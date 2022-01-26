using System;
using System.Data;

public partial class product_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiDuLieu();

        string idSanPham = Request.QueryString.Get("Id");

        string sql = "SELECT * FROM SANPHAM WHERE MaSP =" + idSanPham;

        DataTable dataTable1 = dataAccess.LayBangDuLieu(sql);


        this.rptSanPham.DataSource = dataTable1;
        this.rptSanPham.DataBind();


        dataAccess.DongKetNoiCSDL();
    }
}