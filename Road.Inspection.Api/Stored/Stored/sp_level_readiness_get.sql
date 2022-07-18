use [Road.Inspection]
go
drop proc dbo.sp_level_readiness_get
go 

create proc dbo.sp_level_readiness_get
	@id				nvarchar(100)=null
as
declare @error  nvarchar(max)=null
begin try
	if(@id is null)
		select Oid as id,* from LevelReadiness where GcRecord is null order by date
	else
		select Oid as id,* from LevelReadiness where GCRecord is null and oid = @id order by date
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
--exec sp_level_readiness_get 
