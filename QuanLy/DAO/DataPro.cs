using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    public class DataPro
    {
        private string connected = @"Data Source=LAPTOP-0R646PR6\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        //tạo một Design patern Singleton
        private static DataPro instance;

        public static DataPro Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataPro();

                }
                return DataPro.instance;
            }
            set
            {
                DataPro.instance = value;
            }
        }
        private DataPro() { }

        //viết hàm ExcuteQuery
        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connected))
                //using này có tác dụng khi mà kết thúc khối lệnh này rồi á thì cái dữ liệu được khai báo ở đây sẽ tự dc giải phóng
            {
                conn.Open();

                //để excute câu query trên conn
                SqlCommand cmd = new SqlCommand(query, conn);

                if(para != null )
                {
                    string[] listPara = query.Split(' ');//cắt từng dòng para
                    int i = 0;
                    foreach(string s in listPara ) //lấy từng item trong listPara
                    {
                        if (s.Contains("@"))//kiểm tra mà có dấu @
                        {
                            cmd.Parameters.AddWithValue(s, para[i]);//thì add value
                            i++;//i++ tăng lên
                        }
                    }
                }



                //trung gian để thực hiện câu truy vấn lấy dữ liệu
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(data);//đổ dữ liệu lên cái DataTable

                conn.Close();

            }
            return data;
 

        }
        

        //hàm trả ra số dòng thực thi thành công khi thao tác thêm sửa xóa
        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connected))
            //using này có tác dụng khi mà kết thúc khối lệnh này rồi á thì cái dữ liệu được khai báo ở đây sẽ tự dc giải phóng
            {
                conn.Open();

                //để excute câu query trên conn
                SqlCommand cmd = new SqlCommand(query, conn);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');//cắt từng dòng para
                    int i = 0;
                    foreach (string s in listPara) //lấy từng item trong listPara
                    {
                        if (s.Contains("@"))//kiểm tra mà có dấu @
                        {
                            cmd.Parameters.AddWithValue(s, para[i]);//thì add value
                            i++;//i++ tăng lên
                        }
                    }
                }



                data = cmd.ExecuteNonQuery();

                conn.Close();

            }
            return data;

        }

        //trả ra số lượng kiểu 1 cái dòng hay 1 cái ô đầu tiên trong DataSet
        public object ExecuteScalar(string query, object[] para = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connected))
            //using này có tác dụng khi mà kết thúc khối lệnh này rồi á thì cái dữ liệu được khai báo ở đây sẽ tự dc giải phóng
            {
                conn.Open();

                //để excute câu query trên conn
                SqlCommand cmd = new SqlCommand(query, conn);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');//cắt từng dòng para
                    int i = 0;
                    foreach (string s in listPara) //lấy từng item trong listPara
                    {
                        if (s.Contains("@"))//kiểm tra mà có dấu @
                        {
                            cmd.Parameters.AddWithValue(s, para[i]);//thì add value
                            i++;//i++ tăng lên
                        }
                    }
                }



                data = cmd.ExecuteScalar();

                conn.Close();

            }
            return data;

        }
    }
}
