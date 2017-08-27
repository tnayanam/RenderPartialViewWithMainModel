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
    }
}