using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hotel
{
    public class Functions
    {
        static SqlConnection conn = new SqlConnection();
        public static void getConn()
        {
            //conn.ConnectionString = "Server=DESKTOP-B01JAC6\\MSSQLSERVER1;Database=HotelDB;User Id=sa;Password=1;";
            conn.ConnectionString = "Server=DESKTOP-B01JAC6\\MSSQLSERVER1;Database=HotelDB;User Id=sa;Password=1;";

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void closeConn()
        {
            conn.Close();
        }

        public static DataTable getData(string sql)
        {
            getConn();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = new SqlCommand(sql, conn);
            adap.Fill(dt);
            closeConn();
            return dt;
        }

        public static DataTable getTbOrderDetailRoom(int id)
        {
            getConn();
            string sql = "SELECT r.id, r.num, f.id, f.name, tr.price FROM Room r, TypeRoom tr, Floor f, OrderDetailRoom o WHERE r.floorId = f.id AND r.typeRoomId = tr.id AND o.roomID = r.id AND o.orderID =@OrderId";
            SqlCommand command = new SqlCommand(sql, Functions.conn);
            command.Parameters.AddWithValue("@OrderId", id);
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(command);
            adap.Fill(dt);
            closeConn();
            return dt;
        }

        public static int getDayAt(DateTime d1, DateTime d2)
        {
            return (d2 - d1).Days;
        }
    }
}
