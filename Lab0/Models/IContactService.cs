namespace Lab0.Models;

public interface IContactService
{
    List<Contact> GetContacts();
    Contact? GetContactById(int id);
    void CreateContact(Contact contact);
    bool UpdateContact(Contact contact);
    bool DeleteContactById(int id);
}