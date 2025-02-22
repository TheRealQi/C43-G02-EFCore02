using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class StudentCourse
    {
        #region Convention

        // public int Stud_ID { get; set; }
        // public int Course_ID { get; set; }
        // public string Grade { get; set; }
        
        // public Student Student { get; set; } = null!;
        // public Course Course { get; set; } = null!;

        #endregion

        #region Data Annotations

        // [Key]
        // [ForeignKey("Student")]
        // public int Stud_ID { get; set; }
        //
        // [Key]
        // [ForeignKey("Course")]
        // public int Course_ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "char")]
        // [StringLength(2)] // A+, A, A-, B+, B, B-, C+, C, C-, D+, D, D-, F
        // public string Grade { get; set; }
        //
        // public Student Student { get; set; } = null!;
        // public Course Course { get; set; } = null!;

        #endregion
    }
}