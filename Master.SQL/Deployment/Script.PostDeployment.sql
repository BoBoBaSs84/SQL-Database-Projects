/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
PRINT 'Setting "clr strict security" to ON'
EXEC sp_configure 'clr strict security', 1;
RECONFIGURE;
GO
PRINT 'Setting "show advanced options" to OFF'
EXEC sp_configure 'show advanced options' , 0;
RECONFIGURE;
GO
