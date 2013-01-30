#region -- using declartions --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

#endregion

/// <summary>
/// Summary description for Address
/// </summary>
public class Address : ResultBase
{

    private String _name;
    private String _street;
    private String _state;
    private String _zip;
    private String _phoneNumber;

    //street, city, state and zip) and contact number (i.e. the phone number) of the administrator
    /*-- Constructors --*/

    #region -- Constructor() --
    public Address()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion

    /*-- Events --*/

    /*-- Properties --*/

    #region -- Name Property --
    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
    #endregion

    #region -- Street Property --
    public String Street
    {
        get { return _street; }
        set { _street = value; }
    }
    #endregion

    #region -- State Property --
    public String State
    {
        get { return _state; }
        set { _state = value; }
    }
    #endregion

    #region -- Zip Property --
    public String Zip
    {
        get { return _zip; }
        set { _zip = value; }
    }
    #endregion

    #region -- PhoneNumber Property --
    public String PhoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }
    #endregion

    /*-- Methods --*/

    /*-- Event Handlers --*/

    /*-- Factory Method --*/
    
    #region -- LookupUser() Method --
	public static Address LookupUser(String userName, String password)
	{
        Address returnValue = new Address();
        returnValue.Success = true;
        try
        {
            //  Assume this was created previously.
            Hashtable hashTable = new Hashtable();
            AdminKeys key = new AdminKeys() { Password= "admin", UserName= "admin" };
            Address address = new Address() { Name = "My Address", PhoneNumber = "816-555-1212", State = "MO", Street = "1221 Harrison Street", Zip = "64106" };
            hashTable.Add(key, address);

            // Now look for thekey
            AdminKeys tryKey = new AdminKeys() { UserName = userName, Password = password };
            Address foundAddress = (Address)hashTable[tryKey];
            if (foundAddress != null)
            {
                foundAddress.Success = true;
                return foundAddress;
            }
            else
            {
                returnValue.Success = false;
                returnValue.ErrorString = "Could not find the username and password you supplied";
            }


        }
        catch (Exception ex)
        {
            returnValue.Success = false;
            returnValue.ErrorString = ex.Message;
        }
        return returnValue;

	}
	#endregion
		
	
}