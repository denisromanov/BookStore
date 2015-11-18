-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Denis
-- Create date: 18.11.2015
-- Description:	gets counts books for each style and sorted descending
-- =============================================
alter PROCEDURE GetCountBook 
	-- Add the parameters for the stored procedure here
	   
AS
BEGIN
	
	SET NOCOUNT ON;
    
	SELECT Style.NameStyle, count(case when Book.ID is not null then 1 else null end) as CountBook from Book
	left join Genre
	on Book.GenreID = Genre.ID
	right join Style
	on Genre.StyleID = Style.ID
	group by NameStyle
	order by CountBook DESC
	
	select Style.NameStyle, sum(case when Book.ID is not null then 1 else 0 end) as CountBook from Style
	left join Genre
	on Style.ID = Genre.StyleID
	left join Book
	on Book.GenreID = Genre.ID
	group by NameStyle
	order by CountBook DESC;
END
GO
