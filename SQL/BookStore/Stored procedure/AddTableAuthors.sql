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
-- Create date: 19.11.2015
-- Description:	Add table Authors, and add authors
-- =============================================
CREATE PROCEDURE AddTableAuthors 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;

    create table Authors
	(
		ID int PRIMARY KEY identity,
		AuthorName varchar(255),
		PublishingID int
	);
	 
	SET NOCOUNT OFF;
END
GO
