using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
  class ContactsStorage
  {
    private FileStream fStream;
    private StreamWriter sWriter;
    private StreamReader sReader;
    public ContactsStorage() { }
    public bool SaveContact(List<Contact> contacts)
    {
      bool fileExists = false;
      string fileToSave = @"SavedContactList.txt";
      using(this.sWriter = File.CreateText(fileToSave));
      foreach(Contact c in contacts)
      {
        using(this.sWriter = File.AppendText(fileToSave))
        {
          sWriter.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", c.ContactIndexNumber, c.ContactName, c.ContactStreetAddressName, c.ContactZIPCode, c.ContactCity, c.ContactPhoneNumber, c.ContactEmailAddress );
        }
      }
      return fileExists;
      // gglöm ej att sttänga strömmen
    }

    public List<Contact> LoadContacts()
    {
      List<Contact> contacts = new List<Contact>();
      string fileToRead = @"SavedContactList.txt";
      if(File.Exists(fileToRead))
      {
        fStream = new FileStream("SavedContactList.txt", FileMode.Open);
        sReader = new StreamReader(fStream);
        string ContactIndexNumber = sReader.ReadLine();
        string ContactName = sReader.ReadLine();
        string ContactStreetAddressName = sReader.ReadLine();
        string ContactZIPCode = sReader.ReadLine();
        string ContactCity = sReader.ReadLine();
        string ContactPhoneNumber = sReader.ReadLine();
        string ContactEmailAddress = sReader.ReadLine();
        while(ContactName != null)
        {
          Contact contact = new Contact();
          contact.ContactIndexNumber = int.Parse(ContactIndexNumber);
          contact.ContactName = ContactName;
          contact.ContactStreetAddressName = ContactStreetAddressName;
          contact.ContactZIPCode = ContactZIPCode;
          contact.ContactCity = ContactCity;
          contact.ContactPhoneNumber = ContactPhoneNumber;
          contact.ContactEmailAddress = ContactEmailAddress;
          contacts.Add(contact);
          ContactIndexNumber = sReader.ReadLine();
          ContactName = sReader.ReadLine();
          ContactStreetAddressName = sReader.ReadLine();
          ContactZIPCode = sReader.ReadLine();
          ContactCity = sReader.ReadLine();
          ContactPhoneNumber = sReader.ReadLine();
          ContactEmailAddress = sReader.ReadLine();
        }
        sReader.Close();
      }
      return contacts;
    }
  }
}
