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
        #region Tạo Mới Thuộc tính Sản Phẩm
        Model_Category CreateNew_Category(Model_Category model);
        Model_Color CreateNew_Color(Model_Color model);
        Model_Object CreateNew_Object(Model_Object model);
        Model_Season CreateNew_Season(Model_Season model);
        Model_RawMaterial CreateNew_RawMaterial(Model_RawMaterial model);
        Model_Role CreateNew_Role(Model_Role model);
        Model_Size CreateNew_Size(Model_Size model);
        Model_Manufactured CreateNew_Manufactured(Model_Manufactured model);
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lấy Ra các Thông tin
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
        DataTable GetProductss();
        DataTable GetAllCustomers();
        DataTable GetAllEmployees();
        List<Model_Employee> getbanhang();

        DataTable GetAllProducts();
        DataTable GetAllSuppliers();
        DataTable GetAllEntryBills(DateTime start, DateTime end);
        DataTable GetAllSellBills(DateTime start, DateTime end);
        DataTable GetAllEntryDetails(string id, out int quantity, out decimal total, out string supplierName);
        DataTable GetAllSaleDetails(string id, out int quantity, out decimal total, out string Cusname);
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Các Câu lệnh Insert đối tượng chính
        Model_Product InsertNewProduct(Model_Product model);
        Model_Employee InsertNewEmployee(Model_Employee model);
        Model_Supplier InsertNewSupplier(Model_Supplier model);
        Model_Customer InsertNewCustomer(Model_Customer model);

        void InsertNewEntryDetails(string entryID, string prodID, float discount, decimal unitprice, int quantity, decimal total);
        Model_EntryInvoice InsertNewEntryInvoice(string emID, string supID, string day, decimal total);
        Model_SaleInvoice insert_hoadonban(string nhanvien_id, string day, string khach_id, decimal tongtien);
        void insert_hoadonban_chitiet(string hoadon_id, string hanghoa_ID, float giamgia, int soluong, decimal thanhtien);
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lệnh Delete-Update
        void DeleteCustomer(Model_Customer model);      //xóa khách hàng
        void UpdateCustomer(Model_Customer model);      //sửa khách hàng
        void UpdateSupplier(Model_Supplier model);      //sửa nhà cung cấp
        void DeleteSupplier(Model_Supplier model);      //xóa nhà cung cấp
        void UpdateEmployee(Model_Employee model);      //sửa nhân viên
        void DeleteEmployee(string ID);                 //xóa nhân viên
        void DeleteCategory(Model_Category model);      //xóa loại sản phẩm
        void DeleteColor(Model_Color model);            //xóa Màu
        void DeleteManuFactured(Model_Manufactured model); //Xóa nhà sản xuất
        void DeleteObject(Model_Object model);          //xóa đối tượng
        void DeleteMaterial(Model_RawMaterial model);   //xóa nguyên liệu
        void DeleteSize(Model_Size model);              //xóa kích cõ
        void DeleteSeason(Model_Season model);          //xóa mùa
        void UpdateCategory(Model_Category model);      //sửa loại sản phẩm
        void UpdateColor(Model_Color model);            //sủa màu
        void UpdateManuFactured(Model_Manufactured model); //sửa nhà sản xuất
        void UpdateObject(Model_Object model);          //sửa đối tượng
        void UpdateMaterial(Model_RawMaterial model);   //sửa nguyên liệu
        void UpdateSize(Model_Size model);              //sửa kích cỡ
        void UpdateSeason(Model_Season model);          //sửa mùa
        void DeleteProduct(Model_Product model);
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lệnh Tìm Kiếm
        DataTable FindCustomerByName(string name);
        DataTable FindCustomerByID(string ID);
        DataTable FindSupplierByName(string name);
        DataTable FindSupplierByID(string ID);
        DataTable FindEntryInvoiceByID(string ID);
        DataTable FindEntryInvoiceBySupplierName(string name);
        DataTable FindEntryInvoiceByEmployeeName(string name);
        DataTable FindEmployeeBy_ID(string ID);
        DataTable FindEmployeeBy_Name(string name);
        DataTable FindhanghoaByName(string name);
        DataTable FindSaleInvoiceBy_ID(string ID);
        DataTable FindSaleInvoiceBy_CusName(string name);
        DataTable FindSaleInvoiceBy_EmName(string name);
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Lấy báo Cáo
        DataTable ReportSupplier(string ID);
        DataTable ReportTop5Cus(int year);
        DataTable ReportCantSellProduct(int month);
        #endregion
    }
}
