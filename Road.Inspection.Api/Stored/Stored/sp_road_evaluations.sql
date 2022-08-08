use [Road.Inspection]
go
drop proc dbo.sp_road_evaluations
go
create proc dbo.sp_road_evaluations
as
declare @error			nvarchar(max)

begin try
	
	select * from RoadEvaluation where GCRecord is null order by name asc

	select roadEvaluation as roadEvaluationId, code, name, evaluation from RoadEvaluationItem where GCRecord is null order by name asc

end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
exec dbo.sp_road_evaluations