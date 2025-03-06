CREATE PROCEDURE prd_GetSessionLogin 
	@no_ktp_pegawai VARCHAR(20)
AS 
BEGIN
	EXEC sp_set_session_context @key=N'no_ktp_pegawai', @value=@no_ktp_pegawai
END;
GO 


CREATE PROCEDURE prd_ClearSessionLogin
AS 
BEGIN
	EXEC sp_set_session_context @key=N'no_ktp_pegawai', @value=NULL
END;
GO


