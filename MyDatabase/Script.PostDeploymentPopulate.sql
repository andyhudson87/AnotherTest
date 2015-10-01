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
MERGE INTO Person AS Target 
USING (VALUES 
  ('John', 'Big Man', 'john@bigjohn.com'), 
  ('Andrew', 'Hudson', 'andrew.hudson@tvsscs.com'), 
  ('Mike', 'Moore', ''), 
  ('Sam', 'Loughlin', 'sam.loughlin@tvsscs.com') 
) 
AS Source (first_name, surname, email) 
ON Target.first_name = Source.first_name and Target.surname = Source.surname
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET first_name = Source.first_name, surname = Source.surname, email = Source.email 
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (first_name, surname, email) 
VALUES (first_name, surname, email);