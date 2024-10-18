using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    public class BillDAO
    {

        private static BillDAO instance;
        

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO() { }

        public int GetBillIDByTableIDUnCheck(int id)
        {
            DataTable data = DataPro.Instance.ExecuteQuery("Select *from dbo.Bill Where idTable = " + id + " and status = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }



            return -1;
        }

        public void CheckOut(int id, int discount, float tongTien)
        {
            string query = "update dbo.Bill set dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + tongTien + " where id = " + id;
            DataPro.Instance.ExecuteNonQuery(query);
        }


        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "exec usp_getlistbillbydate @checkIn , @checkOut";
            DataTable hoadon = DataPro.Instance.ExecuteQuery(query, new object[] {checkIn, checkOut});
            return hoadon;
        }



        public void ThemBill(int id)
        {
            DataPro.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] {id});

        }

        public int GetMaxIDBill(int id)
        {
            try
            {
                return (int)DataPro.Instance.ExecuteScalar("select max(id) From dbo.Bill");

            }
            catch
            {
                return -1;
            }
            

        }
    }
}
