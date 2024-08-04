USE [DLWS]
GO

INSERT INTO [dbo].[Users]
           ([UName]
           ,[ULogin]
           ,[UPass]
           ,[user_perm]
           ,[Title]
           ,[Job]
           ,[Email]
           ,[Mobile])
     VALUES
           ('admin'
           ,'admin'
           ,'admin'
           ,1
           ,'Admin'
           ,'IT'
           ,'Hany.Ragab@oilex.com.eg'
           ,0102222)
GO


