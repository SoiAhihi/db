using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DTO
{
    class Bill
    {
        private int id;
        private DateTime cre;
        private int total;
        private int cus;
        private int emp;
        private int bra;
        private int pro;

        public int Id { get => id; set => id = value; }
        public DateTime Cre { get => cre; set => cre = value; }
        public int Total { get => total; set => total = value; }
        public int Cus { get => cus; set => cus = value; }
        public int Emp { get => emp; set => emp = value; }
        public int Bra { get => bra; set => bra = value; }
        public int Pro { get => pro; set => pro = value; }
        public Bill(DataRow row)
        {
            this.id = (int)row["ID"];
            this.total = (int)row["Total"];
            this.emp = (int)row["Emp_id"];
            try
            {
                
                this.cus = (int)row["Cus_id"];
            }
            catch (Exception)
            {

                this.cus = -1;
            }
            try
            {
                this.bra = Convert.ToInt32(row["Branch_id"]);
            }
            catch (Exception)
            {

                this.bra = -1;
            }

            
            this.pro = (int)row["idPro"];
            this.cre = (DateTime)row["Created_Day"];
        }
    }
}
