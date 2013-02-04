#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

#endregion

/// <summary>
/// Summary description for Location
/// </summary>
[Serializable()]
[XmlRoot("Table")]
public class Location
{
    private String _city;
    private String _state;
    private String _zip;
    private String _area_Code;
    private String _time_Zone;

    /*-- Constructors --*/

    #region -- Constructor() --
    public Location()
    {

    }
    #endregion

    /*-- Events --*/

    /*-- Properties --*/

    #region -- City Property --
    [XmlElement("CITY")]
    public String City
    {
        get { return _city; }
        set { _city = value; }
    }
    #endregion

    #region -- State Property --
    [XmlElement("STATE")]
    public String State
    {
        get { return _state; }
        set { _state = value; }
    }
    #endregion

    #region -- Zip Property --
    [XmlElement("ZIP")]
    public String Zip
    {
        get { return _zip; }
        set { _zip = value; }
    }
    #endregion

    #region -- Area_Code Property --
    [XmlElement("AREA_CODE")]
    public String Area_Code
    {
        get { return _area_Code; }
        set { _area_Code = value; }
    }
    #endregion

    #region -- Time_Zone Property --
    [XmlElement("TIME_ZONE")]
    public String Time_Zone
    {
        get { return _time_Zone; }
        set { _time_Zone = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/

}