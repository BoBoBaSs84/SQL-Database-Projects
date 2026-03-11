/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
PRINT 'Setting "show advanced options" to ON';
EXEC sp_configure 'show advanced options'
								, 1;
RECONFIGURE;
GO

PRINT 'Setting "clr enabled" to ON';
EXEC sp_configure 'clr enabled'
								, 1;
RECONFIGURE;
GO

PRINT 'Setting "show advanced options" to OFF';
EXEC sp_configure 'show advanced options'
								, 0;
RECONFIGURE;
GO

IF NOT EXISTS (
		SELECT *
		FROM sys.asymmetric_keys
		WHERE name = 'MasterStrongNameKey'
	)
BEGIN
	CREATE ASYMMETRIC KEY [MasterStrongNameKey]
	FROM EXECUTABLE FILE = 'Master.CLR.dll';
	PRINT 'Asymmetric key "MasterStrongNameKey" created successfully';
END
ELSE
BEGIN
	PRINT 'Asymmetric key "MasterStrongNameKey" already exists';
END
GO
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'MasterStrongName')
BEGIN
		CREATE LOGIN [MasterStrongName]
		FROM ASYMMETRIC KEY [MasterStrongNameKey];
		PRINT 'Login "MasterStrongName" created successfully';
END
ELSE
BEGIN
	PRINT 'Login "MasterStrongName" already exists';
END
GO
GRANT UNSAFE ASSEMBLY TO [MasterStrongName];
GO
GRANT EXTERNAL ACCESS ASSEMBLY TO [MasterStrongName];
GO