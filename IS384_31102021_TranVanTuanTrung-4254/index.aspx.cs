using System;
using System.Data;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiDuLieu();

        string query = "SELECT * FROM SANPHAM ";

        DataTable dataTable1 = dataAccess.LayBangDuLieu(query);

        this.rptSanPham.DataSource = dataTable1;
        this.rptSanPham.DataBind();

        dataAccess.DongKetNoiCSDL();
    }
}