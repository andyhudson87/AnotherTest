CREATE TABLE [dbo].[Person]
(
	[id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [first_name] NVARCHAR(50) NOT NULL, 
    [surname] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL DEFAULT '',
)