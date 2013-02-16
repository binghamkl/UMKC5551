#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

#endregion

namespace Bingham_Sridhar_L4_Q2
{
    /// <summary>
    /// Summary description for LabPartners
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LabPartners : System.Web.Services.WebService
    {

        [WebMethod]
        #region -- LookupByFirstName(String FirstName) Web Method --
        public LabSearchResults LookupByFirstName(String FirstName)
        {
            return LabSearchResults.LoadByFirstNames(FirstName);
        }
        #endregion

        [WebMethod]
        #region -- LookupOtherMembersFirstNames(String FirstName) Web Method --
        public String LookupOtherMembersFirstNames(String FirstName)
        {
            try
            {
                LabSearchResults results = LabSearchResults.LoadOthersExcludingFirstName(FirstName);
                String returnvalue = String.Empty;

                if (results.LabMembers.Count == 0)
                    returnvalue = "{none}";
                else
                {
                    if (results.Success)
                    {
                        foreach (LabMember labMember in results.LabMembers)
                        {
                            if (!string.IsNullOrEmpty(returnvalue))
                            {
                                returnvalue += ", ";
                            }
                            returnvalue += labMember.FirstName;
                        }
                    }
                    else
                        returnvalue = string.Format("Error {0} ", results.Error);
                }

                return returnvalue;
            }
            catch (Exception ex)
            {
                return String.Format("Error {0}", ex.Message);
            }
        }
        #endregion

    }
}
