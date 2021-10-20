/*
 * Inlämningsuppgift 1: Skapa en adressbok
 * Oguz Oz Albayrak
 * CMS21 - Programmering med C#
 * Nackademin
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
  public partial class Form1 : Form
  {
    private ContactsStorage StoredContacts = new ContactsStorage();
    private List<Contact> contacts = new List<Contact>();
    private List<Contact> tempContacts = new List<Contact>();
    private int indexNumber = 0;
    bool lockIndexNumber = false;
    bool editButtoncheck = false;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      contacts = StoredContacts.LoadContacts();
      buttonEditContact.Visible = false;
    }

    private void ButtonSeekContact_Click(object sender, EventArgs e)
    {
      string seek = "";
      if(comboBoxContact.SelectedItem == null)
      {
        comboBoxContact.SelectedText = "Välj sök område        ";
      }
      else
      {
        seek = comboBoxContact.SelectedItem.ToString();
        listBoxContacts.Items.Clear();
        tempContacts.Clear();
        lockIndexNumber = false;
        switch(seek)
        {
          case "Visa alla Kontakter":
            foreach(Contact c in contacts)
            {
              listBoxContacts.Items.Add(c.ContactName);
              tempContacts.Add(c);
            }
            listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            break;
          case "Namn":
            if(textBoxName.Text != "")
            { 
              var seekResultName = contacts.Where(x => x.ContactName.Contains(textBoxName.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultName)
              {
                listBoxContacts.Items.Add(c.ContactName);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          case "Gatuadress":
            if(textBoxStreetAddressName.Text != "")
            {
              var seekResultStreet = contacts.Where(x => x.ContactStreetAddressName.Contains(textBoxStreetAddressName.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultStreet)
              {
                listBoxContacts.Items.Add(c.ContactStreetAddressName);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          case "Postnummer":
            if(textBoxZIPCode.Text != "")
            {
              var seekResultZIPCode = contacts.Where(x => x.ContactZIPCode.Contains(textBoxZIPCode.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultZIPCode)
              {
                listBoxContacts.Items.Add(c.ContactZIPCode);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          case "Ort":
            if(textBoxCity.Text != "")
            {
              var seekResultCity = contacts.Where(x => x.ContactCity.Contains(textBoxCity.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultCity)
              {
                listBoxContacts.Items.Add(c.ContactCity);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          case "Telefon":
            if(textBoxPhoneNumber.Text != "")
            {
              var seekResultPhone = contacts.Where(x => x.ContactPhoneNumber.Contains(textBoxPhoneNumber.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultPhone)
              {
                listBoxContacts.Items.Add(c.ContactPhoneNumber);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          case "Epost":
            if(textBoxEmailAddress.Text != "")
            {
              var seekResultEmail = contacts.Where(x => x.ContactEmailAddress.Contains(textBoxEmailAddress.Text));
              listBoxContacts.Items.Clear();
              foreach(Contact c in seekResultEmail)
              {
                listBoxContacts.Items.Add(c.ContactEmailAddress);
                tempContacts.Add(c);
              }
              listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
            }
            break;
          default:
            listBoxContacts.Items.Clear();
            ClearTextBox(); 
            lockIndexNumber = false;
            break;
        }
        lockIndexNumber = false;
      }
      buttonEditContact.Visible = false;
      //listBoxContacts.DoubleClick += new EventHandler(listBoxContacts_DoubleClick);
      ClearTextBox();
    }

    private void ButtonEditContact_Click(object sender, EventArgs e)
    {
      if (lockIndexNumber)
      {
        textBoxName.Text = tempContacts[this.indexNumber].ContactName;
        textBoxStreetAddressName.Text = tempContacts[this.indexNumber].ContactStreetAddressName;
        textBoxZIPCode.Text = tempContacts[this.indexNumber].ContactZIPCode;
        textBoxCity.Text = tempContacts[this.indexNumber].ContactCity;
        textBoxPhoneNumber.Text = tempContacts[this.indexNumber].ContactPhoneNumber;
        textBoxEmailAddress.Text = tempContacts[this.indexNumber].ContactEmailAddress;
        editButtoncheck = true;
      }
      //lockIndexNumber = false;
    }

    private void ButtonSaveContact_Click(object sender, EventArgs e)
    {   
      if (editButtoncheck)
        {
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactName = textBoxName.Text;
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactStreetAddressName = textBoxStreetAddressName.Text;
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactZIPCode = textBoxZIPCode.Text;
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactCity = textBoxCity.Text;
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactPhoneNumber = textBoxPhoneNumber.Text;
        contacts[tempContacts[this.indexNumber].ContactIndexNumber].ContactEmailAddress = textBoxEmailAddress.Text;
      }
      else
      {
        contacts.Add(new Contact
        {
          ContactIndexNumber = contacts.Count,
          ContactName = textBoxName.Text,
          ContactStreetAddressName = textBoxStreetAddressName.Text,
          ContactZIPCode = textBoxZIPCode.Text,
          ContactCity = textBoxCity.Text,
          ContactPhoneNumber = textBoxPhoneNumber.Text,
          ContactEmailAddress = textBoxEmailAddress.Text
        });
      }
      
      ClearTextBox();
      IndexNumberSort();
      StoredContacts.SaveContact(contacts);
      contacts = StoredContacts.LoadContacts();
      listBoxContacts.Items.Clear();
      ClearTextBox();
      lockIndexNumber = false;
      editButtoncheck = false;
      buttonEditContact.Visible = false;
    }

    private void ButtonDeleteContact_Click(object sender, EventArgs e)
    {
      if (lockIndexNumber)
      {
        //string deletedContactName = contacts[this.indexNumber].ContactName;
        string deletedContactName = tempContacts[this.indexNumber].ContactName;
        contacts.RemoveAt(tempContacts[this.indexNumber].ContactIndexNumber);
        IndexNumberSort();
        StoredContacts.SaveContact(contacts);
        contacts = StoredContacts.LoadContacts();
        listBoxContacts.Items.Clear();
        ClearTextBox();
        lockIndexNumber = false;
        MessageBox.Show(deletedContactName);
      }
      buttonEditContact.Visible = false;
    }

    private void ComboBoxContact_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
    {     
      if(!lockIndexNumber)
      {
        this.indexNumber = int.Parse(listBoxContacts.SelectedIndex.ToString());
        lockIndexNumber = true;
      }    
    }

    private void ClearTextBox()
    {
      textBoxName.Clear();
      textBoxStreetAddressName.Clear();
      textBoxZIPCode.Clear();
      textBoxCity.Clear();
      textBoxPhoneNumber.Clear();
      textBoxEmailAddress.Clear();
    }
    
    private void IndexNumberSort()
    {
      int i = 0;
      foreach(Contact c in contacts)
      {
        c.ContactIndexNumber = i;
        i++;
      }
    }

    private void listBoxContacts_DoubleClick(object sender, EventArgs e)
    {
      ClearTextBox();
      listBoxContacts.Items.Clear();
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactName);
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactStreetAddressName);
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactZIPCode);
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactCity);
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactPhoneNumber);
      listBoxContacts.Items.Add(tempContacts[this.indexNumber].ContactEmailAddress);
      lockIndexNumber = true;
      buttonEditContact.Visible = true;
      listBoxContacts.DoubleClick -= new EventHandler(listBoxContacts_DoubleClick);
    }

    private void ButtonClear_Click(object sender, EventArgs e)
    {
      ClearTextBox();
      listBoxContacts.Items.Clear();
      lockIndexNumber = false;
      buttonEditContact.Visible = false;
    }
  }
}
