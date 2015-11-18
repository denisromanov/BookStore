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
-- Description:	Adds book into table Books
-- =============================================
CREATE PROCEDURE AddBook 
	-- Add the parameters for the stored procedure here
	@Title nvarchar(50), 
	@Price decimal,
	@PublishYear date,
	@GenreID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if((@Title <> '') and (@Price between 5 and 100) and exists(select dbo.Genre.ID from dbo.Genre where dbo.Genre.ID = @GenreID))
	begin
		insert into dbo.Book (dbo.Book.Title, dbo.Book.Price, dbo.Book.PublishYear, dbo.Book.GenreID) values (@Title, @Price, @PublishYear, @GenreID)
	end
    
	SELECT * from dbo.Book
END
GO
