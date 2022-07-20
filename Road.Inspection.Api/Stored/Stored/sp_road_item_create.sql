use [Road.Inspection]
go
drop proc dbo.sp_road_item_create
go
create proc dbo.sp_road_item_create
		@roadInspectionId		uniqueidentifier=null,
		@location 				nvarchar(100)=null,
		@length 				nvarchar(100)=null,
		@latitude 				nvarchar(100)=null,
		@code 					nvarchar(100)=null,
		@measure 				nvarchar(100)=null,
		@image 					nvarchar(100)=null,
		@type					int=0
as
declare @error					nvarchar(max)=null
declare @roadItemId				uniqueidentifier=null
--RoadBridgeInjury = 1
--RoadDrainge = 2
--RoadEdgeSideSlope = 3
--RoadServiceFacility = 4
--SmoothnessRoadway = 5
--RoadLane = 6


begin try
	set @roadItemId = newid()
	if(@roadInspectionId is null)
	begin
		set @error= N'Үндсэн бүртгэлийн мэдээлэл хоосон илгээж байна.';
		raiserror(@error,16,1);
	end
	if not exists (select 1 from RoadInspection where Oid = @roadInspectionId and GCRecord is null)
	begin
		set @error= N'Үндсэн бүртгэлийн мэдээлэл олдсонгүй.';
		raiserror(@error,16,1);
	end	
	if(@type = 1)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
			select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into RoadBridgeInjury (Oid,inspectionId)
			select @roadItemId, @roadInspectionId
	end
	else if(@type = 2)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
			select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into RoadDrainge (Oid,inspectionId)
			select @roadItemId, @roadInspectionId
	end
	else if(@type = 3)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
			select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into RoadEdgeSideSlope (Oid,inspectionId)
			select @roadItemId, @roadInspectionId
	end
	else if(@type = 4)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
			select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into RoadServiceFacility (Oid,inspectionId)
			select @roadItemId, @roadInspectionId
	end
	else if(@type = 5)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
				select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into SmoothnessRoadway (Oid,inspectionId)
				select @roadItemId, @roadInspectionId
	end
	else if(@type = 6)
	begin
		insert into RoadItem (oid,location,length,latitude,code,measure,image)
				select @roadItemId,@location,@length,@latitude,@code,@measure,@image
		insert into RoadLane(Oid,inspectionId)
				select @roadItemId, @roadInspectionId
	end
end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
