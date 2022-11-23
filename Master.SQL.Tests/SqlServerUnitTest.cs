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
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetAllCulturesSuccessTest_TestAction;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest));
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetAllCulturesScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetDateRangeSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetDateRangeRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetNeutralCulturesSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetNeutralCulturesScalarValueCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByCodeSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetCultureByCodeRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByNameSuccessTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition GetCultureByNameRowCountCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByNameUnknownLocaleTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition GetCultureByNameChecksumCondition;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetDateRangeArgumentExceptionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetDateRangeNullTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetDateRangeScalarValueCondition;
		dbo_GetAllCulturesSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByNameSqlNullValueExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetDateRangeSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetNeutralCulturesSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByCodeSqlNullValueExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByCodeSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByNameSuccessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByNameUnknownLocaleTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetCultureByNameCultureNotFoundExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetDateRangeArgumentExceptionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetDateRangeNullTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		dbo_GetAllCulturesSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetAllCulturesScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		dbo_GetDateRangeSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetDateRangeRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		dbo_GetNeutralCulturesSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetNeutralCulturesScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		dbo_GetCultureByCodeSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByCodeRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		dbo_GetCultureByNameSuccessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByNameRowCountCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		dbo_GetCultureByNameUnknownLocaleTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetCultureByNameChecksumCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
		dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		dbo_GetDateRangeArgumentExceptionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		dbo_GetDateRangeNullTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		GetDateRangeScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		// 
		// dbo_GetAllCulturesSuccessTest_TestAction
		// 
		dbo_GetAllCulturesSuccessTest_TestAction.Conditions.Add(GetAllCulturesScalarValueCondition);
		resources.ApplyResources(dbo_GetAllCulturesSuccessTest_TestAction, "dbo_GetAllCulturesSuccessTest_TestAction");
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
		// dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction
		// 
		resources.ApplyResources(dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction, "dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction");
		// 
		// dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction
		// 
		resources.ApplyResources(dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction, "dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction");
		// 
		// dbo_GetDateRangeSuccessTest_TestAction
		// 
		dbo_GetDateRangeSuccessTest_TestAction.Conditions.Add(GetDateRangeRowCountCondition);
		resources.ApplyResources(dbo_GetDateRangeSuccessTest_TestAction, "dbo_GetDateRangeSuccessTest_TestAction");
		// 
		// GetDateRangeRowCountCondition
		// 
		GetDateRangeRowCountCondition.Enabled = true;
		GetDateRangeRowCountCondition.Name = "GetDateRangeRowCountCondition";
		GetDateRangeRowCountCondition.ResultSet = 1;
		GetDateRangeRowCountCondition.RowCount = 21;
		// 
		// dbo_GetNeutralCulturesSuccessTest_TestAction
		// 
		dbo_GetNeutralCulturesSuccessTest_TestAction.Conditions.Add(GetNeutralCulturesScalarValueCondition);
		resources.ApplyResources(dbo_GetNeutralCulturesSuccessTest_TestAction, "dbo_GetNeutralCulturesSuccessTest_TestAction");
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
		// dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction
		// 
		resources.ApplyResources(dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction, "dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction");
		// 
		// dbo_GetCultureByCodeSuccessTest_TestAction
		// 
		dbo_GetCultureByCodeSuccessTest_TestAction.Conditions.Add(GetCultureByCodeRowCountCondition);
		resources.ApplyResources(dbo_GetCultureByCodeSuccessTest_TestAction, "dbo_GetCultureByCodeSuccessTest_TestAction");
		// 
		// GetCultureByCodeRowCountCondition
		// 
		GetCultureByCodeRowCountCondition.Enabled = true;
		GetCultureByCodeRowCountCondition.Name = "GetCultureByCodeRowCountCondition";
		GetCultureByCodeRowCountCondition.ResultSet = 1;
		GetCultureByCodeRowCountCondition.RowCount = 1;
		// 
		// dbo_GetCultureByNameSuccessTest_TestAction
		// 
		dbo_GetCultureByNameSuccessTest_TestAction.Conditions.Add(GetCultureByNameRowCountCondition);
		resources.ApplyResources(dbo_GetCultureByNameSuccessTest_TestAction, "dbo_GetCultureByNameSuccessTest_TestAction");
		// 
		// GetCultureByNameRowCountCondition
		// 
		GetCultureByNameRowCountCondition.Enabled = true;
		GetCultureByNameRowCountCondition.Name = "GetCultureByNameRowCountCondition";
		GetCultureByNameRowCountCondition.ResultSet = 1;
		GetCultureByNameRowCountCondition.RowCount = 1;
		// 
		// dbo_GetCultureByNameUnknownLocaleTest_TestAction
		// 
		dbo_GetCultureByNameUnknownLocaleTest_TestAction.Conditions.Add(GetCultureByNameChecksumCondition);
		resources.ApplyResources(dbo_GetCultureByNameUnknownLocaleTest_TestAction, "dbo_GetCultureByNameUnknownLocaleTest_TestAction");
		// 
		// GetCultureByNameChecksumCondition
		// 
		GetCultureByNameChecksumCondition.Checksum = "-1285073688";
		GetCultureByNameChecksumCondition.Enabled = true;
		GetCultureByNameChecksumCondition.Name = "GetCultureByNameChecksumCondition";
		// 
		// dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction
		// 
		resources.ApplyResources(dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction, "dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction");
		// 
		// dbo_GetDateRangeArgumentExceptionTest_TestAction
		// 
		resources.ApplyResources(dbo_GetDateRangeArgumentExceptionTest_TestAction, "dbo_GetDateRangeArgumentExceptionTest_TestAction");
		// 
		// dbo_GetAllCulturesSuccessTestData
		// 
		dbo_GetAllCulturesSuccessTestData.PosttestAction = null;
		dbo_GetAllCulturesSuccessTestData.PretestAction = null;
		dbo_GetAllCulturesSuccessTestData.TestAction = dbo_GetAllCulturesSuccessTest_TestAction;
		// 
		// dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData
		// 
		dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData.PosttestAction = null;
		dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData.PretestAction = null;
		dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData.TestAction = dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest_TestAction;
		// 
		// dbo_GetCultureByNameSqlNullValueExceptionTestData
		// 
		dbo_GetCultureByNameSqlNullValueExceptionTestData.PosttestAction = null;
		dbo_GetCultureByNameSqlNullValueExceptionTestData.PretestAction = null;
		dbo_GetCultureByNameSqlNullValueExceptionTestData.TestAction = dbo_GetCultureByNameSqlNullValueExceptionTest_TestAction;
		// 
		// dbo_GetDateRangeSuccessTestData
		// 
		dbo_GetDateRangeSuccessTestData.PosttestAction = null;
		dbo_GetDateRangeSuccessTestData.PretestAction = null;
		dbo_GetDateRangeSuccessTestData.TestAction = dbo_GetDateRangeSuccessTest_TestAction;
		// 
		// dbo_GetNeutralCulturesSuccessTestData
		// 
		dbo_GetNeutralCulturesSuccessTestData.PosttestAction = null;
		dbo_GetNeutralCulturesSuccessTestData.PretestAction = null;
		dbo_GetNeutralCulturesSuccessTestData.TestAction = dbo_GetNeutralCulturesSuccessTest_TestAction;
		// 
		// dbo_GetCultureByCodeSqlNullValueExceptionTestData
		// 
		dbo_GetCultureByCodeSqlNullValueExceptionTestData.PosttestAction = null;
		dbo_GetCultureByCodeSqlNullValueExceptionTestData.PretestAction = null;
		dbo_GetCultureByCodeSqlNullValueExceptionTestData.TestAction = dbo_GetCultureByCodeSqlNullValueExceptionTest_TestAction;
		// 
		// dbo_GetCultureByCodeSuccessTestData
		// 
		dbo_GetCultureByCodeSuccessTestData.PosttestAction = null;
		dbo_GetCultureByCodeSuccessTestData.PretestAction = null;
		dbo_GetCultureByCodeSuccessTestData.TestAction = dbo_GetCultureByCodeSuccessTest_TestAction;
		// 
		// dbo_GetCultureByNameSuccessTestData
		// 
		dbo_GetCultureByNameSuccessTestData.PosttestAction = null;
		dbo_GetCultureByNameSuccessTestData.PretestAction = null;
		dbo_GetCultureByNameSuccessTestData.TestAction = dbo_GetCultureByNameSuccessTest_TestAction;
		// 
		// dbo_GetCultureByNameUnknownLocaleTestData
		// 
		dbo_GetCultureByNameUnknownLocaleTestData.PosttestAction = null;
		dbo_GetCultureByNameUnknownLocaleTestData.PretestAction = null;
		dbo_GetCultureByNameUnknownLocaleTestData.TestAction = dbo_GetCultureByNameUnknownLocaleTest_TestAction;
		// 
		// dbo_GetCultureByNameCultureNotFoundExceptionTestData
		// 
		dbo_GetCultureByNameCultureNotFoundExceptionTestData.PosttestAction = null;
		dbo_GetCultureByNameCultureNotFoundExceptionTestData.PretestAction = null;
		dbo_GetCultureByNameCultureNotFoundExceptionTestData.TestAction = dbo_GetCultureByNameCultureNotFoundExceptionTest_TestAction;
		// 
		// dbo_GetDateRangeArgumentExceptionTestData
		// 
		dbo_GetDateRangeArgumentExceptionTestData.PosttestAction = null;
		dbo_GetDateRangeArgumentExceptionTestData.PretestAction = null;
		dbo_GetDateRangeArgumentExceptionTestData.TestAction = dbo_GetDateRangeArgumentExceptionTest_TestAction;
		// 
		// dbo_GetDateRangeNullTestData
		// 
		dbo_GetDateRangeNullTestData.PosttestAction = null;
		dbo_GetDateRangeNullTestData.PretestAction = null;
		dbo_GetDateRangeNullTestData.TestAction = dbo_GetDateRangeNullTest_TestAction;
		// 
		// dbo_GetDateRangeNullTest_TestAction
		// 
		dbo_GetDateRangeNullTest_TestAction.Conditions.Add(GetDateRangeScalarValueCondition);
		resources.ApplyResources(dbo_GetDateRangeNullTest_TestAction, "dbo_GetDateRangeNullTest_TestAction");
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
	public void dbo_GetAllCulturesSuccessTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetAllCulturesSuccessTestData;
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
	public void dbo_GetCultureByCodeArgumentOutOfRangeExceptionTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData;
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
	public void dbo_GetCultureByNameSqlNullValueExceptionTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByNameSqlNullValueExceptionTestData;
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
	public void dbo_GetDateRangeSuccessTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetDateRangeSuccessTestData;
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
	public void dbo_GetNeutralCulturesSuccessTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetNeutralCulturesSuccessTestData;
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
	public void dbo_GetCultureByCodeSqlNullValueExceptionTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByCodeSqlNullValueExceptionTestData;
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
	public void dbo_GetCultureByCodeSuccessTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByCodeSuccessTestData;
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
	public void dbo_GetCultureByNameSuccessTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByNameSuccessTestData;
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
	public void dbo_GetCultureByNameUnknownLocaleTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByNameUnknownLocaleTestData;
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
	public void dbo_GetCultureByNameCultureNotFoundExceptionTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetCultureByNameCultureNotFoundExceptionTestData;
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
	public void dbo_GetDateRangeArgumentExceptionTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetDateRangeArgumentExceptionTestData;
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
	public void dbo_GetDateRangeNullTest()
	{
		SqlDatabaseTestActions testActions = dbo_GetDateRangeNullTestData;
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







	private SqlDatabaseTestActions dbo_GetAllCulturesSuccessTestData;
	private SqlDatabaseTestActions dbo_GetCultureByCodeArgumentOutOfRangeExceptionTestData;
	private SqlDatabaseTestActions dbo_GetCultureByNameSqlNullValueExceptionTestData;
	private SqlDatabaseTestActions dbo_GetDateRangeSuccessTestData;
	private SqlDatabaseTestActions dbo_GetNeutralCulturesSuccessTestData;
	private SqlDatabaseTestActions dbo_GetCultureByCodeSqlNullValueExceptionTestData;
	private SqlDatabaseTestActions dbo_GetCultureByCodeSuccessTestData;
	private SqlDatabaseTestActions dbo_GetCultureByNameSuccessTestData;
	private SqlDatabaseTestActions dbo_GetCultureByNameUnknownLocaleTestData;
	private SqlDatabaseTestActions dbo_GetCultureByNameCultureNotFoundExceptionTestData;
	private SqlDatabaseTestActions dbo_GetDateRangeArgumentExceptionTestData;
	private SqlDatabaseTestActions dbo_GetDateRangeNullTestData;
}
