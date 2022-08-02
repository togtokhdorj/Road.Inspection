use [Road.Inspection]
go
drop proc dbo.sp_road_crashes
go
create proc dbo.sp_road_crashes
as
declare @error			nvarchar(max)

begin try
	
	select * from RoadCrashCode where GCRecord is null order by name asc

	select roadCrashCode as crashCodeId, code, name, measure from RoadCrashCodeItem where GCRecord is null order by name asc

end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
exec dbo.sp_road_crashes