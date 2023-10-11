using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [Required]
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default Number Of Days")]
        [Range(1 ,25, ErrorMessage = "Please enter a valid number.")]
        public int DefaultDays { get; set; }
    }
}
