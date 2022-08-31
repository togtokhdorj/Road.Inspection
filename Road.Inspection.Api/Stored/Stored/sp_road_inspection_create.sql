use [Road.Inspection]
go
drop proc dbo.sp_road_inspection_create
go
create proc dbo.sp_road_inspection_create
	@id						uniqueidentifier=null,
	@teamLeader				nvarchar(100)=null,
	@inspectionEngineer		nvarchar(100)=null,
	@measuringInstrument	nvarchar(100)=null,
	@other					nvarchar(500)=null,
	@markType				nvarchar(100)=null,
	@plateNumber			nvarchar(20)=null,
	@roadNumber				nvarchar(20)=null,
	@roadDirection			nvarchar(100)=null,
	@category				nvarchar(100)=null,
	@startPointN			nvarchar(30)=null,
	@startPointE			nvarchar(30)=null,
	@endPointN				nvarchar(30)=null,
	@endPointE				nvarchar(30)=null,
	@kilometr				nvarchar(20)=null,
	@kilometrs				nvarchar(20)=null,
	@weather				nvarchar(100)=null,
	@degrees				nvarchar(10)=null,
	@beforeLaneDate			nvarchar(20)=null,
	@beforeLeftLane			nvarchar(5)=null,
	@beforeRightLane		nvarchar(5)=null,
	@currentLeftLane		nvarchar(5)=null,
	@currentRightLane		nvarchar(5)=null,
	@specialNote			nvarchar(500)=null,
	@subscriberName			nvarchar(100)=null,
	@subscriberPositions	nvarchar(200)=null,
	@consultantName			nvarchar(100)=null,
	@consultantPositions	nvarchar(200)=null,
	@roadManager			nvarchar(100)=null,
	@roadPositions			nvarchar(200)=null,
	@companyName			nvarchar(500)=null,
	@date					DateTime=null
as
declare @error  nvarchar(max)=null
begin try
	--alter table RoadInspection
	--	alter column degrees nvarchar(10)
	if(@id is null)
	begin
		set @error=N'Бүртгэх боломжгүй байна.';
		raiserror(@error,16,1);
	end
	if exists (select 1 from RoadInspection where GCRecord is not null)
	begin
		delete from RoadInspection where GCRecord is not null
	end
	if exists (select 1 from RoadInspection where Oid = @id and GCRecord is null)
	begin
		update RoadInspection set
			teamLeader = @teamLeader,
			inspectionEngineer = @inspectionEngineer,
			measuringInstrument = @measuringInstrument,
			other = @other,
			markType = @markType,
			plateNumber = @plateNumber,
			roadNumber = @roadNumber,
			roadDirection = @roadDirection,
			category = @category,
			startPointN = @startPointN,
			startPointE = @startPointE,
			endPointN = @endPointN,
			endPointE = @endPointE,
			kilometr = @kilometr,
			kilometrs = @kilometrs,
			degrees = @degrees,
			beforeLaneDate = @beforeLaneDate,
			beforeLeftLane = @beforeLeftLane,
			beforeRightLane = @beforeRightLane,
			currentLeftLane = @currentLeftLane,
			currentRightLane = @currentRightLane,
			specialNote = @specialNote,
			subscriberName = @subscriberName,
			subscriberPositions = @subscriberPositions,
			consultantName = @consultantName,
			consultantPositions = @consultantPositions,
			roadManager = @roadManager,
			roadPositions = @roadPositions,
			weather = @weather,
			date = @date,
			companyName = @companyName
				where Oid = @id and GCRecord is null
	end
	else
	begin
		insert into RoadInspection (Oid,teamLeader,inspectionEngineer,measuringInstrument,other,markType,plateNumber,roadNumber,roadDirection,category,startPointN,startPointE,endPointN,endPointE,kilometr,kilometrs,degrees,beforeLaneDate,beforeLeftLane,beforeRightLane,currentLeftLane,currentRightLane,specialNote,subscriberName,subscriberPositions,consultantName,consultantPositions,roadManager,roadPositions,weather,date,companyName)
			select 	@id,@teamLeader,@inspectionEngineer,@measuringInstrument,@other,@markType,@plateNumber,@roadNumber,@roadDirection,@category,@startPointN,@endPointE,@startPointN,@endPointE,@kilometr,@kilometrs,@degrees,@beforeLaneDate,@beforeLeftLane,@beforeRightLane,@currentLeftLane,@currentRightLane,@specialNote,@subscriberName,@subscriberPositions,@consultantName,@consultantPositions,@roadManager,@roadPositions,@weather,@date,@companyName
	end
end try
begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
