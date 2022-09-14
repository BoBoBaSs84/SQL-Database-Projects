using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Transactions;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Magic.Switch.Board.Tests;
[TestClass()]
public class SqlServerUnitTest : SqlDatabaseTestClass
{
	private TransactionScope transactionScope;
	public SqlServerUnitTest()
	{
		InitializeComponent();
	}

	[TestInitialize()]
	public void TestInitialize()
	{
		transactionScope = new TransactionScope();
		base.InitializeTest();
	}
	[TestCleanup()]
	public void TestCleanup()
	{
		base.CleanupTest();
		transactionScope.Dispose();
	}

	#region Designer support code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_GetApplicationVersionTest_TestAction;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest));
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ScalarValueConditionOne;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_GetConfigurationVersionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ScalarValueConditionTwo;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_ConfigurationInsertCountTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_ConfigurationInsertResultTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition VerifyConfigurationInsertResult;
		this.private_GetApplicationVersionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.private_GetConfigurationVersionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.private_ConfigurationInsertCountTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.private_ConfigurationInsertResultTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		private_GetApplicationVersionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		ScalarValueConditionOne = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		private_GetConfigurationVersionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		ScalarValueConditionTwo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		private_ConfigurationInsertCountTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
		private_ConfigurationInsertResultTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		VerifyConfigurationInsertResult = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
		// 
		// private_GetApplicationVersionTest_TestAction
		// 
		private_GetApplicationVersionTest_TestAction.Conditions.Add(ScalarValueConditionOne);
		resources.ApplyResources(private_GetApplicationVersionTest_TestAction, "private_GetApplicationVersionTest_TestAction");
		// 
		// ScalarValueConditionOne
		// 
		ScalarValueConditionOne.ColumnNumber = 1;
		ScalarValueConditionOne.Enabled = true;
		ScalarValueConditionOne.ExpectedValue = "1.0.0.12705";
		ScalarValueConditionOne.Name = "ScalarValueConditionOne";
		ScalarValueConditionOne.NullExpected = false;
		ScalarValueConditionOne.ResultSet = 1;
		ScalarValueConditionOne.RowNumber = 1;
		// 
		// private_GetConfigurationVersionTest_TestAction
		// 
		private_GetConfigurationVersionTest_TestAction.Conditions.Add(ScalarValueConditionTwo);
		resources.ApplyResources(private_GetConfigurationVersionTest_TestAction, "private_GetConfigurationVersionTest_TestAction");
		// 
		// ScalarValueConditionTwo
		// 
		ScalarValueConditionTwo.ColumnNumber = 1;
		ScalarValueConditionTwo.Enabled = true;
		ScalarValueConditionTwo.ExpectedValue = "1.0.0.12704";
		ScalarValueConditionTwo.Name = "ScalarValueConditionTwo";
		ScalarValueConditionTwo.NullExpected = false;
		ScalarValueConditionTwo.ResultSet = 1;
		ScalarValueConditionTwo.RowNumber = 1;
		// 
		// private_ConfigurationInsertCountTest_TestAction
		// 
		private_ConfigurationInsertCountTest_TestAction.Conditions.Add(rowCountCondition1);
		resources.ApplyResources(private_ConfigurationInsertCountTest_TestAction, "private_ConfigurationInsertCountTest_TestAction");
		// 
		// rowCountCondition1
		// 
		rowCountCondition1.Enabled = true;
		rowCountCondition1.Name = "rowCountCondition1";
		rowCountCondition1.ResultSet = 1;
		rowCountCondition1.RowCount = 1;
		// 
		// private_ConfigurationInsertResultTest_TestAction
		// 
		private_ConfigurationInsertResultTest_TestAction.Conditions.Add(VerifyConfigurationInsertResult);
		resources.ApplyResources(private_ConfigurationInsertResultTest_TestAction, "private_ConfigurationInsertResultTest_TestAction");
		// 
		// VerifyConfigurationInsertResult
		// 
		VerifyConfigurationInsertResult.Checksum = "-537817650";
		VerifyConfigurationInsertResult.Enabled = true;
		VerifyConfigurationInsertResult.Name = "VerifyConfigurationInsertResult";
		// 
		// private_GetApplicationVersionTestData
		// 
		this.private_GetApplicationVersionTestData.PosttestAction = null;
		this.private_GetApplicationVersionTestData.PretestAction = null;
		this.private_GetApplicationVersionTestData.TestAction = private_GetApplicationVersionTest_TestAction;
		// 
		// private_GetConfigurationVersionTestData
		// 
		this.private_GetConfigurationVersionTestData.PosttestAction = null;
		this.private_GetConfigurationVersionTestData.PretestAction = null;
		this.private_GetConfigurationVersionTestData.TestAction = private_GetConfigurationVersionTest_TestAction;
		// 
		// private_ConfigurationInsertCountTestData
		// 
		this.private_ConfigurationInsertCountTestData.PosttestAction = null;
		this.private_ConfigurationInsertCountTestData.PretestAction = null;
		this.private_ConfigurationInsertCountTestData.TestAction = private_ConfigurationInsertCountTest_TestAction;
		// 
		// private_ConfigurationInsertResultTestData
		// 
		this.private_ConfigurationInsertResultTestData.PosttestAction = null;
		this.private_ConfigurationInsertResultTestData.PretestAction = null;
		this.private_ConfigurationInsertResultTestData.TestAction = private_ConfigurationInsertResultTest_TestAction;
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
	public void private_GetApplicationVersionTest()
	{
		SqlDatabaseTestActions testActions = this.private_GetApplicationVersionTestData;
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
	public void private_GetConfigurationVersionTest()
	{
		SqlDatabaseTestActions testActions = this.private_GetConfigurationVersionTestData;
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
	public void private_ConfigurationInsertCountTest()
	{
		SqlDatabaseTestActions testActions = this.private_ConfigurationInsertCountTestData;
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
	public void private_ConfigurationInsertResultTest()
	{
		SqlDatabaseTestActions testActions = this.private_ConfigurationInsertResultTestData;
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


	private SqlDatabaseTestActions private_GetApplicationVersionTestData;
	private SqlDatabaseTestActions private_GetConfigurationVersionTestData;
	private SqlDatabaseTestActions private_ConfigurationInsertCountTestData;
	private SqlDatabaseTestActions private_ConfigurationInsertResultTestData;
}
