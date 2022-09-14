using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magic.Switch.Board.Tests;

[TestClass()]
public class SqlDatabaseSetup
{
	[AssemblyInitialize()]
	public static void InitializeAssembly(TestContext ctx)
	{
		// Setup the test database based on setting in the
		// configuration file

		//SqlDatabaseTestClass.TestService.DeployDatabaseProject();
		//SqlDatabaseTestClass.TestService.GenerateData();
		
		MagicSwitchBoardTestService Service = new();
		Service.DeployCompositeProject();
	}
}
