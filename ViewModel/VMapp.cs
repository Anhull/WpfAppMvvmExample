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
                    IsEmpEdEnabled = true;
                    EdtYear = SelectEmployee.DateOfBirth.Year;
                    EdtMonth = SelectEmployee.DateOfBirth.Month;
                    EdtDay = SelectEmployee.DateOfBirth.Day;
                    EdtMName = SelectEmployee.EmpMName;
                    EdtName = SelectEmployee.EmpName;
                    EdtSName = SelectEmployee.EmpSName;
                    EdtDep = SelectEmployee.InDep;
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
                    IsEmpEdEnabled = false;
                    EdtYear = null;
                    EdtMonth = null;
                    EdtDay = null;
                    EdtMName = String.Empty;
                    EdtName = String.Empty;
                    EdtSName = String.Empty;
                    try
                    {
                        EdtDep = 0;
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
                    IsDepEdEnabled = true;
                    EdtDepName = SelectDepartment.DepName;
                    EdtEmpChief = SelectDepartment.EmpChief;
                }
                else
                {
                    IsDepEdEnabled = false;
                    EdtDepName = String.Empty;
                    EdtEmpChief = 0;
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
                    IsOrdEdEnabled = true;
                    EdtNameOfGood = SelectOrder.Good;
                    EdtOrdEmp = SelectOrder.Emp;
                }
                else
                {
                    IsOrdEdEnabled = false;
                    EdtNameOfGood = String.Empty;
                    EdtOrdEmp = 0;
                }
            }
        }
        //---------------
        //Вводимые данные
        //---------------
        //Employes-------
        //---------------
        private string _insName;
        public string InsName
        {
            get { return _insName; }
            set
            {
                _insName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insSName;
        public string InsSName
        {
            get { return _insSName; }
            set
            {
                _insSName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _insMName;
        public string InsMName
        {
            get { return _insMName; }
            set
            {
                _insMName = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insDay;
        public Nullable<int> InsDay
        {
            get { return _insDay; }
            set
            {
                _insDay = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insMonth;
        public Nullable<int> InsMonth
        {
            get { return _insMonth; }
            set
            {
                _insMonth = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _insYear;
        public Nullable<int> InsYear
        {
            get { return _insYear; }
            set
            {
                _insYear = value;
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
        private int _insDep;
        public int InsDep
        {
            get { return _insDep; }
            set
            {
                _insDep = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Department---------
        //-------------------
        private int _insEmpChief;
        public int InsEmpChief
        {
            get { return _insEmpChief; }
            set
            {
                _insEmpChief = value;
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
        private int _insOrdEmp;
        public int InsOrdEmp
        {
            get { return _insOrdEmp; }
            set
            {
                _insOrdEmp = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _nameOfGood;
        public string NameOfGood
        {
            get { return _nameOfGood; }
            set
            {
                _nameOfGood = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Редактируемые данные
        //-------------------
        //Employes-----------
        //-------------------
        private string _edtName;
        public string EdtName
        {
            get { return _edtName; }
            set
            {
                _edtName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtSName;
        public string EdtSName
        {
            get { return _edtSName; }
            set
            {
                _edtSName = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtMName;
        public string EdtMName
        {
            get { return _edtMName; }
            set
            {
                _edtMName = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtDay;
        public Nullable<int> EdtDay
        {
            get { return _edtDay; }
            set
            {
                _edtDay = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtMonth;
        public Nullable<int> EdtMonth
        {
            get { return _edtMonth; }
            set
            {
                _edtMonth = value;
                RaisePropertyChangedEvent();
            }
        }
        private Nullable<int> _edtYear;
        public Nullable<int> EdtYear
        {
            get { return _edtYear; }
            set
            {
                _edtYear = value;
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
        private int _edtDep;
        public int EdtDep
        {
            get { return _edtDep; }
            set
            {
                _edtDep = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _IsEmpEdEnabled;
        public bool IsEmpEdEnabled
        {
            get { return _IsEmpEdEnabled; }
            set
            {
                _IsEmpEdEnabled = value;
                RaisePropertyChangedEvent();
            }
        }
        //-------------------
        //Department---------
        //-------------------
        private int _edtEmpChief;
        public int EdtEmpChief
        {
            get { return _edtEmpChief; }
            set
            {
                _edtEmpChief = value;
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
        private bool _IsDepEdEnabled;
        public bool IsDepEdEnabled
        {
            get { return _IsDepEdEnabled; }
            set
            {
                _IsDepEdEnabled = value;
                RaisePropertyChangedEvent();
            }
        }
        //-----
        //Order
        //-----
        private int _edtOrdEmp;
        public int EdtOrdEmp
        {
            get { return _edtOrdEmp; }
            set
            {
                _edtOrdEmp = value;
                RaisePropertyChangedEvent();
            }
        }
        private string _edtNameOfGood;
        public string EdtNameOfGood
        {
            get { return _edtNameOfGood; }
            set
            {
                _edtNameOfGood = value;
                RaisePropertyChangedEvent();
            }
        }
        private bool _IsOrdEdEnabled;
        public bool IsOrdEdEnabled
        {
            get { return _IsOrdEdEnabled; }
            set
            {
                _IsOrdEdEnabled = value;
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
            InsYear = null;
            InsMonth = null;
            InsDay = null;
            InsMName = String.Empty;
            InsName = String.Empty;
            InsSName = String.Empty;
            InsDepName = String.Empty;
            NameOfGood = String.Empty;
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
            EmpSexInsMale = true;
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
                if (InsName != null && ( 0 < InsDay ) && (InsDay <= 31) && (0 < InsMonth) && (InsMonth <= 12) && (0 < InsYear) && (InsYear <= 9999))
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            if (EmpSexInsMale == true)
                            {
                                db.Employes.Add(new Employee() { EmpName = InsName, EmpSName = InsSName, EmpMName = InsMName, DateOfBirth = new DateTime((int)InsYear, (int)InsMonth, (int)InsDay), SexValue = Employee.ChooseOfSex.Male, InDep = InsDep });
                            }
                            else
                            {
                                db.Employes.Add(new Employee() { EmpName = InsName, EmpSName = InsSName, EmpMName = InsMName, DateOfBirth = new DateTime((int)InsYear, (int)InsMonth, (int)InsDay), SexValue = Employee.ChooseOfSex.Fermale, InDep = InsDep });
                            }
                            db.SaveChanges();
                            OfEmployes.Clear();
                            db.Employes.ToList().ForEach(x => OfEmployes.Add(x));
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
        public DelegateCommand AddDepCommand => addDepCommand ??
            (addDepCommand = new DelegateCommand(() =>
            {
                if (InsDepName != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Add(new Department() { DepName = InsDepName, EmpChief = InsEmpChief });
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
                if (NameOfGood != null)
                {
                    try
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Add(new Order() { Good = NameOfGood, Emp = InsOrdEmp });
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
                            emp.EmpName = EdtName;
                            emp.EmpMName = EdtMName;
                            emp.EmpSName = EdtSName;
                            emp.DateOfBirth = new DateTime((int)EdtYear, (int)EdtMonth, (int)EdtDay);
                            if (EmpSexEdtMale == true)
                            {
                                emp.SexValue = Employee.ChooseOfSex.Male;
                            }
                            else
                            {
                                emp.SexValue = Employee.ChooseOfSex.Fermale;
                            }
                            emp.InDep = EdtDep;
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
                else
                {
                    Console.WriteLine("Не выбран работник!");
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
                            emp.EmpChief = EdtEmpChief;
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
                else
                {
                    Console.WriteLine("Не выбрано подразделение!");
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
                            emp.Good = EdtNameOfGood;
                            emp.Emp = EdtOrdEmp;
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
                else
                {
                    Console.WriteLine("Не выбран заказ!");
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
                else
                {
                    Console.WriteLine("Вы ничего не выбрали!");
                }
            }));
    }
}
