#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class ForgotPasswordConfirmation : System.Web.UI.Page
{


    /*-- Constructors --*/

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {
        uxColor.Text = Server.UrlDecode(Request.QueryString["Color"]);
        uxEmail.Text = Server.UrlDecode(Request.QueryString["Email"]);
        //Lookup password
        uxPassword.Text = "1234567";  // What a bad password.
    }
    #endregion

}