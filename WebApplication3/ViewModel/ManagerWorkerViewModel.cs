using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication3.ViewModel
{
    public class ManagerWorkerViewModel
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }
        public IEnumerable<SelectListItem> Managers { get; set; }
        // ths will nto work
        //public int ManagerId { get; set; }
        // so making is Nullable
        public int? ManagerId { get; set; }

        // it will show the default value
        public DateTime dateTime { get; set; }

        // it will not show the default value
        public DateTime? dateTimeNoDefault { get; set; }


    }
}