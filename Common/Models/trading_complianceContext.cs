using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Common.Models
{
    public partial class trading_complianceContext : DbContext
    {
        public trading_complianceContext()
        {
        }

        public trading_complianceContext(DbContextOptions<trading_complianceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adcvd> Adcvds { get; set; } = null!;
        public virtual DbSet<AdcvdCaseMap> AdcvdCaseMaps { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<CollaboratorCompany> CollaboratorCompanies { get; set; } = null!;
        public virtual DbSet<CollaboratorRequestItem> CollaboratorRequestItems { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyLicenceMap> CompanyLicenceMaps { get; set; } = null!;
        public virtual DbSet<ComplianceCompany> ComplianceCompanies { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ControlClassMap> ControlClassMaps { get; set; } = null!;
        public virtual DbSet<ControlCountryMap> ControlCountryMaps { get; set; } = null!;
        public virtual DbSet<CountryList> CountryLists { get; set; } = null!;
        public virtual DbSet<CurrencyCodeList> CurrencyCodeLists { get; set; } = null!;
        public virtual DbSet<DecisionConfiguration> DecisionConfigurations { get; set; } = null!;
        public virtual DbSet<DocInfo> DocInfos { get; set; } = null!;
        public virtual DbSet<Eccn> Eccns { get; set; } = null!;
        public virtual DbSet<EntityProcessing> EntityProcessings { get; set; } = null!;
        public virtual DbSet<EntityProcessingDatum> EntityProcessingData { get; set; } = null!;
        public virtual DbSet<EntityProcessingMessage> EntityProcessingMessages { get; set; } = null!;
        public virtual DbSet<EntityProcessingQueueConfig> EntityProcessingQueueConfigs { get; set; } = null!;
        public virtual DbSet<EntityProcessingQueueItem> EntityProcessingQueueItems { get; set; } = null!;
        public virtual DbSet<ExceptionClassMap> ExceptionClassMaps { get; set; } = null!;
        public virtual DbSet<ExceptionCountryMap> ExceptionCountryMaps { get; set; } = null!;
        public virtual DbSet<ExportConfiguration> ExportConfigurations { get; set; } = null!;
        public virtual DbSet<ExportControlCode> ExportControlCodes { get; set; } = null!;
        public virtual DbSet<ExportGaControlCode> ExportGaControlCodes { get; set; } = null!;
        public virtual DbSet<ExportGaFormMap> ExportGaFormMaps { get; set; } = null!;
        public virtual DbSet<ExportH> ExportHs { get; set; } = null!;
        public virtual DbSet<ExportHsConfiguration> ExportHsConfigurations { get; set; } = null!;
        public virtual DbSet<ExportLicenseExceptionCode> ExportLicenseExceptionCodes { get; set; } = null!;
        public virtual DbSet<ExportLicenseMgmt> ExportLicenseMgmts { get; set; } = null!;
        public virtual DbSet<ExportLicenseReservation> ExportLicenseReservations { get; set; } = null!;
        public virtual DbSet<ExportShipment> ExportShipments { get; set; } = null!;
        public virtual DbSet<ExportShipmentLine> ExportShipmentLines { get; set; } = null!;
        public virtual DbSet<ExportShipmentLineControl> ExportShipmentLineControls { get; set; } = null!;
        public virtual DbSet<ExportShipmentLineGaDatum> ExportShipmentLineGaData { get; set; } = null!;
        public virtual DbSet<ExportShipmentLineLicense> ExportShipmentLineLicenses { get; set; } = null!;
        public virtual DbSet<ExportShipmentLineLicenseException> ExportShipmentLineLicenseExceptions { get; set; } = null!;
        public virtual DbSet<ExportShipmentParty> ExportShipmentParties { get; set; } = null!;
        public virtual DbSet<FlywaySchemaHistory> FlywaySchemaHistories { get; set; } = null!;
        public virtual DbSet<Gpa> Gpas { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GroupResourceMap> GroupResourceMaps { get; set; } = null!;
        public virtual DbSet<HsDuty> HsDuties { get; set; } = null!;
        public virtual DbSet<HsSpiDuty> HsSpiDuties { get; set; } = null!;
        public virtual DbSet<HsTariffMap> HsTariffMaps { get; set; } = null!;
        public virtual DbSet<HstariffMap1> HstariffMaps1 { get; set; } = null!;
        public virtual DbSet<ImportControlCode> ImportControlCodes { get; set; } = null!;
        public virtual DbSet<Label> Labels { get; set; } = null!;
        public virtual DbSet<LabelTranslation> LabelTranslations { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Licence> Licences { get; set; } = null!;
        public virtual DbSet<LicenceGroupMap> LicenceGroupMaps { get; set; } = null!;
        public virtual DbSet<OgaDeterminationConfig> OgaDeterminationConfigs { get; set; } = null!;
        public virtual DbSet<PartyType> PartyTypes { get; set; } = null!;
        public virtual DbSet<PgaFormMap> PgaFormMaps { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductAd> ProductAds { get; set; } = null!;
        public virtual DbSet<ProductExportClass> ProductExportClasses { get; set; } = null!;
        public virtual DbSet<ProductExportControl> ProductExportControls { get; set; } = null!;
        public virtual DbSet<ProductExportDataTest> ProductExportDataTests { get; set; } = null!;
        public virtual DbSet<ProductExportDatum> ProductExportData { get; set; } = null!;
        public virtual DbSet<ProductExportDestination> ProductExportDestinations { get; set; } = null!;
        public virtual DbSet<ProductExportGaDatum> ProductExportGaData { get; set; } = null!;
        public virtual DbSet<ProductExportLicense> ProductExportLicenses { get; set; } = null!;
        public virtual DbSet<ProductExportLicenseException> ProductExportLicenseExceptions { get; set; } = null!;
        public virtual DbSet<ProductImportClass> ProductImportClasses { get; set; } = null!;
        public virtual DbSet<ProductImportDatum> ProductImportData { get; set; } = null!;
        public virtual DbSet<ProductPga> ProductPgas { get; set; } = null!;
        public virtual DbSet<ProductPgaDatum> ProductPgaData { get; set; } = null!;
        public virtual DbSet<ProductSourcing> ProductSourcings { get; set; } = null!;
        public virtual DbSet<ProductSourcingAdCvdRate> ProductSourcingAdCvdRates { get; set; } = null!;
        public virtual DbSet<ProductSourcingValueAdjustment> ProductSourcingValueAdjustments { get; set; } = null!;
        public virtual DbSet<ProductSpi> ProductSpis { get; set; } = null!;
        public virtual DbSet<Resource> Resources { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleGroupMap> RoleGroupMaps { get; set; } = null!;
        public virtual DbSet<RplEntity> RplEntities { get; set; } = null!;
        public virtual DbSet<RplEntityAddress> RplEntityAddresses { get; set; } = null!;
        public virtual DbSet<RplEntityName> RplEntityNames { get; set; } = null!;
        public virtual DbSet<RpsResult> RpsResults { get; set; } = null!;
        public virtual DbSet<RpsResultsDetail> RpsResultsDetails { get; set; } = null!;
        public virtual DbSet<SchedulerTask> SchedulerTasks { get; set; } = null!;
        public virtual DbSet<SchemaVersionEntityprocessing> SchemaVersionEntityprocessings { get; set; } = null!;
        public virtual DbSet<Shipment> Shipments { get; set; } = null!;
        public virtual DbSet<ShipmentExportDatum> ShipmentExportData { get; set; } = null!;
        public virtual DbSet<ShipmentImportDatum> ShipmentImportData { get; set; } = null!;
        public virtual DbSet<ShipmentLine> ShipmentLines { get; set; } = null!;
        public virtual DbSet<ShipmentLineAdCvd> ShipmentLineAdCvds { get; set; } = null!;
        public virtual DbSet<ShipmentLineGa> ShipmentLineGas { get; set; } = null!;
        public virtual DbSet<ShipmentLineValueAdj> ShipmentLineValueAdjs { get; set; } = null!;
        public virtual DbSet<ShipmentParty> ShipmentParties { get; set; } = null!;
        public virtual DbSet<Spi> Spis { get; set; } = null!;
        public virtual DbSet<SpiConfiguration> SpiConfigurations { get; set; } = null!;
        public virtual DbSet<SpiCountryMap> SpiCountryMaps { get; set; } = null!;
        public virtual DbSet<StoredProcedureExecutionStatus> StoredProcedureExecutionStatuses { get; set; } = null!;
        public virtual DbSet<Tenant> Tenants { get; set; } = null!;
        public virtual DbSet<TradingParty> TradingParties { get; set; } = null!;
        public virtual DbSet<UomList> UomLists { get; set; } = null!;
        public virtual DbSet<UserComplianceCompanyMap> UserComplianceCompanyMaps { get; set; } = null!;
        public virtual DbSet<UserDatum> UserData { get; set; } = null!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public virtual DbSet<UserRoleMap> UserRoleMaps { get; set; } = null!;
        public virtual DbSet<WorkItem> WorkItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost:5432;Database=trading_compliance;Username=postgres;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adcvd>(entity =>
            {
                entity.ToTable("adcvd");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("case_number");

                entity.Property(e => e.Coe)
                    .HasMaxLength(255)
                    .HasColumnName("coe");

                entity.Property(e => e.Coi)
                    .HasMaxLength(255)
                    .HasColumnName("coi");

                entity.Property(e => e.ConditionLogic)
                    .HasMaxLength(255)
                    .HasColumnName("condition_logic");

                entity.Property(e => e.ControlType)
                    .HasMaxLength(255)
                    .HasColumnName("control_type");

                entity.Property(e => e.Coo)
                    .HasMaxLength(255)
                    .HasColumnName("coo");

                entity.Property(e => e.DutyRates).HasColumnName("duty_rates");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.MandateStatus)
                    .HasMaxLength(255)
                    .HasColumnName("mandate_status");

                entity.Property(e => e.Regulation)
                    .HasMaxLength(255)
                    .HasColumnName("regulation");

                entity.Property(e => e.Scope).HasColumnName("scope");

                entity.Property(e => e.ScopeException).HasColumnName("scope_exception");
            });

            modelBuilder.Entity<AdcvdCaseMap>(entity =>
            {
                entity.ToTable("adcvd_case_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AdcvdId)
                    .HasMaxLength(255)
                    .HasColumnName("adcvd_id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientSecret)
                    .HasMaxLength(32)
                    .HasColumnName("client_secret");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .HasColumnName("user_email");
            });

            modelBuilder.Entity<CollaboratorCompany>(entity =>
            {
                entity.ToTable("collaborator_company");

                entity.Property(e => e.CollaboratorCompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("collaborator_company_id");

                entity.Property(e => e.CollaboratorCompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("collaborator_company_name");

                entity.Property(e => e.CollaboratorType)
                    .HasColumnType("character varying")
                    .HasColumnName("collaborator_type");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.TradingPartyId)
                    .HasColumnType("character varying")
                    .HasColumnName("trading_party_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<CollaboratorRequestItem>(entity =>
            {
                entity.ToTable("collaborator_request_item");

                entity.Property(e => e.CollaboratorRequestItemId)
                    .HasMaxLength(255)
                    .HasColumnName("collaborator_request_item_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.RequestSourceData)
                    .HasMaxLength(255)
                    .HasColumnName("request_source_data");

                entity.Property(e => e.RequestSourceKey)
                    .HasMaxLength(255)
                    .HasColumnName("request_source_key");

                entity.Property(e => e.RequestSourceType)
                    .HasMaxLength(255)
                    .HasColumnName("request_source_type");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.TradingPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("trading_party_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("company_id");

                entity.Property(e => e.CompanyName)
                    .HasColumnType("character varying")
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyType)
                    .HasColumnType("character varying")
                    .HasColumnName("company_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<CompanyLicenceMap>(entity =>
            {
                entity.ToTable("company_licence_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.LicenceId).HasColumnName("licence_id");
            });

            modelBuilder.Entity<ComplianceCompany>(entity =>
            {
                entity.ToTable("compliance_company");

                entity.Property(e => e.ComplianceCompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("compliance_company_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyName)
                    .HasColumnType("character varying")
                    .HasColumnName("compliance_company_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("configuration");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(255)
                    .HasColumnName("added_by");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ConfigData)
                    .HasMaxLength(255)
                    .HasColumnName("config_data");

                entity.Property(e => e.ConfigName)
                    .HasMaxLength(255)
                    .HasColumnName("config_name");

                entity.Property(e => e.ConfigSubType)
                    .HasMaxLength(255)
                    .HasColumnName("config_sub_type");

                entity.Property(e => e.ConfigType)
                    .HasMaxLength(255)
                    .HasColumnName("config_type");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("last_modified_by");
            });

            modelBuilder.Entity<ControlClassMap>(entity =>
            {
                entity.ToTable("control_class_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Control)
                    .HasMaxLength(255)
                    .HasColumnName("control");

                entity.Property(e => e.ControlFlag)
                    .HasMaxLength(255)
                    .HasColumnName("control_flag");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.Ecn)
                    .HasMaxLength(255)
                    .HasColumnName("ecn");
            });

            modelBuilder.Entity<ControlCountryMap>(entity =>
            {
                entity.ToTable("control_country_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Controls)
                    .HasMaxLength(255)
                    .HasColumnName("controls");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.DestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("country_list");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(250)
                    .HasColumnName("country_code");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UnionCode)
                    .HasMaxLength(255)
                    .HasColumnName("union_code");
            });

            modelBuilder.Entity<CurrencyCodeList>(entity =>
            {
                entity.ToTable("currency_code_list");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(255)
                    .HasColumnName("symbol");
            });

            modelBuilder.Entity<DecisionConfiguration>(entity =>
            {
                entity.ToTable("decision_configuration");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionEntity)
                    .HasMaxLength(255)
                    .HasColumnName("decision_entity");

                entity.Property(e => e.DecisionPreference)
                    .HasMaxLength(255)
                    .HasColumnName("decision_preference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<DocInfo>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("doc_info_pkey");

                entity.ToTable("doc_info");

                entity.HasIndex(e => e.DocCode, "uniquedoccode")
                    .IsUnique();

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(255)
                    .HasColumnName("document_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DocCode)
                    .HasMaxLength(255)
                    .HasColumnName("doc_code");

                entity.Property(e => e.DocDefinition).HasColumnName("doc_definition");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PageImages)
                    .HasMaxLength(255)
                    .HasColumnName("page_images");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<Eccn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eccn");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EccnCode)
                    .HasMaxLength(255)
                    .HasColumnName("eccn_code");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.NodeType)
                    .HasMaxLength(255)
                    .HasColumnName("node_type");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.ValidEccn).HasColumnName("valid_eccn");
            });

            modelBuilder.Entity<EntityProcessing>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("entity_processing_pkey");

                entity.ToTable("entity_processing");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(255)
                    .HasColumnName("record_id");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("execution_time");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_id");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("record_type");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<EntityProcessingDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("entity_processing_data");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(255)
                    .HasColumnName("msg_code");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_id");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(255)
                    .HasColumnName("record_id");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("record_type");
            });

            modelBuilder.Entity<EntityProcessingMessage>(entity =>
            {
                entity.ToTable("entity_processing_message");

                entity.Property(e => e.EntityProcessingMessageId)
                    .HasMaxLength(255)
                    .HasColumnName("entity_processing_message_id");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(255)
                    .HasColumnName("field_name");

                entity.Property(e => e.Msg)
                    .HasMaxLength(255)
                    .HasColumnName("msg");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(255)
                    .HasColumnName("msg_code");

                entity.Property(e => e.MsgContext)
                    .HasMaxLength(255)
                    .HasColumnName("msg_context");

                entity.Property(e => e.MsgSeverity).HasColumnName("msg_severity");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(255)
                    .HasColumnName("record_id");

                entity.Property(e => e.RuleId)
                    .HasMaxLength(255)
                    .HasColumnName("rule_id");
            });

            modelBuilder.Entity<EntityProcessingQueueConfig>(entity =>
            {
                entity.HasKey(e => e.QueueConfigId)
                    .HasName("entity_processing_queue_config_pkey");

                entity.ToTable("entity_processing_queue_config");

                entity.Property(e => e.QueueConfigId)
                    .ValueGeneratedNever()
                    .HasColumnName("queue_config_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.LoadEndTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("load_end_time");

                entity.Property(e => e.LoadStartTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("load_start_time");

                entity.Property(e => e.NextLoadTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("next_load_time");

                entity.Property(e => e.QueueConfig)
                    .HasMaxLength(255)
                    .HasColumnName("queue_config");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(255)
                    .HasColumnName("queue_name");

                entity.Property(e => e.QueueType)
                    .HasMaxLength(255)
                    .HasColumnName("queue_type");

                entity.Property(e => e.RecordCount).HasColumnName("record_count");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<EntityProcessingQueueItem>(entity =>
            {
                entity.HasKey(e => e.QueueItemId)
                    .HasName("entity_processing_queue_item_pkey");

                entity.ToTable("entity_processing_queue_item");

                entity.Property(e => e.QueueItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("queue_item_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.QueueIndex).HasColumnName("queue_index");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(255)
                    .HasColumnName("queue_name");

                entity.Property(e => e.QueueType)
                    .HasMaxLength(255)
                    .HasColumnName("queue_type");

                entity.Property(e => e.QueuedTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("queued_time");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(255)
                    .HasColumnName("record_id");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("record_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ExceptionClassMap>(entity =>
            {
                entity.ToTable("exception_class_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Ecn)
                    .HasMaxLength(255)
                    .HasColumnName("ecn");

                entity.Property(e => e.Exceptions)
                    .HasMaxLength(255)
                    .HasColumnName("exceptions");

                entity.Property(e => e.SourceCountry)
                    .HasMaxLength(255)
                    .HasColumnName("source_country");
            });

            modelBuilder.Entity<ExceptionCountryMap>(entity =>
            {
                entity.ToTable("exception_country_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.DestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country");

                entity.Property(e => e.Exceptions)
                    .HasMaxLength(255)
                    .HasColumnName("exceptions");
            });

            modelBuilder.Entity<ExportConfiguration>(entity =>
            {
                entity.ToTable("export_configuration");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(255)
                    .HasColumnName("code_type");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.DestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country");

                entity.Property(e => e.Expression).HasColumnName("expression");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");
            });

            modelBuilder.Entity<ExportControlCode>(entity =>
            {
                entity.ToTable("export_control_code");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.ControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("control_code");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");
            });

            modelBuilder.Entity<ExportGaControlCode>(entity =>
            {
                entity.ToTable("export_ga_control_codes");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Agency)
                    .HasMaxLength(255)
                    .HasColumnName("agency");

                entity.Property(e => e.BaseControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("base_control_code");

                entity.Property(e => e.ControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("control_code");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DestinationCountryFlag)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_flag");

                entity.Property(e => e.DestinationCountryList)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_list");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FormCode)
                    .HasMaxLength(255)
                    .HasColumnName("form_code");

                entity.Property(e => e.Required)
                    .HasMaxLength(255)
                    .HasColumnName("required");
            });

            modelBuilder.Entity<ExportGaFormMap>(entity =>
            {
                entity.ToTable("export_ga_form_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.FormCode)
                    .HasMaxLength(255)
                    .HasColumnName("form_code");

                entity.Property(e => e.FormName)
                    .HasMaxLength(255)
                    .HasColumnName("form_name");

                entity.Property(e => e.FormType)
                    .HasMaxLength(255)
                    .HasColumnName("form_type");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");
            });

            modelBuilder.Entity<ExportH>(entity =>
            {
                entity.ToTable("export_hs");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.GaCodes)
                    .HasMaxLength(255)
                    .HasColumnName("ga_codes");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code");

                entity.Property(e => e.IsFinalHs).HasColumnName("is_final_hs");

                entity.Property(e => e.Uom1)
                    .HasMaxLength(255)
                    .HasColumnName("uom1");

                entity.Property(e => e.Uom2)
                    .HasMaxLength(255)
                    .HasColumnName("uom2");

                entity.Property(e => e.Uom3)
                    .HasMaxLength(255)
                    .HasColumnName("uom3");
            });

            modelBuilder.Entity<ExportHsConfiguration>(entity =>
            {
                entity.ToTable("export_hs_configuration");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(255)
                    .HasColumnName("added_by");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.HsLength)
                    .HasMaxLength(255)
                    .HasColumnName("hs_length");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("last_modified_by");
            });

            modelBuilder.Entity<ExportLicenseExceptionCode>(entity =>
            {
                entity.ToTable("export_license_exception_codes");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("exception_code");
            });

            modelBuilder.Entity<ExportLicenseMgmt>(entity =>
            {
                entity.HasKey(e => e.ExportLicenseId)
                    .HasName("export_license_mgmt_pkey");

                entity.ToTable("export_license_mgmt");

                entity.Property(e => e.ExportLicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ConsumedQuantity).HasColumnName("consumed_quantity");

                entity.Property(e => e.ConsumedValue).HasColumnName("consumed_value");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country");

                entity.Property(e => e.Ecn)
                    .HasMaxLength(255)
                    .HasColumnName("ecn");

                entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");

                entity.Property(e => e.HasQuantityLimit).HasColumnName("has_quantity_limit");

                entity.Property(e => e.HasValueLimit).HasColumnName("has_value_limit");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("license_number");

                entity.Property(e => e.LicenseTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("license_type_code");

                entity.Property(e => e.QuantityLimit).HasColumnName("quantity_limit");

                entity.Property(e => e.Scope).HasColumnName("scope");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.UltimateConsigneeList)
                    .HasMaxLength(255)
                    .HasColumnName("ultimate_consignee_list");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.ValueLimit).HasColumnName("value_limit");
            });

            modelBuilder.Entity<ExportLicenseReservation>(entity =>
            {
                entity.ToTable("export_license_reservation");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("export_date");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.ReservationStatus)
                    .HasMaxLength(255)
                    .HasColumnName("reservation_status");

                entity.Property(e => e.ReservedQuantity).HasColumnName("reserved_quantity");

                entity.Property(e => e.ReservedValue).HasColumnName("reserved_value");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(255)
                    .HasColumnName("transaction_id");
            });

            modelBuilder.Entity<ExportShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentId)
                    .HasName("export_shipment_pkey");

                entity.ToTable("export_shipment");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.Coe)
                    .HasMaxLength(255)
                    .HasColumnName("coe");

                entity.Property(e => e.Coi)
                    .HasMaxLength(255)
                    .HasColumnName("coi");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.EstimatedExportDate).HasColumnName("estimated_export_date");

                entity.Property(e => e.EstimatedImportDate).HasColumnName("estimated_import_date");

                entity.Property(e => e.ExternalShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("external_shipment_id");

                entity.Property(e => e.IncoTerms)
                    .HasMaxLength(255)
                    .HasColumnName("inco_terms");

                entity.Property(e => e.ModeOfTransport)
                    .HasMaxLength(255)
                    .HasColumnName("mode_of_transport");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ExportShipmentLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("export_shipment_line_pkey");

                entity.ToTable("export_shipment_line");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.ClassificationNote).HasColumnName("classification_note");

                entity.Property(e => e.ClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("classified_at");

                entity.Property(e => e.ClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("classified_by");

                entity.Property(e => e.CommodityDescription)
                    .HasMaxLength(255)
                    .HasColumnName("commodity_description");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DetailUrl).HasColumnName("detail_url");

                entity.Property(e => e.Ecn)
                    .HasMaxLength(255)
                    .HasColumnName("ecn");

                entity.Property(e => e.EcnClassificationNote)
                    .HasMaxLength(255)
                    .HasColumnName("ecn_classification_note");

                entity.Property(e => e.EcnClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ecn_classified_at");

                entity.Property(e => e.EcnClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("ecn_classified_by");

                entity.Property(e => e.ExportHsCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_hs_code");

                entity.Property(e => e.ExportUomQtyTuples).HasColumnName("export_uom_qty_tuples");

                entity.Property(e => e.ExternalProductId)
                    .HasMaxLength(255)
                    .HasColumnName("external_product_id");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceLineId)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_line_id");

                entity.Property(e => e.IsLinked)
                    .IsRequired()
                    .HasColumnName("is_linked")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LicenseNotAvailable).HasColumnName("license_not_available");

                entity.Property(e => e.LicenseRequired)
                    .HasMaxLength(255)
                    .HasColumnName("license_required");

                entity.Property(e => e.LineSeq).HasColumnName("line_seq");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentLineId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_line_id");

                entity.Property(e => e.PoId)
                    .HasMaxLength(255)
                    .HasColumnName("po_id");

                entity.Property(e => e.PoLineId)
                    .HasMaxLength(255)
                    .HasColumnName("po_line_id");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("product_category");

                entity.Property(e => e.ProductCategoryInfo)
                    .HasMaxLength(255)
                    .HasColumnName("product_category_info");

                entity.Property(e => e.ProductCurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("product_currency_code");

                entity.Property(e => e.ProductGrossWeight).HasColumnName("product_gross_weight");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductPrice).HasColumnName("product_price");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductRef)
                    .HasMaxLength(255)
                    .HasColumnName("product_ref");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .HasColumnName("product_type");

                entity.Property(e => e.ProductUom)
                    .HasMaxLength(255)
                    .HasColumnName("product_uom");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ExportShipmentLineControl>(entity =>
            {
                entity.HasKey(e => e.LineItemControlId)
                    .HasName("export_shipment_line_control_pkey");

                entity.ToTable("export_shipment_line_control");

                entity.Property(e => e.LineItemControlId)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_control_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("control_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ExportShipmentLineGaDatum>(entity =>
            {
                entity.HasKey(e => e.Linegaid)
                    .HasName("export_shipment_line_ga_data_pkey");

                entity.ToTable("export_shipment_line_ga_data");

                entity.Property(e => e.Linegaid)
                    .HasMaxLength(255)
                    .HasColumnName("linegaid");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaData).HasColumnName("ga_data");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ExportShipmentLineLicense>(entity =>
            {
                entity.HasKey(e => e.LineItemLicenseId)
                    .HasName("export_shipment_line_license_pkey");

                entity.ToTable("export_shipment_line_license");

                entity.Property(e => e.LineItemLicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_license_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ExportShipmentLineLicenseException>(entity =>
            {
                entity.HasKey(e => e.LineItemExceptionId)
                    .HasName("export_shipment_line_license_exception_pkey");

                entity.ToTable("export_shipment_line_license_exception");

                entity.Property(e => e.LineItemExceptionId)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_exception_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.ExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("exception_code");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ExportShipmentParty>(entity =>
            {
                entity.HasKey(e => e.ShipmentPartyId)
                    .HasName("export_shipment_party_pkey");

                entity.ToTable("export_shipment_party");

                entity.Property(e => e.ShipmentPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_party_id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(255)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ExternalPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("external_party_id");

                entity.Property(e => e.IsLinked)
                    .IsRequired()
                    .HasColumnName("is_linked")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PartyType)
                    .HasMaxLength(255)
                    .HasColumnName("party_type");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postal_code");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.RpsResultsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_id");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<FlywaySchemaHistory>(entity =>
            {
                entity.HasKey(e => e.InstalledRank)
                    .HasName("flyway_schema_history_pk");

                entity.ToTable("flyway_schema_history");

                entity.HasIndex(e => e.Success, "flyway_schema_history_s_idx");

                entity.Property(e => e.InstalledRank)
                    .ValueGeneratedNever()
                    .HasColumnName("installed_rank");

                entity.Property(e => e.Checksum).HasColumnName("checksum");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");

                entity.Property(e => e.InstalledBy)
                    .HasMaxLength(100)
                    .HasColumnName("installed_by");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("installed_on")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Script)
                    .HasMaxLength(1000)
                    .HasColumnName("script");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Gpa>(entity =>
            {
                entity.ToTable("gpa");

                entity.Property(e => e.GpaId)
                    .HasMaxLength(255)
                    .HasColumnName("gpa_id");

                entity.Property(e => e.ApplicableHsRange).HasColumnName("applicable_hs_range");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GpaName)
                    .HasMaxLength(255)
                    .HasColumnName("gpa_name");

                entity.Property(e => e.KeywordList).HasColumnName("keyword_list");

                entity.Property(e => e.PotentialHsRange).HasColumnName("potential_hs_range");

                entity.Property(e => e.ProductAttr)
                    .HasMaxLength(255)
                    .HasColumnName("product_attr");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .HasColumnName("group_name");
            });

            modelBuilder.Entity<GroupResourceMap>(entity =>
            {
                entity.ToTable("group_resource_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            });

            modelBuilder.Entity<HsDuty>(entity =>
            {
                entity.ToTable("hs_duty");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AdvaloremRate).HasColumnName("advalorem_rate");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.DutyCompCode)
                    .HasMaxLength(255)
                    .HasColumnName("duty_comp_code");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.OtherRate).HasColumnName("other_rate");

                entity.Property(e => e.PausedBy)
                    .HasMaxLength(255)
                    .HasColumnName("paused_by");

                entity.Property(e => e.PausedOn)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paused_on");

                entity.Property(e => e.PgaCodes)
                    .HasMaxLength(255)
                    .HasColumnName("pga_codes");

                entity.Property(e => e.SpecificRate).HasColumnName("specific_rate");

                entity.Property(e => e.Uom1)
                    .HasMaxLength(255)
                    .HasColumnName("uom1");

                entity.Property(e => e.Uom2)
                    .HasMaxLength(255)
                    .HasColumnName("uom2");

                entity.Property(e => e.Uom3)
                    .HasMaxLength(255)
                    .HasColumnName("uom3");
            });

            modelBuilder.Entity<HsSpiDuty>(entity =>
            {
                entity.ToTable("hs_spi_duty");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AdvaloremRate).HasColumnName("advalorem_rate");

                entity.Property(e => e.HsId)
                    .HasMaxLength(255)
                    .HasColumnName("hs_id");

                entity.Property(e => e.OtherRate).HasColumnName("other_rate");

                entity.Property(e => e.SpecificRate).HasColumnName("specific_rate");

                entity.Property(e => e.SpiCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_code");
            });

            modelBuilder.Entity<HsTariffMap>(entity =>
            {
                entity.ToTable("hs_tariff_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ExportCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_country_code");

                entity.Property(e => e.ImportCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("import_country_code");
            });

            modelBuilder.Entity<HstariffMap1>(entity =>
            {
                entity.ToTable("hstariff_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ExportCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_country_code");

                entity.Property(e => e.ImportCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("import_country_code");
            });

            modelBuilder.Entity<ImportControlCode>(entity =>
            {
                entity.ToTable("import_control_codes");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Agency)
                    .HasMaxLength(255)
                    .HasColumnName("agency");

                entity.Property(e => e.ControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("control_code");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FormCode)
                    .HasMaxLength(255)
                    .HasColumnName("form_code");

                entity.Property(e => e.Required)
                    .HasMaxLength(255)
                    .HasColumnName("required");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("labels_pkey");

                entity.ToTable("labels");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .HasColumnName("key");
            });

            modelBuilder.Entity<LabelTranslation>(entity =>
            {
                entity.ToTable("label_translations");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.LabelKey)
                    .HasMaxLength(255)
                    .HasColumnName("label_key");

                entity.Property(e => e.Language)
                    .HasMaxLength(255)
                    .HasColumnName("language");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.Translation)
                    .HasMaxLength(255)
                    .HasColumnName("translation");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.Language1)
                    .HasName("languages_pkey");

                entity.ToTable("languages");

                entity.Property(e => e.Language1)
                    .HasMaxLength(255)
                    .HasColumnName("language");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.ToTable("licences");

                entity.Property(e => e.LicenceId)
                    .ValueGeneratedNever()
                    .HasColumnName("licence_id");

                entity.Property(e => e.LicenceName)
                    .HasColumnType("character varying")
                    .HasColumnName("licence_name");
            });

            modelBuilder.Entity<LicenceGroupMap>(entity =>
            {
                entity.ToTable("licence_group_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.LicenceId).HasColumnName("licence_id");
            });

            modelBuilder.Entity<OgaDeterminationConfig>(entity =>
            {
                entity.HasKey(e => e.GpaId)
                    .HasName("oga_determination_config_pkey");

                entity.ToTable("oga_determination_config");

                entity.Property(e => e.GpaId)
                    .HasMaxLength(255)
                    .HasColumnName("gpa_id");

                entity.Property(e => e.ApplicableHsRange).HasColumnName("applicable_hs_range");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GpaName)
                    .HasMaxLength(255)
                    .HasColumnName("gpa_name");

                entity.Property(e => e.ImportExportIndicator)
                    .HasMaxLength(255)
                    .HasColumnName("import_export_indicator");

                entity.Property(e => e.KeywordList).HasColumnName("keyword_list");

                entity.Property(e => e.PotentialHsRange).HasColumnName("potential_hs_range");

                entity.Property(e => e.ProductAttr)
                    .HasMaxLength(255)
                    .HasColumnName("product_attr");
            });

            modelBuilder.Entity<PartyType>(entity =>
            {
                entity.ToTable("party_type");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.PartyType1)
                    .HasMaxLength(255)
                    .HasColumnName("party_type");
            });

            modelBuilder.Entity<PgaFormMap>(entity =>
            {
                entity.ToTable("pga_form_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.FormCode)
                    .HasMaxLength(255)
                    .HasColumnName("form_code");

                entity.Property(e => e.FormName)
                    .HasMaxLength(255)
                    .HasColumnName("form_name");

                entity.Property(e => e.FormType)
                    .HasMaxLength(255)
                    .HasColumnName("form_type");

                entity.Property(e => e.PgaCode)
                    .HasMaxLength(255)
                    .HasColumnName("pga_code");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ChildProductIds)
                    .HasMaxLength(255)
                    .HasColumnName("child_product_ids");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ComponentQty)
                    .HasColumnName("component_qty")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CustomsDescription).HasColumnName("customs_description");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Detailurl).HasColumnName("detailurl");

                entity.Property(e => e.ExternalProductId)
                    .HasMaxLength(255)
                    .HasColumnName("external_product_id");

                entity.Property(e => e.GrossWeight).HasColumnName("gross_weight");

                entity.Property(e => e.Imageurl).HasColumnName("imageurl");

                entity.Property(e => e.IsEssentialCharacter)
                    .HasColumnName("is_essential_character")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.ParentProductId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_product_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("product_category");

                entity.Property(e => e.ProductCategoryInfo)
                    .HasMaxLength(255)
                    .HasColumnName("product_category_info");

                entity.Property(e => e.ProductRef)
                    .HasMaxLength(255)
                    .HasColumnName("product_ref");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .HasColumnName("product_type");

                entity.Property(e => e.ProductUom)
                    .HasMaxLength(255)
                    .HasColumnName("product_uom");

                entity.Property(e => e.UomQty).HasColumnName("uom_qty");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductAd>(entity =>
            {
                entity.HasKey(e => e.AdCvdId)
                    .HasName("product_ad_pkey");

                entity.ToTable("product_ad");

                entity.Property(e => e.AdCvdId)
                    .HasMaxLength(255)
                    .HasColumnName("ad_cvd_id");

                entity.Property(e => e.AllOthersCvdRate).HasColumnName("all_others_cvd_rate");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("case_number");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Coo)
                    .HasMaxLength(255)
                    .HasColumnName("coo");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductExportClass>(entity =>
            {
                entity.HasKey(e => e.ExportClassId)
                    .HasName("product_export_class_pkey");

                entity.ToTable("product_export_class");

                entity.Property(e => e.ExportClassId)
                    .HasMaxLength(255)
                    .HasColumnName("export_class_id");

                entity.Property(e => e.ClassificationNote).HasColumnName("classification_note");

                entity.Property(e => e.ClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("classified_at");

                entity.Property(e => e.ClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("classified_by");

                entity.Property(e => e.CommodityDescription).HasColumnName("commodity_description");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Ecn)
                    .HasMaxLength(255)
                    .HasColumnName("ecn");

                entity.Property(e => e.EcnClassificationNote).HasColumnName("ecn_classification_note");

                entity.Property(e => e.EcnClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ecn_classified_at");

                entity.Property(e => e.EcnClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("ecn_classified_by");

                entity.Property(e => e.ExportHsCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_hs_code");

                entity.Property(e => e.ExportUomQtyTuples).HasColumnName("export_uom_qty_tuples");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductExportControl>(entity =>
            {
                entity.ToTable("product_export_control");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("control_code");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.DestinationCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_code");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductExportDataTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("product_export_data_test");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ExportClassId)
                    .HasMaxLength(255)
                    .HasColumnName("export_class_id");

                entity.Property(e => e.ExportControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_code");

                entity.Property(e => e.ExportControlId)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_id");

                entity.Property(e => e.ExportCountry)
                    .HasMaxLength(255)
                    .HasColumnName("export_country");

                entity.Property(e => e.ExportDestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_country");

                entity.Property(e => e.ExportDestinationId)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_id");

                entity.Property(e => e.ExportDestinationLicenseRequired)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_license_required");

                entity.Property(e => e.ExportLicenseExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_code");

                entity.Property(e => e.ExportLicenseExceptionId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_id");

                entity.Property(e => e.ExportLicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_id");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaData).HasColumnName("ga_data");

                entity.Property(e => e.GaDataId)
                    .HasMaxLength(255)
                    .HasColumnName("ga_data_id");

                entity.Property(e => e.GaSystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_system_decision");

                entity.Property(e => e.GaUserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_user_decision");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasColumnName("product_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductExportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("product_export_data");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ExportClassId)
                    .HasMaxLength(255)
                    .HasColumnName("export_class_id");

                entity.Property(e => e.ExportControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_code");

                entity.Property(e => e.ExportControlId)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_id");

                entity.Property(e => e.ExportCountry)
                    .HasMaxLength(255)
                    .HasColumnName("export_country");

                entity.Property(e => e.ExportDestinationCountry)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_country");

                entity.Property(e => e.ExportDestinationId)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_id");

                entity.Property(e => e.ExportDestinationLicenseRequired)
                    .HasMaxLength(255)
                    .HasColumnName("export_destination_license_required");

                entity.Property(e => e.ExportLicenseExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_code");

                entity.Property(e => e.ExportLicenseExceptionId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_id");

                entity.Property(e => e.ExportLicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_id");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaData).HasColumnName("ga_data");

                entity.Property(e => e.GaDataId)
                    .HasMaxLength(255)
                    .HasColumnName("ga_data_id");

                entity.Property(e => e.GaSystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_system_decision");

                entity.Property(e => e.GaUserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_user_decision");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasColumnName("product_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductExportDestination>(entity =>
            {
                entity.ToTable("product_export_destination");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DestinationCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_code");

                entity.Property(e => e.LicenseNotAvailable).HasColumnName("license_not_available");

                entity.Property(e => e.LicenseRequired)
                    .HasMaxLength(255)
                    .HasColumnName("license_required");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductExportGaDatum>(entity =>
            {
                entity.HasKey(e => e.ExportGaDataId)
                    .HasName("product_export_ga_data_pkey");

                entity.ToTable("product_export_ga_data");

                entity.Property(e => e.ExportGaDataId)
                    .HasMaxLength(255)
                    .HasColumnName("export_ga_data_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaData).HasColumnName("ga_data");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote).HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote).HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductExportLicense>(entity =>
            {
                entity.ToTable("product_export_license");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.DestinationCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_code");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductExportLicenseException>(entity =>
            {
                entity.ToTable("product_export_license_exception");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.DestinationCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("destination_country_code");

                entity.Property(e => e.ExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("exception_code");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductImportClass>(entity =>
            {
                entity.HasKey(e => e.ImportClassId)
                    .HasName("product_import_class_pkey");

                entity.ToTable("product_import_class");

                entity.Property(e => e.ImportClassId)
                    .HasMaxLength(255)
                    .HasColumnName("import_class_id");

                entity.Property(e => e.ClassificationNote).HasColumnName("classification_note");

                entity.Property(e => e.ClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("classified_at");

                entity.Property(e => e.ClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("classified_by");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomsDescription).HasColumnName("customs_description");

                entity.Property(e => e.CustomsUomQtyTuples).HasColumnName("customs_uom_qty_tuples");

                entity.Property(e => e.DefaultSourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("default_sourcing_id");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.EndDayAndMonth)
                    .HasMaxLength(255)
                    .HasColumnName("end_day_and_month");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.HsCode1)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code1");

                entity.Property(e => e.HsCode2)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code2");

                entity.Property(e => e.HsCode3)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code3");

                entity.Property(e => e.HsCode4)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code4");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SeasonalityId)
                    .HasMaxLength(20)
                    .HasColumnName("seasonality_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartDayAndMonth)
                    .HasMaxLength(255)
                    .HasColumnName("start_day_and_month");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("product_import_data");

                entity.Property(e => e.AdCvdId)
                    .HasMaxLength(255)
                    .HasColumnName("ad_cvd_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(255)
                    .HasColumnName("country_of_origin");

                entity.Property(e => e.ImportClassId)
                    .HasMaxLength(255)
                    .HasColumnName("import_class_id");

                entity.Property(e => e.PgaCode)
                    .HasMaxLength(255)
                    .HasColumnName("pga_code");

                entity.Property(e => e.PgaDataId)
                    .HasMaxLength(255)
                    .HasColumnName("pga_data_id");

                entity.Property(e => e.PgaId)
                    .HasMaxLength(255)
                    .HasColumnName("pga_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductPga>(entity =>
            {
                entity.HasKey(e => e.PgaId)
                    .HasName("product_pga_pkey");

                entity.ToTable("product_pga");

                entity.Property(e => e.PgaId)
                    .HasMaxLength(255)
                    .HasColumnName("pga_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.PgaCode)
                    .HasMaxLength(255)
                    .HasColumnName("pga_code");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote).HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote).HasColumnName("user_note");
            });

            modelBuilder.Entity<ProductPgaDatum>(entity =>
            {
                entity.HasKey(e => e.PgaDataId)
                    .HasName("product_pga_data_pkey");

                entity.ToTable("product_pga_data");

                entity.Property(e => e.PgaDataId)
                    .HasMaxLength(255)
                    .HasColumnName("pga_data_id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.PgaCode)
                    .HasMaxLength(255)
                    .HasColumnName("pga_code");

                entity.Property(e => e.PgaData).HasColumnName("pga_data");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductSourcing>(entity =>
            {
                entity.HasKey(e => e.SourcingId)
                    .HasName("product_sourcing_pkey");

                entity.ToTable("product_sourcing");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.Coe)
                    .HasMaxLength(255)
                    .HasColumnName("coe");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Coo)
                    .HasMaxLength(255)
                    .HasColumnName("coo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("currency_code");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductSourcingAdCvdRate>(entity =>
            {
                entity.HasKey(e => e.AdCvdId)
                    .HasName("product_sourcing_ad_cvd_rate_pkey");

                entity.ToTable("product_sourcing_ad_cvd_rate");

                entity.Property(e => e.AdCvdId)
                    .HasMaxLength(255)
                    .HasColumnName("ad_cvd_id");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("case_number");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CvdRate).HasColumnName("cvd_rate");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.RateType)
                    .HasMaxLength(255)
                    .HasColumnName("rate_type");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ProductSourcingValueAdjustment>(entity =>
            {
                entity.HasKey(e => e.ValuationId)
                    .HasName("product_sourcing_value_adjustments_pkey");

                entity.ToTable("product_sourcing_value_adjustments");

                entity.Property(e => e.ValuationId)
                    .HasMaxLength(255)
                    .HasColumnName("valuation_id");

                entity.Property(e => e.AdjustmentAmount).HasColumnName("adjustment_amount");

                entity.Property(e => e.AdjustmentRef)
                    .HasMaxLength(255)
                    .HasColumnName("adjustment_ref");

                entity.Property(e => e.AdjustmentType)
                    .HasMaxLength(255)
                    .HasColumnName("adjustment_type");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("currency_code");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(255)
                    .HasColumnName("value_type");
            });

            modelBuilder.Entity<ProductSpi>(entity =>
            {
                entity.ToTable("product_spi");

                entity.Property(e => e.Productspiid)
                    .HasMaxLength(255)
                    .HasColumnName("productspiid");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.SourcingId)
                    .HasMaxLength(255)
                    .HasColumnName("sourcing_id");

                entity.Property(e => e.SpiCertificateurl)
                    .HasMaxLength(255)
                    .HasColumnName("spi_certificateurl");

                entity.Property(e => e.SpiCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_code");

                entity.Property(e => e.SpiComment)
                    .HasMaxLength(255)
                    .HasColumnName("spi_comment");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("resource");

                entity.Property(e => e.ResourceId)
                    .ValueGeneratedNever()
                    .HasColumnName("resource_id");

                entity.Property(e => e.HttpMethod)
                    .HasMaxLength(255)
                    .HasColumnName("http_method");

                entity.Property(e => e.Resource1)
                    .HasMaxLength(255)
                    .HasColumnName("resource");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(255)
                    .HasColumnName("resource_type");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("role_id");

                entity.Property(e => e.AccessStrategy)
                    .HasColumnType("character varying")
                    .HasColumnName("access_strategy");

                entity.Property(e => e.RoleName)
                    .HasColumnType("character varying")
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<RoleGroupMap>(entity =>
            {
                entity.ToTable("role_group_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<RplEntity>(entity =>
            {
                entity.HasKey(e => e.RplId)
                    .HasName("rpl_entity_pkey");

                entity.ToTable("rpl_entity");

                entity.Property(e => e.RplId)
                    .HasMaxLength(255)
                    .HasColumnName("rpl_id");

                entity.Property(e => e.RplType)
                    .HasMaxLength(255)
                    .HasColumnName("rpl_type");
            });

            modelBuilder.Entity<RplEntityAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.RplId })
                    .HasName("rpl_entity_address_pkey");

                entity.ToTable("rpl_entity_address");

                entity.Property(e => e.AddressId)
                    .HasMaxLength(255)
                    .HasColumnName("address_id");

                entity.Property(e => e.RplId)
                    .HasMaxLength(255)
                    .HasColumnName("rpl_id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postal_code");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<RplEntityName>(entity =>
            {
                entity.HasKey(e => new { e.NameId, e.RplId })
                    .HasName("rpl_entity_name_pkey");

                entity.ToTable("rpl_entity_name");

                entity.Property(e => e.NameId)
                    .HasMaxLength(255)
                    .HasColumnName("name_id");

                entity.Property(e => e.RplId)
                    .HasMaxLength(255)
                    .HasColumnName("rpl_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RpsResult>(entity =>
            {
                entity.HasKey(e => e.RpsResultsId)
                    .HasName("rps_results_pkey");

                entity.ToTable("rps_results");

                entity.Property(e => e.RpsResultsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_id");

                entity.Property(e => e.ScreeningDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("screening_date");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.TradingPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("trading_party_id");

                entity.Property(e => e.UserComment)
                    .HasMaxLength(255)
                    .HasColumnName("user_comment");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");
            });

            modelBuilder.Entity<RpsResultsDetail>(entity =>
            {
                entity.HasKey(e => e.RpsResultsDetailsId)
                    .HasName("rps_results_details_pkey");

                entity.ToTable("rps_results_details");

                entity.Property(e => e.RpsResultsDetailsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_details_id");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(255)
                    .HasColumnName("entity_id");

                entity.Property(e => e.MatchScore).HasColumnName("match_score");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(255)
                    .HasColumnName("record_id");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("record_type");

                entity.Property(e => e.RpsResultsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_id");
            });

            modelBuilder.Entity<SchedulerTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("scheduler_task_pkey");

                entity.ToTable("scheduler_task");

                entity.Property(e => e.TaskId)
                    .HasMaxLength(255)
                    .HasColumnName("task_id");

                entity.Property(e => e.EndTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("end_time");

                entity.Property(e => e.ExecutionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("execution_status");

                entity.Property(e => e.IsUserTrigerred).HasColumnName("is_user_trigerred");

                entity.Property(e => e.ScheduledInterval).HasColumnName("scheduled_interval");

                entity.Property(e => e.StartTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("start_time");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(255)
                    .HasColumnName("task_name");

                entity.Property(e => e.TaskParms)
                    .HasMaxLength(255)
                    .HasColumnName("task_parms");

                entity.Property(e => e.TaskType)
                    .HasMaxLength(255)
                    .HasColumnName("task_type");
            });

            modelBuilder.Entity<SchemaVersionEntityprocessing>(entity =>
            {
                entity.HasKey(e => e.InstalledRank)
                    .HasName("schema_version_entityprocessing_pk");

                entity.ToTable("schema_version_entityprocessing");

                entity.HasIndex(e => e.Success, "schema_version_entityprocessing_s_idx");

                entity.Property(e => e.InstalledRank)
                    .ValueGeneratedNever()
                    .HasColumnName("installed_rank");

                entity.Property(e => e.Checksum).HasColumnName("checksum");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");

                entity.Property(e => e.InstalledBy)
                    .HasMaxLength(100)
                    .HasColumnName("installed_by");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("installed_on")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Script)
                    .HasMaxLength(1000)
                    .HasColumnName("script");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("shipment");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.Coe)
                    .HasMaxLength(255)
                    .HasColumnName("coe");

                entity.Property(e => e.Coi)
                    .HasMaxLength(255)
                    .HasColumnName("coi");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.EstimatedExportDate).HasColumnName("estimated_export_date");

                entity.Property(e => e.EstimatedImportDate).HasColumnName("estimated_import_date");

                entity.Property(e => e.ExternalShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("external_shipment_id");

                entity.Property(e => e.IncoTerms)
                    .HasMaxLength(255)
                    .HasColumnName("inco_terms");

                entity.Property(e => e.ModeOfTransport)
                    .HasMaxLength(255)
                    .HasColumnName("mode_of_transport");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ShipmentExportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shipment_export_data");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CountryOfExport)
                    .HasMaxLength(255)
                    .HasColumnName("country_of_export");

                entity.Property(e => e.CountryOfImport)
                    .HasMaxLength(255)
                    .HasColumnName("country_of_import");

                entity.Property(e => e.EstimatedExportDate).HasColumnName("estimated_export_date");

                entity.Property(e => e.EstimatedImportDate).HasColumnName("estimated_import_date");

                entity.Property(e => e.ExportControlCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_code");

                entity.Property(e => e.ExportControlId)
                    .HasMaxLength(255)
                    .HasColumnName("export_control_id");

                entity.Property(e => e.ExportDate).HasColumnName("export_date");

                entity.Property(e => e.ExportLicenseExceptionCode)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_code");

                entity.Property(e => e.ExportLicenseExceptionId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_exception_id");

                entity.Property(e => e.ExportLicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("export_license_id");

                entity.Property(e => e.ExportLineGaId)
                    .HasMaxLength(255)
                    .HasColumnName("export_line_ga_id");

                entity.Property(e => e.IsLinked).HasColumnName("is_linked");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(255)
                    .HasColumnName("license_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ShipmentImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shipment_import_data");

                entity.Property(e => e.AdcvdSystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("adcvd_system_decision");

                entity.Property(e => e.AdcvdUserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("adcvd_user_decision");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CountryOfImport)
                    .HasMaxLength(255)
                    .HasColumnName("country_of_import");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaSystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_system_decision");

                entity.Property(e => e.GaUserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("ga_user_decision");

                entity.Property(e => e.ImportDate).HasColumnName("import_date");

                entity.Property(e => e.IsLinked).HasColumnName("is_linked");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.Lineadcvdid)
                    .HasMaxLength(255)
                    .HasColumnName("lineadcvdid");

                entity.Property(e => e.Linegaid)
                    .HasMaxLength(255)
                    .HasColumnName("linegaid");

                entity.Property(e => e.Linevaid)
                    .HasMaxLength(255)
                    .HasColumnName("linevaid");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .HasColumnName("product_type");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");
            });

            modelBuilder.Entity<ShipmentLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("shipment_line_pkey");

                entity.ToTable("shipment_line");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.ClassificationNote).HasColumnName("classification_note");

                entity.Property(e => e.ClassifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("classified_at");

                entity.Property(e => e.ClassifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("classified_by");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Coo)
                    .HasMaxLength(255)
                    .HasColumnName("coo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomsDescription)
                    .HasMaxLength(255)
                    .HasColumnName("customs_description");

                entity.Property(e => e.CustomsUomQtyTuples)
                    .HasMaxLength(255)
                    .HasColumnName("customs_uom_qty_tuples");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DetailUrl).HasColumnName("detail_url");

                entity.Property(e => e.ExternalManufacturerId)
                    .HasMaxLength(255)
                    .HasColumnName("external_manufacturer_id");

                entity.Property(e => e.ExternalProductId)
                    .HasMaxLength(255)
                    .HasColumnName("external_product_id");

                entity.Property(e => e.ExternalSupplierId)
                    .HasMaxLength(255)
                    .HasColumnName("external_supplier_id");

                entity.Property(e => e.HsCode1)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code1");

                entity.Property(e => e.HsCode2)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code2");

                entity.Property(e => e.HsCode3)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code3");

                entity.Property(e => e.HsCode4)
                    .HasMaxLength(255)
                    .HasColumnName("hs_code4");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceLineId)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_line_id");

                entity.Property(e => e.IsLinked)
                    .IsRequired()
                    .HasColumnName("is_linked")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LineSeq).HasColumnName("line_seq");

                entity.Property(e => e.ManifestQty).HasColumnName("manifest_qty");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentLineId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_line_id");

                entity.Property(e => e.PoId)
                    .HasMaxLength(255)
                    .HasColumnName("po_id");

                entity.Property(e => e.PoLineId)
                    .HasMaxLength(255)
                    .HasColumnName("po_line_id");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("product_category");

                entity.Property(e => e.ProductCategoryInfo)
                    .HasMaxLength(255)
                    .HasColumnName("product_category_info");

                entity.Property(e => e.ProductCurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("product_currency_code");

                entity.Property(e => e.ProductGrossWeight).HasColumnName("product_gross_weight");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(255)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductPrice).HasColumnName("product_price");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductRef)
                    .HasMaxLength(255)
                    .HasColumnName("product_ref");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .HasColumnName("product_type");

                entity.Property(e => e.ProductUom)
                    .HasMaxLength(255)
                    .HasColumnName("product_uom");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.SpiCertificateUrl)
                    .HasMaxLength(255)
                    .HasColumnName("spi_certificate_url");

                entity.Property(e => e.SpiCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_code");

                entity.Property(e => e.SpiComment)
                    .HasMaxLength(255)
                    .HasColumnName("spi_comment");

                entity.Property(e => e.TotalDuty).HasColumnName("total_duty");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<ShipmentLineAdCvd>(entity =>
            {
                entity.HasKey(e => e.Lineadcvdid)
                    .HasName("shipment_line_ad_cvd_pkey");

                entity.ToTable("shipment_line_ad_cvd");

                entity.Property(e => e.Lineadcvdid)
                    .HasMaxLength(255)
                    .HasColumnName("lineadcvdid");

                entity.Property(e => e.AssesmentValue).HasColumnName("assesment_value");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("case_number");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Coo)
                    .HasMaxLength(255)
                    .HasColumnName("coo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CvdRate).HasColumnName("cvd_rate");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RateType)
                    .HasMaxLength(255)
                    .HasColumnName("rate_type");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ShipmentLineGa>(entity =>
            {
                entity.HasKey(e => e.Linegaid)
                    .HasName("shipment_line_ga_pkey");

                entity.ToTable("shipment_line_ga");

                entity.Property(e => e.Linegaid)
                    .HasMaxLength(255)
                    .HasColumnName("linegaid");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.GaCode)
                    .HasMaxLength(255)
                    .HasColumnName("ga_code");

                entity.Property(e => e.GaData).HasColumnName("ga_data");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<ShipmentLineValueAdj>(entity =>
            {
                entity.HasKey(e => e.Linevaid)
                    .HasName("shipment_line_value_adj_pkey");

                entity.ToTable("shipment_line_value_adj");

                entity.Property(e => e.Linevaid)
                    .HasMaxLength(255)
                    .HasColumnName("linevaid");

                entity.Property(e => e.AdjustmentAmount).HasColumnName("adjustment_amount");

                entity.Property(e => e.AdjustmentRef)
                    .HasMaxLength(255)
                    .HasColumnName("adjustment_ref");

                entity.Property(e => e.AdjustmentType)
                    .HasMaxLength(255)
                    .HasColumnName("adjustment_type");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("currency_code");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.LineId)
                    .HasMaxLength(255)
                    .HasColumnName("line_id");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(255)
                    .HasColumnName("value_type");
            });

            modelBuilder.Entity<ShipmentParty>(entity =>
            {
                entity.ToTable("shipment_party");

                entity.Property(e => e.ShipmentPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_party_id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(255)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ExternalPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("external_party_id");

                entity.Property(e => e.IsLinked)
                    .IsRequired()
                    .HasColumnName("is_linked")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PartyType)
                    .HasMaxLength(255)
                    .HasColumnName("party_type");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postal_code");

                entity.Property(e => e.RecordMods)
                    .HasMaxLength(255)
                    .HasColumnName("record_mods");

                entity.Property(e => e.RpsResultsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_id");

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(255)
                    .HasColumnName("shipment_id");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<Spi>(entity =>
            {
                entity.ToTable("spi");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.RateType)
                    .HasMaxLength(255)
                    .HasColumnName("rate_type");

                entity.Property(e => e.SpiCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_code");

                entity.Property(e => e.SpiName)
                    .HasMaxLength(255)
                    .HasColumnName("spi_name");
            });

            modelBuilder.Entity<SpiConfiguration>(entity =>
            {
                entity.ToTable("spi_configuration");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Preference)
                    .HasMaxLength(255)
                    .HasColumnName("preference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.Entity<SpiCountryMap>(entity =>
            {
                entity.ToTable("spi_country_map");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.SpiCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_code");

                entity.Property(e => e.SpiMemberCountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("spi_member_country_code");
            });

            modelBuilder.Entity<StoredProcedureExecutionStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stored_procedure_execution_status");

                entity.Property(e => e.IsRunning).HasColumnName("is_running");

                entity.Property(e => e.LastExecutionTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_execution_time");

                entity.Property(e => e.Parameters)
                    .HasMaxLength(255)
                    .HasColumnName("parameters");

                entity.Property(e => e.StoredProcedureName)
                    .HasMaxLength(255)
                    .HasColumnName("stored_procedure_name");
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.ToTable("tenant");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TenantName)
                    .HasMaxLength(255)
                    .HasColumnName("tenant_name");
            });

            modelBuilder.Entity<TradingParty>(entity =>
            {
                entity.HasKey(e => e.PartyId)
                    .HasName("trading_party_pkey");

                entity.ToTable("trading_party");

                entity.Property(e => e.PartyId)
                    .HasMaxLength(255)
                    .HasColumnName("party_id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.ComplianceStatus)
                    .HasColumnName("compliance_status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(255)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DecisionBy)
                    .HasMaxLength(255)
                    .HasColumnName("decision_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ExternalPartyId)
                    .HasMaxLength(255)
                    .HasColumnName("external_party_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(255)
                    .HasColumnName("org_id");

                entity.Property(e => e.PartyType)
                    .HasMaxLength(255)
                    .HasColumnName("party_type");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postal_code");

                entity.Property(e => e.RpsResultsId)
                    .HasMaxLength(255)
                    .HasColumnName("rps_results_id");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.SystemDecision)
                    .HasMaxLength(255)
                    .HasColumnName("system_decision");

                entity.Property(e => e.SystemDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("system_decision_date");

                entity.Property(e => e.SystemNote)
                    .HasMaxLength(255)
                    .HasColumnName("system_note");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserDecision)
                    .HasMaxLength(255)
                    .HasColumnName("user_decision");

                entity.Property(e => e.UserDecisionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("user_decision_date");

                entity.Property(e => e.UserNote)
                    .HasMaxLength(255)
                    .HasColumnName("user_note");
            });

            modelBuilder.Entity<UomList>(entity =>
            {
                entity.ToTable("uom_list");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(255)
                    .HasColumnName("code_description");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("country_code");

                entity.Property(e => e.CustomsUomCode)
                    .HasMaxLength(255)
                    .HasColumnName("customs_uom_code");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("effective_date");

                entity.Property(e => e.ExpiredBy)
                    .HasMaxLength(255)
                    .HasColumnName("expired_by");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.Uom)
                    .HasMaxLength(255)
                    .HasColumnName("uom");
            });

            modelBuilder.Entity<UserComplianceCompanyMap>(entity =>
            {
                entity.ToTable("user_compliance_company_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.UserProfileId).HasColumnName("user_profile_id");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.ToTable("user_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.ToTable("user_profile");

                entity.HasIndex(e => e.Email, "email_unique")
                    .IsUnique();

                entity.Property(e => e.UserProfileId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_profile_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CountryCode)
                    .HasColumnType("character varying")
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasColumnType("character varying")
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Language)
                    .HasMaxLength(255)
                    .HasColumnName("language");

                entity.Property(e => e.LastName)
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UserType)
                    .HasMaxLength(30)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<UserRoleMap>(entity =>
            {
                entity.ToTable("user_role_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserProfileId).HasColumnName("user_profile_id");
            });

            modelBuilder.Entity<WorkItem>(entity =>
            {
                entity.ToTable("work_item");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.ComplianceCompanyId).HasColumnName("compliance_company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");
            });

            modelBuilder.HasSequence("hibernate_sequence")
                .StartsAt(10000)
                .IncrementsBy(3);

            modelBuilder.HasSequence("queue_sequence");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
