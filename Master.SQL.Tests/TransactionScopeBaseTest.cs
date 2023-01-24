using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace Master.SQL.Tests;

[TestClass]
public abstract class TransactionScopeBaseTest : SqlDatabaseTestClass
{
	private TransactionScope transaction;

	[TestInitialize()]
	public void TestInitialize()
	{
		TestContext.WriteLine($"{nameof(TestInitialize)}: {TestContext.TestName}");
		transaction = new();
		base.InitializeTest();
	}

	[TestCleanup()]
	public void TestCleanup()
	{
		TestContext.WriteLine($"{nameof(TestCleanup)}: {TestContext.TestName}");
		base.CleanupTest();
		transaction.Dispose();
	}
}
