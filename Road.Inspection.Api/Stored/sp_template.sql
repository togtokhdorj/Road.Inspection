use [Arig]
go
drop proc dbo.sp_template
go
create proc dbo.sp_template
	@requestId			uniqueidentifier=null
as
declare @error			nvarchar(max)
declare @memberId		uniqueidentifier=null
declare @lang			nvarchar(2)='mn'

begin try
	
	set @lang = dbo.fn_get_lang(@requestId)

	set @memberId = dbo.fn_get_memberId_in_requestLog(@requestId)

	if (@memberId is null)
	begin
		set @error=dbo.fn_translate(@lang, N'Хэрэглэгчийн бүртгэл олдсонгүй!');
		raiserror(@error,16,1);
	end

end try

begin catch
	set @error=ERROR_MESSAGE();
	raiserror(@error,16,1);
	exec dbo.sp_error_log 'sp_template',@error,@requestId
end catch
go