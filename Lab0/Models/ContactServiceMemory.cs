namespace Lab0.Models;

public class ContactServiceMemory : IContactService
{
    private static Dictionary<int, Contact> _contacts = new()
    {
        {
            1, new Contact()
            {
                Id = 1,
                Name = "Adam",
                Email = "ad@wsei.edu.pl",
                BirthDate = DateOnly.FromDateTime(new DateTime(2000, 03, 11))
            }
        },
        {
            2, new Contact()
            {
                Id = 2,
                Name = "Ewa",
                Email = "Ew@wsei.edu.pl",
                BirthDate = DateOnly.FromDateTime(new DateTime(2000, 03, 12))
            }
        }
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
}