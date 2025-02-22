using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class CourseInstructor
    {
        #region Convention

        // public int Inst_ID { get; set; }
        // public int Course_ID { get; set; }
        // public int? Evaluate { get; set; }
        
        // public Instructor Instructor { get; set; } = null!;
        // public Course Course { get; set; } = null!;

        #endregion

        #region Data Annotations

        // [Key]
        // [ForeignKey("Instructor")]
        // public int Inst_ID { get; set; }
        //
        // [Key]
        // [ForeignKey("Course")]
        // public int Course_ID { get; set; }
        //
        // [Range(1, 100)]
        // public int? Evaluate { get; set; }
        //
        // public Instructor Instructor { get; set; } = null!;
        // public Course Course { get; set; } = null!;

        #endregion
    }
}