use [Road.Inspection]
go
drop proc dbo.sp_road_inspection_create
go
create proc dbo.sp_road_inspection_create
	@id						uniqueidentifier=null,
	@teamLeader				nvarchar(100)=null,
	@inspectionEngineer		nvarchar(100)=null,
	@measuringInstrument		nvarchar(100)=null,
	@other					nvarchar(100)=null,
	@markType				nvarchar(100)=null,
	@plateNumber			nvarchar(100)=null,
	@roadNumber				nvarchar(100)=null,
	@roadDirection			nvarchar(100)=null,
	@category				nvarchar(100)=null,
	@startPoint				nvarchar(100)=null,
	@endPoint				nvarchar(100)=null,
	@kilometr				nvarchar(100)=null,
	@kilometrs				nvarchar(100)=null,
	@endCoordinates			nvarchar(100)=null,
	@degrees				nvarchar(100)=null,
	@beforeLeftLane			nvarchar(100)=null,
	@beforeRightLane		nvarchar(100)=null,
	@currentLeftLane		nvarchar(100)=null,
	@currentRightLane		nvarchar(100)=null,
	@specialNote			nvarchar(100)=null,
	@subscriberName			nvarchar(100)=null,
	@subscriberPositions	nvarchar(100)=null,
	@consultantName			nvarchar(100)=null,
	@consultantPositions	nvarchar(100)=null,
	@roadManager			nvarchar(100)=null,
	@roadPositions			nvarchar(100)=null,
	@weather				int=0,
	@date					DateTime=null
as
declare @error  nvarchar(max)=null
begin try
	if(@id is null)
	begin
		set @error=N'Бүртгэх боломжгүй байна.';
		raiserror(@error,16,1);
	end
	insert into RoadInspection (Oid,teamLeader,inspectionEngineer,measuringInstrument,other,markType,plateNumber,roadNumber,roadDirection,category,startPoint,endPoint,kilometr,kilometrs,endCoordinates,degrees,beforeLeftLane,beforeRightLane,currentLeftLane,currentRightLane,specialNote,subscriberName,subscriberPositions,consultantName,consultantPositions,roadManager,roadPositions,weather,date)
		select 	@id ,@teamLeader ,@inspectionEngineer ,@measuringInstrument ,@other ,@markType ,@plateNumber ,@roadNumber ,@roadDirection ,@category ,@startPoint ,@endPoint ,@kilometr ,@kilometrs ,@endCoordinates ,@degrees ,@beforeLeftLane ,@beforeRightLane ,@currentLeftLane ,@currentRightLane ,@specialNote ,@subscriberName ,@subscriberPositions ,@consultantName ,@consultantPositions ,@roadManager ,@roadPositions ,@weather,@date
end try
begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
