using WpfApp1.Common;
using WpfApp1.Database;
using WpfApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    class ViewModelMainWindow : ModelBase
    {
        //public Datamanager DbManager { get; set; }
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
        //public ICommand UpdateCommand { get { return new RelayCommand(Update); } }
        //public ICommand SaveCommand { get { return new RelayCommand(Save, DbManager.ChangeTracker.HasChanges); } }
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

            //var hc = DbManager.ChangeTracker.HasChanges();
        }
    }
}
