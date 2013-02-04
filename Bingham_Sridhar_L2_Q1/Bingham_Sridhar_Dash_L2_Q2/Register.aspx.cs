#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class Register : System.Web.UI.Page
{


    /*-- Constructors --*/

    #region -- Constructor() --
    public Register()
    {

    }
    #endregion

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #endregion

    #region -- uxSubmit_Click(object sender, EventArgs e) Event Handler --
    protected void uxSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Validate();
            if (Page.IsValid)
            {
                String Name = txtName.Text;
                String Email = txtEmail.Text;
                String Password = txtPassword.Text;
                String Gender = uxGender.SelectedValue;
                String Phone = txtPhoneNumber.Text;
                String SubscribeTo = uxSubscribeTo.SelectedValue;
                String redirectTo = string.Format("RegistrationConfirmation.aspx?Name={0}&Email={1}&Password={2}&Gender={3}&Phone={4}&SubscribeTo={5}",
                                                Server.UrlEncode(Name), Server.UrlEncode(Email), Server.UrlEncode(Password), Server.UrlEncode(Gender),
                                                Server.UrlEncode(Phone), Server.UrlEncode(SubscribeTo));
                Response.Redirect(redirectTo);
            }

        }
        catch (Exception ex)
        {
            uxWarning.Text = ex.Message;
        }
    }
    #endregion

    #region -- uxCancel_Click(object sender, EventArgs e) Event Handler --
    protected void uxCancel_Click(object sender, EventArgs e)
    {

    }
    #endregion

    #region -- uxPasswordValidator_ServerValidate(object source, ServerValidateEventArgs args) Event Handler --
    protected void uxPasswordValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (txtPassword.Text.Length < 7)
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    #endregion

}