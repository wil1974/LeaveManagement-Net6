using System.ComponentModel.DataAnnotations;
//using System.Xml.Linq;


//LeaveTypeVM.cs => VM is short for View Model 0 just a naming convention, not syntax
namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name= "Leave Type")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1,25,ErrorMessage = "Please enter Min. 1 day or Max. 25 days")]
        public int DefaultDays { get; set; }
    }
}
