using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type")]
        [Required(ErrorMessage ="Leave type is required")]
        public string Name { get; set; }

        [Display(Name="Default no of Days")]
        [Required(ErrorMessage = "No of Days required")]
        [Range(1, 25, ErrorMessage ="Please enter valid number")]
        public int DefaultDays { get; set; }
    }
}
