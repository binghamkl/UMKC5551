#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sridhar_Bingham_L3_Q3.AccountDeposit;

#endregion

namespace Sridhar_Bingham_L3_Q3
{
    public partial class _Default : System.Web.UI.Page
    {

        /*-- Constructors --*/

        #region -- Constructor() --
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

        #region -- uxDepositAmountPostBack_Click(object sender, EventArgs e) Event Handler --
        protected void uxDepositAmountPostBack_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDeposit.AccountService client = new AccountDeposit.AccountService();
                decimal depositAmount = 0;
                if (decimal.TryParse(uxDepositPostback.Text, out depositAmount))
                {
                    Deposit deposit = client.DepositIntoAccount(uxUserNamePostBack.Text, depositAmount);
                    uxStatusPostback.Text = deposit.Success.ToString();
                    uxTranMsgPostback.Text = deposit.TransactionMessage;
                    uxErrorPostback.Text = deposit.Error;
                }
                else
                {
                    uxErrorPostback.Text = "Could not parse the deposit";
                }
            }
            catch (Exception ex)
            {
                uxErrorPostback.Text = ex.Message;
            }
        }
        #endregion

        #region -- uxDepositAmountAjax_Click(object sender, EventArgs e) Event Handler --
        protected void uxDepositAmountAjax_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDeposit.AccountService client = new AccountDeposit.AccountService();
                decimal depositAmount = 0;
                if (decimal.TryParse(uxDepositAjax.Text, out depositAmount))
                {
                    Deposit deposit = client.DepositIntoAccount(uxUserNameAjax.Text, depositAmount);
                    uxStatusAjax.Text = deposit.Success.ToString();
                    uxTranMsgAjax.Text = deposit.TransactionMessage;
                    uxErrorAjax.Text = deposit.Error;
                }
                else
                {
                    uxErrorAjax.Text = "Could not parse the deposit";
                }
            }
            catch (Exception ex)
            {
                uxErrorAjax.Text = ex.Message;
            }
        }
        #endregion

    }
}
