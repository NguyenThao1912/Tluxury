﻿using Dapper;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace StoreLibrary.DataAccess
{
    public class SQLConnectors : IDataConnection
    {
        #region Tạo Mới Thuộc Tính Sản Phẩm
        public Model_Category CreateNew_Category(Model_Category model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewCategory", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Color CreateNew_Color(Model_Color model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewColor", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Manufactured CreateNew_Manufactured(Model_Manufactured model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewManufactured", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Object CreateNew_Object(Model_Object model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewObject", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_RawMaterial CreateNew_RawMaterial(Model_RawMaterial model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewRawMaterial", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Role CreateNew_Role(Model_Role model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewRole", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Season CreateNew_Season(Model_Season model)

        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewSeason", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }

        public Model_Size CreateNew_Size(Model_Size model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Size", model.Size);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.NewSize", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@id");
                return model;
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lấy Ra Các Thông Tin từ CSDL
        public List<Model_Category> GetAllCategory()
        {
            List<Model_Category> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Category>("exec dbo.GetAllCategory").ToList();
            }
            return model;
        }


        public List<Model_Color> GetAllColor()
        {
            List<Model_Color> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Color>("exec dbo.GetAllColor").ToList();
            }
            return model;
        }

        public List<Model_Manufactured> GetAllManufactured()
        {
            List<Model_Manufactured> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Manufactured>("exec dbo.GetAllManufactured").ToList();
            }
            return model;
        }

        public List<Model_Object> GetAllObject()
        {
            List<Model_Object> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Object>("exec dbo.GetAllObject").ToList();
            }
            return model;
        }

        public List<Model_RawMaterial> GetModel_RawMaterials()
        {
            List<Model_RawMaterial> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_RawMaterial>("exec dbo.GetAllRawMaterial").ToList();
            }
            return model;
        }

        public List<Model_Size> GetAllSize()
        {
            List<Model_Size> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Size>("exec dbo.GetAllSize").ToList();
            }
            return model;
        }

        public List<Model_Season> GetAllSeason()
        {
            List<Model_Season> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Season>("exec dbo.GetAllSeason").ToList();
            }
            return model;
        }

        public List<Model_Role> GetAllRole()
        {
            List<Model_Role> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Role>("exec dbo.GetAllRole").ToList();
            }
            return model;
        }
        /// <summary>
        /// Lấy ra Datatable có thông tin của khách Hàng
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCustomers()
        {
            DataTable model = new DataTable();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.GetAllCustomers", null, commandType: CommandType.StoredProcedure));
            }
            return model;
        }
        /// <summary>
        /// Lấy toàn bộ Nhân viên ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllEmployees()
        {
            DataTable model = new DataTable();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.GetAllEmployee", null, commandType: CommandType.StoredProcedure));
            }
            return model;
        }

        /// <summary>
        /// Lấy toàn bộ Sản phẩm ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProducts()
        {
            DataTable model = new DataTable();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.getallproduct_banhang", null, commandType: CommandType.StoredProcedure));
            }
            return model;
        }
        /// <summary>
        /// Lấy toàn bộ Nhà cung cấp ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSuppliers()
        {
            DataTable model = new DataTable();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.GetAllSuppliers", null, commandType: CommandType.StoredProcedure));
            }
            return model;
        }
        /// <summary>
        /// Lấy toàn bộ Hóa đơn Nhập ra 1 data table
        /// </summary>
        /// <returns></returns>

        public DataTable GetAllEntryBills(DateTime start, DateTime end)
        {
            DataTable model = new DataTable();
            var p = new DynamicParameters();
            p.Add("@DateStart", start);
            p.Add("@DateEnd", end);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.GetAllEntryInvoices", p, commandType: CommandType.StoredProcedure));
            }
            return model;
        }
        public List<Model_Product> GetAllProduct_List()
        {
            List<Model_Product> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Product>("exec dbo.GetAllProduct_List").ToList();
            }
            return model;
        }
        public List<Model_Employee> getbanhang()
        {
            List<Model_Employee> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Employee>("exec dbo.getbanhang").ToList();
            }
            return model;
        }

        public List<Model_Supplier> GetAllSupplier_List()
        {
            List<Model_Supplier> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Supplier>("exec dbo.GetAllSupplier_List").ToList();
            }
            return model;
        }

        public List<Model_Employee> GetAllEmployee_List()
        {
            List<Model_Employee> model;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Employee>("exec dbo.GetAllEmployee_List").ToList();
            }
            return model;
        }
        public DataTable GetAllEntryDetails(string id, out int quantity, out decimal total, out string supplierName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                DataTable table = new DataTable();
                var p = new DynamicParameters();
                p.Add("@EntryInvoiceID", id);
                p.Add("@Quantity", 0, DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@Total", 0, DbType.Decimal, direction: ParameterDirection.Output);
                p.Add("@Name", "", DbType.String, direction: ParameterDirection.Output);
                table.Load(connection.ExecuteReader("GetAllProduct_In_EntryInvoice", p, commandType: CommandType.StoredProcedure));
                quantity = p.Get<int>("@Quantity");
                total = p.Get<decimal>("@Total");
                supplierName = p.Get<string>("@Name");
                return table;
            }

        }
        public DataTable GetProductss()
        {
            DataTable model = new DataTable();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.[GetAllProduct]", null, commandType: CommandType.StoredProcedure));
            }
            return model;
        }
        /// <summary>
        /// Lấy toàn bộ Hóa đơn bán ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSellBills(DateTime start, DateTime end)
        {
            DataTable model = new DataTable();
            var p = new DynamicParameters();
            p.Add("@DateStart", start);
            p.Add("@DateEnd", end);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model.Load(connection.ExecuteReader("dbo.[GetAllSaleInvoice]", p, commandType: CommandType.StoredProcedure));
            }
            return model;
        }

        public DataTable GetAllSaleDetails(string id, out int quantity, out decimal total, out string Cusname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                DataTable table = new DataTable();
                var p = new DynamicParameters();
                p.Add("@SaleInvoiceID", id);
                p.Add("@Quantity", 0, DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@Total", 0, DbType.Decimal, direction: ParameterDirection.Output);
                p.Add("@Name", "", DbType.String, direction: ParameterDirection.Output);
                table.Load(connection.ExecuteReader("[GetAllProduct_In_SaleInvoice]", p, commandType: CommandType.StoredProcedure));
                quantity = p.Get<int>("@Quantity");
                total = p.Get<decimal>("@Total");
                Cusname = p.Get<string>("@Name");
                return table;
            }

        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Các Câu lệnh Insert đối tượng chính
        //Tạo Hóa đơn nhập mới
        public Model_EntryInvoice InsertNewEntryInvoice(string emID, string supID, string day, decimal total)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                Model_EntryInvoice model = new Model_EntryInvoice();
                var p = new DynamicParameters();
                p.Add("@EmployeeID ", emID);
                p.Add("@SupplierID", supID);
                p.Add("@DayEntry", day);
                p.Add("@Total", total);
                p.Add("@EntryID", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("dbo.InsertNewEntryInvoice", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<string>("@EntryID");
                model.SupplierID = supID;
                model.Day = DateTime.Parse(day);
                model.EmployeeID = emID;
                model.Total = total;
                return model;
            }
        }
        //Tạo chi tiết hóa đơn  nhập mới
        public void InsertNewEntryDetails(string entryID, string prodID, float discount, decimal unitprice, int quantity, decimal total)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@EntryID ", entryID);
                p.Add("@ProductID", prodID);
                p.Add("@Discount", discount);
                p.Add("@UnitPrice", unitprice);
                p.Add("@Quantity", quantity);
                p.Add("@Total", total);
                connection.Execute("dbo.InsertNewEntryDetails", p, commandType: CommandType.StoredProcedure);
            }
        }
        public Model_SaleInvoice Insert_SaleInvoice(string nhanvien_id, string day, string khach_id, decimal tongtien)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                Model_SaleInvoice model = new Model_SaleInvoice();
                var p = new DynamicParameters();
                p.Add("@id", "", DbType.String, direction: ParameterDirection.Output);
                p.Add("@manv ", nhanvien_id);
                p.Add("@makh", khach_id);
                p.Add("@ngayban", day);
                p.Add("@tongtien", tongtien);
                connection.Execute("Insert_SaleInvoice", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<string>("@id");
                model.EmployeeID = nhanvien_id;
                model.day = DateTime.Parse(day);
                model.CustomerID = khach_id;
                model.Total = tongtien;
                return model;
            }
        }
        public void insert_hoadonban_chitiet(string hoadon_id, string hanghoa_ID, float giamgia, int soluong, decimal thanhtien)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@idhoadon ", hoadon_id);
                p.Add("@idhanghoa", hanghoa_ID);
                p.Add("@soluong", soluong);
                p.Add("@giamgia", giamgia);
                p.Add("@thanhtien", thanhtien);
                connection.Execute("dbo.insert_hoadonban_chitiet", p, commandType: CommandType.StoredProcedure);
            }
        }

        //Tạo Sản phẩm mới
        public Model_Product InsertNewProduct(Model_Product model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@ProductName", model.Name);
                p.Add("@CategoryID", model.Category.ID);
                p.Add("@SizeID", model.Size.ID);
                p.Add("@RawMaterial_ID", model.Material.ID);
                p.Add("@ColorID", model.Color.ID);
                p.Add("@ObjectID", model.Object.ID);
                p.Add("@SeasonId", model.Season.ID);
                p.Add("@ManufacturedID", model.Manufactured.ID);
                p.Add("Quantity", model.Quantity);
                p.Add("@Picture", model.Picture);
                p.Add("@PriceEntry", model.PriceEntry);
                p.Add("@PriceSell", model.PriceSell);
                p.Add("@ProductID", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("dbo.InsertNewProduct", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<string>("@ProductID");
            }
            return model;
        }
        //Tạo Nhân Viên mới
        public Model_Employee InsertNewEmployee(Model_Employee model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Sex", model.Sex);
                p.Add("@DateOfBirth", model.DateOfBirth);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Address", model.Address);
                p.Add("@RoleID", model.Role.ID);
                p.Add("@ID", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("dbo.InsertNewEmployee", p, commandType: CommandType.StoredProcedure);
                p.Get<string>("@ID");
                return model;
            }
        }
        //Tạo Nhà Cung Cấp mới
        public Model_Supplier InsertNewSupplier(Model_Supplier model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Address", model.Address);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@ID", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("dbo.InsertNewSupplier", p, commandType: CommandType.StoredProcedure);
                p.Get<string>("@ID");
                return model;
            }
        }
        //Tạo Khách hàng mới
        public Model_Customer InsertNewCustomer(Model_Customer model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Address", model.Address);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@ID", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("dbo.InsertNewCustomer", p, commandType: CommandType.StoredProcedure);
                p.Get<string>("@ID");
                return model;
            }
        }

        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Các Lệnh Delete Update

        public void DeleteProduct(Model_Product model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@ProductID", model.ID);
                connection.Execute("[dbo].[Delete_Product]", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateProduct(Model_Product model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@ProductID", model.ID);
                p.Add("@ProductName", model.Name);
                p.Add("@CategoryID", model.Category.ID);
                p.Add("@SizeID", model.Size.ID);
                p.Add("@RawMaterial_ID", model.Material.ID);
                p.Add("@ColorID", model.Color.ID);
                p.Add("@ObjectID", model.Object.ID);
                p.Add("@SeasonID", model.Season.ID);
                p.Add("@ManufacturedID", model.Manufactured.ID);
                p.Add("@Quantity", model.Quantity);
                p.Add("@Picture", model.Picture);
                p.Add("@PriceEntry", model.PriceEntry);
                p.Add("@PriceSell", model.PriceSell);
                connection.Execute("dbo.UpdateProduct", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteEntryInvoice(string ID)
        {
            var p = new DynamicParameters();
            p.Add("EntryID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("dbo.Delete_EntryInvoice", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateEmployee(Model_Employee model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@EmployeeID", model.ID);
                p.Add("@Name", model.Name);
                p.Add("@Sex", model.Sex);
                p.Add("@DateOfBirth", model.DateOfBirth.Date);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Address", model.Address);
                p.Add("@RoleID", model.Role.ID);
                connection.Execute("dbo.UpdateEmployee", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteEmployee(string ID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@EmployeeID", ID);
                connection.Execute("dbo.Delete_Employee", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Xóa Khách hàng 
        /// </summary>
        public void DeleteCustomer(Model_Customer model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@CustomerID", model.ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("Delete_Customer", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCustomer(Model_Customer model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@CustomerID", model.ID);
            p.Add("@Name", model.Name);
            p.Add("@PhoneNumber", model.PhoneNumber);
            p.Add("@Address", model.Address);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateCustomer", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateSupplier(Model_Supplier model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@SupplierID", model.ID);
            p.Add("@Name", model.Name);
            p.Add("@PhoneNumber", model.PhoneNumber);
            p.Add("@Address", model.Address);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateSupplier", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSupplier(Model_Supplier model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@SupplierID", model.ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("Delete_Supplier", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteCategory(Model_Category model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", model.ID);
                connection.Execute("DeleteCategory", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteColor(Model_Color model)
        {

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", model.ID);
                connection.Execute("DeleteColor", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteManuFactured(Model_Manufactured model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("DeleteManuFactured", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteObject(Model_Object model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("DeleteObject", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteMaterial(Model_RawMaterial model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("DeleteRawMaterial", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSize(Model_Size model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("DeleteSize", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSeason(Model_Season model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("DeleteSeason", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCategory(Model_Category model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateCategory", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateColor(Model_Color model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateColor", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateManuFactured(Model_Manufactured model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateManuFactured", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateObject(Model_Object model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateObject", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateMaterial(Model_RawMaterial model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateRawMaterial", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateSize(Model_Size model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Size);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateSize", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateSeason(Model_Season model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ID", model.ID);
            p.Add("@Name", model.Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateSeason", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteSaleInvoice(string ID)
        {
            var p = new DynamicParameters();
            p.Add("SaleID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("dbo.[Delete_SaleInvoice]", p, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lệnh Tìm Kiếm
        public string find_anh(string hang_id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                string model = "";
                var p = new DynamicParameters();
                p.Add("@mahang", hang_id);
                p.Add("@link", "", DbType.String, direction: ParameterDirection.Output);
                connection.Execute("laylinkanh", p, commandType: CommandType.StoredProcedure);
                model = p.Get<string>("@link");
                return model;
            }
        }
        public DataTable FindCustomerByName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@CustomerName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindCustomerBy_Name", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable FindhanghoaByName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@ProductName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("findhanghoa_banhang", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable FindCustomerByID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@CustomerID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindCustomerBy_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindSupplierByName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@SupplierName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSupplierBy_Name", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindSupplierByID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@SupplierID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSupplierBy_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }


        public DataTable FindEntryInvoiceByID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@EntryID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindEntryInvoiceBy_ID ", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindEntryInvoiceBySupplierName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@SupplierName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindEntryInvoiceBy_SupplierName", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindEntryInvoiceByEmployeeName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@EmployeeName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindEntryInvoiceBy_EmployeeName", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable FindEmployeeBy_ID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@ID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindEmployeeBy_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindEmployeeBy_Name(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@Name", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindEmployeeBy_Name", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }


        public DataTable FindSaleInvoiceBy_ID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@ID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSaleInvoiceby_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindSaleInvoiceBy_CusName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@CusName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSaleInvoiceby_CusName", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindSaleInvoiceBy_EmName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@EmName", name);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSaleInvoiceby_EmName", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        //TÌM KIẾM SẢN PHẨM
        public DataTable FindProduct(string sql)
        {
            string CutFilter = "SELECT Product.ID as N'Mã Sản Phẩm'," +
                    "Product.Name as N'Tên Sản Phẩm'," +
                    "Category.Name as N'Loại Sản Phẩm'," +
                    "Size.Size as N'Kích Cỡ'," +
                    "RawMaterial.Name as N'Nguyên Liệu'," +
                    "Color.Name as N'Màu Sắc'," +
                    "Object.Name as N'Đối Tượng'," +
                    "Season.Name as N'Mùa'," +
                    "Manufactured.Name as N'Nhà Sản Xuất'," +
                    "Quantity as 'Số Lượng'," +
                    "PriceEntry as N'Giá Nhập'," +
                    "PriceSell as N'Giá Bán'" +
                    "FROM Product, Category, Size, RawMaterial, Color, Object, Season, Manufactured " +
                    "WHERE CategoryID = Category.ID AND " +
                    "SizeID = Size.ID AND " +
                    "RawMaterial_ID = RawMaterial.ID AND " +
                    "ColorID = Color.ID AND " +
                    "Object.ID = ObjectID AND " +
                    "SeasonID = Season.ID AND " +
                    "Manufactured.ID = ManufacturedID AND ";
            CutFilter += sql.Remove(sql.Length - 4, 3);
            DataTable table = new DataTable();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader(CutFilter, commandType: CommandType.Text));
            }
            return table;
        }
        // connection.Query<Model_Product,Model_Category,Model_Size,Model_RawMaterial,Model_Color,Model_Object,Model_Season,Model_Manufactured>("sql");

        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lấy Báo Cáo
        public DataTable ReportSupplier(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@SupplierID", ID);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("ReportSupplier", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable ReportTop5Cus(int year)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@year", year);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("[ReportTop5KH]", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable ReportCantSellProduct(int month)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@month", month);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("[ReportcantSellProduct]", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
        public DataTable ReportSaleInvoice(int month, int year, out decimal Amount)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@month", month);
            p.Add("@year", year);
            p.Add("@Amount", 0, DbType.Decimal, ParameterDirection.Output);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("ReportSaleInvoice", p, commandType: CommandType.StoredProcedure));
            }
            Amount = p.Get<decimal>("@Amount");
            return table;

        }

        #endregion
        public Users Checklogin(string username, string pass)
        {
            Users us = new Users();
            DynamicParameters p = new DynamicParameters();
            p.Add("@user", username);
            p.Add("@pass", pass);
            p.Add("@status", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@role", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@islogin", 0, DbType.Int32, ParameterDirection.Output);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("CheckLogin", p, commandType: CommandType.StoredProcedure);
            }
            us.status = p.Get<int>("@status");
            us.role = p.Get<int>("@role");
            us.islogin = p.Get<int>("@islogin");
            return us;
        }

    }
}
