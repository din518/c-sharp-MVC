using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SimpleMVC.Core
{
    public class HospitalDAO
    {
        private HospitalDBConnection conn;
        public HospitalDAO()
        {
            conn = new HospitalDBConnection();
        }
        public DataTable searchByName(string _Hospitalname)
        {
            string query = string.Format("select * from [h1_Hospital] 
		where h1_Hospitalname like @h1_Hospitalname or h1_email 
		like @h1_email");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@h1_Hospitalname", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_Hospitalname);
            sqlParameters[1] = new SqlParameter("@h1_email", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_email);
            return conn.executeSelectQuery(query, sqlParameters);
        }
        public DataTable searchById(string _id)
        {
            string query = "select * from [h1_id] where h1_id = @h1_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@h1_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}