using System.Collections.Generic;

namespace Address_Book.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;
    private static List<Item> _instances = new List<Item> {};

    public Item(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _instances.Add(this);
      _id = instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName()
    {
      _name = newName;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone()
    {
      _phone = newPhone;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress()
    {
      _address = newAddress;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId);
    {
      return _instances[searchId-1];
    }

  }
}