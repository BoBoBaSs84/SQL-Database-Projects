using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Switch.Board.Tests;

public class MagicSwitchBoardTestService : SqlDatabaseTestService
{
	public void DeployCompositeProject()
	{
		DeployDatabaseProject(@"..\..\..\Magic.Switch.Board\Magic.Switch.Board.sqlproj", "Debug", "System.Data.SqlClient", GetConnectionString());
		DeployDatabaseProject(@"..\..\..\Magic.Switch.Board.tSQLt\Magic.Switch.Board.tSQLt.sqlproj", "Debug", "System.Data.SqlClient", GetConnectionString());
	}

	private static string GetConnectionString()
	{
		SqlUnitTestingSection config = (SqlUnitTestingSection)ConfigurationManager.GetSection("SqlUnitTesting");
		return config.ExecutionContext.ConnectionString;
	}
}
