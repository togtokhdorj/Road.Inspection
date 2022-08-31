use [Road.Inspection]
go
drop proc dbo.sp_road_item_create
go
create proc dbo.sp_road_item_create
		@id						uniqueidentifier=null,
		@roadInspectionId		uniqueidentifier=null,
		@location 				nvarchar(100)=null,
		@length 				nvarchar(100)=null,
		@latitude 				nvarchar(100)=null,
		@code 					nvarchar(100)=null,
		@measure 				nvarchar(100)=null,
		@qty 					nvarchar(100)=null,
		@image1 				nvarchar(max)=null,
		@image2 				nvarchar(max)=null,
		@image3 				nvarchar(max)=null,
		@type					int=0
as
declare @error					nvarchar(max)=null,
		@isUpdate				bit=0
--RoadBridgeInjury = 1
--RoadDrainge = 2
--RoadEdgeSideSlope = 3
--RoadServiceFacility = 4
--SmoothnessRoadway = 5
--RoadLane = 6


begin try

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

	if exists (select * from RoadItem where GCRecord is not null)
	begin
		delete b from RoadItem a
			inner join RoadBridgeInjury b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete b from RoadItem a
			inner join RoadDrainge b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete b from RoadItem a
			inner join RoadEdgeSideSlope b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete b from RoadItem a
			inner join RoadServiceFacility b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete b from RoadItem a
			inner join SmoothnessRoadway b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete b from RoadItem a
			inner join RoadLane b on b.Oid = a.Oid
				where a.GCRecord is not null
		delete from RoadItem where GCRecord is not null
	end

	if exists (select * from RoadItem where Oid = @id)
	begin
		set @isUpdate = 1
	end

	if (@isUpdate = 1)
		update RoadItem set
			location = @location,
			length = @length,
			latitude = @latitude,
			code = @code,
			measure = @measure,
			qty = @qty,
			image1 = @image1,
			image2 = @image2,
			image3 = @image3
				where Oid = @id
	else
		insert into RoadItem (oid,location,length,latitude,code,qty,measure,image1,image2,image3)
			select @id,@location,@length,@latitude,@code,@qty,@measure,@image1,@image2,@image3

	if(@type = 1)
	begin
		if (@isUpdate = 0)
			insert into RoadBridgeInjury (Oid,inspectionId)
				select @id, @roadInspectionId
	end
	else if(@type = 2)
	begin
		if (@isUpdate = 0)
			insert into RoadDrainge (Oid,inspectionId)
				select @id, @roadInspectionId
	end
	else if(@type = 3)
	begin
		if (@isUpdate = 0)
			insert into RoadEdgeSideSlope (Oid,inspectionId)
				select @id, @roadInspectionId
	end
	else if(@type = 4)
	begin
		if (@isUpdate = 0)
			insert into RoadServiceFacility (Oid,inspectionId)
				select @id, @roadInspectionId
	end
	else if(@type = 5)
	begin
		if (@isUpdate = 0)
			insert into SmoothnessRoadway (Oid,inspectionId)
				select @id, @roadInspectionId
	end
	else if(@type = 6)
	begin
		if (@isUpdate = 0)
			insert into RoadLane (Oid,inspectionId)
				select @id, @roadInspectionId
	end

end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
