using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Model
{
    [Table("APP_WEB_USER.REF_PLASTIC")]
    public class RefPlastic : IId
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [Index(IsUnique = true)]
        [StringLength(300)]

        [Required]
        public string Name { get; set; }

        [Column("WIDTH_AND_HEIGHT")]
        [StringLength(50)]
        [Required]
        public string WidthAndHeight { get; set; }

        [Column("DENSITY", TypeName = "float")]
        [Required]
        public decimal Density { get; set; }

        [Column("HOLOGRAPHIC")]
        [StringLength(1)]
        [Required]
        public string Holographic { get; set; }

        [Column("ULTRAVIOLET_LIGHT")]
        [StringLength(1)]
        [Required]
        public string UltravioletLight { get; set; }
        public virtual RefSheetFormat REF_SHEET_FORMAT { get; set; }

    }
}
