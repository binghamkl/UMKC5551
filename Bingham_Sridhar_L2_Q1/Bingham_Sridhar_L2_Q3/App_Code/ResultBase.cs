#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#endregion

/// <summary>
/// Summary description for ResultBase
/// </summary>
abstract public class ResultBase
{

    private bool _success;
    private String _errorString;

    /*-- Constructors --*/

    #region -- ResultBase() Constructor --
    public ResultBase()
    {
        //
        // TODO: Add constructor logic here
        //
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

    #region -- ErrorString Property --
    public String ErrorString
    {
        get { return _errorString; }
        set { _errorString = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/
	
}