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
-- Description:	Get styles, book > 1
-- =============================================

-- ѕолучает те книги количество которых больше 1
ALTER PROCEDURE GetStyles 
	
AS
BEGIN
	SET NOCOUNT ON;
	select Style.NameStyle, Count(case when Book.ID is not null then 1 else null end) as CountBook from Style
	left join Genre
	on Style.ID = Genre.StyleID
	left join Book
	on Book.GenreID = Genre.ID
	group by NameStyle
	having Count(case when Book.ID is not null then 1 else null end) > 1
	order by CountBook DESC;
	SET NOCOUNT OFF;
END
GO
