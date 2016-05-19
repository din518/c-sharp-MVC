using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMVC.Core
{
    public class Hospital
    {
        private int _idHospital;
        private string _Hospitalname;
        private string _physicaladdress;
        private string _email;
        public Hospital()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public int idHospital
        {
            get
            { 
                return _idHospital;
            }

            set
            {
                _idHospital = value;
            }
        }
        public string Hospitalname
        {
            get
            {
                return _Hospitalname;
            }

            set
            {
                _Hospitalname = value;
            }
        }

        public string physicaladdress
        {
            get
            {
                return _physicaladdress;
            }
            set
            {
                _physicaladdress = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
    }
}
