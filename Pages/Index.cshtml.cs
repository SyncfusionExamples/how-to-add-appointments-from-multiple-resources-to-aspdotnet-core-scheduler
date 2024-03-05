using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
namespace DataGrid.Pages
{
    public class AppointmentData
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
       public int ResourceID { get; set; }
    }

    public class ResourceData
    {
        public string OwnerText { set; get; }
        public int OwnerId { set; get; }
        public string Color { set; get; }
    }

    public class IndexModel : PageModel
    { 
        public void OnGet()
        {
           
        }
    }
}


