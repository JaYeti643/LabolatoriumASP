namespace Lab0.Models;

public class OrganizationEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Regon { get; set; }
    public string NIP  { get; set; }
    public Address? Address { get; set; }
    public ISet<Contact> Contacts { get; set; }
}

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string Region { get; set; }
}