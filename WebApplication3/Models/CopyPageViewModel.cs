using System.Collections.Generic;
// this page belongs to which copy type pf reatinship
using System.Web.Mvc;
namespace WebApplication3.Models
{
    public class CopyPageViewModel
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public int CopyId { get; set; }
        public IEnumerable<SelectListItem> Copies { get; set; }
    }
}