using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    internal class Bill

    {

        public Bill(int id,DateTime? dateCheckIn,DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.status = status;   
        }

        public Bill(DataRow row)
        {
            this.ID = (int) row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            
            this.status = (int)row["status"];

        }

        private int status;
        public int Status { get => status; set => status = value; }


        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        private int iD;

        public int ID { get => iD; set => iD = value; }
        
    }
}
