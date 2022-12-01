CREATE FUNCTION [private].[WhoAmI] ()
RETURNS TABLE
WITH SCHEMABINDING
AS RETURN
SELECT @@SERVERNAME AS [@@SERVERNAME],
       DB_NAME() AS [DB_NAME()],
       DB_ID() AS [DB_ID()],
       '---' AS [---],
       PROGRAM_NAME() AS [PROGRAM_NAME()],
       @@SPID AS [@@SPID],
       CONTEXT_INFO() AS [CONTEXT_INFO()],
       ORIGINAL_LOGIN() AS [ORIGINAL_LOGIN()],
       '----' AS [----],
       SUSER_ID() AS [SUSER_ID()],
       SUSER_SID() AS [SUSER_SID()],
       SUSER_NAME() AS [SUSER_NAME()],
       SUSER_SNAME() AS [SUSER_SNAME()],
       SYSTEM_USER AS [SYSTEM_USER],
       '-----' AS [-----],
       USER_ID() AS [USER_ID()],
       USER_SID() AS [USER_SID()],
       USER_NAME() AS [USER_NAME()], -- same as CURRENT_USER and USER
       SESSION_USER AS [SESSION_USER]