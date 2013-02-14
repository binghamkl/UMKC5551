#region -- using declarations --

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#endregion

namespace TestWebService
{
    public partial class uxForm : Form
    {


        /*-- Constructors --*/

        #region -- Constructor() --
        public uxForm()
        {
            InitializeComponent();
        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        /*-- Methods --*/

        /*-- Event Handlers --*/

        #region -- uxSearch_Click(object sender, EventArgs e) Event Handler --
        private void uxSearch_Click(object sender, EventArgs e)
        {
            LabPartnerWS.LabPartners client = new LabPartnerWS.LabPartners();
            LabPartnerWS.LabSearchResults results = client.LookupByFirstName(uxFirstName.Text);
            if (results.Success)
            {
                uxFirstName.Text = String.Empty;
                uxNameList.DataSource = results.LabMembers;
                
            }
            else
            {
                MessageBox.Show("Failure\n" + results.Error);
            }
        }
        #endregion

    }
}
