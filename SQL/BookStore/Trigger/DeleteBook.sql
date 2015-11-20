USE [BookDB_Context]
GO
/****** Object:  Trigger [dbo].[DeleteBook]    Script Date: 20.11.2015 16:27:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Denis
-- Create date: 20.11.2015
-- Description:	Delete field ane her dependency
-- =============================================
ALTER TRIGGER .[dbo].[DeleteBook] 
   ON  .[dbo].[Book] 
   FOR DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @CountGenre int
	select @CountGenre = Count(case when Book.ID is not null then 1 else null end) from Book
						left join Genre
						on Book.GenreID = Genre.ID
						left join Style
						on Genre.StyleID = Style.ID
	
	if @CountGenre > 0
	

	SET NOCOUNT OFF;
END
