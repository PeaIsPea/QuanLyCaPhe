using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class Bill
    {

        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow rows)//bỏ mấy cái này vô row
        {
            this.ID = (int)rows["id"];
            this.dateCheckIn = (DateTime?)rows["dateCheckIn"];
            var dateCheckOutTemp = rows["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)rows["status"];
            if(rows["discount"].ToString()!= "")
                this.Discount = (int)rows["discount"];
        }

        private int discount;


        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
