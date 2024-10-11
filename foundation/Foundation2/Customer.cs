public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;

    public Customer (string first, string last, Address address)
    {
        _firstName = first;
        _lastName = last;
        _address = address;
    }
    
    public bool LivesInUSA()
    {
        if (_address.IsUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetNameText()
    {
        return $"{_firstName} {_lastName}";
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}