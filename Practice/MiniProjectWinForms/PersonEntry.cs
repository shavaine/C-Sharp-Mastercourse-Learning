﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDemoLibrary;

namespace MiniProjectWinForms
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        string curItem;
        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList(),
            };
        }
    }
}
