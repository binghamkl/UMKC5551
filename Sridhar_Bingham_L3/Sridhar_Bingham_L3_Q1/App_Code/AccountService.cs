#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

#endregion

/// <summary>
/// Summary description for Accounts
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AccountService : System.Web.Services.WebService {

    public AccountService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    #region -- DepositIntoAccount(String UserName, decimal Amount) Web Method --
    public Deposit DepositIntoAccount(String UserName, decimal Amount)
    {
        Deposit deposit = new Deposit(UserName, Amount);
        return deposit;
    }
    #endregion

}
