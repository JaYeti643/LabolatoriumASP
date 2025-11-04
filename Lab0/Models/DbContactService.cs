namespace Lab0.Models;

public class DbContactService(AppDbContext context) : IContactService
{
    public List<Contact> GetContacts()
    {
        return context.Contacts.ToList();
    }

    public Contact? GetContactById(int id)
    {
        return context.Contacts.Find(id);
    }

    public void CreateContact(Contact contact)
    {
        context.Contacts.Add(contact);
        context.SaveChanges();
    }

    public bool UpdateContact(Contact contact)
    {
        context.Contacts.Update(contact);
        context.SaveChanges();
        return true;
    }

    public bool DeleteContactById(int id)
    {
        var entity = context.Contacts.Find(id);
        if (entity != null)
        {
            context.Contacts.Remove(entity);
            context.SaveChanges();
            return true;
        }
        return false;
    }
}