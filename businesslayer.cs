using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SimpleMVC.Core
{
    public class HospitalBUS
    {
        private HospitalDAO _HospitalDAO;
        public HospitalBUS()
        {
            _HospitalDAO  = new HospitalDAO();
        }
        public HospitalVO getHospitalEmailByName(string name)
        {
            HospitalVO HospitalVO = new HospitalVO();
            DataTable dataTable = new DataTable();

            dataTable = _HospitalDAO.searchByName(name);

            foreach (DataRow dr in dataTable.Rows)
            {
                HospitalVO.idHospital = Int32.Parse(dr["h1_id"].ToString());
                HospitalVO.Hospitalname = dr["h1_Hospitalname"].ToString();
                HospitalVO.physicaladdress = dr["h1_physicaladdress"].ToString();
                HospitalVO.email = dr["h1_email"].ToString();
            }
            return HospitalVO;
        }

    
        public HospitalVO getHospitalById(string _id)
        {
            HospitalVO HospitalVO = new HospitalVO();
            DataTable dataTable = new DataTable();
            dataTable = _HospitalDAO.searchById(_id);

            foreach (DataRow dr in dataTable.Rows)
            {
                HospitalVO.idHospital = Int32.Parse(dr["h1_id"].ToString());
                HospitalVO.Hospitalname = dr["h1_Hospitalname"].ToString();
                HospitalVO.physicaladdress = dr["h1_physicaladdress"].ToString();
                HospitalVO.email = dr["h1_email"].ToString();
            }
            return HospitalVO;
        }
    }
}
