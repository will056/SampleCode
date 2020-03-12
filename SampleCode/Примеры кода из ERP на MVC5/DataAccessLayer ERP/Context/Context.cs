using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Context
{
    public partial class MainContext : DbContext
    {
        public MainContext()
            : base("name=CodeFirstContext")
        {
        }

        public MainContext(bool lazyLoadingEnabled) : base("name=CodeFirstContext")
        {
            this.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        public MainContext(DbConnection dbConnection) : base(dbConnection, contextOwnsConnection: true)
        {
        }

        public MainContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
        public static MainContext Create()
        {
            return new MainContext(false);
        }
        public virtual DbSet<ListUsersKirkRudy> ListUsersKirkRudy { get; set; }
        public virtual DbSet<KirkRudyWorksJournal> ExecutedWorksJournaKirkRudies { get; set; }
        public virtual DbSet<CHIP_IMPLANT_ORDER> CHIP_IMPLANT_ORDER { get; set; }
        public virtual DbSet<COATED_MATERIAL> COATED_MATERIAL { get; set; }
        public virtual DbSet<AtlanticWorksJournal> EXECUTED_W_J_ATLANTIC { get; set; }
        public virtual DbSet<CassiloWorksJournal> EXECUTED_W_J_CASSILO { get; set; }
        public virtual DbSet<EXECUTED_W_J_CUTTING_DOWN> EXECUTED_W_J_CUTTING_DOWN { get; set; }
        public virtual DbSet<EmbossersWorksJournal> EXECUTED_W_J_EMBOSSERS { get; set; }
        public virtual DbSet<ImplantationWorksJournal> EXECUTED_W_J_IMPLANTATION_YMJ { get; set; }
        public virtual DbSet<IndigoWorkJournalEF> EXECUTED_W_J_INDIGO { get; set; }
        public virtual DbSet<InterruptionDefectiveWJ> EXECUTED_W_J_INTER_DEFECTIVE { get; set; }
        public virtual DbSet<EXECUTED_W_J_LAMINATION> EXECUTED_W_J_LAMINATION { get; set; }
        public virtual DbSet<MailOkWorksJournal> EXECUTED_W_J_MAIL_OK { get; set; }
        public virtual DbSet<ManualCodingWorksJournal> EXECUTED_W_J_MANUAL_CODING { get; set; }
        public virtual DbSet<MGIWorksJournal> EXECUTED_W_J_MGI { get; set; }
        public virtual DbSet<OffsetPrintingWorkJournalEF> EXECUTED_W_J_OFFSET_PRINTING { get; set; }
        public virtual DbSet<OKKWorksJournal> EXECUTED_W_J_OKK { get; set; }
        public virtual DbSet<OKKPackLoyaltyKitsWorksJournal> EXECUTED_W_J_PACK_LOYALTY_KITS { get; set; }
        public virtual DbSet<EXECUTED_W_J_PACKAGE_BUILDING> EXECUTED_W_J_PACKAGE_BUILDING { get; set; }
        public virtual DbSet<EXECUTED_W_J_PLEXTOR> EXECUTED_W_J_PLEXTOR { get; set; }
        public virtual DbSet<RoleAccessWorksJournal> EXECUTED_W_J_ROLE_ACCESS { get; set; }
        public virtual DbSet<EXECUTED_W_J_SILK_STENCIL> EXECUTED_W_J_SILK_STENCIL { get; set; }
        public virtual DbSet<EXECUTED_W_J_STAMPING> EXECUTED_W_J_STAMPING { get; set; }
        public virtual DbSet<ExecutedWorkJournal> EXECUTED_WORKS_JOURNAL { get; set; }
        public virtual DbSet<GET_CARD_CHIP_IMPLANT> GET_CARD_CHIP_IMPLANT { get; set; }
        public virtual DbSet<GET_CARD_HOT_ORDER> GET_CARD_HOT_ORDER { get; set; }
        public virtual DbSet<HOT_ORDER> HOT_ORDER { get; set; }
        public virtual DbSet<ISSUED_MATERIAL> ISSUED_MATERIAL { get; set; }
        public virtual DbSet<MechanicJournal> MECHANICS_JOURNAL { get; set; }
        public virtual DbSet<MechanicOrderWork> MECHANICS_JOURNAL_WORK { get; set; }
        public virtual DbSet<ORDER_BARCODE> ORDER_BARCODE { get; set; }
        public virtual DbSet<ORDER_CARD_PRODUCTS> ORDER_CARD_PRODUCTS { get; set; }
        public virtual DbSet<ORDER_LAMINATION> ORDER_LAMINATION { get; set; }
        public virtual DbSet<ORDER_LAYER_SHEET_COMPOSITION> ORDER_LAYER_SHEET_COMPOSITION { get; set; }
        public virtual DbSet<ORDER_LAYOUT> ORDER_LAYOUT { get; set; }
        public virtual DbSet<ORDER_MAIN_INFO> ORDER_MAIN_INFO { get; set; }
        public virtual DbSet<ORDER_SCREEN_PRINTING> ORDER_SCREEN_PRINTING { get; set; }
        public virtual DbSet<RECEIVED_MATERIAL> RECEIVED_MATERIAL { get; set; }
        public virtual DbSet<RefAntennaType> REF_ANTENNA_TYPE { get; set; }
        public virtual DbSet<REF_BARCODE> REF_BARCODE { get; set; }
        public virtual DbSet<REF_CARD_FORMAT> REF_CARD_FORMAT { get; set; }
        public virtual DbSet<REF_CONTACTLESS_INTERFACE> REF_CONTACTLESS_INTERFACE { get; set; }
        public virtual DbSet<RefDepart> REF_DEPART { get; set; }
        public virtual DbSet<REF_HOLOGRAM> REF_HOLOGRAM { get; set; }
        public virtual DbSet<RefMachine> REF_MACHINE { get; set; }
        public virtual DbSet<RefMachineOperation> REF_MACHINE_OPERATION { get; set; }
        public virtual DbSet<REF_MAGNETIC_STRIP> REF_MAGNETIC_STRIP { get; set; }
        public virtual DbSet<REF_MEMBER_EXCHANGE_MATERIAL> REF_MEMBER_EXCHANGE_MATERIAL { get; set; }
        public virtual DbSet<REF_NON_CARD_PRODUCTS> REF_NON_CARD_PRODUCTS { get; set; }
        public virtual DbSet<REF_OVERLAY> REF_OVERLAY { get; set; }
        public virtual DbSet<RefPageLayer> REF_PAGE_LAYER { get; set; }
        public virtual DbSet<REF_SEMIFINISHED> REF_SEMIFINISHED { get; set; }
        public virtual DbSet<RefSheetFormat> REF_SHEET_FORMAT { get; set; }
        public virtual DbSet<REF_SIGNATURE_STRIP> REF_SIGNATURE_STRIP { get; set; }
        public virtual DbSet<REF_STAGE_CHIP_IMPLANT> REF_STAGE_CHIP_IMPLANT { get; set; }
        public virtual DbSet<REF_STAGE_COATED_MATERIAL> REF_STAGE_COATED_MATERIAL { get; set; }
        public virtual DbSet<REF_TYPE_BANK_CARD> REF_TYPE_BANK_CARD { get; set; }
        public virtual DbSet<REF_TYPE_CARD_MATERIAL> REF_TYPE_CARD_MATERIAL { get; set; }
        public virtual DbSet<REF_TYPE_LAYER_SHEET> REF_TYPE_LAYER_SHEET { get; set; }
        public virtual DbSet<REF_TYPE_OPERATION_CARD> REF_TYPE_OPERATION_CARD { get; set; }
        public virtual DbSet<RefTypeOrder> REF_TYPE_ORDER { get; set; }
        public virtual DbSet<RefWire> REF_WIRE { get; set; }
        public virtual DbSet<SOLVENT> SOLVENTs { get; set; }
        public virtual DbSet<TransferJournalCard> TRANSFER_JOURNA_CARD { get; set; }
        public virtual DbSet<TransferJournalCardRoute> TRANSFER_JOURNAL_ROUTE { get; set; }
        public virtual DbSet<TransferJournalSheet> TRANSFER_JOURNAL_SHEET { get; set; }
        public virtual DbSet<TRANSFERRED_AFTER_CHIP_IMPLANT> TRANSFERRED_AFTER_CHIP_IMPLANT { get; set; }
        public virtual DbSet<TRANSFERRED_AFTER_MILLING> TRANSFERRED_AFTER_MILLING { get; set; }
        public virtual DbSet<TRANSFERRED_DESTR_CHIP_IMPLANT> TRANSFERRED_DESTR_CHIP_IMPLANT { get; set; }
        public virtual DbSet<TRANSFERRED_HOT_ORDER> TRANSFERRED_HOT_ORDER { get; set; }
        public virtual DbSet<TRANSFERRED_MATERIAL> TRANSFERRED_MATERIAL { get; set; }
        public virtual DbSet<USED_HOLOGRAM> USED_HOLOGRAM { get; set; }
        public virtual DbSet<UserMachine> UserMachines { get; set; }
        public virtual DbSet<AllAtlantic> ALL_ATLANCTIC_W_J { get; set; }
        public virtual DbSet<AllEmbossers> ALL_EMBOSSERS_W_J { get; set; }
        public virtual DbSet<AllMGI> ALL_EXECUTED_W_J_MGI { get; set; }
        public virtual DbSet<AllOKK> ALL_EXECUTED_W_J_OKK { get; set; }
        public virtual DbSet<AllImplantation> ALL_IMPLANTATION_YMJ_W_J { get; set; }
        public virtual DbSet<AllInterruptionDefective> ALL_INTER_DEFECTIVE { get; set; }
        public virtual DbSet<AllMailOk> ALL_MAIL_OKK { get; set; }
        public virtual DbSet<AllMechinecsJournal> ALL_MECHANICS_JOURNAL { get; set; }
        public virtual DbSet<AllMechinecsJournalWork> ALL_MECHANICS_JOURNAL_WORK { get; set; }
        public virtual DbSet<AllReportEWByOrder> ALL_REPORT_E_W_BY_ORDER { get; set; }
        public virtual DbSet<AllTransferJornal> ALL_TRANSFER_JOURNAL { get; set; }
        public virtual DbSet<ALL_TRANSFER_JOURNAL1> ALL_TRANSFER_JOURNAL1 { get; set; }
        public virtual DbSet<ORDER_STRICT_MATERIALS> ORDER_STRICT_MATERIALS { get; set; }
        public virtual DbSet<PARAMETER_DEFECT> PARAMETER_DEFECT { get; set; }
        public virtual DbSet<TEMP_REPORT_EXECUTED_W_J> TEMP_REPORT_EXECUTED_W_J { get; set; }
        public virtual DbSet<TRAN_STORAGE_CHIP_IMPLANT> TRAN_STORAGE_CHIP_IMPLANT { get; set; }
        public virtual DbSet<AllCassilo> ALL_EXECUTED_W_J_CASSILO { get; set; }
        public virtual DbSet<AllKirkRudy> AllKirkRudies { get; set; }
        public virtual DbSet<AllManualCoding> ALL_EXECUTED_W_J_MANUAL_CODING { get; set; }
        public virtual DbSet<AllPackLoyaltyKits> ALL_EXECUTED_W_J_PACK_LOY_KITS { get; set; }
        public virtual DbSet<ALL_REPORT_PRINT> ALL_REPORT_PRINT { get; set; }
        public virtual DbSet<ALL_REPORT_SILKPRINTING> ALL_REPORT_SILKPRINTING { get; set; }
        public virtual DbSet<OrderFile> OrderFiles { get; set; }
        public virtual DbSet<FMFolder> FMPaths { get; set; }
        public virtual DbSet<FMFile> FMFiles { get; set; }
        public virtual DbSet<FMDirectory> FMDirectories { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationUser> NotificationUsers { get; set; }
        public virtual DbSet<RefTypeNotification> RefTypeNotifications { get; set; }
        public virtual DbSet<AllExecutedWorksJournalUser> AllExecutedWorksJournalUser { get; set; }
        public virtual DbSet<PrepressWorksJournal> PrepressWorksJournal { get; set; }
        public virtual DbSet<AllPrepress> AllPrepress { get; set; }
        public virtual DbSet<HousekeepingOrderWork> HousekeepingOrderWorks { get; set; }
        public virtual DbSet<HousekeepingJournal> HousekeepingJournals { get; set; }
        public virtual DbSet<AllHousekeepingJournal> AllHousekeepingJournals { get; set; }
        public virtual DbSet<AllHousekeepingJournalWork> AllHousekeepingJournalsWork { get; set; }
        public virtual DbSet<AllElectricianJournal> AllElectricianJournals { get; set; }
        public virtual DbSet<AllElectricianJournalWork> ElectricianJournalWorks { get; set; }
        public virtual DbSet<RefWindingMethod> RefWindingMethod { get; set; }
        public virtual DbSet<RefPlastic> RefPlastic { get; set; }
        public virtual DbSet<AllOPIAntennaWindingWorkJournal> AllAntennaWindingWorkJournals { get; set; }
        public virtual DbSet<OPIImplantationWorksJournal> OPIImplantationWorksJournals { get; set; }
        public virtual DbSet<RefChip> RefChips { get; set; }
        public virtual DbSet<RefColorChip> RefColorChips { get; set; }
        public virtual DbSet<AllOPIImplantationWorksJournal> AllOPIImplantationWorksJournals { get; set; }
        public virtual DbSet<AllOPIWeldingWorksJournal> AllOPIWeldingWorksJournals { get; set; }
        public virtual DbSet<AllOPIReWeldingWorksJournal> AllOPIReWeldingWorksJournals { get; set; }
        public virtual DbSet<AllOPIPackageBuildingWorkJournal> AllOPIPackageBuildingWorkJournals { get; set; }
        public virtual DbSet<OPIWorkJournal> OPIWorkJournals { get; set; }
        public virtual DbSet<AllOPILaminationWorksJournal> AllOPILaminationWorksJournals { get; set; }

        public virtual DbSet<ReportOPPOiU> ReportOPPOiUs { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("APP_WEB_USER");


            modelBuilder.Entity<Notification>()
                .HasMany(u => u.NotificationUsers)
                .WithRequired(u => u.Notification)
                .HasForeignKey(u => u.NotificationId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<RefTypeNotification>()
                .HasMany(u => u.Notifications)
                .WithRequired(u => u.RefTypeNotification)
                .HasForeignKey(u => u.RefTypeId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<ListUsersKirkRudy>()
                .HasRequired(u => u.KirkRudy)
                .WithMany(u => u.ListUsersKirkRudy)
                .HasForeignKey(u => u.FkKirkRudy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KirkRudyWorksJournal>()
                .HasRequired(u => u.ExecutedWorksJournal)
                .WithOptional(u => u.ExecutedWorksJournaKirkRudy)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<KirkRudyWorksJournal>()
                .HasMany(u => u.ListUsersKirkRudy)
                .WithRequired(u => u.KirkRudy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FMFolder>()
                .HasMany(u => u.FMFiles)
                .WithRequired(u => u.FMOPath)
                .HasForeignKey(u => u.FolderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FMDirectory>()
               .HasMany(u => u.FMPaths)
               .WithRequired(u => u.Directory)
               .HasForeignKey(u => u.DirectoryId)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<CHIP_IMPLANT_ORDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CHIP_IMPLANT_ORDER>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<CHIP_IMPLANT_ORDER>()
                .HasMany(e => e.TRANSFERRED_DESTR_CHIP_IMPLANT)
                .WithRequired(e => e.CHIP_IMPLANT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_CHIP_IMPLANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHIP_IMPLANT_ORDER>()
                .HasMany(e => e.GET_CARD_CHIP_IMPLANT)
                .WithRequired(e => e.CHIP_IMPLANT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_CHIP_IMPLANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHIP_IMPLANT_ORDER>()
                .HasMany(e => e.TRANSFERRED_AFTER_MILLING)
                .WithRequired(e => e.CHIP_IMPLANT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_CHIP_IMPLANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COATED_MATERIAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COATED_MATERIAL>()
                .Property(e => e.FK_NUMBER_HOT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COATED_MATERIAL>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COATED_MATERIAL>()
                .Property(e => e.STAGE)
                .IsUnicode(false);

            modelBuilder.Entity<COATED_MATERIAL>()
                .Property(e => e.HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.Run);

            modelBuilder.Entity<AtlanticWorksJournal>()
                .Property(e => e.WorkMode)
                ;

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal)
                ;

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.BeginRange)
                ;

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.EndRange)
                ;

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.Thousand);

            modelBuilder.Entity<CassiloWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<CassiloWorksJournal>()
               .HasRequired(u => u.EXECUTED_WORKS_JOURNAL)
               .WithOptional(u => u.EXECUTED_W_J_CASSILO);

            modelBuilder.Entity<EXECUTED_W_J_CUTTING_DOWN>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_CUTTING_DOWN>()
                .Property(e => e.COUNT);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.MachineOperation1);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.BeginRange)
                ;

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.EndRange)
                ;

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.Run)
                ;

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.WorkMode)
                ;

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.MachineOperation2);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.MachineOperation3);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.MachineOperation4);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .Property(e => e.MachineOperation5);

            modelBuilder.Entity<EmbossersWorksJournal>()
                .HasRequired(u => u.ExcecutedWorksJournal)
                .WithOptional(u => u.EXECUTED_W_J_EMBOSSERS);

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.CountDeadChip)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.CountNotch)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.MachineOperation)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.CountNotchWithChip)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.CountDefectAntenna)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.CountDefectAntennaWithChip)
                ;

            modelBuilder.Entity<ImplantationWorksJournal>()
                .Property(e => e.FkAntennaType)
                ;

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.FkExecutedWorksJournal)
                ;

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.OwnTurn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.CountSheet);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.SheetFormat)
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.TechnicalWaste);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.Count);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.Luminosity);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.RangeSheet)
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.ClickCounter)
                .HasPrecision(38, 0);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.Completed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.IsFace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IndigoWorkJournalEF>()
                .Property(e => e.ProductsOnOneSheet);

            modelBuilder.Entity<InterruptionDefectiveWJ>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<InterruptionDefectiveWJ>()
                .Property(e => e.Count);

            modelBuilder.Entity<EXECUTED_W_J_LAMINATION>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_LAMINATION>()
                .Property(e => e.COUNT_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_LAMINATION>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_LAMINATION>()
                .Property(e => e.COUNT_CARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MailOkWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<MailOkWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MailOkWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.Run);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.WorkMode);

            modelBuilder.Entity<ManualCodingWorksJournal>()
                .Property(e => e.Party);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.OwnTurn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.CountSheet)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.SheetFormat)
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.TechnicalWaste)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.RangeSheet)
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.Completed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.IsFace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MGIWorksJournal>()
                .Property(e => e.ProductsOnOneSheet)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.FkExecutedWorkJournal);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.OwnTurn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.ApprovedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.IssuedSheet);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.CountSheet);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.SheetFormat)
                .IsUnicode(false);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.TechnicalWaste);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.Count);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.Completed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.IsFase)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OffsetPrintingWorkJournalEF>()
                .Property(e => e.ProductsOnOneSheet);

            modelBuilder.Entity<OKKWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<OKKWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OKKWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<OKKWorksJournal>()
                .Property(e => e.CountDefect);

            modelBuilder.Entity<OKKWorksJournal>()
                .HasRequired(u => u.ExcecutedWorksJournal)
                .WithOptional(u => u.EXECUTED_W_J_OKK);

            modelBuilder.Entity<OKKPackLoyaltyKitsWorksJournal>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<OKKPackLoyaltyKitsWorksJournal>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OKKPackLoyaltyKitsWorksJournal>()
                .Property(e => e.MachineOperation);

            modelBuilder.Entity<EXECUTED_W_J_PACKAGE_BUILDING>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_PACKAGE_BUILDING>()
                .Property(e => e.COUNT_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_PACKAGE_BUILDING>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_PACKAGE_BUILDING>()
                .Property(e => e.COUNT_CARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_PACKAGE_BUILDING>()
                .Property(e => e.PARTNER)
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.MACHINE_OPERATION);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.COLOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.COUNT_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.COUNT_PRODUCT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.COMPLETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_PLEXTOR>()
                .Property(e => e.PRODUCTS_ON_ONE_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RoleAccessWorksJournal>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<RoleAccessWorksJournal>()
                .Property(e => e.SavingForOthers)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RoleAccessWorksJournal>()
                .Property(e => e.AccessLevel);

            modelBuilder.Entity<RoleAccessWorksJournal>()
                .Property(e => e.AllMachine)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RoleAccessWorksJournal>()
                .Property(e => e.WorkArea);

            modelBuilder.Entity<RoleAccessWorksJournal>()
              .HasRequired(u => u.REF_WORK_AREA)
              .WithMany(u => u.EXECUTED_W_J_ROLE_ACCESS)
              .HasForeignKey(u => u.WorkArea);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.MACHINE_OPERATION);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.OWN_TURN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.COUNT_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.COUNT_PRODUCT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.COMPLETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.IS_FACE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXECUTED_W_J_SILK_STENCIL>()
                .Property(e => e.PRODUCTS_ON_ONE_SHEET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_STAMPING>()
                .Property(e => e.FK_EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<EXECUTED_W_J_STAMPING>()
                .Property(e => e.COUNT_SIGNATURE_STRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_STAMPING>()
                .Property(e => e.COUNT_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXECUTED_W_J_STAMPING>()
                .Property(e => e.COUNT_PREMIUM_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.Id);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.FkMachine);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.Shift);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.FkOrderLayout);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.Verification)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .Property(e => e.VerificationUserName)
                .IsUnicode(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.AtlanticWorksJournal)
                .WithRequired(e => e.ExcecutedWorksJournal);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_CASSILO)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_CUTTING_DOWN)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_EMBOSSERS)
                .WithRequired(e => e.ExcecutedWorksJournal);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_IMPLANTATION_YMJ)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_INDIGO)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_INTER_DEFECTIVE)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_LAMINATION)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_MAIL_OK)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_MANUAL_CODING)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_MGI)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_OFFSET_PRINTING)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_OKK)
                .WithRequired(e => e.ExcecutedWorksJournal);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_PACK_LOYALTY_KITS)
                .WithRequired(e => e.ExcecutedWorksJournal);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_PACKAGE_BUILDING)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_PLEXTOR)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_SILK_STENCIL)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(e => e.EXECUTED_W_J_STAMPING)
                .WithRequired(e => e.EXECUTED_WORKS_JOURNAL);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasRequired(u => u.ORDER_MAIN_INFO)
                .WithMany(u => u.EXECUTED_WORKS_JOURNAL)
                .HasForeignKey(u => u.NumberOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
                .HasOptional(u => u.ORDER_LAYOUT)
                .WithMany(u => u.EXECUTED_WORKS_JOURNAL)
                .HasForeignKey(u => u.FkOrderLayout)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
               .HasRequired(u => u.REF_MACHINE)
               .WithMany(u => u.EXECUTED_WORKS_JOURNAL)
               .HasForeignKey(u => u.FkMachine)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExecutedWorkJournal>()
   .HasOptional(u => u.EXECUTED_W_J_MAIL_OK)
   .WithRequired(u => u.EXECUTED_WORKS_JOURNAL)
   .WillCascadeOnDelete(false);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.FK_NUMBER_CHIP_IMPLANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.COUNT_CUTTING_DOWN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.COUNT_STORAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.COUNT_OKK_BAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_CHIP_IMPLANT>()
                .Property(e => e.COUNT_OKK_GOOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.FK_NUMBER_HOT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.COUNT_CUTTING_DOWN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.COUNT_STORAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.COUNT_OKK_BAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GET_CARD_HOT_ORDER>()
                .Property(e => e.COUNT_OKK_GOOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOT_ORDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOT_ORDER>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<HOT_ORDER>()
                .HasMany(e => e.GET_CARD_HOT_ORDER)
                .WithRequired(e => e.HOT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_HOT_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOT_ORDER>()
                .HasMany(e => e.TRANSFERRED_HOT_ORDER)
                .WithRequired(e => e.HOT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_HOT_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOT_ORDER>()
                .HasMany(e => e.USED_HOLOGRAM)
                .WithRequired(e => e.HOT_ORDER)
                .HasForeignKey(e => e.FK_NUMBER_HOT_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.CHIP)
                .IsUnicode(false);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.COUNT_ROLLS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.USER_NAME_ISSUED_MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ISSUED_MATERIAL>()
                .Property(e => e.DEPART_RECEIVED)
                .IsUnicode(false);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.Id);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.IdMachine);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.DescriptionProblem)
                .IsUnicode(false);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.ImportanceLevel);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.NotePerformer)
                .IsUnicode(false);

            modelBuilder.Entity<MechanicJournal>()
                .Property(e => e.UserCreater)
                .IsUnicode(false);

            modelBuilder.Entity<MechanicJournal>()
                .HasMany(e => e.MECHANICS_JOURNAL_WORK)
                .WithRequired(e => e.MECHANICS_JOURNAL)
                .HasForeignKey(e => e.FkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.Id);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.FkOrder);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.OffHour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.Status);

            modelBuilder.Entity<MechanicOrderWork>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BARCODE>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BARCODE>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BARCODE>()
                .Property(e => e.OPEN)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BARCODE>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_CARD_PRODUCTS>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_CARD_PRODUCTS>()
                .Property(e => e.TYPE_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_CARD_PRODUCTS>()
                .Property(e => e.TYPE_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_CARD_PRODUCTS>()
                .Property(e => e.SIZE_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_CARD_PRODUCTS>()
                .Property(e => e.TYPE_CARD_MATERIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDER_LAMINATION>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAMINATION>()
                .Property(e => e.FACE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAMINATION>()
                .Property(e => e.BACK)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.FK_REF_PLASTIC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.FK_REF_OVERLAY)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.FK_REF_SEMIFINISHED)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.DENSITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDER_LAYER_SHEET_COMPOSITION>()
                .Property(e => e.SORT_ORDER)
                .HasPrecision(38, 0);


            modelBuilder.Entity<ORDER_LAYOUT>()
                .Property(e => e.ID);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .Property(e => e.IS_BLOCKING)
                .IsFixedLength()
                .IsUnicode(false);

            //modelBuilder.Entity<ORDER_LAYOUT>()
            //    .HasMany(e => e.EXECUTED_WORKS_JOURNAL)
            //    .WithOptional(e => e.)
            //    .HasForeignKey(e => e.FkOrderLayout);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .HasMany(e => e.TRANSFER_JOURNA_CARD)
                .WithOptional(e => e.ORDER_LAYOUT)
                .HasForeignKey(e => e.FkOrderLayout);

            modelBuilder.Entity<ORDER_LAYOUT>()
                .HasMany(e => e.TRANSFER_JOURNAL_SHEET)
                .WithOptional(e => e.ORDER_LAYOUT)
                .HasForeignKey(e => e.FkOrderLayout);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.COUNT);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.IS_BLOCKING)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.SIZE_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.BIN)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.LOGIN_AUDITOR)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .Property(e => e.TYPE_ORDER);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.CHIP_IMPLANT_ORDER)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<ORDER_MAIN_INFO>()
            //    .HasMany(e => e.EXECUTED_WORKS_JOURNAL)
            //    .WithRequired(e => e.ORDER_MAIN_INFO)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.HOT_ORDER)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasOptional(e => e.ORDER_BARCODE)
                .WithRequired(e => e.ORDER_MAIN_INFO);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasOptional(e => e.ORDER_CARD_PRODUCTS)
                .WithRequired(e => e.ORDER_MAIN_INFO);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasOptional(e => e.ORDER_LAMINATION)
                .WithRequired(e => e.ORDER_MAIN_INFO);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.ORDER_LAYER_SHEET_COMPOSITION)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.ORDER_LAYOUT)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.SOLVENTs)
                .WithOptional(e => e.ORDER_MAIN_INFO)
                .HasForeignKey(e => e.NUMBER_ORDER_5);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.SOLVENTs1)
                .WithOptional(e => e.ORDER_MAIN_INFO1)
                .HasForeignKey(e => e.NUMBER_ORDER_4);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.SOLVENTs2)
                .WithOptional(e => e.ORDER_MAIN_INFO2)
                .HasForeignKey(e => e.NUMBER_ORDER_3);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.SOLVENTs3)
                .WithOptional(e => e.ORDER_MAIN_INFO3)
                .HasForeignKey(e => e.NUMBER_ORDER_2);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.SOLVENTs4)
                .WithOptional(e => e.ORDER_MAIN_INFO4)
                .HasForeignKey(e => e.NUMBER_ORDER_1);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.TRANSFER_JOURNA_CARD)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .HasForeignKey(e => e.NumberOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.TRANSFER_JOURNAL_SHEET)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasOptional(e => e.ORDER_SCREEN_PRINTING)
                .WithRequired(e => e.ORDER_MAIN_INFO);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasOptional(e => e.ORDER_STRICT_MATERIALS)
                .WithRequired(e => e.ORDER_MAIN_INFO);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                .HasMany(e => e.PARAMETER_DEFECT)
                .WithRequired(e => e.ORDER_MAIN_INFO)
                .HasForeignKey(e => e.NUM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_MAIN_INFO>()
                 .HasMany(e => e.Directories)
                 .WithRequired(e => e.OrderMainInfo)
                 .HasForeignKey(e => e.NumberOrder)
                 .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_SCREEN_PRINTING>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_SCREEN_PRINTING>()
                .Property(e => e.FACE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_SCREEN_PRINTING>()
                .Property(e => e.BACK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVED_MATERIAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIVED_MATERIAL>()
                .Property(e => e.USER_NAME_RECIPIENT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVED_MATERIAL>()
                .Property(e => e.FK_REF_SEMIFINISHED_OPZ)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVED_MATERIAL>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIVED_MATERIAL>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefAntennaType>()
                .Property(e => e.Id);

            modelBuilder.Entity<RefAntennaType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefAntennaType>()
                .HasMany(e => e.ImplantationYMJWorksJournal)
                .WithOptional(e => e.RefAntennaType)
                .HasForeignKey(e => e.FkAntennaType);

            modelBuilder.Entity<REF_BARCODE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_BARCODE>()
                .HasMany(e => e.ORDER_BARCODE)
                .WithRequired(e => e.REF_BARCODE)
                .HasForeignKey(e => e.TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_CARD_FORMAT>()
                .Property(e => e.WIDTH_AND_HEIGHT)
                .IsUnicode(false);

            modelBuilder.Entity<REF_CARD_FORMAT>()
                .HasMany(e => e.ORDER_CARD_PRODUCTS)
                .WithRequired(e => e.REF_CARD_FORMAT)
                .HasForeignKey(e => e.SIZE_CARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_CARD_FORMAT>()
                .HasMany(e => e.ORDER_MAIN_INFO)
                .WithOptional(e => e.REF_CARD_FORMAT)
                .HasForeignKey(e => e.SIZE_CARD);

            //modelBuilder.Entity<REF_CHIP>()
            //    .Property(e => e.NAME)
            //    .IsUnicode(false);

            //modelBuilder.Entity<REF_CHIP>()
            //    .Property(e => e.ID)
            //    .HasPrecision(38, 0);

            //modelBuilder.Entity<REF_CHIP>()
            //    .Property(e => e.COLOR);

            // modelBuilder.Entity<REF_CHIP>()
            //     .HasMany(e => e.ISSUED_MATERIAL)
            //     .WithOptional(e => e.REF_CHIP)
            //     .HasForeignKey(e => e.CHIP);

            // modelBuilder.Entity<REF_CHIP>()
            //     .HasMany(e => e.TRANSFERRED_AFTER_CHIP_IMPLANT)
            //     .WithOptional(e => e.REF_CHIP)
            //     .HasForeignKey(e => e.CHIP);

            // modelBuilder.Entity<REF_CHIP>()
            //     .HasMany(e => e.TRANSFERRED_DESTR_CHIP_IMPLANT)
            //     .WithOptional(e => e.REF_CHIP)
            //     .HasForeignKey(e => e.CHIP);

            // modelBuilder.Entity<REF_CHIP>()
            //     .HasMany(e => e.ORDER_STRICT_MATERIALS)
            //     .WithOptional(e => e.REF_CHIP)
            //     .HasForeignKey(e => e.ADDITIONAL_CHIP_2);

            // modelBuilder.Entity<REF_CHIP>()
            //     .HasMany(e => e.ORDER_STRICT_MATERIALS1)
            //     .WithOptional(e => e.REF_CHIP1)
            //     .HasForeignKey(e => e.ADDITIONAL_CHIP_1);

            // modelBuilder.Entity<REF_CHIP>()
            //.HasMany(e => e.ORDER_STRICT_MATERIALS2)
            //.WithOptional(e => e.REF_CHIP2)
            //.HasForeignKey(e => e.MAIN_CHIP);

            //        modelBuilder.Entity<REF_COLOR>()
            //.Property(e => e.ID)
            //.HasPrecision(38, 0);

            //        modelBuilder.Entity<REF_COLOR>()
            //            .Property(e => e.NAME)
            //            .IsUnicode(false);

            //modelBuilder.Entity<REF_COLOR>()
            //    .HasMany(e => e.EXECUTED_W_J_PLEXTOR)
            //    .WithOptional(e => e.REF_COLOR)
            //    .HasForeignKey(e => e.COLOR);

            modelBuilder.Entity<RefColorChip>()
                .Property(e => e.ID);

            modelBuilder.Entity<RefColorChip>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            //modelBuilder.Entity<RefColorChip>()
            //    .HasMany(e => e.REF_CHIP)
            //    .WithOptional(e => e.REF_COLOR_CHIP)
            //    .HasForeignKey(e => e.COLOR);

            modelBuilder.Entity<REF_CONTACTLESS_INTERFACE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_CONTACTLESS_INTERFACE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.IsShow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.TypeMaterial)
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.DepartExecutedWork)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefDepart>()
                .Property(e => e.OrderDepart);

            modelBuilder.Entity<RefDepart>()
                .HasMany(e => e.REF_WORK_AREA)
                .WithRequired(e => e.REF_DEPART)
                .HasForeignKey(e => e.FkDepart);

            //modelBuilder.Entity<RefWorkArea>()
            //    .HasRequired(u => u.REF_DEPART)
            //    .WithMany(u => u.REF_WORK_AREA)
            //    .HasForeignKey(u=>u.FkDepart);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .Property(e => e.TAPE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .Property(e => e.FK_TYPE_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.COATED_MATERIAL)
                .WithOptional(e => e.REF_HOLOGRAM)
                .HasForeignKey(e => e.HOLOGRAM);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.ISSUED_MATERIAL)
                .WithOptional(e => e.REF_HOLOGRAM)
                .HasForeignKey(e => e.HOLOGRAM);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.TRANSFERRED_HOT_ORDER)
                .WithOptional(e => e.REF_HOLOGRAM)
                .HasForeignKey(e => e.HOLOGRAM);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.USED_HOLOGRAM)
                .WithOptional(e => e.REF_HOLOGRAM)
                .HasForeignKey(e => e.HOLOGRAM);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.ORDER_STRICT_MATERIALS)
                .WithOptional(e => e.REF_HOLOGRAM)
                .HasForeignKey(e => e.BACK_HOLOGRAM);

            modelBuilder.Entity<REF_HOLOGRAM>()
                .HasMany(e => e.ORDER_STRICT_MATERIALS1)
                .WithOptional(e => e.REF_HOLOGRAM1)
                .HasForeignKey(e => e.FACE_HOLOGRAM);


            modelBuilder.Entity<RefMachine>()
                .Property(e => e.Id);

            modelBuilder.Entity<RefMachine>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefMachine>()
                .Property(e => e.WorkArea);

            modelBuilder.Entity<RefMachine>()
                .Property(e => e.CountUser);

            modelBuilder.Entity<RefMachine>()
            .HasRequired(u => u.RefWorkArea)
            .WithMany(u => u.REF_MACHINE)
            .HasForeignKey(u => u.WorkArea);

            modelBuilder.Entity<RefMachine>()
                .HasMany(e => e.EXECUTED_WORKS_JOURNAL)
                .WithRequired(e => e.REF_MACHINE)
                .HasForeignKey(e => e.FkMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachine>()
                .HasMany(e => e.MECHANICS_JOURNAL)
                .WithRequired(e => e.REF_MACHINE)
                .HasForeignKey(e => e.IdMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachine>()
                .HasMany(e => e.WEB_USER_MACHINE)
                .WithRequired(e => e.REF_MACHINE)
                .HasForeignKey(e => e.FkMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachine>()
                .HasMany(e => e.REF_MACHINE_OPERATION)
                .WithRequired(e => e.REF_MACHINE)
                .HasForeignKey(e => e.FkMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachine>()
                .HasMany(e => e.ALL_MECHANICS_JOURNAL)
                .WithRequired(e => e.REF_MACHINE)
                .HasForeignKey(e => e.IdMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .Property(e => e.Id);

            modelBuilder.Entity<RefMachineOperation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefMachineOperation>()
                .Property(e => e.FkMachine);

            modelBuilder.Entity<RefMachineOperation>()
                .Property(e => e.RequeryCount)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_ATLANTIC)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_CASSILO)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_EMBOSSERS)
                .WithOptional(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation2);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_EMBOSSERS1)
                .WithOptional(e => e.REF_MACHINE_OPERATION1)
                .HasForeignKey(e => e.MachineOperation3);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_EMBOSSERS2)
                .WithOptional(e => e.REF_MACHINE_OPERATION2)
                .HasForeignKey(e => e.MachineOperation2);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_EMBOSSERS3)
                .WithOptional(e => e.REF_MACHINE_OPERATION3)
                .HasForeignKey(e => e.MachineOperation5);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_EMBOSSERS4)
                .WithRequired(e => e.REF_MACHINE_OPERATION4)
                .HasForeignKey(e => e.MachineOperation1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_IMPLANTATION_YMJ)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_INDIGO)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_MAIL_OK)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_MANUAL_CODING)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_OFFSET_PRINTING)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_OKK)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_PACK_LOYALTY_KITS)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_PLEXTOR)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MACHINE_OPERATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.EXECUTED_W_J_SILK_STENCIL)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.MACHINE_OPERATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.ALL_EXECUTED_W_J_OKK)
                .WithRequired(e => e.REF_MACHINE_OPERATION)
                .HasForeignKey(e => e.FkMachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefMachineOperation>()
                .HasMany(e => e.ALL_EXECUTED_W_J_OKK1)
                .WithRequired(e => e.REF_MACHINE_OPERATION1)
                .HasForeignKey(e => e.FkMachineOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_MAGNETIC_STRIP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_MAGNETIC_STRIP>()
                .Property(e => e.LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_MAGNETIC_STRIP>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<REF_MAGNETIC_STRIP>()
                .HasMany(e => e.REF_SEMIFINISHED)
                .WithOptional(e => e.REF_MAGNETIC_STRIP)
                .HasForeignKey(e => e.FK_REF_MAGNETIC_STRIP);

            modelBuilder.Entity<REF_MAGNETIC_STRIP>()
                .HasMany(e => e.TRANSFERRED_MATERIAL)
                .WithOptional(e => e.REF_MAGNETIC_STRIP)
                .HasForeignKey(e => e.FK_MAGNETIC_STRIP);

            modelBuilder.Entity<REF_MEMBER_EXCHANGE_MATERIAL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_MEMBER_EXCHANGE_MATERIAL>()
                .Property(e => e.SHORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_MEMBER_EXCHANGE_MATERIAL>()
                .Property(e => e.IS_SHOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REF_MEMBER_EXCHANGE_MATERIAL>()
                .Property(e => e.TYPE_MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<REF_NON_CARD_PRODUCTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_NON_CARD_PRODUCTS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_NON_CARD_PRODUCTS>()
                .Property(e => e.WIDTH_AND_HEIGHT)
                .IsUnicode(false);

            modelBuilder.Entity<REF_OVERLAY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_OVERLAY>()
                .Property(e => e.IS_ROLL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REF_OVERLAY>()
                .Property(e => e.DENSITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_OVERLAY>()
                .HasMany(e => e.ORDER_LAYER_SHEET_COMPOSITION)
                .WithOptional(e => e.REF_OVERLAY)
                .HasForeignKey(e => e.FK_REF_OVERLAY);


            modelBuilder.Entity<REF_OVERLAY>()
                .HasMany(e => e.REF_SEMIFINISHED)
                .WithOptional(e => e.REF_OVERLAY)
                .HasForeignKey(e => e.FK_REF_OVERLAY);

            modelBuilder.Entity<REF_OVERLAY>()
                .HasMany(e => e.TRANSFERRED_MATERIAL)
                .WithOptional(e => e.REF_OVERLAY)
                .HasForeignKey(e => e.FK_OVERLAY);

            modelBuilder.Entity<RefPageLayer>()
                .Property(e => e.Id);

            modelBuilder.Entity<RefPageLayer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefPageLayer>()
                .HasMany(e => e.TRANSFER_JOURNAL_SHEET)
                .WithRequired(e => e.RefPageLayer)
                .HasForeignKey(e => e.PageLayer)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_WIRE)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_OVERLAY)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_MAGNETIC_STRIP)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_WINDING_METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.FK_REF_PLASTIC)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .Property(e => e.DENSITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .HasMany(e => e.ORDER_LAYER_SHEET_COMPOSITION)
                .WithOptional(e => e.REF_SEMIFINISHED)
                .HasForeignKey(e => e.FK_REF_SEMIFINISHED);

            modelBuilder.Entity<REF_SEMIFINISHED>()
                .HasMany(e => e.RECEIVED_MATERIAL)
                .WithRequired(e => e.REF_SEMIFINISHED)
                .HasForeignKey(e => e.FK_REF_SEMIFINISHED_OPZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSheetFormat>()
                .Property(e => e.WidthAndHeight)
                .IsUnicode(false);

            modelBuilder.Entity<RefSheetFormat>()
                .Property(e => e.Count);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_INDIGO)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SheetFormat);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_LAMINATION)
                .WithRequired(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_OFFSET_PRINTING)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SheetFormat);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_PACKAGE_BUILDING)
                .WithRequired(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_PLEXTOR)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.EXECUTED_W_J_SILK_STENCIL)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.ORDER_MAIN_INFO)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.REF_PLASTIC)
                .WithRequired(e => e.REF_SHEET_FORMAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.REF_SEMIFINISHED)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.FK_REF_SHEET_FORMAT);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.SOLVENTs)
                .WithRequired(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SHEET_FORMAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSheetFormat>()
                .HasMany(e => e.TRANSFER_JOURNAL_SHEET)
                .WithOptional(e => e.REF_SHEET_FORMAT)
                .HasForeignKey(e => e.SheetFormat);

            modelBuilder.Entity<REF_SIGNATURE_STRIP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SIGNATURE_STRIP>()
                .Property(e => e.REF_TYPE_BANK_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SIGNATURE_STRIP>()
                .HasMany(e => e.ORDER_STRICT_MATERIALS)
                .WithOptional(e => e.REF_SIGNATURE_STRIP)
                .HasForeignKey(e => e.SIGNATURE_STRIP);

            modelBuilder.Entity<REF_STAGE_CHIP_IMPLANT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_STAGE_COATED_MATERIAL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_STAGE_COATED_MATERIAL>()
                .HasMany(e => e.COATED_MATERIAL)
                .WithRequired(e => e.REF_STAGE_COATED_MATERIAL)
                .HasForeignKey(e => e.STAGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_TYPE_BANK_CARD>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_TYPE_BANK_CARD>()
                .HasMany(e => e.ORDER_CARD_PRODUCTS)
                .WithRequired(e => e.REF_TYPE_BANK_CARD)
                .HasForeignKey(e => e.TYPE_CARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_TYPE_BANK_CARD>()
                .HasMany(e => e.REF_HOLOGRAM)
                .WithOptional(e => e.REF_TYPE_BANK_CARD)
                .HasForeignKey(e => e.FK_TYPE_CARD);

            modelBuilder.Entity<REF_TYPE_BANK_CARD>()
                .HasMany(e => e.REF_SIGNATURE_STRIP)
                .WithRequired(e => e.REF_TYPE_BANK_CARD1)
                .HasForeignKey(e => e.REF_TYPE_BANK_CARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_TYPE_CARD_MATERIAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_TYPE_CARD_MATERIAL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_TYPE_CARD_MATERIAL>()
                .HasMany(e => e.ORDER_CARD_PRODUCTS)
                .WithOptional(e => e.REF_TYPE_CARD_MATERIAL)
                .HasForeignKey(e => e.TYPE_CARD_MATERIAL);

            modelBuilder.Entity<REF_TYPE_LAYER_SHEET>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_TYPE_LAYER_SHEET>()
                .Property(e => e.SORT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REF_TYPE_LAYER_SHEET>()
                .HasMany(e => e.ORDER_LAYER_SHEET_COMPOSITION)
                .WithRequired(e => e.REF_TYPE_LAYER_SHEET)
                .HasForeignKey(e => e.TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_TYPE_OPERATION_CARD>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REF_TYPE_OPERATION_CARD>()
                .HasMany(e => e.ORDER_CARD_PRODUCTS)
                .WithRequired(e => e.REF_TYPE_OPERATION_CARD)
                .HasForeignKey(e => e.TYPE_OPERATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefTypeOrder>()
                .Property(e => e.ID);

            modelBuilder.Entity<RefTypeOrder>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<RefTypeOrder>()
                .HasMany(e => e.ORDER_MAIN_INFO)
                .WithOptional(e => e.REF_TYPE_ORDER)
                .HasForeignKey(e => e.TYPE_ORDER);

            //    modelBuilder.Entity<REF_WINDING_METHOD>()
            //.Property(e => e.NAME)
            //.IsUnicode(false);

            //    modelBuilder.Entity<REF_WINDING_METHOD>()
            //        .Property(e => e.CONSUMPTION)
            //        .HasPrecision(38, 0);

            //    modelBuilder.Entity<REF_WINDING_METHOD>()
            //        .Property(e => e.NUMBER_TURNS)
            //        .HasPrecision(38, 0);

            //    modelBuilder.Entity<REF_WINDING_METHOD>()
            //        .HasMany(e => e.REF_SEMIFINISHED)
            //        .WithOptional(e => e.REF_WINDING_METHOD)
            //        .HasForeignKey(e => e.FK_REF_WINDING_METHOD);

            //    modelBuilder.Entity<REF_WIRE>()
            //        .Property(e => e.NAME)
            //        .IsUnicode(false);

            //    modelBuilder.Entity<REF_WIRE>()
            //        .HasMany(e => e.REF_SEMIFINISHED)
            //        .WithOptional(e => e.REF_WIRE)
            //        .HasForeignKey(e => e.FK_REF_WIRE);

            //    modelBuilder.Entity<REF_WIRE>()
            //        .HasMany(e => e.TRANSFERRED_MATERIAL)
            //        .WithOptional(e => e.REF_WIRE)
            //        .HasForeignKey(e => e.FK_WIRE);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.PRINTING_METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.SHEET_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.NUMBER_ORDER_1)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.NUMBER_ORDER_2)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.NUMBER_ORDER_3)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.NUMBER_ORDER_4)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.NUMBER_ORDER_5)
                .IsUnicode(false);

            modelBuilder.Entity<SOLVENT>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.Id);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.FromWorkArea);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.ToWorkArea);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.Count);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.UserVerification)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCard>()
                .Property(e => e.FkOrderLayout);

            modelBuilder.Entity<TransferJournalCard>()
            .HasRequired(u => u.RefWorkAreaFrom)
            .WithMany(u => u.TRANSFER_JOURNA_CARD_FROM)
            .HasForeignKey(u => u.FromWorkArea);

            modelBuilder.Entity<TransferJournalCard>()
             .HasRequired(u => u.RefWorkAreaTo)
             .WithMany(u => u.TRANSFER_JOURNA_CARD_TO)
             .HasForeignKey(u => u.ToWorkArea);

            modelBuilder.Entity<TransferJournalCard>()
                .HasRequired(u => u.ORDER_MAIN_INFO)
                .WithMany(u => u.TRANSFER_JOURNA_CARD)
                .HasForeignKey(u => u.NumberOrder);

            modelBuilder.Entity<TransferJournalCard>()
                .HasOptional(u => u.ORDER_LAYOUT)
                .WithMany(u => u.TRANSFER_JOURNA_CARD)
                .HasForeignKey(u => u.FkOrderLayout);


            modelBuilder.Entity<TransferJournalCardRoute>()
                .Property(e => e.FromWorkArea);

            modelBuilder.Entity<TransferJournalCardRoute>()
                .Property(e => e.ToWorkArea);

            modelBuilder.Entity<TransferJournalCardRoute>()
                .Property(e => e.TypeMaterial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalCardRoute>()
                .Property(e => e.Id);

            modelBuilder.Entity<TransferJournalCardRoute>()
                .HasRequired(u => u.RefWorkAreaFrom)
                .WithMany(u => u.TRANSFER_JOURNAL_ROUTE_FROM)
                .HasForeignKey(u => u.FromWorkArea);

            modelBuilder.Entity<TransferJournalCardRoute>()
                 .HasRequired(u => u.RefWorkAreaTo)
                 .WithMany(u => u.TRANSFER_JOURNAL_ROUTE_TO)
                 .HasForeignKey(u => u.ToWorkArea);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.Id);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.FromWorkArea);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.ToWorkArea);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.Count);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.SheetFormat)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.CountProduct);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.PageLayer);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.UserVerification)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.ProductsOnOneSheet);

            modelBuilder.Entity<TransferJournalSheet>()
                .Property(e => e.FkOrderLayout);

            modelBuilder.Entity<TransferJournalSheet>()
                .HasRequired(u => u.ORDER_MAIN_INFO)
                .WithMany(u => u.TRANSFER_JOURNAL_SHEET)
                .HasForeignKey(u => u.NumberOrder);

            modelBuilder.Entity<TransferJournalSheet>()
              .HasOptional(u => u.ORDER_LAYOUT)
              .WithMany(u => u.TRANSFER_JOURNAL_SHEET)
              .HasForeignKey(u => u.FkOrderLayout);

            modelBuilder.Entity<TransferJournalSheet>()
               .HasRequired(u => u.RefWorkAreaFrom)
               .WithMany(u => u.TRANSFER_JOURNAL_SHEET_FROM)
               .HasForeignKey(u => u.FromWorkArea);

            modelBuilder.Entity<TransferJournalSheet>()
               .HasRequired(u => u.RefWorkAreaTo)
               .WithMany(u => u.TRANSFER_JOURNAL_SHEET_TO)
               .HasForeignKey(u => u.ToWorkArea);


            modelBuilder.Entity<TRANSFERRED_AFTER_CHIP_IMPLANT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_CHIP_IMPLANT>()
                .Property(e => e.FK_NUMBER_CHIP_IMPLANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_CHIP_IMPLANT>()
                .Property(e => e.COUNT_TO_OKK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_CHIP_IMPLANT>()
                .Property(e => e.COUNT_TO_PERSO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_CHIP_IMPLANT>()
                .Property(e => e.CHIP)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_AFTER_MILLING>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_MILLING>()
                .Property(e => e.FK_NUMBER_CHIP_IMPLANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_MILLING>()
                .Property(e => e.COUNT_TO_OKK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_AFTER_MILLING>()
                .Property(e => e.COUNT_TO_PERSO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.FK_NUMBER_CHIP_IMPLANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.DESTROY_CARD_WITH_CHIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.DESTROY_ONLY_CARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.DESTROY_ONLY_CHIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.DESTROY_DEFECTIVE_TAPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_DESTR_CHIP_IMPLANT>()
                .Property(e => e.CHIP)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.FK_NUMBER_HOT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.GOOD_TO_OKK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.DESTROY_HOLOGRAM_STRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.DESTROY_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.DESTROY_STRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.DESTROY_NOT_USED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_HOT_ORDER>()
                .Property(e => e.HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.USER_NAME_ISSUED_MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.FK_WIRE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.COUNT_WIRE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.FK_OVERLAY)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.COUNT_OVERLAY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.FK_MAGNETIC_STRIP)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERRED_MATERIAL>()
                .Property(e => e.COUNT_MAGNETIC_STRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.FK_NUMBER_HOT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.NUMBER_ROLL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.NUMBER_FIRST_USED_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.NUMBER_END_USED_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USED_HOLOGRAM>()
                .Property(e => e.HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<UserMachine>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserMachine>()
                .Property(e => e.FkMachine);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Run);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.WorkMode)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllAtlantic>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.MachineOperation)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Run);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.WorkMode)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllEmbossers>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.FkOrderLayout);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.FkExecutedWorksJournal);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.MachineOperation)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.OwnTurn)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.CountSheet)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.SheetFormat)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.TechnicalWaste)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.RangeSheet)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.Completed)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.IsFace)
                .IsUnicode(false);

            modelBuilder.Entity<AllMGI>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.FkMachineOperation);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.CountDefect);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllOKK>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.CountDeadChip);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.CountNotch);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.CountNotchWithChip);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.CountDefectAntenna);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.CountDefectAntennaWithChip);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.NameAntenna)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllImplantation>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Shift)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Count)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllInterruptionDefective>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllMailOk>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.IdMachine);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.IdWorkArea);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.DescriptionProblem)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.IdStatus);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.ImportanceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.IntImportanceLevel);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.NotePerformer)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.ShortUserPerformer)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.UserCreater)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.ShortUserCreater)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.WorkAresName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
                .Property(e => e.NameDepart)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournal>()
             .Property(e => e.ShortNameVerificationUser)
             .IsUnicode(false);


            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.OffHour)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.IdStatus);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.UserPerformer)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.UserCreater)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.FkOrder);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.IdMachine);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.IdWorkArea);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<AllMechinecsJournalWork>()
                .Property(e => e.DescriptionProblem)
                .IsUnicode(false);

            modelBuilder.Entity<AllReportEWByOrder>()
                .Property(e => e.OrderOperation)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AllReportEWByOrder>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllReportEWByOrder>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllReportEWByOrder>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<AllReportEWByOrder>()
                .Property(e => e.Count)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.IdOrderLayout);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.FromWorkArea)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.IdFromWorkArea);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.ToWorkArea)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.IdToWorkArea);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.PageLayer)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.CountInProduct);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.UserVerification)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllTransferJornal>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.FK_ORDER_LAYOUT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.FROM_WORK_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.ID_FROM_WORK_AREA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.TO_WORK_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.ID_TO_WORK_AREA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.PAGE_LAYER)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.COUNT_IN_PRODUCT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.USER_VERIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_TRANSFER_JOURNAL1>()
                .Property(e => e.IS_DELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.FACE_HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.BACK_HOLOGRAM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.MAIN_CHIP)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.ADDITIONAL_CHIP_1)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.ADDITIONAL_CHIP_2)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STRICT_MATERIALS>()
                .Property(e => e.SIGNATURE_STRIP)
                .IsUnicode(false);


            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.NUM)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.ADD_RESERVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.COUNT_SAMPLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.FACT_COUNT_ANNEXE_HOLOGRAM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.FACT_COUNT_ANNEXE_STRIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PARAMETER_DEFECT>()
                .Property(e => e.COUNT_RUNS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TEMP_REPORT_EXECUTED_W_J>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_REPORT_EXECUTED_W_J>()
                .Property(e => e.RANGE_COMPLETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TEMP_REPORT_EXECUTED_W_J>()
                .Property(e => e.RANGE_NO_COMPLETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TEMP_REPORT_EXECUTED_W_J>()
                .Property(e => e.ALL_COMPLETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TEMP_REPORT_EXECUTED_W_J>()
                .Property(e => e.ALL_NO_COMPLETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRAN_STORAGE_CHIP_IMPLANT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRAN_STORAGE_CHIP_IMPLANT>()
                .Property(e => e.FK_NUMBER_CHIP_IMPLANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRAN_STORAGE_CHIP_IMPLANT>()
                .Property(e => e.CARD_WITHOUT_CHIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRAN_STORAGE_CHIP_IMPLANT>()
                .Property(e => e.CARD_WITH_CHIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRAN_STORAGE_CHIP_IMPLANT>()
                .Property(e => e.CHIP)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.IsDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Thousand);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllCassilo>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.BeginRange);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.EndRange);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Run);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Party);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.WorkMode)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllManualCoding>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Id);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Shift);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.isDeleted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Count);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.VerificationShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.Machine)
                .IsUnicode(false);

            modelBuilder.Entity<AllPackLoyaltyKits>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_PRINT>()
                .Property(e => e.OrderOperation)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_REPORT_PRINT>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_PRINT>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_PRINT>()
                .Property(e => e.Location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_PRINT>()
                .Property(e => e.Count)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_SILKPRINTING>()
                .Property(e => e.ORDER_OPERATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALL_REPORT_SILKPRINTING>()
                .Property(e => e.NUMBER_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_SILKPRINTING>()
                .Property(e => e.LOCATION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_SILKPRINTING>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ALL_REPORT_SILKPRINTING>()
                .Property(e => e.COUNT)
                .IsUnicode(false);


            modelBuilder.Entity<OrderFile>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
        .Property(e => e.Title)
        .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.Note)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.UserName)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.NameFile1)
            .IsUnicode(false);
            modelBuilder.Entity<OrderFile>()
            .Property(e => e.NameFile2)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.NameFile3)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.NameFile4)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
            .Property(e => e.NameFile5)
            .IsUnicode(false);

            modelBuilder.Entity<OrderFile>()
                .HasRequired(u => u.OrderMainInfo)
                .WithMany(u => u.OrderFiles)
                .HasForeignKey(u => u.NumberOrder);

            modelBuilder.Entity<OrderFile>()
                .HasIndex(a => new { a.Id, a.NameFile1, a.NameFile2, a.NameFile3, a.NameFile4, a.NameFile5 })
                .IsUnique();


            modelBuilder.Entity<PrepressWorksJournal>()
    .HasRequired(u => u.ExecutedWorkJournal)
    .WithOptional(u => u.ExecutedWorksJournaPrepress)
    .WillCascadeOnDelete(false);


            modelBuilder.Entity<KirkRudyWorksJournal>()
                .HasMany(u => u.ListUsersKirkRudy)
                .WithRequired(u => u.KirkRudy)
                .WillCascadeOnDelete(false);

        }
    }
}
