use [Road.Inspection]
go
drop proc dbo.sp_road_inspection_get
go
create proc dbo.sp_road_inspection_get
--RoadBridgeInjury = 1
--RoadDrainge = 2
--RoadEdgeSideSlope = 3
--RoadServiceFacility = 4
--SmoothnessRoadway = 5
--RoadLane = 6
as
declare @error  nvarchar(max)=null
begin try
		select * into #roadInspection From RoadInspection where GCRecord is null
		select * from #roadInspection
		/*RoadBridgeInjury*/
		select c.*,b.inspectionId from #roadInspection a
			join RoadBridgeInjury b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
		/*RoadDrainge*/
		select c.*,b.inspectionId from #roadInspection a
			join RoadDrainge b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
		/*RoadEdgeSideSlope*/
		select c.*,b.inspectionId from #roadInspection a
			join RoadEdgeSideSlope b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
		/*RoadServiceFacility*/
		select c.*,b.inspectionId from #roadInspection a
			join RoadServiceFacility b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
		/*SmoothnessRoadway*/
		select c.*,b.inspectionId from #roadInspection a
			join SmoothnessRoadway b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
		/*RoadLane*/
		select c.*,b.inspectionId from #roadInspection a
			join RoadLane b on a.Oid = b.inspectionId
			join RoadItem c on b.Oid = c.Oid
				where c.GCRecord is null and c.Oid = b.Oid
	
end try
begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
end catch
go
exec sp_road_inspection_get
