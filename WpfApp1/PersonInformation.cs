using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WpfApp1
{
    public class PersonInformation
    {
        public string FullName
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string NumberOfPhone
        {
            get;
            set;
        }

        public string HomeAdress
        {
            get;
            set;
        }


        public DateTime BirthDay { get; set; } = DateTime.Now;
    }
}
