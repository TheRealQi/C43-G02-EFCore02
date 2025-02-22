using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class Instructor
    {
        #region Convention

        // public int ID { get; set; }
        // public string Name { get; set; }
        // public int? Bouns { get; set; }
        // public decimal Salary { get; set; }
        // public string? Adress { get; set; }
        // public decimal HourRate { get; set; }
        // public int Dept_ID { get; set; }
        
        // public Department Department { get; set; } = null!;
        // public Department ManagedDepartment { get; set; }
        // public ICollection<CourseInstructor> CourseInstructors { get; set; }

        #endregion

        #region Data Annotations

        // [Key]
        // public int ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "varchar")]
        // [StringLength(50, MinimumLength = 3)]
        // public string Name { get; set; }
        //
        // public int? Bouns { get; set; }
        //
        // [Required]
        // [Column(TypeName = "decimal(10,2)")]
        // public decimal Salary { get; set; }
        //
        // [Column(TypeName = "varchar")]
        // [StringLength(100)]
        // public string? Adress { get; set; }
        //
        // [Required]
        // [Column(TypeName = "decimal(10,2)")]
        // public decimal HourRate { get; set; }
        //
        // [Required]
        // [ForeignKey("Department")]
        // public int Dept_ID { get; set; }
        //
        //
        // public Department Department_ { get; set; } = null!;
        // [InverseProperty("Manager")]
        // public Department ManagedDepartment { get; set; }
        // public ICollection<CourseInstructor> CourseInstructors { get; set; }
        
        #endregion
    }
}