using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKTCode;

namespace DemoKTCodeTest
{
    [TestFixture]
    internal class SanPhamServicesTest
    {
        public SanPhamServices _SPS = null;

        [SetUp]
        public void Setup()
        {
            _SPS = new SanPhamServices();
        }
        // Edit Sửa Sản phẩm thành công
        [Test]

        public void EditThanhCong()
        {
            SanPham sanPham = new SanPham
            {
                MaSP = "SP001",
                TenSP = "Laptop Dell",
                NamBaoHanh = 36,
                Gia = 2000,
                SoLuong = 5,
                DanhMuc = "Điện tử"
            };

            Assert.IsTrue(_SPS.Edit(sanPham));
        }

        // Edit Sửa Sản phẩm thất bại với giá âm

        [Test]
        public void EditThatBaiGiaAm()
        {
            SanPham sanPham = new SanPham
            {
                MaSP = "SP001",
                TenSP = "Laptop Dell",
                NamBaoHanh = 36,
                Gia = -2000,
                SoLuong = 5,
                DanhMuc = "Điện tử"
            };
            Assert.IsFalse(_SPS.Edit(sanPham));
        }

        // Edit Sửa Sản phẩm thất bại với số lượng âm
        [Test]
        public void EditThatBaiSoLuongAm()
        {
            SanPham sanPham = new SanPham
            {
                MaSP = "SP001",
                TenSP = "Laptop Dell",
                NamBaoHanh = 36,
                Gia = 2000,
                SoLuong = -5,
                DanhMuc = "Điện tử"
            };
            Assert.IsFalse(_SPS.Edit(sanPham));
        }

        // Edit Sửa Sản phẩm thất bại với mã sản phẩm không tồn tại
        [Test]
        public void EditThatBai1()
        {
            SanPham sanPham = new SanPham
            {
                MaSP = "SP002",
                TenSP = "Laptop Dell",
                NamBaoHanh = 36,
                Gia = 2000,
                SoLuong = 5,
                DanhMuc = "Điện tử"
            };
            Assert.IsFalse(_SPS.Edit(sanPham));
        }

        //Biên
        public void EditThanhCOngVoiGia0()
        {
            SanPham sanPham = new SanPham
            {
                MaSP = "SP001",
                TenSP = "Laptop Dell",
                NamBaoHanh = 36,
                Gia = 0,
                SoLuong = 5,
                DanhMuc = "Điện tử"
            };
            Assert.IsTrue(_SPS.Edit(sanPham));
        }
        [Test]
        public void ChechMatontai()
        {
            Assert.IsTrue(_SPS.ChechMatontai("SP001"));
        }

        [Test]
        public void DeleteThanhCong()
        {
            Assert.IsTrue(_SPS.Delete("SP001"));
        }

        [Test]
        public void DeleteThatBai()
        {
            Assert.IsFalse(_SPS.Delete("SP002"));
        }
        [Test]        

        
        public void ChechMatontaiThatBai()
        {
            Assert.IsFalse(_SPS.ChechMatontai("SP002"));
        }
    }
}
