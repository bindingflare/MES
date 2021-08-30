using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edcore.GanttChart
{
    public class ModelledTask
    {
        private ProjectManager m_Manager;
        private Task m_Task;

        public object ID { get; internal set; }

        public object ParentID { get; set; }

        public string Text { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public DateTime BaselineStartDate { get; set; }

        public DateTime BaselineFinishDate { get; set; }

        public TimeSpan TimeDuration { get; set; }

        public Single Progress { get; set; }

        public TimeSpan Delay { get; set; }

        public Task Parent { get; internal set; }

        public IEnumerable<Task> Children { get; set; }

        public string Tooltip { get; set; }

        public ModelledTask(Task task, ProjectManager manager)
        {
            this.m_Manager = manager;
            this.m_Task = task;

            Update();
        }

        public void Update()
        {
            ID = m_Task.ID;
            // Parent
            if (m_Manager.IsMember(m_Task))
            {
                Parent = m_Manager.DirectGroupOf(m_Task);
                ParentID = Parent.ID;
            }
            Children = m_Task.Children;

            // Delay
            Delay = m_Task.Delay;
            TimeDuration = m_Task.Duration;
            // Baseline
            BaselineStartDate = m_Manager.Start + m_Task.Start;
            BaselineFinishDate = m_Manager.Start + m_Task.End;
            // Task
            StartDate = BaselineStartDate;
            FinishDate = BaselineFinishDate + Delay;

            Text = m_Task.Name;
            Tooltip = m_Task.Complete.ToString("p");
            Progress = m_Task.Complete * 100;
        }
    }
}
