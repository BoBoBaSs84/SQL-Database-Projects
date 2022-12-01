using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace Master.SQL.Tests;
[TestClass()]
public class SqlServerUnitTest : SqlDatabaseTestClass
{
	private TransactionScope transaction;

	public SqlServerUnitTest() => InitializeComponent();

	[TestInitialize()]
	public void TestInitialize()
	{
		transaction = new();
		base.InitializeTest();
	}

	[TestCleanup()]
	public void TestCleanup()
	{
		base.CleanupTest();
		transaction.Dispose();
	}

	#region Designer support code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetAllCulturesSuccessTest_TestAction;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest));
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetAllCulturesScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByNameSqlNullValueExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetDateRangeSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetDateRangeRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetNeutralCulturesSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetNeutralCulturesScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByCodeSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetCultureByCodeRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByNameSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetCultureByNameRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByNameUnknownLocaleTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition GetCultureByNameChecksumCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetDateRangeArgumentExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetDateRangeNullTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetDateRangeScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetLangageCodeIdentifierSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetLangageCodeIdentifierScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_WhoAmITest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
		this.clr_GetAllCulturesSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByNameSqlNullValueExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetDateRangeSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetNeutralCulturesSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByCodeSqlNullValueExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByCodeSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByNameSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByNameUnknownLocaleTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetCultureByNameCultureNotFoundExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetDateRangeArgumentExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetDateRangeNullTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetLangageCodeIdentifierSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.private_WhoAmITestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		clr_GetAllCulturesSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetAllCulturesScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		clr_GetCultureByNameSqlNullValueExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		clr_GetDateRangeSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetDateRangeRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		clr_GetNeutralCulturesSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetNeutralCulturesScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		clr_GetCultureByCodeSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByCodeRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		clr_GetCultureByNameSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByNameRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		clr_GetCultureByNameUnknownLocaleTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByNameChecksumCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
		clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		clr_GetDateRangeArgumentExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		clr_GetDateRangeNullTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetDateRangeScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		clr_GetLangageCodeIdentifierSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetLangageCodeIdentifierScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		private_WhoAmITest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		// 
		// clr_GetAllCulturesSuccessTest_TestAction
		// 
		clr_GetAllCulturesSuccessTest_TestAction.Conditions.Add(GetAllCulturesScalarValueCondition);
		resources.ApplyResources(clr_GetAllCulturesSuccessTest_TestAction, "clr_GetAllCulturesSuccessTest_TestAction");
		// 
		// GetAllCulturesScalarValueCondition
		// 
		GetAllCulturesScalarValueCondition.ColumnNumber = 1;
		GetAllCulturesScalarValueCondition.Enabled = true;
		GetAllCulturesScalarValueCondition.ExpectedValue = "True";
		GetAllCulturesScalarValueCondition.Name = "GetAllCulturesScalarValueCondition";
		GetAllCulturesScalarValueCondition.NullExpected = false;
		GetAllCulturesScalarValueCondition.ResultSet = 1;
		GetAllCulturesScalarValueCondition.RowNumber = 1;
		// 
		// clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction, "clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction");
		// 
		// clr_GetCultureByNameSqlNullValueExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetCultureByNameSqlNullValueExceptionTest_TestAction, "clr_GetCultureByNameSqlNullValueExceptionTest_TestAction");
		// 
		// clr_GetDateRangeSuccessTest_TestAction
		// 
		clr_GetDateRangeSuccessTest_TestAction.Conditions.Add(GetDateRangeRowCountCondition);
		resources.ApplyResources(clr_GetDateRangeSuccessTest_TestAction, "clr_GetDateRangeSuccessTest_TestAction");
		// 
		// GetDateRangeRowCountCondition
		// 
		GetDateRangeRowCountCondition.Enabled = true;
		GetDateRangeRowCountCondition.Name = "GetDateRangeRowCountCondition";
		GetDateRangeRowCountCondition.ResultSet = 1;
		GetDateRangeRowCountCondition.RowCount = 21;
		// 
		// clr_GetNeutralCulturesSuccessTest_TestAction
		// 
		clr_GetNeutralCulturesSuccessTest_TestAction.Conditions.Add(GetNeutralCulturesScalarValueCondition);
		resources.ApplyResources(clr_GetNeutralCulturesSuccessTest_TestAction, "clr_GetNeutralCulturesSuccessTest_TestAction");
		// 
		// GetNeutralCulturesScalarValueCondition
		// 
		GetNeutralCulturesScalarValueCondition.ColumnNumber = 1;
		GetNeutralCulturesScalarValueCondition.Enabled = true;
		GetNeutralCulturesScalarValueCondition.ExpectedValue = "True";
		GetNeutralCulturesScalarValueCondition.Name = "GetNeutralCulturesScalarValueCondition";
		GetNeutralCulturesScalarValueCondition.NullExpected = false;
		GetNeutralCulturesScalarValueCondition.ResultSet = 1;
		GetNeutralCulturesScalarValueCondition.RowNumber = 1;
		// 
		// clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction, "clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction");
		// 
		// clr_GetCultureByCodeSuccessTest_TestAction
		// 
		clr_GetCultureByCodeSuccessTest_TestAction.Conditions.Add(GetCultureByCodeRowCountCondition);
		resources.ApplyResources(clr_GetCultureByCodeSuccessTest_TestAction, "clr_GetCultureByCodeSuccessTest_TestAction");
		// 
		// GetCultureByCodeRowCountCondition
		// 
		GetCultureByCodeRowCountCondition.Enabled = true;
		GetCultureByCodeRowCountCondition.Name = "GetCultureByCodeRowCountCondition";
		GetCultureByCodeRowCountCondition.ResultSet = 1;
		GetCultureByCodeRowCountCondition.RowCount = 1;
		// 
		// clr_GetCultureByNameSuccessTest_TestAction
		// 
		clr_GetCultureByNameSuccessTest_TestAction.Conditions.Add(GetCultureByNameRowCountCondition);
		resources.ApplyResources(clr_GetCultureByNameSuccessTest_TestAction, "clr_GetCultureByNameSuccessTest_TestAction");
		// 
		// GetCultureByNameRowCountCondition
		// 
		GetCultureByNameRowCountCondition.Enabled = true;
		GetCultureByNameRowCountCondition.Name = "GetCultureByNameRowCountCondition";
		GetCultureByNameRowCountCondition.ResultSet = 1;
		GetCultureByNameRowCountCondition.RowCount = 1;
		// 
		// clr_GetCultureByNameUnknownLocaleTest_TestAction
		// 
		clr_GetCultureByNameUnknownLocaleTest_TestAction.Conditions.Add(GetCultureByNameChecksumCondition);
		resources.ApplyResources(clr_GetCultureByNameUnknownLocaleTest_TestAction, "clr_GetCultureByNameUnknownLocaleTest_TestAction");
		// 
		// GetCultureByNameChecksumCondition
		// 
		GetCultureByNameChecksumCondition.Checksum = "-1285073688";
		GetCultureByNameChecksumCondition.Enabled = true;
		GetCultureByNameChecksumCondition.Name = "GetCultureByNameChecksumCondition";
		// 
		// clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction, "clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction");
		// 
		// clr_GetDateRangeArgumentExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetDateRangeArgumentExceptionTest_TestAction, "clr_GetDateRangeArgumentExceptionTest_TestAction");
		// 
		// clr_GetDateRangeNullTest_TestAction
		// 
		clr_GetDateRangeNullTest_TestAction.Conditions.Add(GetDateRangeScalarValueCondition);
		resources.ApplyResources(clr_GetDateRangeNullTest_TestAction, "clr_GetDateRangeNullTest_TestAction");
		// 
		// GetDateRangeScalarValueCondition
		// 
		GetDateRangeScalarValueCondition.ColumnNumber = 1;
		GetDateRangeScalarValueCondition.Enabled = true;
		GetDateRangeScalarValueCondition.ExpectedValue = "1900-01-01";
		GetDateRangeScalarValueCondition.Name = "GetDateRangeScalarValueCondition";
		GetDateRangeScalarValueCondition.NullExpected = false;
		GetDateRangeScalarValueCondition.ResultSet = 1;
		GetDateRangeScalarValueCondition.RowNumber = 1;
		// 
		// clr_GetLangageCodeIdentifierSuccessTest_TestAction
		// 
		clr_GetLangageCodeIdentifierSuccessTest_TestAction.Conditions.Add(GetLangageCodeIdentifierScalarValueCondition);
		resources.ApplyResources(clr_GetLangageCodeIdentifierSuccessTest_TestAction, "clr_GetLangageCodeIdentifierSuccessTest_TestAction");
		// 
		// GetLangageCodeIdentifierScalarValueCondition
		// 
		GetLangageCodeIdentifierScalarValueCondition.ColumnNumber = 1;
		GetLangageCodeIdentifierScalarValueCondition.Enabled = true;
		GetLangageCodeIdentifierScalarValueCondition.ExpectedValue = "2057";
		GetLangageCodeIdentifierScalarValueCondition.Name = "GetLangageCodeIdentifierScalarValueCondition";
		GetLangageCodeIdentifierScalarValueCondition.NullExpected = false;
		GetLangageCodeIdentifierScalarValueCondition.ResultSet = 1;
		GetLangageCodeIdentifierScalarValueCondition.RowNumber = 1;
		// 
		// clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction
		// 
		resources.ApplyResources(clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction, "clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction");
		// 
		// private_WhoAmITest_TestAction
		// 
		private_WhoAmITest_TestAction.Conditions.Add(rowCountCondition1);
		resources.ApplyResources(private_WhoAmITest_TestAction, "private_WhoAmITest_TestAction");
		// 
		// rowCountCondition1
		// 
		rowCountCondition1.Enabled = true;
		rowCountCondition1.Name = "rowCountCondition1";
		rowCountCondition1.ResultSet = 1;
		rowCountCondition1.RowCount = 1;
		// 
		// clr_GetAllCulturesSuccessTestData
		// 
		this.clr_GetAllCulturesSuccessTestData.PosttestAction = null;
		this.clr_GetAllCulturesSuccessTestData.PretestAction = null;
		this.clr_GetAllCulturesSuccessTestData.TestAction = clr_GetAllCulturesSuccessTest_TestAction;
		// 
		// clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData
		// 
		this.clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData.PosttestAction = null;
		this.clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData.PretestAction = null;
		this.clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData.TestAction = clr_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction;
		// 
		// clr_GetCultureByNameSqlNullValueExceptionTestData
		// 
		this.clr_GetCultureByNameSqlNullValueExceptionTestData.PosttestAction = null;
		this.clr_GetCultureByNameSqlNullValueExceptionTestData.PretestAction = null;
		this.clr_GetCultureByNameSqlNullValueExceptionTestData.TestAction = clr_GetCultureByNameSqlNullValueExceptionTest_TestAction;
		// 
		// clr_GetDateRangeSuccessTestData
		// 
		this.clr_GetDateRangeSuccessTestData.PosttestAction = null;
		this.clr_GetDateRangeSuccessTestData.PretestAction = null;
		this.clr_GetDateRangeSuccessTestData.TestAction = clr_GetDateRangeSuccessTest_TestAction;
		// 
		// clr_GetNeutralCulturesSuccessTestData
		// 
		this.clr_GetNeutralCulturesSuccessTestData.PosttestAction = null;
		this.clr_GetNeutralCulturesSuccessTestData.PretestAction = null;
		this.clr_GetNeutralCulturesSuccessTestData.TestAction = clr_GetNeutralCulturesSuccessTest_TestAction;
		// 
		// clr_GetCultureByCodeSqlNullValueExceptionTestData
		// 
		this.clr_GetCultureByCodeSqlNullValueExceptionTestData.PosttestAction = null;
		this.clr_GetCultureByCodeSqlNullValueExceptionTestData.PretestAction = null;
		this.clr_GetCultureByCodeSqlNullValueExceptionTestData.TestAction = clr_GetCultureByCodeSqlNullValueExceptionTest_TestAction;
		// 
		// clr_GetCultureByCodeSuccessTestData
		// 
		this.clr_GetCultureByCodeSuccessTestData.PosttestAction = null;
		this.clr_GetCultureByCodeSuccessTestData.PretestAction = null;
		this.clr_GetCultureByCodeSuccessTestData.TestAction = clr_GetCultureByCodeSuccessTest_TestAction;
		// 
		// clr_GetCultureByNameSuccessTestData
		// 
		this.clr_GetCultureByNameSuccessTestData.PosttestAction = null;
		this.clr_GetCultureByNameSuccessTestData.PretestAction = null;
		this.clr_GetCultureByNameSuccessTestData.TestAction = clr_GetCultureByNameSuccessTest_TestAction;
		// 
		// clr_GetCultureByNameUnknownLocaleTestData
		// 
		this.clr_GetCultureByNameUnknownLocaleTestData.PosttestAction = null;
		this.clr_GetCultureByNameUnknownLocaleTestData.PretestAction = null;
		this.clr_GetCultureByNameUnknownLocaleTestData.TestAction = clr_GetCultureByNameUnknownLocaleTest_TestAction;
		// 
		// clr_GetCultureByNameCultureNotFoundExceptionTestData
		// 
		this.clr_GetCultureByNameCultureNotFoundExceptionTestData.PosttestAction = null;
		this.clr_GetCultureByNameCultureNotFoundExceptionTestData.PretestAction = null;
		this.clr_GetCultureByNameCultureNotFoundExceptionTestData.TestAction = clr_GetCultureByNameCultureNotFoundExceptionTest_TestAction;
		// 
		// clr_GetDateRangeArgumentExceptionTestData
		// 
		this.clr_GetDateRangeArgumentExceptionTestData.PosttestAction = null;
		this.clr_GetDateRangeArgumentExceptionTestData.PretestAction = null;
		this.clr_GetDateRangeArgumentExceptionTestData.TestAction = clr_GetDateRangeArgumentExceptionTest_TestAction;
		// 
		// clr_GetDateRangeNullTestData
		// 
		this.clr_GetDateRangeNullTestData.PosttestAction = null;
		this.clr_GetDateRangeNullTestData.PretestAction = null;
		this.clr_GetDateRangeNullTestData.TestAction = clr_GetDateRangeNullTest_TestAction;
		// 
		// clr_GetLangageCodeIdentifierSuccessTestData
		// 
		this.clr_GetLangageCodeIdentifierSuccessTestData.PosttestAction = null;
		this.clr_GetLangageCodeIdentifierSuccessTestData.PretestAction = null;
		this.clr_GetLangageCodeIdentifierSuccessTestData.TestAction = clr_GetLangageCodeIdentifierSuccessTest_TestAction;
		// 
		// clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData
		// 
		this.clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData.PosttestAction = null;
		this.clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData.PretestAction = null;
		this.clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData.TestAction = clr_GetLangageCodeIdentifierSqlNullValueExceptionTest_TestAction;
		// 
		// private_WhoAmITestData
		// 
		this.private_WhoAmITestData.PosttestAction = null;
		this.private_WhoAmITestData.PretestAction = null;
		this.private_WhoAmITestData.TestAction = private_WhoAmITest_TestAction;
	}

	#endregion


	#region Additional test attributes
	//
	// You can use the following additional attributes as you write your tests:
	//
	// Use ClassInitialize to run code before running the first test in the class
	// [ClassInitialize()]
	// public static void MyClassInitialize(TestContext testContext) { }
	//
	// Use ClassCleanup to run code after all tests in a class have run
	// [ClassCleanup()]
	// public static void MyClassCleanup() { }
	//
	#endregion

	[TestMethod()]
	public void clr_GetAllCulturesSuccessTest()
	{
		SqlDatabaseTestActions testActions = clr_GetAllCulturesSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 1)]
	public void clr_GetCultureByCodeArgumentOutOfRangeExceptionTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 1)]
	public void clr_GetCultureByNameSqlNullValueExceptionTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByNameSqlNullValueExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	public void clr_GetDateRangeSuccessTest()
	{
		SqlDatabaseTestActions testActions = clr_GetDateRangeSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	public void clr_GetNeutralCulturesSuccessTest()
	{
		SqlDatabaseTestActions testActions = clr_GetNeutralCulturesSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 1)]
	public void clr_GetCultureByCodeSqlNullValueExceptionTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByCodeSqlNullValueExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void clr_GetCultureByCodeSuccessTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByCodeSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void clr_GetCultureByNameSuccessTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByNameSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void clr_GetCultureByNameUnknownLocaleTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByNameUnknownLocaleTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 1)]
	public void clr_GetCultureByNameCultureNotFoundExceptionTest()
	{
		SqlDatabaseTestActions testActions = clr_GetCultureByNameCultureNotFoundExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 1)]
	public void clr_GetDateRangeArgumentExceptionTest()
	{
		SqlDatabaseTestActions testActions = clr_GetDateRangeArgumentExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void clr_GetDateRangeNullTest()
	{
		SqlDatabaseTestActions testActions = clr_GetDateRangeNullTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void clr_GetLangageCodeIdentifierSuccessTest()
	{
		SqlDatabaseTestActions testActions = this.clr_GetLangageCodeIdentifierSuccessTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
		}
	}

	[TestMethod()]
	[ExpectedSqlException(MessageNumber = 6522, Severity = 16, State = 2)]
	public void clr_GetLangageCodeIdentifierSqlNullValueExceptionTest()
	{
		SqlDatabaseTestActions testActions = this.clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
		}
	}
	[TestMethod()]
	public void private_WhoAmITest()
	{
		SqlDatabaseTestActions testActions = this.private_WhoAmITestData;
		// Execute the pre-test script
		// 
		System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
		SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
		try
		{
			// Execute the test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
			SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
		}
		finally
		{
			// Execute the post-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
			SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
		}
	}

	private SqlDatabaseTestActions clr_GetAllCulturesSuccessTestData;
	private SqlDatabaseTestActions clr_GetCultureByCodeArgumentOutOfRangeExceptionTestData;
	private SqlDatabaseTestActions clr_GetCultureByNameSqlNullValueExceptionTestData;
	private SqlDatabaseTestActions clr_GetDateRangeSuccessTestData;
	private SqlDatabaseTestActions clr_GetNeutralCulturesSuccessTestData;
	private SqlDatabaseTestActions clr_GetCultureByCodeSqlNullValueExceptionTestData;
	private SqlDatabaseTestActions clr_GetCultureByCodeSuccessTestData;
	private SqlDatabaseTestActions clr_GetCultureByNameSuccessTestData;
	private SqlDatabaseTestActions clr_GetCultureByNameUnknownLocaleTestData;
	private SqlDatabaseTestActions clr_GetCultureByNameCultureNotFoundExceptionTestData;
	private SqlDatabaseTestActions clr_GetDateRangeArgumentExceptionTestData;
	private SqlDatabaseTestActions clr_GetDateRangeNullTestData;
	private SqlDatabaseTestActions clr_GetLangageCodeIdentifierSuccessTestData;
	private SqlDatabaseTestActions clr_GetLangageCodeIdentifierSqlNullValueExceptionTestData;
	private SqlDatabaseTestActions private_WhoAmITestData;
}
