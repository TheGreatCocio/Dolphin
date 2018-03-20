using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class DAL
    {
        public DAL()
        {
        }
        private static DAL instance;

        public static DAL Instance
        {
            get
            {
                if (instance == null)
                { instance = new DAL(); }
                return instance;
            }
        }

        private string sqlConn;
        private SqlConnection SqlConnection = null;

        private void ConnectSql()
        {

            sqlConn = @"server=DESKTOP-OMSM6ON; Database=DolphinDB; Trusted_Connection=True";
           

            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(sqlConn);
            }
            try
            {
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("####################Failed to connect to sql server: " + ex);
            }
        }

        public bool CreateMember(Member member)
        {
            try
            {
                ConnectSql();
                SqlCommand cmd = new SqlCommand("INSERT INTO Member VALUES ('" + member.Name + "', '" + member.Adress + "', '" + member.PhoneNumber + "', '" + member.Birthday.Date + "', '" + member.EnrollDate.Date + "', 1, '" + member.MembershipType + "', 1, 1)", SqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SqlConnection.Close();
            }
            return true;
        }
    }
}
