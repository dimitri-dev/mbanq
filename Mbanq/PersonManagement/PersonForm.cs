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

namespace PersonManagement
{
    public partial class PersonForm : Form
    {
        private IPersonRepository personRepository = new PersonRepository();
        private IEnumerable<IPerson> dataSource = new List<IPerson>();

        public PersonForm()
        {
            InitializeComponent();
        }

        private async void PersonForm_Load(object sender, EventArgs e)
        {
            dataSource = await personRepository.GetAllAsync();
            personBindingSource.DataSource = dataSource;
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            // TODO: Implement new person creation
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
                // TODO: Delete row logic
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
                // TODO: Edit row logic
                MessageBox.Show("Edit button pressed");
            }
        }

        private string PersonDetails(IPerson person)
        {
            return $"{person.OIB} - {person.Name} {person.Surname}\n"
                 + $"{person.Address} {person.Place}\n"
                 + $"{person.Phone} - {person.Mail}";
        }
    }
}
