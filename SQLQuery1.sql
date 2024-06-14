USE [p2750500]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_FilterbyStaffId]
		@StaffId = 8

SELECT	@return_value as 'Return Value'

GO
