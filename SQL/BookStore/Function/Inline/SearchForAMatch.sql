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
-- Description:	������� ��������� ��������� ������ (��� �� ����� ������ �����, ������ ���� ���� � �� ����� ����� ���� ������� � ������� ���� ����������)
-- =============================================
ALTER FUNCTION SearchForAMatch 
(	
	-- Add the parameters for the function here
	@Value nvarchar(50) 
	 
)
RETURNS TABLE
AS
RETURN 
(
	SELECT * from Book
	where Book.Title LIKE '%' + @Value + '%'
)
GO
