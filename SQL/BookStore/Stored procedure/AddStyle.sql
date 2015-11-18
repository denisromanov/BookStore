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
-- Description:	Adds style into table Styles
-- =============================================
CREATE PROCEDURE AddStyle 
	-- Add the parameters for the stored procedure here
	@StyleName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	
	-- My stored procedure, adds style into table
	if(@StyleName <> '')
	begin
		insert into dbo.Style (dbo.Style.NameStyle) values (@StyleName)
	end
	select * from dbo.Style
END
GO
