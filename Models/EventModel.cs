using System;
using System.ComponentModel.DataAnnotations;
namespace test1.Models
{
    public class EventModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; } = DateTime.Today;

        [StringLength(500, ErrorMessage = "Description is too long (500 characters max)")]
        public string Description { get; set; } = string.Empty;

        public bool IsOnline { get; set; }
    }
}
