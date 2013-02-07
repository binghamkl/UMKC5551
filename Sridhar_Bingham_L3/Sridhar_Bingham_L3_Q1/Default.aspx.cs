using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String configString = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
        SqlConnection connection = new SqlConnection(configString);
        connection.Open();

        SqlCommand cmd = new SqlCommand("Select * from UserAccount", connection);
        SqlDataReader reader =  cmd.ExecuteReader();
    }
}
