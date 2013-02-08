#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

#endregion

/// <summary>
/// Summary description for Account
/// </summary>
public class Account : Results
{

    private int _accountNo;
    private String _userName;

    /*-- Constructors --*/

    #region -- Constructor(String UserName) --
    public Account(String UserName)
    {
        try
        {
            String configString = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection connection = new SqlConnection(configString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("FetchAccount", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserName", UserName));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                AccountNo = reader.GetInt32(reader.GetOrdinal("AccountNo"));
                UserName = reader.GetString(reader.GetOrdinal("UserName"));
                Success = true;
            }
            reader.Close();
            connection.Close();

        }
        catch (Exception ex)
        {
            Success = false;
            Error = ex.Message;
        }
    }
    #endregion

    /*-- Events --*/

    /*-- Properties --*/

    #region -- AccountNo Property --
    public int AccountNo
    {
        get { return _accountNo; }
        set { _accountNo = value; }
    }
    #endregion

    #region -- UserName Property --
    public String UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/
	
}