use [Road.Inspection]
go
drop proc dbo.sp_level_readiness_create
go
create proc dbo.sp_level_readiness_create
	@id								uniqueidentifier=null,
	@kmFrom							float=0,
	@kmTo							float=0,
	@kmTotal						float=0,
	@startPointN					nvarchar(15)=null,
	@startPointE					nvarchar(15)=null,
	@endPointN						nvarchar(15)=null,
	@endPointE						nvarchar(15)=null,
	@date							Datetime=null,
	@subscriberName					nvarchar(100)=null,
	@subscriberPositions			nvarchar(200)=null,
	@consultantName					nvarchar(100)=null,
	@consultantPositions			nvarchar(200)=null,
	@roadManager					nvarchar(100)=null,
	@roadPositions					nvarchar(200)=null,
	@other							nvarchar(500)=null,
	@pavementEdgeEvaluation			int=0,
	@dartDam						int=0,
	@bridgeThroat					int=0,
	@markRoadEquipment				int=0,
	@roadConstruction				int=0
as
declare @error  nvarchar(max)=null
begin try
	if(@id is null)
	begin
		set @error=N'Бүртгэх боломжгүй байна.';
		raiserror(@error,16,1);
	end
	if exists (select 1 from LevelReadiness where GCRecord is not null)
	begin
		delete from LevelReadiness where GCRecord is not null
	end
	if exists (select 1 from LevelReadiness where Oid = @id and GCRecord is null)
	begin
		update LevelReadiness set
			Oid = @id,
			date = @date,
			kmFrom = @kmFrom,
			kmTo = @kmTo,
			kmTotal = @kmTotal,
			startPointE = @startPointE,
			startPointN = @startPointN,
			endPointE = @endPointE,
			endPointN = @endPointN,
			subscriberName = @subscriberName,
			subscriberPositions = @subscriberPositions,
			consultantName = @consultantName,
			consultantPositions = @consultantPositions,
			roadManager = @roadManager,
			roadPositions = @roadPositions,
			pavementEdgeEvaluation = @pavementEdgeEvaluation,
			dartDam = @dartDam,
			bridgeThroat = @bridgeThroat,
			markRoadEquipment = @markRoadEquipment,
			roadConstruction = @roadConstruction,
			other = @other
				where Oid = @id and GCRecord is null
	end
	else
	begin
		insert into LevelReadiness (Oid,date,kmFrom,kmTo,kmTotal,startPointE,startPointN,endPointE,endPointN,subscriberName,subscriberPositions,consultantName,consultantPositions,roadManager,roadPositions,other,pavementEdgeEvaluation,dartDam,bridgeThroat,markRoadEquipment,roadConstruction)
			select @id,@date,@kmFrom,@kmTo,@kmTotal,@startPointE,@startPointN,@endPointE,@endPointN,@subscriberName,@subscriberPositions,@consultantName,@consultantPositions,@roadManager,@roadPositions,@other,@pavementEdgeEvaluation, @dartDam,@bridgeThroat,@markRoadEquipment,@roadConstruction
	end
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
