
/* Unmerged change from project '11_App_Code'
Before:
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
After:
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
*/
using System.Data;
using System.Data.SqlClient;

public class DataAccess : System.Web.UI.Page
{
    SqlConnection connection;

    public void MoKetNoiDuLieu()
    {
        string path = Page.Server.MapPath("App_data");
        path += "\\Database.mdf";
        connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");
        connection.Open();
        //connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""..\App_Data\Database.mdf"";Integrated Security=True");
        //connection.Open();

    }

    public DataTable LayBangDuLieu(string sql)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable dataTable = new DataTable();

        adapter.Fill(dataTable);

        return dataTable;


    }
    public int ThucThiCauLenhSql(string sql)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = this.connection;
        cmd.CommandText = sql;

        return cmd.ExecuteNonQuery();
    }

    public void DongKetNoiCSDL()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}