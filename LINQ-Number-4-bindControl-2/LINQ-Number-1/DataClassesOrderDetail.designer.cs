﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_Number_1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="northwindProg210")]
	public partial class DataClassesOrderDetailDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrder_Detail(Order_Detail instance);
    partial void UpdateOrder_Detail(Order_Detail instance);
    partial void DeleteOrder_Detail(Order_Detail instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public DataClassesOrderDetailDataContext() : 
				base(global::LINQ_Number_1.Properties.Settings.Default.northwindProg210ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesOrderDetailDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesOrderDetailDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesOrderDetailDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesOrderDetailDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order_Detail> Order_Details
		{
			get
			{
				return this.GetTable<Order_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order Details]")]
	public partial class Order_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private int _ProductID;
		
		private decimal _UnitPrice;
		
		private short _Quantity;
		
		private float _Discount;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(short value);
    partial void OnQuantityChanged();
    partial void OnDiscountChanging(float value);
    partial void OnDiscountChanged();
    #endregion
		
		public Order_Detail()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money NOT NULL")]
		public decimal UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="SmallInt NOT NULL")]
		public short Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Real NOT NULL")]
		public float Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Detail", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Order_Details.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Order_Details.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(int);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private int _SupplierID;
		
		private int _CategoryID;
		
		private string _QuantityPerUnit;
		
		private decimal _UnitPrice;
		
		private short _UnitsInStock;
		
		private short _UnitsOnOrder;
		
		private short _ReorderLevel;
		
		private bool _Discontinued;
		
		private EntitySet<Order_Detail> _Order_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnSupplierIDChanging(int value);
    partial void OnSupplierIDChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnQuantityPerUnitChanging(string value);
    partial void OnQuantityPerUnitChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnUnitsInStockChanging(short value);
    partial void OnUnitsInStockChanged();
    partial void OnUnitsOnOrderChanging(short value);
    partial void OnUnitsOnOrderChanged();
    partial void OnReorderLevelChanging(short value);
    partial void OnReorderLevelChanged();
    partial void OnDiscontinuedChanging(bool value);
    partial void OnDiscontinuedChanged();
    #endregion
		
		public Product()
		{
			this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", DbType="Int NOT NULL")]
		public int SupplierID
		{
			get
			{
				return this._SupplierID;
			}
			set
			{
				if ((this._SupplierID != value))
				{
					this.OnSupplierIDChanging(value);
					this.SendPropertyChanging();
					this._SupplierID = value;
					this.SendPropertyChanged("SupplierID");
					this.OnSupplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL")]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityPerUnit", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string QuantityPerUnit
		{
			get
			{
				return this._QuantityPerUnit;
			}
			set
			{
				if ((this._QuantityPerUnit != value))
				{
					this.OnQuantityPerUnitChanging(value);
					this.SendPropertyChanging();
					this._QuantityPerUnit = value;
					this.SendPropertyChanged("QuantityPerUnit");
					this.OnQuantityPerUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money NOT NULL")]
		public decimal UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsInStock", DbType="SmallInt NOT NULL")]
		public short UnitsInStock
		{
			get
			{
				return this._UnitsInStock;
			}
			set
			{
				if ((this._UnitsInStock != value))
				{
					this.OnUnitsInStockChanging(value);
					this.SendPropertyChanging();
					this._UnitsInStock = value;
					this.SendPropertyChanged("UnitsInStock");
					this.OnUnitsInStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsOnOrder", DbType="SmallInt NOT NULL")]
		public short UnitsOnOrder
		{
			get
			{
				return this._UnitsOnOrder;
			}
			set
			{
				if ((this._UnitsOnOrder != value))
				{
					this.OnUnitsOnOrderChanging(value);
					this.SendPropertyChanging();
					this._UnitsOnOrder = value;
					this.SendPropertyChanged("UnitsOnOrder");
					this.OnUnitsOnOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReorderLevel", DbType="SmallInt NOT NULL")]
		public short ReorderLevel
		{
			get
			{
				return this._ReorderLevel;
			}
			set
			{
				if ((this._ReorderLevel != value))
				{
					this.OnReorderLevelChanging(value);
					this.SendPropertyChanging();
					this._ReorderLevel = value;
					this.SendPropertyChanged("ReorderLevel");
					this.OnReorderLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discontinued", DbType="Bit NOT NULL")]
		public bool Discontinued
		{
			get
			{
				return this._Discontinued;
			}
			set
			{
				if ((this._Discontinued != value))
				{
					this.OnDiscontinuedChanging(value);
					this.SendPropertyChanging();
					this._Discontinued = value;
					this.SendPropertyChanged("Discontinued");
					this.OnDiscontinuedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Detail", Storage="_Order_Details", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Order_Detail> Order_Details
		{
			get
			{
				return this._Order_Details;
			}
			set
			{
				this._Order_Details.Assign(value);
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
		
		private void attach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
}
#pragma warning restore 1591