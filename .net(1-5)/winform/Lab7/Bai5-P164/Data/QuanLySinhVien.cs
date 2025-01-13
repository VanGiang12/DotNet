using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_P164.Data
{
    public class QuanLySinhVien
    {
        private string filePath = @"D:\myfile\SVCK.bin";

        public List<SinhVienCoKhi> DocDanhSach()
        {
            List<SinhVienCoKhi> danhSachSV = new List<SinhVienCoKhi>();

            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    danhSachSV = (List<SinhVienCoKhi>)bin.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc danh sách: " + ex.Message);
            }

            return danhSachSV;
        }

        public void GhiDanhSach(List<SinhVienCoKhi> danhSachSV)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, danhSachSV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi danh sách: " + ex.Message);
            }
        }
    }
}
