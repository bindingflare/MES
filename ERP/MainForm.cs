using Edcore.GanttChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class MainForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        ProjectManager m_Manager = null;

        public MainForm()
        {
            InitializeComponent();

            // Create a Project
            m_Manager = new ProjectManager("256K DRAM 7월 진척현황");

            // Perform some task operations
            m_Manager.AddCustomField("Greeting", typeof(string), 80);
            m_Manager.AddCustomField("Cancelled", typeof(string), 80);
            m_Manager.AddCustomField("Important", typeof(bool), 80);

            var work = new MyTask(m_Manager) { Name = "Prepare for Work" };
            var wake = new MyTask(m_Manager) { Name = "Wake Up" };
            var teeth = new MyTask(m_Manager) { Name = "Brush Teeth" };
            var shower = new MyTask(m_Manager) { Name = "Shower" };
            var clothes = new MyTask(m_Manager) { Name = "Change into New Clothes" };
            var hair = new MyTask(m_Manager) { Name = "Blow My Hair" };
            var pack = new MyTask(m_Manager) { Name = "Pack the Suitcase" };

            m_Manager.Add(work);
            m_Manager.Add(wake);
            m_Manager.Add(teeth);
            m_Manager.Add(shower);
            m_Manager.Add(clothes);
            m_Manager.Add(hair);
            m_Manager.Add(pack);

            m_Manager.SetField(work, 7, "Hello");
            m_Manager.SetField(wake, 7, "HI");
            m_Manager.SetField(teeth, 7, "hey");
            m_Manager.SetField(shower, 7, "Yo");
            m_Manager.SetField(clothes, 7, "Greetings");
            m_Manager.SetField(hair, 7, "Good morning");
            m_Manager.SetField(pack, 7, "Good evening");

            var job1 = new MyTask(m_Manager) { Name = "Job1" };
            var job2 = new MyTask(m_Manager) { Name = "Job2" };
            var job3 = new MyTask(m_Manager) { Name = "Brush Teeth" };
            var job4 = new MyTask(m_Manager) { Name = "JOb4" };
            var job5 = new MyTask(m_Manager) { Name = "JOb 5" };
            var job6 = new MyTask(m_Manager) { Name = "job 6" };
            var job7 = new MyTask(m_Manager) { Name = "end job" };

            m_Manager.Add(job1);
            m_Manager.Add(job2);
            m_Manager.Add(job3);
            m_Manager.Add(job4);
            m_Manager.Add(job5);
            m_Manager.Add(job6);
            m_Manager.Add(job7);

            m_Manager.SetField(job1, 7, "Hello");
            m_Manager.SetField(job2, 7, "HI");
            m_Manager.SetField(job3, 7, "hey");
            m_Manager.SetField(job4, 7, "Yo");
            m_Manager.SetField(job5, 7, "Greetings");
            m_Manager.SetField(job6, 7, "Good morning");
            m_Manager.SetField(job7, 7, "Good evening");

            //m_Manager.SetField(work, "Important", "Yes");

            // Test delay
            m_Manager.SetDelay(job2, new TimeSpan(3, 0, 0, 0));
            m_Manager.SetDelay(job3, new TimeSpan(1, 0, 0, 0));
            m_Manager.SetDelay(job4, new TimeSpan(7, 0, 0, 0));
            m_Manager.SetDelay(job7, new TimeSpan(3, 0, 0, 0));

            // Create another 1000 tasks for stress testing
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var task = new MyTask(m_Manager) { Name = string.Format("New Task {0}", i.ToString()) };
                m_Manager.Add(task);
                m_Manager.SetStart(task, TimeSpan.FromDays(rand.Next(100)));
                m_Manager.SetDuration(task, TimeSpan.FromDays(rand.Next(50)));
            }

            // Set task durations, e.g. using ProjectManager methods 
            m_Manager.SetDuration(wake, TimeSpan.FromDays(3));
            m_Manager.SetDuration(teeth, TimeSpan.FromDays(5));
            m_Manager.SetDuration(shower, TimeSpan.FromDays(7));
            m_Manager.SetDuration(clothes, TimeSpan.FromDays(4));
            m_Manager.SetDuration(hair, TimeSpan.FromDays(3));
            m_Manager.SetDuration(pack, TimeSpan.FromDays(5));
            m_Manager.SetDuration(job2, TimeSpan.FromDays(3));
            m_Manager.SetDuration(job3, TimeSpan.FromDays(5));
            m_Manager.SetDuration(job4, TimeSpan.FromDays(7));
            m_Manager.SetDuration(job5, TimeSpan.FromDays(4));
            m_Manager.SetDuration(job6, TimeSpan.FromDays(3));
            m_Manager.SetDuration(job7, TimeSpan.FromDays(5));

            // demostrate splitting a task
            m_Manager.Split(pack, new MyTask(m_Manager), new MyTask(m_Manager), TimeSpan.FromDays(2));
            m_Manager.Split(job7, new MyTask(m_Manager), new MyTask(m_Manager), TimeSpan.FromDays(2));

            // Set task complete status, e.g. using newly created properties
            wake.Complete = 0.9f;
            teeth.Complete = 0.5f;
            shower.Complete = 0.4f;

            job2.Complete = 0.9f;
            job3.Complete = 0.5f;
            job4.Complete = 0.4f;

            // Give the Tasks some organisation, setting group and precedents
            m_Manager.Group(work, wake);
            m_Manager.Group(work, teeth);
            m_Manager.Group(work, shower);
            m_Manager.Group(work, clothes);
            m_Manager.Group(work, hair);
            m_Manager.Group(work, pack);
            m_Manager.Relate(wake, teeth);
            m_Manager.Relate(wake, shower);
            m_Manager.Relate(shower, clothes);
            m_Manager.Relate(shower, hair);
            m_Manager.Relate(hair, pack);
            m_Manager.Relate(clothes, pack);

            m_Manager.Group(job1, job2);
            m_Manager.Group(job1, job3);
            m_Manager.Group(job1, job4);
            m_Manager.Group(job1, job5);
            //m_Manager.Group(job1, job6);
            m_Manager.Group(job1, job7);
            m_Manager.Relate(job2, job3);
            m_Manager.Relate(job2, job4);
            m_Manager.Relate(job4, job5);
            //m_Manager.Relate(job4, job6);
            //m_Manager.Relate(job6, job7);
            m_Manager.Relate(job5, job7);

            // Build tasklist
            IEnumerable<Task> tasks = m_Manager.RootTasks;
            foreach (Task task in tasks)
            {
                task.Children = m_Manager.DirectMembersOf(task);
                if (task.Children.Count() != 0)
                {
                    task.CanExpand = true;
                }
            }

            ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            ganttControl1.ChartMappings.DurationFieldName = "Duration";
            ganttControl1.ChartMappings.TextFieldName = "Text";
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Text";
            ganttControl1.DataSource = GetTasks();

            // Set Time information
            var span = DateTime.Today - m_Manager.Start;
            m_Manager.Now = span; // set the "Now" marker at the correct date
        }

        private object GetTasks()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(m_Manager.HeaderList.ToArray());
            
            foreach (Task task in m_Manager.Tasks)
            {
                ModelledTask mTask = new ModelledTask(task, m_Manager);

                DataRow row = table.NewRow();
                row["Text"] = task.Name;
                row["ID"] = task.ID;
                if (m_Manager.IsMember(task)) row["ParentID"] = m_Manager.DirectGroupOf(task).ID;
                row["StartDate"] = m_Manager.Start + task.Start;
                row["FinishDate"] = m_Manager.Start + task.End;
                row["Duration"] = task.Duration;
                row["Tooltip"] = task.Complete.ToString("p") + " done";
                row["Progress"] = task.Complete;
                table.Rows.Add(row);
            }

            List<ModelledTask> tasks = new List<ModelledTask>();
            foreach (Task task in m_Manager.Tasks)
            {
                tasks.Add(new ModelledTask(task, m_Manager));
            }

            return table;
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage2;
        }

        private void tileInventory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage3;
        }

        private void tileEventM_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage4;
        }
    }

    /// <summary>
    /// A custom task of your own type deriving from the Task interface (optional)
    /// </summary>
    [Serializable]
    public class MyTask : Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }

        private ProjectManager Manager { get; set; }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }
}
