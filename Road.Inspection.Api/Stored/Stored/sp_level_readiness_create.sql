use [Road.Inspection]
go
drop proc dbo.sp_create_level_readiness
go
create proc dbo.sp_create_level_readiness
	@kilometr						int=0,
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
	@roadConstruction				int=0
as
declare @error  nvarchar(max)=null
begin try
	insert into LevelReadiness (Oid,kilometr,totalKilometrs,startCoordinateLength,startCoordinateLatitude,endCoordinateLength,endCoordinateLatitude,
								workChairmanName,roadManagerCompanyName,position,name,pavementEdgeEvaluation,dartDam,bridgeThroat,markRoadEquipment,roadConstruction)
		select NEWID(),@kilometr,@totalKilometrs,@startCoordinateLength,@startCoordinateLatitude,@endCoordinateLength,@endCoordinateLatitude,@workChairmanName,@roadManagerCompanyName,@position,@name,@pavementEdgeEvaluation,@dartDam,@bridgeThroat,@markRoadEquipment,@roadConstruction
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
