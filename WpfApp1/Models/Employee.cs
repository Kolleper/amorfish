using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WpfApp1.Common;

namespace WpfApp1.Models
{
    [Serializable]
    class Employee : ModelBase
    {
        #region Fields
        private string _Lastname;
        private string _Firstname;
        private int _IdEmployee;
        private string _Birthday;
        private string _Otchestvo;
        private string _NumberOfPhone;
        private string _Gender;
        private string _HomeAdress;
        #endregion

        #region Properties
        /// <summary> 
        /// Technical ID 
        /// </summary> 
        [Key]
        public int IdEmployee
        {
            get { return _IdEmployee; }
            set
            {
                _IdEmployee = value;
                OnPropertyChanged();
            }
        }

        /// <summary> 
        /// Firsname of employee 
        /// </summary> 
        public string Firstname
        {
            get { return _Firstname; }
            set
            {
                _Firstname = value;
                OnPropertyChanged();
            }
        }

        /// <summary> 
        /// Lastname of employee 
        /// </summary> 
        public string Lastname
        {
            get { return _Lastname; }
            set
            {
                _Lastname = value;
                OnPropertyChanged();
            }
        }

        /// <summary> 
        /// Date of birth
        /// </summary> 
        public string Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                OnPropertyChanged();
            }
        }
        /// <summary> 
        /// Otchestvo of employee
        /// </summary> 
        public string Otchestvo
        {
            get { return _Otchestvo; }
            set
            {
                _Otchestvo = value;
                OnPropertyChanged();
            }
        }
        /// <summary> 
        /// Phone number of employee
        /// </summary> 
        public string NumberOfPhone
        {
            get { return _NumberOfPhone; }
            set
            {
                _NumberOfPhone = value;
                OnPropertyChanged();
            }
        }
        /// <summary> 
        /// Gender of employee
        /// </summary> 
        public string Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
                OnPropertyChanged();
            }
        }
        /// <summary> 
        /// Home adress of employee
        /// </summary> 
        public string HomeAdress
        {
            get { return _HomeAdress; }
            set
            {
                _HomeAdress = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region NotMapped

        private DateTime _DayOfBirth;
        /// <summary> 
        /// Property 
        /// </summary> 
        /// 
        [NotMapped]
        public DateTime DayOfBirth
        {
            get { return Convert.ToDateTime(Birthday); }
            set
            {
                Birthday = value.ToShortDateString();
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
