-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
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
-- Description:	Выводит количство книг, по введенному стилю
-- =============================================
Create FUNCTION OutputCountBook 
(
	-- Add the parameters for the function here
	@StyleName nvarchar(50)
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int
	
	select @Result = Count(*) from Style --case when Book.ID is not null then 1 else NULL end
	inner join Genre
	on Style.ID = Genre.StyleID
	inner join Book
	on Book.GenreID = Genre.ID
	GROUP BY Style.NameStyle
	HAVING Style.NameStyle = @StyleName
	-- Return the result of the function
	RETURN @Result

END
GO
select dbo.OutputCountBook('art')

