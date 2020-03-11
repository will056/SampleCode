using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Model
{
    [Table("APP_WEB_USER.EXECUTED_W_J_INDIGO")]
    public partial class IndigoWorkJournalEF:IId
    {
        [Key]
        [Column("FK_EXECUTED_WORKS_JOURNAL")]
        public int Id { get; set; }

        [Column("MACHINE_OPERATION")]
        public int MachineOperation { get; set; }

        [Column("OWN_TURN")]
        [StringLength(1)]
        public string OwnTurn { get; set; }

        [Column("COUNT_SHEET", TypeName = "float")]
        public int? CountSheet { get; set; }

        [Column("SHEET_FORMAT")]
        [StringLength(50)]
        public string SheetFormat { get; set; }

        [Column("TECHNICAL_WASTE", TypeName = "float")]
        public int? TechnicalWaste { get; set; }

        [Column("COUNT_PRODUCT", TypeName = "float")]
        public int? Count { get; set; }

        [Column("MATERIAL")]
        [StringLength(300)]
        public string Material { get; set; }

        [Column("LUMINOSITY")]
        public int? Luminosity { get; set; }

        [Column("RANGE_SHEET")]
        [StringLength(100)]
        public string RangeSheet { get; set; }

        [Column("CLICK_COUNTER")]
        public decimal? ClickCounter { get; set; }

        [Column("COMPLETED")]
        [StringLength(1)]
        public string Completed { get; set; }

        [Column("IS_FACE")]
        [StringLength(1)]
        public string IsFace { get; set; }

        [Column("PRODUCTS_ON_ONE_SHEET", TypeName = "float")]
        public int? ProductsOnOneSheet { get; set; }

        [Column("EXECUTED_WORKS_JOURNAL")]
        public virtual ExecutedWorkJournal EXECUTED_WORKS_JOURNAL { get; set; }

        [Column("REF_MACHINE_OPERATION")]
        public virtual RefMachineOperation REF_MACHINE_OPERATION { get; set; }

        [Column("REF_SHEET_FORMAT")]
        public virtual RefSheetFormat REF_SHEET_FORMAT { get; set; }
    }
}
