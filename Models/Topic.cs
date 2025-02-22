using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi2.Models
{
    public class Topic
    {
        #region Convention

        // public int ID { get; set; }
        // public string Name { get; set; }
        //
        // public ICollection<Course> Courses { get; set; }

        #endregion

        #region Data Annotations

        // [Key]
        // public int ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "varchar")]
        // [StringLength(100,  MinimumLength = 3)]
        // public string Name { get; set; }
        
        // public ICollection<Course> Courses { get; set; }

        #endregion
    }
}