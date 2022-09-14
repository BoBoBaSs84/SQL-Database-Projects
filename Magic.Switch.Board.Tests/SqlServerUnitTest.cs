using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Magic.Switch.Board.Tests;
[TestClass()]
public class SqlServerUnitTest : SqlDatabaseTestClass
{

	public SqlServerUnitTest()
	{
		InitializeComponent();
	}

	[TestInitialize()]
	public void TestInitialize()
	{
		base.InitializeTest();
		var tc = base.TestContext;
	}
	[TestCleanup()]
	public void TestCleanup()
	{
		base.CleanupTest();
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
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction private_GetConfigurationVersionTest_TestAction;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ScalarValueConditionOne;
		Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ScalarValueConditionTwo;
		this.private_GetApplicationVersionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		this.private_GetConfigurationVersionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
		private_GetApplicationVersionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		private_GetConfigurationVersionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
		ScalarValueConditionOne = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		ScalarValueConditionTwo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
		// 
		// private_GetApplicationVersionTest_TestAction
		// 
		private_GetApplicationVersionTest_TestAction.Conditions.Add(ScalarValueConditionOne);
		resources.ApplyResources(private_GetApplicationVersionTest_TestAction, "private_GetApplicationVersionTest_TestAction");
		// 
		// private_GetConfigurationVersionTest_TestAction
		// 
		private_GetConfigurationVersionTest_TestAction.Conditions.Add(ScalarValueConditionTwo);
		resources.ApplyResources(private_GetConfigurationVersionTest_TestAction, "private_GetConfigurationVersionTest_TestAction");
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
		// ScalarValueConditionTwo
		// 
		ScalarValueConditionTwo.ColumnNumber = 1;
		ScalarValueConditionTwo.Enabled = true;
		ScalarValueConditionTwo.ExpectedValue = "1.0.0.12704";
		ScalarValueConditionTwo.Name = "ScalarValueConditionTwo";
		ScalarValueConditionTwo.NullExpected = false;
		ScalarValueConditionTwo.ResultSet = 1;
		ScalarValueConditionTwo.RowNumber = 1;
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
	private SqlDatabaseTestActions private_GetApplicationVersionTestData;
	private SqlDatabaseTestActions private_GetConfigurationVersionTestData;
}
