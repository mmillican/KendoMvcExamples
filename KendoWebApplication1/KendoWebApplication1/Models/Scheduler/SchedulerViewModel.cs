using System;
using System.Collections.Generic;
using Kendo.Mvc.UI;

namespace KendoWebApplication1.Models.Scheduler
{
    public class SchedulerViewModel
    {
        public List<TaskViewModel> Tasks { get; set; }

        public SchedulerViewModel()
        {
            Tasks = new List<TaskViewModel>();
        }
    }

    public class TaskViewModel : ISchedulerEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
    }
}