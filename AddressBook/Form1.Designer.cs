namespace AddressBook
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBoxContacts = new System.Windows.Forms.ListBox();
      this.labelName = new System.Windows.Forms.Label();
      this.labelStreetAddressName = new System.Windows.Forms.Label();
      this.labelZIPCode = new System.Windows.Forms.Label();
      this.labelCity = new System.Windows.Forms.Label();
      this.labelPhoneNumber = new System.Windows.Forms.Label();
      this.labelEmailAddress = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.textBoxStreetAddressName = new System.Windows.Forms.TextBox();
      this.textBoxZIPCode = new System.Windows.Forms.TextBox();
      this.textBoxCity = new System.Windows.Forms.TextBox();
      this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
      this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
      this.buttonSeekContact = new System.Windows.Forms.Button();
      this.buttonSaveContact = new System.Windows.Forms.Button();
      this.buttonDeleteContact = new System.Windows.Forms.Button();
      this.buttonEditContact = new System.Windows.Forms.Button();
      this.comboBoxContact = new System.Windows.Forms.ComboBox();
      this.labelSeek = new System.Windows.Forms.Label();
      this.buttonClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listBoxContacts
      // 
      this.listBoxContacts.FormattingEnabled = true;
      this.listBoxContacts.Location = new System.Drawing.Point(454, 45);
      this.listBoxContacts.Name = "listBoxContacts";
      this.listBoxContacts.Size = new System.Drawing.Size(246, 355);
      this.listBoxContacts.TabIndex = 0;
      this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.ListBoxContacts_SelectedIndexChanged);
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(240, 48);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(35, 13);
      this.labelName.TabIndex = 1;
      this.labelName.Text = "Namn";
      // 
      // labelStreetAddressName
      // 
      this.labelStreetAddressName.AutoSize = true;
      this.labelStreetAddressName.Location = new System.Drawing.Point(214, 74);
      this.labelStreetAddressName.Name = "labelStreetAddressName";
      this.labelStreetAddressName.Size = new System.Drawing.Size(61, 13);
      this.labelStreetAddressName.TabIndex = 2;
      this.labelStreetAddressName.Text = "Gatuadress";
      // 
      // labelZIPCode
      // 
      this.labelZIPCode.AutoSize = true;
      this.labelZIPCode.Location = new System.Drawing.Point(210, 100);
      this.labelZIPCode.Name = "labelZIPCode";
      this.labelZIPCode.Size = new System.Drawing.Size(65, 13);
      this.labelZIPCode.TabIndex = 3;
      this.labelZIPCode.Text = "Postnummer";
      // 
      // labelCity
      // 
      this.labelCity.AutoSize = true;
      this.labelCity.Location = new System.Drawing.Point(254, 126);
      this.labelCity.Name = "labelCity";
      this.labelCity.Size = new System.Drawing.Size(21, 13);
      this.labelCity.TabIndex = 4;
      this.labelCity.Text = "Ort";
      // 
      // labelPhoneNumber
      // 
      this.labelPhoneNumber.AutoSize = true;
      this.labelPhoneNumber.Location = new System.Drawing.Point(232, 152);
      this.labelPhoneNumber.Name = "labelPhoneNumber";
      this.labelPhoneNumber.Size = new System.Drawing.Size(43, 13);
      this.labelPhoneNumber.TabIndex = 5;
      this.labelPhoneNumber.Text = "Telefon";
      // 
      // labelEmailAddress
      // 
      this.labelEmailAddress.AutoSize = true;
      this.labelEmailAddress.Location = new System.Drawing.Point(241, 178);
      this.labelEmailAddress.Name = "labelEmailAddress";
      this.labelEmailAddress.Size = new System.Drawing.Size(34, 13);
      this.labelEmailAddress.TabIndex = 6;
      this.labelEmailAddress.Text = "Epost";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(281, 45);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(100, 20);
      this.textBoxName.TabIndex = 7;
      // 
      // textBoxStreetAddressName
      // 
      this.textBoxStreetAddressName.Location = new System.Drawing.Point(281, 71);
      this.textBoxStreetAddressName.Name = "textBoxStreetAddressName";
      this.textBoxStreetAddressName.Size = new System.Drawing.Size(100, 20);
      this.textBoxStreetAddressName.TabIndex = 8;
      // 
      // textBoxZIPCode
      // 
      this.textBoxZIPCode.Location = new System.Drawing.Point(281, 97);
      this.textBoxZIPCode.Name = "textBoxZIPCode";
      this.textBoxZIPCode.Size = new System.Drawing.Size(100, 20);
      this.textBoxZIPCode.TabIndex = 9;
      // 
      // textBoxCity
      // 
      this.textBoxCity.Location = new System.Drawing.Point(281, 123);
      this.textBoxCity.Name = "textBoxCity";
      this.textBoxCity.Size = new System.Drawing.Size(100, 20);
      this.textBoxCity.TabIndex = 10;
      // 
      // textBoxPhoneNumber
      // 
      this.textBoxPhoneNumber.Location = new System.Drawing.Point(281, 149);
      this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
      this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
      this.textBoxPhoneNumber.TabIndex = 11;
      // 
      // textBoxEmailAddress
      // 
      this.textBoxEmailAddress.Location = new System.Drawing.Point(281, 175);
      this.textBoxEmailAddress.Name = "textBoxEmailAddress";
      this.textBoxEmailAddress.Size = new System.Drawing.Size(100, 20);
      this.textBoxEmailAddress.TabIndex = 12;
      // 
      // buttonSeekContact
      // 
      this.buttonSeekContact.Location = new System.Drawing.Point(34, 81);
      this.buttonSeekContact.Name = "buttonSeekContact";
      this.buttonSeekContact.Size = new System.Drawing.Size(75, 23);
      this.buttonSeekContact.TabIndex = 13;
      this.buttonSeekContact.Text = "Sök";
      this.buttonSeekContact.UseVisualStyleBackColor = true;
      this.buttonSeekContact.Click += new System.EventHandler(this.ButtonSeekContact_Click);
      // 
      // buttonSaveContact
      // 
      this.buttonSaveContact.Location = new System.Drawing.Point(34, 139);
      this.buttonSaveContact.Name = "buttonSaveContact";
      this.buttonSaveContact.Size = new System.Drawing.Size(75, 23);
      this.buttonSaveContact.TabIndex = 14;
      this.buttonSaveContact.Text = "Spara";
      this.buttonSaveContact.UseVisualStyleBackColor = true;
      this.buttonSaveContact.Click += new System.EventHandler(this.ButtonSaveContact_Click);
      // 
      // buttonDeleteContact
      // 
      this.buttonDeleteContact.Location = new System.Drawing.Point(34, 168);
      this.buttonDeleteContact.Name = "buttonDeleteContact";
      this.buttonDeleteContact.Size = new System.Drawing.Size(75, 23);
      this.buttonDeleteContact.TabIndex = 15;
      this.buttonDeleteContact.Text = "Ta bort";
      this.buttonDeleteContact.UseVisualStyleBackColor = true;
      this.buttonDeleteContact.Click += new System.EventHandler(this.ButtonDeleteContact_Click);
      // 
      // buttonEditContact
      // 
      this.buttonEditContact.Location = new System.Drawing.Point(34, 110);
      this.buttonEditContact.Name = "buttonEditContact";
      this.buttonEditContact.Size = new System.Drawing.Size(75, 23);
      this.buttonEditContact.TabIndex = 16;
      this.buttonEditContact.Text = "Edit";
      this.buttonEditContact.UseVisualStyleBackColor = true;
      this.buttonEditContact.Click += new System.EventHandler(this.ButtonEditContact_Click);
      // 
      // comboBoxContact
      // 
      this.comboBoxContact.FormattingEnabled = true;
      this.comboBoxContact.Items.AddRange(new object[] {
            "Namn",
            "Gatuadress",
            "Postnummer",
            "Ort",
            "Telefon",
            "Epost",
            "Visa alla Kontakter"});
      this.comboBoxContact.Location = new System.Drawing.Point(34, 48);
      this.comboBoxContact.Name = "comboBoxContact";
      this.comboBoxContact.Size = new System.Drawing.Size(121, 21);
      this.comboBoxContact.TabIndex = 17;
      this.comboBoxContact.SelectedIndexChanged += new System.EventHandler(this.ComboBoxContact_SelectedIndexChanged);
      // 
      // labelSeek
      // 
      this.labelSeek.AutoSize = true;
      this.labelSeek.Location = new System.Drawing.Point(31, 32);
      this.labelSeek.Name = "labelSeek";
      this.labelSeek.Size = new System.Drawing.Size(120, 13);
      this.labelSeek.TabIndex = 18;
      this.labelSeek.Text = "Välj önskad sök område";
      // 
      // buttonClear
      // 
      this.buttonClear.Location = new System.Drawing.Point(34, 197);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(75, 23);
      this.buttonClear.TabIndex = 19;
      this.buttonClear.Text = "Rensa Form";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonClear);
      this.Controls.Add(this.labelSeek);
      this.Controls.Add(this.comboBoxContact);
      this.Controls.Add(this.buttonEditContact);
      this.Controls.Add(this.buttonDeleteContact);
      this.Controls.Add(this.buttonSaveContact);
      this.Controls.Add(this.buttonSeekContact);
      this.Controls.Add(this.textBoxEmailAddress);
      this.Controls.Add(this.textBoxPhoneNumber);
      this.Controls.Add(this.textBoxCity);
      this.Controls.Add(this.textBoxZIPCode);
      this.Controls.Add(this.textBoxStreetAddressName);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelEmailAddress);
      this.Controls.Add(this.labelPhoneNumber);
      this.Controls.Add(this.labelCity);
      this.Controls.Add(this.labelZIPCode);
      this.Controls.Add(this.labelStreetAddressName);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.listBoxContacts);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxContacts;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelStreetAddressName;
    private System.Windows.Forms.Label labelZIPCode;
    private System.Windows.Forms.Label labelCity;
    private System.Windows.Forms.Label labelPhoneNumber;
    private System.Windows.Forms.Label labelEmailAddress;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.TextBox textBoxStreetAddressName;
    private System.Windows.Forms.TextBox textBoxZIPCode;
    private System.Windows.Forms.TextBox textBoxCity;
    private System.Windows.Forms.TextBox textBoxPhoneNumber;
    private System.Windows.Forms.TextBox textBoxEmailAddress;
    private System.Windows.Forms.Button buttonSeekContact;
    private System.Windows.Forms.Button buttonSaveContact;
    private System.Windows.Forms.Button buttonDeleteContact;
    private System.Windows.Forms.Button buttonEditContact;
    private System.Windows.Forms.ComboBox comboBoxContact;
    private System.Windows.Forms.Label labelSeek;
    private System.Windows.Forms.Button buttonClear;
  }
}

