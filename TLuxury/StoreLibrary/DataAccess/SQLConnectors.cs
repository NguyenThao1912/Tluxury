using Dapper;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.DataAccess
{
    public class SQLConnectors : IDataConnection
    {
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

        public List<Model_Category> GetAllCategory()
        {
            List<Model_Category> model;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                model = connection.Query<Model_Category>("exec dbo.GetAllCategory").ToList();
            }
            return model;
        }

        public List<Model_Color> GetAllColor()
        {
            List<Model_Color> model;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
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

        public Model_Product InsertNewProduct(Model_Product model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new  DynamicParameters();
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
                p.Add("@ProductID","",DbType.String,direction:ParameterDirection.Output);
                connection.Execute("dbo.InsertNewProduct", p,commandType: CommandType.StoredProcedure);
                model.ID = p.Get<string>("@ProductID");
            }
            return model;
        }

        public Model_Employee InsertNewEmployee(Model_Employee model)
        {
            using(IDbConnection connection =  new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
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
        /// Xóa Khách hàng 
        /// </summary>
        public void DeleteCustomer(Model_Customer model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@CustomerID", model.ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("Delete_Customer", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Lấy toàn bộ Nhân viên ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy toàn bộ Sản phẩm ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProducts()
        {
            throw new NotImplementedException();
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

        public DataTable GetAllEntryBills()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy toàn bộ Hóa đơn bán ra 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSellBills()
        {
            throw new NotImplementedException();
        }


        public void UpdateCustomer(Model_Customer model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@CustomerID", model.ID);
            p.Add("@Name", model.Name);
            p.Add("@PhoneNumber", model.PhoneNumber);
            p.Add("@Address", model.Address);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateCustomer", p, commandType: CommandType.StoredProcedure);
            }
        }

        public DataTable FindCustomerByName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@CustomerName", name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
               table.Load(connection.ExecuteReader("FindCustomerBy_Name", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public DataTable FindCustomerByID(string ID)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@CustomerID", ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindCustomerBy_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }

        public void UpdateSupplier(Model_Supplier model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@SupplierID", model.ID);
            p.Add("@Name", model.Name);
            p.Add("@PhoneNumber", model.PhoneNumber);
            p.Add("@Address", model.Address);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("UpdateSupplier", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSupplier(Model_Supplier model)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@SupplierID", model.ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                connection.Execute("Delete_Supplier", p, commandType: CommandType.StoredProcedure);
            }
        }

        public DataTable FindSupplierByName(string name)
        {
            DynamicParameters p = new DynamicParameters();
            DataTable table = new DataTable();
            p.Add("@SupplierName", name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Clothes")))
            {
                table.Load(connection.ExecuteReader("FindSupplierBy_ID", p, commandType: CommandType.StoredProcedure));
            }
            return table;
        }
    }
}
