using PersonManagement.Common;
using PersonManagement.Common.Repositories;
using PersonManagement.Models;
using PersonManagement.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
    public partial class PersonEditForm : Form
    {
        private IPerson model;
        private IPersonRepository personRepository;

        public PersonEditForm(IPersonRepository repository, IPerson person = null)
        {
            this.model = person;
            personRepository = repository;
            InitializeComponent();
        }

        private void PersonEditForm_Load(object sender, EventArgs e)
        {
            if (model != null)
            {
                this.Text = $"Edit Person: {model.Name} {model.Surname}";
                this.btn_submit.Text = "Edit";

                this.input_OIB.Text = model.OIB;
                this.input_name.Text = model.Name;
                this.input_surname.Text = model.Surname;
                this.input_address.Text = model.Address;
                this.input_place.Text = model.Place;
                this.input_email.Text = model.Mail;
                this.input_phone.Text = model.Phone;
            }
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            bool creationFlag = false;

            if (model == null)
            {
                creationFlag = true;
                model = new Person();
                model.Id = Guid.NewGuid();
                model.DateCreated = DateTime.Now;
            }

            model.OIB = this.input_OIB.Text;
            model.Name = this.input_name.Text;
            model.Surname = this.input_surname.Text;
            model.Place = this.input_place.Text;
            model.Address = this.input_address.Text;
            model.Phone = this.input_phone.Text;
            model.Mail = this.input_email.Text;
            model.DateUpdated = DateTime.Now;

            try
            {
                ValidateData(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (creationFlag)
                    model = null; // Reset for dateCreated field to be accurate...

                return;
            }

            // Assume validation is passed error-free.
            try
            {
                if (creationFlag)
                {
                    await personRepository.CreateAsync(model);
                }
                else
                {
                    await personRepository.UpdateAsync(model.Id, model);
                }
            }
            catch (Exception ex)
            {
                
                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                {
                    if (ex.InnerException.InnerException.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("OIB already exists.", "Person " + (creationFlag ? "creation" : "update") + " failed.");
                        await personRepository.ReloadAsync();

                        // This code only if you assume the OIB repetition was accidental:
                        if (creationFlag) model = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Person " + (creationFlag ? "creation" : "update") + " failed.");
                }
            }

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Please use this with a try-catch block.
        private void ValidateData(IPerson person)
        {
            if (person == null)
            {
                throw new Exception("Model is empty.");
            }

            if (person.OIB.IsNullOrEmpty())
            {
                throw new Exception("OIB is null or empty.");
            }
            
            // OIB consists of 11 digits - ISO 7064, 11.10
            // Could be prefixed with letters such as "HR"
            if (person.OIB.Length < 11 || person.OIB.Length > 13)
            {
                throw new Exception("Invalid OIB format.");
            }

            if (person.Name.IsNullOrEmpty())
            {
                throw new Exception("Name is null or empty.");
            }

            if (person.Surname.IsNullOrEmpty())
            {
                throw new Exception("Surname is null or empty.");
            }

            if (person.Place.IsNullOrEmpty())
            {
                throw new Exception("Place is null or empty.");
            }

            if (person.Address.IsNullOrEmpty())
            {
                throw new Exception("Address is null or empty.");
            }

            if (person.Phone.IsNullOrEmpty())
            {
                throw new Exception("Phone is null or empty.");
            }

            if (person.Mail.IsNullOrEmpty())
            {
                throw new Exception("Email is null or empty.");
            }

            // This is to have a form of simple email validation, I could copy-paste billions of regex implementations, none of them are "perfect".
            try
            {
                MailAddress e = new MailAddress(person.Mail);
            }
            catch(Exception ex)
            {
                throw new Exception("Email isn't in the proper format.");
            }
        }
    }
}
