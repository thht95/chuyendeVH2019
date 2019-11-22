
select * from lophanhchinh
select * from hocsinh

go
alter proc spHocsinhDetail
as
begin
select Hocsinh_ID, (HoTen + ' ' + TenLopHC) as HoTen
from Hocsinh hs, LopHanhchinh lhc
where hs.LopHC_ID = lhc.LopHC_ID;
end

go
create proc spThoikhoabieuTheoHocsinh
as
begin 
select l.LopCLB_ID, Lichhoc 
from LopCLB l, Hoadonhocphi h, ChitiethoadonHP c
where h.HoadonHP_ID = c.HoadonHP_ID and c.LopCLB_ID = l.LopCLB_ID 

end

go
alter proc spSelectHSByLopCLBID
@clbId int
as
begin
	select * 
	from hocsinh hs, Hoadonhocphi hp, ChitiethoadonHP ct, lopclb lop, lophanhchinh lophc
	where hs.Hocsinh_ID = hp.Hocsinh_ID
	and ct.HoadonHP_ID = hp.HoadonHP_ID
	and ct.LopCLB_ID = lop.LopCLB_ID
	and lop.Trangthai = 1
	and lophc.LopHC_ID = hs.LopHC_ID
	and lop.CLB_ID = 1
end

go
create proc spSelectHoadonByHsId
@hsId int
as
begin
	select * 
	from hocsinh hs, Hoadonhocphi hp, ChitiethoadonHP ct, lopclb lop, lophanhchinh lophc
	where hs.Hocsinh_ID = hp.Hocsinh_ID
	and ct.HoadonHP_ID = hp.HoadonHP_ID
	and ct.LopCLB_ID = lop.LopCLB_ID
	and lop.Trangthai = 1
	and lophc.LopHC_ID = hs.LopHC_ID
	and hs.Hocsinh_ID = @hsId
end


go
alter table lophanhchinh
alter column namhoc varchar(100)