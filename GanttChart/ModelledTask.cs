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

        string ID { get; set; }

        Task Parent { get; set; }

        IEnumerable<Task> Children { get; set; }

        DateTime StartDate { get; set; }

        DateTime FinishDate { get; set; }

        TimeSpan Duration { get; set; }

        string Text { get; set; }

        Single Progress { get; set; }

        public ModelledTask(Task task, ProjectManager manager)
        {
            this.m_Manager = manager;
            this.m_Task = task;

            ID = task.ID;
            Children = task.Children;
            StartDate = manager.Start + task.Start;
            FinishDate = manager.Start + task.End;
            Duration = task.Duration;
            Text = task.Complete.ToString("p");
            Progress = task.Complete;
        }

        public void Update()
        {
            Children = m_Task.Children;
            StartDate = m_Manager.Start + m_Task.Start;
            FinishDate = m_Manager.Start + m_Task.End;
            Duration = m_Task.Duration;
            Text = m_Task.Complete.ToString("p");
            Progress = m_Task.Complete;
        }
    }
}
