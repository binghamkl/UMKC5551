#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

#endregion

namespace Bingham_Sridhar_L2_Q4
{
    public partial class _Default : System.Web.UI.Page
    {

        /*-- Constructors --*/

        #region -- Constructor() --
        public _Default()
        {

        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        /*-- Methods --*/

        #region -- CreateNode(XmlNode node) Method --
        /// <summary>
        /// Create Tree nodes for the tree control from XLMNode
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private TreeNode CreateNode(XmlNode node)
        {
            TreeNode newNode = new TreeNode();
            if (string.IsNullOrEmpty(node.Value))
                newNode.Text = node.Name;
            else
                newNode.Text = node.Value;
            foreach (XmlNode childNode in node.ChildNodes)
            {
                TreeNode treeChild = CreateNode(childNode);
                newNode.ChildNodes.Add(treeChild);
            }
            return newNode;
        }
        #endregion

        /*-- Event Handlers --*/

        #region -- Page_Load(object sender, EventArgs e) Event Handler --
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region -- uxSearchZip_Click(object sender, EventArgs e) Event Handler --
        protected void uxSearchZip_Click(object sender, EventArgs e)
        {
            try
            {
                uszipWS.USZip client = new uszipWS.USZip();
                XmlNode node =  client.GetInfoByZIP(uxZipCode.Text);
                uxRaw.Text = node.InnerXml;

                //Put information into tree
                TreeNode newNode = CreateNode(node);
                uxRawXMLTree.Nodes.Clear();
                uxRawXMLTree.Nodes.Add(newNode);
                uxRawXMLTree.ExpandAll();

                XmlSerializer serializer = new XmlSerializer(typeof(Location));
                XmlReader reader = XmlReader.Create(new StringReader(node.InnerXml));                

                Location location = (Location)serializer.Deserialize(reader);

                if (location != null)
                {
                    uxAreaCode.Text = location.Area_Code;
                    uxCity.Text = location.City;
                    uxState.Text = location.State;
                    uxTimeZone.Text = location.Time_Zone;
                    uxZip.Text = location.Zip;
                }


            }
            catch (Exception ex)
            {
            }
        }
        #endregion

    }
}
