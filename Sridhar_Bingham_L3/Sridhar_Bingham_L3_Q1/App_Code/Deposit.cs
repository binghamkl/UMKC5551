#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

#endregion

/// <summary>
/// Summary description for UserAccount
/// </summary>
public class Deposit : Results
{


    private String _transactionMessage;
    private String _userName;
    private decimal _amount;

    /*-- Constructors --*/

    #region -- Constructor() --
    public Deposit() { }
    #endregion

    #region -- Constructor(String UserName, decimal Amount) --
    public Deposit(String UserName, decimal Amount)
    {
        try
        {
            Account account = new Account(UserName);
            if (account.Success)
            {
                String configString = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
                SqlConnection connection = new SqlConnection(configString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("InsertTransaction", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("AccountNo", account.AccountNo));
                cmd.Parameters.Add(new SqlParameter("Amount", Amount));
                SqlParameter outParam = new SqlParameter("TransactionId", System.Data.SqlDbType.Int);
                outParam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();

                if (outParam.Value == null)
                {
                    this.Success = false;
                    this.Error = "Did not Get back a transaction ID";
                }
                else
                {
                    this.Success = true;
                    this.Amount = Amount;
                    this.Username = Username;
                    this.TransactionMessage = "Successfully deposited Transaction ID " + outParam.Value.ToString();
                }

                connection.Close();
            }
            else
            {
                this.Success = false;
                this.Error = "Could not Load Account   " + account.Error;
            }
        }
        catch (Exception ex)
        {
            this.Success = false;
            this.Error = ex.Message;
        }
    }
    #endregion

    /*-- Events --*/

    /*-- Properties --*/

    #region -- Username Property --
    public String Username
    {
        get { return _userName; }
        set { _userName = value; }
    }
    #endregion

    #region -- Amount Property --
    public decimal Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    #endregion

    #region -- TransactionMessage Property --
    public String TransactionMessage
    {
        get { return _transactionMessage; }
        set { _transactionMessage = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/
	
}