using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data;

namespace QuanLyNhanVien
{
    class KetNoi
    {
        public SqlConnection connection = new SqlConnection();

        public KetNoi()
        {
            try
            {
                connection.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
                connection.Open();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public DataTable LoadData(string TT)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = TT;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            return data;
        }
        public DataTable LoadDataDK(string proc, string param, string value)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = value;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable LoadDataDK_2DK(string proc, string param1,string param2, string value1,string value2)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param1, SqlDbType.VarChar).Value = value1;
            command.Parameters.AddWithValue(param2, SqlDbType.VarChar).Value = value2;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataSet LoadDataSet(string proc)
        {
            DataSet data = new DataSet();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable LoadDataUser(string name, string pass)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DangNhapDK";
            command.Parameters.AddWithValue("@Ten", SqlDbType.VarChar).Value = name;
            command.Parameters.AddWithValue("@MK", SqlDbType.VarChar).Value = pass;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
         
            return table;
        }
        public void ChucVu(string proc, string ma, string ten, string phuCap)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaChucVu", SqlDbType.VarChar).Value = ma;
                command.Parameters.AddWithValue("@Ten", SqlDbType.NVarChar).Value = ten;
                command.Parameters.AddWithValue("@PhuCap", SqlDbType.Int).Value = phuCap;
                command.ExecuteNonQuery();
          
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
          
            }

        }
        public void LuongNV(string proc, string maLuong, string maNV, string luong, string soNgayCong, string thangNam)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaLuong", SqlDbType.VarChar).Value = maLuong;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
                command.Parameters.AddWithValue("@Luong", SqlDbType.Int).Value = luong;
                command.Parameters.AddWithValue("@SoNgayCong", SqlDbType.Int).Value = soNgayCong;
                command.Parameters.AddWithValue("@ThangNam", SqlDbType.VarChar).Value = thangNam;
                command.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
         
            }

        }

        public void HopDong(string proc, string maHD, string maNV, string luongHD, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaHD", SqlDbType.VarChar).Value = maHD;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
                command.Parameters.AddWithValue("@Luong", SqlDbType.Int).Value = luongHD;
                command.Parameters.AddWithValue("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
                command.Parameters.AddWithValue("@NgayKetThuc", SqlDbType.Date).Value = ngayKetThuc;
                command.ExecuteNonQuery();
           
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
     
            }

        }

        public void BaoHiemNV(string proc, string maBH, string maNV, string ngayBatDau, string ngayKetThuc, string soTien)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaBH", SqlDbType.VarChar).Value = maBH;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
                command.Parameters.AddWithValue("@SoTien", SqlDbType.Int).Value = soTien;
                command.Parameters.AddWithValue("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
                command.Parameters.AddWithValue("@NgayKetThuc", SqlDbType.Date).Value = ngayKetThuc;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        public void DanhMucBH(string proc, string maBH, string ten, string tiLe)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaBH", SqlDbType.VarChar).Value = maBH;
                command.Parameters.AddWithValue("@Ten", SqlDbType.NVarChar).Value = ten;
                command.Parameters.AddWithValue("@TiLeBH", SqlDbType.Float).Value = tiLe;
                command.ExecuteNonQuery();
            
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
      
            }

        }

        public void PhongBan(string proc, string maPhongBan, string ten, string SDT)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaPhongBan", SqlDbType.VarChar).Value = maPhongBan;
                command.Parameters.AddWithValue("@Ten", SqlDbType.NVarChar).Value = ten;
                command.Parameters.AddWithValue("@DienThoai", SqlDbType.VarChar).Value = SDT;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
       
            }

        }

        public void DanhSachKTKL(string proc, string maKTKL,string maNV, string ngay, string ghiChu)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaKTKL", SqlDbType.VarChar).Value = maKTKL;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
                command.Parameters.AddWithValue("@Ngay", SqlDbType.Date).Value = ngay;
                command.Parameters.AddWithValue("@GhiChu", SqlDbType.NVarChar).Value = ghiChu ;
                command.ExecuteNonQuery();
          
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
      
            }

        }

        public void TuyenDung(string proc, string maTuyenDung, string Ten)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaTD", SqlDbType.VarChar).Value = maTuyenDung;
                command.Parameters.AddWithValue("@Ten", SqlDbType.NVarChar).Value = Ten;
                command.ExecuteNonQuery();
      
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
          
            }

        }


        public void QuyDinhKTKL(string proc, string maKTKL, string ten, string tien)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaKTKL", SqlDbType.VarChar).Value = maKTKL;
                command.Parameters.AddWithValue("@Ten", SqlDbType.NVarChar).Value = ten;
                command.Parameters.AddWithValue("@SoTien", SqlDbType.Int).Value = tien;
                command.ExecuteNonQuery();
     
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
     
            }

        }

        public void DanhSachNV(string proc, string maNV,string maTD,string maCV,string maPB, string noiLV, string HoTen,
            string NS, string QueQuan, string gt, string CMND, string trinhDo, string SDT,string email, string noiO, string NoiSinh)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
                command.Parameters.AddWithValue("@MaTD", SqlDbType.VarChar).Value = maTD;
                command.Parameters.AddWithValue("@MaCV", SqlDbType.VarChar).Value = maCV;
                command.Parameters.AddWithValue("@MaPB", SqlDbType.VarChar).Value = maPB;
                command.Parameters.AddWithValue("@NoiLV", SqlDbType.NVarChar).Value = noiLV;
                command.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                command.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = NS;
                command.Parameters.AddWithValue("@QueQuan", SqlDbType.NVarChar).Value = QueQuan;
                command.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = gt;
                command.Parameters.AddWithValue("@CMND", SqlDbType.VarChar).Value = CMND;
                command.Parameters.AddWithValue("@TrinhDo", SqlDbType.NVarChar).Value = trinhDo;
                command.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = SDT;
                command.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = email;
                command.Parameters.AddWithValue("@NoiO", SqlDbType.NVarChar).Value = noiO;
                command.Parameters.AddWithValue("@NoiSinh", SqlDbType.NVarChar).Value = NoiSinh;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);

            }

        }
        public void Xoa(string proc, string paramMa, string ma)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramMa, SqlDbType.VarChar).Value = ma;
                command.ExecuteNonQuery();
  
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
     
            }

        }

        public void Xoa_2DK(string proc, string paramMa1, string paramMa2, string ma1, string ma2)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramMa1, SqlDbType.VarChar).Value = ma1;
                command.Parameters.AddWithValue(paramMa2, SqlDbType.VarChar).Value = ma2;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);

            }

        }



    }
}
