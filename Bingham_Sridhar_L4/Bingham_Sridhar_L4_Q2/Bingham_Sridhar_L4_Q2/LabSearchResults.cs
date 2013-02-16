#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#endregion

namespace Bingham_Sridhar_L4_Q2
{
    public class LabSearchResults
    {

        private String _error;
        private bool _success;
        private List<LabMember> _labMembers = new List<LabMember>();

        /*-- Constructors --*/

        #region -- Constructor() --
        public LabSearchResults()
        {

        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        #region -- Success Property --
        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }
        #endregion

        #region -- Error Property --
        public String Error
        {
            get { return _error; }
            set { _error = value; }
        }
        #endregion

        #region -- LabMembers Property --
        public List<LabMember> LabMembers
        {
            get { return _labMembers; }
            set { _labMembers = value; }
        }
        #endregion

        /*-- Methods --*/

        /*-- Event Handlers --*/

        /*-- Factory Method --*/

        #region -- LoadByFirstNames(String FirstName) Method --
        internal static LabSearchResults LoadByFirstNames(String FirstName)
		{
            LabSearchResults result = new LabSearchResults();
            try
            {
                Lab4Entities labEntity = new Lab4Entities();
                var LabMemberList = labEntity.FetchLabMemberByFirstName(FirstName);
                result.LabMembers = LabMemberList.ToList();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
		}
		#endregion

        #region -- LoadOthersExdludingFirstName(String FirstName) Method --
        internal static LabSearchResults LoadOthersExcludingFirstName(String FirstName)
        {
            LabSearchResults result = new LabSearchResults();
            try
            {
                Lab4Entities labEntity = new Lab4Entities();
                var LabMemberList = labEntity.FetchOtherLabMemberExcludingFirstName(FirstName);
                result.LabMembers = LabMemberList.ToList();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }
        #endregion

    }
}