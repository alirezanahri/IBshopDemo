using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBshopDemo.Migrations
{
    /// <inheritdoc />
    public partial class initail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtMonthlyReports",
                columns: table => new
                {
                    ArtMonthlyReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    MrkReq = table.Column<int>(type: "int", nullable: false),
                    CompStudy = table.Column<int>(type: "int", nullable: false),
                    ArchiveDesignQty = table.Column<int>(type: "int", nullable: false),
                    MediaFailureQty = table.Column<int>(type: "int", nullable: false),
                    SiteBannerAvgTime = table.Column<int>(type: "int", nullable: false),
                    BrochureDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    StoryDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    GifDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    StandDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    BannerDesignQty = table.Column<int>(type: "int", nullable: false),
                    BrochureDesignQty = table.Column<int>(type: "int", nullable: false),
                    StoryDesignQty = table.Column<int>(type: "int", nullable: false),
                    GifDesignQty = table.Column<int>(type: "int", nullable: false),
                    StandDesigQty = table.Column<int>(type: "int", nullable: false),
                    MotionQty = table.Column<int>(type: "int", nullable: false),
                    ArchivedmotionQty = table.Column<int>(type: "int", nullable: false),
                    AppliedMotionAvgTime = table.Column<int>(type: "int", nullable: false),
                    RecordedvideoQty = table.Column<int>(type: "int", nullable: false),
                    RecordedQty = table.Column<int>(type: "int", nullable: false),
                    NarrationEditQty = table.Column<int>(type: "int", nullable: false),
                    VideoArchiveQty = table.Column<int>(type: "int", nullable: false),
                    VideoProduceAvgTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMonthlyReports", x => x.ArtMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "BranchesInfos",
                columns: table => new
                {
                    BranchCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchManager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchesInfos", x => x.BranchCode);
                });

            migrationBuilder.CreateTable(
                name: "BranchesMonthlyReports",
                columns: table => new
                {
                    BranchMonthlyReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    IbcardConflictBranchQty = table.Column<int>(type: "int", nullable: false),
                    IbcrowdConflictBranchQty = table.Column<int>(type: "int", nullable: false),
                    IBcrowdKpiconflictQty = table.Column<int>(type: "int", nullable: false),
                    CoursesQty = table.Column<int>(type: "int", nullable: false),
                    OnlineExamsQty = table.Column<int>(type: "int", nullable: false),
                    CoursesNeedQty = table.Column<int>(type: "int", nullable: false),
                    ServicesToBranchQty = table.Column<int>(type: "int", nullable: false),
                    CandstoDevelopmentQty = table.Column<int>(type: "int", nullable: false),
                    ReportsConflictsToBranchQty = table.Column<int>(type: "int", nullable: false),
                    InvestmentCapitalConflicts = table.Column<int>(type: "int", nullable: false),
                    FacilityReqQty = table.Column<int>(type: "int", nullable: false),
                    SwsolvedQty = table.Column<int>(type: "int", nullable: false),
                    FundSettlementQty = table.Column<int>(type: "int", nullable: false),
                    FundsConflictsQty = table.Column<int>(type: "int", nullable: false),
                    SendtoBranch = table.Column<int>(type: "int", nullable: false),
                    MrkpacTobranchQty = table.Column<int>(type: "int", nullable: false),
                    CrttoCusQty = table.Column<int>(type: "int", nullable: false),
                    InpersonBranchQty = table.Column<int>(type: "int", nullable: false),
                    BranchTickects = table.Column<int>(type: "int", nullable: false),
                    TicketConflictsQty = table.Column<int>(type: "int", nullable: false),
                    BranchInfractionQty = table.Column<int>(type: "int", nullable: false),
                    BranchReformQty = table.Column<int>(type: "int", nullable: false),
                    BranchMonQty = table.Column<int>(type: "int", nullable: false),
                    BranchCompCheckedQty = table.Column<int>(type: "int", nullable: false),
                    AccBranchQty = table.Column<int>(type: "int", nullable: false),
                    BranchCompQty = table.Column<int>(type: "int", nullable: false),
                    BranchpersonnelQty = table.Column<int>(type: "int", nullable: false),
                    PersonnelAssuranceReqQty = table.Column<int>(type: "int", nullable: false),
                    PersonnelAdReqQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchesMonthlyReports", x => x.BranchMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "BranchKpis",
                columns: table => new
                {
                    KpibranchCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WrsupReq = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrongIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrcCnf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrongQty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrnReqQty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kllevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConIntMonPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienttoIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrcClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MrkSpv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchKpis", x => x.KpibranchCode);
                });

            migrationBuilder.CreateTable(
                name: "BranchManagerMonthlyReports",
                columns: table => new
                {
                    BranchManagerMonthlyReportIdBranchManagerMonthlyReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    BranchLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBcardMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    IBcardSuccessMtgqty = table.Column<int>(type: "int", nullable: false),
                    IBcrowdMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    IBcrowdSuccessMtgqty = table.Column<int>(type: "int", nullable: false),
                    AssuranceMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    AssuranceSuccessMtgqty = table.Column<int>(type: "int", nullable: false),
                    DebtSharesMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    DebtSharesSuccessMtgqty = table.Column<int>(type: "int", nullable: false),
                    InvestmentMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    InvesmentSuccessMtgqty = table.Column<int>(type: "int", nullable: false),
                    CoursesReq = table.Column<int>(type: "int", nullable: false),
                    CoursesMrkmtgqty = table.Column<int>(type: "int", nullable: false),
                    CoursesMrkmtgfirstAgreementQty = table.Column<int>(type: "int", nullable: false),
                    ComplainantQty = table.Column<int>(type: "int", nullable: false),
                    Conciliation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchManagerMonthlyReports", x => x.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "BranchRankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchRankingId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    GanjinehRank = table.Column<int>(type: "int", nullable: true),
                    Andokhtehrank = table.Column<int>(type: "int", nullable: true),
                    ServatRank = table.Column<int>(type: "int", nullable: true),
                    Bimehrank = table.Column<int>(type: "int", nullable: true),
                    IBcrowdrank = table.Column<int>(type: "int", nullable: true),
                    Productrank = table.Column<int>(type: "int", nullable: true),
                    Sandoghrank = table.Column<int>(type: "int", nullable: true),
                    SatisfactionRank = table.Column<int>(type: "int", nullable: true),
                    Servicerank = table.Column<int>(type: "int", nullable: true),
                    TotalRank = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchRankings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmMonthlyReports",
                columns: table => new
                {
                    Crmmrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    InChatQty = table.Column<int>(type: "int", nullable: false),
                    InCompCallQty = table.Column<int>(type: "int", nullable: false),
                    InVmQty = table.Column<int>(type: "int", nullable: false),
                    InCallQty = table.Column<int>(type: "int", nullable: false),
                    OutAccNumEditQty = table.Column<int>(type: "int", nullable: false),
                    OutsurveyQty = table.Column<int>(type: "int", nullable: false),
                    OutComTrtQty = table.Column<int>(type: "int", nullable: false),
                    OutVmQty = table.Column<int>(type: "int", nullable: false),
                    SejamQty = table.Column<int>(type: "int", nullable: false),
                    AvgCallDuration = table.Column<double>(type: "float", nullable: false),
                    AvgCallWaitingDuration = table.Column<double>(type: "float", nullable: false),
                    ToalCallDuration = table.Column<double>(type: "float", nullable: false),
                    GanjinehIssuesQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssuesVol = table.Column<double>(type: "float", nullable: false),
                    AndookhtehIssuesQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssuesVol = table.Column<double>(type: "float", nullable: false),
                    GoharandServatIssuesQty = table.Column<int>(type: "int", nullable: false),
                    GoharandServatIssuesVol = table.Column<double>(type: "float", nullable: false),
                    TotalIssuesQty = table.Column<int>(type: "int", nullable: false),
                    TotalIssuesVol = table.Column<double>(type: "float", nullable: false),
                    CrmcoursesQty = table.Column<int>(type: "int", nullable: false),
                    TicketOnlineQty = table.Column<int>(type: "int", nullable: false),
                    Inticket = table.Column<int>(type: "int", nullable: false),
                    ComplaintTicketQty = table.Column<int>(type: "int", nullable: false),
                    SurveyTicketQty = table.Column<int>(type: "int", nullable: false),
                    InSurveyCallQty = table.Column<int>(type: "int", nullable: false),
                    OutSurveyCallQty = table.Column<int>(type: "int", nullable: false),
                    OnlineChatsurveyQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehTicketQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehicketQty = table.Column<int>(type: "int", nullable: false),
                    ServatafarinanTicketQty = table.Column<int>(type: "int", nullable: false),
                    GoharTicketQty = table.Column<int>(type: "int", nullable: false),
                    IbCardTicketQty = table.Column<int>(type: "int", nullable: false),
                    IbCrowdTicketQty = table.Column<int>(type: "int", nullable: false),
                    BranchComplTicketQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmMonthlyReports", x => x.Crmmrid);
                });

            migrationBuilder.CreateTable(
                name: "FinancialMonthlyReports",
                columns: table => new
                {
                    FinancialMonthlyReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    PersonnelSetQty = table.Column<int>(type: "int", nullable: false),
                    CheckedfundQty = table.Column<int>(type: "int", nullable: false),
                    ContQty = table.Column<int>(type: "int", nullable: false),
                    TreasuryBillsQty = table.Column<int>(type: "int", nullable: false),
                    Recivedgaurantee = table.Column<int>(type: "int", nullable: false),
                    RestaxinstallmentQty = table.Column<int>(type: "int", nullable: false),
                    ResFundInstallmenQty = table.Column<int>(type: "int", nullable: false),
                    TaminInstallmentQty = table.Column<int>(type: "int", nullable: false),
                    TaminPenaltyVol = table.Column<int>(type: "int", nullable: false),
                    TranCommissionQty = table.Column<int>(type: "int", nullable: false),
                    TaminInstallmentDelay = table.Column<int>(type: "int", nullable: false),
                    TaxInstallmentDelay = table.Column<int>(type: "int", nullable: false),
                    PrpReqQty = table.Column<int>(type: "int", nullable: false),
                    MtnprpQty = table.Column<int>(type: "int", nullable: false),
                    ColPrpQty = table.Column<int>(type: "int", nullable: false),
                    LblPrpQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialMonthlyReports", x => x.FinancialMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialSuperMarketMonthlyReports",
                columns: table => new
                {
                    SuperMrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    CustomersReplyQty = table.Column<int>(type: "int", nullable: false),
                    IbshoppRegisterQty = table.Column<int>(type: "int", nullable: false),
                    AuthenticationQty = table.Column<int>(type: "int", nullable: false),
                    ActivationQty = table.Column<int>(type: "int", nullable: false),
                    ReportForCustomerC = table.Column<int>(type: "int", nullable: false),
                    ReportForCustomerF = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssuesVol = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssuesVol = table.Column<int>(type: "int", nullable: false),
                    GoharandServatIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    GohrandServatIssuesVol = table.Column<int>(type: "int", nullable: false),
                    GanjinehRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehRevokeVol = table.Column<int>(type: "int", nullable: false),
                    AndookhtehRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehRevokeVol = table.Column<int>(type: "int", nullable: false),
                    GoharandServatRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    GohrandServatRevokeVol = table.Column<int>(type: "int", nullable: false),
                    TotIsuuVol = table.Column<int>(type: "int", nullable: false),
                    TotRevVol = table.Column<int>(type: "int", nullable: false),
                    EditQty = table.Column<int>(type: "int", nullable: false),
                    LegalServQty = table.Column<int>(type: "int", nullable: false),
                    CardIssuanceQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardVol = table.Column<int>(type: "int", nullable: false),
                    InvestorsQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcrowdVol = table.Column<int>(type: "int", nullable: false),
                    InsuranceIssued = table.Column<int>(type: "int", nullable: false),
                    CreaditQty = table.Column<int>(type: "int", nullable: false),
                    CreaditVol = table.Column<int>(type: "int", nullable: false),
                    OnlineCodeQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialSuperMarketMonthlyReports", x => x.SuperMrid);
                });

            migrationBuilder.CreateTable(
                name: "HrMonthlyReports",
                columns: table => new
                {
                    HrmonthlyreportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    HrpersonnelQty = table.Column<int>(type: "int", nullable: false),
                    LeftQty = table.Column<int>(type: "int", nullable: false),
                    HrmhiredQty = table.Column<int>(type: "int", nullable: false),
                    Obqty = table.Column<int>(type: "int", nullable: false),
                    Reqqty = table.Column<int>(type: "int", nullable: false),
                    SentCvtoDep = table.Column<int>(type: "int", nullable: false),
                    CoursQty = table.Column<int>(type: "int", nullable: false),
                    IntQty = table.Column<int>(type: "int", nullable: false),
                    RsgReq = table.Column<int>(type: "int", nullable: false),
                    UsedImp = table.Column<int>(type: "int", nullable: false),
                    Gcissu = table.Column<int>(type: "int", nullable: false),
                    SrvAsgNewPer = table.Column<int>(type: "int", nullable: false),
                    AsuAsgNewPer = table.Column<int>(type: "int", nullable: false),
                    GurReqFun = table.Column<int>(type: "int", nullable: false),
                    GurReqLtt = table.Column<int>(type: "int", nullable: false),
                    PyrDedReqLtt = table.Column<int>(type: "int", nullable: false),
                    SendOutLtt = table.Column<int>(type: "int", nullable: false),
                    SendIntLtt = table.Column<int>(type: "int", nullable: false),
                    RecLtt = table.Column<int>(type: "int", nullable: false),
                    PerEntCnfQty = table.Column<int>(type: "int", nullable: false),
                    PreFailQty = table.Column<int>(type: "int", nullable: false),
                    ReplacemntQty = table.Column<int>(type: "int", nullable: false),
                    Rrfail = table.Column<int>(type: "int", nullable: false),
                    RrfacFail = table.Column<int>(type: "int", nullable: false),
                    LobFailQty = table.Column<int>(type: "int", nullable: false),
                    FloFailQty = table.Column<int>(type: "int", nullable: false),
                    TblFailQty = table.Column<int>(type: "int", nullable: false),
                    StrFailQty = table.Column<int>(type: "int", nullable: false),
                    MngRfailQty = table.Column<int>(type: "int", nullable: false),
                    BrkFailQty = table.Column<int>(type: "int", nullable: false),
                    PntFailQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrMonthlyReports", x => x.HrmonthlyreportId);
                });

            migrationBuilder.CreateTable(
                name: "IncomeCenters",
                columns: table => new
                {
                    IncomecenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeCenters", x => x.IncomecenterId);
                });

            migrationBuilder.CreateTable(
                name: "Kpicrms",
                columns: table => new
                {
                    Kpicrmcode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NegFb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocallQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fcsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusReqMetPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MissedCallPercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutAnsPercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftCallPercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SrvPrdSatPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelAvr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallAnsSpd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wtunder3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcallCostAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallAnsSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersComImpSer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeCusNeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdAwaPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerImpPrdSur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewtooldSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Csat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MrkOutcall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crmiss = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpicrms", x => x.Kpicrmcode);
                });

            migrationBuilder.CreateTable(
                name: "Kpidevelopments",
                columns: table => new
                {
                    KpidevelomentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RdinPrdImp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeCusNeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewTooldsat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerImpPrdSur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdAwaPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewCusinSrvPrd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SugCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SugInc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvSugAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccsugRate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpidevelopments", x => x.KpidevelomentCode);
                });

            migrationBuilder.CreateTable(
                name: "Kpifinancials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KpifinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtdecLegRe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RvwAccConflicts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RvwInvConflicts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevPlnBudPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncBudMeetPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemistakeFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcrFinRepPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtrTimeDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedAssetConflict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillIssueAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnrctrInvoicesMatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdrecintotalRec = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpifinancials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kpihrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kpihrcode = table.Column<int>(type: "int", nullable: false),
                    RecEff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EduEfc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnColeagPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MistakeinPersonalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalMistakePerc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColLoyPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EduCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProEduCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgmEduCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenEduCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PapConCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntColCam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReqToNeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IctsrvSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcallCostAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecDelRat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrRecDelRat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpihrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kpimarkets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KpimarketingCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistertoIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewCusAsset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegMrk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrcMrkRti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePlanDsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MrkStgDsg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpimarkets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kpiplannings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KpiplanCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelonPrConf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffImpAct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtimpPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrImPercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmsavePercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivePer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nps = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kpiplannings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketingMonthlyReports",
                columns: table => new
                {
                    Mrkmrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    SentSmsQty = table.Column<int>(type: "int", nullable: false),
                    ReportAdvQty = table.Column<int>(type: "int", nullable: false),
                    NotifPushQty = table.Column<int>(type: "int", nullable: false),
                    PostMediaQty = table.Column<int>(type: "int", nullable: false),
                    StateMedAdvQty = table.Column<int>(type: "int", nullable: false),
                    BilboardQty = table.Column<int>(type: "int", nullable: false),
                    SrchEntQty = table.Column<int>(type: "int", nullable: false),
                    RefEntQty = table.Column<int>(type: "int", nullable: false),
                    SmedEntQty = table.Column<int>(type: "int", nullable: false),
                    SiteEntMonthlyAvg = table.Column<int>(type: "int", nullable: false),
                    InstFlwQty = table.Column<int>(type: "int", nullable: false),
                    EngQty = table.Column<int>(type: "int", nullable: false),
                    TlgPostContentQty = table.Column<int>(type: "int", nullable: false),
                    LinkdinContentQty = table.Column<int>(type: "int", nullable: false),
                    DesignQty = table.Column<int>(type: "int", nullable: false),
                    VideoQty = table.Column<int>(type: "int", nullable: false),
                    HoldQty = table.Column<int>(type: "int", nullable: false),
                    HoldComptQty = table.Column<int>(type: "int", nullable: false),
                    RecVidPostQty = table.Column<int>(type: "int", nullable: false),
                    TrainPostQty = table.Column<int>(type: "int", nullable: false),
                    InsFlwQty = table.Column<int>(type: "int", nullable: false),
                    NewsQty = table.Column<int>(type: "int", nullable: false),
                    TrainingCntrctQty = table.Column<int>(type: "int", nullable: false),
                    IbcrowdCalllegalCusQty = table.Column<int>(type: "int", nullable: false),
                    PrdSrvAdvCallQty = table.Column<int>(type: "int", nullable: false),
                    SucCallQty = table.Column<int>(type: "int", nullable: false),
                    ToalInvestVol = table.Column<int>(type: "int", nullable: false),
                    ConversationRate = table.Column<int>(type: "int", nullable: false),
                    BounceRate = table.Column<int>(type: "int", nullable: true),
                    KeywordsRank = table.Column<int>(type: "int", nullable: false),
                    GoogleEntTerRate = table.Column<int>(type: "int", nullable: false),
                    LinkEntTerRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingMonthlyReports", x => x.Mrkmrid);
                });

            migrationBuilder.CreateTable(
                name: "OperationKpis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationKpicode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Piapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppDev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answeringspeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IbCardAutAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SejAutAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayToCusAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusAutAsset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SucOprRate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationKpis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationMonthlyReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oprmrid = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    PoseConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    SmsinternetConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    BranchInternetConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    IntternetEntranceConflictReq = table.Column<int>(type: "int", nullable: false),
                    FixedConflictQty = table.Column<int>(type: "int", nullable: false),
                    TotalConflictsProcess = table.Column<int>(type: "int", nullable: false),
                    BkgNewCustomer = table.Column<int>(type: "int", nullable: false),
                    BkgReqCnfqty = table.Column<int>(type: "int", nullable: false),
                    BkgCrdVol = table.Column<int>(type: "int", nullable: false),
                    BkgCrdQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardIssuesVol = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardIssuesQty = table.Column<int>(type: "int", nullable: false),
                    TotalTransferVol = table.Column<int>(type: "int", nullable: false),
                    TotalmsgQty = table.Column<int>(type: "int", nullable: false),
                    RemotChcAut = table.Column<int>(type: "int", nullable: false),
                    TotalEditAcc = table.Column<int>(type: "int", nullable: false),
                    TotalIdeEdit = table.Column<int>(type: "int", nullable: false),
                    TotalLegAut = table.Column<int>(type: "int", nullable: false),
                    TotalChcSejam = table.Column<int>(type: "int", nullable: false),
                    TotalIssuCrt = table.Column<int>(type: "int", nullable: false),
                    AbCganjinehTamaddon = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehTamaddonRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehShahr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehShahrRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehSandogh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehSandoghRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehSamaneh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehSamanehRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehBranches = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehBranchesRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehShahrnet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehShahrnetRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCganjinehTotalRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehTamaddon = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehTamaddonRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehShahr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehShahrRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehOtherBanks = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehOtherBanksRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehSandogh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehSandoghRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehSamaneh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehSamanehRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehBranch = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehBranchRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehShahrnet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehShahrnetRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCandookhtehTotalRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatTamaddon = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatTamaddonRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatSamaneh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatSamanehRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatBranch = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatBranchRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatSandogh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatSandoghRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCservatTotalRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharTamaddon = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharTamaddonRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharSamaneh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharSamanehRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharBranch = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharBranchRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharSandogh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharSandoghRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbCgoharTotalRe = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationMonthlyReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDesignMonthlyReports",
                columns: table => new
                {
                    ProcessDesignMrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    PrcdQty = table.Column<int>(type: "int", nullable: false),
                    RelPrcdQty = table.Column<int>(type: "int", nullable: false),
                    InsQty = table.Column<int>(type: "int", nullable: false),
                    RelInsQty = table.Column<int>(type: "int", nullable: false),
                    RegQty = table.Column<int>(type: "int", nullable: false),
                    RelReqQty = table.Column<int>(type: "int", nullable: false),
                    FormQty = table.Column<int>(type: "int", nullable: false),
                    PrcDesign = table.Column<int>(type: "int", nullable: false),
                    ReviewPrc = table.Column<int>(type: "int", nullable: false),
                    AsmPrc = table.Column<int>(type: "int", nullable: false),
                    DlgQty = table.Column<int>(type: "int", nullable: false),
                    IndexQty = table.Column<int>(type: "int", nullable: false),
                    ReviwIndxQty = table.Column<int>(type: "int", nullable: false),
                    KpimonitoringQty = table.Column<int>(type: "int", nullable: false),
                    MrkcommHold = table.Column<int>(type: "int", nullable: false),
                    MrkDoneCmm = table.Column<int>(type: "int", nullable: false),
                    MrkFailCmm = table.Column<int>(type: "int", nullable: false),
                    DevCommHold = table.Column<int>(type: "int", nullable: false),
                    DevDoneCmm = table.Column<int>(type: "int", nullable: false),
                    DevFailCmm = table.Column<int>(type: "int", nullable: false),
                    CrmcommHold = table.Column<int>(type: "int", nullable: false),
                    CrmdoneCmm = table.Column<int>(type: "int", nullable: false),
                    CrmfailCmm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDesignMonthlyReports", x => x.ProcessDesignMrid);
                });

            migrationBuilder.CreateTable(
                name: "ProductDevelopmentMontylyReports",
                columns: table => new
                {
                    DevMrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    CheckedSuggestQty = table.Column<int>(type: "int", nullable: false),
                    AcceptedSuggestQty = table.Column<int>(type: "int", nullable: false),
                    SuggestPersonnelQty = table.Column<int>(type: "int", nullable: false),
                    EconomicalSuggestQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreaditCardCustQty = table.Column<int>(type: "int", nullable: false),
                    IbcComplQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreadiCardReqQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreaditCardProcessAvgTime = table.Column<int>(type: "int", nullable: false),
                    IbwDesignQty = table.Column<int>(type: "int", nullable: false),
                    IbwDesignVol = table.Column<int>(type: "int", nullable: false),
                    IbwDesignTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDevelopmentMontylyReports", x => x.DevMrid);
                });

            migrationBuilder.CreateTable(
                name: "QaMonthlyReports",
                columns: table => new
                {
                    Qamrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    TotalPersonnelIncCallQty = table.Column<int>(type: "int", nullable: false),
                    TotalChcIncCallQty = table.Column<int>(type: "int", nullable: false),
                    WelFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    WelFailIncQty = table.Column<int>(type: "int", nullable: false),
                    SurFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    SurFailIncQty = table.Column<int>(type: "int", nullable: false),
                    KnwFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    KnwFailIncQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    ProFailIncQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    TicFailIncQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtPerIncQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtIncQty = table.Column<int>(type: "int", nullable: false),
                    SysFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    SysFailIncQty = table.Column<int>(type: "int", nullable: false),
                    TotalPersonnelOutCallQty = table.Column<int>(type: "int", nullable: false),
                    TotalChcOutCallQty = table.Column<int>(type: "int", nullable: false),
                    SurFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    SurFailOutQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    ProFailOutQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    TicFailOutQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtPerOutQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtOutQty = table.Column<int>(type: "int", nullable: false),
                    ToalOnlineChat = table.Column<int>(type: "int", nullable: false),
                    TotalCheckedOnlineChat = table.Column<int>(type: "int", nullable: false),
                    SurFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    SurFailChatQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    ProFailChatQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    TicFailChatQty = table.Column<int>(type: "int", nullable: false),
                    TimFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    TimFailChatQty = table.Column<int>(type: "int", nullable: false),
                    SurveyChatOnline = table.Column<int>(type: "int", nullable: false),
                    HgradeQty = table.Column<int>(type: "int", nullable: false),
                    GgradeQty = table.Column<int>(type: "int", nullable: false),
                    FgradeQty = table.Column<int>(type: "int", nullable: false),
                    EgradeQty = table.Column<int>(type: "int", nullable: false),
                    DgradeQty = table.Column<int>(type: "int", nullable: false),
                    CgradeQty = table.Column<int>(type: "int", nullable: false),
                    BgradeQty = table.Column<int>(type: "int", nullable: false),
                    AgradeQty = table.Column<int>(type: "int", nullable: false),
                    ApgradeQty = table.Column<int>(type: "int", nullable: false),
                    RepFail = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QaMonthlyReports", x => x.Qamrid);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleUniqeCode = table.Column<int>(type: "int", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "FixIncomeProperties",
                columns: table => new
                {
                    FixIncomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    InComeCenterId = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerQty = table.Column<int>(type: "int", nullable: true),
                    GanjinehIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GanjinehRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AndookhtehIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AndookhtehRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VirIssueBillQty = table.Column<int>(type: "int", nullable: false),
                    VirIssueBillVol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrancheCodeNavigationBranchCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixIncomeProperties", x => x.FixIncomeId);
                    table.ForeignKey(
                        name: "FK_FixIncomeProperties_BranchesInfos_BrancheCodeNavigationBranchCode",
                        column: x => x.BrancheCodeNavigationBranchCode,
                        principalTable: "BranchesInfos",
                        principalColumn: "BranchCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FixIncomeProperties_IncomeCenters_InComeCenterId",
                        column: x => x.InComeCenterId,
                        principalTable: "IncomeCenters",
                        principalColumn: "IncomecenterId");
                });

            migrationBuilder.CreateTable(
                name: "MixProperties",
                columns: table => new
                {
                    MixIncomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    IncomeCenterId = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<int>(type: "int", nullable: true),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServatIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServatRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GoharIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GoharRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalIssue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRev = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrancheCodeNavigationBranchCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixProperties", x => x.MixIncomeId);
                    table.ForeignKey(
                        name: "FK_MixProperties_BranchesInfos_BrancheCodeNavigationBranchCode",
                        column: x => x.BrancheCodeNavigationBranchCode,
                        principalTable: "BranchesInfos",
                        principalColumn: "BranchCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixProperties_IncomeCenters_IncomeCenterId",
                        column: x => x.IncomeCenterId,
                        principalTable: "IncomeCenters",
                        principalColumn: "IncomecenterId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    IncomeCenterId = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<int>(type: "int", nullable: true),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IbcrowdVol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IbcardIssueQty = table.Column<int>(type: "int", nullable: false),
                    CardQty = table.Column<int>(type: "int", nullable: false),
                    KargozariBoursCode = table.Column<int>(type: "int", nullable: false),
                    DealValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrancheCodeNavigationBranchCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                    table.ForeignKey(
                        name: "FK_Products_BranchesInfos_BrancheCodeNavigationBranchCode",
                        column: x => x.BrancheCodeNavigationBranchCode,
                        principalTable: "BranchesInfos",
                        principalColumn: "BranchCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_IncomeCenters_IncomeCenterId",
                        column: x => x.IncomeCenterId,
                        principalTable: "IncomeCenters",
                        principalColumn: "IncomecenterId");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FixIncomeProperties_BrancheCodeNavigationBranchCode",
                table: "FixIncomeProperties",
                column: "BrancheCodeNavigationBranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_FixIncomeProperties_InComeCenterId",
                table: "FixIncomeProperties",
                column: "InComeCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MixProperties_BrancheCodeNavigationBranchCode",
                table: "MixProperties",
                column: "BrancheCodeNavigationBranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_MixProperties_IncomeCenterId",
                table: "MixProperties",
                column: "IncomeCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrancheCodeNavigationBranchCode",
                table: "Products",
                column: "BrancheCodeNavigationBranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IncomeCenterId",
                table: "Products",
                column: "IncomeCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMonthlyReports");

            migrationBuilder.DropTable(
                name: "BranchesMonthlyReports");

            migrationBuilder.DropTable(
                name: "BranchKpis");

            migrationBuilder.DropTable(
                name: "BranchManagerMonthlyReports");

            migrationBuilder.DropTable(
                name: "BranchRankings");

            migrationBuilder.DropTable(
                name: "CrmMonthlyReports");

            migrationBuilder.DropTable(
                name: "FinancialMonthlyReports");

            migrationBuilder.DropTable(
                name: "FinancialSuperMarketMonthlyReports");

            migrationBuilder.DropTable(
                name: "FixIncomeProperties");

            migrationBuilder.DropTable(
                name: "HrMonthlyReports");

            migrationBuilder.DropTable(
                name: "Kpicrms");

            migrationBuilder.DropTable(
                name: "Kpidevelopments");

            migrationBuilder.DropTable(
                name: "Kpifinancials");

            migrationBuilder.DropTable(
                name: "Kpihrs");

            migrationBuilder.DropTable(
                name: "Kpimarkets");

            migrationBuilder.DropTable(
                name: "Kpiplannings");

            migrationBuilder.DropTable(
                name: "MarketingMonthlyReports");

            migrationBuilder.DropTable(
                name: "MixProperties");

            migrationBuilder.DropTable(
                name: "OperationKpis");

            migrationBuilder.DropTable(
                name: "OperationMonthlyReports");

            migrationBuilder.DropTable(
                name: "ProcessDesignMonthlyReports");

            migrationBuilder.DropTable(
                name: "ProductDevelopmentMontylyReports");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "QaMonthlyReports");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "BranchesInfos");

            migrationBuilder.DropTable(
                name: "IncomeCenters");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
