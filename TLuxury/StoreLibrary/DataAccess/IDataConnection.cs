using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.DataAccess
{
    public interface IDataConnection
    {
        Model_Category CreateNew_Category(Model_Category model);
        Model_Color CreateNew_Color(Model_Color model);
        Model_Object CreateNew_Object(Model_Object model);
        Model_Season CreateNew_Season(Model_Season model);
        Model_RawMaterial CreateNew_RawMaterial(Model_RawMaterial model);
        Model_Role CreateNew_Role(Model_Role model);
        Model_Size CreateNew_Size(Model_Size model);
        Model_Manufactured CreateNew_Manufactured(Model_Manufactured model);
        List<Model_Category> GetAllCategory();
        List<Model_Color> GetAllColor();
        List<Model_Manufactured> GetAllManufactured();
        List<Model_Object> GetAllObject();
        List<Model_RawMaterial> GetModel_RawMaterials();
        List<Model_Size> GetAllSize();
        List<Model_Season> GetAllSeason();
        List<Model_Product> GetAllProduct_List();
        List<Model_Role> GetAllRole();
        List<Model_Employee> GetAllEmployee_List();
        List<Model_Supplier> GetAllSupplier_List();
        Model_Product InsertNewProduct(Model_Product model);
        Model_Employee InsertNewEmployee(Model_Employee model);
        Model_Supplier InsertNewSupplier(Model_Supplier model);
        Model_Customer InsertNewCustomer(Model_Customer model);
        DataTable GetAllCustomers();
        DataTable GetAllEmployees();
        DataTable GetAllProducts();
        DataTable GetAllSuppliers();
        DataTable GetAllEntryBills(DateTime start,DateTime end);
        DataTable GetAllSellBills();
        void DeleteCustomer(Model_Customer model);
        void UpdateCustomer(Model_Customer model);
        void UpdateSupplier(Model_Supplier model);
        void DeleteSupplier(Model_Supplier model);
        DataTable FindCustomerByName(string name);
        DataTable FindCustomerByID(string ID);
        DataTable FindSupplierByName(string name);
        DataTable FindSupplierByID(string ID);
        Model_EntryInvoice InsertNewEntryInvoice(string emID, string supID, string day, decimal total);
        void InsertNewEntryDetails(string entryID,string prodID,float discount,decimal unitprice,int quantity,decimal total );
        DataTable FindEntryInvoiceByID(string ID);
        DataTable FindEntryInvoiceBySupplierName(string name);
        DataTable FindEntryInvoiceByEmployeeName(string name);
    }
}
