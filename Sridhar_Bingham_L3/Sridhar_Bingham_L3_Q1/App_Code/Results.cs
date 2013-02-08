#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#endregion

/// <summary>
/// Summary description for Results
/// </summary>
abstract public class Results
{

    private bool _success;
    private String _error;
    
    /*-- Constructors --*/

    #region -- Constructor() --
    public Results()
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

    #region -- Error Property --
    public String Error
    {
        get { return _error; }
        set { _error = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/
	
}