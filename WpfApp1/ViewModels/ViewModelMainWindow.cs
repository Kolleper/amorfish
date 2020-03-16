using WpfApp1.Common;
using WpfApp1.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WpfApp1.ViewModels
{
    class ViewModelMainWindow : ModelBase
    {
        private Employee _ActEmployee;

        private bool _EmployeeExist;
        /// <summary> 
        /// Property 
        /// </summary> 
        public bool EmployeeExist
        {
            get { return _EmployeeExist; }
            set
            {
                _EmployeeExist = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Employee> _Employees;
        /// <summary> 
        /// Property 
        /// </summary> 
        public ObservableCollection<Employee> Employees
        {
            get { return _Employees; }
            set
            {
                _Employees = value;
                OnPropertyChanged();
            }
        }
        //public ViewModelMainWindow()
        //{
        //    Update();
        //}

        /// <summary> 
        /// Property 
        /// </summary> 
        public Employee ActEmployee
        {
            get { return _ActEmployee; }
            set
            {
                _ActEmployee = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get { return new RelayCommand(Add); } }
        public ICommand UpdateCommand { get { return new RelayCommand(Update); } }
        public ICommand SaveCommand { get { return new RelayCommand(Save); } }
        public ICommand DeleteCommand { get { return new RelayCommand(Delete, () => EmployeeExist); } }


        //private void Update()
        //{
        //    DbManager = new Datamanager();
        //    DbManager.Emlployees.Load();

        //    Employees = DbManager.Emlployees.Local;
        //    EmployeeExist = Employees.Count > 0;

        //    ActEmployee = Employees.FirstOrDefault();
        //}

        //private void Save()
        //{
        //    DbManager.SaveChanges();
        //}
        private void Update()
        {
            if (File.Exists("employees.db"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("employees.db", FileMode.Open);
                Employees = (ObservableCollection<Employee>)formatter.Deserialize(fs);
                fs.Close();
            }
            else
            {
                Employees = new ObservableCollection<Employee>();
            }
            EmployeeExist = Employees.Count > 0;
            ActEmployee = Employees.FirstOrDefault();
        }
        private void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("employees.db", FileMode.OpenOrCreate);
            formatter.Serialize(fs, Employees);
            fs.Close();
        }

        private void Delete()
        {
            if (ActEmployee != null)
            {
                Employees.Remove(ActEmployee);
                EmployeeExist = Employees.Count > 0;
                ActEmployee = Employees.FirstOrDefault();
            }
        }

        private void Add()
        {
            Employees.Add(new Employee() { DayOfBirth = DateTime.Now.Date });
            ActEmployee = Employees.LastOrDefault();
            EmployeeExist = Employees.Count > 0;
        }
    }
}
