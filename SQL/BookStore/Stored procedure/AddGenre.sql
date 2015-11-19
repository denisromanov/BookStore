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
-- Description:	Adds genre into table Genres
-- =============================================
ALTER PROCEDURE AddGenre 
	-- Add the parameters for the stored procedure here
	@GenreName nvarchar(50) = NULL, 
	@StyleID int
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF (@StyleID <> 0 and EXISTS(select dbo.Style.ID from dbo.Style where dbo.Style.ID = @StyleID))
	BEGIN
		-- My stored procedure, adds genre into table
		insert into dbo.Genre (dbo.Genre.NameGenre, dbo.Genre.StyleID) values (@GenreName, @StyleID)
	END
	select * from dbo.Genre
	SET NOCOUNT OFF;
END
GO
