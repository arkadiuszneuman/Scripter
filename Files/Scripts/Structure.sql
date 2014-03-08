IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_test]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_test]

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_test]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION fn_test
(
 @param int
)
RETURNS int
AS
BEGIN
	RETURN @param;

END
' 
END
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_1]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_1](
	[id] [char](10) COLLATE Polish_CI_AS NOT NULL,
	[a] [int] NOT NULL
) ON [PRIMARY]
END

SET ANSI_PADDING ON
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Table_1]') AND name = N'NonClusteredIndex-20140308-103723')
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20140308-103723] ON [dbo].[Table_1]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Table_1_a]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Table_1] ADD  CONSTRAINT [DF_Table_1_a]  DEFAULT ([dbo].[fn_test]((3))) FOR [a]
END
