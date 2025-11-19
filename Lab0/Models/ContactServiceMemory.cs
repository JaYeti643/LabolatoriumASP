namespace Lab0.Models;

public class ContactServiceMemory : IContactService
{
    private static Dictionary<int, Contact> _contacts = new()
    {
       
    };

    private int _i = 2;
    public List<Contact> GetContacts()
    {
        return _contacts.Values.ToList();
    }

    public Contact? GetContactById(int id)
    {
        if (_contacts.ContainsKey(id))
        {
            return _contacts[id];
            
        }
        return null;
    }

    public void CreateContact(Contact contact)
    {
        contact.Id = ++_i;
        _contacts.Add(contact.Id, contact);
    }

    public bool UpdateContact(Contact contact)
    {
        if (_contacts.ContainsKey(contact.Id))
        {
            _contacts[contact.Id] = contact;
            return true;
        }

        return false;
    }

    public bool DeleteContactById(int id)
    {
        if (_contacts.ContainsKey(id))
        {
            _contacts.Remove(id);
            return true;
        }
        return false;
        
    }

    public List<OrganizationEntity> GetOrganizations()
    {
        return default;
    }
}