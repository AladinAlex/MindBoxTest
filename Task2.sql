 -- 1.Создание таблиц
 CREATE TABLE [dbo].[Product](
 	[ID] [int] IDENTITY(1,1) NOT NULL,
 	[Name] [nvarchar](max) NOT NULL
 )

 CREATE TABLE [dbo].[Category](
 	[ID] [int] IDENTITY(1,1) NOT NULL,
 	[Name] [nvarchar](max) NOT NULL
 )

 CREATE TABLE [dbo].[Product_Category](
 	[ID] [int] IDENTITY(1,1) NOT NULL,
 	[Product_ID] [int] NOT NULL,
 	[Category_ID] [int] NOT NULL
 )

 --2. Запрос для вывода пар "Имя продукта – Имя категории"
 select pr.Name as [Продукт], isnull(ct.Name, '') as [Категория]
from Product pr
left join Product_Category pc on pc.Product_ID = pr.ID
left join Category ct on ct.ID = pc.Category_ID