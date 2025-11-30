using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Task1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string address { get; set; }
        public string ImageURL { get;  set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }   // Foreign Key

        [ForeignKey("CourseId")]
        public Course Course { get; set; }  // Navigation property

    }
}
