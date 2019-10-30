using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DinamikCRM.Entity.Models.DB
{
    public partial class CRMContext : DbContext
    {
        public CRMContext()
        {
        }

        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccount> TblAccount { get; set; }
        public virtual DbSet<TblAccountCurrent> TblAccountCurrent { get; set; }
        public virtual DbSet<TblAccountTransaction> TblAccountTransaction { get; set; }
        public virtual DbSet<TblActivity> TblActivity { get; set; }
        public virtual DbSet<TblActivityCustomFieldData> TblActivityCustomFieldData { get; set; }
        public virtual DbSet<TblActivityHistory> TblActivityHistory { get; set; }
        public virtual DbSet<TblActivityLog> TblActivityLog { get; set; }
        public virtual DbSet<TblAppointment> TblAppointment { get; set; }
        public virtual DbSet<TblAppointmentCustomFieldData> TblAppointmentCustomFieldData { get; set; }
        public virtual DbSet<TblAppointmentDetail> TblAppointmentDetail { get; set; }
        public virtual DbSet<TblAttach> TblAttach { get; set; }
        public virtual DbSet<TblBoard> TblBoard { get; set; }
        public virtual DbSet<TblBoardCategory> TblBoardCategory { get; set; }
        public virtual DbSet<TblBoardItem> TblBoardItem { get; set; }
        public virtual DbSet<TblBrand> TblBrand { get; set; }
        public virtual DbSet<TblBundle> TblBundle { get; set; }
        public virtual DbSet<TblBundleDetail> TblBundleDetail { get; set; }
        public virtual DbSet<TblCalendar> TblCalendar { get; set; }
        public virtual DbSet<TblCall> TblCall { get; set; }
        public virtual DbSet<TblCallList> TblCallList { get; set; }
        public virtual DbSet<TblCallListData> TblCallListData { get; set; }
        public virtual DbSet<TblCallScheduler> TblCallScheduler { get; set; }
        public virtual DbSet<TblCallScript> TblCallScript { get; set; }
        public virtual DbSet<TblCampaignList> TblCampaignList { get; set; }
        public virtual DbSet<TblCampaignTempList> TblCampaignTempList { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblChat> TblChat { get; set; }
        public virtual DbSet<TblChatRoom> TblChatRoom { get; set; }
        public virtual DbSet<TblChatRoomMember> TblChatRoomMember { get; set; }
        public virtual DbSet<TblCheckIn> TblCheckIn { get; set; }
        public virtual DbSet<TblCity> TblCity { get; set; }
        public virtual DbSet<TblCompany> TblCompany { get; set; }
        public virtual DbSet<TblCompanyAddress> TblCompanyAddress { get; set; }
        public virtual DbSet<TblCompanyBranch> TblCompanyBranch { get; set; }
        public virtual DbSet<TblCompanyCategory> TblCompanyCategory { get; set; }
        public virtual DbSet<TblCompanyContact> TblCompanyContact { get; set; }
        public virtual DbSet<TblCompanyCustomFieldData> TblCompanyCustomFieldData { get; set; }
        public virtual DbSet<TblCompanyDetail> TblCompanyDetail { get; set; }
        public virtual DbSet<TblCompanyEmail> TblCompanyEmail { get; set; }
        public virtual DbSet<TblCompanyPermit> TblCompanyPermit { get; set; }
        public virtual DbSet<TblCompanyPhone> TblCompanyPhone { get; set; }
        public virtual DbSet<TblCompanySettings> TblCompanySettings { get; set; }
        public virtual DbSet<TblCompanySocial> TblCompanySocial { get; set; }
        public virtual DbSet<TblContact> TblContact { get; set; }
        public virtual DbSet<TblContactAddress> TblContactAddress { get; set; }
        public virtual DbSet<TblContactContact> TblContactContact { get; set; }
        public virtual DbSet<TblContactCustomFieldData> TblContactCustomFieldData { get; set; }
        public virtual DbSet<TblContactDetail> TblContactDetail { get; set; }
        public virtual DbSet<TblContactEmail> TblContactEmail { get; set; }
        public virtual DbSet<TblContactEmotion> TblContactEmotion { get; set; }
        public virtual DbSet<TblContactForm> TblContactForm { get; set; }
        public virtual DbSet<TblContactPermit> TblContactPermit { get; set; }
        public virtual DbSet<TblContactPhone> TblContactPhone { get; set; }
        public virtual DbSet<TblContactSettings> TblContactSettings { get; set; }
        public virtual DbSet<TblContactSocial> TblContactSocial { get; set; }
        public virtual DbSet<TblContent> TblContent { get; set; }
        public virtual DbSet<TblContentCategory> TblContentCategory { get; set; }
        public virtual DbSet<TblContentComment> TblContentComment { get; set; }
        public virtual DbSet<TblContentReact> TblContentReact { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCoupon> TblCoupon { get; set; }
        public virtual DbSet<TblCouponData> TblCouponData { get; set; }
        public virtual DbSet<TblCustomField> TblCustomField { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblCustomerAddress> TblCustomerAddress { get; set; }
        public virtual DbSet<TblCustomerContact> TblCustomerContact { get; set; }
        public virtual DbSet<TblCustomerCustomFieldData> TblCustomerCustomFieldData { get; set; }
        public virtual DbSet<TblCustomerDetail> TblCustomerDetail { get; set; }
        public virtual DbSet<TblCustomerEmail> TblCustomerEmail { get; set; }
        public virtual DbSet<TblCustomerEmotion> TblCustomerEmotion { get; set; }
        public virtual DbSet<TblCustomerPermit> TblCustomerPermit { get; set; }
        public virtual DbSet<TblCustomerPhone> TblCustomerPhone { get; set; }
        public virtual DbSet<TblCustomerSettings> TblCustomerSettings { get; set; }
        public virtual DbSet<TblCustomerSocial> TblCustomerSocial { get; set; }
        public virtual DbSet<TblDashboard> TblDashboard { get; set; }
        public virtual DbSet<TblDealer> TblDealer { get; set; }
        public virtual DbSet<TblDealerAddress> TblDealerAddress { get; set; }
        public virtual DbSet<TblDealerArea> TblDealerArea { get; set; }
        public virtual DbSet<TblDealerEmail> TblDealerEmail { get; set; }
        public virtual DbSet<TblDealerPhone> TblDealerPhone { get; set; }
        public virtual DbSet<TblDistrict> TblDistrict { get; set; }
        public virtual DbSet<TblDynamic> TblDynamic { get; set; }
        public virtual DbSet<TblEmailProvider> TblEmailProvider { get; set; }
        public virtual DbSet<TblEmailSignature> TblEmailSignature { get; set; }
        public virtual DbSet<TblEmailTemplate> TblEmailTemplate { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblEmployeeAddress> TblEmployeeAddress { get; set; }
        public virtual DbSet<TblEmployeeAsset> TblEmployeeAsset { get; set; }
        public virtual DbSet<TblEmployeeCustomFieldData> TblEmployeeCustomFieldData { get; set; }
        public virtual DbSet<TblEmployeeDetail> TblEmployeeDetail { get; set; }
        public virtual DbSet<TblEmployeeEmail> TblEmployeeEmail { get; set; }
        public virtual DbSet<TblEmployeeEmotion> TblEmployeeEmotion { get; set; }
        public virtual DbSet<TblEmployeeLeave> TblEmployeeLeave { get; set; }
        public virtual DbSet<TblEmployeeLeaveCategory> TblEmployeeLeaveCategory { get; set; }
        public virtual DbSet<TblEmployeePhone> TblEmployeePhone { get; set; }
        public virtual DbSet<TblEmployeeSettings> TblEmployeeSettings { get; set; }
        public virtual DbSet<TblEmployeeSocial> TblEmployeeSocial { get; set; }
        public virtual DbSet<TblExpense> TblExpense { get; set; }
        public virtual DbSet<TblExpenseCategory> TblExpenseCategory { get; set; }
        public virtual DbSet<TblFaq> TblFaq { get; set; }
        public virtual DbSet<TblFavorites> TblFavorites { get; set; }
        public virtual DbSet<TblFeed> TblFeed { get; set; }
        public virtual DbSet<TblFeedComment> TblFeedComment { get; set; }
        public virtual DbSet<TblFeedReact> TblFeedReact { get; set; }
        public virtual DbSet<TblFeedback> TblFeedback { get; set; }
        public virtual DbSet<TblFeedbackCustomFieldData> TblFeedbackCustomFieldData { get; set; }
        public virtual DbSet<TblFeedbackHistory> TblFeedbackHistory { get; set; }
        public virtual DbSet<TblForm> TblForm { get; set; }
        public virtual DbSet<TblFormData> TblFormData { get; set; }
        public virtual DbSet<TblFormDetail> TblFormDetail { get; set; }
        public virtual DbSet<TblGroup> TblGroup { get; set; }
        public virtual DbSet<TblGroupApi> TblGroupApi { get; set; }
        public virtual DbSet<TblGroupBanking> TblGroupBanking { get; set; }
        public virtual DbSet<TblGroupLanding> TblGroupLanding { get; set; }
        public virtual DbSet<TblGroupLocation> TblGroupLocation { get; set; }
        public virtual DbSet<TblGroupSocial> TblGroupSocial { get; set; }
        public virtual DbSet<TblGroupSolution> TblGroupSolution { get; set; }
        public virtual DbSet<TblHelp> TblHelp { get; set; }
        public virtual DbSet<TblImage> TblImage { get; set; }
        public virtual DbSet<TblIntegration> TblIntegration { get; set; }
        public virtual DbSet<TblInventory> TblInventory { get; set; }
        public virtual DbSet<TblInvitation> TblInvitation { get; set; }
        public virtual DbSet<TblLead> TblLead { get; set; }
        public virtual DbSet<TblLeadAddress> TblLeadAddress { get; set; }
        public virtual DbSet<TblLeadContact> TblLeadContact { get; set; }
        public virtual DbSet<TblLeadCustomFieldData> TblLeadCustomFieldData { get; set; }
        public virtual DbSet<TblLeadDetail> TblLeadDetail { get; set; }
        public virtual DbSet<TblLeadEmail> TblLeadEmail { get; set; }
        public virtual DbSet<TblLeadEmotion> TblLeadEmotion { get; set; }
        public virtual DbSet<TblLeadPermit> TblLeadPermit { get; set; }
        public virtual DbSet<TblLeadPhone> TblLeadPhone { get; set; }
        public virtual DbSet<TblLeadSettings> TblLeadSettings { get; set; }
        public virtual DbSet<TblLeadSocial> TblLeadSocial { get; set; }
        public virtual DbSet<TblLogEmail> TblLogEmail { get; set; }
        public virtual DbSet<TblLogError> TblLogError { get; set; }
        public virtual DbSet<TblLogLogin> TblLogLogin { get; set; }
        public virtual DbSet<TblLogPage> TblLogPage { get; set; }
        public virtual DbSet<TblLogPayment> TblLogPayment { get; set; }
        public virtual DbSet<TblLogSearch> TblLogSearch { get; set; }
        public virtual DbSet<TblLogSms> TblLogSms { get; set; }
        public virtual DbSet<TblMailbox> TblMailbox { get; set; }
        public virtual DbSet<TblModule> TblModule { get; set; }
        public virtual DbSet<TblModuleChangeLog> TblModuleChangeLog { get; set; }
        public virtual DbSet<TblModuleDetail> TblModuleDetail { get; set; }
        public virtual DbSet<TblNeighborhood> TblNeighborhood { get; set; }
        public virtual DbSet<TblNote> TblNote { get; set; }
        public virtual DbSet<TblNoteContent> TblNoteContent { get; set; }
        public virtual DbSet<TblNps> TblNps { get; set; }
        public virtual DbSet<TblNpsData> TblNpsData { get; set; }
        public virtual DbSet<TblNpsList> TblNpsList { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetail { get; set; }
        public virtual DbSet<TblOrderHistory> TblOrderHistory { get; set; }
        public virtual DbSet<TblOrderNoteTemplate> TblOrderNoteTemplate { get; set; }
        public virtual DbSet<TblOrderVehicle> TblOrderVehicle { get; set; }
        public virtual DbSet<TblPlan> TblPlan { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductCategory> TblProductCategory { get; set; }
        public virtual DbSet<TblProductComment> TblProductComment { get; set; }
        public virtual DbSet<TblProductCustomFieldData> TblProductCustomFieldData { get; set; }
        public virtual DbSet<TblProductDetail> TblProductDetail { get; set; }
        public virtual DbSet<TblProductList> TblProductList { get; set; }
        public virtual DbSet<TblProductListProduct> TblProductListProduct { get; set; }
        public virtual DbSet<TblProductVendor> TblProductVendor { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblProposal> TblProposal { get; set; }
        public virtual DbSet<TblProposalCategory> TblProposalCategory { get; set; }
        public virtual DbSet<TblProposalCustomFieldData> TblProposalCustomFieldData { get; set; }
        public virtual DbSet<TblProposalProduct> TblProposalProduct { get; set; }
        public virtual DbSet<TblProposalService> TblProposalService { get; set; }
        public virtual DbSet<TblProposalSettings> TblProposalSettings { get; set; }
        public virtual DbSet<TblProposalTemplate> TblProposalTemplate { get; set; }
        public virtual DbSet<TblQuarter> TblQuarter { get; set; }
        public virtual DbSet<TblRelations> TblRelations { get; set; }
        public virtual DbSet<TblReminder> TblReminder { get; set; }
        public virtual DbSet<TblRequest> TblRequest { get; set; }
        public virtual DbSet<TblRequestCategory> TblRequestCategory { get; set; }
        public virtual DbSet<TblRequestHistory> TblRequestHistory { get; set; }
        public virtual DbSet<TblRequestLink> TblRequestLink { get; set; }
        public virtual DbSet<TblReservation> TblReservation { get; set; }
        public virtual DbSet<TblReservationCustomFieldData> TblReservationCustomFieldData { get; set; }
        public virtual DbSet<TblRole> TblRole { get; set; }
        public virtual DbSet<TblRule> TblRule { get; set; }
        public virtual DbSet<TblSales> TblSales { get; set; }
        public virtual DbSet<TblSalesCategory> TblSalesCategory { get; set; }
        public virtual DbSet<TblSalesCustomFieldData> TblSalesCustomFieldData { get; set; }
        public virtual DbSet<TblSalesPayment> TblSalesPayment { get; set; }
        public virtual DbSet<TblSalesProduct> TblSalesProduct { get; set; }
        public virtual DbSet<TblSalesService> TblSalesService { get; set; }
        public virtual DbSet<TblSalesShipment> TblSalesShipment { get; set; }
        public virtual DbSet<TblSector> TblSector { get; set; }
        public virtual DbSet<TblSegment> TblSegment { get; set; }
        public virtual DbSet<TblSeller> TblSeller { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblServiceCategory> TblServiceCategory { get; set; }
        public virtual DbSet<TblServiceDetail> TblServiceDetail { get; set; }
        public virtual DbSet<TblSettings> TblSettings { get; set; }
        public virtual DbSet<TblSmsList> TblSmsList { get; set; }
        public virtual DbSet<TblSmsListData> TblSmsListData { get; set; }
        public virtual DbSet<TblSmsprovider> TblSmsprovider { get; set; }
        public virtual DbSet<TblSmstemplate> TblSmstemplate { get; set; }
        public virtual DbSet<TblStore> TblStore { get; set; }
        public virtual DbSet<TblStoreOrder> TblStoreOrder { get; set; }
        public virtual DbSet<TblSubCategory> TblSubCategory { get; set; }
        public virtual DbSet<TblSubscription> TblSubscription { get; set; }
        public virtual DbSet<TblSubscriptionDetail> TblSubscriptionDetail { get; set; }
        public virtual DbSet<TblSubscriptionPack> TblSubscriptionPack { get; set; }
        public virtual DbSet<TblSubscriptionSettings> TblSubscriptionSettings { get; set; }
        public virtual DbSet<TblSubscriptionTemplate> TblSubscriptionTemplate { get; set; }
        public virtual DbSet<TblSurveyLead> TblSurveyLead { get; set; }
        public virtual DbSet<TblTag> TblTag { get; set; }
        public virtual DbSet<TblTarget> TblTarget { get; set; }
        public virtual DbSet<TblTask> TblTask { get; set; }
        public virtual DbSet<TblTaskCategory> TblTaskCategory { get; set; }
        public virtual DbSet<TblTaskCustomFieldData> TblTaskCustomFieldData { get; set; }
        public virtual DbSet<TblTaskHistory> TblTaskHistory { get; set; }
        public virtual DbSet<TblTaskResponsible> TblTaskResponsible { get; set; }
        public virtual DbSet<TblTaskSettings> TblTaskSettings { get; set; }
        public virtual DbSet<TblTeam> TblTeam { get; set; }
        public virtual DbSet<TblTransfer> TblTransfer { get; set; }
        public virtual DbSet<TblTransferCustomFieldData> TblTransferCustomFieldData { get; set; }
        public virtual DbSet<TblType> TblType { get; set; }
        public virtual DbSet<TblUrl> TblUrl { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserDashboard> TblUserDashboard { get; set; }
        public virtual DbSet<TblUserDetail> TblUserDetail { get; set; }
        public virtual DbSet<TblUserExtension> TblUserExtension { get; set; }
        public virtual DbSet<TblUserInvoice> TblUserInvoice { get; set; }
        public virtual DbSet<TblUserModule> TblUserModule { get; set; }
        public virtual DbSet<TblUserPrivacy> TblUserPrivacy { get; set; }
        public virtual DbSet<TblUserRole> TblUserRole { get; set; }
        public virtual DbSet<TblUserStatus> TblUserStatus { get; set; }
        public virtual DbSet<TblUserStatusLog> TblUserStatusLog { get; set; }
        public virtual DbSet<TblUserSubscription> TblUserSubscription { get; set; }
        public virtual DbSet<TblVehicle> TblVehicle { get; set; }
        public virtual DbSet<TblVendor> TblVendor { get; set; }
        public virtual DbSet<TblVendorAddress> TblVendorAddress { get; set; }
        public virtual DbSet<TblVendorBranch> TblVendorBranch { get; set; }
        public virtual DbSet<TblVendorContact> TblVendorContact { get; set; }
        public virtual DbSet<TblVendorCustomFieldData> TblVendorCustomFieldData { get; set; }
        public virtual DbSet<TblVendorEmail> TblVendorEmail { get; set; }
        public virtual DbSet<TblVendorPhone> TblVendorPhone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("server=DESKTOP-6I03M14\\SQLEXPRESS;Database=CRM;Integrated Security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.ToTable("tblAccount");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAccountCurrent>(entity =>
            {
                entity.ToTable("tblAccountCurrent");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAccountTransaction>(entity =>
            {
                entity.ToTable("tblAccountTransaction");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblActivity>(entity =>
            {
                entity.ToTable("tblActivity");

                entity.Property(e => e.ActivityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblActivityCustomFieldData>(entity =>
            {
                entity.ToTable("tblActivityCustomFieldData");

                entity.Property(e => e.ActivityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblActivityHistory>(entity =>
            {
                entity.ToTable("tblActivityHistory");

                entity.Property(e => e.ActivityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Production)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblActivityLog>(entity =>
            {
                entity.ToTable("tblActivityLog");

                entity.Property(e => e.ActivityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAppointment>(entity =>
            {
                entity.ToTable("tblAppointment");

                entity.Property(e => e.AppointmentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AppointmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Location).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAppointmentCustomFieldData>(entity =>
            {
                entity.ToTable("tblAppointmentCustomFieldData");

                entity.Property(e => e.AppointmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAppointmentDetail>(entity =>
            {
                entity.ToTable("tblAppointmentDetail");

                entity.Property(e => e.AppointmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblAttach>(entity =>
            {
                entity.ToTable("tblAttach");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBoard>(entity =>
            {
                entity.ToTable("tblBoard");

                entity.Property(e => e.BoardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('False')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBoardCategory>(entity =>
            {
                entity.ToTable("tblBoardCategory");

                entity.Property(e => e.BoardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBoardItem>(entity =>
            {
                entity.ToTable("tblBoardItem");

                entity.Property(e => e.BoardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.ToTable("tblBrand");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBundle>(entity =>
            {
                entity.ToTable("tblBundle");

                entity.Property(e => e.BundleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency).HasDefaultValueSql("((87))");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblBundleDetail>(entity =>
            {
                entity.ToTable("tblBundleDetail");

                entity.Property(e => e.BundleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCalendar>(entity =>
            {
                entity.ToTable("tblCalendar");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageBody).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCall>(entity =>
            {
                entity.ToTable("tblCall");

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.Ucid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCallList>(entity =>
            {
                entity.ToTable("tblCallList");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCallListData>(entity =>
            {
                entity.ToTable("tblCallListData");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CallListDataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Param1).HasMaxLength(500);

                entity.Property(e => e.Param2).HasMaxLength(500);

                entity.Property(e => e.Param3).HasMaxLength(500);

                entity.Property(e => e.Param4).HasMaxLength(500);

                entity.Property(e => e.Param5).HasMaxLength(500);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCallScheduler>(entity =>
            {
                entity.ToTable("tblCallScheduler");

                entity.Property(e => e.CallSchedulerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallbackDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCallScript>(entity =>
            {
                entity.ToTable("tblCallScript");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCampaignList>(entity =>
            {
                entity.ToTable("tblCampaignList");

                entity.Property(e => e.CampaignNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCampaignTempList>(entity =>
            {
                entity.ToTable("tblCampaignTempList");

                entity.Property(e => e.CampaignNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tblCategory");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblChat>(entity =>
            {
                entity.ToTable("tblChat");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.MessageNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNumber).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblChatRoom>(entity =>
            {
                entity.ToTable("tblChatRoom");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomName).HasMaxLength(50);

                entity.Property(e => e.RoomNumber).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblChatRoomMember>(entity =>
            {
                entity.ToTable("tblChatRoomMember");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCheckIn>(entity =>
            {
                entity.ToTable("tblCheckIn");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CheckInNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Place).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.ToTable("tblCity");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.ToTable("tblCompany");

                entity.HasIndex(e => new { e.GroupId, e.CompanyNumber })
                    .HasName("IX_tblCompany");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyAddress>(entity =>
            {
                entity.ToTable("tblCompanyAddress");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyAddress");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyBranch>(entity =>
            {
                entity.ToTable("tblCompanyBranch");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyCategory>(entity =>
            {
                entity.ToTable("tblCompanyCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyContact>(entity =>
            {
                entity.ToTable("tblCompanyContact");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyContact");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyCustomFieldData>(entity =>
            {
                entity.ToTable("tblCompanyCustomFieldData");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyCustomFieldData");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyDetail>(entity =>
            {
                entity.ToTable("tblCompanyDetail");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyDetail");

                entity.Property(e => e.CompanyContactEmail).HasMaxLength(50);

                entity.Property(e => e.CompanyContactName).HasMaxLength(50);

                entity.Property(e => e.CompanyContactPhone).HasMaxLength(50);

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCompanyEmail>(entity =>
            {
                entity.ToTable("tblCompanyEmail");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyEmail");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyPermit>(entity =>
            {
                entity.ToTable("tblCompanyPermit");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyPermit");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanyPhone>(entity =>
            {
                entity.ToTable("tblCompanyPhone");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanyPhone");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanySettings>(entity =>
            {
                entity.ToTable("tblCompanySettings");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanySettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param10).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param11).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param12).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param2).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.Param3).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param4).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param5).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param6).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param7).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param8).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param9).HasDefaultValueSql("('True')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCompanySocial>(entity =>
            {
                entity.ToTable("tblCompanySocial");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCompanySocial");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContact>(entity =>
            {
                entity.ToTable("tblContact");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactAddress>(entity =>
            {
                entity.ToTable("tblContactAddress");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactContact>(entity =>
            {
                entity.ToTable("tblContactContact");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactCustomFieldData>(entity =>
            {
                entity.ToTable("tblContactCustomFieldData");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactDetail>(entity =>
            {
                entity.ToTable("tblContactDetail");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHaveAchild).HasColumnName("IsHaveAChild");

                entity.Property(e => e.MarriageDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactEmail>(entity =>
            {
                entity.ToTable("tblContactEmail");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactEmotion>(entity =>
            {
                entity.ToTable("tblContactEmotion");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactForm>(entity =>
            {
                entity.ToTable("tblContactForm");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactPermit>(entity =>
            {
                entity.ToTable("tblContactPermit");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactPhone>(entity =>
            {
                entity.ToTable("tblContactPhone");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactSettings>(entity =>
            {
                entity.ToTable("tblContactSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param10).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param11).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param12).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param2).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.Param3).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param4).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param5).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param6).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param7).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param8).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param9).HasDefaultValueSql("('True')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContactSocial>(entity =>
            {
                entity.ToTable("tblContactSocial");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContent>(entity =>
            {
                entity.ToTable("tblContent");

                entity.Property(e => e.ContentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.TargetUrl)
                    .HasColumnName("TargetURL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("VideoURL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblContentCategory>(entity =>
            {
                entity.ToTable("tblContentCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContentComment>(entity =>
            {
                entity.ToTable("tblContentComment");

                entity.Property(e => e.ContentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblContentReact>(entity =>
            {
                entity.ToTable("tblContentReact");

                entity.Property(e => e.ContentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.ToTable("tblCountry");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCoupon>(entity =>
            {
                entity.ToTable("tblCoupon");

                entity.Property(e => e.CouponNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCouponData>(entity =>
            {
                entity.ToTable("tblCouponData");

                entity.Property(e => e.CouponNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomField>(entity =>
            {
                entity.ToTable("tblCustomField");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tblCustomer");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_tblCustomer");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SectorId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SegmentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerAddress>(entity =>
            {
                entity.ToTable("tblCustomerAddress");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerContact>(entity =>
            {
                entity.ToTable("tblCustomerContact");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DirectionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerCustomFieldData>(entity =>
            {
                entity.ToTable("tblCustomerCustomFieldData");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerDetail>(entity =>
            {
                entity.ToTable("tblCustomerDetail");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CountryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHaveAchild).HasColumnName("IsHaveAChild");

                entity.Property(e => e.MarriageDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ServiceId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerEmail>(entity =>
            {
                entity.ToTable("tblCustomerEmail");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerEmotion>(entity =>
            {
                entity.ToTable("tblCustomerEmotion");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerPermit>(entity =>
            {
                entity.ToTable("tblCustomerPermit");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerPhone>(entity =>
            {
                entity.ToTable("tblCustomerPhone");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerSettings>(entity =>
            {
                entity.ToTable("tblCustomerSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param10).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param11).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param12).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param2).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.Param3).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param4).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param5).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param6).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param7).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param8).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param9).HasDefaultValueSql("('True')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblCustomerSocial>(entity =>
            {
                entity.ToTable("tblCustomerSocial");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDashboard>(entity =>
            {
                entity.ToTable("tblDashboard");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDealer>(entity =>
            {
                entity.ToTable("tblDealer");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDealerAddress>(entity =>
            {
                entity.ToTable("tblDealerAddress");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDealerArea>(entity =>
            {
                entity.ToTable("tblDealerArea");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDealerEmail>(entity =>
            {
                entity.ToTable("tblDealerEmail");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDealerPhone>(entity =>
            {
                entity.ToTable("tblDealerPhone");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.ToTable("tblDistrict");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblDynamic>(entity =>
            {
                entity.ToTable("tblDynamic");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmailProvider>(entity =>
            {
                entity.ToTable("tblEmailProvider");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Host2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortPop3).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmailSignature>(entity =>
            {
                entity.ToTable("tblEmailSignature");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmailTemplate>(entity =>
            {
                entity.ToTable("tblEmailTemplate");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployee");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeAddress>(entity =>
            {
                entity.ToTable("tblEmployeeAddress");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeAsset>(entity =>
            {
                entity.ToTable("tblEmployeeAsset");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InventoryNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeCustomFieldData>(entity =>
            {
                entity.ToTable("tblEmployeeCustomFieldData");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeDetail>(entity =>
            {
                entity.ToTable("tblEmployeeDetail");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BloodTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerSkills).HasMaxLength(1000);

                entity.Property(e => e.CoursesAndCertification).HasMaxLength(1000);

                entity.Property(e => e.DisabilityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DrivingLicenceTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.EducationStatusId).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHaveAchild).HasColumnName("IsHaveAChild");

                entity.Property(e => e.IsPassport).HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MarriageDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PassportNumber).HasMaxLength(50);

                entity.Property(e => e.Profession).HasMaxLength(50);

                entity.Property(e => e.SchoolName).HasMaxLength(100);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkExperiences).HasMaxLength(1000);
            });

            modelBuilder.Entity<TblEmployeeEmail>(entity =>
            {
                entity.ToTable("tblEmployeeEmail");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeEmotion>(entity =>
            {
                entity.ToTable("tblEmployeeEmotion");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeLeave>(entity =>
            {
                entity.ToTable("tblEmployeeLeave");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeLeaveCategory>(entity =>
            {
                entity.ToTable("tblEmployeeLeaveCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeePhone>(entity =>
            {
                entity.ToTable("tblEmployeePhone");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeSettings>(entity =>
            {
                entity.ToTable("tblEmployeeSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param10).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param11).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param12).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param13)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param14)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param15)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param16)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param17)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param18)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param19)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param2).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param20)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param3).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param4).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param5).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param6).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param7).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param8).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param9).HasDefaultValueSql("('True')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblEmployeeSocial>(entity =>
            {
                entity.ToTable("tblEmployeeSocial");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblExpense>(entity =>
            {
                entity.ToTable("tblExpense");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblExpenseCategory>(entity =>
            {
                entity.ToTable("tblExpenseCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFaq>(entity =>
            {
                entity.ToTable("tblFAQ");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFavorites>(entity =>
            {
                entity.ToTable("tblFavorites");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFeed>(entity =>
            {
                entity.ToTable("tblFeed");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeedNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFeedComment>(entity =>
            {
                entity.ToTable("tblFeedComment");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FeedNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFeedReact>(entity =>
            {
                entity.ToTable("tblFeedReact");

                entity.Property(e => e.FeedNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.ToTable("tblFeedback");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FeedbackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFeedbackCustomFieldData>(entity =>
            {
                entity.ToTable("tblFeedbackCustomFieldData");

                entity.Property(e => e.FeedbackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFeedbackHistory>(entity =>
            {
                entity.ToTable("tblFeedbackHistory");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FeedbackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblForm>(entity =>
            {
                entity.ToTable("tblForm");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FormNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GdprMessage).HasMaxLength(2000);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutoAnswer).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsAutoDistribution).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsEmail).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsGdpr).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsLogo).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsPublish).HasDefaultValueSql("('False')");

                entity.Property(e => e.IsValidate).HasDefaultValueSql("('False')");

                entity.Property(e => e.ModuleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SelectText)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Seçiniz')");

                entity.Property(e => e.SourceId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubmitText)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Kaydet')");

                entity.Property(e => e.SuccessMessage).HasMaxLength(500);

                entity.Property(e => e.SuccessUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFormData>(entity =>
            {
                entity.ToTable("tblFormData");

                entity.Property(e => e.FormNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).IsUnicode(false);

                entity.Property(e => e.Param10).IsUnicode(false);

                entity.Property(e => e.Param2).IsUnicode(false);

                entity.Property(e => e.Param3).IsUnicode(false);

                entity.Property(e => e.Param4).IsUnicode(false);

                entity.Property(e => e.Param5).IsUnicode(false);

                entity.Property(e => e.Param6).IsUnicode(false);

                entity.Property(e => e.Param7).IsUnicode(false);

                entity.Property(e => e.Param8).IsUnicode(false);

                entity.Property(e => e.Param9).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblFormDetail>(entity =>
            {
                entity.ToTable("tblFormDetail");

                entity.Property(e => e.FormNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName).HasMaxLength(500);

                entity.Property(e => e.MappedDbField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.ToTable("tblGroup");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Score).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sector).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftStart)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGroupApi>(entity =>
            {
                entity.ToTable("tblGroupApi");

                entity.Property(e => e.ApiKey).HasMaxLength(50);

                entity.Property(e => e.ApiSecret).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblGroupBanking>(entity =>
            {
                entity.ToTable("tblGroupBanking");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountOwner)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblGroupLanding>(entity =>
            {
                entity.ToTable("tblGroupLanding");

                entity.Property(e => e.Description1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsForms).HasDefaultValueSql("('False')");

                entity.Property(e => e.Slogan1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slogan2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slogan3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblGroupLocation>(entity =>
            {
                entity.ToTable("tblGroupLocation");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftStart)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblGroupSocial>(entity =>
            {
                entity.ToTable("tblGroupSocial");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Other1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Other2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Other3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pinterest)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WhatsApp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Youtube)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGroupSolution>(entity =>
            {
                entity.ToTable("tblGroupSolution");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblHelp>(entity =>
            {
                entity.ToTable("tblHelp");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.HelpNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblImage>(entity =>
            {
                entity.ToTable("tblImage");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblIntegration>(entity =>
            {
                entity.ToTable("tblIntegration");

                entity.Property(e => e.ApiKey)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApiSecret)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IntegrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Param3)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Param4)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Param5)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblInventory>(entity =>
            {
                entity.ToTable("tblInventory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InventoryNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblInvitation>(entity =>
            {
                entity.ToTable("tblInvitation");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvitationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLead>(entity =>
            {
                entity.ToTable("tblLead");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SectorId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SegmentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadAddress>(entity =>
            {
                entity.ToTable("tblLeadAddress");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadContact>(entity =>
            {
                entity.ToTable("tblLeadContact");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadCustomFieldData>(entity =>
            {
                entity.ToTable("tblLeadCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadDetail>(entity =>
            {
                entity.ToTable("tblLeadDetail");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHaveAchild).HasColumnName("IsHaveAChild");

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarriageDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadEmail>(entity =>
            {
                entity.ToTable("tblLeadEmail");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadEmotion>(entity =>
            {
                entity.ToTable("tblLeadEmotion");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadPermit>(entity =>
            {
                entity.ToTable("tblLeadPermit");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadPhone>(entity =>
            {
                entity.ToTable("tblLeadPhone");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadSettings>(entity =>
            {
                entity.ToTable("tblLeadSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param10).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param11).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param12).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param13)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param14)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param15)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param16)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param17)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param18)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param19)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param2).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param20)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Param3).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param4).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param5).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param6).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param7).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param8).HasDefaultValueSql("('True')");

                entity.Property(e => e.Param9).HasDefaultValueSql("('True')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLeadSocial>(entity =>
            {
                entity.ToTable("tblLeadSocial");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblLogEmail>(entity =>
            {
                entity.ToTable("tblLog_Email");

                entity.Property(e => e.Body)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogError>(entity =>
            {
                entity.ToTable("tblLog_Error");

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogLogin>(entity =>
            {
                entity.ToTable("tblLog_Login");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogPage>(entity =>
            {
                entity.ToTable("tblLog_Page");

                entity.HasIndex(e => new { e.GroupId, e.Id })
                    .HasName("IX_tblLog_Page");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogPayment>(entity =>
            {
                entity.ToTable("tblLog_Payment");

                entity.Property(e => e.ConversationId)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogSearch>(entity =>
            {
                entity.ToTable("tblLog_Search");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogSms>(entity =>
            {
                entity.ToTable("tblLog_Sms");

                entity.Property(e => e.Body)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMailbox>(entity =>
            {
                entity.ToTable("tblMailbox");

                entity.Property(e => e.Body)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MailNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedMailNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblModule>(entity =>
            {
                entity.ToTable("tblModule");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_EN")
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.KeywordsEn)
                    .HasColumnName("Keywords_EN")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameEn)
                    .HasColumnName("Name_EN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("Title_EN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("VideoURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VideoUrlEn)
                    .HasColumnName("VideoURL_EN")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblModuleChangeLog>(entity =>
            {
                entity.ToTable("tblModuleChangeLog");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblModuleDetail>(entity =>
            {
                entity.ToTable("tblModuleDetail");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_EN")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNeighborhood>(entity =>
            {
                entity.ToTable("tblNeighborhood");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNote>(entity =>
            {
                entity.ToTable("tblNote");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNoteContent>(entity =>
            {
                entity.ToTable("tblNoteContent");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNps>(entity =>
            {
                entity.ToTable("tblNps");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HighPointTag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LowPointTag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NpsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShortUrl)
                    .HasColumnName("ShortURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNpsData>(entity =>
            {
                entity.ToTable("tblNpsData");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NpsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNpsList>(entity =>
            {
                entity.ToTable("tblNpsList");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NpsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecordNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tblOrder");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.ToTable("tblOrderDetail");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblOrderHistory>(entity =>
            {
                entity.ToTable("tblOrderHistory");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblOrderNoteTemplate>(entity =>
            {
                entity.ToTable("tblOrderNoteTemplate");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblOrderVehicle>(entity =>
            {
                entity.ToTable("tblOrderVehicle");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VehicleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlan>(entity =>
            {
                entity.ToTable("tblPlan");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_EN")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameEn)
                    .HasColumnName("Name_EN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceEn).HasColumnName("Price_EN");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tblProduct");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductCategory>(entity =>
            {
                entity.ToTable("tblProductCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductComment>(entity =>
            {
                entity.ToTable("tblProductComment");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductCustomFieldData>(entity =>
            {
                entity.ToTable("tblProductCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductDetail>(entity =>
            {
                entity.ToTable("tblProductDetail");

                entity.Property(e => e.CriticalStock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Currency).HasDefaultValueSql("((87))");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductList>(entity =>
            {
                entity.ToTable("tblProductList");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductListProduct>(entity =>
            {
                entity.ToTable("tblProductListProduct");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceMax).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProductVendor>(entity =>
            {
                entity.ToTable("tblProductVendor");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.ToTable("tblProject");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposal>(entity =>
            {
                entity.ToTable("tblProposal");

                entity.Property(e => e.Currency).HasDefaultValueSql("((87))");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndingText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProposalNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartingText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalCategory>(entity =>
            {
                entity.ToTable("tblProposalCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poc).HasColumnName("POC");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalCustomFieldData>(entity =>
            {
                entity.ToTable("tblProposalCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalProduct>(entity =>
            {
                entity.ToTable("tblProposalProduct");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalService>(entity =>
            {
                entity.ToTable("tblProposalService");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalSettings>(entity =>
            {
                entity.ToTable("tblProposalSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblProposalTemplate>(entity =>
            {
                entity.ToTable("tblProposalTemplate");

                entity.Property(e => e.DescriptionEnd)
                    .HasColumnName("Description_End")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionStart)
                    .HasColumnName("Description_Start")
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblQuarter>(entity =>
            {
                entity.ToTable("tblQuarter");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRelations>(entity =>
            {
                entity.ToTable("tblRelations");

                entity.Property(e => e.DataNumberFrom)
                    .HasColumnName("DataNumber_From")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumberTo)
                    .HasColumnName("DataNumber_To")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleIdFrom).HasColumnName("ModuleId_From");

                entity.Property(e => e.ModuleIdTo).HasColumnName("ModuleId_To");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblReminder>(entity =>
            {
                entity.ToTable("tblReminder");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReminderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReminderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRequest>(entity =>
            {
                entity.ToTable("tblRequest");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRequestCategory>(entity =>
            {
                entity.ToTable("tblRequestCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRequestHistory>(entity =>
            {
                entity.ToTable("tblRequestHistory");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRequestLink>(entity =>
            {
                entity.ToTable("tblRequestLink");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Param3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Param4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Param5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblReservation>(entity =>
            {
                entity.ToTable("tblReservation");

                entity.Property(e => e.Child)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('False')");

                entity.Property(e => e.Location).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Person)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReservationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblReservationCustomFieldData>(entity =>
            {
                entity.ToTable("tblReservationCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tblRole");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRule>(entity =>
            {
                entity.ToTable("tblRule");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasMaxLength(500);

                entity.Property(e => e.Param10).HasMaxLength(500);

                entity.Property(e => e.Param11).HasMaxLength(500);

                entity.Property(e => e.Param12).HasMaxLength(500);

                entity.Property(e => e.Param13).HasMaxLength(500);

                entity.Property(e => e.Param14).HasMaxLength(500);

                entity.Property(e => e.Param15).HasMaxLength(500);

                entity.Property(e => e.Param16).HasMaxLength(500);

                entity.Property(e => e.Param17).HasMaxLength(500);

                entity.Property(e => e.Param18).HasMaxLength(500);

                entity.Property(e => e.Param19).HasMaxLength(500);

                entity.Property(e => e.Param2).HasMaxLength(500);

                entity.Property(e => e.Param20).HasMaxLength(500);

                entity.Property(e => e.Param3).HasMaxLength(500);

                entity.Property(e => e.Param4).HasMaxLength(500);

                entity.Property(e => e.Param5).HasMaxLength(500);

                entity.Property(e => e.Param6).HasMaxLength(500);

                entity.Property(e => e.Param7).HasMaxLength(500);

                entity.Property(e => e.Param8).HasMaxLength(500);

                entity.Property(e => e.Param9).HasMaxLength(500);

                entity.Property(e => e.RuleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSales>(entity =>
            {
                entity.ToTable("tblSales");

                entity.Property(e => e.Currency).HasDefaultValueSql("((87))");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsShipment).HasDefaultValueSql("('False')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesCategory>(entity =>
            {
                entity.ToTable("tblSalesCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poc).HasColumnName("POC");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesCustomFieldData>(entity =>
            {
                entity.ToTable("tblSalesCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesPayment>(entity =>
            {
                entity.ToTable("tblSalesPayment");

                entity.Property(e => e.Body)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesProduct>(entity =>
            {
                entity.ToTable("tblSalesProduct");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesService>(entity =>
            {
                entity.ToTable("tblSalesService");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSalesShipment>(entity =>
            {
                entity.ToTable("tblSalesShipment");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSector>(entity =>
            {
                entity.ToTable("tblSector");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSegment>(entity =>
            {
                entity.ToTable("tblSegment");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSeller>(entity =>
            {
                entity.ToTable("tblSeller");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("tblService");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblServiceCategory>(entity =>
            {
                entity.ToTable("tblServiceCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblServiceDetail>(entity =>
            {
                entity.ToTable("tblServiceDetail");

                entity.Property(e => e.Currency).HasDefaultValueSql("((87))");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSettings>(entity =>
            {
                entity.ToTable("tblSettings");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActiveConsoleBirthdays)
                    .HasColumnName("IsActive_Console_Birthdays")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleContractdays)
                    .HasColumnName("IsActive_Console_Contractdays")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleDailyReports)
                    .HasColumnName("IsActive_Console_DailyReports")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleLastLogin)
                    .HasColumnName("IsActive_Console_LastLogin")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleReminder)
                    .HasColumnName("IsActive_Console_Reminder")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleSubscriptions)
                    .HasColumnName("IsActive_Console_Subscriptions")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveConsoleUserSubscription)
                    .HasColumnName("IsActive_Console_User_Subscription")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveInvitation)
                    .HasColumnName("IsActive_Invitation")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsActiveStore)
                    .HasColumnName("IsActive_Store")
                    .HasDefaultValueSql("('False')");
            });

            modelBuilder.Entity<TblSmsList>(entity =>
            {
                entity.ToTable("tblSmsList");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSmsListData>(entity =>
            {
                entity.ToTable("tblSmsListData");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSmsprovider>(entity =>
            {
                entity.ToTable("tblSMSProvider");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Originator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostUrl)
                    .HasColumnName("PostURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSmstemplate>(entity =>
            {
                entity.ToTable("tblSMSTemplate");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblStore>(entity =>
            {
                entity.ToTable("tblStore");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ExpireDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblStoreOrder>(entity =>
            {
                entity.ToTable("tblStoreOrder");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubCategory>(entity =>
            {
                entity.ToTable("tblSubCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubscription>(entity =>
            {
                entity.ToTable("tblSubscription");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SubscriptionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubscriptionDetail>(entity =>
            {
                entity.ToTable("tblSubscriptionDetail");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubscriptionPack>(entity =>
            {
                entity.ToTable("tblSubscriptionPack");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PackNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubscriptionSettings>(entity =>
            {
                entity.ToTable("tblSubscriptionSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSubscriptionTemplate>(entity =>
            {
                entity.ToTable("tblSubscriptionTemplate");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblSurveyLead>(entity =>
            {
                entity.ToTable("tblSurveyLead");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Point)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Q1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Q2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Q3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Q4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTag>(entity =>
            {
                entity.ToTable("tblTag");

                entity.Property(e => e.DataNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTarget>(entity =>
            {
                entity.ToTable("tblTarget");

                entity.Property(e => e.Badge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTask>(entity =>
            {
                entity.ToTable("tblTask");

                entity.Property(e => e.Deadline).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShared).HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTaskCategory>(entity =>
            {
                entity.ToTable("tblTaskCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTaskCustomFieldData>(entity =>
            {
                entity.ToTable("tblTaskCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTaskHistory>(entity =>
            {
                entity.ToTable("tblTaskHistory");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTaskResponsible>(entity =>
            {
                entity.ToTable("tblTaskResponsible");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTaskSettings>(entity =>
            {
                entity.ToTable("tblTaskSettings");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param13).HasMaxLength(100);

                entity.Property(e => e.Param14).HasMaxLength(100);

                entity.Property(e => e.Param15).HasMaxLength(100);

                entity.Property(e => e.Param16).HasMaxLength(100);

                entity.Property(e => e.Param17).HasMaxLength(100);

                entity.Property(e => e.Param18).HasMaxLength(100);

                entity.Property(e => e.Param19).HasMaxLength(100);

                entity.Property(e => e.Param20).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTeam>(entity =>
            {
                entity.ToTable("tblTeam");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTransfer>(entity =>
            {
                entity.ToTable("tblTransfer");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param1).HasColumnType("smalldatetime");

                entity.Property(e => e.Param10)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param11)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param12)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param13)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param14)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param15)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param16).HasColumnType("smalldatetime");

                entity.Property(e => e.Param17).HasColumnType("smalldatetime");

                entity.Property(e => e.Param18)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param19).HasColumnType("smalldatetime");

                entity.Property(e => e.Param2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param20).HasColumnType("smalldatetime");

                entity.Property(e => e.Param21).HasColumnType("smalldatetime");

                entity.Property(e => e.Param3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param4).HasColumnType("smalldatetime");

                entity.Property(e => e.Param5).HasColumnType("smalldatetime");

                entity.Property(e => e.Param6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Param7).HasColumnType("smalldatetime");

                entity.Property(e => e.Param8).HasColumnType("smalldatetime");

                entity.Property(e => e.Param9)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransferNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblTransferCustomFieldData>(entity =>
            {
                entity.ToTable("tblTransferCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblType>(entity =>
            {
                entity.ToTable("tblType");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUrl>(entity =>
            {
                entity.ToTable("tblUrl");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalUrl).HasMaxLength(1000);

                entity.Property(e => e.ShortUrl).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUser");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUserDashboard>(entity =>
            {
                entity.ToTable("tblUserDashboard");
            });

            modelBuilder.Entity<TblUserDetail>(entity =>
            {
                entity.ToTable("tblUserDetail");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Team).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblUserExtension>(entity =>
            {
                entity.ToTable("tblUserExtension");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserInvoice>(entity =>
            {
                entity.ToTable("tblUserInvoice");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Luser).HasColumnName("LUser");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUserModule>(entity =>
            {
                entity.ToTable("tblUserModule");
            });

            modelBuilder.Entity<TblUserPrivacy>(entity =>
            {
                entity.ToTable("tblUserPrivacy");

                entity.Property(e => e.IsMailing).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsPhone).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsPush).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsRemote).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsSms).HasDefaultValueSql("('True')");
            });

            modelBuilder.Entity<TblUserRole>(entity =>
            {
                entity.ToTable("tblUserRole");
            });

            modelBuilder.Entity<TblUserStatus>(entity =>
            {
                entity.ToTable("tblUserStatus");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUserStatusLog>(entity =>
            {
                entity.ToTable("tblUserStatusLog");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblUserSubscription>(entity =>
            {
                entity.ToTable("tblUserSubscription");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Luser).HasColumnName("LUser");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblVehicle>(entity =>
            {
                entity.ToTable("tblVehicle");

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendor>(entity =>
            {
                entity.ToTable("tblVendor");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorContactEmail).HasMaxLength(50);

                entity.Property(e => e.VendorContactName).HasMaxLength(50);

                entity.Property(e => e.VendorContactPhone).HasMaxLength(50);

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorAddress>(entity =>
            {
                entity.ToTable("tblVendorAddress");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorBranch>(entity =>
            {
                entity.ToTable("tblVendorBranch");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorContact>(entity =>
            {
                entity.ToTable("tblVendorContact");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorCustomFieldData>(entity =>
            {
                entity.ToTable("tblVendorCustomFieldData");

                entity.Property(e => e.FieldNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorEmail>(entity =>
            {
                entity.ToTable("tblVendorEmail");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorPhone>(entity =>
            {
                entity.ToTable("tblVendorPhone");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
