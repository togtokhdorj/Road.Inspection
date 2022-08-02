use [Road.Inspection]
go
drop proc dbo.sp_level_readiness_update
go
create proc dbo.sp_level_readiness_update
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
	@date							Datetime=null,
	@id								uniqueidentifier=null
as
declare @error  nvarchar(max)=null
begin try
	update LevelReadiness
		set kilometr = @kilometr,
			kilometrs = @kilometrs,
			totalKilometrs = @totalKilometrs,
			startCoordinateLength = @startCoordinateLength,
			startCoordinateLatitude = @startCoordinateLatitude,
			endCoordinateLength = @endCoordinateLength,
			endCoordinateLatitude = @endCoordinateLatitude,
			workChairmanName = @workChairmanName,
			roadManagerCompanyName = @roadManagerCompanyName,
			position = @position,
			[name] = @name,
			pavementEdgeEvaluation = @pavementEdgeEvaluation,
			dartDam = @dartDam,
			bridgeThroat = @bridgeThroat,
			markRoadEquipment = @markRoadEquipment,
			roadConstruction = @roadConstruction,
			date = @date
				where Oid = @id
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
