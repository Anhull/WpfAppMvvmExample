using System;
using System.Collections.ObjectModel;
using System.Linq;
using WpfAppMvvm.Model;

namespace WpfAppMvvm.ViewModel 
{
    public class VMapp : ObservableObject
    {
        //Коллекция DataGrid для Сотрудников
        private ObservableCollection<Employee> _ofemployes;
        public ObservableCollection<Employee> OfEmployes
        {
            get { return _ofemployes; }
            set
            {
                _ofemployes = value;
                RaisePropertyChangedEvent();
            }
        }
        //Коллекция DataGrid для Подразделений
        private ObservableCollection<Department> _ofdepartments;
        public ObservableCollection<Department> OfDepartments
        {
            get { return _ofdepartments; }
            set
            {
                _ofdepartments = value;
                RaisePropertyChangedEvent();
            }
        }
        //Коллекция DataGrid для Заказов
        private ObservableCollection<Order> _oforders;
        public ObservableCollection<Order> OfOrders
        {
            get { return _oforders; }
            set
            {
                _oforders = value;
                RaisePropertyChangedEvent();
            }
        }
        //Выбранный сотрудник
        private Employee _selectEmployee;
        public Employee SelectEmployee
        {
            get { return _selectEmployee; }
            set
            {
                _selectEmployee = value;
                RaisePropertyChangedEvent();
                _selectDepartment = null;
                _selectOrder = null;
                if (SelectEmployee != null)
                {
                    IsEmpEditEnabled = true;
                    EdtEmpYear = SelectEmployee.DateOfBirth.Year;
                    EdtEmpMonth = SelectEmployee.DateOfBirth.Month;
                    EdtEmpDay = SelectEmployee.DateOfBirth.Day;
                    EdtEmpMName = SelectEmployee.EmpMName;
                    EdtEmpName = SelectEmployee.EmpName;
                    EdtEmpSName = SelectEmployee.EmpSName;
                    EdtEmpDep = SelectEmployee.EmpInDep;
                    if (SelectEmployee.SexValue == Employee.ChooseOfSex.Male)
                    {
                        EmpSexEdtMale = true;
                    }
                    else if (SelectEmployee.SexValue == Employee.ChooseOfSex.Fermale)
                    {
                        EmpSexEdtFemale = true;
                    }
                }
                else
                {
                    IsEmpEditEnabled = false;
                    EdtEmpYear = null;
                    EdtEmpMonth = null;
                    EdtEmpDay = null;
                    EdtEmpMName = String.Empty;
                    EdtEmpName = String.Empty;
                    EdtEmpSName = String.Empty;
                    try
                    {
                        EdtEmpDep = 0;
                    }
                    catch { }
                    EmpSexEdtMale = true;
                }
            }
        }
        //Выбранное подразделение
        private Department _selectDepartment;
        public Department SelectDepartment
        {
            get { return _selectDepartment; }
            set
            {
                _selectDepartment = value;
                RaisePropertyChangedEvent();
                _selectEmployee = null;
                _selectOrder = null;
                if (SelectDepartment != null)
                {
                    IsDepEditEnabled = true;
                    EdtDepName = SelectDepartment.DepName;
                    EdtDepEmpChief = SelectDepartment.DepEmpChief;
                }
                else
                {
                    IsDepEditEnabled = false;
                    EdtDepName = String.Empty;
                    EdtDepEmpChief = 0;
                }
            }
        }
        //Выбранный заказ
        private Order _selectOrder;
        public Order SelectOrder
        {
            get { return _selectOrder; }
            set
            {
                _selectOrder = value;
                RaisePropertyChangedEvent();
                _selectDepartment = null;
                _selectEmployee = null;
                if (SelectOrder != null)
                {
                    IsOrdEditEnabled = true;
                    EdtOrdGood = SelectOrder.OrdGood;
                    EdtOrdEmp = SelectOrder.OrdEmp;
                }
                else
                {
                    IsOrdEditEnabled = false;
                    EdtOrdGood = String.Empty;
                    EdtOrdEmp = 0;
                }
            }
        }
        //---------------
        //Вводимые данные
        //---------------
        //Employes-------
        //---------------
        private string _insEmpName;
        public string InsEmpName
        {
            get { return _insEmpName; }
            set
            {
                _insEmpName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insEmpSName;
        public string InsEmpSName
        {
            get { return _insEmpSName; }
            set
            {
                _insEmpSName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insEmpMName;
        public string InsEmpMName
        {
            get { return _insEmpMName; }
            set
            {
                _insEmpMName = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insEmpDay;
        public Nullable<int> InsEmpDay
        {
            get { return _insEmpDay; }
            set
            {
                _insEmpDay = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insEmpMonth;
        public Nullable<int> InsEmpMonth
        {
            get { return _insEmpMonth; }
            set
            {
                _insEmpMonth = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insEmpYear;
        public Nullable<int> InsEmpYear
        {
            get { return _insEmpYear; }
            set
            {
                _insEmpYear = value;
                RaisePropertyChangedEvent();
            }
        }     
        private bool _empSexInsMale;
        public bool EmpSexInsMale
        {
            get { return _empSexInsMale; }
            set
            {
                _empSexInsMale = value;
                RaisePropertyChangedEvent();
                if(EmpSexInsMale == true)
                {
                    EmpSexInsFemale = false;
                }
            }
        }
        private bool _empSexInsFemale;
        public bool EmpSexInsFemale
        {
            get { return _empSexInsFemale; }
            set
            {
                _empSexInsFemale = value;
                RaisePropertyChangedEvent();
                if (EmpSexInsFemale == true)
                {
                    EmpSexInsMale = false;
                }
            }
        }
        private Nullable<int> _insEmpDep;
        public Nullable<int> InsEmpDep
        {
            get { return _insEmpDep; }
            set
            {
                _insEmpDep = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Department---------
        //-------------------
        private Nullable<int> _insDepEmpChief;
        public Nullable<int> InsDepEmpChief
        {
            get { return _insDepEmpChief; }
            set
            {
                _insDepEmpChief = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insDepName;
        public string InsDepName
        {
            get { return _insDepName; }
            set
            {
                _insDepName = value;
                RaisePropertyChangedEvent();
            }
        }
        //------
        //Order
        //------
        private Nullable<int> _insOrdEmp;
        public Nullable<int> InsOrdEmp
        {
            get { return _insOrdEmp; }
            set
            {
                _insOrdEmp = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insOrdGood;
        public string InsOrdGood
        {
            get { return _insOrdGood; }
            set
            {
                _insOrdGood = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Редактируемые данные
        //-------------------
        //Employes-----------
        //-------------------
        private string _edtEmpName;
        public string EdtEmpName
        {
            get { return _edtEmpName; }
            set
            {
                _edtEmpName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtEmpSName;
        public string EdtEmpSName
        {
            get { return _edtEmpSName; }
            set
            {
                _edtEmpSName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtEmpMName;
        public string EdtEmpMName
        {
            get { return _edtEmpMName; }
            set
            {
                _edtEmpMName = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtEmpDay;
        public Nullable<int> EdtEmpDay
        {
            get { return _edtEmpDay; }
            set
            {
                _edtEmpDay = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtEmpMonth;
        public Nullable<int> EdtEmpMonth
        {
            get { return _edtEmpMonth; }
            set
            {
                _edtEmpMonth = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtEmpYear;
        public Nullable<int> EdtEmpYear
        {
            get { return _edtEmpYear; }
            set
            {
                _edtEmpYear = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _empSexEdtMale;
        public bool EmpSexEdtMale
        {
            get { return _empSexEdtMale; }
            set
            {
                _empSexEdtMale = value;
                RaisePropertyChangedEvent();
                if (EmpSexEdtMale == true)
                {
                    EmpSexEdtFemale = false;
                }
            }
        }
        private bool _empSexEdtFemale;
        public bool EmpSexEdtFemale
        {
            get { return _empSexEdtFemale; }
            set
            {
                _empSexEdtFemale = value;
                RaisePropertyChangedEvent();
                if (EmpSexEdtFemale == true)
                {
                    EmpSexEdtMale = false;
                }
            }
        }
        private Nullable<int> _edtEmpDep;
        public Nullable<int> EdtEmpDep
        {
            get { return _edtEmpDep; }
            set
            {
                _edtEmpDep = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _IsEmpEditEnabled;
        public bool IsEmpEditEnabled
        {
            get { return _IsEmpEditEnabled; }
            set
            {
                _IsEmpEditEnabled = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Department---------
        //-------------------
        private Nullable<int> _edtDepEmpChief;
        public Nullable<int> EdtDepEmpChief
        {
            get { return _edtDepEmpChief; }
            set
            {
                _edtDepEmpChief = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtDepName;
        public string EdtDepName
        {
            get { return _edtDepName; }
            set
            {
                _edtDepName = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _IsDepEditEnabled;
        public bool IsDepEditEnabled
        {
            get { return _IsDepEditEnabled; }
            set
            {
                _IsDepEditEnabled = value;
                RaisePropertyChangedEvent();
            }
        }
        //-----
        //Order
        //-----
        private Nullable<int> _edtOrdEmp;
        public Nullable<int> EdtOrdEmp
        {
            get { return _edtOrdEmp; }
            set
            {
                _edtOrdEmp = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtOrdGood;
        public string EdtOrdGood
        {
            get { return _edtOrdGood; }
            set
            {
                _edtOrdGood = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _IsOrdEditEnabled;
        public bool IsOrdEditEnabled
        {
            get { return _IsOrdEditEnabled; }
            set
            {
                _IsOrdEditEnabled = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Заполнение DataGrid
        //-------------------
        public void FillDataGrid()
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Employes.ToList().ForEach(x => OfEmployes.Add(x));
                    db.Departments.ToList().ForEach(x => OfDepartments.Add(x));
                    db.Orders.ToList().ForEach(x => OfOrders.Add(x));
                }
            }
            catch { }
        }
        //очистка вводимой информации
        public void ClearAdder()
        {
            InsDepEmpChief = 0;
            InsEmpDep = 0;
            InsOrdEmp = 0;
            InsEmpYear = null;
            InsEmpMonth = null;
            InsEmpDay = null;
            InsEmpMName = null;
            InsEmpName = null;
            InsEmpSName = null;
            InsDepName = null;
            InsOrdGood = null;
        }
        //Конструктор класса
        public VMapp()
        {
            OfEmployes = new ObservableCollection<Employee>();
            OfDepartments = new ObservableCollection<Department>();
            OfOrders = new ObservableCollection<Order>();
            OfEmployes.CollectionChanged += delegate{ RaisePropertyChangedEvent(); };
            OfDepartments.CollectionChanged += delegate { RaisePropertyChangedEvent(); };
            OfOrders.CollectionChanged += delegate { RaisePropertyChangedEvent(); };
            ClearAdder();
            FillDataGrid();
        }

        DelegateCommand addEmpCommand;
        DelegateCommand addDepCommand;
        DelegateCommand addOrdCommand;
        
        DelegateCommand editEmpCommand;
        DelegateCommand editDepCommand;
        DelegateCommand editOrdCommand;

        DelegateCommand delCommand;
        //Комманды добавления
        public DelegateCommand AddEmpCommand => addEmpCommand ??
            (addEmpCommand = new DelegateCommand(() =>
            {
                if (InsEmpName != null && ( 0 < InsEmpDay ) && (InsEmpDay <= 31) && (0 < InsEmpMonth) && (InsEmpMonth <= 12) && (0 < InsEmpYear) && (InsEmpYear <= 9999))
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            if (EmpSexInsMale == true)
                            {
                                db.Employes.Add(new Employee() { EmpName = InsEmpName, EmpSName = InsEmpSName, EmpMName = InsEmpMName, DateOfBirth = new DateTime((int)InsEmpYear, (int)InsEmpMonth, (int)InsEmpDay), SexValue = Employee.ChooseOfSex.Male, EmpInDep = (int)InsEmpDep });
                            }
                            else
                            {
                                db.Employes.Add(new Employee() { EmpName = InsEmpName, EmpSName = InsEmpSName, EmpMName = InsEmpMName, DateOfBirth = new DateTime((int)InsEmpYear, (int)InsEmpMonth, (int)InsEmpDay), SexValue = Employee.ChooseOfSex.Fermale, EmpInDep = (int)InsEmpDep });
                            }
                            db.SaveChanges();
                            OfEmployes.Clear();
                            db.Employes.ToList().ForEach(x => OfEmployes.Add(x));
                            ClearAdder();
                        }
                    }
                    catch(Exception ex) 
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    Console.WriteLine("Неверно указаны данные!");
                }
            }));
        public DelegateCommand AddDepCommand => addDepCommand ??
            (addDepCommand = new DelegateCommand(() =>
            {
                if (InsDepName != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Add(new Department() { DepName = InsDepName, DepEmpChief = (int)InsDepEmpChief });
                            db.SaveChanges();
                            OfDepartments.Clear();
                            db.Departments.ToList().ForEach(x => OfDepartments.Add(x));
                            ClearAdder();
                        }
                    }
                    catch { }
                }
                else
                {
                    Console.WriteLine("Неверно указаны данные!");
                }
            }));
        public DelegateCommand AddOrdCommand => addOrdCommand ??
            (addOrdCommand = new DelegateCommand(() =>
            {
                if (InsOrdGood != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Add(new Order() { OrdGood = InsOrdGood, OrdEmp = (int)InsOrdEmp });
                            db.SaveChanges();
                            OfOrders.Clear();
                            db.Orders.ToList().ForEach(x => OfOrders.Add(x));
                            ClearAdder();
                        }
                    }
                    catch { }
                }
                else
                {
                    Console.WriteLine("Неверно указаны данные!");
                }
            }));
        //Команды редактирования
        public DelegateCommand EditEmpCommand => editEmpCommand ??
            (editEmpCommand = new DelegateCommand(() =>
            {
                if (SelectEmployee != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var emp = db.Employes.Where(c => c.Id == SelectEmployee.Id).FirstOrDefault();
                            emp.EmpName = EdtEmpName;
                            emp.EmpMName = EdtEmpMName;
                            emp.EmpSName = EdtEmpSName;
                            emp.DateOfBirth = new DateTime((int)EdtEmpYear, (int)EdtEmpMonth, (int)EdtEmpDay);
                            if (EmpSexEdtMale == true)
                            {
                                emp.SexValue = Employee.ChooseOfSex.Male;
                            }
                            else
                            {
                                emp.SexValue = Employee.ChooseOfSex.Fermale;
                            }
                            emp.EmpInDep = (int)EdtEmpDep;
                            db.SaveChanges();
                            OfEmployes.Clear();
                            db.Employes.ToList().ForEach(x => OfEmployes.Add(x));
                        }
                    }
                    catch(Exception ex) 
                    {
                        Console.WriteLine(ex);
                    }
                }
            }));
        public DelegateCommand EditDepCommand => editDepCommand ??
            (editDepCommand = new DelegateCommand(() =>
            {
                if (SelectDepartment != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var emp = db.Departments.Where(c => c.DepartmentId == SelectDepartment.DepartmentId).FirstOrDefault();
                            emp.DepName = EdtDepName;
                            emp.DepEmpChief = (int)EdtDepEmpChief;
                            db.SaveChanges();
                            OfDepartments.Clear();
                            db.Departments.ToList().ForEach(x => OfDepartments.Add(x));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }));
        public DelegateCommand EditOrdCommand => editOrdCommand ??
            (editOrdCommand = new DelegateCommand(() =>
            {
                if (SelectOrder != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var emp = db.Orders.Where(c => c.OrderId == SelectOrder.OrderId).FirstOrDefault();
                            emp.OrdGood = EdtOrdGood;
                            emp.OrdEmp = (int)EdtOrdEmp;
                            db.SaveChanges();
                            OfOrders.Clear();
                            db.Orders.ToList().ForEach(x => OfOrders.Add(x));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }));
        //Команда удаления
        public DelegateCommand DelCommand => delCommand ??
            (delCommand = new DelegateCommand(() =>
            {
                if (SelectEmployee != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Employes.Remove(SelectEmployee);
                            db.SaveChanges();
                            OfEmployes.Clear();
                            db.Employes.ToList().ForEach(x => OfEmployes.Add(x));

                        }
                    }
                    catch { }
                }
                else if (SelectDepartment != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Departments.Remove(SelectDepartment);
                            db.SaveChanges();
                            OfDepartments.Clear();
                            db.Departments.ToList().ForEach(x => OfDepartments.Add(x));

                        }
                    }
                    catch { }
                }
                else if (SelectOrder != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Orders.Remove(SelectOrder);
                            db.SaveChanges();
                            OfOrders.Clear();
                            db.Orders.ToList().ForEach(x => OfOrders.Add(x));

                        }
                    }
                    catch { }
                }
            }));
    }
}
