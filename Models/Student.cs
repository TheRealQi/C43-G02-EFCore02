using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class Student
    {
        #region Convention

        // public int ID { get; set; }
        // public string FName { get; set; }
        // public string LName { get; set; }
        // public string? Address { get; set; }
        // public string Age { get; set; }
        // public int Dep_ID { get; set; }
        //
        // public Department Department { get; set; } = null!;
        // public ICollection<StudentCourse> StudentCourses { get; set; }
        

        #endregion


        #region Data Annotations
        //
        // [Key]
        // public int ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "varchar")]
        // [StringLength(50, MinimumLength = 3)]
        // public string FName { get; set; }
        //
        // [Required]
        // [Column(TypeName = "varchar")]
        // [StringLength(50, MinimumLength = 3)]
        // public string LName { get; set; }
        //
        // [MaxLength(100)]
        // public string? Address { get; set; }
        //
        // [Required]
        // [Range(18, 100)]
        // public int Age { get; set; }
        //
        // [Required]
        // [ForeignKey("Department")]
        // public int Dep_ID { get; set; }
        //
        // public Department Department { get; set; } = null!;
        // public ICollection<StudentCourse> StudentCourses { get; set; }
        //
        #endregion
    }
}