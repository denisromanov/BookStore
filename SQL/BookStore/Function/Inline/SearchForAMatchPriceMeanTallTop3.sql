-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Denis
-- Create date: 19.11.2015
-- Description:	Func like at Search for a match, but will output data where price tall mean, top 3
-- =============================================
ALTER FUNCTION SearchForAMatchTOP3(@Value nvarchar(50))
RETURNS @TAB TABLE
(
	ID int primary key NOT NULL,
    Title nvarchar(255) NOT NULL,
	Price decimal NOT NULL
)
as 
begin
with SearchFor(ID, Title, Price)
as
(
	
	SELECT id, Title, Price from Book
	where Book.Title LIKE '%' + @Value + '%'
)
 INSERT @TAB
 SELECT ID, Title, Price FROM SearchFor 
   RETURN
END;
go
--as 
--begin

--WITH SearchFor (ID, Title, Price, PublishYear, GenreID, AuthorID, PublishingID)
--AS
--(
	
--	SELECT * from Book
--	where Book.Title LIKE '%' + @Value + '%'
--)
--GO
--SELECT TOP(3) FROM SearchFor
--where AVG(Price) < Price