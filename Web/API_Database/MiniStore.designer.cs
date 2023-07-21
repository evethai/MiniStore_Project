﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MiniStore")]
	public partial class MiniStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertWorkSheet(WorkSheet instance);
    partial void UpdateWorkSheet(WorkSheet instance);
    partial void DeleteWorkSheet(WorkSheet instance);
    partial void InsertSheetDetail(SheetDetail instance);
    partial void UpdateSheetDetail(SheetDetail instance);
    partial void DeleteSheetDetail(SheetDetail instance);
    partial void InsertSalary(Salary instance);
    partial void UpdateSalary(Salary instance);
    partial void DeleteSalary(Salary instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public MiniStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<WorkSheet> WorkSheets
		{
			get
			{
				return this.GetTable<WorkSheet>();
			}
		}
		
		public System.Data.Linq.Table<SheetDetail> SheetDetails
		{
			get
			{
				return this.GetTable<SheetDetail>();
			}
		}
		
		public System.Data.Linq.Table<Salary> Salaries
		{
			get
			{
				return this.GetTable<Salary>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkSheet")]
	public partial class WorkSheet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdWorkSheet;
		
		private string _IdEmp;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<int> _Sheet;
		
		private System.Nullable<System.DateTime> _TimeCheckIn;
		
		private System.Nullable<System.DateTime> _TimeCheckOut;
		
		private System.Nullable<bool> _Status;
		
		private System.Nullable<System.TimeSpan> _Total_working_hours;
		
		private System.Nullable<double> _default_coefficient;
		
		private System.Nullable<double> _sunday_coefficient;
		
		private EntityRef<SheetDetail> _SheetDetail;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdWorkSheetChanging(string value);
    partial void OnIdWorkSheetChanged();
    partial void OnIdEmpChanging(string value);
    partial void OnIdEmpChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnSheetChanging(System.Nullable<int> value);
    partial void OnSheetChanged();
    partial void OnTimeCheckInChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeCheckInChanged();
    partial void OnTimeCheckOutChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeCheckOutChanged();
    partial void OnStatusChanging(System.Nullable<bool> value);
    partial void OnStatusChanged();
    partial void OnTotal_working_hoursChanging(System.Nullable<System.TimeSpan> value);
    partial void OnTotal_working_hoursChanged();
    partial void Ondefault_coefficientChanging(System.Nullable<double> value);
    partial void Ondefault_coefficientChanged();
    partial void Onsunday_coefficientChanging(System.Nullable<double> value);
    partial void Onsunday_coefficientChanged();
    #endregion
		
		public WorkSheet()
		{
			this._SheetDetail = default(EntityRef<SheetDetail>);
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdWorkSheet", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdWorkSheet
		{
			get
			{
				return this._IdWorkSheet;
			}
			set
			{
				if ((this._IdWorkSheet != value))
				{
					this.OnIdWorkSheetChanging(value);
					this.SendPropertyChanging();
					this._IdWorkSheet = value;
					this.SendPropertyChanged("IdWorkSheet");
					this.OnIdWorkSheetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmp", DbType="NVarChar(20)")]
		public string IdEmp
		{
			get
			{
				return this._IdEmp;
			}
			set
			{
				if ((this._IdEmp != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdEmpChanging(value);
					this.SendPropertyChanging();
					this._IdEmp = value;
					this.SendPropertyChanged("IdEmp");
					this.OnIdEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sheet", DbType="Int")]
		public System.Nullable<int> Sheet
		{
			get
			{
				return this._Sheet;
			}
			set
			{
				if ((this._Sheet != value))
				{
					if (this._SheetDetail.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSheetChanging(value);
					this.SendPropertyChanging();
					this._Sheet = value;
					this.SendPropertyChanged("Sheet");
					this.OnSheetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeCheckIn", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeCheckIn
		{
			get
			{
				return this._TimeCheckIn;
			}
			set
			{
				if ((this._TimeCheckIn != value))
				{
					this.OnTimeCheckInChanging(value);
					this.SendPropertyChanging();
					this._TimeCheckIn = value;
					this.SendPropertyChanged("TimeCheckIn");
					this.OnTimeCheckInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeCheckOut", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeCheckOut
		{
			get
			{
				return this._TimeCheckOut;
			}
			set
			{
				if ((this._TimeCheckOut != value))
				{
					this.OnTimeCheckOutChanging(value);
					this.SendPropertyChanging();
					this._TimeCheckOut = value;
					this.SendPropertyChanged("TimeCheckOut");
					this.OnTimeCheckOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit")]
		public System.Nullable<bool> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_working_hours", DbType="Time")]
		public System.Nullable<System.TimeSpan> Total_working_hours
		{
			get
			{
				return this._Total_working_hours;
			}
			set
			{
				if ((this._Total_working_hours != value))
				{
					this.OnTotal_working_hoursChanging(value);
					this.SendPropertyChanging();
					this._Total_working_hours = value;
					this.SendPropertyChanged("Total_working_hours");
					this.OnTotal_working_hoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_default_coefficient", DbType="Float")]
		public System.Nullable<double> default_coefficient
		{
			get
			{
				return this._default_coefficient;
			}
			set
			{
				if ((this._default_coefficient != value))
				{
					this.Ondefault_coefficientChanging(value);
					this.SendPropertyChanging();
					this._default_coefficient = value;
					this.SendPropertyChanged("default_coefficient");
					this.Ondefault_coefficientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sunday_coefficient", DbType="Float")]
		public System.Nullable<double> sunday_coefficient
		{
			get
			{
				return this._sunday_coefficient;
			}
			set
			{
				if ((this._sunday_coefficient != value))
				{
					this.Onsunday_coefficientChanging(value);
					this.SendPropertyChanging();
					this._sunday_coefficient = value;
					this.SendPropertyChanged("sunday_coefficient");
					this.Onsunday_coefficientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SheetDetail_WorkSheet", Storage="_SheetDetail", ThisKey="Sheet", OtherKey="Sheet", IsForeignKey=true)]
		public SheetDetail SheetDetail
		{
			get
			{
				return this._SheetDetail.Entity;
			}
			set
			{
				SheetDetail previousValue = this._SheetDetail.Entity;
				if (((previousValue != value) 
							|| (this._SheetDetail.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SheetDetail.Entity = null;
						previousValue.WorkSheets.Remove(this);
					}
					this._SheetDetail.Entity = value;
					if ((value != null))
					{
						value.WorkSheets.Add(this);
						this._Sheet = value.Sheet;
					}
					else
					{
						this._Sheet = default(Nullable<int>);
					}
					this.SendPropertyChanged("SheetDetail");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_WorkSheet", Storage="_Employee", ThisKey="IdEmp", OtherKey="IdEmp", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.WorkSheets.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.WorkSheets.Add(this);
						this._IdEmp = value.IdEmp;
					}
					else
					{
						this._IdEmp = default(string);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SheetDetail")]
	public partial class SheetDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Sheet;
		
		private System.Nullable<double> _CoefficientsSalary;
		
		private System.Nullable<System.TimeSpan> _ShiftStartTime;
		
		private System.Nullable<System.TimeSpan> _ShiftEndTime;
		
		private System.Nullable<int> _Roles;
		
		private System.Nullable<bool> _CheckNight;
		
		private EntitySet<WorkSheet> _WorkSheets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSheetChanging(int value);
    partial void OnSheetChanged();
    partial void OnCoefficientsSalaryChanging(System.Nullable<double> value);
    partial void OnCoefficientsSalaryChanged();
    partial void OnShiftStartTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnShiftStartTimeChanged();
    partial void OnShiftEndTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnShiftEndTimeChanged();
    partial void OnRolesChanging(System.Nullable<int> value);
    partial void OnRolesChanged();
    partial void OnCheckNightChanging(System.Nullable<bool> value);
    partial void OnCheckNightChanged();
    #endregion
		
		public SheetDetail()
		{
			this._WorkSheets = new EntitySet<WorkSheet>(new Action<WorkSheet>(this.attach_WorkSheets), new Action<WorkSheet>(this.detach_WorkSheets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sheet", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Sheet
		{
			get
			{
				return this._Sheet;
			}
			set
			{
				if ((this._Sheet != value))
				{
					this.OnSheetChanging(value);
					this.SendPropertyChanging();
					this._Sheet = value;
					this.SendPropertyChanged("Sheet");
					this.OnSheetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoefficientsSalary", DbType="Float")]
		public System.Nullable<double> CoefficientsSalary
		{
			get
			{
				return this._CoefficientsSalary;
			}
			set
			{
				if ((this._CoefficientsSalary != value))
				{
					this.OnCoefficientsSalaryChanging(value);
					this.SendPropertyChanging();
					this._CoefficientsSalary = value;
					this.SendPropertyChanged("CoefficientsSalary");
					this.OnCoefficientsSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShiftStartTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> ShiftStartTime
		{
			get
			{
				return this._ShiftStartTime;
			}
			set
			{
				if ((this._ShiftStartTime != value))
				{
					this.OnShiftStartTimeChanging(value);
					this.SendPropertyChanging();
					this._ShiftStartTime = value;
					this.SendPropertyChanged("ShiftStartTime");
					this.OnShiftStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShiftEndTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> ShiftEndTime
		{
			get
			{
				return this._ShiftEndTime;
			}
			set
			{
				if ((this._ShiftEndTime != value))
				{
					this.OnShiftEndTimeChanging(value);
					this.SendPropertyChanging();
					this._ShiftEndTime = value;
					this.SendPropertyChanged("ShiftEndTime");
					this.OnShiftEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Roles", DbType="Int")]
		public System.Nullable<int> Roles
		{
			get
			{
				return this._Roles;
			}
			set
			{
				if ((this._Roles != value))
				{
					this.OnRolesChanging(value);
					this.SendPropertyChanging();
					this._Roles = value;
					this.SendPropertyChanged("Roles");
					this.OnRolesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckNight", DbType="Bit")]
		public System.Nullable<bool> CheckNight
		{
			get
			{
				return this._CheckNight;
			}
			set
			{
				if ((this._CheckNight != value))
				{
					this.OnCheckNightChanging(value);
					this.SendPropertyChanging();
					this._CheckNight = value;
					this.SendPropertyChanged("CheckNight");
					this.OnCheckNightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SheetDetail_WorkSheet", Storage="_WorkSheets", ThisKey="Sheet", OtherKey="Sheet")]
		public EntitySet<WorkSheet> WorkSheets
		{
			get
			{
				return this._WorkSheets;
			}
			set
			{
				this._WorkSheets.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_WorkSheets(WorkSheet entity)
		{
			this.SendPropertyChanging();
			entity.SheetDetail = this;
		}
		
		private void detach_WorkSheets(WorkSheet entity)
		{
			this.SendPropertyChanging();
			entity.SheetDetail = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salary")]
	public partial class Salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdSalary;
		
		private string _IdEmp;
		
		private System.Nullable<double> _SalaryByHour;
		
		private System.Nullable<double> _SubSalary;
		
		private double _BasicSalary;
		
		private double _SalaryBeforTax;
		
		private double _Tax;
		
		private System.Nullable<double> _AdvSalary;
		
		private System.Nullable<double> _FinalSalary;
		
		private System.DateTime _DateImonth;
		
		private System.DateTime _DateOmonth;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSalaryChanging(string value);
    partial void OnIdSalaryChanged();
    partial void OnIdEmpChanging(string value);
    partial void OnIdEmpChanged();
    partial void OnSalaryByHourChanging(System.Nullable<double> value);
    partial void OnSalaryByHourChanged();
    partial void OnSubSalaryChanging(System.Nullable<double> value);
    partial void OnSubSalaryChanged();
    partial void OnBasicSalaryChanging(double value);
    partial void OnBasicSalaryChanged();
    partial void OnSalaryBeforTaxChanging(double value);
    partial void OnSalaryBeforTaxChanged();
    partial void OnTaxChanging(double value);
    partial void OnTaxChanged();
    partial void OnAdvSalaryChanging(System.Nullable<double> value);
    partial void OnAdvSalaryChanged();
    partial void OnFinalSalaryChanging(System.Nullable<double> value);
    partial void OnFinalSalaryChanged();
    partial void OnDateImonthChanging(System.DateTime value);
    partial void OnDateImonthChanged();
    partial void OnDateOmonthChanging(System.DateTime value);
    partial void OnDateOmonthChanged();
    #endregion
		
		public Salary()
		{
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSalary", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdSalary
		{
			get
			{
				return this._IdSalary;
			}
			set
			{
				if ((this._IdSalary != value))
				{
					this.OnIdSalaryChanging(value);
					this.SendPropertyChanging();
					this._IdSalary = value;
					this.SendPropertyChanged("IdSalary");
					this.OnIdSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmp", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string IdEmp
		{
			get
			{
				return this._IdEmp;
			}
			set
			{
				if ((this._IdEmp != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdEmpChanging(value);
					this.SendPropertyChanging();
					this._IdEmp = value;
					this.SendPropertyChanged("IdEmp");
					this.OnIdEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalaryByHour", DbType="Float")]
		public System.Nullable<double> SalaryByHour
		{
			get
			{
				return this._SalaryByHour;
			}
			set
			{
				if ((this._SalaryByHour != value))
				{
					this.OnSalaryByHourChanging(value);
					this.SendPropertyChanging();
					this._SalaryByHour = value;
					this.SendPropertyChanged("SalaryByHour");
					this.OnSalaryByHourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubSalary", DbType="Float")]
		public System.Nullable<double> SubSalary
		{
			get
			{
				return this._SubSalary;
			}
			set
			{
				if ((this._SubSalary != value))
				{
					this.OnSubSalaryChanging(value);
					this.SendPropertyChanging();
					this._SubSalary = value;
					this.SendPropertyChanged("SubSalary");
					this.OnSubSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BasicSalary", DbType="Float NOT NULL")]
		public double BasicSalary
		{
			get
			{
				return this._BasicSalary;
			}
			set
			{
				if ((this._BasicSalary != value))
				{
					this.OnBasicSalaryChanging(value);
					this.SendPropertyChanging();
					this._BasicSalary = value;
					this.SendPropertyChanged("BasicSalary");
					this.OnBasicSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalaryBeforTax", DbType="Float NOT NULL")]
		public double SalaryBeforTax
		{
			get
			{
				return this._SalaryBeforTax;
			}
			set
			{
				if ((this._SalaryBeforTax != value))
				{
					this.OnSalaryBeforTaxChanging(value);
					this.SendPropertyChanging();
					this._SalaryBeforTax = value;
					this.SendPropertyChanged("SalaryBeforTax");
					this.OnSalaryBeforTaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tax", DbType="Float NOT NULL")]
		public double Tax
		{
			get
			{
				return this._Tax;
			}
			set
			{
				if ((this._Tax != value))
				{
					this.OnTaxChanging(value);
					this.SendPropertyChanging();
					this._Tax = value;
					this.SendPropertyChanged("Tax");
					this.OnTaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdvSalary", DbType="Float")]
		public System.Nullable<double> AdvSalary
		{
			get
			{
				return this._AdvSalary;
			}
			set
			{
				if ((this._AdvSalary != value))
				{
					this.OnAdvSalaryChanging(value);
					this.SendPropertyChanging();
					this._AdvSalary = value;
					this.SendPropertyChanged("AdvSalary");
					this.OnAdvSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FinalSalary", DbType="Float")]
		public System.Nullable<double> FinalSalary
		{
			get
			{
				return this._FinalSalary;
			}
			set
			{
				if ((this._FinalSalary != value))
				{
					this.OnFinalSalaryChanging(value);
					this.SendPropertyChanging();
					this._FinalSalary = value;
					this.SendPropertyChanged("FinalSalary");
					this.OnFinalSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateImonth", DbType="Date NOT NULL")]
		public System.DateTime DateImonth
		{
			get
			{
				return this._DateImonth;
			}
			set
			{
				if ((this._DateImonth != value))
				{
					this.OnDateImonthChanging(value);
					this.SendPropertyChanging();
					this._DateImonth = value;
					this.SendPropertyChanged("DateImonth");
					this.OnDateImonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOmonth", DbType="Date NOT NULL")]
		public System.DateTime DateOmonth
		{
			get
			{
				return this._DateOmonth;
			}
			set
			{
				if ((this._DateOmonth != value))
				{
					this.OnDateOmonthChanging(value);
					this.SendPropertyChanging();
					this._DateOmonth = value;
					this.SendPropertyChanged("DateOmonth");
					this.OnDateOmonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Salary", Storage="_Employee", ThisKey="IdEmp", OtherKey="IdEmp", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Salaries.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Salaries.Add(this);
						this._IdEmp = value.IdEmp;
					}
					else
					{
						this._IdEmp = default(string);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdEmp;
		
		private string _FullNameEmp;
		
		private System.Nullable<bool> _Sex;
		
		private string _CCCD;
		
		private System.Nullable<System.DateTime> _DoB;
		
		private string _AddressEmp;
		
		private string _PhoneEmp;
		
		private System.Nullable<System.DateTime> _DateJoin;
		
		private string _Username;
		
		private string _Password;
		
		private System.Nullable<int> _Roles;
		
		private System.Nullable<bool> _IsActive;
		
		private string _PictureEmp;
		
		private System.Nullable<int> _SNPT;
		
		private string _Email;
		
		private EntitySet<WorkSheet> _WorkSheets;
		
		private EntitySet<Salary> _Salaries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdEmpChanging(string value);
    partial void OnIdEmpChanged();
    partial void OnFullNameEmpChanging(string value);
    partial void OnFullNameEmpChanged();
    partial void OnSexChanging(System.Nullable<bool> value);
    partial void OnSexChanged();
    partial void OnCCCDChanging(string value);
    partial void OnCCCDChanged();
    partial void OnDoBChanging(System.Nullable<System.DateTime> value);
    partial void OnDoBChanged();
    partial void OnAddressEmpChanging(string value);
    partial void OnAddressEmpChanged();
    partial void OnPhoneEmpChanging(string value);
    partial void OnPhoneEmpChanged();
    partial void OnDateJoinChanging(System.Nullable<System.DateTime> value);
    partial void OnDateJoinChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRolesChanging(System.Nullable<int> value);
    partial void OnRolesChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    partial void OnPictureEmpChanging(string value);
    partial void OnPictureEmpChanged();
    partial void OnSNPTChanging(System.Nullable<int> value);
    partial void OnSNPTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Employee()
		{
			this._WorkSheets = new EntitySet<WorkSheet>(new Action<WorkSheet>(this.attach_WorkSheets), new Action<WorkSheet>(this.detach_WorkSheets));
			this._Salaries = new EntitySet<Salary>(new Action<Salary>(this.attach_Salaries), new Action<Salary>(this.detach_Salaries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmp", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdEmp
		{
			get
			{
				return this._IdEmp;
			}
			set
			{
				if ((this._IdEmp != value))
				{
					this.OnIdEmpChanging(value);
					this.SendPropertyChanging();
					this._IdEmp = value;
					this.SendPropertyChanged("IdEmp");
					this.OnIdEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullNameEmp", DbType="NVarChar(50)")]
		public string FullNameEmp
		{
			get
			{
				return this._FullNameEmp;
			}
			set
			{
				if ((this._FullNameEmp != value))
				{
					this.OnFullNameEmpChanging(value);
					this.SendPropertyChanging();
					this._FullNameEmp = value;
					this.SendPropertyChanged("FullNameEmp");
					this.OnFullNameEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="Bit")]
		public System.Nullable<bool> Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CCCD", DbType="NVarChar(50)")]
		public string CCCD
		{
			get
			{
				return this._CCCD;
			}
			set
			{
				if ((this._CCCD != value))
				{
					this.OnCCCDChanging(value);
					this.SendPropertyChanging();
					this._CCCD = value;
					this.SendPropertyChanged("CCCD");
					this.OnCCCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoB", DbType="Date")]
		public System.Nullable<System.DateTime> DoB
		{
			get
			{
				return this._DoB;
			}
			set
			{
				if ((this._DoB != value))
				{
					this.OnDoBChanging(value);
					this.SendPropertyChanging();
					this._DoB = value;
					this.SendPropertyChanged("DoB");
					this.OnDoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressEmp", DbType="NVarChar(250)")]
		public string AddressEmp
		{
			get
			{
				return this._AddressEmp;
			}
			set
			{
				if ((this._AddressEmp != value))
				{
					this.OnAddressEmpChanging(value);
					this.SendPropertyChanging();
					this._AddressEmp = value;
					this.SendPropertyChanged("AddressEmp");
					this.OnAddressEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneEmp", DbType="NVarChar(15)")]
		public string PhoneEmp
		{
			get
			{
				return this._PhoneEmp;
			}
			set
			{
				if ((this._PhoneEmp != value))
				{
					this.OnPhoneEmpChanging(value);
					this.SendPropertyChanging();
					this._PhoneEmp = value;
					this.SendPropertyChanged("PhoneEmp");
					this.OnPhoneEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateJoin", DbType="Date")]
		public System.Nullable<System.DateTime> DateJoin
		{
			get
			{
				return this._DateJoin;
			}
			set
			{
				if ((this._DateJoin != value))
				{
					this.OnDateJoinChanging(value);
					this.SendPropertyChanging();
					this._DateJoin = value;
					this.SendPropertyChanged("DateJoin");
					this.OnDateJoinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(20)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(20)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Roles", DbType="Int")]
		public System.Nullable<int> Roles
		{
			get
			{
				return this._Roles;
			}
			set
			{
				if ((this._Roles != value))
				{
					this.OnRolesChanging(value);
					this.SendPropertyChanging();
					this._Roles = value;
					this.SendPropertyChanged("Roles");
					this.OnRolesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PictureEmp", DbType="NVarChar(MAX)")]
		public string PictureEmp
		{
			get
			{
				return this._PictureEmp;
			}
			set
			{
				if ((this._PictureEmp != value))
				{
					this.OnPictureEmpChanging(value);
					this.SendPropertyChanging();
					this._PictureEmp = value;
					this.SendPropertyChanged("PictureEmp");
					this.OnPictureEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SNPT", DbType="Int")]
		public System.Nullable<int> SNPT
		{
			get
			{
				return this._SNPT;
			}
			set
			{
				if ((this._SNPT != value))
				{
					this.OnSNPTChanging(value);
					this.SendPropertyChanging();
					this._SNPT = value;
					this.SendPropertyChanged("SNPT");
					this.OnSNPTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_WorkSheet", Storage="_WorkSheets", ThisKey="IdEmp", OtherKey="IdEmp")]
		public EntitySet<WorkSheet> WorkSheets
		{
			get
			{
				return this._WorkSheets;
			}
			set
			{
				this._WorkSheets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Salary", Storage="_Salaries", ThisKey="IdEmp", OtherKey="IdEmp")]
		public EntitySet<Salary> Salaries
		{
			get
			{
				return this._Salaries;
			}
			set
			{
				this._Salaries.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_WorkSheets(WorkSheet entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_WorkSheets(WorkSheet entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
		
		private void attach_Salaries(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Salaries(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
}
#pragma warning restore 1591
