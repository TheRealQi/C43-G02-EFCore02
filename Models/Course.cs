using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class Course
    {
        #region Convention

        // public int ID { get; set; }
        // public int Duration { get; set; }
        // public string Name { get; set; }
        // public string? Description { get; set; }
        // public int Top_ID { get; set; }
        //
        // public Topic Topic { get; set; }
        // public ICollection<StudentCourse> StudentCourses { get; set; }
        // public ICollection<CourseInstructor> CourseInstructors { get; set; }

        #endregion

        #region Data Annotations

        [Key]
        public int ID { get; set; }
        
        [Required]
        [Range(1, 12)]
        public int Duration { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string? Description { get; set; }
        
        [Required]
        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
        
        public Topic Topic { get; set; } = null!;
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; set; }
        
        

        #endregion
    }
}