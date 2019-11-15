
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
