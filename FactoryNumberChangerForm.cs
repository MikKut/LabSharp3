using Lb3_CSharp.Models;
using Lb3_CSharp.Models.HR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class FactoryNumberChangerForm : Form
    {
        Dictionary<int, Workshop> workshops = new Dictionary<int, Workshop>();
        Dictionary<string, Slave> slaves = new Dictionary<string, Slave>();
        Dictionary<string, Master> masters = new Dictionary<string, Master>();
        FactoriesDirection.FactoriesDirection _factoriesDirection;
        public FactoryNumberChangerForm()
        {
            _factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            InitializeComponent();
        }

        private void AddFactoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameBox.Text))
                {
                    throw new ArgumentException("Wrong input factory data");
                }
                var x = workshops.Values;
                if (!_factoriesDirection.AddFactory(new Factory(NameBox.Text, workshops.Values, new FactoryHR(new Dictionary<string, Slave>(slaves), new Dictionary<string, Master>(masters), IncomePerMasterNumeric.Value, IncomePerSlaveNumeric.Value))))
                {
                    MessageBox.Show("This factory already exists");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workshops.Clear();
                slaves.Clear();
                masters.Clear();
            }
        }

        private void DeleteFactoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameBox.Text))
                {
                    throw new ArgumentException("Wrong input factory data");
                }

                if (!_factoriesDirection.DeleteFactory(new Factory(NameBox.Text, workshops.Values, new FactoryHR(slaves, masters, IncomePerMasterNumeric.Value, IncomePerSlaveNumeric.Value))))
                {
                    MessageBox.Show("Cannot delete the factory: nothing to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workshops.Clear();
                slaves.Clear();
                masters.Clear();
            }
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
             this.Hide();
             this.Owner.Show();
        }

        private void QuantityOfMasters_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WorkshopAdder_Click(object sender, EventArgs e)
        {
            try
            {
                workshops.Add((int)IDNumeric.Value, new Workshop((int)SellingCostNumeric.Value, (int)IDNumeric.Value, (int)WorkplaceNumberNumeric.Value, (int)CurrentNumberOfMastersNumeric.Value, (int)CurrentNumberOfEmployeeNumeric.Value, (int)MaxCapacityNumeric.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)WorkshopIDNumeric.Value;
                CheckPersonData(id);
                slaves.Add(PersonTIN.Text, new Slave(id, PersonName.Text, PersonTIN.Text, HasEducation.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                HasEducation.Checked = false;
            }
        }
        private void CheckPersonData(int id)
        {
            if (!workshops.ContainsKey(id))
            {
                throw new ArgumentException("There is no such workshop");
            }

            if (!long.TryParse(PersonTIN.Text, out _))
            {
                throw new ArgumentException("Wrong TIN");
            }
            if (slaves.Where(x => x.Value.WokshopID == id).Count() 
                + masters.Where(x => x.Value.WokshopID == id).Count()
                >= workshops[id].MaxCapacity)
            {
                throw new ArgumentException("Too much people in the workshop");
            }
        }

        private void AddMaster_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)WorkshopIDNumeric.Value;
                CheckPersonData(id);
                masters.Add(PersonTIN.Text, new Master(id, PersonName.Text, PersonTIN.Text, (int)NumberOfDoneCoursesNumeric.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HasEducation_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
