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
PRINT 'Setting "show advanced options" to ON'
EXEC sp_configure 'show advanced options' , 1;
RECONFIGURE;
GO
PRINT 'Setting "clr enabled" to ON'
EXEC sp_configure 'clr enabled', 1;
RECONFIGURE;
GO
PRINT 'Setting "clr strict security" to OFF'
EXEC sp_configure 'clr strict security', 0;
RECONFIGURE;
GO
PRINT 'Setting "xp_cmdshell" to ON'
EXEC sp_configure 'xp_cmdshell', 1;
RECONFIGURE;
GO
