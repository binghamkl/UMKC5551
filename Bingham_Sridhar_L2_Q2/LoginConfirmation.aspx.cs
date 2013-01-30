#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class LoginConfirmation : System.Web.UI.Page
{


    /*-- Constructors --*/

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            String Email = Server.UrlDecode(Request.QueryString["Email"]);
            String Password = Server.UrlDecode(Request.QueryString["Password"]);
            String RememberMe = Server.UrlDecode(Request.QueryString["RememberMe"]);
            uxEmail.Text = Email;
            uxPassword.Text = Password;
            uxRememberMe.Text = RememberMe;
        }
    }
    #endregion

}