using PersonManagement.Models.Common;
using PersonManagement.Common.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonManagement.Common.Filters;

namespace PersonManagement
{
    public partial class PersonForm : Form
    {
        private IPersonRepository personRepository = new PersonRepository();

        public PersonForm()
        {
            InitializeComponent();
        }

        private async void PersonForm_Load(object sender, EventArgs e)
        {
            personBindingSource.DataSource = await personRepository.GetAllAsync();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(personRepository);
            form.ShowDialog();

            PersonForm_Load(sender, e);
        }

        private void ultraGrid1_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            if (e.ReInitialize == false)
            {
                e.Row.Cells["EditButton"].Value = "Edit";
                e.Row.Cells["DeleteButton"].Value = "Delete";
            }
        }

        private async void ultraGrid1_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Value == "Delete")
            {
                try
                {
                    var personId = (Guid)e.Cell.Row.Cells["Id"].Value;
                    var person = await personRepository.GetAsync(personId); // Easier to fetch from local than to parse rows, performance is questionable....

                    var mb = MessageBox.Show(PersonDetails(person), "Are you sure you want to delete this user?", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == mb)
                    {
                        var result = await personRepository.DeleteAsync(personId);
                        MessageBox.Show($"User is " + (result ? "" : "not ") + "sucessfully deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Issue Occured");
                }
            }
            
            if (e.Cell.Value == "Edit")
            {
                var personId = (Guid)e.Cell.Row.Cells["Id"].Value;
                var person = await personRepository.GetAsync(personId); // Easier to fetch from local than to parse rows, performance is questionable....

                PersonEditForm form = new PersonEditForm(personRepository, person);
                form.ShowDialog();
            }

            PersonForm_Load(sender, e);
        }

        private string PersonDetails(IPerson person)
        {
            return $"{person.OIB} - {person.Name} {person.Surname}\n"
                 + $"{person.Address} {person.Place}\n"
                 + $"{person.Phone} - {person.Mail}";
        }

        private async void input_searchPhrase_ValueChanged(object sender, EventArgs e)
        {
            var filter = new PersonFilter();
            filter.SearchPhrase = input_searchPhrase.Text;
            personBindingSource.DataSource = await personRepository.GetAllAsync(filter);
        }
    }
}
