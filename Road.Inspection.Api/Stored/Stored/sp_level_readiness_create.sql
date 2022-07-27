use [Road.Inspection]
go
drop proc dbo.sp_level_readiness_create
go
create proc dbo.sp_level_readiness_create
	@kilometr						int=0,
	@kilometrs						int=0,
	@totalKilometrs					int=0,
	@startCoordinateLength			nvarchar(100)=null,
	@startCoordinateLatitude		nvarchar(100)=null,
	@endCoordinateLength			nvarchar(100)=null,
	@endCoordinateLatitude			nvarchar(100)=null,
	@workChairmanName				nvarchar(100)=null,
	@roadManagerCompanyName			nvarchar(100)=null,
	@position						nvarchar(100)=null,
	@name							nvarchar(100)=null,
	@pavementEdgeEvaluation			int=0,
	@dartDam						int=0,
	@bridgeThroat					int=0,
	@markRoadEquipment				int=0,
	@roadConstruction				int=0,
	@date							Datetime=null
as
declare @error  nvarchar(max)=null
begin try
	insert into LevelReadiness (Oid,kilometr,kilometrs,totalKilometrs,startCoordinateLength,startCoordinateLatitude,endCoordinateLength,endCoordinateLatitude,
								workChairmanName,roadManagerCompanyName,position,name,pavementEdgeEvaluation,dartDam,bridgeThroat,markRoadEquipment,roadConstruction,date)
		select NEWID(),@kilometr,@kilometrs,@totalKilometrs,@startCoordinateLength,@startCoordinateLatitude,@endCoordinateLength,@endCoordinateLatitude,@workChairmanName,@roadManagerCompanyName,@position,@name,@pavementEdgeEvaluation,@dartDam,@bridgeThroat,@markRoadEquipment,@roadConstruction, @date
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
