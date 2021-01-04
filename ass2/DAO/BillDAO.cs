using ass2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DAO
{
    class BillDAO
    {
        private static BillDAO instance; // Ctrl + R + E

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        public List<Bill> SelectAllBill()
        {
            List<Bill> re = new List<Bill>();
            string query = "SELECT * FROM dbo.BILL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                re.Add(new Bill(item));
            }
            return re;
        }
        public void CreatBill(string total,string cus,string emp) 
        {
            string query = "EXEC dbo.p_addBill "+ total + "," + cus+ "," + emp;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteById(string id)
        {
            string query = "DELETE dbo.BILL WHERE ID = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdateBill(string id,string total)
        {
            string query = "UPDATE dbo.BILL SET Total =" +total+" WHERE ID ="+ id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
