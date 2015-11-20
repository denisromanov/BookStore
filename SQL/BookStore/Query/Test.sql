--exec AddColumnsForTableTheBook
--exec AddTableAuthors
--exec AddTablePublishings
--SELECT dbo.OutputCountBook('Art')
--SELECT * FROM SearchForAMatch('ar')
SELECT * FROM SearchForAMatchTOP3('ar')