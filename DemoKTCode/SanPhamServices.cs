using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCode
{
    public class SanPhamServices
    {
        private readonly List<SanPham> sanPhams = new List<SanPham>();

        public SanPhamServices() 
        {
        sanPhams.Add(new SanPham 
        { MaSP = "SP001", TenSP = "Laptop", NamBaoHanh = 24, Gia = 1500, SoLuong = 10, DanhMuc = "Điện tử" });
        }

        public SanPham? GetBySP(string Masp)
        {
            return sanPhams.FirstOrDefault(x => x.MaSP == Masp);
        }

        public bool Add(SanPham sp)
        {
            try
            {
                if(sp.Gia < 0 || sp.SoLuong <0 ) return false;
                if(sanPhams.Exists(x => x.MaSP == sp.MaSP)) return false;

                sanPhams.Add(sp);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(SanPham sp)
        {
            var Exisst = sanPhams.FirstOrDefault(x=> x.MaSP == sp.MaSP);
            if(Exisst != null)
            {
                if (sp.Gia < 0 || sp.SoLuong < 0) return false;
                Exisst.TenSP = sp.TenSP;
                Exisst.NamBaoHanh = sp.NamBaoHanh;
                Exisst.Gia = sp.Gia;
                Exisst.SoLuong = sp.SoLuong;
                Exisst.DanhMuc = sp.DanhMuc;
                return true;
            }
            return false;
        }

        public bool Delete(string sp)
        {
            var Exisst = sanPhams.FirstOrDefault(x => x.MaSP == sp);
            if (Exisst != null)
            {
                sanPhams.Remove(Exisst);
                return true;
            }
            return false;
        }

        public bool ChechMatontai(string sp)
        {
          if( sanPhams.Exists(x => x.MaSP == sp))
            {
                return true;
            }
            
            return false;

        }
    }
}
