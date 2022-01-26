using System;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiDuLieu();

        string query = "SELECT * FROM HANGSX ";

        DataTable dataTable1 = dataAccess.LayBangDuLieu(query);

        this.rptHangSX.DataSource = dataTable1;
        this.rptHangSX.DataBind();


        dataAccess.DongKetNoiCSDL();
    }

}

