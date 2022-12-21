using Lb3_CSharp.Models;
using Lb2_Sharp.FactoriesDirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lb3_CSharp.Models.HR;

namespace Lb2_Sharp
{
    public partial class ChangeFactoryInfoForm : Form
    {
        private FactoriesDirection.FactoriesDirection _factoriesDirection;
        private IFactoryHR _factoryHR;
        private List<Workshop> _workshops;
        private Dictionary<string, Slave> _slaves;
        private Dictionary<string, Master> _masters;
        private IFactory _oldFactory;
        public ChangeFactoryInfoForm()
        {
            _factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            InitializeComponent();
        }
        public void SetValuesOfTheFactory(string factoryName)
        {
            try 
            { 
            _oldFactory = FactoriesDirection.FactoriesDirection.GetInstance().Factories[factoryName];
            NameBox.Text = factoryName;
            IncomePerMasterNumeric.Value = _oldFactory.FactoryHR.IncomePerMaster;
            IncomePerSlaveNumeric.Value = _oldFactory.FactoryHR.IncomePerSlave;
            _factoryHR = _oldFactory.FactoryHR;
            _workshops = _oldFactory.Workshops;
            _slaves = _oldFactory.FactoryHR.Employees;
            _masters = _oldFactory.FactoryHR.Masters;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void SubmitFactoryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameBox.Text))
                {
                    throw new ArgumentException("Wrong input factory data");
                }
                var factory = _factoriesDirection.GetFactory(NameBox.Text);
                _factoriesDirection.DeleteFactory(factory);
                if (!_factoriesDirection.AddFactory(new Factory(NameBox.Text, factory.Workshops, factory.FactoryHR)))
                {
                    MessageBox.Show("This factory already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void IncomePerSlaveNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IncomePerMasterNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IncomePerSlave_Click(object sender, EventArgs e)
        {

        }

        private void IncomePerMaster_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfSlavesLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfSlavesNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuantityOfMasters_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfMastersNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuantityOfWorkshops_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfWorkshopsNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteWorkshopButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (_workshops.Remove(new Workshop(SellingCostNumeric.Value, (int)IDNumeric.Value, (int)WorkplaceNumberNumeric.Value, (int)CurrentNumberOfMastersNumeric.Value, (int)CurrentNumberOfEmployeeNumeric.Value, (int)MaxCapacityNumeric.Value)))
                {
                    DeleteWorkshopButton.BackColor = Color.Green;
                }

                DeleteWorkshopButton.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_slaves.Remove(PersonName.Text))
                {
                    DeleteEmployeeButton.BackColor = Color.Green;
                }

                DeleteEmployeeButton.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }

        private void DeleteMasterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_masters.Remove(PersonName.Text))
                {
                    DeleteMasterButton.BackColor = Color.Green;
                }

                DeleteMasterButton.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)WorkshopIDNumeric.Value;
                CheckPersonData(id);
                _slaves.Add(PersonTIN.Text, new Slave(id, PersonName.Text, PersonTIN.Text, HasEducation.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }
        private void CheckPersonData(int id)
        {
            if (_workshops.Where(x => x.ID == id).Count() == 0)
            {
                MessageBox.Show("Wrong workshop ID");
                return;
            }

            if (!int.TryParse(PersonTIN.Text, out _))
            {
                MessageBox.Show("Wrong TIN");
                return;
            }
        }

        private void AddMaster_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)WorkshopIDNumeric.Value;
                CheckPersonData(id);
                _masters.Add(PersonTIN.Text, new Master(id, PersonName.Text, PersonTIN.Text, (int)NumberOfDoneCoursesNumeric.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }

        private void WorkshopAdder_Click(object sender, EventArgs e)
        {
            try
            {
                _workshops.Add((new Workshop(SellingCostNumeric.Value, (int)IDNumeric.Value, (int)WorkplaceNumberNumeric.Value, (int)CurrentNumberOfMastersNumeric.Value, (int)CurrentNumberOfEmployeeNumeric.Value, (int)MaxCapacityNumeric.Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DeleteWorkshopButton.BackColor = Color.Red;
            }
        }
    }
}
