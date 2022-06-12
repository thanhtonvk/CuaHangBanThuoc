using CuaHangBanThuoc.BLL.InterfaceService;
using CuaHangBanThuoc.DAL;
using CuaHangBanThuoc.DAL.InterfaceService;
using CuaHangBanThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThuoc.BLL
{
    internal class ChiTietHDBBLL : IChiTietHDBBLL
    {
        IChiTietHDBDAL dal = new ChiTietHDBDAL();

        public string Add(ChiTietHDB chiTietHDB)
        {
            
           int rs = dal.Add(chiTietHDB);
            if (rs > 0) return "Thành công";
            return "Không thành công";
        }

        public string Delete(int id)
        {
           int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Không thành công";
        }

        public List<getChiTietHoaDonBan_Result> GetAll(int idHDB)
        {
           return dal.GetAll(idHDB);
        }

        public ChiTietHDB GetChiTietHDB(int id)
        {
            return dal.GetChiTietHDB(id);
        }
    }
}
