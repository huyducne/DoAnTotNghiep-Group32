using System;
using System.Data;

public partial class category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiDuLieu();

        string idDanhMuc = Request.QueryString.Get("Id");

        string sql = "SELECT * FROM SANPHAM WHERE MaNSX =" + idDanhMuc;
        string sql1 = "SELECT * FROM HANGSX WHERE MaNSX =" + idDanhMuc;
        DataTable dataTable1 = dataAccess.LayBangDuLieu(sql);
        DataTable dataTable2 = dataAccess.LayBangDuLieu(sql1);

        this.rptSanPham.DataSource = dataTable1;
        this.rptSanPham.DataBind();
        this.rptHangSX.DataSource = dataTable2;
        this.rptHangSX.DataBind();

        dataAccess.DongKetNoiCSDL();
    }
}