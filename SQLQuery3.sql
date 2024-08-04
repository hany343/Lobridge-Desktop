USE [DLWS]
GO

INSERT INTO [dbo].[User_Perm]
           ([ID]
           ,[Role]
           ,[incoming]
           ,[in_sup]
           ,[in_ship]
           ,[in_batch]
           ,[in_card]
           ,[in_weight]
           ,[App_settings])
     VALUES
           (1
           ,'admin'
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1)
GO


