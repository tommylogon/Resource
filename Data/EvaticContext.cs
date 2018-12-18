using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Resource.Models
{
    public partial class EvaticContext : DbContext
    {
        public EvaticContext()
        {
        }

        public EvaticContext(DbContextOptions<EvaticContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accessories> Accessories { get; set; }
        public virtual DbSet<ActionCode> ActionCode { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AllDates> AllDates { get; set; }
        public virtual DbSet<AppAutoStartWindows> AppAutoStartWindows { get; set; }
        public virtual DbSet<AppClientUpdate> AppClientUpdate { get; set; }
        public virtual DbSet<AppLanguage> AppLanguage { get; set; }
        public virtual DbSet<AppLanguageReplace> AppLanguageReplace { get; set; }
        public virtual DbSet<AppMobileLoginCheck> AppMobileLoginCheck { get; set; }
        public virtual DbSet<AppPermissionObject> AppPermissionObject { get; set; }
        public virtual DbSet<AppRole> AppRole { get; set; }
        public virtual DbSet<AppRolePermission> AppRolePermission { get; set; }
        public virtual DbSet<AppRolePermissionDetails> AppRolePermissionDetails { get; set; }
        public virtual DbSet<AppServerJob> AppServerJob { get; set; }
        public virtual DbSet<AppSettings> AppSettings { get; set; }
        public virtual DbSet<AppSettingsSearch> AppSettingsSearch { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppUserDept> AppUserDept { get; set; }
        public virtual DbSet<AppUserMenu> AppUserMenu { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaPostalCode> AreaPostalCode { get; set; }
        public virtual DbSet<AreaResource> AreaResource { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleAggregated> ArticleAggregated { get; set; }
        public virtual DbSet<ArticleCalcSchema> ArticleCalcSchema { get; set; }
        public virtual DbSet<ArticleDiscount> ArticleDiscount { get; set; }
        public virtual DbSet<ArticleFeeLevel> ArticleFeeLevel { get; set; }
        public virtual DbSet<ArticleGenerations> ArticleGenerations { get; set; }
        public virtual DbSet<ArticleIntegration> ArticleIntegration { get; set; }
        public virtual DbSet<ArticleIntegrationStage> ArticleIntegrationStage { get; set; }
        public virtual DbSet<ArticleIntegrationSupplier> ArticleIntegrationSupplier { get; set; }
        public virtual DbSet<ArticleIntegrationSupplierStage> ArticleIntegrationSupplierStage { get; set; }
        public virtual DbSet<ArticleModelLocation> ArticleModelLocation { get; set; }
        public virtual DbSet<ArticleReplacementArticle> ArticleReplacementArticle { get; set; }
        public virtual DbSet<ArticleSortGroupDefaultValues> ArticleSortGroupDefaultValues { get; set; }
        public virtual DbSet<ArticleSupplier> ArticleSupplier { get; set; }
        public virtual DbSet<BusinessHours> BusinessHours { get; set; }
        public virtual DbSet<CalendarInformation> CalendarInformation { get; set; }
        public virtual DbSet<ChangedWorkHours> ChangedWorkHours { get; set; }
        public virtual DbSet<CheckList> CheckList { get; set; }
        public virtual DbSet<CheckListModelDependencies> CheckListModelDependencies { get; set; }
        public virtual DbSet<CheckListSymptomDependencies> CheckListSymptomDependencies { get; set; }
        public virtual DbSet<CheckListTree> CheckListTree { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompetenceGroup> CompetenceGroup { get; set; }
        public virtual DbSet<CompetenceGroupDetails> CompetenceGroupDetails { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactEmail> ContactEmail { get; set; }
        public virtual DbSet<ContactReference> ContactReference { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractCreditArticle> ContractCreditArticle { get; set; }
        public virtual DbSet<ContractCreditCustomer> ContractCreditCustomer { get; set; }
        public virtual DbSet<ContractFixedPrice> ContractFixedPrice { get; set; }
        public virtual DbSet<ContractFixedPriceAutoTasks> ContractFixedPriceAutoTasks { get; set; }
        public virtual DbSet<ContractIncludedArticles> ContractIncludedArticles { get; set; }
        public virtual DbSet<ContractIncludedArticlesUsed> ContractIncludedArticlesUsed { get; set; }
        public virtual DbSet<ContractInvoiceFee> ContractInvoiceFee { get; set; }
        public virtual DbSet<ContractInvoiceHeadingTemp> ContractInvoiceHeadingTemp { get; set; }
        public virtual DbSet<ContractInvoiceLineTemp> ContractInvoiceLineTemp { get; set; }
        public virtual DbSet<ContractMeterArticleConsumable> ContractMeterArticleConsumable { get; set; }
        public virtual DbSet<ContractMeterDetails> ContractMeterDetails { get; set; }
        public virtual DbSet<ContractPartCreditChanges> ContractPartCreditChanges { get; set; }
        public virtual DbSet<ContractPeriodVolume> ContractPeriodVolume { get; set; }
        public virtual DbSet<ContractPrepaidUnits> ContractPrepaidUnits { get; set; }
        public virtual DbSet<ContractPrepaidUnitsArticles> ContractPrepaidUnitsArticles { get; set; }
        public virtual DbSet<ContractPrice> ContractPrice { get; set; }
        public virtual DbSet<ContractTemplate> ContractTemplate { get; set; }
        public virtual DbSet<ContractTemplateFixedPrice> ContractTemplateFixedPrice { get; set; }
        public virtual DbSet<ContractTemplateMeterPriceLevel> ContractTemplateMeterPriceLevel { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<ContractTypeArticle> ContractTypeArticle { get; set; }
        public virtual DbSet<ContractTypeGroups> ContractTypeGroups { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CreditTerms> CreditTerms { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerBalance> CustomerBalance { get; set; }
        public virtual DbSet<CustomerInvoicing> CustomerInvoicing { get; set; }
        public virtual DbSet<CustomerInvoicingMeterDetails> CustomerInvoicingMeterDetails { get; set; }
        public virtual DbSet<CustomerMachineModelMeterPrice> CustomerMachineModelMeterPrice { get; set; }
        public virtual DbSet<CustomerMailFormat> CustomerMailFormat { get; set; }
        public virtual DbSet<CustomerPayment> CustomerPayment { get; set; }
        public virtual DbSet<CustomerTechnician> CustomerTechnician { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<DatabaseTextLog> DatabaseTextLog { get; set; }
        public virtual DbSet<DefaultServicesArticles> DefaultServicesArticles { get; set; }
        public virtual DbSet<DefaultWorkHours> DefaultWorkHours { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentTrans> DocumentTrans { get; set; }
        public virtual DbSet<EmpChecker> EmpChecker { get; set; }
        public virtual DbSet<EpwIdSettings> EpwIdSettings { get; set; }
        public virtual DbSet<EvaticDataType> EvaticDataType { get; set; }
        public virtual DbSet<ExternalSoldItems> ExternalSoldItems { get; set; }
        public virtual DbSet<ExternalStockAdminOrderHeading> ExternalStockAdminOrderHeading { get; set; }
        public virtual DbSet<ExternalStockAdminOrderLine> ExternalStockAdminOrderLine { get; set; }
        public virtual DbSet<ExternalStockAdminOrderLineReceived> ExternalStockAdminOrderLineReceived { get; set; }
        public virtual DbSet<FollowUp> FollowUp { get; set; }
        public virtual DbSet<FrequenceList> FrequenceList { get; set; }
        public virtual DbSet<IncidentStatus> IncidentStatus { get; set; }
        public virtual DbSet<InforegGroups> InforegGroups { get; set; }
        public virtual DbSet<InforegGroupValues> InforegGroupValues { get; set; }
        public virtual DbSet<Information> Information { get; set; }
        public virtual DbSet<InformationLink> InformationLink { get; set; }
        public virtual DbSet<InvoiceHeading> InvoiceHeading { get; set; }
        public virtual DbSet<InvoiceLayout> InvoiceLayout { get; set; }
        public virtual DbSet<InvoiceLog> InvoiceLog { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayment { get; set; }
        public virtual DbSet<InvoiceSetupDetail> InvoiceSetupDetail { get; set; }
        public virtual DbSet<LinkArticleMapping> LinkArticleMapping { get; set; }
        public virtual DbSet<LinkObjectMapping> LinkObjectMapping { get; set; }
        public virtual DbSet<LinkSettings> LinkSettings { get; set; }
        public virtual DbSet<LinkTransportLog> LinkTransportLog { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineConsumableLevel> MachineConsumableLevel { get; set; }
        public virtual DbSet<MachineConsumableMeterReading> MachineConsumableMeterReading { get; set; }
        public virtual DbSet<MachineData> MachineData { get; set; }
        public virtual DbSet<MachineLeasingInformation> MachineLeasingInformation { get; set; }
        public virtual DbSet<MachineOnContract> MachineOnContract { get; set; }
        public virtual DbSet<MachineRelation> MachineRelation { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<MailAutoServer> MailAutoServer { get; set; }
        public virtual DbSet<Meter> Meter { get; set; }
        public virtual DbSet<MeterArticleEstimated> MeterArticleEstimated { get; set; }
        public virtual DbSet<MeterOnContract> MeterOnContract { get; set; }
        public virtual DbSet<MeterReading> MeterReading { get; set; }
        public virtual DbSet<MeterReadingEstimated> MeterReadingEstimated { get; set; }
        public virtual DbSet<MeterReadingImport> MeterReadingImport { get; set; }
        public virtual DbSet<MeterReadingLog> MeterReadingLog { get; set; }
        public virtual DbSet<MeterReadingOldValues> MeterReadingOldValues { get; set; }
        public virtual DbSet<MeterReadingValidation> MeterReadingValidation { get; set; }
        public virtual DbSet<MeterTypeConvertTable> MeterTypeConvertTable { get; set; }
        public virtual DbSet<MobileOrderHeading> MobileOrderHeading { get; set; }
        public virtual DbSet<MobileOrderLine> MobileOrderLine { get; set; }
        public virtual DbSet<MobileSession> MobileSession { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<ModelArticleGroupWarranty> ModelArticleGroupWarranty { get; set; }
        public virtual DbSet<ModelDefaultServicesCode> ModelDefaultServicesCode { get; set; }
        public virtual DbSet<ModelMeter> ModelMeter { get; set; }
        public virtual DbSet<ModelMeterPrice> ModelMeterPrice { get; set; }
        public virtual DbSet<ModelMeterToner> ModelMeterToner { get; set; }
        public virtual DbSet<ModelSymptomHelpText> ModelSymptomHelpText { get; set; }
        public virtual DbSet<ModelVirtualMeterDependencies> ModelVirtualMeterDependencies { get; set; }
        public virtual DbSet<OrderDefaultArticles> OrderDefaultArticles { get; set; }
        public virtual DbSet<OrderHeading> OrderHeading { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<OrderLineArticleSerialNumber> OrderLineArticleSerialNumber { get; set; }
        public virtual DbSet<OrderLineInvoice> OrderLineInvoice { get; set; }
        public virtual DbSet<OrderLineMachine> OrderLineMachine { get; set; }
        public virtual DbSet<OrderLinePackingSlip> OrderLinePackingSlip { get; set; }
        public virtual DbSet<OrderLinePartCreditChanges> OrderLinePartCreditChanges { get; set; }
        public virtual DbSet<OrderLineWorkHourListStatus> OrderLineWorkHourListStatus { get; set; }
        public virtual DbSet<OrderNo> OrderNo { get; set; }
        public virtual DbSet<OrderSupportMateriel> OrderSupportMateriel { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<PackingSlipHeading> PackingSlipHeading { get; set; }
        public virtual DbSet<PostalCode> PostalCode { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<PriceChangeLog> PriceChangeLog { get; set; }
        public virtual DbSet<PriceChangeProjectAutoLog> PriceChangeProjectAutoLog { get; set; }
        public virtual DbSet<PriceLevel> PriceLevel { get; set; }
        public virtual DbSet<PrintLanguage> PrintLanguage { get; set; }
        public virtual DbSet<PrintLayout> PrintLayout { get; set; }
        public virtual DbSet<PriorityCode> PriorityCode { get; set; }
        public virtual DbSet<PriorityCodeSupport> PriorityCodeSupport { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<ProblemMachine> ProblemMachine { get; set; }
        public virtual DbSet<ProblemTask> ProblemTask { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectActivity> ProjectActivity { get; set; }
        public virtual DbSet<ProjectAuto> ProjectAuto { get; set; }
        public virtual DbSet<ProjectAutoActivity> ProjectAutoActivity { get; set; }
        public virtual DbSet<ProjectAutoTask> ProjectAutoTask { get; set; }
        public virtual DbSet<ProjectPreorder> ProjectPreorder { get; set; }
        public virtual DbSet<ProjectTask> ProjectTask { get; set; }
        public virtual DbSet<ProjectTaskAuto> ProjectTaskAuto { get; set; }
        public virtual DbSet<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
        public virtual DbSet<ProjectTaskCheckListAuto> ProjectTaskCheckListAuto { get; set; }
        public virtual DbSet<ProjectTaskCheckListTreeFiles> ProjectTaskCheckListTreeFiles { get; set; }
        public virtual DbSet<ProjectTaskCheckListTreeValues> ProjectTaskCheckListTreeValues { get; set; }
        public virtual DbSet<ProjectTaskResource> ProjectTaskResource { get; set; }
        public virtual DbSet<ProjectTaskResourceAuto> ProjectTaskResourceAuto { get; set; }
        public virtual DbSet<ProjectTaskStartStop> ProjectTaskStartStop { get; set; }
        public virtual DbSet<ProjectTaskUndoCheckOut> ProjectTaskUndoCheckOut { get; set; }
        public virtual DbSet<ProjectTemplate> ProjectTemplate { get; set; }
        public virtual DbSet<ProjectTemplateTasks> ProjectTemplateTasks { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyValues> PropertyValues { get; set; }
        public virtual DbSet<QuickOrderArticles> QuickOrderArticles { get; set; }
        public virtual DbSet<QuickOrderArticlesDefaultValues> QuickOrderArticlesDefaultValues { get; set; }
        public virtual DbSet<Recurrence> Recurrence { get; set; }
        public virtual DbSet<RemoteAccess> RemoteAccess { get; set; }
        public virtual DbSet<ReportLayout> ReportLayout { get; set; }
        public virtual DbSet<SaleBookmark> SaleBookmark { get; set; }
        public virtual DbSet<SaleBusinessCode> SaleBusinessCode { get; set; }
        public virtual DbSet<SaleCalcContractModel> SaleCalcContractModel { get; set; }
        public virtual DbSet<SaleCalcContractRow> SaleCalcContractRow { get; set; }
        public virtual DbSet<SaleCalcHeading> SaleCalcHeading { get; set; }
        public virtual DbSet<SaleCalcIntervalGroup> SaleCalcIntervalGroup { get; set; }
        public virtual DbSet<SaleCalcIntervalMeter> SaleCalcIntervalMeter { get; set; }
        public virtual DbSet<SaleCalcLeasing> SaleCalcLeasing { get; set; }
        public virtual DbSet<SaleCalcMeterData> SaleCalcMeterData { get; set; }
        public virtual DbSet<SaleCalcMeterDataVirtualDep> SaleCalcMeterDataVirtualDep { get; set; }
        public virtual DbSet<SaleCalcOldContract> SaleCalcOldContract { get; set; }
        public virtual DbSet<SaleCalcSubscription> SaleCalcSubscription { get; set; }
        public virtual DbSet<SaleCalcTargetPrice> SaleCalcTargetPrice { get; set; }
        public virtual DbSet<SaleCathegory> SaleCathegory { get; set; }
        public virtual DbSet<SaleCustomerExtMachine> SaleCustomerExtMachine { get; set; }
        public virtual DbSet<SaleCustomerMail> SaleCustomerMail { get; set; }
        public virtual DbSet<SaleDeletedItems> SaleDeletedItems { get; set; }
        public virtual DbSet<SaleDocument> SaleDocument { get; set; }
        public virtual DbSet<SaleDocumentType> SaleDocumentType { get; set; }
        public virtual DbSet<SaleGridlayout> SaleGridlayout { get; set; }
        public virtual DbSet<SaleGroup> SaleGroup { get; set; }
        public virtual DbSet<SaleGroupSelected> SaleGroupSelected { get; set; }
        public virtual DbSet<SaleLevel> SaleLevel { get; set; }
        public virtual DbSet<SaleMailconfig> SaleMailconfig { get; set; }
        public virtual DbSet<SaleMailSent> SaleMailSent { get; set; }
        public virtual DbSet<SaleNote> SaleNote { get; set; }
        public virtual DbSet<SaleOrderLine> SaleOrderLine { get; set; }
        public virtual DbSet<SaleOrderLineMachine> SaleOrderLineMachine { get; set; }
        public virtual DbSet<SaleProperty> SaleProperty { get; set; }
        public virtual DbSet<SaleReport> SaleReport { get; set; }
        public virtual DbSet<SaleSaleproject> SaleSaleproject { get; set; }
        public virtual DbSet<Salesman> Salesman { get; set; }
        public virtual DbSet<SaleTask> SaleTask { get; set; }
        public virtual DbSet<SdVersion> SdVersion { get; set; }
        public virtual DbSet<SdVersionFiles> SdVersionFiles { get; set; }
        public virtual DbSet<ServicesArticles> ServicesArticles { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockAdminArticle> StockAdminArticle { get; set; }
        public virtual DbSet<StockAdminArticleSerialNo> StockAdminArticleSerialNo { get; set; }
        public virtual DbSet<StockAdminHistory> StockAdminHistory { get; set; }
        public virtual DbSet<StockAdminOrderHeading> StockAdminOrderHeading { get; set; }
        public virtual DbSet<StockAdminOrderLine> StockAdminOrderLine { get; set; }
        public virtual DbSet<StockAdminOrderLineReceived> StockAdminOrderLineReceived { get; set; }
        public virtual DbSet<StockQty> StockQty { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierDept> SupplierDept { get; set; }
        public virtual DbSet<SupplierOrderHeading> SupplierOrderHeading { get; set; }
        public virtual DbSet<SupplierOrderLine> SupplierOrderLine { get; set; }
        public virtual DbSet<SymptomCode> SymptomCode { get; set; }
        public virtual DbSet<SymptomCodeDefaultNode> SymptomCodeDefaultNode { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamNodes> TeamNodes { get; set; }
        public virtual DbSet<Technician> Technician { get; set; }
        public virtual DbSet<TechnicianAvailability> TechnicianAvailability { get; set; }
        public virtual DbSet<TechnicianAvailabilityType> TechnicianAvailabilityType { get; set; }
        public virtual DbSet<TechnicianCompetence> TechnicianCompetence { get; set; }
        public virtual DbSet<TechnicianGpsCoordinates> TechnicianGpsCoordinates { get; set; }
        public virtual DbSet<TechnicianPlannerNode> TechnicianPlannerNode { get; set; }
        public virtual DbSet<TechnicianPushLog> TechnicianPushLog { get; set; }
        public virtual DbSet<TechnicianPushToken> TechnicianPushToken { get; set; }
        public virtual DbSet<TechnicianServicesArticles> TechnicianServicesArticles { get; set; }
        public virtual DbSet<TechnicianServicesArticlesPrice> TechnicianServicesArticlesPrice { get; set; }
        public virtual DbSet<TechnicianTeams> TechnicianTeams { get; set; }
        public virtual DbSet<TempOldCheckListValues> TempOldCheckListValues { get; set; }
        public virtual DbSet<TempOldProjectTaskCheckListValues> TempOldProjectTaskCheckListValues { get; set; }
        public virtual DbSet<Tree> Tree { get; set; }
        public virtual DbSet<UserIdentity> UserIdentity { get; set; }
        public virtual DbSet<VolumeHistory> VolumeHistory { get; set; }
        public virtual DbSet<Warranty> Warranty { get; set; }
        public virtual DbSet<WebErrorLogins> WebErrorLogins { get; set; }
        public virtual DbSet<WebFieldHelpText> WebFieldHelpText { get; set; }

        // Unable to generate entity type for table 'dbo.WEBNET_ORDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WEEK_NO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CONTRACT_TEMPLATE_METER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.METER_READING_WEB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUDIT_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILE_ORDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SALE_SALEPROJECT_STATE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILE_ORDER_INCOMING_BACKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILE_SYNC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMET_WARRANTY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PROJECT_TASK_COMPENSATION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STOCK_ADMIN_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EPORT_LINK_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EPORT_ORDER_HEADING'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EPORT_ORDER_LINE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXTERNAL_IMPORT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXTERNAL_STOCK_QTY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ORDER_SALESMAN_PROVISION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SALE_CALC_FIXED_PRICE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.INVOICE_SETUP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LEASING'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRICE_DISCOUNT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LETTERS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JOBLIST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TECHNICIAN_START_STOP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TRANSFORM_VALUE'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Program.Settings.ConnectionStrings["ResourceContext"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessories>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.AccNo });

                entity.ToTable("ACCESSORIES");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.AccNo)
                    .HasColumnName("ACC_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.Accessories)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACCESSORIES_ARTICLE_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.Accessories)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACCESSORIES_MACHINE_FK");
            });

            modelBuilder.Entity<ActionCode>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code });

                entity.ToTable("ACTION_CODE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(3);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.ActionCode)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACTION_CODE_COMPANY_FK");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.RowNo });

                entity.ToTable("ADDRESS");

                entity.HasIndex(e => e.AddressName)
                    .HasName("IDX_ADR_ADDRESS_NAME");

                entity.HasIndex(e => e.AreaObjNo)
                    .HasName("IDX_AREA_OBJ_NO");

                entity.HasIndex(e => new { e.SourceObjNo, e.Invoice, e.RowNo, e.PostalCode, e.Description })
                    .HasName("IDX_ADDRESS_TYPE_AND_POSTAL");

                entity.HasIndex(e => new { e.SourceObjNo, e.Address1, e.AddressName, e.Description, e.Address2, e.PhoneNo, e.PostalCode })
                    .HasName("IDX_ADDRESS_MANY");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AddressCode)
                    .HasColumnName("ADDRESS_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.AddressId)
                    .HasColumnName("ADDRESS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AddressName)
                    .HasColumnName("ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.AddressStatus)
                    .IsRequired()
                    .HasColumnName("ADDRESS_STATUS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.BankAccount)
                    .HasColumnName("BANK_ACCOUNT")
                    .HasMaxLength(30);

                entity.Property(e => e.BankId)
                    .HasColumnName("BANK_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.BankName)
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.CoordX)
                    .HasColumnName("COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CoordY)
                    .HasColumnName("COORD_Y")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.Delivery)
                    .HasColumnName("DELIVERY")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Invoice)
                    .HasColumnName("INVOICE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceAsEmail)
                    .HasColumnName("INVOICE_AS_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceAsEmailAddress)
                    .HasColumnName("INVOICE_AS_EMAIL_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Letter)
                    .HasColumnName("LETTER")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MainAddress)
                    .HasColumnName("MAIN_ADDRESS")
                    .HasMaxLength(1);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.TravelCode)
                    .HasColumnName("TRAVEL_CODE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Visit)
                    .HasColumnName("VISIT")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("ADDRESS_COUNTRY_FK");
            });

            modelBuilder.Entity<AllDates>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("ALL_DATES");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE_")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AppAutoStartWindows>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("APP_AUTO_START_WINDOWS");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenIn)
                    .IsRequired()
                    .HasColumnName("OPEN_IN")
                    .HasMaxLength(20);

                entity.Property(e => e.Parameters)
                    .HasColumnName("PARAMETERS")
                    .HasMaxLength(250);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Usermame)
                    .IsRequired()
                    .HasColumnName("USERMAME")
                    .HasMaxLength(30);

                entity.Property(e => e.ValidTo)
                    .HasColumnName("VALID_TO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AppClientUpdate>(entity =>
            {
                entity.HasKey(e => new { e.SetupProgram, e.SetupFilename });

                entity.ToTable("APP_CLIENT_UPDATE");

                entity.Property(e => e.SetupProgram)
                    .HasColumnName("SETUP_PROGRAM")
                    .HasMaxLength(50);

                entity.Property(e => e.SetupFilename)
                    .HasColumnName("SETUP_FILENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.SetupFile)
                    .IsRequired()
                    .HasColumnName("SETUP_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusChangeDate)
                    .HasColumnName("STATUS_CHANGE_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AppLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("APP_LANGUAGE");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.LangDesc)
                    .IsRequired()
                    .HasColumnName("LANG_DESC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AppLanguageReplace>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.OrigionalText });

                entity.ToTable("APP_LANGUAGE_REPLACE");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.OrigionalText)
                    .HasColumnName("ORIGIONAL_TEXT")
                    .HasMaxLength(256);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OrderBy)
                    .HasColumnName("ORDER_BY")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ReplaceText)
                    .IsRequired()
                    .HasColumnName("REPLACE_TEXT")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AppMobileLoginCheck>(entity =>
            {
                entity.HasKey(e => e.ResourceObjNo);

                entity.ToTable("APP_MOBILE_LOGIN_CHECK");

                entity.Property(e => e.ResourceObjNo)
                    .HasColumnName("RESOURCE_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SESSION_ID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AppPermissionObject>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("APP_PERMISSION_OBJECT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasColumnName("PERMISSION_NAME")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("APP_ROLE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("ROLE_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.SettingsAccess)
                    .HasColumnName("SETTINGS_ACCESS")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<AppRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleObjNo, e.PermissionObjNo });

                entity.ToTable("APP_ROLE_PERMISSION");

                entity.Property(e => e.RoleObjNo).HasColumnName("ROLE_OBJ_NO");

                entity.Property(e => e.PermissionObjNo).HasColumnName("PERMISSION_OBJ_NO");

                entity.Property(e => e.PermissionCode)
                    .HasColumnName("PERMISSION_CODE")
                    .HasMaxLength(1);

                entity.HasOne(d => d.PermissionObjNoNavigation)
                    .WithMany(p => p.AppRolePermission)
                    .HasForeignKey(d => d.PermissionObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("APP_ROLE_PERMISSION_PERMISSION_FK");

                entity.HasOne(d => d.RoleObjNoNavigation)
                    .WithMany(p => p.AppRolePermission)
                    .HasForeignKey(d => d.RoleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("APP_ROLE_PERMISSION_ROLE_FK");
            });

            modelBuilder.Entity<AppRolePermissionDetails>(entity =>
            {
                entity.HasKey(e => new { e.RoleObjNo, e.PermissionObjNo, e.DetailType });

                entity.ToTable("APP_ROLE_PERMISSION_DETAILS");

                entity.Property(e => e.RoleObjNo).HasColumnName("ROLE_OBJ_NO");

                entity.Property(e => e.PermissionObjNo).HasColumnName("PERMISSION_OBJ_NO");

                entity.Property(e => e.DetailType)
                    .HasColumnName("DETAIL_TYPE")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DetailCode)
                    .HasColumnName("DETAIL_CODE")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<AppServerJob>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("APP_SERVER_JOB");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExecutedInformation)
                    .HasColumnName("EXECUTED_INFORMATION")
                    .HasMaxLength(1024);

                entity.Property(e => e.JobType).HasColumnName("JOB_TYPE");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDateExecuted)
                    .HasColumnName("OBJ_DATE_EXECUTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Parameters)
                    .HasColumnName("PARAMETERS")
                    .HasMaxLength(1024);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppSettings>(entity =>
            {
                entity.HasKey(e => new { e.SettingUser, e.SettingKey, e.SubKey });

                entity.ToTable("APP_SETTINGS");

                entity.Property(e => e.SettingUser)
                    .HasColumnName("SETTING_USER")
                    .HasMaxLength(32);

                entity.Property(e => e.SettingKey)
                    .HasColumnName("SETTING_KEY")
                    .HasMaxLength(32);

                entity.Property(e => e.SubKey)
                    .HasColumnName("SUB_KEY")
                    .HasMaxLength(40);

                entity.Property(e => e.Setting)
                    .HasColumnName("SETTING")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<AppSettingsSearch>(entity =>
            {
                entity.HasKey(e => new { e.LoginName, e.SearchType, e.SearchName, e.RowIndex });

                entity.ToTable("APP_SETTINGS_SEARCH");

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.SearchType)
                    .HasColumnName("SEARCH_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.SearchName)
                    .HasColumnName("SEARCH_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.RowIndex)
                    .HasColumnName("ROW_INDEX")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.RowContents)
                    .HasColumnName("ROW_CONTENTS")
                    .HasMaxLength(255);

                entity.HasOne(d => d.LoginNameNavigation)
                    .WithMany(p => p.AppSettingsSearch)
                    .HasForeignKey(d => d.LoginName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("APP_SETTINGS_SEARCH_FK");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.LoginName);

                entity.ToTable("APP_USER");

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryNo)
                    .HasColumnName("COUNTRY_NO")
                    .HasMaxLength(5);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.DisableCheckForExcel)
                    .HasColumnName("DISABLE_CHECK_FOR_EXCEL")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchMail)
                    .HasColumnName("EXCH_MAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(55);

                entity.Property(e => e.Inactive)
                    .HasColumnName("INACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLoginEsObjDate)
                    .HasColumnName("LAST_LOGIN_ES_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkObjNo).HasColumnName("LINK_OBJ_NO");

                entity.Property(e => e.ProgramLanguage)
                    .HasColumnName("PROGRAM_LANGUAGE")
                    .HasMaxLength(20);

                entity.Property(e => e.ReportLanguage)
                    .HasColumnName("REPORT_LANGUAGE")
                    .HasMaxLength(20);

                entity.Property(e => e.RoleObjNo).HasColumnName("ROLE_OBJ_NO");

                entity.Property(e => e.ShowOnlyDefAppLanguage)
                    .HasColumnName("SHOW_ONLY_DEF_APP_LANGUAGE")
                    .HasMaxLength(1);

                entity.Property(e => e.ShowOnlyDefPrintLanguage)
                    .HasColumnName("SHOW_ONLY_DEF_PRINT_LANGUAGE")
                    .HasMaxLength(1);

                entity.Property(e => e.ShowOnlyOwn)
                    .HasColumnName("SHOW_ONLY_OWN")
                    .HasMaxLength(1);

                entity.Property(e => e.ShowOnlyOwnArticle)
                    .HasColumnName("SHOW_ONLY_OWN_ARTICLE")
                    .HasMaxLength(1);

                entity.Property(e => e.SyncMachine)
                    .HasColumnName("SYNC_MACHINE")
                    .HasMaxLength(20);

                entity.Property(e => e.SyncStatus)
                    .HasColumnName("SYNC_STATUS")
                    .HasMaxLength(15);

                entity.Property(e => e.SyncTimeIn)
                    .HasColumnName("SYNC_TIME_IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.SyncTimeOut)
                    .HasColumnName("SYNC_TIME_OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.UseMap).HasColumnName("USE_MAP");

                entity.Property(e => e.UserType)
                    .HasColumnName("USER_TYPE")
                    .HasMaxLength(1);

                entity.HasOne(d => d.RoleObjNoNavigation)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.RoleObjNo)
                    .HasConstraintName("APP_USER_ROLE_FK");
            });

            modelBuilder.Entity<AppUserDept>(entity =>
            {
                entity.HasKey(e => new { e.LoginName, e.Company, e.Dept });

                entity.ToTable("APP_USER_DEPT");

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.LoginNameNavigation)
                    .WithMany(p => p.AppUserDept)
                    .HasForeignKey(d => d.LoginName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APP_USER_DEPT_APP_USER");
            });

            modelBuilder.Entity<AppUserMenu>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.LoginName, e.MenuId });

                entity.ToTable("APP_USER_MENU");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.MenuId)
                    .HasColumnName("MENU_ID")
                    .HasMaxLength(90);

                entity.Property(e => e.OnMenu).HasColumnName("ON_MENU");

                entity.Property(e => e.OnToolbar).HasColumnName("ON_TOOLBAR");

                entity.Property(e => e.OrderBy)
                    .HasColumnName("ORDER_BY")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("AREA");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasColumnName("AREA_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.DistanceKm)
                    .HasColumnName("DISTANCE_KM")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TravelCostPrice)
                    .HasColumnName("TRAVEL_COST_PRICE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TravelSalesPrice)
                    .HasColumnName("TRAVEL_SALES_PRICE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TravelTime)
                    .HasColumnName("TRAVEL_TIME")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AREA_COMPANY_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .HasConstraintName("AREA_DEPT_FK");
            });

            modelBuilder.Entity<AreaPostalCode>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("AREA_POSTAL_CODE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FromCountry)
                    .IsRequired()
                    .HasColumnName("FROM_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.FromPostalCode)
                    .IsRequired()
                    .HasColumnName("FROM_POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ToCountry)
                    .IsRequired()
                    .HasColumnName("TO_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.ToPostalCode)
                    .IsRequired()
                    .HasColumnName("TO_POSTAL_CODE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AreaResource>(entity =>
            {
                entity.HasKey(e => new { e.AreaObjNo, e.TechnicianObjNo });

                entity.ToTable("AREA_RESOURCE");

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.AreaResource)
                    .HasForeignKey(d => d.AreaObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AREA_RESOURCE_AREA_FK");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.AreaResource)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AREA_RESOURCE_TECH_FK");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ARTICLE");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX__ARTICLE_OBJ_NO")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.Company, e.ArticleNo })
                    .HasName("IDX_ARTICLE_ARTICLE_NO");

                entity.HasIndex(e => new { e.Company, e.ExternalId })
                    .HasName("IDX_ARTICLE_EXTERNAL");

                entity.HasIndex(e => new { e.Company, e.ExternalId, e.ExternalSystemOn })
                    .HasName("IDX_ARTICLE_EXTERNAL_ON");

                entity.HasIndex(e => new { e.ObjNo, e.ArticleNo, e.ArticleDescription })
                    .HasName("IDX_ARTICLE_OBJ_NO_DESC");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.AccountNoPurchase)
                    .HasColumnName("ACCOUNT_NO_PURCHASE")
                    .HasMaxLength(10);

                entity.Property(e => e.AccountNoStock)
                    .HasColumnName("ACCOUNT_NO_STOCK")
                    .HasMaxLength(10);

                entity.Property(e => e.AdjustSalesprices)
                    .HasColumnName("ADJUST_SALESPRICES")
                    .HasMaxLength(1);

                entity.Property(e => e.AggregatedArticle)
                    .HasColumnName("AGGREGATED_ARTICLE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleDescrForward)
                    .HasColumnName("ARTICLE_DESCR_FORWARD")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleDescription)
                    .HasColumnName("ARTICLE_DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.ArticleInfo)
                    .HasColumnName("ARTICLE_INFO")
                    .HasMaxLength(1500);

                entity.Property(e => e.ArticleInfoInternal)
                    .HasColumnName("ARTICLE_INFO_INTERNAL")
                    .HasMaxLength(500);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleNoForward)
                    .HasColumnName("ARTICLE_NO_FORWARD")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleNoSupplier)
                    .HasColumnName("ARTICLE_NO_SUPPLIER")
                    .HasMaxLength(20);

                entity.Property(e => e.ArticleSearchname)
                    .HasColumnName("ARTICLE_SEARCHNAME")
                    .HasMaxLength(250);

                entity.Property(e => e.ArticleStatus)
                    .IsRequired()
                    .HasColumnName("ARTICLE_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.CalcAutoadjustFromSummary).HasColumnName("CALC_AUTOADJUST_FROM_SUMMARY");

                entity.Property(e => e.CalcChangeSalesprice).HasColumnName("CALC_CHANGE_SALESPRICE");

                entity.Property(e => e.CalcSchemaNo).HasColumnName("CALC_SCHEMA_NO");

                entity.Property(e => e.CampaignFrom)
                    .HasColumnName("CAMPAIGN_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CampaignPrice)
                    .HasColumnName("CAMPAIGN_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CampaignTo)
                    .HasColumnName("CAMPAIGN_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CampainNo)
                    .HasColumnName("CAMPAIN_NO")
                    .HasMaxLength(7);

                entity.Property(e => e.CodeInSalemanual).HasColumnName("CODE_IN_SALEMANUAL");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CostGroup)
                    .HasColumnName("COST_GROUP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CostListPrice)
                    .HasColumnName("COST_LIST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateForwarded)
                    .HasColumnName("DATE_FORWARDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EanNo)
                    .HasColumnName("EAN_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.EcoTaxCalculate)
                    .HasColumnName("ECO_TAX_CALCULATE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EcoTaxCode)
                    .HasColumnName("ECO_TAX_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalSystemOn)
                    .HasColumnName("EXTERNAL_SYSTEM_ON")
                    .HasMaxLength(1);

                entity.Property(e => e.FeeCalculate)
                    .HasColumnName("FEE_CALCULATE")
                    .HasMaxLength(1);

                entity.Property(e => e.FeeLevel)
                    .HasColumnName("FEE_LEVEL")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.InSalemanual).HasColumnName("IN_SALEMANUAL");

                entity.Property(e => e.LastChangeCostPrice)
                    .HasColumnName("LAST_CHANGE_COST_PRICE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangePrice1)
                    .HasColumnName("LAST_CHANGE_PRICE_1")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangePrice2)
                    .HasColumnName("LAST_CHANGE_PRICE_2")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangePrice3)
                    .HasColumnName("LAST_CHANGE_PRICE_3")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangePrice4)
                    .HasColumnName("LAST_CHANGE_PRICE_4")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangePrice5)
                    .HasColumnName("LAST_CHANGE_PRICE_5")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxDiscountPercent)
                    .HasColumnName("MAX_DISCOUNT_PERCENT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.MeanCostPrice)
                    .HasColumnName("MEAN_COST_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.NotUseTargetPrice).HasColumnName("NOT_USE_TARGET_PRICE");

                entity.Property(e => e.NumOfDecimals)
                    .HasColumnName("NUM_OF_DECIMALS")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldContractDistribute).HasColumnName("OLD_CONTRACT_DISTRIBUTE");

                entity.Property(e => e.ProcentOfCost1)
                    .HasColumnName("PROCENT_OF_COST_1")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProcentOfCost2)
                    .HasColumnName("PROCENT_OF_COST_2")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProcentOfCost3)
                    .HasColumnName("PROCENT_OF_COST_3")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProcentOfCost4)
                    .HasColumnName("PROCENT_OF_COST_4")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProcentOfCost5)
                    .HasColumnName("PROCENT_OF_COST_5")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProvisionPercent)
                    .HasColumnName("PROVISION_PERCENT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.SalesPrice1)
                    .HasColumnName("SALES_PRICE_1")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesPrice2)
                    .HasColumnName("SALES_PRICE_2")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesPrice3)
                    .HasColumnName("SALES_PRICE_3")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesPrice4)
                    .HasColumnName("SALES_PRICE_4")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesPrice5)
                    .HasColumnName("SALES_PRICE_5")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SerialNo).HasColumnName("SERIAL_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.StockAdminStopOrder)
                    .HasColumnName("STOCK_ADMIN_STOP_ORDER")
                    .HasMaxLength(1);

                entity.Property(e => e.StockAdminStopOrderDate)
                    .HasColumnName("STOCK_ADMIN_STOP_ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockTracking)
                    .HasColumnName("STOCK_TRACKING")
                    .HasMaxLength(1);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.TargetPriceCode)
                    .HasColumnName("TARGET_PRICE_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.UnitAmount).HasColumnName("UNIT_AMOUNT");

                entity.Property(e => e.UnitPurchase)
                    .HasColumnName("UNIT_PURCHASE")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPurchaseAmount).HasColumnName("UNIT_PURCHASE_AMOUNT");

                entity.Property(e => e.UseCalcSchema).HasColumnName("USE_CALC_SCHEMA");

                entity.Property(e => e.UseInMobile)
                    .HasColumnName("USE_IN_MOBILE")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.WarrantyLength)
                    .HasColumnName("WARRANTY_LENGTH")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("WEIGHT_UNIT")
                    .HasMaxLength(10);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ARTICLE_COMPANY_FK");

                entity.HasOne(d => d.SupplierObjNoNavigation)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.SupplierObjNo)
                    .HasConstraintName("ARTICLE_SUPPLIER_FK");
            });

            modelBuilder.Entity<ArticleAggregated>(entity =>
            {
                entity.HasKey(e => new { e.OwnerObjNo, e.ArticleObjNo });

                entity.ToTable("ARTICLE_AGGREGATED");

                entity.Property(e => e.OwnerObjNo).HasColumnName("OWNER_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.DefaultStockObjNo).HasColumnName("DEFAULT_STOCK_OBJ_NO");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<ArticleCalcSchema>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.SchemaNo, e.PriceFrom });

                entity.ToTable("ARTICLE_CALC_SCHEMA");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaNo).HasColumnName("SCHEMA_NO");

                entity.Property(e => e.PriceFrom)
                    .HasColumnName("PRICE_FROM")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Price3)
                    .HasColumnName("PRICE_3")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Price4)
                    .HasColumnName("PRICE_4")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Price5)
                    .HasColumnName("PRICE_5")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.PriceTo)
                    .HasColumnName("PRICE_TO")
                    .HasColumnType("decimal(25, 10)");
            });

            modelBuilder.Entity<ArticleDiscount>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("ARTICLE_DISCOUNT");

                entity.HasIndex(e => new { e.CustomerObjNo, e.ArticleObjNo, e.ArticleSortgroup, e.Dept, e.ArticleSortgroupNo })
                    .HasName("IDX_ARTICLE_DISC");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ArticleSortgroup)
                    .HasColumnName("ARTICLE_SORTGROUP")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleSortgroupNo)
                    .HasColumnName("ARTICLE_SORTGROUP_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.CostPriceFixed)
                    .HasColumnName("COST_PRICE_FIXED")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FixedAmount)
                    .HasColumnName("FIXED_AMOUNT")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.MinQty)
                    .HasColumnName("MIN_QTY")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesPriceFixed)
                    .HasColumnName("SALES_PRICE_FIXED")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.ArticleDiscount)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .HasConstraintName("ARTICLE_DISCOUNT_ARTICLE_FK");

                entity.HasOne(d => d.ContractObjNoNavigation)
                    .WithMany(p => p.ArticleDiscount)
                    .HasForeignKey(d => d.ContractObjNo)
                    .HasConstraintName("ARTICLE_DISCOUNT_CONTRACT_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ArticleDiscount)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("ARTICLE_DISCOUNT_CUSTOMER_FK");
            });

            modelBuilder.Entity<ArticleFeeLevel>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code });

                entity.ToTable("ARTICLE_FEE_LEVEL");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.FeeLevel)
                    .HasColumnName("FEE_LEVEL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("SHORT_DESCRIPTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArticleGenerations>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.ArticleNo });

                entity.ToTable("ARTICLE_GENERATIONS");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.RegDate)
                    .HasColumnName("REG_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SourceObjNoNavigation)
                    .WithMany(p => p.ArticleGenerations)
                    .HasForeignKey(d => d.SourceObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ARTICLE_ARTICLE_GEN_FK");
            });

            modelBuilder.Entity<ArticleIntegration>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleNo });

                entity.ToTable("ARTICLE_INTEGRATION");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.ArticleDescription)
                    .HasColumnName("ARTICLE_DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SerialNoRequired).HasColumnName("SERIAL_NO_REQUIRED");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup1Desc)
                    .HasColumnName("SORTGROUP_1_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup2Desc)
                    .HasColumnName("SORTGROUP_2_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup3Desc)
                    .HasColumnName("SORTGROUP_3_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup4Desc)
                    .HasColumnName("SORTGROUP_4_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup5Desc)
                    .HasColumnName("SORTGROUP_5_DESC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ArticleIntegrationStage>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleNo });

                entity.ToTable("ARTICLE_INTEGRATION_STAGE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.ArticleDescription)
                    .HasColumnName("ARTICLE_DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SerialNoRequired).HasColumnName("SERIAL_NO_REQUIRED");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup1Desc)
                    .HasColumnName("SORTGROUP_1_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup2Desc)
                    .HasColumnName("SORTGROUP_2_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup3Desc)
                    .HasColumnName("SORTGROUP_3_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup4Desc)
                    .HasColumnName("SORTGROUP_4_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortgroup5Desc)
                    .HasColumnName("SORTGROUP_5_DESC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ArticleIntegrationSupplier>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleNo, e.SupplierNo });

                entity.ToTable("ARTICLE_INTEGRATION_SUPPLIER");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.SupplierNo)
                    .HasColumnName("SUPPLIER_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.ArticleNoSupplier)
                    .HasColumnName("ARTICLE_NO_SUPPLIER")
                    .HasMaxLength(100);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("numeric(25, 10)");
            });

            modelBuilder.Entity<ArticleIntegrationSupplierStage>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleNo, e.SupplierNo });

                entity.ToTable("ARTICLE_INTEGRATION_SUPPLIER_STAGE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.SupplierNo)
                    .HasColumnName("SUPPLIER_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.ArticleNoSupplier)
                    .HasColumnName("ARTICLE_NO_SUPPLIER")
                    .HasMaxLength(100);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("numeric(25, 10)");
            });

            modelBuilder.Entity<ArticleModelLocation>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("ARTICLE_MODEL_LOCATION");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(250);

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.ArticleModelLocation)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ARTICLE_MODEL_LOCATION_ARTICLE_FK");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.ArticleModelLocation)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ARTICLE_MODEL_LOCATION_MODEL_FK");
            });

            modelBuilder.Entity<ArticleReplacementArticle>(entity =>
            {
                entity.HasKey(e => new { e.ArticleObjNo1, e.ArticleObjNo2 });

                entity.ToTable("ARTICLE_REPLACEMENT_ARTICLE");

                entity.Property(e => e.ArticleObjNo1).HasColumnName("ARTICLE_OBJ_NO_1");

                entity.Property(e => e.ArticleObjNo2).HasColumnName("ARTICLE_OBJ_NO_2");
            });

            modelBuilder.Entity<ArticleSortGroupDefaultValues>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("ARTICLE_SORT_GROUP_DEFAULT_VALUES");

                entity.HasIndex(e => new { e.Company, e.Sg1Code, e.Sg2Code, e.Sg3Code, e.Sg4Code, e.Sg5Code })
                    .HasName("IDX_ARTICLE_SG_DEFAULT_VALUES_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.AccountNoPurchase)
                    .HasColumnName("ACCOUNT_NO_PURCHASE")
                    .HasMaxLength(10);

                entity.Property(e => e.CalcSchemaNo).HasColumnName("CALC_SCHEMA_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Costgroup)
                    .HasColumnName("COSTGROUP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.IsModel).HasColumnName("IS_MODEL");

                entity.Property(e => e.Sg1Code)
                    .HasColumnName("SG1_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sg2Code)
                    .HasColumnName("SG2_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sg3Code)
                    .HasColumnName("SG3_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sg4Code)
                    .HasColumnName("SG4_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sg5Code)
                    .HasColumnName("SG5_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.StockTracking)
                    .HasColumnName("STOCK_TRACKING")
                    .HasMaxLength(1);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.UnitPurchase)
                    .HasColumnName("UNIT_PURCHASE")
                    .HasMaxLength(10);

                entity.Property(e => e.UseSerialNo).HasColumnName("USE_SERIAL_NO");

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.WarrantyLength)
                    .HasColumnName("WARRANTY_LENGTH")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<ArticleSupplier>(entity =>
            {
                entity.HasKey(e => new { e.ArticleObjNo, e.SupplierObjNo });

                entity.ToTable("ARTICLE_SUPPLIER");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.CostListPrice)
                    .HasColumnName("COST_LIST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ExternalAvailability)
                    .HasColumnName("EXTERNAL_AVAILABILITY")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierArticleNo)
                    .HasColumnName("SUPPLIER_ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.UnitPurchase)
                    .HasColumnName("UNIT_PURCHASE")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BusinessHours>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.Day });

                entity.ToTable("BUSINESS_HOURS");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Hours)
                    .HasColumnName("HOURS")
                    .HasMaxLength(11);

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.Lunch)
                    .HasColumnName("LUNCH")
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<CalendarInformation>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CALENDAR_INFORMATION");

                entity.HasIndex(e => new { e.UserLinkObjNo, e.DateFrom })
                    .HasName("IDX_CI_USER_DATE_ONLY_FROM");

                entity.HasIndex(e => new { e.UserLinkObjNo, e.DateFrom, e.DateTo })
                    .HasName("IDX_CI_USER_DATE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalendarText)
                    .HasColumnName("CALENDAR_TEXT")
                    .HasMaxLength(2000);

                entity.Property(e => e.CalendarType)
                    .IsRequired()
                    .HasColumnName("CALENDAR_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.UserLinkObjNo).HasColumnName("USER_LINK_OBJ_NO");
            });

            modelBuilder.Entity<ChangedWorkHours>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CHANGED_WORK_HOURS");

                entity.HasIndex(e => new { e.Company, e.DateToChange })
                    .HasName("IDX_CHANGED_WORK_HOURS");

                entity.HasIndex(e => new { e.SourceObjNo, e.DateToChange })
                    .HasName("IDX_CHANGED_WORK_HOURS_SOURCE");

                entity.HasIndex(e => new { e.Company, e.Dept, e.DateToChange })
                    .HasName("IDX_CHANGED_WORK_HOURS_DEPT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateToChange)
                    .HasColumnName("DATE_TO_CHANGE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasColumnName("HOURS")
                    .HasMaxLength(11);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");
            });

            modelBuilder.Entity<CheckList>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code });

                entity.ToTable("CHECK_LIST");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckListVersion)
                    .HasColumnName("CHECK_LIST_VERSION")
                    .HasMaxLength(30);

                entity.Property(e => e.DefaultPrint)
                    .HasColumnName("DEFAULT_PRINT")
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.DocGenerateName)
                    .HasColumnName("DOC_GENERATE_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.DocImage)
                    .HasColumnName("DOC_IMAGE")
                    .HasColumnType("image");

                entity.Property(e => e.DocName)
                    .HasColumnName("DOC_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.DocType)
                    .HasColumnName("DOC_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.SendWithServiceReport)
                    .HasColumnName("SEND_WITH_SERVICE_REPORT")
                    .HasMaxLength(1);

                entity.Property(e => e.Sql).HasColumnName("SQL");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.CheckList)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CHECK_LIST_NAME_FK");
            });

            modelBuilder.Entity<CheckListModelDependencies>(entity =>
            {
                entity.HasKey(e => new { e.CheckListCode, e.ModelObjNo });

                entity.ToTable("CHECK_LIST_MODEL_DEPENDENCIES");

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");
            });

            modelBuilder.Entity<CheckListSymptomDependencies>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.CheckListCode, e.SymptomCode1, e.SymptomCode2, e.SymptomCode3 });

                entity.ToTable("CHECK_LIST_SYMPTOM_DEPENDENCIES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.AutoAdd)
                    .HasColumnName("AUTO_ADD")
                    .HasMaxLength(1);

                entity.Property(e => e.Mandatory)
                    .HasColumnName("MANDATORY")
                    .HasMaxLength(1);

                entity.Property(e => e.SymptomCode)
                    .HasColumnName("SYMPTOM_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCodeNo)
                    .HasColumnName("SYMPTOM_CODE_NO")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CheckListTree>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.CheckListCode, e.NodeKey });

                entity.ToTable("CHECK_LIST_TREE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.NodeKey)
                    .HasColumnName("NODE_KEY")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.Property(e => e.DataType).HasColumnName("DATA_TYPE");

                entity.Property(e => e.ExpandDefValue)
                    .HasColumnName("EXPAND_DEF_VALUE")
                    .HasMaxLength(1);

                entity.Property(e => e.ExpandValue)
                    .HasColumnName("EXPAND_VALUE")
                    .HasMaxLength(1);

                entity.Property(e => e.GroupType).HasColumnName("GROUP_TYPE");

                entity.Property(e => e.History)
                    .HasColumnName("HISTORY")
                    .HasMaxLength(1);

                entity.Property(e => e.Mandatory)
                    .HasColumnName("MANDATORY")
                    .HasMaxLength(1);

                entity.Property(e => e.MandatoryBeforeStart)
                    .HasColumnName("MANDATORY_BEFORE_START")
                    .HasMaxLength(1);

                entity.Property(e => e.NodeLevel)
                    .HasColumnName("NODE_LEVEL")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NodeText)
                    .IsRequired()
                    .HasColumnName("NODE_TEXT")
                    .HasMaxLength(250);

                entity.Property(e => e.ParentKey)
                    .IsRequired()
                    .HasColumnName("PARENT_KEY")
                    .HasMaxLength(890);

                entity.Property(e => e.PreValues).HasColumnName("PRE_VALUES");

                entity.Property(e => e.PrintOrder)
                    .HasColumnName("PRINT_ORDER")
                    .HasMaxLength(50);

                entity.Property(e => e.ShowComment)
                    .HasColumnName("SHOW_COMMENT")
                    .HasMaxLength(1);

                entity.Property(e => e.ShowStatGroup)
                    .HasColumnName("SHOW_STAT_GROUP")
                    .HasMaxLength(1);

                entity.Property(e => e.StdValue)
                    .HasColumnName("STD_VALUE")
                    .HasMaxLength(100);

                entity.Property(e => e.StdValueFromHistory)
                    .HasColumnName("STD_VALUE_FROM_HISTORY")
                    .HasMaxLength(1);

                entity.Property(e => e.TreeLevel)
                    .HasColumnName("TREE_LEVEL")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Company1);

                entity.ToTable("COMPANY");

                entity.Property(e => e.Company1)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("BANK_ACCOUNT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("COMPANY_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostAccountNo)
                    .HasColumnName("POST_ACCOUNT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<CompetenceGroup>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("COMPETENCE_GROUP");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.CompetenceGroup)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMPETENCE_GROUP_COMPANY_FK");
            });

            modelBuilder.Entity<CompetenceGroupDetails>(entity =>
            {
                entity.HasKey(e => new { e.CompetenceGroupObjNo, e.ModelObjNo })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("COMPETENCE_GROUP_DETAILS");

                entity.Property(e => e.CompetenceGroupObjNo).HasColumnName("COMPETENCE_GROUP_OBJ_NO");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.HasOne(d => d.CompetenceGroupObjNoNavigation)
                    .WithMany(p => p.CompetenceGroupDetails)
                    .HasForeignKey(d => d.CompetenceGroupObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CGD_GROUP_FK");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.CompetenceGroupDetails)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CGD_MODEL_FK");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.ContactNo })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CONTACT");

                entity.HasIndex(e => e.ContactNo)
                    .HasName("IDX_CONTACT_CONTACT_NO");

                entity.HasIndex(e => new { e.ObjNo, e.ContactName, e.PhoneNo })
                    .HasName("IDX_CONTACT_NAME_PHONE");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Birthday)
                    .HasColumnName("BIRTHDAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactCode)
                    .IsRequired()
                    .HasColumnName("CONTACT_CODE")
                    .HasMaxLength(1);

                entity.Property(e => e.ContactId)
                    .HasColumnName("CONTACT_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.ContactInfo)
                    .HasColumnName("CONTACT_INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactNotes).HasColumnName("CONTACT_NOTES");

                entity.Property(e => e.ContactStatus)
                    .HasColumnName("CONTACT_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.EMail1)
                    .HasColumnName("E_MAIL_1")
                    .HasMaxLength(70);

                entity.Property(e => e.EMail2)
                    .HasColumnName("E_MAIL_2")
                    .HasMaxLength(70);

                entity.Property(e => e.ExternalSystemKey)
                    .HasColumnName("EXTERNAL_SYSTEM_KEY")
                    .HasMaxLength(40);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.LetterTitle)
                    .HasColumnName("LETTER_TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.MainContact)
                    .HasColumnName("MAIN_CONTACT")
                    .HasMaxLength(2);

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SirTitle)
                    .HasColumnName("SIR_TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(20);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.WebAccess).HasColumnName("WEB_ACCESS");

                entity.Property(e => e.WebAccessContact).HasColumnName("WEB_ACCESS_CONTACT");

                entity.Property(e => e.WebAccessMachine).HasColumnName("WEB_ACCESS_MACHINE");

                entity.Property(e => e.WebAccessMeterReporting).HasColumnName("WEB_ACCESS_METER_REPORTING");

                entity.Property(e => e.WebAccessOnlyOwn).HasColumnName("WEB_ACCESS_ONLY_OWN");

                entity.Property(e => e.WebAccessOrder).HasColumnName("WEB_ACCESS_ORDER");

                entity.Property(e => e.WebAccessOrderLog).HasColumnName("WEB_ACCESS_ORDER_LOG");

                entity.Property(e => e.WebAccessProject).HasColumnName("WEB_ACCESS_PROJECT");

                entity.Property(e => e.WebAccessProjectLog).HasColumnName("WEB_ACCESS_PROJECT_LOG");

                entity.Property(e => e.WebAccessSupport).HasColumnName("WEB_ACCESS_SUPPORT");

                entity.Property(e => e.WebAccessSupportLog).HasColumnName("WEB_ACCESS_SUPPORT_LOG");

                entity.Property(e => e.WebPassword)
                    .HasColumnName("WEB_PASSWORD")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ContactEmail>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.ContactNo });

                entity.ToTable("CONTACT_EMAIL");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasColumnName("CONTACT_COMPANY")
                    .HasMaxLength(30);

                entity.Property(e => e.ContactName)
                    .HasColumnName("CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.EMailGroup)
                    .HasColumnName("E_MAIL_GROUP")
                    .HasMaxLength(10);

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ContactReference>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.ContactNo });

                entity.ToTable("CONTACT_REFERENCE");

                entity.HasIndex(e => new { e.ContactCode, e.ContactObjNo })
                    .HasName("IDX_CONTACT_REFERENCE_CONTACT_CODE_CONTACT_OBJ_NO");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContactCode)
                    .HasColumnName("CONTACT_CODE")
                    .HasMaxLength(1);

                entity.Property(e => e.ContactObjNo).HasColumnName("CONTACT_OBJ_NO");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactReference)
                    .HasForeignKey(d => new { d.ContactObjNo, d.ContactNo })
                    .HasConstraintName("CR_CONTACT_FK");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CONTRACT");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_CONTRACT_CUSTOMER");

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_CONTRACT_STATUS");

                entity.HasIndex(e => new { e.Company, e.ContractNo })
                    .HasName("IDX_CONTRACT_CONTRACT_NO");

                entity.HasIndex(e => new { e.Company, e.Dept })
                    .HasName("idx_CONTRACT_COMPANY_DEPT");

                entity.HasIndex(e => new { e.Status, e.ObjNo })
                    .HasName("IDX_CONTRACT_STATUS_OBJ");

                entity.HasIndex(e => new { e.Company, e.Dept, e.ContractNo })
                    .HasName("UQK_CONTRACT_COMPANY_DEPT_CONTRACT_NO")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerObjNo, e.Status, e.ObjNo, e.ContractNo })
                    .HasName("IDX_CONTRACT_CUSTOMER_STATUS_OBJ_NO_CONTRACT_NO");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleObjNoOneRow).HasColumnName("ARTICLE_OBJ_NO_ONE_ROW");

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.BicMr)
                    .HasColumnName("BIC_MR")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculateAllRowsAsTotalVolume)
                    .HasColumnName("CALCULATE_ALL_ROWS_AS_TOTAL_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumableOrderMinimumLevel)
                    .HasColumnName("CONSUMABLE_ORDER_MINIMUM_LEVEL")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ConsumableOrderRemainingDays)
                    .HasColumnName("CONSUMABLE_ORDER_REMAINING_DAYS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ConsumableOrderSoonDays)
                    .HasColumnName("CONSUMABLE_ORDER_SOON_DAYS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContractInfo)
                    .HasColumnName("CONTRACT_INFO")
                    .HasMaxLength(899);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(15);

                entity.Property(e => e.CreditCustomerObjNo).HasColumnName("CREDIT_CUSTOMER_OBJ_NO");

                entity.Property(e => e.CreditEnabled)
                    .HasColumnName("CREDIT_ENABLED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEndDate)
                    .HasColumnName("CREDIT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditEstimated)
                    .HasColumnName("CREDIT_ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditFixed)
                    .HasColumnName("CREDIT_FIXED")
                    .HasColumnType("money");

                entity.Property(e => e.CreditOnlyOnce)
                    .HasColumnName("CREDIT_ONLY_ONCE")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditPercentage)
                    .HasColumnName("CREDIT_PERCENTAGE")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CreditTermMr).HasColumnName("CREDIT_TERM_MR");

                entity.Property(e => e.CreditVirtual)
                    .HasColumnName("CREDIT_VIRTUAL")
                    .HasMaxLength(1);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(200);

                entity.Property(e => e.DeliveryAddressRowNo)
                    .HasColumnName("DELIVERY_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.DeliveryCustomerObjNo).HasColumnName("DELIVERY_CUSTOMER_OBJ_NO");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.IbanMr)
                    .HasColumnName("IBAN_MR")
                    .HasMaxLength(50);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceFee)
                    .HasColumnName("INVOICE_FEE")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceInfo)
                    .HasColumnName("INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.InvoiceWithMeterReading)
                    .HasColumnName("INVOICE_WITH_METER_READING")
                    .HasMaxLength(1);

                entity.Property(e => e.MakeXmlFileOfInvoice)
                    .HasColumnName("MAKE_XML_FILE_OF_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.MandateRefNoMr)
                    .HasColumnName("MANDATE_REF_NO_MR")
                    .HasMaxLength(35);

                entity.Property(e => e.MeterReadingLetterOneLetter)
                    .HasColumnName("METER_READING_LETTER_ONE_LETTER")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OnHold)
                    .HasColumnName("ON_HOLD")
                    .HasMaxLength(1);

                entity.Property(e => e.OnHoldDate)
                    .HasColumnName("ON_HOLD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnHoldInfo)
                    .HasColumnName("ON_HOLD_INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderTypeMr)
                    .HasColumnName("ORDER_TYPE_MR")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTypeMr)
                    .HasColumnName("PAYMENT_TYPE_MR")
                    .HasMaxLength(10);

                entity.Property(e => e.PrintInvoiceAsOneLine)
                    .HasColumnName("PRINT_INVOICE_AS_ONE_LINE")
                    .HasMaxLength(1);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.UseInvoicedToVolume)
                    .HasColumnName("USE_INVOICED_TO_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_COMPANY_FK");

                entity.HasOne(d => d.CreditCustomerObjNoNavigation)
                    .WithMany(p => p.ContractCreditCustomerObjNoNavigation)
                    .HasForeignKey(d => d.CreditCustomerObjNo)
                    .HasConstraintName("CONTRACT_CREDIT_CUSTOMER_FK");

                entity.HasOne(d => d.CreditTermNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.CreditTerm)
                    .HasConstraintName("CONTRACT_CREDIT_TERM_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ContractCustomerObjNoNavigation)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_CUSTOMER_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_DEPT_FK");
            });

            modelBuilder.Entity<ContractCreditArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleObjNoInvoice);

                entity.ToTable("CONTRACT_CREDIT_ARTICLE");

                entity.Property(e => e.ArticleObjNoInvoice)
                    .HasColumnName("ARTICLE_OBJ_NO_INVOICE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNoCredit).HasColumnName("ARTICLE_OBJ_NO_CREDIT");

                entity.HasOne(d => d.ArticleObjNoInvoiceNavigation)
                    .WithOne(p => p.ContractCreditArticle)
                    .HasForeignKey<ContractCreditArticle>(d => d.ArticleObjNoInvoice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_CREDIT_ARTICLE_FK");
            });

            modelBuilder.Entity<ContractCreditCustomer>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.CustomerObjNo });

                entity.ToTable("CONTRACT_CREDIT_CUSTOMER");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CreditEnabled)
                    .HasColumnName("CREDIT_ENABLED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEndDate)
                    .HasColumnName("CREDIT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditFixed)
                    .HasColumnName("CREDIT_FIXED")
                    .HasColumnType("money");

                entity.Property(e => e.CreditFixedMr)
                    .HasColumnName("CREDIT_FIXED_MR")
                    .HasColumnType("money");

                entity.Property(e => e.CreditOnlyOnce)
                    .HasColumnName("CREDIT_ONLY_ONCE")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditPercentage)
                    .HasColumnName("CREDIT_PERCENTAGE")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CreditPercentageMr)
                    .HasColumnName("CREDIT_PERCENTAGE_MR")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CreditVirtual)
                    .HasColumnName("CREDIT_VIRTUAL")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.UnitPriceCredit)
                    .HasColumnName("UNIT_PRICE_CREDIT")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ContractCreditCustomer)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_CREDIT_CUSTOMER_CUSTOMER_FK");
            });

            modelBuilder.Entity<ContractFixedPrice>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo });

                entity.ToTable("CONTRACT_FIXED_PRICE");

                entity.HasIndex(e => e.ContractActiveFrom)
                    .HasName("IDX_FP_ACTIVE_FROM");

                entity.HasIndex(e => e.ContractActiveUntil)
                    .HasName("IDX_FP_ACTIVE_UNTIL");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_FP_MACHINE_OBJ_NO");

                entity.HasIndex(e => new { e.Status, e.ContractObjNo })
                    .HasName("IDX_CONTRACT_FIXED_PRICE_CONTRACT_OBJ_NO_AND_STATUS");

                entity.HasIndex(e => new { e.MachineObjNo, e.Status, e.ContractActiveUntil, e.ContractActiveFrom, e.ContractObjNo, e.ContractTypeObjNo })
                    .HasName("IDX_CONTRACT_FIXED_PRICE_MACHINE_STATUS_ACTIVE_FROM_ACTIVE_TO_CONTRACT_CONTRACT_TYPE");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AllowCredit)
                    .IsRequired()
                    .HasColumnName("ALLOW_CREDIT")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractActiveFrom)
                    .HasColumnName("CONTRACT_ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractActiveUntil)
                    .HasColumnName("CONTRACT_ACTIVE_UNTIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractEndDate)
                    .HasColumnName("CONTRACT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CostPriceOnlyFirst)
                    .HasColumnName("COST_PRICE_ONLY_FIRST")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEnabled)
                    .HasColumnName("CREDIT_ENABLED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEndDate)
                    .HasColumnName("CREDIT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditFixed)
                    .HasColumnName("CREDIT_FIXED")
                    .HasColumnType("money");

                entity.Property(e => e.CreditOnlyOnce)
                    .HasColumnName("CREDIT_ONLY_ONCE")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditPercentage)
                    .HasColumnName("CREDIT_PERCENTAGE")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerWarrantyDateFrom)
                    .HasColumnName("CUSTOMER_WARRANTY_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerWarrantyDateTo)
                    .HasColumnName("CUSTOMER_WARRANTY_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerWarrantyMonths)
                    .HasColumnName("CUSTOMER_WARRANTY_MONTHS")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ExtensionPeriod)
                    .HasColumnName("EXTENSION_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceFrequency)
                    .HasColumnName("INVOICE_FREQUENCY")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.InvoiceInfo)
                    .HasColumnName("INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.InvoiceLayoutObjNo).HasColumnName("INVOICE_LAYOUT_OBJ_NO");

                entity.Property(e => e.InvoiceStartDate)
                    .HasColumnName("INVOICE_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceTime)
                    .IsRequired()
                    .HasColumnName("INVOICE_TIME")
                    .HasMaxLength(1);

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.Invoiced)
                    .HasColumnName("INVOICED")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoicedToDate)
                    .HasColumnName("INVOICED_TO_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemsOnRow)
                    .HasColumnName("ITEMS_ON_ROW")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Leasing)
                    .HasColumnName("LEASING")
                    .HasMaxLength(1);

                entity.Property(e => e.LeasingDept)
                    .HasColumnName("LEASING_DEPT")
                    .HasMaxLength(3);

                entity.Property(e => e.LeasingFactor)
                    .HasColumnName("LEASING_FACTOR")
                    .HasColumnType("decimal(11, 6)");

                entity.Property(e => e.LeasingInvestedAmount)
                    .HasColumnName("LEASING_INVESTED_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingInvestedCostAccessories)
                    .HasColumnName("LEASING_INVESTED_COST_ACCESSORIES")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingInvestedCostMachine)
                    .HasColumnName("LEASING_INVESTED_COST_MACHINE")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingOwner).HasColumnName("LEASING_OWNER");

                entity.Property(e => e.LeasingOwnerContractNo)
                    .HasColumnName("LEASING_OWNER_CONTRACT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.LeasingRefiContractPeriod)
                    .HasColumnName("LEASING_REFI_CONTRACT_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.LeasingRefiFactor)
                    .HasColumnName("LEASING_REFI_FACTOR")
                    .HasColumnType("decimal(11, 6)");

                entity.Property(e => e.LeasingRefiInvestedAmount)
                    .HasColumnName("LEASING_REFI_INVESTED_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.MachineIncome)
                    .HasColumnName("MACHINE_INCOME")
                    .HasMaxLength(1);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.NextInvoiceInfo)
                    .HasColumnName("NEXT_INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OnHold)
                    .HasColumnName("ON_HOLD")
                    .HasMaxLength(1);

                entity.Property(e => e.OnHoldDate)
                    .HasColumnName("ON_HOLD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnHoldInfo)
                    .HasColumnName("ON_HOLD_INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.OneTimeInvoice)
                    .HasColumnName("ONE_TIME_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.PreTerminationLimit)
                    .HasColumnName("PRE_TERMINATION_LIMIT")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PriceIncreaseAfter)
                    .HasColumnName("PRICE_INCREASE_AFTER")
                    .HasColumnType("datetime");

                entity.Property(e => e.PricePrMonth)
                    .HasColumnName("PRICE_PR_MONTH")
                    .HasColumnType("money");

                entity.Property(e => e.RowInfo)
                    .HasColumnName("ROW_INFO")
                    .HasMaxLength(899);

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.ShowOnNext)
                    .HasColumnName("SHOW_ON_NEXT")
                    .HasMaxLength(1);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SortingNo)
                    .HasColumnName("SORTING_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.TerminatedDate)
                    .HasColumnName("TERMINATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsePriceFromArticle).HasColumnName("USE_PRICE_FROM_ARTICLE");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.ContractFixedPrice)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CFP_ARTICLE_FK");

                entity.HasOne(d => d.ContractObjNoNavigation)
                    .WithMany(p => p.ContractFixedPrice)
                    .HasForeignKey(d => d.ContractObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_FP_CONTRACT_FK");

                entity.HasOne(d => d.ContractTypeObjNoNavigation)
                    .WithMany(p => p.ContractFixedPrice)
                    .HasForeignKey(d => d.ContractTypeObjNo)
                    .HasConstraintName("CONTRACT_FP_CONTRTYPE_FK");

                entity.HasOne(d => d.InvoiceLayoutObjNoNavigation)
                    .WithMany(p => p.ContractFixedPrice)
                    .HasForeignKey(d => d.InvoiceLayoutObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FP_INVOICE_LAYOUT_FK");

                entity.HasOne(d => d.SalesmanObjNoNavigation)
                    .WithMany(p => p.ContractFixedPrice)
                    .HasForeignKey(d => d.SalesmanObjNo)
                    .HasConstraintName("CONTRACT_FP_SALESMAN_FK");
            });

            modelBuilder.Entity<ContractFixedPriceAutoTasks>(entity =>
            {
                entity.HasKey(e => new { e.ContractFixedPriceObjNo, e.ProjectTaskAutoObjNo });

                entity.ToTable("CONTRACT_FIXED_PRICE_AUTO_TASKS");

                entity.Property(e => e.ContractFixedPriceObjNo).HasColumnName("CONTRACT_FIXED_PRICE_OBJ_NO");

                entity.Property(e => e.ProjectTaskAutoObjNo).HasColumnName("PROJECT_TASK_AUTO_OBJ_NO");
            });

            modelBuilder.Entity<ContractIncludedArticles>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.ContractRowNo, e.ContractType, e.ArticleObjNo });

                entity.ToTable("CONTRACT_INCLUDED_ARTICLES");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ContractType)
                    .HasColumnName("CONTRACT_TYPE")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('FP')");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.AmountNotUsed)
                    .HasColumnName("AMOUNT_NOT_USED")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.Frequence)
                    .HasColumnName("FREQUENCE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SaveNotUsed)
                    .HasColumnName("SAVE_NOT_USED")
                    .HasMaxLength(1);

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("VALID_FROM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractIncludedArticlesUsed>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.ContractRowNo, e.ContractType, e.ArticleObjNo, e.UsedFrom });

                entity.ToTable("CONTRACT_INCLUDED_ARTICLES_USED");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ContractType)
                    .HasColumnName("CONTRACT_TYPE")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('FP')");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.UsedFrom)
                    .HasColumnName("USED_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.AmountNotUsedMoved)
                    .HasColumnName("AMOUNT_NOT_USED_MOVED")
                    .HasMaxLength(1);

                entity.Property(e => e.UsedTo)
                    .HasColumnName("USED_TO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractInvoiceFee>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.FeeRowNo });

                entity.ToTable("CONTRACT_INVOICE_FEE");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.FeeRowNo)
                    .HasColumnName("FEE_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Leasing)
                    .HasColumnName("LEASING")
                    .HasMaxLength(1);

                entity.Property(e => e.OnlyNextInvoice)
                    .HasColumnName("ONLY_NEXT_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.HasOne(d => d.ContractObjNoNavigation)
                    .WithMany(p => p.ContractInvoiceFee)
                    .HasForeignKey(d => d.ContractObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_INVOICE_FEE_CONTRACT_FK");
            });

            modelBuilder.Entity<ContractInvoiceHeadingTemp>(entity =>
            {
                entity.HasKey(e => new { e.Owner, e.PreviewType, e.Company, e.SourceObjNo, e.InvoiceCustomerObjNo, e.InvoiceAddressRowNo, e.SubContractNo });

                entity.ToTable("CONTRACT_INVOICE_HEADING_TEMP");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PreviewType)
                    .HasColumnName("PREVIEW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculateVat)
                    .HasColumnName("CALCULATE_VAT")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditTermObjNo).HasColumnName("CREDIT_TERM_OBJ_NO");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.DelAddressRowNo)
                    .HasColumnName("DEL_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.DelCustomerObjNo).HasColumnName("DEL_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DeliveryTerm)
                    .HasColumnName("DELIVERY_TERM")
                    .HasMaxLength(10);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceInfo)
                    .HasColumnName("INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.OurReference)
                    .HasColumnName("OUR_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.RowNumbers).HasColumnName("ROW_NUMBERS");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ContractInvoiceLineTemp>(entity =>
            {
                entity.HasKey(e => new { e.Owner, e.PreviewType, e.Company, e.SourceObjNo, e.InvoiceCustomerObjNo, e.InvoiceAddressRowNo, e.InvoiceLineNo, e.SubContractNo });

                entity.ToTable("CONTRACT_INVOICE_LINE_TEMP");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PreviewType)
                    .HasColumnName("PREVIEW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InvoiceLineNo)
                    .HasColumnName("INVOICE_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.LineSum)
                    .HasColumnName("LINE_SUM")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.MeterReadingLetter)
                    .HasColumnName("METER_READING_LETTER")
                    .HasMaxLength(1);

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("numeric(11, 5)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("numeric(4, 2)");

                entity.HasOne(d => d.ContractInvoiceHeadingTemp)
                    .WithMany(p => p.ContractInvoiceLineTemp)
                    .HasForeignKey(d => new { d.Owner, d.PreviewType, d.Company, d.SourceObjNo, d.InvoiceCustomerObjNo, d.InvoiceAddressRowNo, d.SubContractNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_INVOICE_LINE_TEMP_HEADING_FK");
            });

            modelBuilder.Entity<ContractMeterArticleConsumable>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CONTRACT_METER_ARTICLE_CONSUMABLE");

                entity.HasIndex(e => new { e.ContractObjNo, e.SourceObjNo, e.MeterObjNo, e.ArticleObjNo })
                    .HasName("IDX_CONTRACT_METER_ARTICLE_CONSUMABLE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ConsumableName)
                    .HasColumnName("CONSUMABLE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.CoveredPercentage)
                    .HasColumnName("COVERED_PERCENTAGE")
                    .HasColumnType("numeric(6, 3)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.UnitsPerToner)
                    .HasColumnName("UNITS_PER_TONER")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<ContractMeterDetails>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo, e.MeterObjNo });

                entity.ToTable("CONTRACT_METER_DETAILS");

                entity.HasIndex(e => new { e.ContractObjNo, e.RowNo })
                    .HasName("IDX_CMD_CONTRACT_ROW");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.AdvancedLevelsDiscount)
                    .HasColumnName("ADVANCED_LEVELS_DISCOUNT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AllUnitsOnMaxLevel)
                    .HasColumnName("ALL_UNITS_ON_MAX_LEVEL")
                    .HasMaxLength(1);

                entity.Property(e => e.AutomaticAdjustVolume)
                    .HasColumnName("AUTOMATIC_ADJUST_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEnabled)
                    .HasColumnName("CREDIT_ENABLED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEndDate)
                    .HasColumnName("CREDIT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditFixed)
                    .HasColumnName("CREDIT_FIXED")
                    .HasColumnType("money");

                entity.Property(e => e.CreditFixedMr)
                    .HasColumnName("CREDIT_FIXED_MR")
                    .HasColumnType("money");

                entity.Property(e => e.CreditOnlyOnce)
                    .HasColumnName("CREDIT_ONLY_ONCE")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditPercentage)
                    .HasColumnName("CREDIT_PERCENTAGE")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.CreditPercentageMr)
                    .HasColumnName("CREDIT_PERCENTAGE_MR")
                    .HasColumnType("decimal(5, 3)");

                entity.Property(e => e.HiddenVolume)
                    .HasColumnName("HIDDEN_VOLUME")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.InvoiceCreditCopies)
                    .HasColumnName("INVOICE_CREDIT_COPIES")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceExcessCopies)
                    .HasColumnName("INVOICE_EXCESS_COPIES")
                    .HasMaxLength(1);

                entity.Property(e => e.Level1)
                    .HasColumnName("LEVEL1")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Level2)
                    .HasColumnName("LEVEL2")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Level3)
                    .HasColumnName("LEVEL3")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MaxcopiesToCredit)
                    .HasColumnName("MAXCOPIES_TO_CREDIT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MeterStart)
                    .HasColumnName("METER_START")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MrArticleObjNo).HasColumnName("MR_ARTICLE_OBJ_NO");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE1")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE2")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Price3)
                    .HasColumnName("PRICE3")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PriceNegativeCopies)
                    .HasColumnName("PRICE_NEGATIVE_COPIES")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PvArticleObjNo).HasColumnName("PV_ARTICLE_OBJ_NO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.UnitPriceCredit)
                    .HasColumnName("UNIT_PRICE_CREDIT")
                    .HasMaxLength(1);

                entity.Property(e => e.UseAdvancedLevels)
                    .HasColumnName("USE_ADVANCED_LEVELS")
                    .HasMaxLength(1);

                entity.Property(e => e.UseHiddenVolume)
                    .HasColumnName("USE_HIDDEN_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.UseHighestPrice)
                    .IsRequired()
                    .HasColumnName("USE_HIGHEST_PRICE")
                    .HasMaxLength(1);

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.VolumePerPeriod)
                    .HasColumnName("VOLUME_PER_PERIOD")
                    .HasMaxLength(1);

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.ContractMeterDetails)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("METER_DETAILS_METER_FK");

                entity.HasOne(d => d.MrArticleObjNoNavigation)
                    .WithMany(p => p.ContractMeterDetailsMrArticleObjNoNavigation)
                    .HasForeignKey(d => d.MrArticleObjNo)
                    .HasConstraintName("CPV_MR_ARTICLE_FK");

                entity.HasOne(d => d.PvArticleObjNoNavigation)
                    .WithMany(p => p.ContractMeterDetailsPvArticleObjNoNavigation)
                    .HasForeignKey(d => d.PvArticleObjNo)
                    .HasConstraintName("CPV_PV_ARTICLE_FK");

                entity.HasOne(d => d.ContractPeriodVolume)
                    .WithMany(p => p.ContractMeterDetails)
                    .HasForeignKey(d => new { d.ContractObjNo, d.RowNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CMD_PERIOD_VOLUME_FK");
            });

            modelBuilder.Entity<ContractPartCreditChanges>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CONTRACT_PART_CREDIT_CHANGES");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.CustomerInvoicingNo)
                    .HasColumnName("CUSTOMER_INVOICING_NO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.MeterVirtual)
                    .HasColumnName("METER_VIRTUAL")
                    .HasMaxLength(1);

                entity.Property(e => e.MeterVirtualDependency)
                    .HasColumnName("METER_VIRTUAL_DEPENDENCY")
                    .HasMaxLength(1);

                entity.Property(e => e.NewCounter)
                    .HasColumnName("NEW_COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.NewInvoiceDate)
                    .HasColumnName("NEW_INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewOrderNo)
                    .HasColumnName("NEW_ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.NewReadingDate)
                    .HasColumnName("NEW_READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldCounter)
                    .HasColumnName("OLD_COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.OldReadingDate)
                    .HasColumnName("OLD_READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PreviewType)
                    .IsRequired()
                    .HasColumnName("PREVIEW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasColumnName("ROW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusMessage)
                    .HasColumnName("STATUS_MESSAGE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Terminated)
                    .HasColumnName("TERMINATED")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ContractPeriodVolume>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo });

                entity.ToTable("CONTRACT_PERIOD_VOLUME");

                entity.HasIndex(e => e.CalculateMethod)
                    .HasName("IDX_PV_CALC_METHOD");

                entity.HasIndex(e => new { e.Status, e.ContractObjNo })
                    .HasName("IDX_CONTRACT_PERIOD_VOLUME_CONTRACT_OBJ_NO_AND_STATUS");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AllowCredit)
                    .IsRequired()
                    .HasColumnName("ALLOW_CREDIT")
                    .HasMaxLength(1);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.BicMr)
                    .HasColumnName("BIC_MR")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculateMethod)
                    .IsRequired()
                    .HasColumnName("CALCULATE_METHOD")
                    .HasMaxLength(3);

                entity.Property(e => e.ContractEndDate)
                    .HasColumnName("CONTRACT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CreditTermMr).HasColumnName("CREDIT_TERM_MR");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.ExtensionPeriod)
                    .HasColumnName("EXTENSION_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FirstInvoiceOnStartCounter)
                    .HasColumnName("FIRST_INVOICE_ON_START_COUNTER")
                    .HasMaxLength(1);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.IbanMr)
                    .HasColumnName("IBAN_MR")
                    .HasMaxLength(50);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceFrequency)
                    .HasColumnName("INVOICE_FREQUENCY")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.InvoiceInfo)
                    .HasColumnName("INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.InvoiceLayoutLetterObjNo).HasColumnName("INVOICE_LAYOUT_LETTER_OBJ_NO");

                entity.Property(e => e.InvoiceLayoutObjNo).HasColumnName("INVOICE_LAYOUT_OBJ_NO");

                entity.Property(e => e.InvoiceTime)
                    .IsRequired()
                    .HasColumnName("INVOICE_TIME")
                    .HasMaxLength(1);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.MandateRefNoMr)
                    .HasColumnName("MANDATE_REF_NO_MR")
                    .HasMaxLength(35);

                entity.Property(e => e.MeterAddressRowNo)
                    .HasColumnName("METER_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MeterCheckInvoice)
                    .HasColumnName("METER_CHECK_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.MeterContact)
                    .HasColumnName("METER_CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.MeterCustObjNo).HasColumnName("METER_CUST_OBJ_NO");

                entity.Property(e => e.MeterInvAddressRowNo)
                    .HasColumnName("METER_INV_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MeterInvCustObjNo).HasColumnName("METER_INV_CUST_OBJ_NO");

                entity.Property(e => e.MeterNextLetterDate)
                    .HasColumnName("METER_NEXT_LETTER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterSendLetterBy)
                    .HasColumnName("METER_SEND_LETTER_BY")
                    .HasMaxLength(1);

                entity.Property(e => e.MeterSendLetterByValue)
                    .HasColumnName("METER_SEND_LETTER_BY_VALUE")
                    .HasMaxLength(70);

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("MINIMUM_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.MrSubContractNo)
                    .HasColumnName("MR_SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.NextInvoiceFrom)
                    .HasColumnName("NEXT_INVOICE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.NextInvoiceInfo)
                    .HasColumnName("NEXT_INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.NextInvoiceTo)
                    .HasColumnName("NEXT_INVOICE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OnHold)
                    .HasColumnName("ON_HOLD")
                    .HasMaxLength(1);

                entity.Property(e => e.OnHoldDate)
                    .HasColumnName("ON_HOLD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnHoldInfo)
                    .HasColumnName("ON_HOLD_INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.PreTerminationLimit)
                    .HasColumnName("PRE_TERMINATION_LIMIT")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PriceIncreaseAfter)
                    .HasColumnName("PRICE_INCREASE_AFTER")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadingFrequence)
                    .HasColumnName("READING_FREQUENCE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingFrequenceOtherFirst)
                    .HasColumnName("READING_FREQUENCE_OTHER_FIRST")
                    .HasColumnType("numeric(15, 10)");

                entity.Property(e => e.ReadingRunningYear)
                    .HasColumnName("READING_RUNNING_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.RowInfo)
                    .HasColumnName("ROW_INFO")
                    .HasMaxLength(899);

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.ShowOnNextInvoice)
                    .HasColumnName("SHOW_ON_NEXT_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.TerminatedDate)
                    .HasColumnName("TERMINATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseLastCounter)
                    .HasColumnName("USE_LAST_COUNTER")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.ContractObjNoNavigation)
                    .WithMany(p => p.ContractPeriodVolume)
                    .HasForeignKey(d => d.ContractObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CPV_CONTRACT_FK");

                entity.HasOne(d => d.InvoiceLayoutLetterObjNoNavigation)
                    .WithMany(p => p.ContractPeriodVolumeInvoiceLayoutLetterObjNoNavigation)
                    .HasForeignKey(d => d.InvoiceLayoutLetterObjNo)
                    .HasConstraintName("PV_INVOICE_LAYOUT_LETTER_FK");

                entity.HasOne(d => d.InvoiceLayoutObjNoNavigation)
                    .WithMany(p => p.ContractPeriodVolumeInvoiceLayoutObjNoNavigation)
                    .HasForeignKey(d => d.InvoiceLayoutObjNo)
                    .HasConstraintName("PV_INVOICE_LAYOUT_FK");
            });

            modelBuilder.Entity<ContractPrepaidUnits>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo, e.PuName });

                entity.ToTable("CONTRACT_PREPAID_UNITS");

                entity.HasIndex(e => e.ContractObjNo)
                    .HasName("IDX_CPU_CONTRACT");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_CPU_OBJ_NO");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo).HasColumnName("ROW_NO");

                entity.Property(e => e.PuName)
                    .HasColumnName("PU_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.AutoInvoice).HasColumnName("AUTO_INVOICE");

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InvAddressRowNo).HasColumnName("INV_ADDRESS_ROW_NO");

                entity.Property(e => e.InvCustomerObjNo).HasColumnName("INV_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceInfo)
                    .HasColumnName("INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.NextInvoiceInfo)
                    .HasColumnName("NEXT_INVOICE_INFO")
                    .HasMaxLength(250);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PuDescription)
                    .HasColumnName("PU_DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.ShowOnNext)
                    .HasColumnName("SHOW_ON_NEXT")
                    .HasMaxLength(1);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("VALID_TO")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ContractObjNoNavigation)
                    .WithMany(p => p.ContractPrepaidUnits)
                    .HasForeignKey(d => d.ContractObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_PREPAID_UNITS_CONTRACT_FK");
            });

            modelBuilder.Entity<ContractPrepaidUnitsArticles>(entity =>
            {
                entity.HasKey(e => new { e.CpuObjNo, e.ArticleObjNo });

                entity.ToTable("CONTRACT_PREPAID_UNITS_ARTICLES");

                entity.Property(e => e.CpuObjNo).HasColumnName("CPU_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.QtyFactor)
                    .HasColumnName("QTY_FACTOR")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<ContractPrice>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.PriceCode });

                entity.ToTable("CONTRACT_PRICE");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.PriceCode)
                    .HasColumnName("PRICE_CODE")
                    .HasMaxLength(1);

                entity.Property(e => e.PriceLimit)
                    .HasColumnName("PRICE_LIMIT")
                    .HasColumnType("money");

                entity.Property(e => e.VolumeLimit)
                    .HasColumnName("VOLUME_LIMIT")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<ContractTemplate>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CONTRACT_TEMPLATE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNoOneRow).HasColumnName("ARTICLE_OBJ_NO_ONE_ROW");

                entity.Property(e => e.AutomaticAdjustVolume)
                    .HasColumnName("AUTOMATIC_ADJUST_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.CalculateAllRowsAsTotalVolume)
                    .HasColumnName("CALCULATE_ALL_ROWS_AS_TOTAL_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.CalculateMethod)
                    .HasColumnName("CALCULATE_METHOD")
                    .HasMaxLength(3);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractFactor)
                    .HasColumnName("CONTRACT_FACTOR")
                    .HasColumnType("decimal(10, 7)");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CreditEstimated)
                    .HasColumnName("CREDIT_ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.ExcludedDesc)
                    .HasColumnName("EXCLUDED_DESC")
                    .HasMaxLength(255);

                entity.Property(e => e.FpArticleObjNo).HasColumnName("FP_ARTICLE_OBJ_NO");

                entity.Property(e => e.IncludedDesc)
                    .HasColumnName("INCLUDED_DESC")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceCreditCopies)
                    .HasColumnName("INVOICE_CREDIT_COPIES")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceExcessCopies)
                    .HasColumnName("INVOICE_EXCESS_COPIES")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceFrequency)
                    .HasColumnName("INVOICE_FREQUENCY")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.InvoiceLayoutFpObjNo).HasColumnName("INVOICE_LAYOUT_FP_OBJ_NO");

                entity.Property(e => e.InvoiceLayoutLetterObjNo).HasColumnName("INVOICE_LAYOUT_LETTER_OBJ_NO");

                entity.Property(e => e.InvoiceLayoutObjNo).HasColumnName("INVOICE_LAYOUT_OBJ_NO");

                entity.Property(e => e.InvoiceTime)
                    .IsRequired()
                    .HasColumnName("INVOICE_TIME")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceWithMeterReading)
                    .HasColumnName("INVOICE_WITH_METER_READING")
                    .HasMaxLength(1);

                entity.Property(e => e.MakeXmlFileOfInvoice)
                    .HasColumnName("MAKE_XML_FILE_OF_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.MaxDiscount)
                    .HasColumnName("MAX_DISCOUNT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.MeterReadingLetterOneLetter)
                    .HasColumnName("METER_READING_LETTER_ONE_LETTER")
                    .HasMaxLength(1);

                entity.Property(e => e.MrArticleObjNo).HasColumnName("MR_ARTICLE_OBJ_NO");

                entity.Property(e => e.PrintInvoiceAsOneLine)
                    .HasColumnName("PRINT_INVOICE_AS_ONE_LINE")
                    .HasMaxLength(1);

                entity.Property(e => e.ProvisionPercent)
                    .HasColumnName("PROVISION_PERCENT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.PvArticleObjNo).HasColumnName("PV_ARTICLE_OBJ_NO");

                entity.Property(e => e.ReadingFrequency)
                    .HasColumnName("READING_FREQUENCY")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingRunningYear)
                    .HasColumnName("READING_RUNNING_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup1Pv)
                    .HasColumnName("SORTGROUP_1_PV")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2Pv)
                    .HasColumnName("SORTGROUP_2_PV")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.UseInvoicedToVolume)
                    .HasColumnName("USE_INVOICED_TO_VOLUME")
                    .HasMaxLength(1);

                entity.Property(e => e.UsePriceFromArticle).HasColumnName("USE_PRICE_FROM_ARTICLE");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.ContractTemplate)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_TEMPLATE_COMPANY_FK");

                entity.HasOne(d => d.ContractTypeObjNoNavigation)
                    .WithMany(p => p.ContractTemplate)
                    .HasForeignKey(d => d.ContractTypeObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTRACT_TEMPLATE_CONTRACT_TYPE");

                entity.HasOne(d => d.InvoiceLayoutLetterObjNoNavigation)
                    .WithMany(p => p.ContractTemplateInvoiceLayoutLetterObjNoNavigation)
                    .HasForeignKey(d => d.InvoiceLayoutLetterObjNo)
                    .HasConstraintName("FK_CONTRACT_TEMPLATE_INVOICE_LAYOUT");

                entity.HasOne(d => d.InvoiceLayoutObjNoNavigation)
                    .WithMany(p => p.ContractTemplateInvoiceLayoutObjNoNavigation)
                    .HasForeignKey(d => d.InvoiceLayoutObjNo)
                    .HasConstraintName("FK_CONTRACT_TEMPLATE_INVOICE_LAYOUT1");

                entity.HasOne(d => d.MrArticleObjNoNavigation)
                    .WithMany(p => p.ContractTemplateMrArticleObjNoNavigation)
                    .HasForeignKey(d => d.MrArticleObjNo)
                    .HasConstraintName("FK_CONTRACT_TEMPLATE_ARTICLE1");

                entity.HasOne(d => d.PvArticleObjNoNavigation)
                    .WithMany(p => p.ContractTemplatePvArticleObjNoNavigation)
                    .HasForeignKey(d => d.PvArticleObjNo)
                    .HasConstraintName("FK_CONTRACT_TEMPLATE_ARTICLE");
            });

            modelBuilder.Entity<ContractTemplateFixedPrice>(entity =>
            {
                entity.HasKey(e => new { e.ContractTemplateObjNo, e.ArticleObjNo });

                entity.ToTable("CONTRACT_TEMPLATE_FIXED_PRICE");

                entity.Property(e => e.ContractTemplateObjNo).HasColumnName("CONTRACT_TEMPLATE_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.InvoiceFrequency).HasColumnName("INVOICE_FREQUENCY");

                entity.Property(e => e.InvoiceLayoutObjNo).HasColumnName("INVOICE_LAYOUT_OBJ_NO");

                entity.Property(e => e.InvoiceTime)
                    .HasColumnName("INVOICE_TIME")
                    .HasMaxLength(1);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.RowNo).HasColumnName("ROW_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.UsePriceFromArticle)
                    .HasColumnName("USE_PRICE_FROM_ARTICLE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ContractTemplateMeterPriceLevel>(entity =>
            {
                entity.HasKey(e => e.IdNum);

                entity.ToTable("CONTRACT_TEMPLATE_METER_PRICE_LEVEL");

                entity.HasIndex(e => new { e.ContractTemplateObjNo, e.MeterObjNo })
                    .HasName("IDX_CONTRACT_TEMPLATE_METER_PRICE_LEVEL");

                entity.HasIndex(e => new { e.ContractTemplateObjNo, e.MeterObjNo, e.LevelNum })
                    .HasName("IDX_CONTRACT_TEMPLATE_METER_PRICE_LEVEL_UNIQUE_KEY")
                    .IsUnique();

                entity.Property(e => e.IdNum).HasColumnName("ID_NUM");

                entity.Property(e => e.ContractTemplateObjNo).HasColumnName("CONTRACT_TEMPLATE_OBJ_NO");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LevelFromValue)
                    .HasColumnName("LEVEL_FROM_VALUE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.LevelNum)
                    .HasColumnName("LEVEL_NUM")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.HasOne(d => d.ContractTemplateObjNoNavigation)
                    .WithMany(p => p.ContractTemplateMeterPriceLevel)
                    .HasForeignKey(d => d.ContractTemplateObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_TEMPLATE_METER_PRICE_LEVEL_TEMPLATE_FK");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.ContractTemplateMeterPriceLevel)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_TEMPLATE_METER_PRICE_LEVEL_METER_FK");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CONTRACT_TYPE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasColumnName("CONTRACT_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(40);

                entity.Property(e => e.Project).HasColumnName("PROJECT");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.ResponseTimeSupport)
                    .HasColumnName("RESPONSE_TIME_SUPPORT")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Service).HasColumnName("SERVICE");

                entity.Property(e => e.Sg1QuickOrderNotShowIfInvoiceable)
                    .HasColumnName("SG1_QUICK_ORDER_NOT_SHOW_IF_INVOICEABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sg2QuickOrderNotShowIfInvoiceable)
                    .HasColumnName("SG2_QUICK_ORDER_NOT_SHOW_IF_INVOICEABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sg3QuickOrderNotShowIfInvoiceable)
                    .HasColumnName("SG3_QUICK_ORDER_NOT_SHOW_IF_INVOICEABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sg4QuickOrderNotShowIfInvoiceable)
                    .HasColumnName("SG4_QUICK_ORDER_NOT_SHOW_IF_INVOICEABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sg5QuickOrderNotShowIfInvoiceable)
                    .HasColumnName("SG5_QUICK_ORDER_NOT_SHOW_IF_INVOICEABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SolutionTime)
                    .HasColumnName("SOLUTION_TIME")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.SolutionTimeSupport)
                    .HasColumnName("SOLUTION_TIME_SUPPORT")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Support).HasColumnName("SUPPORT");

                entity.Property(e => e.UseResponseTime).HasColumnName("USE_RESPONSE_TIME");

                entity.Property(e => e.UseSolutionTime).HasColumnName("USE_SOLUTION_TIME");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.ContractType)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_TYPE_COMPANY_FK");
            });

            modelBuilder.Entity<ContractTypeArticle>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CONTRACT_TYPE_ARTICLE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ArticleSortgroup)
                    .HasColumnName("ARTICLE_SORTGROUP")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleSortgroupNo)
                    .HasColumnName("ARTICLE_SORTGROUP_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.ContractTypeArticle)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .HasConstraintName("CONTRACT_TYPE_ARTICLE_ARTICLE_FK");

                entity.HasOne(d => d.ContractTypeObjNoNavigation)
                    .WithMany(p => p.ContractTypeArticle)
                    .HasForeignKey(d => d.ContractTypeObjNo)
                    .HasConstraintName("CONTRACT_TYPE_ARTICLE_CONTRACT_FK");
            });

            modelBuilder.Entity<ContractTypeGroups>(entity =>
            {
                entity.HasKey(e => new { e.ContractTypeObjNo, e.Registry, e.Code });

                entity.ToTable("CONTRACT_TYPE_GROUPS");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.HasOne(d => d.ContractTypeObjNoNavigation)
                    .WithMany(p => p.ContractTypeGroups)
                    .HasForeignKey(d => d.ContractTypeObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CONTRACT_TG_CT_FK");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryNo);

                entity.ToTable("COUNTRY");

                entity.Property(e => e.CountryNo)
                    .HasColumnName("COUNTRY_NO")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressFreeFields)
                    .HasColumnName("ADDRESS_FREE_FIELDS")
                    .HasMaxLength(1);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CreditTerms>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("CREDIT_TERMS");

                entity.HasIndex(e => new { e.Company, e.Code })
                    .HasName("UQK_CREDIT_TERMS_COMPANY_CODE")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalculateDiscount)
                    .HasColumnName("CALCULATE_DISCOUNT")
                    .HasMaxLength(1);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.DiscountComment)
                    .HasColumnName("DISCOUNT_COMMENT")
                    .HasMaxLength(1);

                entity.Property(e => e.FromEndOfMonth)
                    .HasColumnName("FROM_END_OF_MONTH")
                    .HasMaxLength(1);

                entity.Property(e => e.NoOfDays)
                    .HasColumnName("NO_OF_DAYS")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NoOfDaysDirectDebit).HasColumnName("NO_OF_DAYS_DIRECT_DEBIT");

                entity.Property(e => e.NoOfDaysDiscount)
                    .HasColumnName("NO_OF_DAYS_DISCOUNT")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Sepa).HasColumnName("SEPA");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.CreditTerms)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CREDIT_TERMS_COMPANY_FK");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CUSTOMER");

                entity.HasIndex(e => e.CalculateInterest)
                    .HasName("IDX_CUSTOMER_CALCULATE_INTEREST");

                entity.HasIndex(e => e.CustomerName)
                    .HasName("IDX_CUSTOMER_NAME_ONLY");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_CUSTOMER_OBJ_NO")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_C_STATUS");

                entity.HasIndex(e => new { e.Company, e.CustomerName })
                    .HasName("customer_name_idx");

                entity.HasIndex(e => new { e.Company, e.CustomerNo })
                    .HasName("customer_no_idx");

                entity.HasIndex(e => new { e.ObjNo, e.CustomerName, e.CustomerNo, e.SearchName })
                    .HasName("IDX_CUSTOMER_NO_NAME_AND_SEARCH");

                entity.HasIndex(e => new { e.ObjNo, e.Company, e.Status, e.CustomerName, e.CustomerNo, e.CustomerName2, e.CustomerName3, e.CustomerName4, e.Dept })
                    .HasName("IDX_CUSTOMER_MANY");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(15);

                entity.Property(e => e.AmalgamateOrders)
                    .HasColumnName("AMALGAMATE_ORDERS")
                    .HasMaxLength(1);

                entity.Property(e => e.BankId)
                    .HasColumnName("BANK_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.BankName)
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessCode)
                    .HasColumnName("BUSINESS_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculateInterest)
                    .HasColumnName("CALCULATE_INTEREST")
                    .HasMaxLength(1);

                entity.Property(e => e.CalculateVat)
                    .HasColumnName("CALCULATE_VAT")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("CREDIT_LIMIT")
                    .HasColumnType("money");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CustomerLink)
                    .HasColumnName("CUSTOMER_LINK")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName2)
                    .HasColumnName("CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName3)
                    .HasColumnName("CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName4)
                    .HasColumnName("CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("CUSTOMER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerNotes).HasColumnName("CUSTOMER_NOTES");

                entity.Property(e => e.CustomerType)
                    .HasColumnName("CUSTOMER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryTerm)
                    .HasColumnName("DELIVERY_TERM")
                    .HasMaxLength(10);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(150);

                entity.Property(e => e.Employees)
                    .HasColumnName("EMPLOYEES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Established)
                    .HasColumnName("ESTABLISHED")
                    .HasMaxLength(15);

                entity.Property(e => e.ExternalSystemKey)
                    .HasColumnName("EXTERNAL_SYSTEM_KEY")
                    .HasMaxLength(40);

                entity.Property(e => e.FixedDiscount)
                    .HasColumnName("FIXED_DISCOUNT")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.GenerateRemainder)
                    .HasColumnName("GENERATE_REMAINDER")
                    .HasMaxLength(1);

                entity.Property(e => e.HideInstallationNode)
                    .HasColumnName("HIDE_INSTALLATION_NODE")
                    .HasMaxLength(1);

                entity.Property(e => e.Http)
                    .HasColumnName("HTTP")
                    .HasMaxLength(50);

                entity.Property(e => e.Information)
                    .HasColumnName("INFORMATION")
                    .HasMaxLength(500);

                entity.Property(e => e.InformationAlwaysOn)
                    .HasColumnName("INFORMATION_ALWAYS_ON")
                    .HasMaxLength(1);

                entity.Property(e => e.InvCustomerAddressRowNo)
                    .HasColumnName("INV_CUSTOMER_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InvCustomerObjNo).HasColumnName("INV_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceFee)
                    .HasColumnName("INVOICE_FEE")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceTax)
                    .HasColumnName("INVOICE_TAX")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MainOfficeCustomerObjNo).HasColumnName("MAIN_OFFICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.MakeXmlFileOfInvoice)
                    .HasColumnName("MAKE_XML_FILE_OF_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.NotAllowPartlyDeliver)
                    .HasColumnName("NOT_ALLOW_PARTLY_DELIVER")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenForInvoice)
                    .HasColumnName("OPEN_FOR_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.OrganizationNo)
                    .HasColumnName("ORGANIZATION_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.PriceList)
                    .HasColumnName("PRICE_LIST")
                    .HasMaxLength(1);

                entity.Property(e => e.Sales)
                    .HasColumnName("SALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.SearchName)
                    .HasColumnName("SEARCH_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.SupportClockPausedTime)
                    .HasColumnName("SUPPORT_CLOCK_PAUSED_TIME")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportMandatoryContact)
                    .HasColumnName("SUPPORT_MANDATORY_CONTACT")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportMandatoryEmail)
                    .HasColumnName("SUPPORT_MANDATORY_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportMandatoryPhone)
                    .HasColumnName("SUPPORT_MANDATORY_PHONE")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportMandatoryPhoneOrEmail)
                    .HasColumnName("SUPPORT_MANDATORY_PHONE_OR_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.WebPassword)
                    .HasColumnName("WEB_PASSWORD")
                    .HasMaxLength(32);

                entity.Property(e => e.XmlFormatOrderLineGroup)
                    .HasColumnName("XML_FORMAT_ORDER_LINE_GROUP")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_COMPANY_FK");

                entity.HasOne(d => d.CreditTermNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CreditTerm)
                    .HasConstraintName("CUSTOMER_CREDIT_TERM_FK");

                entity.HasOne(d => d.SalesmanObjNoNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.SalesmanObjNo)
                    .HasConstraintName("CUSTOMER_SALESMAN_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_DEPT_FK");
            });

            modelBuilder.Entity<CustomerBalance>(entity =>
            {
                entity.HasKey(e => e.CustomerObjNo);

                entity.ToTable("CUSTOMER_BALANCE");

                entity.Property(e => e.CustomerObjNo)
                    .HasColumnName("CUSTOMER_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance)
                    .HasColumnName("BALANCE")
                    .HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithOne(p => p.CustomerBalance)
                    .HasForeignKey<CustomerBalance>(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_BALANCE_FK");
            });

            modelBuilder.Entity<CustomerInvoicing>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Company, e.OrderNo });

                entity.ToTable("CUSTOMER_INVOICING");

                entity.HasIndex(e => e.ContractObjNo)
                    .HasName("IDX_CI_CONTRACT_OBJ_NO");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_CI_CUSTOMER_OBJ_NO");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_CI_MACHINE_OBJ_NO");

                entity.HasIndex(e => e.RowSource)
                    .HasName("IDX_CI_ROW_SOURCE");

                entity.HasIndex(e => new { e.Company, e.OrderNo })
                    .HasName("IDX_CI_COMPANY_ORDER_NO");

                entity.HasIndex(e => new { e.ContractObjNo, e.OrderNo })
                    .HasName("IDX_CI_CONTRACT_ORDER");

                entity.HasIndex(e => new { e.ContractObjNo, e.ContractRowNo, e.MachineObjNo, e.MeterObjNo })
                    .HasName("IDX_CUSTOMER_INV_MACHINE_METER_CONTRACT");

                entity.HasIndex(e => new { e.InvoiceDate, e.RowSource, e.Company, e.CustomerObjNo })
                    .HasName("IDX_CUSTOMER_INVOICING_REPORT");

                entity.HasIndex(e => new { e.No, e.Company, e.CustomerObjNo, e.OrderNo })
                    .HasName("IDX_CUSTOMER_INVOICING_SEARCH");

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Correction)
                    .HasColumnName("CORRECTION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.FromCounter)
                    .HasColumnName("FROM_COUNTER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceRangeFrom)
                    .HasColumnName("INVOICE_RANGE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceRangeTo)
                    .HasColumnName("INVOICE_RANGE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceReadingFrequence)
                    .HasColumnName("INVOICE_READING_FREQUENCE")
                    .HasColumnType("decimal(15, 10)");

                entity.Property(e => e.InvoicedSum)
                    .HasColumnName("INVOICED_SUM")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.MrSubContractNo)
                    .HasColumnName("MR_SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNoContract)
                    .HasColumnName("ORDER_NO_CONTRACT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrginalPeriodicVolume)
                    .HasColumnName("ORGINAL_PERIODIC_VOLUME")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OrginalRowPeriodicHiddenVolume)
                    .HasColumnName("ORGINAL_ROW_PERIODIC_HIDDEN_VOLUME")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OrginalRowPeriodicVolume)
                    .HasColumnName("ORGINAL_ROW_PERIODIC_VOLUME")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OrginalVolumeOfTotal)
                    .HasColumnName("ORGINAL_VOLUME_OF_TOTAL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PlussUnits)
                    .HasColumnName("PLUSS_UNITS")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.PricePerUnitOrMonth)
                    .HasColumnName("PRICE_PER_UNIT_OR_MONTH")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.ReadingFrequenceOtherFirst)
                    .HasColumnName("READING_FREQUENCE_OTHER_FIRST")
                    .HasColumnType("decimal(15, 10)");

                entity.Property(e => e.RowSource)
                    .HasColumnName("ROW_SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.RowSourcePart)
                    .HasColumnName("ROW_SOURCE_PART")
                    .HasMaxLength(2);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ToCounter)
                    .HasColumnName("TO_COUNTER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseNextPeriod)
                    .HasColumnName("USE_NEXT_PERIOD")
                    .HasMaxLength(1);

                entity.Property(e => e.UsedUnits)
                    .HasColumnName("USED_UNITS")
                    .HasColumnType("numeric(15, 0)");
            });

            modelBuilder.Entity<CustomerInvoicingMeterDetails>(entity =>
            {
                entity.HasKey(e => e.LineNo);

                entity.ToTable("CUSTOMER_INVOICING_METER_DETAILS");

                entity.HasIndex(e => e.CiNo)
                    .HasName("IDX_CIMD_CI");

                entity.HasIndex(e => e.LineNo)
                    .HasName("IDX_CUSTOMER_INVOICING_METER_DETAILS");

                entity.HasIndex(e => new { e.CiNo, e.Company, e.OrderNo })
                    .HasName("IDX_CIMD_CI_FULL");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CiNo)
                    .HasColumnName("CI_NO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedFrom)
                    .HasColumnName("ESTIMATED_FROM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedTo)
                    .HasColumnName("ESTIMATED_TO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromCounter)
                    .HasColumnName("FROM_COUNTER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingDateFrom)
                    .HasColumnName("READING_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadingDateTo)
                    .HasColumnName("READING_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToCounter)
                    .HasColumnName("TO_COUNTER")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.CustomerInvoicing)
                    .WithMany(p => p.CustomerInvoicingMeterDetails)
                    .HasForeignKey(d => new { d.CiNo, d.Company, d.OrderNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_INVOICING_METER_DETAILS_CI_FK");
            });

            modelBuilder.Entity<CustomerMachineModelMeterPrice>(entity =>
            {
                entity.HasKey(e => new { e.CustomerObjNo, e.MachineObjNo, e.ModelObjNo, e.MeterObjNo });

                entity.ToTable("CUSTOMER_MACHINE_MODEL_METER_PRICE");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.CustomerMachineModelMeterPrice)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CMMMP_CUSTOMER_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.CustomerMachineModelMeterPrice)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CMMMP_MACHINE_FK");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.CustomerMachineModelMeterPrice)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CMMMP_METER_FK");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.CustomerMachineModelMeterPrice)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CMMMP_MODEL_FK");
            });

            modelBuilder.Entity<CustomerMailFormat>(entity =>
            {
                entity.HasKey(e => new { e.CustomerObjNo, e.Type });

                entity.ToTable("CUSTOMER_MAIL_FORMAT");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.EmailFormat)
                    .HasColumnName("EMAIL_FORMAT")
                    .HasMaxLength(4000);

                entity.Property(e => e.SendAutomatically)
                    .HasColumnName("SEND_AUTOMATICALLY")
                    .HasMaxLength(1);

                entity.Property(e => e.SendEmail)
                    .HasColumnName("SEND_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.SendSms)
                    .HasColumnName("SEND_SMS")
                    .HasMaxLength(1);

                entity.Property(e => e.SmsFormat)
                    .HasColumnName("SMS_FORMAT")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.CustomerMailFormat)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_MAIL_FORMAT_FK");
            });

            modelBuilder.Entity<CustomerPayment>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.OrderNo, e.DateOfPayment });

                entity.ToTable("CUSTOMER_PAYMENT");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DateOfPayment)
                    .HasColumnName("DATE_OF_PAYMENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.StatusPayment)
                    .HasColumnName("STATUS_PAYMENT")
                    .HasMaxLength(2);

                entity.HasOne(d => d.OrderHeading)
                    .WithMany(p => p.CustomerPayment)
                    .HasForeignKey(d => new { d.Company, d.OrderNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CP_ORDER_FK");
            });

            modelBuilder.Entity<CustomerTechnician>(entity =>
            {
                entity.HasKey(e => new { e.CustomerObjNo, e.TechnicianObjNo });

                entity.ToTable("CUSTOMER_TECHNICIAN");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.CustomerTechnician)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_TECHNICIAN_CUSTOMER_FK");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.CustomerTechnician)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUSTOMER_TECHNICIAN_TECHNICIAN_FK");
            });

            modelBuilder.Entity<DatabaseLog>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("DATABASE_LOG");

                entity.HasIndex(e => new { e.SourceHeadingNo, e.SourceRowNo })
                    .HasName("IDX_DATABASE_LOG_HEADING_ROW_NO");

                entity.HasIndex(e => new { e.LogType, e.SourceRowNo, e.SourceHeadingNo })
                    .HasName("IDX_DATABASE_LOG_TYPE_ROW_NO_HEADING_NO");

                entity.HasIndex(e => new { e.LogType, e.SourceHeadingNo, e.SourceRowNo, e.ObjNo })
                    .HasName("IDX_DATABASE_LOG_TYPE_HEADING_ROW_OBJ_NO");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.LogComment)
                    .HasColumnName("LOG_COMMENT")
                    .HasMaxLength(256);

                entity.Property(e => e.LogDate)
                    .HasColumnName("LOG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogInfo)
                    .HasColumnName("LOG_INFO")
                    .HasMaxLength(256);

                entity.Property(e => e.LogType)
                    .HasColumnName("LOG_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.LogUser)
                    .HasColumnName("LOG_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceHeadingNo)
                    .HasColumnName("SOURCE_HEADING_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.SourceRowNo)
                    .HasColumnName("SOURCE_ROW_NO")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<DatabaseTextLog>(entity =>
            {
                entity.HasKey(e => new { e.LogType, e.SourceObjNo, e.LogUser, e.LogDate });

                entity.ToTable("DATABASE_TEXT_LOG");

                entity.Property(e => e.LogType)
                    .HasColumnName("LOG_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.LogUser)
                    .HasColumnName("LOG_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.LogDate)
                    .HasColumnName("LOG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogText).HasColumnName("LOG_TEXT");
            });

            modelBuilder.Entity<DefaultServicesArticles>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.ProjectTaskType, e.SymptomCode1, e.SymptomCode2, e.SymptomCode3, e.SymptomCode4 });

                entity.ToTable("DEFAULT_SERVICES_ARTICLES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTaskType).HasColumnName("PROJECT_TASK_TYPE");

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode4)
                    .HasColumnName("SYMPTOM_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleType)
                    .IsRequired()
                    .HasColumnName("ARTICLE_TYPE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<DefaultWorkHours>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("DEFAULT_WORK_HOURS");

                entity.HasIndex(e => new { e.Company, e.DateFrom })
                    .HasName("IDX_DEFAULT_WORK_HOURS");

                entity.HasIndex(e => new { e.SourceObjNo, e.DateFrom })
                    .HasName("IDX_DEFAULT_WORK_HOURS_SOURCE");

                entity.HasIndex(e => new { e.Company, e.Dept, e.DateFrom })
                    .HasName("IDX_DEFAULT_WORK_HOURS_DEPT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HoursFri)
                    .HasColumnName("HOURS_FRI")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursMon)
                    .HasColumnName("HOURS_MON")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursSat)
                    .HasColumnName("HOURS_SAT")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursSun)
                    .HasColumnName("HOURS_SUN")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursThu)
                    .HasColumnName("HOURS_THU")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursTue)
                    .HasColumnName("HOURS_TUE")
                    .HasMaxLength(11);

                entity.Property(e => e.HoursWed)
                    .HasColumnName("HOURS_WED")
                    .HasMaxLength(11);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept });

                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("BANK_ACCOUNT_NO")
                    .HasMaxLength(11);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("COMPANY_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CreditorId)
                    .HasColumnName("CREDITOR_ID")
                    .HasMaxLength(35);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("DEPARTMENT_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderTypeContract)
                    .HasColumnName("ORDER_TYPE_CONTRACT")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderTypeContractMr)
                    .HasColumnName("ORDER_TYPE_CONTRACT_MR")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderTypeOrder)
                    .HasColumnName("ORDER_TYPE_ORDER")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderTypeProject)
                    .HasColumnName("ORDER_TYPE_PROJECT")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostAccountNo)
                    .HasColumnName("POST_ACCOUNT_NO")
                    .HasMaxLength(11);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DEPARTMENT_COMPANY_FK");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("DOCUMENT");

                entity.HasIndex(e => e.SourceObjNo)
                    .HasName("IDX_DOCUMENT_SOURCE_OBJ_NO");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocNode)
                    .HasColumnName("DOC_NODE")
                    .HasMaxLength(512);

                entity.Property(e => e.DocumentDateCreated)
                    .HasColumnName("DOCUMENT_DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentFile)
                    .IsRequired()
                    .HasColumnName("DOCUMENT_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.DocumentSize)
                    .HasColumnName("DOCUMENT_SIZE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocumentTitle)
                    .IsRequired()
                    .HasColumnName("DOCUMENT_TITLE")
                    .HasMaxLength(250);

                entity.Property(e => e.DocumentType)
                    .HasColumnName("DOCUMENT_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.InfoCheckbox01)
                    .HasColumnName("INFO_CHECKBOX_01")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox02)
                    .HasColumnName("INFO_CHECKBOX_02")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox03)
                    .HasColumnName("INFO_CHECKBOX_03")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox04)
                    .HasColumnName("INFO_CHECKBOX_04")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox05)
                    .HasColumnName("INFO_CHECKBOX_05")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadOnlyAccess)
                    .HasColumnName("READ_ONLY_ACCESS")
                    .HasMaxLength(1);

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.TaskObjNo).HasColumnName("TASK_OBJ_NO");

                entity.Property(e => e.UseInMeterReadingLetter)
                    .HasColumnName("USE_IN_METER_READING_LETTER")
                    .HasMaxLength(1);

                entity.Property(e => e.UseInMobile)
                    .HasColumnName("USE_IN_MOBILE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DocumentTrans>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("DOCUMENT_TRANS");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocumentFile)
                    .IsRequired()
                    .HasColumnName("DOCUMENT_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.DocumentTitle)
                    .HasColumnName("DOCUMENT_TITLE")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<EmpChecker>(entity =>
            {
                entity.HasKey(e => e.ResourceObjNo);

                entity.ToTable("EMP_CHECKER");

                entity.Property(e => e.ResourceObjNo)
                    .HasColumnName("RESOURCE_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Checker)
                    .IsRequired()
                    .HasColumnName("CHECKER")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EpwIdSettings>(entity =>
            {
                entity.HasKey(e => e.Loginid);

                entity.ToTable("EPW_ID_SETTINGS");

                entity.Property(e => e.Loginid)
                    .HasColumnName("LOGINID")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Countrycode)
                    .HasColumnName("COUNTRYCODE")
                    .HasMaxLength(2);

                entity.Property(e => e.Projectsummaryamount).HasColumnName("PROJECTSUMMARYAMOUNT");

                entity.Property(e => e.Projectsummarycolumns)
                    .HasColumnName("PROJECTSUMMARYCOLUMNS")
                    .HasMaxLength(500);

                entity.Property(e => e.Projectsummarylayout).HasColumnName("PROJECTSUMMARYLAYOUT");

                entity.Property(e => e.Projectsummarysorting)
                    .HasColumnName("PROJECTSUMMARYSORTING")
                    .HasMaxLength(200);

                entity.Property(e => e.Searchamount).HasColumnName("SEARCHAMOUNT");

                entity.Property(e => e.Splittersizes)
                    .HasColumnName("SPLITTERSIZES")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<EvaticDataType>(entity =>
            {
                entity.HasKey(e => e.DataType);

                entity.ToTable("EVATIC_DATA_TYPE");

                entity.Property(e => e.DataType)
                    .HasColumnName("DATA_TYPE")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ExternalSoldItems>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.InvoiceNo, e.ArticleNo, e.SerialNo });

                entity.ToTable("EXTERNAL_SOLD_ITEMS");

                entity.HasIndex(e => new { e.Company, e.DeliveryDate })
                    .HasName("IDX_EXTERNAL_SOLD_ITEMS_DELIVERY_DATE");

                entity.HasIndex(e => new { e.Company, e.SerialNo })
                    .HasName("IDX_EXTERNAL_SOLD_ITEMS_SERIAL_NO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(15);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("AREA_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.AreaDescription)
                    .HasColumnName("AREA_DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName2)
                    .HasColumnName("CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName3)
                    .HasColumnName("CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerName4)
                    .HasColumnName("CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("CUSTOMER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryCustomerNo)
                    .HasColumnName("DELIVERY_CUSTOMER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(150);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.Imported)
                    .HasColumnName("IMPORTED")
                    .HasMaxLength(1);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.PostLocation)
                    .HasColumnName("POST_LOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("PROJECT_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("numeric(11, 5)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("STATUS_DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.StockNo)
                    .HasColumnName("STOCK_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.WarrantyEndDate)
                    .HasColumnName("WARRANTY_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyText)
                    .HasColumnName("WARRANTY_TEXT")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ExternalStockAdminOrderHeading>(entity =>
            {
                entity.HasKey(e => new { e.OrderNo, e.Company });

                entity.ToTable("EXTERNAL_STOCK_ADMIN_ORDER_HEADING");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.DelAddress1)
                    .HasColumnName("DEL_ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress2)
                    .HasColumnName("DEL_ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress3)
                    .HasColumnName("DEL_ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddressName)
                    .HasColumnName("DEL_ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DelContactName)
                    .HasColumnName("DEL_CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.DelCountryNo)
                    .HasColumnName("DEL_COUNTRY_NO")
                    .HasMaxLength(5);

                entity.Property(e => e.DelCustomerNo)
                    .HasColumnName("DEL_CUSTOMER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.DelFaxNo)
                    .HasColumnName("DEL_FAX_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.DelPhoneNo)
                    .HasColumnName("DEL_PHONE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.DelPostalCode)
                    .HasColumnName("DEL_POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DelPostalDescription)
                    .HasColumnName("DEL_POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDelivery)
                    .HasColumnName("DIRECT_DELIVERY")
                    .HasMaxLength(1);

                entity.Property(e => e.ExternalInfo)
                    .HasColumnName("EXTERNAL_INFO")
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalOrderNo)
                    .HasColumnName("EXTERNAL_ORDER_NO")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ExternalStatus)
                    .HasColumnName("EXTERNAL_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.SupplierNo)
                    .HasColumnName("SUPPLIER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SuppliersOrderNo)
                    .HasColumnName("SUPPLIERS_ORDER_NO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ExternalStockAdminOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.OrderNo, e.Company, e.OrderLine });

                entity.ToTable("EXTERNAL_STOCK_ADMIN_ORDER_LINE");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLine)
                    .HasColumnName("ORDER_LINE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AllReceived)
                    .HasColumnName("ALL_RECEIVED")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleNo)
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.EstimatedArrival)
                    .HasColumnName("ESTIMATED_ARRIVAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Express)
                    .HasColumnName("EXPRESS")
                    .HasMaxLength(1);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(60);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaOrdered)
                    .HasColumnName("QTA_ORDERED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaReceived)
                    .HasColumnName("QTA_RECEIVED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReplacementNo).HasColumnName("REPLACEMENT_NO");

                entity.Property(e => e.ReturnReference)
                    .HasColumnName("RETURN_REFERENCE")
                    .HasMaxLength(9);

                entity.Property(e => e.ReturnType)
                    .HasColumnName("RETURN_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ReturnedSerialNo)
                    .HasColumnName("RETURNED_SERIAL_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SalesOrderLineNo)
                    .HasColumnName("SALES_ORDER_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SalesOrderNo)
                    .HasColumnName("SALES_ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.StockNo)
                    .HasColumnName("STOCK_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.SuppliersInvoiceNo)
                    .HasColumnName("SUPPLIERS_INVOICE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.HasOne(d => d.ExternalStockAdminOrderHeading)
                    .WithMany(p => p.ExternalStockAdminOrderLine)
                    .HasForeignKey(d => new { d.OrderNo, d.Company })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EXT_STOCK_ADMIN_OL_OH_FK");
            });

            modelBuilder.Entity<ExternalStockAdminOrderLineReceived>(entity =>
            {
                entity.HasKey(e => new { e.OrderNo, e.Company, e.ReceivedDate, e.PackingSlipNo, e.PackingSlipLineNo });

                entity.ToTable("EXTERNAL_STOCK_ADMIN_ORDER_LINE_RECEIVED");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("RECEIVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PackingSlipLineNo)
                    .HasColumnName("PACKING_SLIP_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleNo)
                    .IsRequired()
                    .HasColumnName("ARTICLE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OrderLine)
                    .HasColumnName("ORDER_LINE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.QtaReceived)
                    .HasColumnName("QTA_RECEIVED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaRemaining)
                    .HasColumnName("QTA_REMAINING")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<FollowUp>(entity =>
            {
                entity.HasKey(e => new { e.FollowUpCode, e.ObjNo, e.FollowUpNo });

                entity.ToTable("FOLLOW_UP");

                entity.Property(e => e.FollowUpCode)
                    .HasColumnName("FOLLOW_UP_CODE")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.FollowUpNo)
                    .HasColumnName("FOLLOW_UP_NO")
                    .HasColumnType("numeric(5, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.FollowUpBy).HasColumnName("FOLLOW_UP_BY");

                entity.Property(e => e.FollowUpCategory)
                    .HasColumnName("FOLLOW_UP_CATEGORY")
                    .HasMaxLength(10);

                entity.Property(e => e.FollowUpDate)
                    .HasColumnName("FOLLOW_UP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Show)
                    .HasColumnName("SHOW")
                    .HasColumnType("numeric(2, 0)");

                entity.HasOne(d => d.FollowUpByNavigation)
                    .WithMany(p => p.FollowUp)
                    .HasForeignKey(d => d.FollowUpBy)
                    .HasConstraintName("FOLLOW_UP_SALESMAN_FK");
            });

            modelBuilder.Entity<FrequenceList>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.ArticleObjNo });

                entity.ToTable("FREQUENCE_LIST");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("numeric(25, 5)");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.FrequenceList)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FL_MODEL_FK");
            });

            modelBuilder.Entity<IncidentStatus>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code });

                entity.ToTable("INCIDENT_STATUS");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.AllowClose)
                    .HasColumnName("ALLOW_CLOSE")
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnName("INACTIVE");

                entity.Property(e => e.SolutionTime)
                    .HasColumnName("SOLUTION_TIME")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<InforegGroups>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Registry, e.Code });

                entity.ToTable("INFOREG_GROUPS");

                entity.HasIndex(e => new { e.Registry, e.Company })
                    .HasName("IDX_INFOREG_GROUPS_REGISTRY");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnName("INACTIVE");
            });

            modelBuilder.Entity<InforegGroupValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Registry, e.Code, e.Value });

                entity.ToTable("INFOREG_GROUP_VALUES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Information>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.TextType, e.TextNo, e.TextInfo });

                entity.ToTable("INFORMATION");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TextType).HasColumnName("TEXT_TYPE");

                entity.Property(e => e.TextNo)
                    .HasColumnName("TEXT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TextInfo)
                    .HasColumnName("TEXT_INFO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<InformationLink>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.TextType, e.TextNo, e.SourceObjNo });

                entity.ToTable("INFORMATION_LINK");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TextType).HasColumnName("TEXT_TYPE");

                entity.Property(e => e.TextNo)
                    .HasColumnName("TEXT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");
            });

            modelBuilder.Entity<InvoiceHeading>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.InvoiceNo, e.Dept });

                entity.ToTable("INVOICE_HEADING");

                entity.HasIndex(e => new { e.Company, e.InvoiceNo, e.Dept })
                    .HasName("IDX_INVOICE_HEADING_INCLUDE_DATE");

                entity.HasIndex(e => new { e.Company, e.InvoiceNo, e.Dept, e.InvoiceStatus })
                    .HasName("IDX_INVOICE_HEADING_STATUS");

                entity.HasIndex(e => new { e.Company, e.InvoiceNo, e.Dept, e.InvoiceDate, e.InvoiceStatus, e.InvoiceCustomerObjNo })
                    .HasName("IDX_INVOICE_HEADING_SEARCH");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AllPaid)
                    .HasColumnName("ALL_PAID")
                    .HasMaxLength(1);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerReferenceInfo)
                    .HasColumnName("CUSTOMER_REFERENCE_INFO")
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryAddress1)
                    .HasColumnName("DELIVERY_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress2)
                    .HasColumnName("DELIVERY_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress3)
                    .HasColumnName("DELIVERY_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryContactName)
                    .HasColumnName("DELIVERY_CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.DeliveryCountry)
                    .HasColumnName("DELIVERY_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.DeliveryCustomerName)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName2)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName3)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName4)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerObjNo).HasColumnName("DELIVERY_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DeliveryName)
                    .HasColumnName("DELIVERY_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryPostalcode)
                    .HasColumnName("DELIVERY_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryPostlocation)
                    .HasColumnName("DELIVERY_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryState)
                    .HasColumnName("DELIVERY_STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DirectDebitDate)
                    .HasColumnName("DIRECT_DEBIT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestCalcTo)
                    .HasColumnName("INTEREST_CALC_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceAddress1)
                    .HasColumnName("INVOICE_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress2)
                    .HasColumnName("INVOICE_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress3)
                    .HasColumnName("INVOICE_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAsEmail)
                    .HasColumnName("INVOICE_AS_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceAsEmailAddress)
                    .HasColumnName("INVOICE_AS_EMAIL_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceCountry)
                    .HasColumnName("INVOICE_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.InvoiceCustomerName)
                    .HasColumnName("INVOICE_CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName2)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName3)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName4)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceName)
                    .HasColumnName("INVOICE_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoicePostalcode)
                    .HasColumnName("INVOICE_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvoicePostlocation)
                    .HasColumnName("INVOICE_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceState)
                    .HasColumnName("INVOICE_STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvoiceStatus)
                    .HasColumnName("INVOICE_STATUS")
                    .HasMaxLength(3);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.OurReference)
                    .HasColumnName("OUR_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ReminderNo)
                    .HasColumnName("REMINDER_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusPayment)
                    .HasColumnName("STATUS_PAYMENT")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<InvoiceLayout>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("INVOICE_LAYOUT");

                entity.HasIndex(e => new { e.Company, e.Code })
                    .HasName("UQK_INVOICE_LAYOUT_COMPANY_CODE")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(3);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ContractNoCheck)
                    .HasColumnName("CONTRACT_NO_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ContractRowTerminated)
                    .HasColumnName("CONTRACT_ROW_TERMINATED")
                    .HasMaxLength(30);

                entity.Property(e => e.ContractRowTerminatedCheck)
                    .HasColumnName("CONTRACT_ROW_TERMINATED_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CopiesIncluded)
                    .HasColumnName("COPIES_INCLUDED")
                    .HasMaxLength(30);

                entity.Property(e => e.CopiesIncludedCheck)
                    .HasColumnName("COPIES_INCLUDED_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CopiesIncludedTotal)
                    .HasColumnName("COPIES_INCLUDED_TOTAL")
                    .HasMaxLength(30);

                entity.Property(e => e.CopiesIncludedTotalCheck)
                    .HasColumnName("COPIES_INCLUDED_TOTAL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DateRange)
                    .HasColumnName("DATE_RANGE")
                    .HasMaxLength(30);

                entity.Property(e => e.DateRangeCheck)
                    .HasColumnName("DATE_RANGE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DateRangeMeterReadingLetter)
                    .HasColumnName("DATE_RANGE_METER_READING_LETTER")
                    .HasMaxLength(30);

                entity.Property(e => e.DateRangeMeterReadingLetterCheck)
                    .HasColumnName("DATE_RANGE_METER_READING_LETTER_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DateRangeMrlOnTopCheck)
                    .HasColumnName("DATE_RANGE_MRL_ON_TOP_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DateRangeOnTopCheck)
                    .HasColumnName("DATE_RANGE_ON_TOP_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DateRangeOverview)
                    .HasColumnName("DATE_RANGE_OVERVIEW")
                    .HasMaxLength(30);

                entity.Property(e => e.DateRangeOverviewCheck)
                    .HasColumnName("DATE_RANGE_OVERVIEW_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.Estimated)
                    .HasColumnName("ESTIMATED")
                    .HasMaxLength(30);

                entity.Property(e => e.EstimatedCheck)
                    .HasColumnName("ESTIMATED_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ExcessCopies)
                    .HasColumnName("EXCESS_COPIES")
                    .HasMaxLength(30);

                entity.Property(e => e.ExcessCopiesCheck)
                    .HasColumnName("EXCESS_COPIES_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FixedPrice)
                    .HasColumnName("FIXED_PRICE")
                    .HasMaxLength(30);

                entity.Property(e => e.FixedPriceCheck)
                    .HasColumnName("FIXED_PRICE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Frequency)
                    .HasColumnName("FREQUENCY")
                    .HasMaxLength(30);

                entity.Property(e => e.FrequencyCheck)
                    .HasColumnName("FREQUENCY_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceOverviewHeading)
                    .HasColumnName("INVOICE_OVERVIEW_HEADING")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceOverviewHeadingCheck)
                    .HasColumnName("INVOICE_OVERVIEW_HEADING_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceOverviewRowBefore)
                    .HasColumnName("INVOICE_OVERVIEW_ROW_BEFORE")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceOverviewRowBeforeCheck)
                    .HasColumnName("INVOICE_OVERVIEW_ROW_BEFORE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceTotal)
                    .HasColumnName("INVOICE_TOTAL")
                    .HasMaxLength(30);

                entity.Property(e => e.InvoiceTotalCheck)
                    .HasColumnName("INVOICE_TOTAL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoiceTotalRowBefore)
                    .HasColumnName("INVOICE_TOTAL_ROW_BEFORE")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceTotalRowBeforeCheck)
                    .HasColumnName("INVOICE_TOTAL_ROW_BEFORE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoicedFromTo)
                    .HasColumnName("INVOICED_FROM_TO")
                    .HasMaxLength(30);

                entity.Property(e => e.InvoicedFromToCheck)
                    .HasColumnName("INVOICED_FROM_TO_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InvoicedFromToTotal)
                    .HasColumnName("INVOICED_FROM_TO_TOTAL")
                    .HasMaxLength(30);

                entity.Property(e => e.InvoicedFromToTotalCheck)
                    .HasColumnName("INVOICED_FROM_TO_TOTAL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(30);

                entity.Property(e => e.LocationCheck)
                    .HasColumnName("LOCATION_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineAddress)
                    .HasColumnName("MACHINE_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.MachineAddressCheck)
                    .HasColumnName("MACHINE_ADDRESS_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineAddressCheckAlways)
                    .HasColumnName("MACHINE_ADDRESS_CHECK_ALWAYS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineAddressNotOverview)
                    .HasColumnName("MACHINE_ADDRESS_NOT_OVERVIEW")
                    .HasMaxLength(255);

                entity.Property(e => e.MachineAddressNotOverviewCheck)
                    .HasColumnName("MACHINE_ADDRESS_NOT_OVERVIEW_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineAddressNotOverviewCheckAlways)
                    .HasColumnName("MACHINE_ADDRESS_NOT_OVERVIEW_CHECK_ALWAYS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineFixed)
                    .HasColumnName("MACHINE_FIXED")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineFixedCheck)
                    .HasColumnName("MACHINE_FIXED_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineIdNo)
                    .HasColumnName("MACHINE_ID_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineIdNoCheck)
                    .HasColumnName("MACHINE_ID_NO_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineNoCheck)
                    .HasColumnName("MACHINE_NO_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineRowBefore)
                    .HasColumnName("MACHINE_ROW_BEFORE")
                    .HasMaxLength(255);

                entity.Property(e => e.MachineRowBeforeCheck)
                    .HasColumnName("MACHINE_ROW_BEFORE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineTotal)
                    .HasColumnName("MACHINE_TOTAL")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineTotalCheck)
                    .HasColumnName("MACHINE_TOTAL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MachineVolume)
                    .HasColumnName("MACHINE_VOLUME")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineVolumeCheck)
                    .HasColumnName("MACHINE_VOLUME_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterInfoOnOverviewCheck)
                    .HasColumnName("METER_INFO_ON_OVERVIEW_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterName)
                    .HasColumnName("METER_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.MeterNameCheck)
                    .HasColumnName("METER_NAME_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReading)
                    .HasColumnName("METER_READING")
                    .HasMaxLength(30);

                entity.Property(e => e.MeterReadingCheck)
                    .HasColumnName("METER_READING_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MeterReadingDate)
                    .HasColumnName("METER_READING_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.MeterReadingDateCheck)
                    .HasColumnName("METER_READING_DATE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("MINIMUM_PRICE")
                    .HasMaxLength(30);

                entity.Property(e => e.MinimumPriceBrackets)
                    .HasColumnName("MINIMUM_PRICE_BRACKETS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MinimumPriceCheck)
                    .HasColumnName("MINIMUM_PRICE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(30);

                entity.Property(e => e.ModelCheck)
                    .HasColumnName("MODEL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.NoOfCopies)
                    .HasColumnName("NO_OF_COPIES")
                    .HasMaxLength(30);

                entity.Property(e => e.NoOfCopiesCheck)
                    .HasColumnName("NO_OF_COPIES_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.NoOfCopiesTotal)
                    .HasColumnName("NO_OF_COPIES_TOTAL")
                    .HasMaxLength(30);

                entity.Property(e => e.NoOfCopiesTotalCheck)
                    .HasColumnName("NO_OF_COPIES_TOTAL_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.NoOfHiddenCopies)
                    .HasColumnName("NO_OF_HIDDEN_COPIES")
                    .HasMaxLength(30);

                entity.Property(e => e.NoOfHiddenCopiesCheck)
                    .HasColumnName("NO_OF_HIDDEN_COPIES_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PrevMetReadCount)
                    .HasColumnName("PREV_MET_READ_COUNT")
                    .HasMaxLength(30);

                entity.Property(e => e.PrevMetReadCountCheck)
                    .HasColumnName("PREV_MET_READ_COUNT_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PrevMetReadDate)
                    .HasColumnName("PREV_MET_READ_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.PrevMetReadDateCheck)
                    .HasColumnName("PREV_MET_READ_DATE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PrevServMetCount)
                    .HasColumnName("PREV_SERV_MET_COUNT")
                    .HasMaxLength(30);

                entity.Property(e => e.PrevServMetCountCheck)
                    .HasColumnName("PREV_SERV_MET_COUNT_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PrevServMetDate)
                    .HasColumnName("PREV_SERV_MET_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.PrevServMetDateCheck)
                    .HasColumnName("PREV_SERV_MET_DATE_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PricePrCopy)
                    .HasColumnName("PRICE_PR_COPY")
                    .HasMaxLength(30);

                entity.Property(e => e.PricePrCopyCheck)
                    .HasColumnName("PRICE_PR_COPY_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SubContractNoCheck)
                    .HasColumnName("SUB_CONTRACT_NO_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.UsedCopies)
                    .HasColumnName("USED_COPIES")
                    .HasMaxLength(30);

                entity.Property(e => e.UsedCopiesCheck)
                    .HasColumnName("USED_COPIES_CHECK")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.InvoiceLayout)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVOICE_LAYOUT_COMPANY_FK");
            });

            modelBuilder.Entity<InvoiceLog>(entity =>
            {
                entity.HasKey(e => e.LogNo);

                entity.ToTable("INVOICE_LOG");

                entity.Property(e => e.LogNo)
                    .HasColumnName("LOG_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.LogDescr)
                    .HasColumnName("LOG_DESCR")
                    .HasMaxLength(50);

                entity.Property(e => e.LogText)
                    .HasColumnName("LOG_TEXT")
                    .HasMaxLength(300);

                entity.Property(e => e.LogTime)
                    .HasColumnName("LOG_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .HasColumnName("LOG_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.LogUser)
                    .HasColumnName("LOG_USER")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.InvoiceNo, e.Dept, e.DateOfPayment });

                entity.ToTable("INVOICE_PAYMENT");

                entity.HasIndex(e => new { e.Company, e.InvoiceNo, e.Dept })
                    .HasName("IDX_INVOICE_PAYMENT_EACH_INVOICE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfPayment)
                    .HasColumnName("DATE_OF_PAYMENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusPayment)
                    .HasColumnName("STATUS_PAYMENT")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<InvoiceSetupDetail>(entity =>
            {
                entity.HasKey(e => new { e.Owner, e.PreviewType, e.Company, e.ContractObjNo, e.InvoiceCustomerObjNo, e.InvoiceAddressRowNo, e.MrSubContractNo });

                entity.ToTable("INVOICE_SETUP_DETAIL");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PreviewType)
                    .HasColumnName("PREVIEW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MrSubContractNo)
                    .HasColumnName("MR_SUB_CONTRACT_NO")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubContractNo)
                    .HasColumnName("SUB_CONTRACT_NO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<LinkArticleMapping>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("LINK_ARTICLE_MAPPING");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleNoExternal)
                    .IsRequired()
                    .HasColumnName("ARTICLE_NO_EXTERNAL")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleNoLocal)
                    .IsRequired()
                    .HasColumnName("ARTICLE_NO_LOCAL")
                    .HasMaxLength(30);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.StepType)
                    .IsRequired()
                    .HasColumnName("STEP_TYPE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<LinkObjectMapping>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("LINK_OBJECT_MAPPING");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleNoExternal)
                    .HasColumnName("ARTICLE_NO_EXTERNAL")
                    .HasMaxLength(30);

                entity.Property(e => e.ArticleNoLocal)
                    .HasColumnName("ARTICLE_NO_LOCAL")
                    .HasMaxLength(30);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.MapType)
                    .HasColumnName("MAP_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.ObjectExternal)
                    .HasColumnName("OBJECT_EXTERNAL")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjectLocal)
                    .IsRequired()
                    .HasColumnName("OBJECT_LOCAL")
                    .HasMaxLength(30);

                entity.Property(e => e.StepType)
                    .IsRequired()
                    .HasColumnName("STEP_TYPE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<LinkSettings>(entity =>
            {
                entity.HasKey(e => new { e.SettingUser, e.SettingKey, e.SubKey });

                entity.ToTable("LINK_SETTINGS");

                entity.Property(e => e.SettingUser)
                    .HasColumnName("SETTING_USER")
                    .HasMaxLength(32);

                entity.Property(e => e.SettingKey)
                    .HasColumnName("SETTING_KEY")
                    .HasMaxLength(32);

                entity.Property(e => e.SubKey)
                    .HasColumnName("SUB_KEY")
                    .HasMaxLength(32);

                entity.Property(e => e.Setting)
                    .HasColumnName("SETTING")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<LinkTransportLog>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("LINK_TRANSPORT_LOG");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignDate)
                    .HasColumnName("ASSIGN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartnerName)
                    .HasColumnName("PARTNER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.PartnerObjNo).HasColumnName("PARTNER_OBJ_NO");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ProjectNoExternal)
                    .HasColumnName("PROJECT_NO_EXTERNAL")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Sent)
                    .IsRequired()
                    .HasColumnName("SENT")
                    .HasMaxLength(1);

                entity.Property(e => e.SentDate)
                    .HasColumnName("SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusMsg)
                    .HasColumnName("STATUS_MSG")
                    .HasMaxLength(300);

                entity.Property(e => e.StepType)
                    .HasColumnName("STEP_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TaskNoExternal)
                    .HasColumnName("TASK_NO_EXTERNAL")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("LOG");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Appdomainname)
                    .IsRequired()
                    .HasColumnName("APPDOMAINNAME");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(64);

                entity.Property(e => e.Eventid).HasColumnName("EVENTID");

                entity.Property(e => e.Formattedmessage).HasColumnName("FORMATTEDMESSAGE");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasColumnName("MACHINENAME")
                    .HasMaxLength(32);

                entity.Property(e => e.Message).HasColumnName("MESSAGE");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Processid)
                    .IsRequired()
                    .HasColumnName("PROCESSID")
                    .HasMaxLength(256);

                entity.Property(e => e.Processname)
                    .IsRequired()
                    .HasColumnName("PROCESSNAME");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(32);

                entity.Property(e => e.Threadname).HasColumnName("THREADNAME");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(256);

                entity.Property(e => e.Win32threadid)
                    .HasColumnName("WIN32THREADID")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("MACHINE");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_MACHINE_CUSTOMER_INCLUDE");

                entity.HasIndex(e => e.ModelObjNo)
                    .HasName("IDX_M_MODEL_OBJ_NO");

                entity.HasIndex(e => new { e.Company, e.Dept })
                    .HasName("IDX_MACHINE_COMPANY_DEPT");

                entity.HasIndex(e => new { e.Company, e.IdNo })
                    .HasName("IDX_MACHINE_ID_NO");

                entity.HasIndex(e => new { e.Company, e.MachineNo })
                    .HasName("machine_no_idx");

                entity.HasIndex(e => new { e.Status, e.CustomerObjNo })
                    .HasName("IDX_MACHINE_STATUS_CUSTOMER")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.ObjNo, e.ModelObjNo, e.MachineNo })
                    .HasName("IDX_MACHINE_OBJ_MODEL_MACHINE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFrom)
                    .HasColumnName("ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActiveTo)
                    .HasColumnName("ACTIVE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddressDelRowNo)
                    .HasColumnName("ADDRESS_DEL_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AddressInvRowNo)
                    .HasColumnName("ADDRESS_INV_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDelObjNo).HasColumnName("CUSTOMER_DEL_OBJ_NO");

                entity.Property(e => e.CustomerInvObjNo).HasColumnName("CUSTOMER_INV_OBJ_NO");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerWarrantyValidTo)
                    .HasColumnName("CUSTOMER_WARRANTY_VALID_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InactiveText)
                    .HasColumnName("INACTIVE_TEXT")
                    .HasMaxLength(255);

                entity.Property(e => e.Information)
                    .HasColumnName("INFORMATION")
                    .HasMaxLength(1024);

                entity.Property(e => e.InformationAlwaysOn)
                    .HasColumnName("INFORMATION_ALWAYS_ON")
                    .HasMaxLength(1);

                entity.Property(e => e.InstallationDate)
                    .HasColumnName("INSTALLATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstallationName)
                    .HasColumnName("INSTALLATION_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallationNode)
                    .HasColumnName("INSTALLATION_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.InvoiceReference)
                    .HasColumnName("INVOICE_REFERENCE")
                    .HasMaxLength(250);

                entity.Property(e => e.InvoiceReferenceManuel)
                    .HasColumnName("INVOICE_REFERENCE_MANUEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(890)
                    .IsUnicode(false);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldMachineNo)
                    .HasColumnName("OLD_MACHINE_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenForInvoice)
                    .HasColumnName("OPEN_FOR_INVOICE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.PackingSlipText)
                    .HasColumnName("PACKING_SLIP_TEXT")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.RelationMaster)
                    .HasColumnName("RELATION_MASTER")
                    .HasMaxLength(1);

                entity.Property(e => e.RemoteAccessAdr)
                    .HasColumnName("REMOTE_ACCESS_ADR")
                    .HasMaxLength(30);

                entity.Property(e => e.RemoteAccessType)
                    .HasColumnName("REMOTE_ACCESS_TYPE")
                    .HasMaxLength(3);

                entity.Property(e => e.RespCustomerObjNo).HasColumnName("RESP_CUSTOMER_OBJ_NO");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.RevNo)
                    .IsRequired()
                    .HasColumnName("REV_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.ServiceOrderReference)
                    .HasColumnName("SERVICE_ORDER_REFERENCE")
                    .HasMaxLength(1024);

                entity.Property(e => e.ServicesCode)
                    .HasColumnName("SERVICES_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_COMPANY_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_CUSTOMER_FK");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_MODEL_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_DEPT_FK");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => new { d.CustomerObjNo, d.AddressRowNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_ADDRESS_FK");
            });

            modelBuilder.Entity<MachineConsumableLevel>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.ConsumableName, e.StatusDate });

                entity.ToTable("MACHINE_CONSUMABLE_LEVEL");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_MACHINE_CONSUMABLE_MACHINE");

                entity.HasIndex(e => e.OrderLineObjNo)
                    .HasName("IDX_MCL_ORDER_LINE");

                entity.HasIndex(e => new { e.MachineObjNo, e.ConsumableName })
                    .HasName("IDX_MACHINE_CONSUMABLE_MACHINE_CONSUMABLE");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ConsumableName)
                    .HasColumnName("CONSUMABLE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalculatedRemainingDays)
                    .HasColumnName("CALCULATED_REMAINING_DAYS")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumableCoverage)
                    .HasColumnName("CONSUMABLE_COVERAGE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.ConsumableLevel)
                    .HasColumnName("CONSUMABLE_LEVEL")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.OrderLineObjNo).HasColumnName("ORDER_LINE_OBJ_NO");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PeakStatus)
                    .HasColumnName("PEAK_STATUS")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<MachineConsumableMeterReading>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.MeterObjNo, e.ReadingDate });

                entity.ToTable("MACHINE_CONSUMABLE_METER_READING");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ReadingDate)
                    .HasColumnName("READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Counter)
                    .HasColumnName("COUNTER")
                    .HasColumnType("numeric(12, 0)");
            });

            modelBuilder.Entity<MachineData>(entity =>
            {
                entity.HasKey(e => e.MachineObjNo);

                entity.ToTable("MACHINE_DATA");

                entity.Property(e => e.MachineObjNo)
                    .HasColumnName("MACHINE_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFrom)
                    .HasColumnName("ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActiveTo)
                    .HasColumnName("ACTIVE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Activities)
                    .HasColumnName("ACTIVITIES")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.LastVisit)
                    .HasColumnName("LAST_VISIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasColumnType("numeric(19, 5)");
            });

            modelBuilder.Entity<MachineLeasingInformation>(entity =>
            {
                entity.HasKey(e => e.MachineObjNo);

                entity.ToTable("MACHINE_LEASING_INFORMATION");

                entity.Property(e => e.MachineObjNo)
                    .HasColumnName("MACHINE_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Leasing)
                    .HasColumnName("LEASING")
                    .HasMaxLength(1);

                entity.Property(e => e.LeasingFactor)
                    .HasColumnName("LEASING_FACTOR")
                    .HasColumnType("decimal(11, 6)");

                entity.Property(e => e.LeasingInvestedAmount)
                    .HasColumnName("LEASING_INVESTED_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingInvestedCostAccessories)
                    .HasColumnName("LEASING_INVESTED_COST_ACCESSORIES")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingInvestedCostMachine)
                    .HasColumnName("LEASING_INVESTED_COST_MACHINE")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingOwner).HasColumnName("LEASING_OWNER");

                entity.Property(e => e.LeasingOwnerContractNo)
                    .HasColumnName("LEASING_OWNER_CONTRACT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.LeasingRefiContractPeriod)
                    .HasColumnName("LEASING_REFI_CONTRACT_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.LeasingRefiFactor)
                    .HasColumnName("LEASING_REFI_FACTOR")
                    .HasColumnType("decimal(11, 6)");

                entity.Property(e => e.LeasingRefiInvestedAmount)
                    .HasColumnName("LEASING_REFI_INVESTED_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.LeasingStartDate)
                    .HasColumnName("LEASING_START_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MachineOnContract>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo, e.MachineObjNo });

                entity.ToTable("MACHINE_ON_CONTRACT");

                entity.HasIndex(e => e.ContractActiveFrom)
                    .HasName("IDX_MC_ACTIVE_FROM");

                entity.HasIndex(e => e.ContractActiveUntil)
                    .HasName("IDX_MC_ACTIVE_UNTIL");

                entity.HasIndex(e => e.ContractTypeObjNo)
                    .HasName("IDX_MC_CONTRACT_TYPE");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_MOC_MACHINE_OBJ_NO");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ConsumableOrder)
                    .HasColumnName("CONSUMABLE_ORDER")
                    .HasMaxLength(1);

                entity.Property(e => e.ConsumableOrderMinimumLevel)
                    .HasColumnName("CONSUMABLE_ORDER_MINIMUM_LEVEL")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ConsumableOrderRemainingDays)
                    .HasColumnName("CONSUMABLE_ORDER_REMAINING_DAYS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ConsumableOrderSoonDays)
                    .HasColumnName("CONSUMABLE_ORDER_SOON_DAYS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ConsumableOrderSplitOnLocation)
                    .HasColumnName("CONSUMABLE_ORDER_SPLIT_ON_LOCATION")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractActiveFrom)
                    .HasColumnName("CONTRACT_ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractActiveUntil)
                    .HasColumnName("CONTRACT_ACTIVE_UNTIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CreditEstimated)
                    .HasColumnName("CREDIT_ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.CreditEstimatedFixed)
                    .HasColumnName("CREDIT_ESTIMATED_FIXED")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CreditEstimatedLastPeriodInvoiced).HasColumnName("CREDIT_ESTIMATED_LAST_PERIOD_INVOICED");

                entity.Property(e => e.CreditEstimatedLastYearInvoiced).HasColumnName("CREDIT_ESTIMATED_LAST_YEAR_INVOICED");

                entity.Property(e => e.CustomerWarrantyDateFrom)
                    .HasColumnName("CUSTOMER_WARRANTY_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerWarrantyDateTo)
                    .HasColumnName("CUSTOMER_WARRANTY_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerWarrantyMonths)
                    .HasColumnName("CUSTOMER_WARRANTY_MONTHS")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.InvoiceTextAddressCustomerObjNo).HasColumnName("INVOICE_TEXT_ADDRESS_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceTextAddressRowNo)
                    .HasColumnName("INVOICE_TEXT_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InvoiceTextLocation)
                    .HasColumnName("INVOICE_TEXT_LOCATION")
                    .HasMaxLength(100);

                entity.Property(e => e.MeterAddressRowNo)
                    .HasColumnName("METER_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MeterContact)
                    .HasColumnName("METER_CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.MeterCustObjNo).HasColumnName("METER_CUST_OBJ_NO");

                entity.Property(e => e.MeterDateGenerated)
                    .HasColumnName("METER_DATE_GENERATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterDateReminded)
                    .HasColumnName("METER_DATE_REMINDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterIdentification)
                    .HasColumnName("METER_IDENTIFICATION")
                    .HasMaxLength(15);

                entity.Property(e => e.MeterSendLetterBy)
                    .HasColumnName("METER_SEND_LETTER_BY")
                    .HasMaxLength(1);

                entity.Property(e => e.MeterSendLetterByValue)
                    .HasColumnName("METER_SEND_LETTER_BY_VALUE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.ContractTypeObjNoNavigation)
                    .WithMany(p => p.MachineOnContract)
                    .HasForeignKey(d => d.ContractTypeObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MOC_CONTRACT_TYPE_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.MachineOnContract)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MOC_MACHINE_FK");

                entity.HasOne(d => d.ContractPeriodVolume)
                    .WithMany(p => p.MachineOnContract)
                    .HasForeignKey(d => new { d.ContractObjNo, d.RowNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MOC_CONTRACT_PV_FK");
            });

            modelBuilder.Entity<MachineRelation>(entity =>
            {
                entity.HasKey(e => new { e.PrimaryObjNo, e.RelationObjNo });

                entity.ToTable("MACHINE_RELATION");

                entity.HasIndex(e => e.PrimaryObjNo)
                    .HasName("IDX_MR_PRIMARY");

                entity.HasIndex(e => new { e.RelationObjNo, e.TreeLevel })
                    .HasName("IDX_MR_RELATION");

                entity.Property(e => e.PrimaryObjNo).HasColumnName("PRIMARY_OBJ_NO");

                entity.Property(e => e.RelationObjNo).HasColumnName("RELATION_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjUser)
                    .HasColumnName("OBJ_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TreeLevel)
                    .HasColumnName("TREE_LEVEL")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("MAIL");

                entity.HasIndex(e => e.SourceObjNo)
                    .HasName("IDX_MAIL_SOURCE_OBJ_NO");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500);

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.From)
                    .HasColumnName("FROM")
                    .HasMaxLength(500);

                entity.Property(e => e.MailDate)
                    .HasColumnName("MAIL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MailText).HasColumnName("MAIL_TEXT");

                entity.Property(e => e.MailType)
                    .HasColumnName("MAIL_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.NumAttachment)
                    .HasColumnName("NUM_ATTACHMENT")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(500);

                entity.Property(e => e.To)
                    .HasColumnName("TO")
                    .HasMaxLength(500);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MailAutoServer>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("MAIL_AUTO_SERVER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(500);

                entity.Property(e => e.Body).HasColumnName("BODY");

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500);

                entity.Property(e => e.FromAddress)
                    .HasColumnName("FROM_ADDRESS")
                    .HasMaxLength(500);

                entity.Property(e => e.FromName)
                    .HasColumnName("FROM_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.InternalInfoField)
                    .HasColumnName("INTERNAL_INFO_FIELD")
                    .HasMaxLength(255);

                entity.Property(e => e.MailDate)
                    .HasColumnName("MAIL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MailSentDate)
                    .HasColumnName("MAIL_SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumAttachment)
                    .HasColumnName("NUM_ATTACHMENT")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(500);

                entity.Property(e => e.To)
                    .HasColumnName("TO")
                    .HasMaxLength(500);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Meter>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("METER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.MeterType)
                    .IsRequired()
                    .HasColumnName("METER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.MeterVirtual)
                    .HasColumnName("METER_VIRTUAL")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Meter)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("METER_COMPANY_FK");
            });

            modelBuilder.Entity<MeterArticleEstimated>(entity =>
            {
                entity.HasKey(e => e.MeterObjNo);

                entity.ToTable("METER_ARTICLE_ESTIMATED");

                entity.Property(e => e.MeterObjNo)
                    .HasColumnName("METER_OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");
            });

            modelBuilder.Entity<MeterOnContract>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo, e.MachineObjNo, e.MeterObjNo });

                entity.ToTable("METER_ON_CONTRACT");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Counter)
                    .HasColumnName("COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CreditEstimatedTerminatedLastInvoiced)
                    .HasColumnName("CREDIT_ESTIMATED_TERMINATED_LAST_INVOICED")
                    .HasMaxLength(1);

                entity.Property(e => e.MaxCounter)
                    .HasColumnName("MAX_COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MeterLetterReported)
                    .HasColumnName("METER_LETTER_REPORTED")
                    .HasMaxLength(1);

                entity.Property(e => e.MeterVolume)
                    .HasColumnName("METER_VOLUME")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingCounterLap)
                    .HasColumnName("READING_COUNTER_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReadingTerminateLap)
                    .HasColumnName("READING_TERMINATE_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TerminateCounter)
                    .HasColumnName("TERMINATE_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TerminateDate)
                    .HasColumnName("TERMINATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseNextPeriod)
                    .HasColumnName("USE_NEXT_PERIOD")
                    .HasMaxLength(1);

                entity.Property(e => e.VolumeOfTotal)
                    .HasColumnName("VOLUME_OF_TOTAL")
                    .HasColumnType("numeric(8, 5)");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.MeterOnContract)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MEOC_METER_FK");

                entity.HasOne(d => d.MachineOnContract)
                    .WithMany(p => p.MeterOnContract)
                    .HasForeignKey(d => new { d.ContractObjNo, d.RowNo, d.MachineObjNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MEOC_MAOC_FK");
            });

            modelBuilder.Entity<MeterReading>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.MeterObjNo, e.ReadingDate, e.ReadingType });

                entity.ToTable("METER_READING");

                entity.HasIndex(e => new { e.MachineObjNo, e.MeterObjNo })
                    .HasName("IDX_MR_METER_MACHINE");

                entity.HasIndex(e => new { e.ProjectNo, e.TaskNo })
                    .HasName("IDX_MR_PROJECT");

                entity.HasIndex(e => new { e.MachineObjNo, e.MeterObjNo, e.ReadingDate })
                    .HasName("IDX_MR_METER_MACHINE_DATE");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ReadingDate)
                    .HasColumnName("READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadingType)
                    .HasColumnName("READING_TYPE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Counter)
                    .HasColumnName("COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedSource)
                    .HasColumnName("CREATED_SOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.Estimated)
                    .HasColumnName("ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.Imported)
                    .HasColumnName("IMPORTED")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingLap)
                    .HasColumnName("READING_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReadingYear)
                    .HasColumnName("READING_YEAR")
                    .HasColumnType("numeric(5, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportCounter).HasColumnName("REPORT_COUNTER");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.MeterReading)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SMR_MACHINE_FK");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.MeterReading)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SMR_METER_FK");
            });

            modelBuilder.Entity<MeterReadingEstimated>(entity =>
            {
                entity.HasKey(e => new { e.ContractObjNo, e.RowNo, e.MachineObjNo, e.MeterObjNo, e.InvoiceYear, e.InvoicePeriod });

                entity.ToTable("METER_READING_ESTIMATED");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.InvoiceYear)
                    .HasColumnName("INVOICE_YEAR")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.InvoicePeriod).HasColumnName("INVOICE_PERIOD");

                entity.Property(e => e.Counter)
                    .HasColumnName("COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.CounterCorrected)
                    .HasColumnName("COUNTER_CORRECTED")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.ReadingDate)
                    .HasColumnName("READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadingLap)
                    .HasColumnName("READING_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.MeterReadingEstimated)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MRE_METER_FK");

                entity.HasOne(d => d.MachineOnContract)
                    .WithMany(p => p.MeterReadingEstimated)
                    .HasForeignKey(d => new { d.ContractObjNo, d.RowNo, d.MachineObjNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MRE_MOC_FK");
            });

            modelBuilder.Entity<MeterReadingImport>(entity =>
            {
                entity.HasKey(e => new { e.BatchObjNo, e.LineNo });

                entity.ToTable("METER_READING_IMPORT");

                entity.Property(e => e.BatchObjNo).HasColumnName("BATCH_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("CUSTOMER_NO")
                    .HasMaxLength(200);

                entity.Property(e => e.Estimated)
                    .HasColumnName("ESTIMATED")
                    .HasMaxLength(20);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(200);

                entity.Property(e => e.MeterType)
                    .HasColumnName("METER_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(200);

                entity.Property(e => e.NewReading)
                    .HasColumnName("NEW_READING")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("REPORT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowHidden).HasColumnName("ROW_HIDDEN");

                entity.Property(e => e.StatusComment)
                    .HasColumnName("STATUS_COMMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.StatusContractObjNo).HasColumnName("STATUS_CONTRACT_OBJ_NO");

                entity.Property(e => e.StatusContractRowNo)
                    .HasColumnName("STATUS_CONTRACT_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.StatusImported).HasColumnName("STATUS_IMPORTED");

                entity.Property(e => e.StatusMachineObjNo).HasColumnName("STATUS_MACHINE_OBJ_NO");

                entity.Property(e => e.StatusMeterObjNo).HasColumnName("STATUS_METER_OBJ_NO");

                entity.Property(e => e.StatusObjDate)
                    .HasColumnName("STATUS_OBJ_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MeterReadingLog>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.MeterObjNo, e.ObjDate, e.OldReadingType, e.OldReadingDate });

                entity.ToTable("METER_READING_LOG");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldReadingType)
                    .HasColumnName("OLD_READING_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.OldReadingDate)
                    .HasColumnName("OLD_READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.OldCounter)
                    .HasColumnName("OLD_COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.OldEstimated)
                    .HasColumnName("OLD_ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.OldImported)
                    .HasColumnName("OLD_IMPORTED")
                    .HasMaxLength(1);

                entity.Property(e => e.OldProjectNo)
                    .HasColumnName("OLD_PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OldReadingLap)
                    .HasColumnName("OLD_READING_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.OldReadingYear)
                    .HasColumnName("OLD_READING_YEAR")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.OldTaskNo)
                    .HasColumnName("OLD_TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MeterReadingOldValues>(entity =>
            {
                entity.HasKey(e => new { e.MachineObjNo, e.MeterObjNo, e.ReadingDate, e.ReadingType });

                entity.ToTable("METER_READING_OLD_VALUES");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ReadingDate)
                    .HasColumnName("READING_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadingType)
                    .HasColumnName("READING_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Counter)
                    .HasColumnName("COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedSource)
                    .HasColumnName("CREATED_SOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.Estimated)
                    .HasColumnName("ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.Imported)
                    .HasColumnName("IMPORTED")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReadingLap)
                    .HasColumnName("READING_LAP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReadingYear)
                    .HasColumnName("READING_YEAR")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ReportCounter).HasColumnName("REPORT_COUNTER");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.MeterReadingOldValues)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("METER_READING_OLD_VALUES_MACHINE_FK");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.MeterReadingOldValues)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("METER_READING_OLD_VALUES_METER_FK");
            });

            modelBuilder.Entity<MeterReadingValidation>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.MeterObjNo });

                entity.ToTable("METER_READING_VALIDATION");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Mubv)
                    .HasColumnName("MUBV")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Upm)
                    .HasColumnName("UPM")
                    .HasColumnType("numeric(12, 0)");
            });

            modelBuilder.Entity<MeterTypeConvertTable>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Parameter1, e.Parameter2, e.Parameter3 });

                entity.ToTable("METER_TYPE_CONVERT_TABLE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Parameter1)
                    .HasColumnName("PARAMETER_1")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter2)
                    .HasColumnName("PARAMETER_2")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter3)
                    .HasColumnName("PARAMETER_3")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");
            });

            modelBuilder.Entity<MobileOrderHeading>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("MOBILE_ORDER_HEADING");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.AllPaid)
                    .HasColumnName("ALL_PAID")
                    .HasMaxLength(1);

                entity.Property(e => e.CalculateVat)
                    .HasColumnName("CALCULATE_VAT")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.DeliveryAddress1)
                    .HasColumnName("DELIVERY_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress2)
                    .HasColumnName("DELIVERY_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryName)
                    .HasColumnName("DELIVERY_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryPostalcode)
                    .HasColumnName("DELIVERY_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryPostlocation)
                    .HasColumnName("DELIVERY_POSTLOCATION")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryTerm)
                    .HasColumnName("DELIVERY_TERM")
                    .HasMaxLength(10);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.InterestCalcTo)
                    .HasColumnName("INTEREST_CALC_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceFee)
                    .HasColumnName("INVOICE_FEE")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasColumnName("INVOICE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderNoCredit)
                    .HasColumnName("ORDER_NO_CREDIT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderSource)
                    .HasColumnName("ORDER_SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderTag)
                    .HasColumnName("ORDER_TAG")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.OurReference)
                    .HasColumnName("OUR_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.ReminderNo)
                    .HasColumnName("REMINDER_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<MobileOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.LineNo });

                entity.ToTable("MOBILE_ORDER_LINE");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnName("ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActiveTo)
                    .HasColumnName("ACTIVE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Booking)
                    .HasColumnName("BOOKING")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.FromCounter)
                    .HasColumnName("FROM_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.OrderLineSource)
                    .HasColumnName("ORDER_LINE_SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.QtyNotDelivered)
                    .HasColumnName("QTY_NOT_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.RowType)
                    .HasColumnName("ROW_TYPE")
                    .HasMaxLength(3);

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.ServicesArticleType)
                    .HasColumnName("SERVICES_ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.StockTracking)
                    .HasColumnName("STOCK_TRACKING")
                    .HasMaxLength(1);

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.ToCounter)
                    .HasColumnName("TO_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<MobileSession>(entity =>
            {
                entity.ToTable("MOBILE_SESSION");

                entity.HasIndex(e => e.MobileSessionObjNo)
                    .HasName("IDX_MOBILE_SESSION_OBJ_NO")
                    .IsUnique();

                entity.Property(e => e.MobileSessionId).HasColumnName("MOBILE_SESSION_ID");

                entity.Property(e => e.Cordova)
                    .HasColumnName("CORDOVA")
                    .HasMaxLength(30);

                entity.Property(e => e.EmVersion)
                    .HasColumnName("EM_VERSION")
                    .HasMaxLength(30);

                entity.Property(e => e.EmsVersion)
                    .HasColumnName("EMS_VERSION")
                    .HasMaxLength(30);

                entity.Property(e => e.ExpiresAt)
                    .HasColumnName("EXPIRES_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileSessionObjNo).HasColumnName("MOBILE_SESSION_OBJ_NO");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(300);

                entity.Property(e => e.Platform)
                    .HasColumnName("PLATFORM")
                    .HasMaxLength(30);

                entity.Property(e => e.StartedAt)
                    .HasColumnName("STARTED_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(36);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(30);

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.MobileSession)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MOBILE_SESSION_TECHNICIAN_FK");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("MODEL");

                entity.HasIndex(e => new { e.Company, e.ModelType })
                    .HasName("UQK_MODEL_COMPANY_MODEL_TYPE")
                    .IsUnique();

                entity.HasIndex(e => new { e.ModelType, e.ArticleObjNo })
                    .HasName("IDX_MODEL_ARTICLE");

                entity.HasIndex(e => new { e.ObjNo, e.ModelType })
                    .HasName("IDX_MODE_COMPANY_OBJ_NO_MODEL_TYPE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.IntervalGroupObjNo).HasColumnName("INTERVAL_GROUP_OBJ_NO");

                entity.Property(e => e.LaunchDate)
                    .HasColumnName("LAUNCH_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineSortgroup1)
                    .HasColumnName("MACHINE_SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineSortgroup2)
                    .HasColumnName("MACHINE_SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineSortgroup3)
                    .HasColumnName("MACHINE_SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineSortgroup4)
                    .HasColumnName("MACHINE_SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineSortgroup5)
                    .HasColumnName("MACHINE_SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutOfProd)
                    .HasColumnName("OUT_OF_PROD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServiceInterval)
                    .HasColumnName("SERVICE_INTERVAL")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.TotalMeterObjNo).HasColumnName("TOTAL_METER_OBJ_NO");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.WarrantyCode)
                    .HasColumnName("WARRANTY_CODE")
                    .HasMaxLength(3);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .HasConstraintName("MODEL_ARTICLE_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MODEL_COMPANY_FK");

                entity.HasOne(d => d.SupplierObjNoNavigation)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.SupplierObjNo)
                    .HasConstraintName("MODEL_SUPPLIER_FK");
            });

            modelBuilder.Entity<ModelArticleGroupWarranty>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.SortGroupNo, e.SortGroupText });

                entity.ToTable("MODEL_ARTICLE_GROUP_WARRANTY");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.SortGroupNo)
                    .HasColumnName("SORT_GROUP_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SortGroupText)
                    .HasColumnName("SORT_GROUP_TEXT")
                    .HasMaxLength(10);

                entity.Property(e => e.WarrantyMonths)
                    .HasColumnName("WARRANTY_MONTHS")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.WarrantyMonthsNewMachine)
                    .HasColumnName("WARRANTY_MONTHS_NEW_MACHINE")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.WarrantyUnits)
                    .HasColumnName("WARRANTY_UNITS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.WarrantyUnitsNewMachine)
                    .HasColumnName("WARRANTY_UNITS_NEW_MACHINE")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<ModelDefaultServicesCode>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.Dept });

                entity.ToTable("MODEL_DEFAULT_SERVICES_CODE");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesCode)
                    .HasColumnName("SERVICES_CODE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ModelMeter>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.MeterObjNo });

                entity.ToTable("MODEL_METER");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.FixedPpu)
                    .HasColumnName("FIXED_PPU")
                    .HasColumnType("numeric(11, 10)");

                entity.Property(e => e.MaxCounter)
                    .HasColumnName("MAX_COUNTER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NumberOfCiphers)
                    .HasColumnName("NUMBER_OF_CIPHERS")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ppeu)
                    .HasColumnName("PPEU")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.PpuLevel1)
                    .HasColumnName("PPU_LEVEL_1")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.PpuLevel2)
                    .HasColumnName("PPU_LEVEL_2")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.PpuLevel3)
                    .HasColumnName("PPU_LEVEL_3")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.TargetPpu)
                    .HasColumnName("TARGET_PPU")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.TargetVolume)
                    .HasColumnName("TARGET_VOLUME")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.UseInCalc)
                    .HasColumnName("USE_IN_CALC")
                    .HasMaxLength(1);

                entity.Property(e => e.VirtualFunction)
                    .HasColumnName("VIRTUAL_FUNCTION")
                    .HasMaxLength(250);

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.ModelMeter)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MODEL_METER_METER_FK");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.ModelMeter)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MODEL_METER_MODEL_FK");
            });

            modelBuilder.Entity<ModelMeterPrice>(entity =>
            {
                entity.HasKey(e => new { e.CustomerObjNo, e.ModelObjNo, e.MeterObjNo });

                entity.ToTable("MODEL_METER_PRICE");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PriceType)
                    .IsRequired()
                    .HasColumnName("PRICE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("VALID_FROM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.ModelMeterPrice)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MMP_METER");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.ModelMeterPrice)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MMP_MODEL");
            });

            modelBuilder.Entity<ModelMeterToner>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("MODEL_METER_TONER");

                entity.HasIndex(e => new { e.ModelObjNo, e.MeterObjNo, e.ArticleObjNo })
                    .HasName("IDX_MODEL_METER_TONER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ConsumableName)
                    .HasColumnName("CONSUMABLE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CoveredPercentage)
                    .HasColumnName("COVERED_PERCENTAGE")
                    .HasColumnType("numeric(6, 3)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.UnitsPerToner)
                    .HasColumnName("UNITS_PER_TONER")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<ModelSymptomHelpText>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.SymptomCodeNo, e.SymptomCode });

                entity.ToTable("MODEL_SYMPTOM_HELP_TEXT");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.SymptomCodeNo)
                    .HasColumnName("SYMPTOM_CODE_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SymptomCode)
                    .HasColumnName("SYMPTOM_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.HelpText)
                    .HasColumnName("HELP_TEXT")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<ModelVirtualMeterDependencies>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.VirtualMeterObjNo, e.MeterObjNo });

                entity.ToTable("MODEL_VIRTUAL_METER_DEPENDENCIES");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.VirtualMeterObjNo).HasColumnName("VIRTUAL_METER_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.HasOne(d => d.M)
                    .WithMany(p => p.ModelVirtualMeterDependenciesM)
                    .HasForeignKey(d => new { d.ModelObjNo, d.MeterObjNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MODEL_VIRTUAL_METER_DEPENDENCIES_FK2");

                entity.HasOne(d => d.ModelMeter)
                    .WithMany(p => p.ModelVirtualMeterDependenciesModelMeter)
                    .HasForeignKey(d => new { d.ModelObjNo, d.VirtualMeterObjNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MODEL_VIRTUAL_METER_DEPENDENCIES_FK1");
            });

            modelBuilder.Entity<OrderDefaultArticles>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleType, e.ArticleObjNo });

                entity.ToTable("ORDER_DEFAULT_ARTICLES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleType)
                    .HasColumnName("ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.OrderDefaultArticles)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ODA_ARTICLE_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.OrderDefaultArticles)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ODA_COMPANY_FK");
            });

            modelBuilder.Entity<OrderHeading>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.OrderNo });

                entity.ToTable("ORDER_HEADING");

                entity.HasIndex(e => e.AllPaid)
                    .HasName("IDX_OH_ALL_PAID");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_OH_CUSTOMER_OBJ_NO");

                entity.HasIndex(e => e.Dept)
                    .HasName("IDX_OH_DEPT");

                entity.HasIndex(e => e.DueDate)
                    .HasName("IDX_OH_DUE_DATE");

                entity.HasIndex(e => e.InvoiceDate)
                    .HasName("IDX_OH_INVOICE_DATE");

                entity.HasIndex(e => new { e.Company, e.InvoiceCustomerObjNo })
                    .HasName("IDX_ORDER_HEADING_COMPANY_INVOICE_CUSTOMER");

                entity.HasIndex(e => new { e.Company, e.InvoiceDate })
                    .HasName("IDX_OH_COMPANY_INVOICE_DATE");

                entity.HasIndex(e => new { e.Company, e.InvoiceNoCredit })
                    .HasName("IDX_OH_CREDIT_INVOICE_NO");

                entity.HasIndex(e => new { e.Company, e.OrderNoCredit })
                    .HasName("IDX_OH_CREDIT_NO");

                entity.HasIndex(e => new { e.Company, e.Status })
                    .HasName("IDX_OH_STATUS");

                entity.HasIndex(e => new { e.Company, e.InvoiceDate, e.Dept })
                    .HasName("IDX_OH_COMPANY_DEPT_INVOICE_DATE");

                entity.HasIndex(e => new { e.Company, e.SourceObjNo, e.OrderSource })
                    .HasName("IDX_CI_ORDER_COMPANY_SOURCE_");

                entity.HasIndex(e => new { e.InvoiceAddressRowNo, e.InvoiceCustomerObjNo, e.Company })
                    .HasName("IDX_ORDER_HEADING_INVOICE_ADDRESS");

                entity.HasIndex(e => new { e.OrderNo, e.Company, e.CustomerObjNo })
                    .HasName("IDX_OH_ORDER_NO_COMPANY_CUSTOMER");

                entity.HasIndex(e => new { e.OrderNo, e.CustomerObjNo, e.InvoiceDate, e.Company, e.Status, e.OrderSource })
                    .HasName("IDX_ORDER_HEADING_COMPANY_STATUS_ORDER_SOURCE_WITH_INCLUDE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AllPaid)
                    .HasColumnName("ALL_PAID")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AmalgamateOrders)
                    .HasColumnName("AMALGAMATE_ORDERS")
                    .HasMaxLength(1);

                entity.Property(e => e.Bic)
                    .HasColumnName("BIC")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculateVat)
                    .HasColumnName("CALCULATE_VAT")
                    .HasMaxLength(1);

                entity.Property(e => e.CpuObjNo).HasColumnName("CPU_OBJ_NO");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerReferenceInfo)
                    .HasColumnName("CUSTOMER_REFERENCE_INFO")
                    .HasMaxLength(100);

                entity.Property(e => e.DelCustomerObjNo).HasColumnName("DEL_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DeliveryAddress1)
                    .HasColumnName("DELIVERY_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress2)
                    .HasColumnName("DELIVERY_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress3)
                    .HasColumnName("DELIVERY_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddressId)
                    .HasColumnName("DELIVERY_ADDRESS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DeliveryCountry)
                    .HasColumnName("DELIVERY_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryName)
                    .HasColumnName("DELIVERY_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryPostalcode)
                    .HasColumnName("DELIVERY_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryPostlocation)
                    .HasColumnName("DELIVERY_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryState)
                    .HasColumnName("DELIVERY_STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryTerm)
                    .HasColumnName("DELIVERY_TERM")
                    .HasMaxLength(10);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDebitDate)
                    .HasColumnName("DIRECT_DEBIT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.Information)
                    .HasColumnName("INFORMATION")
                    .HasMaxLength(500);

                entity.Property(e => e.InterestCalcTo)
                    .HasColumnName("INTEREST_CALC_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceAddress1)
                    .HasColumnName("INVOICE_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress2)
                    .HasColumnName("INVOICE_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress3)
                    .HasColumnName("INVOICE_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InvoiceAsEmail)
                    .HasColumnName("INVOICE_AS_EMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceAsEmailAddress)
                    .HasColumnName("INVOICE_AS_EMAIL_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceCountry)
                    .HasColumnName("INVOICE_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceDeptCredit)
                    .HasColumnName("INVOICE_DEPT_CREDIT")
                    .HasMaxLength(6);

                entity.Property(e => e.InvoiceFee)
                    .HasColumnName("INVOICE_FEE")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceName)
                    .HasColumnName("INVOICE_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InvoiceNoCredit)
                    .HasColumnName("INVOICE_NO_CREDIT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InvoicePostalcode)
                    .HasColumnName("INVOICE_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvoicePostlocation)
                    .HasColumnName("INVOICE_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceState)
                    .HasColumnName("INVOICE_STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasColumnName("INVOICE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.MakeXmlFileOfInvoice)
                    .HasColumnName("MAKE_XML_FILE_OF_INVOICE")
                    .HasMaxLength(1);

                entity.Property(e => e.MandateRefNo)
                    .HasColumnName("MANDATE_REF_NO")
                    .HasMaxLength(35);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.NotAllowPartlyDeliver)
                    .HasColumnName("NOT_ALLOW_PARTLY_DELIVER")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ObjectOpen)
                    .HasColumnName("OBJECT_OPEN")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjectOpenedBy)
                    .HasColumnName("OBJECT_OPENED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjectOpenedDate)
                    .HasColumnName("OBJECT_OPENED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNoCredit)
                    .HasColumnName("ORDER_NO_CREDIT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderNoOnAccount)
                    .HasColumnName("ORDER_NO_ON_ACCOUNT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderSource)
                    .HasColumnName("ORDER_SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderTag)
                    .HasColumnName("ORDER_TAG")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.OurReference)
                    .HasColumnName("OUR_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ReminderNo)
                    .HasColumnName("REMINDER_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(2);

                entity.Property(e => e.StatusPayment)
                    .HasColumnName("STATUS_PAYMENT")
                    .HasMaxLength(2);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.OrderHeading)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ORDER_COMPANY_FK");

                entity.HasOne(d => d.CreditTermNavigation)
                    .WithMany(p => p.OrderHeading)
                    .HasForeignKey(d => d.CreditTerm)
                    .HasConstraintName("ORDER_CREDIT_TERMS_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.OrderHeading)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ORDER_CUSTOMER_FK");

                entity.HasOne(d => d.SalesmanObjNoNavigation)
                    .WithMany(p => p.OrderHeading)
                    .HasForeignKey(d => d.SalesmanObjNo)
                    .HasConstraintName("ORDER_SALESMAN_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.OrderHeading)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ORDER_DEPT_FK");
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.OrderNo, e.LineNo });

                entity.ToTable("ORDER_LINE");

                entity.HasIndex(e => e.ArticleObjNo)
                    .HasName("IDX_ORDER_LINE_ARTICLE_OBJ_NO");

                entity.HasIndex(e => e.CpuObjNo)
                    .HasName("IDX_ORDER_LINE_CPU_OBJ_NO");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_ORDER_LINE_MACHINE_OBJ_NO");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_ORDER_LINE_OBJ_NO");

                entity.HasIndex(e => e.SourceObjNo)
                    .HasName("IDX_ORDER_LINE_SOURCE_OBJ_NO");

                entity.HasIndex(e => new { e.ArticleObjNo, e.StockObjNo })
                    .HasName("IDX_ORDER_LINE_ARTICLE_STOCK");

                entity.HasIndex(e => new { e.Company, e.OrderNo })
                    .HasName("IDXL_OL_COMPANY_ORDER_NO");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.ExternalId })
                    .HasName("ORDER_LINE_EXTERNAL");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.ActiveFrom, e.SourceObjNo })
                    .HasName("IDX_ORDER_LINE_TECH_WORK");

                entity.HasIndex(e => new { e.ArticleObjNo, e.QtyDelivered, e.Company, e.CpuObjNo })
                    .HasName("IDX_CPU_CHECK");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.Invoiceable, e.ArticleObjNo, e.MachineObjNo, e.LineNo, e.QtyDelivered })
                    .HasName("IDX_ORDER_LINE_COMPANY_ORDER_INV_ARTICLE_MACHINE_LINE_QTY");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.Invoiceable, e.LineNo, e.MachineObjNo, e.ArticleObjNo, e.QtyDelivered })
                    .HasName("IDX_ORDER_LINE_ORDER_INV_LINE_MACHINE_ARTICLE_QTY");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.ArticleObjNo, e.ActiveFrom, e.Company, e.OrderNo, e.SourceObjNo, e.ActiveTo, e.ExternalId })
                    .HasName("IDX_ORDER_LINE_MANY4");

                entity.HasIndex(e => new { e.ArticleObjNo, e.ActiveFrom, e.TechnicianObjNo, e.SourceObjNo, e.OrderNo, e.Company, e.ActiveTo, e.ExternalId, e.LineNo })
                    .HasName("IDX_ORDER_LINE_MANY2");

                entity.HasIndex(e => new { e.Company, e.MachineObjNo, e.OrderNo, e.Invoiceable, e.ArticleObjNo, e.QtyDelivered, e.CostPrice, e.ActiveFrom, e.ActiveTo })
                    .HasName("IDX_OL_ORDER_COST");

                entity.HasIndex(e => new { e.SourceObjNo, e.TechnicianObjNo, e.ActiveFrom, e.ArticleObjNo, e.OrderNo, e.Company, e.ActiveTo, e.ExternalId, e.LineNo })
                    .HasName("IDX_ORDER_LINE_MANY3");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.ActiveFrom, e.Company, e.ArticleObjNo, e.SourceObjNo, e.OrderNo, e.ActiveTo, e.ExternalId, e.LineNo })
                    .HasName("IDX_ORDER_LINE_MANY1");

                entity.HasIndex(e => new { e.LineNo, e.CostPrice, e.SalesPrice, e.Discount, e.QtyDelivered, e.ActiveFrom, e.ActiveTo, e.Company, e.OrderNo, e.ArticleObjNo, e.MachineObjNo, e.Invoiceable })
                    .HasName("IDX_ORDER_LINE_ARTICLE_MACHINE_INV_WITH_INCLUDE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnName("ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActiveTo)
                    .HasColumnName("ACTIVE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AggregateArticleType)
                    .HasColumnName("AGGREGATE_ARTICLE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleModelLocationObjNo).HasColumnName("ARTICLE_MODEL_LOCATION_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ArticleSerialNo)
                    .HasColumnName("ARTICLE_SERIAL_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticleWeight)
                    .HasColumnName("ARTICLE_WEIGHT")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.Booking)
                    .HasColumnName("BOOKING")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CpuObjNo).HasColumnName("CPU_OBJ_NO");

                entity.Property(e => e.DelAddress1)
                    .HasColumnName("DEL_ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress2)
                    .HasColumnName("DEL_ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress3)
                    .HasColumnName("DEL_ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddressName)
                    .HasColumnName("DEL_ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DelContactName)
                    .HasColumnName("DEL_CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.DelCountryNo)
                    .HasColumnName("DEL_COUNTRY_NO")
                    .HasMaxLength(5);

                entity.Property(e => e.DelCustomerObjNo).HasColumnName("DEL_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DelPostalCode)
                    .HasColumnName("DEL_POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DelPostalDescription)
                    .HasColumnName("DEL_POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.DelState)
                    .HasColumnName("DEL_STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.EcoFeeLevel)
                    .HasColumnName("ECO_FEE_LEVEL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.EcoTaxCalculate)
                    .HasColumnName("ECO_TAX_CALCULATE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromCounter)
                    .HasColumnName("FROM_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.HideLine)
                    .HasColumnName("HIDE_LINE")
                    .HasMaxLength(1);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(250);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MasterLineObjNo).HasColumnName("MASTER_LINE_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OnAccountOrderNo)
                    .HasColumnName("ON_ACCOUNT_ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderLineSource)
                    .HasColumnName("ORDER_LINE_SOURCE")
                    .HasMaxLength(1);

                entity.Property(e => e.QtyActDelivered)
                    .HasColumnName("QTY_ACT_DELIVERED")
                    .HasColumnType("numeric(11, 5)");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.QtyNotDelivered)
                    .HasColumnName("QTY_NOT_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.RmaNo)
                    .HasColumnName("RMA_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RowType)
                    .HasColumnName("ROW_TYPE")
                    .HasMaxLength(3);

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.SerialNoNew)
                    .HasColumnName("SERIAL_NO_NEW")
                    .HasMaxLength(30);

                entity.Property(e => e.SerialNoOld)
                    .HasColumnName("SERIAL_NO_OLD")
                    .HasMaxLength(30);

                entity.Property(e => e.ServicesArticleType)
                    .HasColumnName("SERVICES_ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.StockAdminQtyReceived)
                    .HasColumnName("STOCK_ADMIN_QTY_RECEIVED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.StockTracking)
                    .HasColumnName("STOCK_TRACKING")
                    .HasMaxLength(1);

                entity.Property(e => e.SummarizeRowInfo)
                    .HasColumnName("SUMMARIZE_ROW_INFO")
                    .HasMaxLength(10);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.ToCounter)
                    .HasColumnName("TO_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.WarrantyAccepted).HasColumnName("WARRANTY_ACCEPTED");

                entity.Property(e => e.WarrantyComment)
                    .HasColumnName("WARRANTY_COMMENT")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyCommentIn)
                    .HasColumnName("WARRANTY_COMMENT_IN")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyCommentInternal)
                    .HasColumnName("WARRANTY_COMMENT_INTERNAL")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyCommentOut)
                    .HasColumnName("WARRANTY_COMMENT_OUT")
                    .HasMaxLength(255);

                entity.Property(e => e.WarrantyComplete)
                    .HasColumnName("WARRANTY_COMPLETE")
                    .HasMaxLength(1);

                entity.Property(e => e.WarrantyPartReceived)
                    .HasColumnName("WARRANTY_PART_RECEIVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyPartSent)
                    .HasColumnName("WARRANTY_PART_SENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyStatus)
                    .HasColumnName("WARRANTY_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.Warrenty)
                    .HasColumnName("WARRENTY")
                    .HasMaxLength(1);

                entity.Property(e => e.WorkHourListComment)
                    .HasColumnName("WORK_HOUR_LIST_COMMENT")
                    .HasMaxLength(1024);

                entity.Property(e => e.WorkHourListObjDate)
                    .HasColumnName("WORK_HOUR_LIST_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkHourListQty)
                    .HasColumnName("WORK_HOUR_LIST_QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.WorkHourListStatus)
                    .HasColumnName("WORK_HOUR_LIST_STATUS")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkHourListUsername)
                    .HasColumnName("WORK_HOUR_LIST_USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .HasConstraintName("ORDER_LINE_ARTICLE_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.MachineObjNo)
                    .HasConstraintName("OL_MACHINE_FK");

                entity.HasOne(d => d.OrderHeading)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => new { d.Company, d.OrderNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OL_ORDER_HEADING_FK");
            });

            modelBuilder.Entity<OrderLineArticleSerialNumber>(entity =>
            {
                entity.HasKey(e => new { e.OrderLineObjNo, e.SerialNo });

                entity.ToTable("ORDER_LINE_ARTICLE_SERIAL_NUMBER");

                entity.HasIndex(e => e.OrderLineObjNo)
                    .HasName("IDX_OLAS_LINE");

                entity.Property(e => e.OrderLineObjNo).HasColumnName("ORDER_LINE_OBJ_NO");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceDept)
                    .HasColumnName("INVOICE_DEPT")
                    .HasMaxLength(6);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MachineCreatedOrChanged)
                    .HasColumnName("MACHINE_CREATED_OR_CHANGED")
                    .HasMaxLength(1);

                entity.Property(e => e.PackingSlipMachineObjNo).HasColumnName("PACKING_SLIP_MACHINE_OBJ_NO");

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtyActDelivered)
                    .HasColumnName("QTY_ACT_DELIVERED")
                    .HasColumnType("numeric(25, 10)");
            });

            modelBuilder.Entity<OrderLineInvoice>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.InvoiceNo, e.Dept, e.OrderNo, e.LineNo });

                entity.ToTable("ORDER_LINE_INVOICE");

                entity.HasIndex(e => new { e.Company, e.OrderNo })
                    .HasName("IDX_ORDER_LINE_INVOICE_ORDER_NO");

                entity.HasIndex(e => new { e.Company, e.InvoiceNo, e.Dept })
                    .HasName("IDX_ORDER_LINE_INVOICE_INVOICE_NO");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.LineNo })
                    .HasName("IDX_ORDER_LINE_INVOICE_ORDER_LINE_QTY");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.QtyInvoiced)
                    .HasColumnName("QTY_INVOICED")
                    .HasColumnType("numeric(11, 5)");

                entity.HasOne(d => d.OrderHeading)
                    .WithMany(p => p.OrderLineInvoice)
                    .HasForeignKey(d => new { d.Company, d.OrderNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ORDER_LINE_INVOICE_FK");

                entity.HasOne(d => d.InvoiceHeading)
                    .WithMany(p => p.OrderLineInvoice)
                    .HasForeignKey(d => new { d.Company, d.InvoiceNo, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVOICE_HEADING_FK");
            });

            modelBuilder.Entity<OrderLineMachine>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.OrderNo, e.LineNo, e.MachineObjNo });

                entity.ToTable("ORDER_LINE_MACHINE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.OrderLineMachine)
                    .HasForeignKey(d => new { d.Company, d.OrderNo, d.LineNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OLM_OL_FK");
            });

            modelBuilder.Entity<OrderLinePackingSlip>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.PackingSlipNo, e.LineNo });

                entity.ToTable("ORDER_LINE_PACKING_SLIP");

                entity.HasIndex(e => new { e.Company, e.PackingSlipNo })
                    .HasName("IDX_PACKING_SLIP_NUMBER");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.LineNo })
                    .HasName("IDX_PACKING_SLIP_ORDER_LINE");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.LineNo, e.QtyDelivered })
                    .HasName("PK_ORDER_LINE_PS_QTY");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCreatedOrChanged)
                    .HasColumnName("MACHINE_CREATED_OR_CHANGED")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PackingSlipMachineObjNo).HasColumnName("PACKING_SLIP_MACHINE_OBJ_NO");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("numeric(11, 5)");
            });

            modelBuilder.Entity<OrderLinePartCreditChanges>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("ORDER_LINE_PART_CREDIT_CHANGES");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NewInvoiceDate)
                    .HasColumnName("NEW_INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PreviewType)
                    .IsRequired()
                    .HasColumnName("PREVIEW_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");
            });

            modelBuilder.Entity<OrderLineWorkHourListStatus>(entity =>
            {
                entity.HasKey(e => new { e.OrderLineObjNo, e.WorkHourListObjDate });

                entity.ToTable("ORDER_LINE_WORK_HOUR_LIST_STATUS");

                entity.HasIndex(e => e.OrderLineObjNo)
                    .HasName("IDX_ORDER_LINE_WORK_HOUR_LIST_STATUS_ORDER_LINE_OBJ_NO");

                entity.Property(e => e.OrderLineObjNo).HasColumnName("ORDER_LINE_OBJ_NO");

                entity.Property(e => e.WorkHourListObjDate)
                    .HasColumnName("WORK_HOUR_LIST_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkHourListComment)
                    .HasColumnName("WORK_HOUR_LIST_COMMENT")
                    .HasMaxLength(1024);

                entity.Property(e => e.WorkHourListQty)
                    .HasColumnName("WORK_HOUR_LIST_QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.WorkHourListStatus)
                    .HasColumnName("WORK_HOUR_LIST_STATUS")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkHourListUsername)
                    .HasColumnName("WORK_HOUR_LIST_USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<OrderNo>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.OrderNo1 });

                entity.ToTable("ORDER_NO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo1)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<OrderSupportMateriel>(entity =>
            {
                entity.HasKey(e => new { e.TypeOfOrder, e.LevelSum });

                entity.ToTable("ORDER_SUPPORT_MATERIEL");

                entity.Property(e => e.TypeOfOrder)
                    .HasColumnName("TYPE_OF_ORDER")
                    .HasMaxLength(1);

                entity.Property(e => e.LevelSum)
                    .HasColumnName("LEVEL_SUM")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.LevelPrc)
                    .HasColumnName("LEVEL_PRC")
                    .HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code });

                entity.ToTable("ORDER_TYPE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.CreditCode)
                    .HasColumnName("CREDIT_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DebetCode)
                    .HasColumnName("DEBET_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PackingSlipHeading>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.PackingSlipNo });

                entity.ToTable("PACKING_SLIP_HEADING");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerReferenceInfo)
                    .HasColumnName("CUSTOMER_REFERENCE_INFO")
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryAddress1)
                    .HasColumnName("DELIVERY_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress2)
                    .HasColumnName("DELIVERY_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryAddress3)
                    .HasColumnName("DELIVERY_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryContactName)
                    .HasColumnName("DELIVERY_CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.DeliveryCountry)
                    .HasColumnName("DELIVERY_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.DeliveryCustomerName)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName2)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName3)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerName4)
                    .HasColumnName("DELIVERY_CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryCustomerObjNo).HasColumnName("DELIVERY_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DeliveryName)
                    .HasColumnName("DELIVERY_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryPostalcode)
                    .HasColumnName("DELIVERY_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryPostlocation)
                    .HasColumnName("DELIVERY_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryState)
                    .HasColumnName("DELIVERY_STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress1)
                    .HasColumnName("INVOICE_ADDRESS1")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress2)
                    .HasColumnName("INVOICE_ADDRESS2")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceAddress3)
                    .HasColumnName("INVOICE_ADDRESS3")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCountry)
                    .HasColumnName("INVOICE_COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.InvoiceCustomerName)
                    .HasColumnName("INVOICE_CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName2)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_2")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName3)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_3")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerName4)
                    .HasColumnName("INVOICE_CUSTOMER_NAME_4")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceCustomerObjNo).HasColumnName("INVOICE_CUSTOMER_OBJ_NO");

                entity.Property(e => e.InvoiceName)
                    .HasColumnName("INVOICE_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoicePostalcode)
                    .HasColumnName("INVOICE_POSTALCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvoicePostlocation)
                    .HasColumnName("INVOICE_POSTLOCATION")
                    .HasMaxLength(60);

                entity.Property(e => e.InvoiceState)
                    .HasColumnName("INVOICE_STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.OurReference)
                    .HasColumnName("OUR_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.PackingSlipStatus)
                    .HasColumnName("PACKING_SLIP_STATUS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PackingSlipStatusDate)
                    .HasColumnName("PACKING_SLIP_STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackingSlipStatusUser)
                    .HasColumnName("PACKING_SLIP_STATUS_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.TrackingNumber)
                    .HasColumnName("TRACKING_NUMBER")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PostalCode>(entity =>
            {
                entity.HasKey(e => new { e.PostalCode1, e.Description, e.Country });

                entity.ToTable("POSTAL_CODE");

                entity.Property(e => e.PostalCode1)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.PostalCode)
                    .HasForeignKey(d => d.Country)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("POSTAL_CODE_COUNTRY_FK");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.ValidFrom, e.PriceType });

                entity.ToTable("PRICE");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("VALID_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.PriceType)
                    .HasColumnName("PRICE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ActivePrice)
                    .HasColumnName("ACTIVE_PRICE")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(25, 10)");
            });

            modelBuilder.Entity<PriceChangeLog>(entity =>
            {
                entity.HasKey(e => new { e.BatchObjNo, e.LineNo });

                entity.ToTable("PRICE_CHANGE_LOG");

                entity.Property(e => e.BatchObjNo).HasColumnName("BATCH_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(400);

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(400);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("CUSTOMER_NO")
                    .HasMaxLength(400);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(400);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(400);

                entity.Property(e => e.NewPrice)
                    .HasColumnName("NEW_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.NewPriceDate)
                    .HasColumnName("NEW_PRICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldPrice)
                    .HasColumnName("OLD_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OldPriceDate)
                    .HasColumnName("OLD_PRICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceChangeType)
                    .IsRequired()
                    .HasColumnName("PRICE_CHANGE_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.PriceSourceObjNo).HasColumnName("PRICE_SOURCE_OBJ_NO");

                entity.Property(e => e.PriceType)
                    .HasColumnName("PRICE_TYPE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PriceChangeProjectAutoLog>(entity =>
            {
                entity.HasKey(e => new { e.BatchObjNo, e.LineNo });

                entity.ToTable("PRICE_CHANGE_PROJECT_AUTO_LOG");

                entity.HasIndex(e => new { e.ProjectNo, e.TaskNo, e.PriceChangeType, e.ObjDate })
                    .HasName("IDX_PRICE_CHANGE_PROJECT_AUTO_LOG_LAST_UPDATE");

                entity.Property(e => e.BatchObjNo).HasColumnName("BATCH_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(400);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("CUSTOMER_NO")
                    .HasMaxLength(400);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(400);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(400);

                entity.Property(e => e.NewCostPrice)
                    .HasColumnName("NEW_COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.NewPrice)
                    .HasColumnName("NEW_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldCostPrice)
                    .HasColumnName("OLD_COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OldPrice)
                    .HasColumnName("OLD_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceChangeType)
                    .IsRequired()
                    .HasColumnName("PRICE_CHANGE_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<PriceLevel>(entity =>
            {
                entity.HasKey(e => e.IdNum);

                entity.ToTable("PRICE_LEVEL");

                entity.HasIndex(e => new { e.SourceObjNo, e.LevelNum, e.ValidFrom })
                    .HasName("IDX_PRICE_LEVEL_UNIQUE_KEY")
                    .IsUnique();

                entity.HasIndex(e => new { e.ValidFrom, e.SourceObjNo, e.LevelNum })
                    .HasName("IDX_PRICE_LEVEL");

                entity.Property(e => e.IdNum).HasColumnName("ID_NUM");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LevelFromValue)
                    .HasColumnName("LEVEL_FROM_VALUE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.LevelNum)
                    .HasColumnName("LEVEL_NUM")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("VALID_FROM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PrintLanguage>(entity =>
            {
                entity.HasKey(e => e.ReportLanguage);

                entity.ToTable("PRINT_LANGUAGE");

                entity.Property(e => e.ReportLanguage)
                    .HasColumnName("REPORT_LANGUAGE")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasMaxLength(1);

                entity.Property(e => e.LangDesc)
                    .IsRequired()
                    .HasColumnName("LANG_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.Standard)
                    .IsRequired()
                    .HasColumnName("STANDARD")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<PrintLayout>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("PRINT_LAYOUT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateChanged)
                    .HasColumnName("DATE_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnName("FILE_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("REPORT_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");
            });

            modelBuilder.Entity<PriorityCode>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.PriorityCode1 });

                entity.ToTable("PRIORITY_CODE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PriorityCode1)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Pri)
                    .HasColumnName("PRI")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PriorityText)
                    .HasColumnName("PRIORITY_TEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(6, 2)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PriorityCode)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PRIORITY_CODE_DEPT_FK");
            });

            modelBuilder.Entity<PriorityCodeSupport>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.PriorityCode });

                entity.ToTable("PRIORITY_CODE_SUPPORT");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Pri)
                    .HasColumnName("PRI")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PriorityText)
                    .HasColumnName("PRIORITY_TEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(6, 2)");
            });

            modelBuilder.Entity<Problem>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProblemNo });

                entity.ToTable("PROBLEM");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProblemNo)
                    .HasColumnName("PROBLEM_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ActionCode1)
                    .HasColumnName("ACTION_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode2)
                    .HasColumnName("ACTION_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode3)
                    .HasColumnName("ACTION_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode4)
                    .HasColumnName("ACTION_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.AnalysisLog).HasColumnName("ANALYSIS_LOG");

                entity.Property(e => e.AnalysisStatus).HasColumnName("ANALYSIS_STATUS");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpectedEndDate)
                    .HasColumnName("EXPECTED_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstallationDateFrom)
                    .HasColumnName("INSTALLATION_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstallationDateTo)
                    .HasColumnName("INSTALLATION_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineNoFrom)
                    .HasColumnName("MACHINE_NO_FROM")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineNoTo)
                    .HasColumnName("MACHINE_NO_TO")
                    .HasMaxLength(30);

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ProblemCreated)
                    .HasColumnName("PROBLEM_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProblemDescription)
                    .HasColumnName("PROBLEM_DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.ProblemManager)
                    .IsRequired()
                    .HasColumnName("PROBLEM_MANAGER")
                    .HasMaxLength(100);

                entity.Property(e => e.ProblemName)
                    .IsRequired()
                    .HasColumnName("PROBLEM_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ProblemReported)
                    .HasColumnName("PROBLEM_REPORTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProblemStatus).HasColumnName("PROBLEM_STATUS");

                entity.Property(e => e.ProblemType).HasColumnName("PROBLEM_TYPE");

                entity.Property(e => e.ProblemUrl)
                    .HasColumnName("PROBLEM_URL")
                    .HasMaxLength(200);

                entity.Property(e => e.ShowMachines).HasColumnName("SHOW_MACHINES");

                entity.Property(e => e.ShowTasks).HasColumnName("SHOW_TASKS");

                entity.Property(e => e.SolutionCustomerDesc).HasColumnName("SOLUTION_CUSTOMER_DESC");

                entity.Property(e => e.SolutionInternalDesc).HasColumnName("SOLUTION_INTERNAL_DESC");

                entity.Property(e => e.SolutionStatus).HasColumnName("SOLUTION_STATUS");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode4)
                    .HasColumnName("SYMPTOM_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("TASK_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.WorkaroundCustomerDesc).HasColumnName("WORKAROUND_CUSTOMER_DESC");

                entity.Property(e => e.WorkaroundInernalDesc).HasColumnName("WORKAROUND_INERNAL_DESC");

                entity.Property(e => e.WorkaroundLog).HasColumnName("WORKAROUND_LOG");

                entity.Property(e => e.WorkaroundStatus).HasColumnName("WORKAROUND_STATUS");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.Problem)
                    .HasForeignKey(d => d.ModelObjNo)
                    .HasConstraintName("PROBLEM_MODEL_FK");
            });

            modelBuilder.Entity<ProblemMachine>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProblemNo, e.MachineObjNo });

                entity.ToTable("PROBLEM_MACHINE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProblemNo)
                    .HasColumnName("PROBLEM_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MachineStatus)
                    .HasColumnName("MACHINE_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.MailDefault).HasColumnName("MAIL_DEFAULT");

                entity.Property(e => e.MailSolution).HasColumnName("MAIL_SOLUTION");

                entity.Property(e => e.MailWorkaround).HasColumnName("MAIL_WORKAROUND");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.ProblemMachine)
                    .HasForeignKey(d => d.MachineObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROBLEM_MACHINE_MACHINE_FK");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.ProblemMachine)
                    .HasForeignKey(d => new { d.Company, d.ProblemNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROBLEM_MACHINE_PROBLEM_FK");
            });

            modelBuilder.Entity<ProblemTask>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProblemNo, e.ProjectNo, e.TaskNo });

                entity.ToTable("PROBLEM_TASK");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProblemNo)
                    .HasColumnName("PROBLEM_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.IncidentStatus)
                    .HasColumnName("INCIDENT_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.InternalText)
                    .HasColumnName("INTERNAL_TEXT")
                    .HasMaxLength(2000);

                entity.Property(e => e.MailDefault).HasColumnName("MAIL_DEFAULT");

                entity.Property(e => e.MailSolution).HasColumnName("MAIL_SOLUTION");

                entity.Property(e => e.MailWorkaround).HasColumnName("MAIL_WORKAROUND");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.ProblemTask)
                    .HasForeignKey(d => new { d.Company, d.ProblemNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROBLEM_TASK_PROBLEM_FK");

                entity.HasOne(d => d.ProjectTask)
                    .WithMany(p => p.ProblemTask)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROBLEM_TASK_PROJECT_FK");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectNo);

                entity.ToTable("PROJECT");

                entity.HasIndex(e => e.Company)
                    .HasName("IDX_P_COMPANY");

                entity.HasIndex(e => e.Dept)
                    .HasName("IDX_P_DEPT");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_P_OBJ_NO");

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_P_STATUS");

                entity.HasIndex(e => new { e.ProjectNo, e.Company })
                    .HasName("IDX_PROJECT_COMPANY_PROJECT_NO");

                entity.HasIndex(e => new { e.Status, e.ProjectNo })
                    .HasName("IDX_PROJECT_STATUS_PROJECT_NO");

                entity.HasIndex(e => new { e.Company, e.Dept, e.Status })
                    .HasName("IDX_PROJECT_COMPANY_DEPT_STATUS");

                entity.HasIndex(e => new { e.ProjectNo, e.Dept, e.Company })
                    .HasName("IDX_PROJECT_PROJECT_NO_DEPT_COMPANY");

                entity.HasIndex(e => new { e.Status, e.Company, e.ProjectNo, e.Dept, e.Contact, e.ContactEmail })
                    .HasName("IDX_PROJECT_STATUS_COMPANY_MORE");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("CONTACT_EMAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerReferenceInfo)
                    .HasColumnName("CUSTOMER_REFERENCE_INFO")
                    .HasMaxLength(100);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ObjectOpen)
                    .HasColumnName("OBJECT_OPEN")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjectOpenedBy)
                    .HasColumnName("OBJECT_OPENED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjectOpenedDate)
                    .HasColumnName("OBJECT_OPENED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.AreaObjNo)
                    .HasConstraintName("PROJECT_AREA_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_COMPANY_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("PROJECT_CUSTOMER_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_DEPT_FK");
            });

            modelBuilder.Entity<ProjectActivity>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.ActivityId });

                entity.ToTable("PROJECT_ACTIVITY");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ActivityDesc)
                    .HasColumnName("ACTIVITY_DESC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectAuto>(entity =>
            {
                entity.HasKey(e => e.ProjectNo);

                entity.ToTable("PROJECT_AUTO");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("CONTACT_EMAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerReferenceInfo)
                    .HasColumnName("CUSTOMER_REFERENCE_INFO")
                    .HasMaxLength(100);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ObjectOpen)
                    .HasColumnName("OBJECT_OPEN")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjectOpenedBy)
                    .HasColumnName("OBJECT_OPENED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.ObjectOpenedDate)
                    .HasColumnName("OBJECT_OPENED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.ProjectAuto)
                    .HasForeignKey(d => d.AreaObjNo)
                    .HasConstraintName("PROJECT_AREA_AUTO_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.ProjectAuto)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_AUTO_COMPANY_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ProjectAuto)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("PROJECT_AUTO_CUSTOMER_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ProjectAuto)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_AUTO_DEPT_FK");
            });

            modelBuilder.Entity<ProjectAutoActivity>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.ActivityId });

                entity.ToTable("PROJECT_AUTO_ACTIVITY");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ActivityDesc)
                    .HasColumnName("ACTIVITY_DESC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectAutoTask>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("PROJECT_AUTO_TASK");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.DaysBeetween)
                    .HasColumnName("DAYS_BEETWEEN")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastCheck)
                    .HasColumnName("LAST_CHECK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTask)
                    .HasColumnName("LAST_TASK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTaskObjNo).HasColumnName("LAST_TASK_OBJ_NO");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(890)
                    .IsUnicode(false);

                entity.Property(e => e.NumDaysAhead)
                    .HasColumnName("NUM_DAYS_AHEAD")
                    .HasColumnType("numeric(5, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.PlannedDuration)
                    .HasColumnName("PLANNED_DURATION")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PlannedHourOfDay)
                    .HasColumnName("PLANNED_HOUR_OF_DAY")
                    .HasMaxLength(5);

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomText)
                    .HasColumnName("SYMPTOM_TEXT")
                    .HasMaxLength(500);

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ProjectAutoTask)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("PROJECT_AUTO_TASK_CUSTOMER_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.ProjectAutoTask)
                    .HasForeignKey(d => d.MachineObjNo)
                    .HasConstraintName("PROJECT_AUTO_TASK_MACHINE_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ProjectAutoTask)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .HasConstraintName("PROJECT_AUTO_TASK_DEPT_FK");
            });

            modelBuilder.Entity<ProjectPreorder>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("PROJECT_PREORDER");

                entity.HasIndex(e => e.TaskObjNo)
                    .HasName("IDX_PRE_ORDER_TASK");

                entity.HasIndex(e => new { e.TaskObjNo, e.ArticleObjNo, e.DefaultStockObjNo })
                    .HasName("IDX_PRE_ORDER_OTHER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AggregateArticleType)
                    .HasColumnName("AGGREGATE_ARTICLE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleDescription)
                    .HasColumnName("ARTICLE_DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.DefaultStockObjNo).HasColumnName("DEFAULT_STOCK_OBJ_NO");

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.SyncedStatus)
                    .HasColumnName("SYNCED_STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaskObjNo).HasColumnName("TASK_OBJ_NO");
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.TaskNo });

                entity.ToTable("PROJECT_TASK");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_PT_CUSTOMER_OBJ_NO");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_PT_MACHINE_OBJ_NO");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_PT_OBJ_NO");

                entity.HasIndex(e => e.ReceivedDate)
                    .HasName("IDX_PT_RECEIVED_DATE");

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_PT_STATUS");

                entity.HasIndex(e => new { e.DateResponse, e.SourceObjNo })
                    .HasName("IDX_PT_SOURCE_OBJ_NO_INCLUDE");

                entity.HasIndex(e => new { e.ReceivedDate, e.ReceivedBy })
                    .HasName("IDX_PT_RECEIVED_DATE_AND_BY");

                entity.HasIndex(e => new { e.Status, e.Type })
                    .HasName("IDX_PROJECT_TASK_STATUS_TYPE");

                entity.HasIndex(e => new { e.OnHold, e.Status, e.Type })
                    .HasName("IDX_PROJECT_TASK_ON_HOLD_STATUS_TYPE");

                entity.HasIndex(e => new { e.Status, e.DateResponse, e.TimeEstimate })
                    .HasName("IDX_PROJECT_TASK_STATUS_AND_PLANNED");

                entity.HasIndex(e => new { e.Status, e.TimeEstimate, e.DateResponse })
                    .HasName("IDX_PROJECT_TASK_STATUS_TIME_ESTIMATE");

                entity.HasIndex(e => new { e.Status, e.Type, e.Node, e.ProjectNo })
                    .HasName("IDX_PROJECT_TASK_STATUS_TYPE_NODE_PROJECT_NO");

                entity.HasIndex(e => new { e.MachineObjNo, e.CustomerObjNo, e.ProjectNo, e.TaskNo, e.ReceivedDate })
                    .HasName("IDX_PROJECT_TASK_PROJECT_TASK_RECEIVED_DATE_INCLUDE");

                entity.HasIndex(e => new { e.CustomerObjNo, e.MachineObjNo, e.Status, e.ProjectNo, e.TaskNo, e.ReceivedDate })
                    .HasName("IDX_PT_CUSTOMER_MACHINE_STATUS_RECEIVED");

                entity.HasIndex(e => new { e.ObjNo, e.Status, e.CustomerObjNo, e.TaskNo, e.ProjectNo, e.PriorityCode, e.DateResponse, e.TimeEstimate })
                    .HasName("IDX_PROJECT_TASK_MANY");

                entity.HasIndex(e => new { e.ReceivedDate, e.Status, e.CustomerObjNo, e.MachineObjNo, e.ActionCode3, e.ActionCode2, e.ActionCode1, e.SymptomCode3, e.SymptomCode2, e.SymptomCode1 })
                    .HasName("IDX_PT_CUSTOMER_MACHINE_ACTION_SYMPTOM");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ActionCode1)
                    .HasColumnName("ACTION_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode2)
                    .HasColumnName("ACTION_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode3)
                    .HasColumnName("ACTION_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode4)
                    .HasColumnName("ACTION_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionText).HasColumnName("ACTION_TEXT");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AddressName)
                    .HasColumnName("ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.AddressPhoneNo)
                    .HasColumnName("ADDRESS_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.CheckedInDate)
                    .HasColumnName("CHECKED_IN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckedOut)
                    .HasColumnName("CHECKED_OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.CheckedOutBy)
                    .HasColumnName("CHECKED_OUT_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.CheckedOutDate)
                    .HasColumnName("CHECKED_OUT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosureCode)
                    .HasColumnName("CLOSURE_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorCode)
                    .HasColumnName("COLOR_CODE")
                    .HasMaxLength(5);

                entity.Property(e => e.CommentInternal).HasColumnName("COMMENT_INTERNAL");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("CONTACT_EMAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CoordX)
                    .HasColumnName("COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CoordY)
                    .HasColumnName("COORD_Y")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CpuObjNo).HasColumnName("CPU_OBJ_NO");

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.CustomerSatisfaction).HasColumnName("CUSTOMER_SATISFACTION");

                entity.Property(e => e.CustomerSignatureName)
                    .HasColumnName("CUSTOMER_SIGNATURE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DateReported)
                    .HasColumnName("DATE_REPORTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateResponse)
                    .HasColumnName("DATE_RESPONSE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalProjectNo)
                    .HasColumnName("EXTERNAL_PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ExternalReplyMailAddress)
                    .HasColumnName("EXTERNAL_REPLY_MAIL_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalStatus)
                    .HasColumnName("EXTERNAL_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.ExternalSystemObjNo).HasColumnName("EXTERNAL_SYSTEM_OBJ_NO");

                entity.Property(e => e.ExternalTaskNo)
                    .HasColumnName("EXTERNAL_TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.FixedPrice)
                    .HasColumnName("FIXED_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.IncidentStatus)
                    .HasColumnName("INCIDENT_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OnHold)
                    .HasColumnName("ON_HOLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderInformation)
                    .HasColumnName("ORDER_INFORMATION")
                    .HasMaxLength(500);

                entity.Property(e => e.OrgNode)
                    .HasColumnName("ORG_NODE")
                    .HasMaxLength(890);

                entity.Property(e => e.OrgPriorityCode)
                    .HasColumnName("ORG_PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectTaskStatus)
                    .HasColumnName("PROJECT_TASK_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.ReceivedBy)
                    .HasColumnName("RECEIVED_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("RECEIVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResourcePriority)
                    .HasColumnName("RESOURCE_PRIORITY")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.RespCustomerObjNo).HasColumnName("RESP_CUSTOMER_OBJ_NO");

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("RESPONSE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ServicesCode)
                    .HasColumnName("SERVICES_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.SolutionDate)
                    .HasColumnName("SOLUTION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SolutionTime)
                    .HasColumnName("SOLUTION_TIME")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode4)
                    .HasColumnName("SYMPTOM_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomTag)
                    .HasColumnName("SYMPTOM_TAG")
                    .HasMaxLength(800);

                entity.Property(e => e.SymptomText).HasColumnName("SYMPTOM_TEXT");

                entity.Property(e => e.TaskTitle)
                    .HasColumnName("TASK_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeEstimate)
                    .HasColumnName("TIME_ESTIMATE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.AreaObjNo)
                    .HasConstraintName("PT_AREA_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ProjectTaskCustomerObjNoNavigation)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("PROJECT_TASK_CUSTOMER_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.MachineObjNo)
                    .HasConstraintName("_PROJECT_TASK_MACHINE_FK_");

                entity.HasOne(d => d.ProjectNoNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.ProjectNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("_PT_PROJECT_FK_");

                entity.HasOne(d => d.RespCustomerObjNoNavigation)
                    .WithMany(p => p.ProjectTaskRespCustomerObjNoNavigation)
                    .HasForeignKey(d => d.RespCustomerObjNo)
                    .HasConstraintName("PROJECT_TASK_RESP_CUSTOMER_FK");
            });

            modelBuilder.Entity<ProjectTaskAuto>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.TaskNo });

                entity.ToTable("PROJECT_TASK_AUTO");

                entity.HasIndex(e => e.ObjNo)
                    .HasName("IDX_PROJECT_TASK_AUTO_OBJ_NO");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ActionCode1)
                    .HasColumnName("ACTION_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode2)
                    .HasColumnName("ACTION_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionCode3)
                    .HasColumnName("ACTION_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.ActionText)
                    .HasColumnName("ACTION_TEXT")
                    .HasMaxLength(1200);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.AddressName)
                    .HasColumnName("ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.CheckedInDate)
                    .HasColumnName("CHECKED_IN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckedOut)
                    .HasColumnName("CHECKED_OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.CheckedOutBy)
                    .HasColumnName("CHECKED_OUT_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.CheckedOutDate)
                    .HasColumnName("CHECKED_OUT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ColorCode)
                    .HasColumnName("COLOR_CODE")
                    .HasMaxLength(5);

                entity.Property(e => e.CommentInternal).HasColumnName("COMMENT_INTERNAL");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("CONTACT_EMAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CoordX)
                    .HasColumnName("COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CoordY)
                    .HasColumnName("COORD_Y")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.DateReported)
                    .HasColumnName("DATE_REPORTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateResponse)
                    .HasColumnName("DATE_RESPONSE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaysBeetween)
                    .HasColumnName("DAYS_BEETWEEN")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ExternalProjectNo)
                    .HasColumnName("EXTERNAL_PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ExternalReplyMailAddress)
                    .HasColumnName("EXTERNAL_REPLY_MAIL_ADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.ExternalStatus)
                    .HasColumnName("EXTERNAL_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.ExternalTaskNo)
                    .HasColumnName("EXTERNAL_TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.FixedPrice)
                    .HasColumnName("FIXED_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LANGUAGE_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.LastCheck)
                    .HasColumnName("LAST_CHECK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTask)
                    .HasColumnName("LAST_TASK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTaskObjNo).HasColumnName("LAST_TASK_OBJ_NO");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(890)
                    .IsUnicode(false);

                entity.Property(e => e.NumDaysAhead)
                    .HasColumnName("NUM_DAYS_AHEAD")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OrderInformation)
                    .HasColumnName("ORDER_INFORMATION")
                    .HasMaxLength(500);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectTaskStatus)
                    .HasColumnName("PROJECT_TASK_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.ReceivedBy)
                    .HasColumnName("RECEIVED_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("RECEIVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResourcePriority)
                    .HasColumnName("RESOURCE_PRIORITY")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("RESPONSE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ServicesCode)
                    .HasColumnName("SERVICES_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomTag)
                    .HasColumnName("SYMPTOM_TAG")
                    .HasMaxLength(800);

                entity.Property(e => e.SymptomText)
                    .HasColumnName("SYMPTOM_TEXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.TaskTitle)
                    .HasColumnName("TASK_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeEstimate)
                    .HasColumnName("TIME_ESTIMATE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.ProjectTaskAuto)
                    .HasForeignKey(d => d.AreaObjNo)
                    .HasConstraintName("PT_AUTO_AREA_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.ProjectTaskAuto)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("PROJECT_TASK_AUTO_CUSTOMER_FK");

                entity.HasOne(d => d.MachineObjNoNavigation)
                    .WithMany(p => p.ProjectTaskAuto)
                    .HasForeignKey(d => d.MachineObjNo)
                    .HasConstraintName("PROJECT_TASK_AUTO_MACHINE_FK");

                entity.HasOne(d => d.ProjectNoNavigation)
                    .WithMany(p => p.ProjectTaskAuto)
                    .HasForeignKey(d => d.ProjectNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PT_AUTO_PROJECT_AUTO_FK");
            });

            modelBuilder.Entity<ProjectTaskCheckList>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.Code, e.MachineObjNo });

                entity.ToTable("PROJECT_TASK_CHECK_LIST");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.CheckListId)
                    .IsRequired()
                    .HasColumnName("CHECK_LIST_ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.ProjectTaskCheckList)
                    .HasForeignKey(d => new { d.Company, d.Code })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_TASK_CHECK_LIST_FK2");

                entity.HasOne(d => d.ProjectTask)
                    .WithMany(p => p.ProjectTaskCheckList)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_TASK_CHECK_LIST_FK");
            });

            modelBuilder.Entity<ProjectTaskCheckListAuto>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.Code, e.MachineObjNo });

                entity.ToTable("PROJECT_TASK_CHECK_LIST_AUTO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.CheckListId)
                    .IsRequired()
                    .HasColumnName("CHECK_LIST_ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.ProjectTaskCheckListAuto)
                    .HasForeignKey(d => new { d.Company, d.Code })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_TASK_CHECK_LIST_AUTO_FK2");

                entity.HasOne(d => d.ProjectTaskAuto)
                    .WithMany(p => p.ProjectTaskCheckListAuto)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_TASK_CHECK_LIST_AUTO_FK");
            });

            modelBuilder.Entity<ProjectTaskCheckListTreeFiles>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.CheckListCode, e.ResourceObjNo, e.MachineObjNo, e.CheckListNodeKey, e.FileNo });

                entity.ToTable("PROJECT_TASK_CHECK_LIST_TREE_FILES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.CheckListNodeKey)
                    .HasColumnName("CHECK_LIST_NODE_KEY")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasColumnName("FILE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CheckListId)
                    .IsRequired()
                    .HasColumnName("CHECK_LIST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnName("FILE_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.FileDate)
                    .HasColumnName("FILE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileTitle)
                    .HasColumnName("FILE_TITLE")
                    .HasMaxLength(250);

                entity.Property(e => e.FileType)
                    .HasColumnName("FILE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ProjectTaskCheckListTreeValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.CheckListCode, e.ResourceObjNo, e.MachineObjNo, e.CheckListNodeKey });

                entity.ToTable("PROJECT_TASK_CHECK_LIST_TREE_VALUES");

                entity.HasIndex(e => e.MachineObjNo)
                    .HasName("IDX_PROJECT_TASK_CHECK_LIST_TREE_VALUES_MACHINE_2");

                entity.HasIndex(e => e.ResourceObjNo)
                    .HasName("IDX_PROJECT_TASK_CHECK_LIST_TREE_VALUES_RESOURCE");

                entity.HasIndex(e => new { e.CheckListNodeKey, e.MachineObjNo, e.Company, e.CheckListCode, e.CheckListId, e.Status, e.ObjDate, e.ProjectNo, e.TaskNo, e.ResourceObjNo })
                    .HasName("IDX_PROJECT_TASK_CHECK_LIST_TREE_VALUES_MANY");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.CheckListNodeKey)
                    .HasColumnName("CHECK_LIST_NODE_KEY")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListId)
                    .IsRequired()
                    .HasColumnName("CHECK_LIST_ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(4000);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatGroup)
                    .HasColumnName("STAT_GROUP")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectTaskResource>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.TaskNo, e.ResourceNo });

                entity.ToTable("PROJECT_TASK_RESOURCE");

                entity.HasIndex(e => e.ResourceObjNo)
                    .HasName("IDX_PROJECT_TASK_RESOURCE_RESOURCE");

                entity.HasIndex(e => new { e.ProjectNo, e.TaskNo })
                    .HasName("IDX_PTR_PROJECT_TASK_NO");

                entity.HasIndex(e => new { e.ResourceObjNo, e.CheckedInDate })
                    .HasName("IDX_PTR_RESOURCE_CHECKED_IN_DATE");

                entity.HasIndex(e => new { e.ResourceObjNo, e.ExternalId })
                    .HasName("PROJECT_TASK_RESOURCE_EXTERNAL");

                entity.HasIndex(e => new { e.TaskNo, e.ProjectNo, e.CheckedOutDate })
                    .HasName("IDX_PTR_TASK_PROJECT_CHECKED_OUT_DATE");

                entity.HasIndex(e => new { e.ResourceObjNo, e.ProjectNo, e.TaskNo, e.CheckedOut })
                    .HasName("IDX_PTR_RESOURCE_OBJ_NO_PROJECT_NO_TASK_NO_CHECKED_OUT");

                entity.HasIndex(e => new { e.TaskNo, e.ProjectNo, e.ResourceObjNo, e.ExternalId })
                    .HasName("IDX_PTR_TASK_RESOURCE_EXTERNAL");

                entity.HasIndex(e => new { e.TaskNo, e.ProjectNo, e.ResourceObjNo, e.ResourceNo })
                    .HasName("IDX_PTR_TASK_NO_RESOURCE_NO");

                entity.HasIndex(e => new { e.TaskNo, e.ProjectNo, e.CheckedOutDate, e.ResourceObjNo, e.CheckedOut, e.CheckedInDate })
                    .HasName("IDX_PTR_TASK_PROJECT_RESOURCE_CHECKED_OUT_INFORMATION");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ResourceNo)
                    .HasColumnName("RESOURCE_NO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AssignDate)
                    .HasColumnName("ASSIGN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignTime)
                    .HasColumnName("ASSIGN_TIME")
                    .HasMaxLength(5);

                entity.Property(e => e.CheckedInDate)
                    .HasColumnName("CHECKED_IN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckedOut)
                    .HasColumnName("CHECKED_OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.CheckedOutDate)
                    .HasColumnName("CHECKED_OUT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Edited)
                    .HasColumnName("EDITED")
                    .HasMaxLength(1);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.TeamLeader)
                    .HasColumnName("TEAM_LEADER")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ResourceObjNoNavigation)
                    .WithMany(p => p.ProjectTaskResource)
                    .HasForeignKey(d => d.ResourceObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTR_TECHNICIAN_FK");

                entity.HasOne(d => d.ProjectTask)
                    .WithMany(p => p.ProjectTaskResource)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTR_TASK_FK");
            });

            modelBuilder.Entity<ProjectTaskResourceAuto>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.TaskNo, e.ResourceNo });

                entity.ToTable("PROJECT_TASK_RESOURCE_AUTO");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ResourceNo)
                    .HasColumnName("RESOURCE_NO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AssignDate)
                    .HasColumnName("ASSIGN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignTime)
                    .HasColumnName("ASSIGN_TIME")
                    .HasMaxLength(5);

                entity.Property(e => e.CheckedInDate)
                    .HasColumnName("CHECKED_IN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckedOut)
                    .HasColumnName("CHECKED_OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.CheckedOutDate)
                    .HasColumnName("CHECKED_OUT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.TeamLeader)
                    .HasColumnName("TEAM_LEADER")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ResourceObjNoNavigation)
                    .WithMany(p => p.ProjectTaskResourceAuto)
                    .HasForeignKey(d => d.ResourceObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTR_AUTO_TECHNICIAN_FK");

                entity.HasOne(d => d.ProjectTaskAuto)
                    .WithMany(p => p.ProjectTaskResourceAuto)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTR_TASK_AUTO_FK");
            });

            modelBuilder.Entity<ProjectTaskStartStop>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.SeqNo });

                entity.ToTable("PROJECT_TASK_START_STOP");

                entity.HasIndex(e => new { e.ProjectNo, e.TaskNo, e.Type })
                    .HasName("IDX_PROJECT_TASK_START_STOP");

                entity.HasIndex(e => new { e.Company, e.SeqNo, e.ProjectNo, e.Type })
                    .HasName("IDX_PROJECT_TASK_START_STOP_COMPANY_SEQ_NO_PROJECT_NO_TYPE");

                entity.HasIndex(e => new { e.Status, e.Company, e.TaskNo, e.ProjectNo, e.StopTime, e.SeqNo })
                    .HasName("IDX_PROJECT_TASK_START_STOP_STATUS_COMPANY_TASK_NO_PROJECT_NO_STOP_TIME_SEQ_NO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SeqNo)
                    .HasColumnName("SEQ_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.CpuObjNo).HasColumnName("CPU_OBJ_NO");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(1000);

                entity.Property(e => e.InvoiceText)
                    .HasColumnName("INVOICE_TEXT")
                    .HasMaxLength(250);

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.ServicesCode)
                    .HasColumnName("SERVICES_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StopTime)
                    .HasColumnName("STOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(20);

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.ProjectTaskStartStop)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .HasConstraintName("PROJECT_TASK_START_STOP_TECH_FK");

                entity.HasOne(d => d.ProjectTask)
                    .WithMany(p => p.ProjectTaskStartStop)
                    .HasForeignKey(d => new { d.ProjectNo, d.TaskNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROJECT_TASK_START_STOP_PT_FK");
            });

            modelBuilder.Entity<ProjectTaskUndoCheckOut>(entity =>
            {
                entity.HasKey(e => new { e.ProjectNo, e.TaskNo, e.UndoTime });

                entity.ToTable("PROJECT_TASK_UNDO_CHECK_OUT");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.UndoTime)
                    .HasColumnName("UNDO_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");
            });

            modelBuilder.Entity<ProjectTemplate>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("PROJECT_TEMPLATE");

                entity.HasIndex(e => new { e.Company, e.Code })
                    .HasName("PROJECT_TEMPLATE_KEY_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectTemplateTasks>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.TaskNo });

                entity.ToTable("PROJECT_TEMPLATE_TASKS");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CheckListCode)
                    .HasColumnName("CHECK_LIST_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("RESPONSE_TIME")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.SymptomCode1)
                    .HasColumnName("SYMPTOM_CODE_1")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode2)
                    .HasColumnName("SYMPTOM_CODE_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode3)
                    .HasColumnName("SYMPTOM_CODE_3")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomCode4)
                    .HasColumnName("SYMPTOM_CODE_4")
                    .HasMaxLength(10);

                entity.Property(e => e.SymptomText).HasColumnName("SYMPTOM_TEXT");

                entity.Property(e => e.TaskTitle)
                    .HasColumnName("TASK_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeEstimate)
                    .HasColumnName("TIME_ESTIMATE")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("PROPERTY");

                entity.HasIndex(e => e.SourceObjNo)
                    .HasName("IDX_ROPERTY_SOURCE_OBJ_NO");

                entity.HasIndex(e => new { e.SourceObjNo, e.Code })
                    .HasName("IDX_PROPERTY_SOURCE_OBJ_NO_CODE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PropertyValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Registry, e.Code });

                entity.ToTable("PROPERTY_VALUES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DataType)
                    .HasColumnName("DATA_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.DropdownValues)
                    .HasColumnName("DROPDOWN_VALUES")
                    .HasMaxLength(200);

                entity.Property(e => e.Mandatory).HasColumnName("MANDATORY");

                entity.Property(e => e.MaxLen).HasColumnName("MAX_LEN");

                entity.Property(e => e.MinLen).HasColumnName("MIN_LEN");

                entity.Property(e => e.SyncToMobile).HasColumnName("SYNC_TO_MOBILE");

                entity.Property(e => e.UseValues).HasColumnName("USE_VALUES");
            });

            modelBuilder.Entity<QuickOrderArticles>(entity =>
            {
                entity.HasKey(e => new { e.ModelObjNo, e.ArticleObjNo });

                entity.ToTable("QUICK_ORDER_ARTICLES");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Group1)
                    .HasColumnName("GROUP_1")
                    .HasMaxLength(1);

                entity.Property(e => e.Group2)
                    .HasColumnName("GROUP_2")
                    .HasMaxLength(1);

                entity.Property(e => e.Group3)
                    .HasColumnName("GROUP_3")
                    .HasMaxLength(1);

                entity.Property(e => e.Qty1)
                    .HasColumnName("QTY_1")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.Qty2)
                    .HasColumnName("QTY_2")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.Qty3)
                    .HasColumnName("QTY_3")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.UseInSales).HasColumnName("USE_IN_SALES");

                entity.Property(e => e.UseInService).HasColumnName("USE_IN_SERVICE");

                entity.Property(e => e.UseInWeb).HasColumnName("USE_IN_WEB");

                entity.HasOne(d => d.ModelObjNoNavigation)
                    .WithMany(p => p.QuickOrderArticles)
                    .HasForeignKey(d => d.ModelObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QOA_MODEL_FK");
            });

            modelBuilder.Entity<QuickOrderArticlesDefaultValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ArticleSortGroupNo, e.ArticleSortGroupValue });

                entity.ToTable("QUICK_ORDER_ARTICLES_DEFAULT_VALUES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleSortGroupNo)
                    .HasColumnName("ARTICLE_SORT_GROUP_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleSortGroupValue)
                    .HasColumnName("ARTICLE_SORT_GROUP_VALUE")
                    .HasMaxLength(10);

                entity.Property(e => e.Qty1)
                    .HasColumnName("QTY_1")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.Qty2)
                    .HasColumnName("QTY_2")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.Qty3)
                    .HasColumnName("QTY_3")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.UseInSales).HasColumnName("USE_IN_SALES");

                entity.Property(e => e.UseInService).HasColumnName("USE_IN_SERVICE");

                entity.Property(e => e.UseInWeb).HasColumnName("USE_IN_WEB");
            });

            modelBuilder.Entity<Recurrence>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.SourceObjNo });

                entity.ToTable("RECURRENCE");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.DayOfMonth)
                    .HasColumnName("DAY_OF_MONTH")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DayOfWeekMask)
                    .HasColumnName("DAY_OF_WEEK_MASK")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Instance)
                    .HasColumnName("INSTANCE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Interval)
                    .HasColumnName("INTERVAL")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MonthOfYear)
                    .HasColumnName("MONTH_OF_YEAR")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NoEndDate).HasColumnName("NO_END_DATE");

                entity.Property(e => e.NumDaysAhead)
                    .HasColumnName("NUM_DAYS_AHEAD")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Occurences)
                    .HasColumnName("OCCURENCES")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PatternEndDate)
                    .HasColumnName("PATTERN_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatternStartDate)
                    .HasColumnName("PATTERN_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecurrenceType)
                    .HasColumnName("RECURRENCE_TYPE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Regenerate).HasColumnName("REGENERATE");

                entity.Property(e => e.ServiceInterval)
                    .HasColumnName("SERVICE_INTERVAL")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ServiceIntervalFirstCounter)
                    .HasColumnName("SERVICE_INTERVAL_FIRST_COUNTER")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ServiceIntervalOn)
                    .HasColumnName("SERVICE_INTERVAL_ON")
                    .HasMaxLength(1);

                entity.Property(e => e.ServiceIntervalOnly)
                    .HasColumnName("SERVICE_INTERVAL_ONLY")
                    .HasMaxLength(1);

                entity.Property(e => e.ServiceIntervalUseEstimated)
                    .HasColumnName("SERVICE_INTERVAL_USE_ESTIMATED")
                    .HasMaxLength(1);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RemoteAccess>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.Address });

                entity.ToTable("REMOTE_ACCESS");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessType)
                    .HasColumnName("ACCESS_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.ConnectionType)
                    .HasColumnName("CONNECTION_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MainAccess).HasColumnName("MAIN_ACCESS");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.SourceObjNoNavigation)
                    .WithMany(p => p.RemoteAccess)
                    .HasForeignKey(d => d.SourceObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("REMOTE_ACCESS_CUSTOMER_FK");
            });

            modelBuilder.Entity<ReportLayout>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.ReportName, e.FieldName });

                entity.ToTable("REPORT_LAYOUT");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ALL')");

                entity.Property(e => e.ReportName)
                    .HasColumnName("REPORT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldFont)
                    .HasColumnName("FIELD_FONT")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldText)
                    .HasColumnName("FIELD_TEXT")
                    .HasMaxLength(1056);

                entity.Property(e => e.FontBold)
                    .HasColumnName("FONT_BOLD")
                    .HasMaxLength(2);

                entity.Property(e => e.FontColor)
                    .HasColumnName("FONT_COLOR")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FontItalic)
                    .HasColumnName("FONT_ITALIC")
                    .HasMaxLength(2);

                entity.Property(e => e.FontSize)
                    .HasColumnName("FONT_SIZE")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FontUnderline)
                    .HasColumnName("FONT_UNDERLINE")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<SaleBookmark>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_BOOKMARK");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookmarkGlobal).HasColumnName("BOOKMARK_GLOBAL");

                entity.Property(e => e.BookmarkName)
                    .HasColumnName("BOOKMARK_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.BookmarkOwner)
                    .HasColumnName("BOOKMARK_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.BookmarkType).HasColumnName("BOOKMARK_TYPE");

                entity.Property(e => e.BookmarkValue)
                    .HasColumnName("BOOKMARK_VALUE")
                    .HasMaxLength(1024);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BookmarkOwnerNavigation)
                    .WithMany(p => p.SaleBookmark)
                    .HasForeignKey(d => d.BookmarkOwner)
                    .HasConstraintName("FK_SALE_BOOKMARK_APP_USER");
            });

            modelBuilder.Entity<SaleBusinessCode>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.BusinessCode });

                entity.ToTable("SALE_BUSINESS_CODE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessCode)
                    .HasColumnName("BUSINESS_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaleCalcContractModel>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.ModelObjNo });

                entity.ToTable("SALE_CALC_CONTRACT_MODEL");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");
            });

            modelBuilder.Entity<SaleCalcContractRow>(entity =>
            {
                entity.HasKey(e => new { e.CalcObjNo, e.ContractRowNo, e.TemplateObjNo });

                entity.ToTable("SALE_CALC_CONTRACT_ROW");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TemplateObjNo).HasColumnName("TEMPLATE_OBJ_NO");
            });

            modelBuilder.Entity<SaleCalcHeading>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SALE_CALC_HEADING");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllOnOneVolumeRow)
                    .HasColumnName("ALL_ON_ONE_VOLUME_ROW")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("APPROVED_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("APPROVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalcNo)
                    .HasColumnName("CALC_NO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CalcType)
                    .IsRequired()
                    .HasColumnName("CALC_TYPE")
                    .HasMaxLength(3);

                entity.Property(e => e.ContractActiveFrom)
                    .HasColumnName("CONTRACT_ACTIVE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractObjNo).HasColumnName("CONTRACT_OBJ_NO");

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContractSpecialCosts)
                    .HasColumnName("CONTRACT_SPECIAL_COSTS")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ContractStart)
                    .HasColumnName("CONTRACT_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerProvFactor)
                    .HasColumnName("CUSTOMER_PROV_FACTOR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.DateGenerated)
                    .HasColumnName("DATE_GENERATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExternalContractCost)
                    .HasColumnName("EXTERNAL_CONTRACT_COST")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ExternalContractDesc)
                    .HasColumnName("EXTERNAL_CONTRACT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.ExternalContractEnd)
                    .HasColumnName("EXTERNAL_CONTRACT_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalContractPeriod)
                    .HasColumnName("EXTERNAL_CONTRACT_PERIOD")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ExternalContractTotal)
                    .HasColumnName("EXTERNAL_CONTRACT_TOTAL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.FeeCalculate)
                    .HasColumnName("FEE_CALCULATE")
                    .HasMaxLength(1);

                entity.Property(e => e.InternalContractCost)
                    .HasColumnName("INTERNAL_CONTRACT_COST")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.InternalContractDesc)
                    .HasColumnName("INTERNAL_CONTRACT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.InternalContractEnd)
                    .HasColumnName("INTERNAL_CONTRACT_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.InternalContractPeriod)
                    .HasColumnName("INTERNAL_CONTRACT_PERIOD")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.InternalContractTotal)
                    .HasColumnName("INTERNAL_CONTRACT_TOTAL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxHwDiscount)
                    .HasColumnName("MAX_HW_DISCOUNT")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderNoDirectSale)
                    .HasColumnName("ORDER_NO_DIRECT_SALE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ProjectPrice)
                    .HasColumnName("PROJECT_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.SaleprojectObjNo).HasColumnName("SALEPROJECT_OBJ_NO");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.SpecialProvision)
                    .HasColumnName("SPECIAL_PROVISION")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(2);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.SupplierFactor)
                    .HasColumnName("SUPPLIER_FACTOR")
                    .HasColumnType("numeric(9, 7)");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.SupplierProvision)
                    .HasColumnName("SUPPLIER_PROVISION")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.TemplateObjNo).HasColumnName("TEMPLATE_OBJ_NO");

                entity.Property(e => e.UseAutoSupplierFactor)
                    .HasColumnName("USE_AUTO_SUPPLIER_FACTOR")
                    .HasMaxLength(1);

                entity.Property(e => e.UseProjectPrice)
                    .HasColumnName("USE_PROJECT_PRICE")
                    .HasMaxLength(1);

                entity.HasOne(d => d.SaleprojectObjNoNavigation)
                    .WithMany(p => p.SaleCalcHeading)
                    .HasForeignKey(d => d.SaleprojectObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_CALC_HEADING_SALE_SALEPROJECT");

                entity.HasOne(d => d.TemplateObjNoNavigation)
                    .WithMany(p => p.SaleCalcHeading)
                    .HasForeignKey(d => d.TemplateObjNo)
                    .HasConstraintName("FK_SALE_CALC_HEADING_CONTRACT_TEMPLATE");
            });

            modelBuilder.Entity<SaleCalcIntervalGroup>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CALC_INTERVAL_GROUP");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SaleCalcIntervalMeter>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CALC_INTERVAL_METER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalFrom)
                    .HasColumnName("INTERVAL_FROM")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IntervalObjNo).HasColumnName("INTERVAL_OBJ_NO");

                entity.Property(e => e.IntervalTo)
                    .HasColumnName("INTERVAL_TO")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Ppeu)
                    .HasColumnName("PPEU")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.Ppu)
                    .HasColumnName("PPU")
                    .HasColumnType("numeric(25, 10)");

                entity.HasOne(d => d.IntervalObjNoNavigation)
                    .WithMany(p => p.SaleCalcIntervalMeter)
                    .HasForeignKey(d => d.IntervalObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_CALC_INTERVAL_METER_SALE_CALC_INTERVAL_GROUP");

                entity.HasOne(d => d.MeterObjNoNavigation)
                    .WithMany(p => p.SaleCalcIntervalMeter)
                    .HasForeignKey(d => d.MeterObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_CALC_INTERVAL_METER_METER");
            });

            modelBuilder.Entity<SaleCalcLeasing>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CALC_LEASING");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalcPriceFrom)
                    .HasColumnName("CALC_PRICE_FROM")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CalcPriceTo)
                    .HasColumnName("CALC_PRICE_TO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FactorDescription)
                    .HasColumnName("FACTOR_DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Leasing).HasColumnName("LEASING");

                entity.Property(e => e.LeasingFactor)
                    .HasColumnName("LEASING_FACTOR")
                    .HasColumnType("decimal(9, 7)");

                entity.Property(e => e.MonthFrom)
                    .HasColumnName("MONTH_FROM")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MonthTo)
                    .HasColumnName("MONTH_TO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Rental).HasColumnName("RENTAL");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");
            });

            modelBuilder.Entity<SaleCalcMeterData>(entity =>
            {
                entity.HasKey(e => new { e.CalcObjNo, e.ContractRowNo, e.MeterObjNo, e.LineObjNo });

                entity.ToTable("SALE_CALC_METER_DATA");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.LineObjNo).HasColumnName("LINE_OBJ_NO");

                entity.Property(e => e.ContractProvisionPercent)
                    .HasColumnName("CONTRACT_PROVISION_PERCENT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DiscountProvFactor)
                    .HasColumnName("DISCOUNT_PROV_FACTOR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Ppeu)
                    .HasColumnName("PPEU")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PpeuDiscount)
                    .HasColumnName("PPEU_DISCOUNT")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.PricePrUnit)
                    .HasColumnName("PRICE_PR_UNIT")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Provision)
                    .HasColumnName("PROVISION")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ServicePrice)
                    .HasColumnName("SERVICE_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.TemplateObjNo).HasColumnName("TEMPLATE_OBJ_NO");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(18, 9)");
            });

            modelBuilder.Entity<SaleCalcMeterDataVirtualDep>(entity =>
            {
                entity.HasKey(e => new { e.CalcObjNo, e.ContractRowNo, e.LineObjNo, e.VirtualMeterObjNo, e.MeterObjNo });

                entity.ToTable("SALE_CALC_METER_DATA_VIRTUAL_DEP");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.LineObjNo).HasColumnName("LINE_OBJ_NO");

                entity.Property(e => e.VirtualMeterObjNo).HasColumnName("VIRTUAL_METER_OBJ_NO");

                entity.Property(e => e.MeterObjNo).HasColumnName("METER_OBJ_NO");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(18, 9)");
            });

            modelBuilder.Entity<SaleCalcOldContract>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.CalcObjNo, e.ContractType });

                entity.ToTable("SALE_CALC_OLD_CONTRACT");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.ContractType)
                    .HasColumnName("CONTRACT_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractCost)
                    .HasColumnName("CONTRACT_COST")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ContractDesc)
                    .HasColumnName("CONTRACT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContractTotal)
                    .HasColumnName("CONTRACT_TOTAL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("DATE_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ppu)
                    .HasColumnName("PPU")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ProvisionFactor)
                    .HasColumnName("PROVISION_FACTOR")
                    .HasColumnType("numeric(10, 5)");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.CalcObjNoNavigation)
                    .WithMany(p => p.SaleCalcOldContract)
                    .HasForeignKey(d => d.CalcObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_CALC_OLD_CONTRACT_SALE_CALC_HEADING");
            });

            modelBuilder.Entity<SaleCalcSubscription>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CALC_SUBSCRIPTION");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleDescription)
                    .HasColumnName("ARTICLE_DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.ContractPeriod)
                    .HasColumnName("CONTRACT_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ContractTypeObjNo).HasColumnName("CONTRACT_TYPE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CostPriceOnlyFirst)
                    .HasColumnName("COST_PRICE_ONLY_FIRST")
                    .HasMaxLength(1);

                entity.Property(e => e.CreateMachine)
                    .HasColumnName("CREATE_MACHINE")
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceFrequency)
                    .HasColumnName("INVOICE_FREQUENCY")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ItemsOnRow)
                    .HasColumnName("ITEMS_ON_ROW")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleCalcTargetPrice>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SALE_CALC_TARGET_PRICE");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.Factor)
                    .HasColumnName("FACTOR")
                    .HasColumnType("decimal(9, 6)");
            });

            modelBuilder.Entity<SaleCathegory>(entity =>
            {
                entity.HasKey(e => e.CathegoryId);

                entity.ToTable("SALE_CATHEGORY");

                entity.Property(e => e.CathegoryId)
                    .HasColumnName("CATHEGORY_ID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CathegoryName)
                    .IsRequired()
                    .HasColumnName("CATHEGORY_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaleCustomerExtMachine>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CUSTOMER_EXT_MACHINE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Contract).HasColumnName("CONTRACT");

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FixedPrice)
                    .HasColumnName("FIXED_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Information)
                    .HasColumnName("INFORMATION")
                    .HasMaxLength(2048);

                entity.Property(e => e.InstallationDate)
                    .HasColumnName("INSTALLATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.NoticeTime)
                    .HasColumnName("NOTICE_TIME")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ppeu)
                    .HasColumnName("PPEU")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Ppu)
                    .HasColumnName("PPU")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SaleProbability).HasColumnName("SALE_PROBABILITY");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.TotalContract).HasColumnName("TOTAL_CONTRACT");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<SaleCustomerMail>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_CUSTOMER_MAIL");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.DateReceived)
                    .HasColumnName("DATE_RECEIVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSent)
                    .HasColumnName("DATE_SENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtId)
                    .IsRequired()
                    .HasColumnName("EXT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.MailFile)
                    .IsRequired()
                    .HasColumnName("MAIL_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.MailOwner)
                    .IsRequired()
                    .HasColumnName("MAIL_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.MailSize)
                    .HasColumnName("MAIL_SIZE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.NumAttachment)
                    .HasColumnName("NUM_ATTACHMENT")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SaleprojectObjNo).HasColumnName("SALEPROJECT_OBJ_NO");

                entity.Property(e => e.SentFrom)
                    .HasColumnName("SENT_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.SentFromMail)
                    .HasColumnName("SENT_FROM_MAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.SentTo)
                    .HasColumnName("SENT_TO")
                    .HasMaxLength(255);

                entity.Property(e => e.SentToMail)
                    .HasColumnName("SENT_TO_MAIL")
                    .HasMaxLength(512);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaleDeletedItems>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.ItemType, e.DateDeleted });

                entity.ToTable("SALE_DELETED_ITEMS");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ItemType)
                    .HasColumnName("ITEM_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.DateDeleted)
                    .HasColumnName("DATE_DELETED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleDocument>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_DOCUMENT");

                entity.HasIndex(e => e.CustomerObjNo)
                    .HasName("IDX_SALE_DOCUMENT_CUSTOMER_OBJ_NO");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.DocNode)
                    .HasColumnName("DOC_NODE")
                    .HasMaxLength(512);

                entity.Property(e => e.DocumentCategory)
                    .HasColumnName("DOCUMENT_CATEGORY")
                    .HasMaxLength(10);

                entity.Property(e => e.DocumentDateChanged)
                    .HasColumnName("DOCUMENT_DATE_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentDateCreated)
                    .HasColumnName("DOCUMENT_DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentFile)
                    .HasColumnName("DOCUMENT_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.DocumentName)
                    .HasColumnName("DOCUMENT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentOwner)
                    .HasColumnName("DOCUMENT_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentSale).HasColumnName("DOCUMENT_SALE");

                entity.Property(e => e.DocumentSeek)
                    .HasColumnName("DOCUMENT_SEEK")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentSize)
                    .HasColumnName("DOCUMENT_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DocumentType).HasColumnName("DOCUMENT_TYPE");

                entity.Property(e => e.DocumentTypeid).HasColumnName("DOCUMENT_TYPEID");

                entity.Property(e => e.InfoCheckbox01)
                    .HasColumnName("INFO_CHECKBOX_01")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox02)
                    .HasColumnName("INFO_CHECKBOX_02")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox03)
                    .HasColumnName("INFO_CHECKBOX_03")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox04)
                    .HasColumnName("INFO_CHECKBOX_04")
                    .HasMaxLength(1);

                entity.Property(e => e.InfoCheckbox05)
                    .HasColumnName("INFO_CHECKBOX_05")
                    .HasMaxLength(1);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.WriteAccessUsers)
                    .HasColumnName("WRITE_ACCESS_USERS")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<SaleDocumentType>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_DOCUMENT_TYPE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(890)
                    .IsUnicode(false);

                entity.Property(e => e.ProtectedPassword)
                    .HasColumnName("PROTECTED_PASSWORD")
                    .HasMaxLength(100);

                entity.Property(e => e.SystemGroup).HasColumnName("SYSTEM_GROUP");

                entity.Property(e => e.TemplateFile)
                    .HasColumnName("TEMPLATE_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("TEMPLATE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.TemplateOwner)
                    .HasColumnName("TEMPLATE_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.TemplateType).HasColumnName("TEMPLATE_TYPE");

                entity.Property(e => e.UseTemplate).HasColumnName("USE_TEMPLATE");

                entity.HasOne(d => d.TemplateOwnerNavigation)
                    .WithMany(p => p.SaleDocumentType)
                    .HasForeignKey(d => d.TemplateOwner)
                    .HasConstraintName("FK_SALE_DOCUMENT_TYPE_APP_USER");
            });

            modelBuilder.Entity<SaleGridlayout>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_GRIDLAYOUT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Application)
                    .HasColumnName("APPLICATION")
                    .HasMaxLength(30);

                entity.Property(e => e.DateChanged)
                    .HasColumnName("DATE_CHANGED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GridOwner)
                    .HasColumnName("GRID_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.Language)
                    .HasColumnName("LANGUAGE")
                    .HasMaxLength(20);

                entity.Property(e => e.LayoutFile)
                    .HasColumnName("LAYOUT_FILE")
                    .HasColumnType("image");

                entity.Property(e => e.LayoutName)
                    .HasColumnName("LAYOUT_NAME")
                    .HasMaxLength(512);

                entity.HasOne(d => d.GridOwnerNavigation)
                    .WithMany(p => p.SaleGridlayout)
                    .HasForeignKey(d => d.GridOwner)
                    .HasConstraintName("FK_SALE_GRIDLAYOUT_APP_USER");
            });

            modelBuilder.Entity<SaleGroup>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SALE_GROUP");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupType).HasColumnName("GROUP_TYPE");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowNo)
                    .HasColumnName("ROW_NO")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<SaleGroupSelected>(entity =>
            {
                entity.HasKey(e => e.IdColumn);

                entity.ToTable("SALE_GROUP_SELECTED");

                entity.Property(e => e.IdColumn)
                    .HasColumnName("ID_COLUMN")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.GroupObjNo).HasColumnName("GROUP_OBJ_NO");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.HasOne(d => d.GroupObjNoNavigation)
                    .WithMany(p => p.SaleGroupSelected)
                    .HasForeignKey(d => d.GroupObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_GROUP_SELECTED_SALE_GROUP");
            });

            modelBuilder.Entity<SaleLevel>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.LevelId });

                entity.ToTable("SALE_LEVEL");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LevelId)
                    .HasColumnName("LEVEL_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.LevelName)
                    .IsRequired()
                    .HasColumnName("LEVEL_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaleMailconfig>(entity =>
            {
                entity.HasKey(e => e.Owner);

                entity.ToTable("SALE_MAILCONFIG");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllFolders).HasColumnName("ALL_FOLDERS");

                entity.Property(e => e.DialupName)
                    .HasColumnName("DIALUP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mail2)
                    .HasColumnName("MAIL2")
                    .HasMaxLength(50);

                entity.Property(e => e.MailSystem)
                    .HasColumnName("MAIL_SYSTEM")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(25);

                entity.Property(e => e.Pop3Server)
                    .HasColumnName("POP3_SERVER")
                    .HasMaxLength(50);

                entity.Property(e => e.ReplyAdress)
                    .HasColumnName("REPLY_ADRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.SeekFolders)
                    .HasColumnName("SEEK_FOLDERS")
                    .HasMaxLength(50);

                entity.Property(e => e.SmtpServer)
                    .HasColumnName("SMTP_SERVER")
                    .HasMaxLength(50);

                entity.Property(e => e.UseDialup).HasColumnName("USE_DIALUP");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<SaleMailSent>(entity =>
            {
                entity.HasKey(e => new { e.SourceObjNo, e.EmailAdr });

                entity.ToTable("SALE_MAIL_SENT");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.EmailAdr)
                    .HasColumnName("EMAIL_ADR")
                    .HasMaxLength(50);

                entity.Property(e => e.DateSent)
                    .HasColumnName("DATE_SENT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleNote>(entity =>
            {
                entity.HasKey(e => new { e.ObjNo, e.SourceObjNo });

                entity.ToTable("SALE_NOTE");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasColumnName("NOTE_TEXT");
            });

            modelBuilder.Entity<SaleOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.CalcObjNo, e.LineNo })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SALE_ORDER_LINE");

                entity.HasIndex(e => new { e.CalcObjNo, e.ContractRowNo })
                    .HasName("IDX_SALE_ORDER_LINE_CALC_CONTRACT_ROW");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AggregateArticleType)
                    .HasColumnName("AGGREGATE_ARTICLE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ArticleSerialNo)
                    .HasColumnName("ARTICLE_SERIAL_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.AutoFpPrice)
                    .HasColumnName("AUTO_FP_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.AutoFpTemplateObjNo).HasColumnName("AUTO_FP_TEMPLATE_OBJ_NO");

                entity.Property(e => e.CalcAutoadjustFromSummary).HasColumnName("CALC_AUTOADJUST_FROM_SUMMARY");

                entity.Property(e => e.CalcChangeSalesprice).HasColumnName("CALC_CHANGE_SALESPRICE");

                entity.Property(e => e.ContractRowNo)
                    .HasColumnName("CONTRACT_ROW_NO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.DirectSale)
                    .HasColumnName("DIRECT_SALE")
                    .HasMaxLength(1);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Distribute)
                    .HasColumnName("DISTRIBUTE")
                    .HasMaxLength(1);

                entity.Property(e => e.FeeCalculate)
                    .HasColumnName("FEE_CALCULATE")
                    .HasMaxLength(1);

                entity.Property(e => e.FeeLevel)
                    .HasColumnName("FEE_LEVEL")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.FeePrice)
                    .HasColumnName("FEE_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.HideArticleNo)
                    .HasColumnName("HIDE_ARTICLE_NO")
                    .HasMaxLength(1);

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(250);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineType)
                    .HasColumnName("LINE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.LinkedLineNo)
                    .HasColumnName("LINKED_LINE_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MachineAddrRow)
                    .HasColumnName("MACHINE_ADDR_ROW")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MachineLocation)
                    .HasColumnName("MACHINE_LOCATION")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ManualFpPeriod)
                    .HasColumnName("MANUAL_FP_PERIOD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ManualFpPrice)
                    .HasColumnName("MANUAL_FP_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ManualFpStartDate)
                    .HasColumnName("MANUAL_FP_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManualFpTemplateObjNo).HasColumnName("MANUAL_FP_TEMPLATE_OBJ_NO");

                entity.Property(e => e.MaxDiscount)
                    .HasColumnName("MAX_DISCOUNT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.ModelObjNo).HasColumnName("MODEL_OBJ_NO");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.OptionalLine)
                    .HasColumnName("OPTIONAL_LINE")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderLineObjNo).HasColumnName("ORDER_LINE_OBJ_NO");

                entity.Property(e => e.Provision)
                    .HasColumnName("PROVISION")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ProvisionFactor)
                    .HasColumnName("PROVISION_FACTOR")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.ProvisionPercent)
                    .HasColumnName("PROVISION_PERCENT")
                    .HasColumnType("numeric(9, 5)");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("QTY_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.QtyNotDelivered)
                    .HasColumnName("QTY_NOT_DELIVERED")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.TargetPrice)
                    .HasColumnName("TARGET_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.TextBefore).HasColumnName("TEXT_BEFORE");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(6);

                entity.Property(e => e.VatCode)
                    .HasColumnName("VAT_CODE")
                    .HasColumnType("decimal(4, 2)");

                entity.HasOne(d => d.CalcObjNoNavigation)
                    .WithMany(p => p.SaleOrderLine)
                    .HasForeignKey(d => d.CalcObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_ORDER_LINE_SALE_CALC_HEADING");
            });

            modelBuilder.Entity<SaleOrderLineMachine>(entity =>
            {
                entity.HasKey(e => new { e.CalcObjNo, e.LineNo, e.MachineObjNo });

                entity.ToTable("SALE_ORDER_LINE_MACHINE");

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.HasOne(d => d.SaleOrderLine)
                    .WithMany(p => p.SaleOrderLineMachine)
                    .HasForeignKey(d => new { d.CalcObjNo, d.LineNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SOLM_SOL_FK");
            });

            modelBuilder.Entity<SaleProperty>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_PROPERTY");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.GlobalValue).HasColumnName("GLOBAL_VALUE");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjNoSource).HasColumnName("OBJ_NO_SOURCE");

                entity.Property(e => e.Property)
                    .HasColumnName("PROPERTY")
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyOwner)
                    .IsRequired()
                    .HasColumnName("PROPERTY_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.PropertyOwnerNavigation)
                    .WithMany(p => p.SaleProperty)
                    .HasForeignKey(d => d.PropertyOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_PROPERTY_APP_USER");
            });

            modelBuilder.Entity<SaleReport>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("SALE_REPORT");

                entity.Property(e => e.Index)
                    .HasColumnName("INDEX")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DocumentType)
                    .HasColumnName("DOCUMENT_TYPE")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.GlobalReport)
                    .HasColumnName("GLOBAL_REPORT")
                    .HasMaxLength(1);

                entity.Property(e => e.Keycolumns)
                    .HasColumnName("KEYCOLUMNS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ObjNo).HasColumnName("OBJ_NO");

                entity.Property(e => e.ReportDescription)
                    .HasColumnName("REPORT_DESCRIPTION")
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('NO DESCRIPTION')");

                entity.Property(e => e.ReportName)
                    .HasColumnName("REPORT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportNode)
                    .HasColumnName("REPORT_NODE")
                    .HasMaxLength(512);

                entity.Property(e => e.ReportOpenIn)
                    .HasColumnName("REPORT_OPEN_IN")
                    .HasMaxLength(20);

                entity.Property(e => e.ReportOwner)
                    .HasColumnName("REPORT_OWNER")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportPassword)
                    .HasColumnName("REPORT_PASSWORD")
                    .HasMaxLength(20);

                entity.Property(e => e.ReportTable)
                    .HasColumnName("REPORT_TABLE")
                    .HasMaxLength(30);

                entity.Property(e => e.ReportType)
                    .IsRequired()
                    .HasColumnName("REPORT_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.ShowLimitations)
                    .HasColumnName("SHOW_LIMITATIONS")
                    .HasMaxLength(1);

                entity.Property(e => e.Sql).HasColumnName("SQL");

                entity.Property(e => e.UseMerging)
                    .HasColumnName("USE_MERGING")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<SaleSaleproject>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SALE_SALEPROJECT");

                entity.HasIndex(e => new { e.ObjNo, e.SaleProject })
                    .HasName("IDX_SALE_PROJECT_SALE_PROJECT");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalcObjNo).HasColumnName("CALC_OBJ_NO");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("CUSTOMER_REFERENCE")
                    .HasMaxLength(100);

                entity.Property(e => e.DecisionDate)
                    .HasColumnName("DECISION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FollowUp1).HasColumnName("FOLLOW_UP1");

                entity.Property(e => e.FollowUp2).HasColumnName("FOLLOW_UP2");

                entity.Property(e => e.FollowUp3).HasColumnName("FOLLOW_UP3");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectNotes).HasColumnName("PROJECT_NOTES");

                entity.Property(e => e.ProjectOrderLink).HasColumnName("PROJECT_ORDER_LINK");

                entity.Property(e => e.SaleAmount)
                    .HasColumnName("SALE_AMOUNT")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.SaleCustomer).HasColumnName("SALE_CUSTOMER");

                entity.Property(e => e.SaleDate)
                    .HasColumnName("SALE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleExpire).HasColumnName("SALE_EXPIRE");

                entity.Property(e => e.SaleExpiredate)
                    .HasColumnName("SALE_EXPIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleOwner)
                    .HasColumnName("SALE_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.SaleProbability).HasColumnName("SALE_PROBABILITY");

                entity.Property(e => e.SaleProfit)
                    .HasColumnName("SALE_PROFIT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaleProject)
                    .HasColumnName("SALE_PROJECT")
                    .HasMaxLength(255);

                entity.Property(e => e.SaleProjectNo)
                    .HasColumnName("SALE_PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.SaleCustomerNavigation)
                    .WithMany(p => p.SaleSaleproject)
                    .HasForeignKey(d => d.SaleCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALE_SALEPROJECT_CUSTOMER");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALESMAN");

                entity.HasIndex(e => new { e.Company, e.SalesmanCode })
                    .HasName("UQK_SALESMAN_COMPANY_SALESMAN_CODE")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.AreaObjNo).HasColumnName("AREA_OBJ_NO");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanCode)
                    .IsRequired()
                    .HasColumnName("SALESMAN_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.SalesmanName)
                    .HasColumnName("SALESMAN_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.HasOne(d => d.AreaObjNoNavigation)
                    .WithMany(p => p.Salesman)
                    .HasForeignKey(d => d.AreaObjNo)
                    .HasConstraintName("SALESMAN_AREA_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Salesman)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SALESMAN_COMPANY_FK");

                entity.HasOne(d => d.StockObjNoNavigation)
                    .WithMany(p => p.Salesman)
                    .HasForeignKey(d => d.StockObjNo)
                    .HasConstraintName("SALESMAN_STOCK_FK");
            });

            modelBuilder.Entity<SaleTask>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SALE_TASK");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IDX_SALE_TASK_EXTERNAL");

                entity.HasIndex(e => new { e.ObjNo, e.TaskSubject, e.TaskDateEnd, e.TaskOwner, e.TaskDateStart })
                    .HasName("IDX_SALE_TASK_DATE_START_INCLUDE");

                entity.HasIndex(e => new { e.ExternalId, e.TaskDateEnd, e.TaskDateStart, e.CreatedBy, e.TaskUseTime, e.TaskOwner, e.PrivateTask })
                    .HasName("IDX_SALE_TASK_EXTERNAL_STAR_END_CREATED_BY_USE_TIME_OWNER_PRIVATE");

                entity.HasIndex(e => new { e.CreatedBy, e.TaskSale, e.TaskCustomer, e.ObjNo, e.TaskDateStart, e.TaskReminder, e.TaskReminderDatetime, e.TaskOwner, e.ExternalId, e.TaskPriority })
                    .HasName("IDX_SALE_TASK_MANY");

                entity.HasIndex(e => new { e.TaskOwner, e.TaskCustomer, e.TaskDateStart, e.ObjNo, e.TaskSubject, e.TaskReminderDatetime, e.SendMail1, e.SendMail2, e.ExternalId, e.PrivateTask })
                    .HasName("IDX_SALE_TASK_REMINDER");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactNo)
                    .HasColumnName("CONTACT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNode)
                    .HasColumnName("CUSTOMER_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentObjNo).HasColumnName("PARENT_OBJ_NO");

                entity.Property(e => e.PrivateTask)
                    .HasColumnName("PRIVATE_TASK")
                    .HasMaxLength(1);

                entity.Property(e => e.RecurrenceObjNo).HasColumnName("RECURRENCE_OBJ_NO");

                entity.Property(e => e.SendMail1).HasColumnName("SEND_MAIL1");

                entity.Property(e => e.SendMail2).HasColumnName("SEND_MAIL2");

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.StatusText)
                    .HasColumnName("STATUS_TEXT")
                    .HasMaxLength(30);

                entity.Property(e => e.TaskCathegoryId)
                    .HasColumnName("TASK_CATHEGORY_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.TaskCompleted).HasColumnName("TASK_COMPLETED");

                entity.Property(e => e.TaskCustomer).HasColumnName("TASK_CUSTOMER");

                entity.Property(e => e.TaskDateEnd)
                    .HasColumnName("TASK_DATE_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskDateStart)
                    .HasColumnName("TASK_DATE_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskLevelId)
                    .HasColumnName("TASK_LEVEL_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.TaskNode)
                    .HasColumnName("TASK_NODE")
                    .HasMaxLength(830);

                entity.Property(e => e.TaskOwner)
                    .HasColumnName("TASK_OWNER")
                    .HasMaxLength(20);

                entity.Property(e => e.TaskPriority).HasColumnName("TASK_PRIORITY");

                entity.Property(e => e.TaskReminder).HasColumnName("TASK_REMINDER");

                entity.Property(e => e.TaskReminderDatetime)
                    .HasColumnName("TASK_REMINDER_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskReminderOpenIn)
                    .HasColumnName("TASK_REMINDER_OPEN_IN")
                    .HasMaxLength(1);

                entity.Property(e => e.TaskSale).HasColumnName("TASK_SALE");

                entity.Property(e => e.TaskSubject)
                    .IsRequired()
                    .HasColumnName("TASK_SUBJECT")
                    .HasMaxLength(255);

                entity.Property(e => e.TaskText)
                    .HasColumnName("TASK_TEXT")
                    .HasMaxLength(3000);

                entity.Property(e => e.TaskTypeid).HasColumnName("TASK_TYPEID");

                entity.Property(e => e.TaskUseTime).HasColumnName("TASK_USE_TIME");

                entity.Property(e => e.ToOthers)
                    .HasColumnName("TO_OTHERS")
                    .HasMaxLength(255);

                entity.Property(e => e.ToOthersReminder)
                    .HasColumnName("TO_OTHERS_REMINDER")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<SdVersion>(entity =>
            {
                entity.HasKey(e => e.ProductName);

                entity.ToTable("SD_VERSION");

                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(2000);

                entity.Property(e => e.VersionDate)
                    .HasColumnName("VERSION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.VersionNo)
                    .HasColumnName("VERSION_NO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SdVersionFiles>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("SD_VERSION_FILES");

                entity.Property(e => e.FileId).HasColumnName("FILE_ID");

                entity.Property(e => e.FileDate)
                    .HasColumnName("FILE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileTitle)
                    .HasColumnName("FILE_TITLE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ServicesArticles>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.ArticleType, e.ArticleObjNo });

                entity.ToTable("SERVICES_ARTICLES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleType)
                    .HasColumnName("ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.ArticleTypedef)
                    .HasColumnName("ARTICLE_TYPEDEF")
                    .HasMaxLength(2);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DefaultInMobile)
                    .HasColumnName("DEFAULT_IN_MOBILE")
                    .HasMaxLength(1);

                entity.Property(e => e.FixedTravelChk)
                    .HasColumnName("FIXED_TRAVEL_CHK")
                    .HasMaxLength(1);

                entity.Property(e => e.Hide)
                    .HasColumnName("HIDE")
                    .HasMaxLength(1);

                entity.Property(e => e.Invoiceable)
                    .HasColumnName("INVOICEABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.KmChk)
                    .HasColumnName("KM_CHK")
                    .HasMaxLength(1);

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(11, 5)");

                entity.Property(e => e.Rounding)
                    .HasColumnName("ROUNDING")
                    .HasMaxLength(15);

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.TravelTimeChk)
                    .HasColumnName("TRAVEL_TIME_CHK")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.ServicesArticles)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SA_ARTICLE_FK");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("STOCK");

                entity.HasIndex(e => new { e.Company, e.StockNo })
                    .HasName("UQK_STOCK_COMPANY_STOCK_NO")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(5);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.EMail1)
                    .HasColumnName("E_MAIL_1")
                    .HasMaxLength(70);

                entity.Property(e => e.MainStockObjNo).HasColumnName("MAIN_STOCK_OBJ_NO");

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(250);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalDescription)
                    .HasColumnName("POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.StockName)
                    .HasColumnName("STOCK_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasColumnName("STOCK_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.StockStatus)
                    .HasColumnName("STOCK_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STOCK_COMPANY_FK");
            });

            modelBuilder.Entity<StockAdminArticle>(entity =>
            {
                entity.HasKey(e => new { e.ArticleObjNo, e.StockObjNo });

                entity.ToTable("STOCK_ADMIN_ARTICLE");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.AmountOnStock)
                    .HasColumnName("AMOUNT_ON_STOCK")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50);

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("MAX_AMOUNT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MeanCostPrice)
                    .HasColumnName("MEAN_COST_PRICE")
                    .HasColumnType("numeric(25, 10)");

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("ORDER_AMOUNT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OrderPoint)
                    .HasColumnName("ORDER_POINT")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.StockAdminArticle)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STOCK_ADMIN_OPI_ARTICLE_FK");

                entity.HasOne(d => d.StockObjNoNavigation)
                    .WithMany(p => p.StockAdminArticle)
                    .HasForeignKey(d => d.StockObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STOCK_ADMIN_OPI_STOCK_FK");
            });

            modelBuilder.Entity<StockAdminArticleSerialNo>(entity =>
            {
                entity.HasKey(e => new { e.StockAdminOrderObjNo, e.StockAdminOrderLineNo, e.ArticleObjNo, e.SerialNo });

                entity.ToTable("STOCK_ADMIN_ARTICLE_SERIAL_NO");

                entity.HasIndex(e => new { e.Company, e.OrderNo, e.Status })
                    .HasName("IDX_STOCK_ADMIN_ARTICLE_ORDER_STATUS");

                entity.HasIndex(e => new { e.DeliveryDate, e.ArticleObjNo, e.SerialNo })
                    .HasName("ID_STOCK_ADMIN_AS_NO_ARTICLE_SERIAL");

                entity.HasIndex(e => new { e.StockAdminOrderObjNo, e.StockAdminOrderLineNo, e.ArticleObjNo, e.SerialNo, e.Company, e.Status })
                    .HasName("ID_STOCK_ADMIN_AS_NO_COMPANY_STATUS_INCLUDE");

                entity.Property(e => e.StockAdminOrderObjNo).HasColumnName("STOCK_ADMIN_ORDER_OBJ_NO");

                entity.Property(e => e.StockAdminOrderLineNo)
                    .HasColumnName("STOCK_ADMIN_ORDER_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.BinLocation)
                    .HasColumnName("BIN_LOCATION")
                    .HasMaxLength(200);

                entity.Property(e => e.CalcAvgCostPrice)
                    .HasColumnName("CALC_AVG_COST_PRICE")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DeliveryBatchObjNo).HasColumnName("DELIVERY_BATCH_OBJ_NO");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PackingSlipLineNo)
                    .HasColumnName("PACKING_SLIP_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.WarrantyLength)
                    .HasColumnName("WARRANTY_LENGTH")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.WarrantyStart)
                    .HasColumnName("WARRANTY_START")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<StockAdminHistory>(entity =>
            {
                entity.HasKey(e => new { e.DateHistory, e.StockObjNo, e.ArticleObjNo });

                entity.ToTable("STOCK_ADMIN_HISTORY");

                entity.Property(e => e.DateHistory)
                    .HasColumnName("DATE_HISTORY")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.QtyOnStock)
                    .HasColumnName("QTY_ON_STOCK")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.ValueOnStock)
                    .HasColumnName("VALUE_ON_STOCK")
                    .HasColumnType("numeric(25, 10)");
            });

            modelBuilder.Entity<StockAdminOrderHeading>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("STOCK_ADMIN_ORDER_HEADING");

                entity.HasIndex(e => new { e.Company, e.OrderNo })
                    .HasName("STOCK_ADMIN_ORDER_HEADING_COMPANY_ORDER_NO");

                entity.HasIndex(e => new { e.Company, e.ObjNo, e.OrderNo, e.OrderType })
                    .HasName("IDX_STOCK_ADMIN_ORDER_HEADING_COMPANY_ORDER_AND_TYPE");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(40);

                entity.Property(e => e.DelAddress1)
                    .HasColumnName("DEL_ADDRESS_1")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress2)
                    .HasColumnName("DEL_ADDRESS_2")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddress3)
                    .HasColumnName("DEL_ADDRESS_3")
                    .HasMaxLength(60);

                entity.Property(e => e.DelAddressName)
                    .HasColumnName("DEL_ADDRESS_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.DelContactName)
                    .HasColumnName("DEL_CONTACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.DelCountryNo)
                    .HasColumnName("DEL_COUNTRY_NO")
                    .HasMaxLength(5);

                entity.Property(e => e.DelCustomerObjNo).HasColumnName("DEL_CUSTOMER_OBJ_NO");

                entity.Property(e => e.DelFaxNo)
                    .HasColumnName("DEL_FAX_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.DelPhoneNo)
                    .HasColumnName("DEL_PHONE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.DelPostalCode)
                    .HasColumnName("DEL_POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DelPostalDescription)
                    .HasColumnName("DEL_POSTAL_DESCRIPTION")
                    .HasMaxLength(60);

                entity.Property(e => e.DelState)
                    .HasColumnName("DEL_STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDelivery)
                    .HasColumnName("DIRECT_DELIVERY")
                    .HasMaxLength(1);

                entity.Property(e => e.Information)
                    .HasColumnName("INFORMATION")
                    .HasMaxLength(2000);

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjDateCreate)
                    .HasColumnName("OBJ_DATE_CREATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusInformation)
                    .HasColumnName("STATUS_INFORMATION")
                    .HasMaxLength(2000);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.SuppliersOrderNo)
                    .HasColumnName("SUPPLIERS_ORDER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.UsernameCreate)
                    .HasColumnName("USERNAME_CREATE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<StockAdminOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.OrderObjNo, e.OrderLine });

                entity.ToTable("STOCK_ADMIN_ORDER_LINE");

                entity.HasIndex(e => e.OrderObjNo)
                    .HasName("IDX_STOCK_ADMIN_ORDER_OBJ_NO");

                entity.HasIndex(e => new { e.ArticleObjNo, e.AllReceived })
                    .HasName("IDX_STOCK_ADMIN_ORDER_LINE_ALL_RECEIVED");

                entity.HasIndex(e => new { e.SalesOrderNo, e.SalesOrderLineNo })
                    .HasName("IDX_STOCK_ADMIN_ORDER_LINE_LINKED_ORDER");

                entity.HasIndex(e => new { e.ProjectNo, e.TaskNo, e.AllReceived })
                    .HasName("IDX_STOCK_ADMIN_ALL_RECEIVED_PROJECT_TASK");

                entity.HasIndex(e => new { e.StockObjNo, e.ArticleObjNo, e.OrderObjNo })
                    .HasName("IDX_STOCK_ADMIN_ORDER_LINE_STOCK_ARTICLE_ORDER");

                entity.Property(e => e.OrderObjNo).HasColumnName("ORDER_OBJ_NO");

                entity.Property(e => e.OrderLine)
                    .HasColumnName("ORDER_LINE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AllReceived)
                    .HasColumnName("ALL_RECEIVED")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE2")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.EstimatedArrival)
                    .HasColumnName("ESTIMATED_ARRIVAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Express)
                    .HasColumnName("EXPRESS")
                    .HasMaxLength(1);

                entity.Property(e => e.LineProposalObjDate)
                    .HasColumnName("LINE_PROPOSAL_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineProposalUsername)
                    .HasColumnName("LINE_PROPOSAL_USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.LineSource)
                    .HasColumnName("LINE_SOURCE")
                    .HasMaxLength(2);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.MeansOfDelivery)
                    .HasColumnName("MEANS_OF_DELIVERY")
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaOrdered)
                    .HasColumnName("QTA_ORDERED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaReceived)
                    .HasColumnName("QTA_RECEIVED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ReplacementObjNo).HasColumnName("REPLACEMENT_OBJ_NO");

                entity.Property(e => e.ReturnReference)
                    .HasColumnName("RETURN_REFERENCE")
                    .HasMaxLength(9);

                entity.Property(e => e.ReturnType)
                    .HasColumnName("RETURN_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.ReturnedSerialNo)
                    .HasColumnName("RETURNED_SERIAL_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SalesOrderLineNo)
                    .HasColumnName("SALES_ORDER_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SalesOrderNo)
                    .HasColumnName("SALES_ORDER_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusInformation)
                    .HasColumnName("STATUS_INFORMATION")
                    .HasMaxLength(2000);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.SuppliersInvoiceNo)
                    .HasColumnName("SUPPLIERS_INVOICE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.HasOne(d => d.OrderObjNoNavigation)
                    .WithMany(p => p.StockAdminOrderLine)
                    .HasForeignKey(d => d.OrderObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STOCK_ADMIN_OL_OH_FK");
            });

            modelBuilder.Entity<StockAdminOrderLineReceived>(entity =>
            {
                entity.HasKey(e => new { e.OrderObjNo, e.OrderLine, e.ReceivedDate, e.PackingSlipNo, e.PackingSlipLineNo });

                entity.ToTable("STOCK_ADMIN_ORDER_LINE_RECEIVED");

                entity.Property(e => e.OrderObjNo).HasColumnName("ORDER_OBJ_NO");

                entity.Property(e => e.OrderLine)
                    .HasColumnName("ORDER_LINE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("RECEIVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackingSlipNo)
                    .HasColumnName("PACKING_SLIP_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PackingSlipLineNo)
                    .HasColumnName("PACKING_SLIP_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.DeliveryBatchObjNo).HasColumnName("DELIVERY_BATCH_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.QtaReceived)
                    .HasColumnName("QTA_RECEIVED")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.QtaRemaining)
                    .HasColumnName("QTA_REMAINING")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SyncTime)
                    .HasColumnName("SYNC_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<StockQty>(entity =>
            {
                entity.HasKey(e => new { e.ArticleObjNo, e.StockObjNo });

                entity.ToTable("STOCK_QTY");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.LastSalesDate)
                    .HasColumnName("LAST_SALES_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderLimit)
                    .HasColumnName("ORDER_LIMIT")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.QtyInOrder)
                    .HasColumnName("QTY_IN_ORDER")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtyInStock)
                    .HasColumnName("QTY_IN_STOCK")
                    .HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.StockObjNoNavigation)
                    .WithMany(p => p.StockQty)
                    .HasForeignKey(d => d.StockObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STOCK_QTY_STOCK_FK");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("SUPPLIER");

                entity.HasIndex(e => new { e.Company, e.ExternalId })
                    .HasName("IDX_SUPPLIER_EXTERNAL");

                entity.HasIndex(e => new { e.Company, e.ExternalId, e.ExternalSystemOn })
                    .HasName("IDX_SUPPLIER_EXTERNAL_ON");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.AddressRowNo)
                    .HasColumnName("ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AllowExportToFile)
                    .HasColumnName("ALLOW_EXPORT_TO_FILE")
                    .HasMaxLength(1);

                entity.Property(e => e.ArticleSupplier).HasColumnName("ARTICLE_SUPPLIER");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Discount2)
                    .HasColumnName("DISCOUNT_2")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.ExportToFileSp)
                    .HasColumnName("EXPORT_TO_FILE_SP")
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalSystemOn)
                    .HasColumnName("EXTERNAL_SYSTEM_ON")
                    .HasMaxLength(1);

                entity.Property(e => e.FtpFilename)
                    .HasColumnName("FTP_FILENAME")
                    .HasMaxLength(250);

                entity.Property(e => e.FtpHostname)
                    .HasColumnName("FTP_HOSTNAME")
                    .HasMaxLength(250);

                entity.Property(e => e.FtpPassiveMode)
                    .HasColumnName("FTP_PASSIVE_MODE")
                    .HasMaxLength(1);

                entity.Property(e => e.FtpPassword)
                    .HasColumnName("FTP_PASSWORD")
                    .HasMaxLength(100);

                entity.Property(e => e.FtpPort)
                    .HasColumnName("FTP_PORT")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.FtpProxy)
                    .HasColumnName("FTP_PROXY")
                    .HasMaxLength(250);

                entity.Property(e => e.FtpRelativeDirectory)
                    .HasColumnName("FTP_RELATIVE_DIRECTORY")
                    .HasMaxLength(250);

                entity.Property(e => e.FtpUser)
                    .HasColumnName("FTP_USER")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAddressRowNo)
                    .HasColumnName("INVOICE_ADDRESS_ROW_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LeasingSupplier).HasColumnName("LEASING_SUPPLIER");

                entity.Property(e => e.MinOrderTotal)
                    .HasColumnName("MIN_ORDER_TOTAL")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.OwnCustomerNo)
                    .HasColumnName("OWN_CUSTOMER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.RentalSupplier).HasColumnName("RENTAL_SUPPLIER");

                entity.Property(e => e.SalesmanProvisionPercent)
                    .HasColumnName("SALESMAN_PROVISION_PERCENT")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.SendFileWithFtp)
                    .HasColumnName("SEND_FILE_WITH_FTP")
                    .HasMaxLength(1);

                entity.Property(e => e.SupplierInfo)
                    .HasColumnName("SUPPLIER_INFO")
                    .HasMaxLength(1500);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.SupplierNo)
                    .HasColumnName("SUPPLIER_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SupplierProvisionFactor)
                    .HasColumnName("SUPPLIER_PROVISION_FACTOR")
                    .HasColumnType("decimal(10, 5)");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SUPPLIER_COMPANY_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .HasConstraintName("SUPPLIER_CUSTOMER_FK");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => new { d.CustomerObjNo, d.InvoiceAddressRowNo })
                    .HasConstraintName("SUPPLIER_CUSTOMER_ADDRESS_FK");
            });

            modelBuilder.Entity<SupplierDept>(entity =>
            {
                entity.HasKey(e => new { e.SupplierObjNo, e.Company, e.Dept });

                entity.ToTable("SUPPLIER_DEPT");

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupplierObjNoNavigation)
                    .WithMany(p => p.SupplierDept)
                    .HasForeignKey(d => d.SupplierObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUPPLIER_DEPT_SUPPLIER");
            });

            modelBuilder.Entity<SupplierOrderHeading>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.InvoiceNo, e.SupplierObjNo, e.OrderObjNo });

                entity.ToTable("SUPPLIER_ORDER_HEADING");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.OrderObjNo).HasColumnName("ORDER_OBJ_NO");

                entity.Property(e => e.CreditTerm).HasColumnName("CREDIT_TERM");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<SupplierOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.InvoiceNo, e.SupplierObjNo, e.OrderObjNo, e.LineNo });

                entity.ToTable("SUPPLIER_ORDER_LINE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SupplierObjNo).HasColumnName("SUPPLIER_OBJ_NO");

                entity.Property(e => e.OrderObjNo).HasColumnName("ORDER_OBJ_NO");

                entity.Property(e => e.LineNo)
                    .HasColumnName("LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountCostPrice)
                    .HasColumnName("DISCOUNT_COST_PRICE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiscountCostPrice2)
                    .HasColumnName("DISCOUNT_COST_PRICE_2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.OrderLineNo)
                    .HasColumnName("ORDER_LINE_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.WarrantyLength)
                    .HasColumnName("WARRANTY_LENGTH")
                    .HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.SupplierOrderHeading)
                    .WithMany(p => p.SupplierOrderLine)
                    .HasForeignKey(d => new { d.Company, d.InvoiceNo, d.SupplierObjNo, d.OrderObjNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SUOH_SUOL_FK");
            });

            modelBuilder.Entity<SymptomCode>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Registry, e.Code });

                entity.ToTable("SYMPTOM_CODE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);

                entity.Property(e => e.Inactive).HasColumnName("INACTIVE");

                entity.Property(e => e.PriorityCode)
                    .HasColumnName("PRIORITY_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponseTimeCalc)
                    .HasColumnName("RESPONSE_TIME_CALC")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<SymptomCodeDefaultNode>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.Registry, e.Code, e.NodeType });

                entity.ToTable("SYMPTOM_CODE_DEFAULT_NODE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registry)
                    .HasColumnName("REGISTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.NodeType)
                    .HasColumnName("NODE_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(890)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("TEAM");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TeamCode)
                    .IsRequired()
                    .HasColumnName("TEAM_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamDescription)
                    .HasColumnName("TEAM_DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamOwner).HasColumnName("TEAM_OWNER");

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<TeamNodes>(entity =>
            {
                entity.HasKey(e => new { e.TeamObjNo, e.Node });

                entity.ToTable("TEAM_NODES");

                entity.Property(e => e.TeamObjNo).HasColumnName("TEAM_OBJ_NO");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.HasOne(d => d.TeamObjNoNavigation)
                    .WithMany(p => p.TeamNodes)
                    .HasForeignKey(d => d.TeamObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TEAM_NODES_FK");
            });

            modelBuilder.Entity<Technician>(entity =>
            {
                entity.HasKey(e => e.ObjNo);

                entity.ToTable("TECHNICIAN");

                entity.HasIndex(e => new { e.Company, e.Dept, e.TechnicianNo })
                    .HasName("UQK_TECHNICIAN_COMPANY_DEPT_TECHNICIAN_NO")
                    .IsUnique();

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutosyncArticleData)
                    .HasColumnName("AUTOSYNC_ARTICLE_DATA")
                    .HasMaxLength(1);

                entity.Property(e => e.AutosyncBasicData)
                    .HasColumnName("AUTOSYNC_BASIC_DATA")
                    .HasMaxLength(1);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CoordX)
                    .HasColumnName("COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CoordY)
                    .HasColumnName("COORD_Y")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpFunction)
                    .HasColumnName("EMP_FUNCTION")
                    .HasMaxLength(9);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.GpsCoordX)
                    .HasColumnName("GPS_COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.GpsCoordY)
                    .HasColumnName("GPS_COORD_Y")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.GpsObjDate)
                    .HasColumnName("GPS_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Info01)
                    .HasColumnName("INFO_01")
                    .HasMaxLength(100);

                entity.Property(e => e.Info02)
                    .HasColumnName("INFO_02")
                    .HasMaxLength(100);

                entity.Property(e => e.Info03)
                    .HasColumnName("INFO_03")
                    .HasMaxLength(100);

                entity.Property(e => e.Info04)
                    .HasColumnName("INFO_04")
                    .HasMaxLength(100);

                entity.Property(e => e.Info05)
                    .HasColumnName("INFO_05")
                    .HasMaxLength(100);

                entity.Property(e => e.Info06)
                    .HasColumnName("INFO_06")
                    .HasMaxLength(100);

                entity.Property(e => e.Info07)
                    .HasColumnName("INFO_07")
                    .HasMaxLength(100);

                entity.Property(e => e.Info08)
                    .HasColumnName("INFO_08")
                    .HasMaxLength(100);

                entity.Property(e => e.Info09)
                    .HasColumnName("INFO_09")
                    .HasMaxLength(100);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO_10")
                    .HasMaxLength(100);

                entity.Property(e => e.LastMobileActionObjDate)
                    .HasColumnName("LAST_MOBILE_ACTION_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Layout).HasColumnName("LAYOUT");

                entity.Property(e => e.MobileCreateProject).HasColumnName("MOBILE_CREATE_PROJECT");

                entity.Property(e => e.MobileMachineEdit).HasColumnName("MOBILE_MACHINE_EDIT");

                entity.Property(e => e.MobilePassword)
                    .HasColumnName("MOBILE_PASSWORD")
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhoneNo)
                    .HasColumnName("MOBILE_PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.MobilePlannerMode).HasColumnName("MOBILE_PLANNER_MODE");

                entity.Property(e => e.MsgObjDate)
                    .HasColumnName("MSG_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsgObjDateIn)
                    .HasColumnName("MSG_OBJ_DATE_IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsgText)
                    .HasColumnName("MSG_TEXT")
                    .HasMaxLength(1000);

                entity.Property(e => e.MsgTextIn)
                    .HasColumnName("MSG_TEXT_IN")
                    .HasMaxLength(1000);

                entity.Property(e => e.MsgTextRead)
                    .HasColumnName("MSG_TEXT_READ")
                    .HasMaxLength(1);

                entity.Property(e => e.MsgUsername)
                    .HasColumnName("MSG_USERNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MsgUsernameIn)
                    .HasColumnName("MSG_USERNAME_IN")
                    .HasMaxLength(50);

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(870)
                    .IsUnicode(false);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ResponsibleTechnicianObjNo).HasColumnName("RESPONSIBLE_TECHNICIAN_OBJ_NO");

                entity.Property(e => e.SalesmanObjNo).HasColumnName("SALESMAN_OBJ_NO");

                entity.Property(e => e.ShowPriorityAlertMessage)
                    .HasColumnName("SHOW_PRIORITY_ALERT_MESSAGE")
                    .HasMaxLength(1);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StockObjNo).HasColumnName("STOCK_OBJ_NO");

                entity.Property(e => e.SupportAdministrator)
                    .HasColumnName("SUPPORT_ADMINISTRATOR")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowChangeNode)
                    .HasColumnName("SUPPORT_ALLOW_CHANGE_NODE")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowDelete)
                    .HasColumnName("SUPPORT_ALLOW_DELETE")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowNotSolved)
                    .HasColumnName("SUPPORT_ALLOW_NOT_SOLVED")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowSeeAssignedTasks)
                    .HasColumnName("SUPPORT_ALLOW_SEE_ASSIGNED_TASKS")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowSeeAssignedTasksOthers)
                    .HasColumnName("SUPPORT_ALLOW_SEE_ASSIGNED_TASKS_OTHERS")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowSort)
                    .HasColumnName("SUPPORT_ALLOW_SORT")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportAllowToAssignOther)
                    .HasColumnName("SUPPORT_ALLOW_TO_ASSIGN_OTHER")
                    .HasMaxLength(1);

                entity.Property(e => e.SupportMaximumNumberOfTasks)
                    .HasColumnName("SUPPORT_MAXIMUM_NUMBER_OF_TASKS")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SupportMaximumNumberOfTasksEachGroup)
                    .HasColumnName("SUPPORT_MAXIMUM_NUMBER_OF_TASKS_EACH_GROUP")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.SupportNode)
                    .HasColumnName("SUPPORT_NODE")
                    .HasMaxLength(890);

                entity.Property(e => e.SupportShowOnHold)
                    .HasColumnName("SUPPORT_SHOW_ON_HOLD")
                    .HasMaxLength(1);

                entity.Property(e => e.TechnicianName)
                    .IsRequired()
                    .HasColumnName("TECHNICIAN_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.TechnicianNo)
                    .IsRequired()
                    .HasColumnName("TECHNICIAN_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.UseMobile).HasColumnName("USE_MOBILE");

                entity.Property(e => e.UseMobileEma).HasColumnName("USE_MOBILE_EMA");

                entity.Property(e => e.UseMobileEmw).HasColumnName("USE_MOBILE_EMW");

                entity.Property(e => e.UseMobilePc).HasColumnName("USE_MOBILE_PC");

                entity.Property(e => e.UseMobilePhone).HasColumnName("USE_MOBILE_PHONE");

                entity.Property(e => e.UseMobileTomtom).HasColumnName("USE_MOBILE_TOMTOM");

                entity.Property(e => e.UserIdentityId).HasColumnName("USER_IDENTITY_ID");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.WorkStatus)
                    .HasColumnName("WORK_STATUS")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkStatusObjDate)
                    .HasColumnName("WORK_STATUS_OBJ_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Technician)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_COMPANY_FK");

                entity.HasOne(d => d.SalesmanObjNoNavigation)
                    .WithMany(p => p.Technician)
                    .HasForeignKey(d => d.SalesmanObjNo)
                    .HasConstraintName("TECHNICIAN_SALESMAN_FK");

                entity.HasOne(d => d.StockObjNoNavigation)
                    .WithMany(p => p.Technician)
                    .HasForeignKey(d => d.StockObjNo)
                    .HasConstraintName("TECHNICIAN_STOCK_FK");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.Technician)
                    .HasForeignKey(d => d.UserIdentityId)
                    .HasConstraintName("TECHNICIAN_USER_IDENTITY_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Technician)
                    .HasForeignKey(d => new { d.Company, d.Dept })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_DEPT_FK");
            });

            modelBuilder.Entity<TechnicianAvailability>(entity =>
            {
                entity.HasKey(e => new { e.AvailNo, e.TechnicianObjNo, e.DateFrom });

                entity.ToTable("TECHNICIAN_AVAILABILITY");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.DateFrom })
                    .HasName("IDX_TECHNICIAN_AVAILABILITY");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.ExternalId })
                    .HasName("IDX_TECHNICIAN_AVAILABILITY_EXERNAL");

                entity.HasIndex(e => new { e.TechnicianObjNo, e.AvailabilityType, e.DateFrom, e.ExternalId, e.BarText, e.Duration, e.AvailNo })
                    .HasName("IDX_TECHNICIAN_AVAILBILITYON");

                entity.Property(e => e.AvailNo)
                    .HasColumnName("AVAIL_NO")
                    .HasColumnType("numeric(9, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvailabilityType)
                    .HasColumnName("AVAILABILITY_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.BarText)
                    .HasColumnName("BAR_TEXT")
                    .HasMaxLength(255);

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianAvailability)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_AVAILABILITY_TECH_FK");
            });

            modelBuilder.Entity<TechnicianAvailabilityType>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.Code });

                entity.ToTable("TECHNICIAN_AVAILABILITY_TYPE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TechnicianCompetence>(entity =>
            {
                entity.HasKey(e => new { e.CompetenceGroupObjNo, e.TechnicianObjNo });

                entity.ToTable("TECHNICIAN_COMPETENCE");

                entity.Property(e => e.CompetenceGroupObjNo).HasColumnName("COMPETENCE_GROUP_OBJ_NO");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.HasOne(d => d.CompetenceGroupObjNoNavigation)
                    .WithMany(p => p.TechnicianCompetence)
                    .HasForeignKey(d => d.CompetenceGroupObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECH_COMPETENCE_GROUP_FK");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianCompetence)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECH_COMPETENCE_TECH_FK");
            });

            modelBuilder.Entity<TechnicianGpsCoordinates>(entity =>
            {
                entity.HasKey(e => new { e.TechnicianObjNo, e.ObjDate });

                entity.ToTable("TECHNICIAN_GPS_COORDINATES");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoordX)
                    .HasColumnName("COORD_X")
                    .HasColumnType("numeric(20, 10)");

                entity.Property(e => e.CoordY)
                    .HasColumnName("COORD_Y")
                    .HasColumnType("numeric(20, 10)");
            });

            modelBuilder.Entity<TechnicianPlannerNode>(entity =>
            {
                entity.HasKey(e => new { e.TechnicianObjNo, e.Node });

                entity.ToTable("TECHNICIAN_PLANNER_NODE");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianPlannerNode)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TPN_TECH_FK");
            });

            modelBuilder.Entity<TechnicianPushLog>(entity =>
            {
                entity.ToTable("TECHNICIAN_PUSH_LOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.PushBadge).HasColumnName("PUSH_BADGE");

                entity.Property(e => e.PushTime)
                    .HasColumnName("PUSH_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PushType).HasColumnName("PUSH_TYPE");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianPushLog)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TECHNICIAN_PUSH_LOG_TECHNICIAN");
            });

            modelBuilder.Entity<TechnicianPushToken>(entity =>
            {
                entity.ToTable("TECHNICIAN_PUSH_TOKEN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GpsTracking)
                    .IsRequired()
                    .HasColumnName("GPS_TRACKING")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Language)
                    .HasColumnName("LANGUAGE")
                    .HasMaxLength(10);

                entity.Property(e => e.ObjDate)
                    .HasColumnName("OBJ_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnName("PLATFORM")
                    .HasMaxLength(20);

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("TOKEN");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianPushToken)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TECHNICIAN_PUSH_TOKEN_TECHNICIAN");
            });

            modelBuilder.Entity<TechnicianServicesArticles>(entity =>
            {
                entity.HasKey(e => new { e.TechnicianObjNo, e.ArticleType });

                entity.ToTable("TECHNICIAN_SERVICES_ARTICLES");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.ArticleType)
                    .HasColumnName("ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.HourReg)
                    .HasColumnName("HOUR_REG")
                    .HasMaxLength(1);

                entity.Property(e => e.UseAsDefault)
                    .HasColumnName("USE_AS_DEFAULT")
                    .HasMaxLength(1);

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianServicesArticles)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_SA_TECH_FK");
            });

            modelBuilder.Entity<TechnicianServicesArticlesPrice>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.ArticleType, e.ArticleTypedef, e.TechnicianObjNo });

                entity.ToTable("TECHNICIAN_SERVICES_ARTICLES_PRICE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleType)
                    .HasColumnName("ARTICLE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ArticleTypedef)
                    .HasColumnName("ARTICLE_TYPEDEF")
                    .HasMaxLength(2);

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianServicesArticlesPrice)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_SERVICES_ARTICLES_PRICE_TECHNICIAN_FK");
            });

            modelBuilder.Entity<TechnicianTeams>(entity =>
            {
                entity.HasKey(e => new { e.TechnicianObjNo, e.TeamObjNo, e.Type });

                entity.ToTable("TECHNICIAN_TEAMS");

                entity.Property(e => e.TechnicianObjNo).HasColumnName("TECHNICIAN_OBJ_NO");

                entity.Property(e => e.TeamObjNo).HasColumnName("TEAM_OBJ_NO");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.TeamObjNoNavigation)
                    .WithMany(p => p.TechnicianTeams)
                    .HasForeignKey(d => d.TeamObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_TEAMS_TEAM_FK");

                entity.HasOne(d => d.TechnicianObjNoNavigation)
                    .WithMany(p => p.TechnicianTeams)
                    .HasForeignKey(d => d.TechnicianObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TECHNICIAN_TEAMS_TECHNICIAN_FK");
            });

            modelBuilder.Entity<TempOldCheckListValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Code, e.LineObjNo });

                entity.ToTable("TEMP_OLD_CHECK_LIST_VALUES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.LineObjNo).HasColumnName("LINE_OBJ_NO");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.LineNo).HasColumnName("LINE_NO");

                entity.Property(e => e.Mandatory)
                    .HasColumnName("MANDATORY")
                    .HasMaxLength(1);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.TempOldCheckListValues)
                    .HasForeignKey(d => new { d.Company, d.Code })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CHECK_LIST_VALUES_FK");
            });

            modelBuilder.Entity<TempOldProjectTaskCheckListValues>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ProjectNo, e.TaskNo, e.ResourceObjNo, e.CheckListLineObjNo });

                entity.ToTable("TEMP_OLD_PROJECT_TASK_CHECK_LIST_VALUES");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ResourceObjNo).HasColumnName("RESOURCE_OBJ_NO");

                entity.Property(e => e.CheckListLineObjNo).HasColumnName("CHECK_LIST_LINE_OBJ_NO");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(250);

                entity.Property(e => e.Diff)
                    .HasColumnName("DIFF")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tree>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.Dept, e.TreeName, e.NodeKey });

                entity.ToTable("TREE");

                entity.HasIndex(e => new { e.TreeName, e.Company, e.Dept, e.SourceObjNo })
                    .HasName("IDX_TREE");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("DEPT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TreeName)
                    .HasColumnName("TREE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodeKey)
                    .HasColumnName("NODE_KEY")
                    .HasMaxLength(830)
                    .IsUnicode(false);

                entity.Property(e => e.NodeLevel)
                    .HasColumnName("NODE_LEVEL")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NodeTag)
                    .HasColumnName("NODE_TAG")
                    .HasMaxLength(800);

                entity.Property(e => e.NodeText)
                    .IsRequired()
                    .HasColumnName("NODE_TEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentKey)
                    .IsRequired()
                    .HasColumnName("PARENT_KEY")
                    .HasMaxLength(890);

                entity.Property(e => e.SourceObjNo).HasColumnName("SOURCE_OBJ_NO");

                entity.Property(e => e.TreeLevel)
                    .HasColumnName("TREE_LEVEL")
                    .HasColumnType("numeric(5, 0)");
            });

            modelBuilder.Entity<UserIdentity>(entity =>
            {
                entity.ToTable("USER_IDENTITY");

                entity.HasIndex(e => e.Email)
                    .HasName("UIX_USER_IDENTITY_EMAIL")
                    .IsUnique();

                entity.Property(e => e.UserIdentityId).HasColumnName("USER_IDENTITY_ID");

                entity.Property(e => e.AppUserLoginName)
                    .HasColumnName("APP_USER_LOGIN_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("PASSWORD_HASH")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordResetRequestedOn)
                    .HasColumnName("PASSWORD_RESET_REQUESTED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.PasswordResetToken)
                    .HasColumnName("PASSWORD_RESET_TOKEN")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AppUserLoginNameNavigation)
                    .WithMany(p => p.UserIdentity)
                    .HasForeignKey(d => d.AppUserLoginName)
                    .HasConstraintName("USER_IDENTITY_APP_USER_FK");
            });

            modelBuilder.Entity<VolumeHistory>(entity =>
            {
                entity.HasKey(e => new { e.CmdObjNo, e.DateChanged });

                entity.ToTable("VOLUME_HISTORY");

                entity.Property(e => e.CmdObjNo).HasColumnName("CMD_OBJ_NO");

                entity.Property(e => e.DateChanged)
                    .HasColumnName("DATE_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("decimal(25, 10)");
            });

            modelBuilder.Entity<Warranty>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.WarrantyNo });

                entity.ToTable("WARRANTY");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyNo)
                    .HasColumnName("WARRANTY_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Accepted).HasColumnName("ACCEPTED");

                entity.Property(e => e.ArticleCounter)
                    .HasColumnName("ARTICLE_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ArticleInstallationDate)
                    .HasColumnName("ARTICLE_INSTALLATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArticleObjNo).HasColumnName("ARTICLE_OBJ_NO");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500);

                entity.Property(e => e.CommentIn)
                    .HasColumnName("COMMENT_IN")
                    .HasMaxLength(500);

                entity.Property(e => e.CommentOut)
                    .HasColumnName("COMMENT_OUT")
                    .HasMaxLength(500);

                entity.Property(e => e.Compensation).HasColumnName("COMPENSATION");

                entity.Property(e => e.CompensationProcessed).HasColumnName("COMPENSATION_PROCESSED");

                entity.Property(e => e.CompensationTransport)
                    .HasColumnName("COMPENSATION_TRANSPORT")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CompensationWork)
                    .HasColumnName("COMPENSATION_WORK")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.CustomerObjNo).HasColumnName("CUSTOMER_OBJ_NO");

                entity.Property(e => e.Info1)
                    .HasColumnName("INFO_1")
                    .HasMaxLength(100);

                entity.Property(e => e.Info2)
                    .HasColumnName("INFO_2")
                    .HasMaxLength(100);

                entity.Property(e => e.Info3)
                    .HasColumnName("INFO_3")
                    .HasMaxLength(100);

                entity.Property(e => e.Info4)
                    .HasColumnName("INFO_4")
                    .HasMaxLength(100);

                entity.Property(e => e.Info5)
                    .HasColumnName("INFO_5")
                    .HasMaxLength(100);

                entity.Property(e => e.InstallationDate)
                    .HasColumnName("INSTALLATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceNoCustomer)
                    .HasColumnName("INVOICE_NO_CUSTOMER")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineCounter)
                    .HasColumnName("MACHINE_COUNTER")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("MACHINE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineObjNo).HasColumnName("MACHINE_OBJ_NO");

                entity.Property(e => e.ModelType)
                    .IsRequired()
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.PartReceived)
                    .HasColumnName("PART_RECEIVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartSent)
                    .HasColumnName("PART_SENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("PROJECT_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("PURCHASE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("REGISTRATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rma).HasColumnName("RMA");

                entity.Property(e => e.RmaNo)
                    .HasColumnName("RMA_NO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SalesPrice)
                    .HasColumnName("SALES_PRICE")
                    .HasColumnType("decimal(25, 10)");

                entity.Property(e => e.SerialNoNew)
                    .HasColumnName("SERIAL_NO_NEW")
                    .HasMaxLength(50);

                entity.Property(e => e.SerialNoOld)
                    .HasColumnName("SERIAL_NO_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.Sortgroup1)
                    .HasColumnName("SORTGROUP_1")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup2)
                    .HasColumnName("SORTGROUP_2")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup3)
                    .HasColumnName("SORTGROUP_3")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup4)
                    .HasColumnName("SORTGROUP_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Sortgroup5)
                    .HasColumnName("SORTGROUP_5")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.StatusInternal)
                    .HasColumnName("STATUS_INTERNAL")
                    .HasMaxLength(10);

                entity.Property(e => e.StatusProducer)
                    .HasColumnName("STATUS_PRODUCER")
                    .HasMaxLength(1);

                entity.Property(e => e.SymptomText)
                    .HasColumnName("SYMPTOM_TEXT")
                    .HasMaxLength(1000);

                entity.Property(e => e.TaskNo)
                    .HasColumnName("TASK_NO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.WarrantyDate)
                    .HasColumnName("WARRANTY_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ArticleObjNoNavigation)
                    .WithMany(p => p.Warranty)
                    .HasForeignKey(d => d.ArticleObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WARRANTY_ARTICLE_FK");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Warranty)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WARRANTY_COMPANY_FK");

                entity.HasOne(d => d.CustomerObjNoNavigation)
                    .WithMany(p => p.Warranty)
                    .HasForeignKey(d => d.CustomerObjNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WARRANTY_CUSTOMER_FK");
            });

            modelBuilder.Entity<WebErrorLogins>(entity =>
            {
                entity.HasKey(e => e.ObjNo)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("WEB_ERROR_LOGINS");

                entity.Property(e => e.ObjNo)
                    .HasColumnName("OBJ_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginTime)
                    .HasColumnName("LOGIN_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WebFieldHelpText>(entity =>
            {
                entity.ToTable("WEB_FIELD_HELP_TEXT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("BODY")
                    .HasMaxLength(2048);

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasColumnName("FIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("PAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(255);
            });
        }
    }
}