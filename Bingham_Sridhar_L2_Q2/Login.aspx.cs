#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class Login : System.Web.UI.Page
{


    /*-- Constructors --*/

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #endregion

    #region -- uxSubmitLogin_Click(object sender, EventArgs e) Event Handler --
    protected void uxSubmitLogin_Click(object sender, EventArgs e)
    {
        Validate();
        if (IsValid)
        {
            String Email = uxEmail.Text;
            String Password = uxPassword.Text;
            bool RememberMe = uxRememberMe.Checked;

            String url = string.Format("LoginConfirmation.aspx?Email={0}&Password={1}&RememberMe={2}",
                                    Server.UrlEncode(Email), Server.UrlEncode(Password), Server.UrlEncode(RememberMe.ToString()));
            Response.Redirect(url);
        }

    }
    #endregion

    #region -- uxPasswordValidator_ServerValidate(object source, ServerValidateEventArgs args) Event Handler --
    protected void uxPasswordValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (uxPassword.Text.Length < 7)
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    #endregion


}