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
IF NOT EXISTS (
  SELECT *
  FROM sys.assemblies a
  JOIN sys.assembly_files af
  	ON a.assembly_id = af.assembly_id
  JOIN sys.trusted_assemblies ta 
  	ON ta.hash = HASHBYTES('SHA2_512', af.content)
  WHERE a.name = 'Master.CLR'
  )
BEGIN
  DECLARE @Hash VARBINARY(8000)
    , @CLR_Name NVARCHAR(4000);

  SELECT @Hash = HASHBYTES('SHA2_512', af.content)
    , @CLR_Name = a.clr_name
  FROM sys.assemblies a
  JOIN sys.assembly_files af
  	ON a.assembly_id = af.assembly_id
  WHERE a.name = 'Master.CLR'

  PRINT 'Adding assembly "Master.CLR" to trusted_assemblies';
  EXECUTE sys.sp_add_trusted_assembly @Hash, @CLR_Name;
END