USE [master]
GO
ALTER DATABASE AppsDB SET RECOVERY SIMPLE WITH NO_WAIT
GO
ALTER DATABASE AppsDB SET RECOVERY SIMPLE --��ģʽ
GO
USE AppsDB
GO
DBCC SHRINKFILE (N'Apps_log' , 11, TRUNCATEONLY) 
GO
 --�����DNName_Log �����֪����sys.database_files����ʲô���ֵĻ������������������в�ѯ
USE AppsDB
GO
SELECT file_id, name FROM sys.database_files;
GO
USE [master]
GO
ALTER DATABASE AppsDB SET RECOVERY FULL WITH NO_WAIT
GO
ALTER DATABASE AppsDB SET RECOVERY FULL --��ԭΪ��ȫģʽ
GO

