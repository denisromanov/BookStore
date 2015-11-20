-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
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
-- Create date: 20.11.2015
-- Description:	Delete field ane her dependency
-- =============================================
ALTER TRIGGER .DeleteBook 
   ON  .dbo.Book 
   FOR DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	declare @Id int
	delete GenreDel
	from Genre GenreDel, inserted book
	where GenreDel.ID = book.GenreID 

	SET NOCOUNT OFF;
END
GO
