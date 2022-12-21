using Lb2_CSharp;
using Lb3_CSharp.Models;
using Lb3_CSharp.Models.HR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class GeneralForm : Form
    {
        private Color _errorColor = Color.Red, _defaultColor = Color.DarkGray;
        private FactoriesDirection.FactoriesDirection factoriesDirection;
        private ForInvestorForm _investorForm;
        private ChangeFactoryInfoForm _changeFactoryInfoForm;
        private FactoryNumberChangerForm _numberChangerForm;
        private UnitFactoriesForm _unitsForm;
        private GetLoadedForm _getLoadedForm;
        public GeneralForm()
        {
            factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            _investorForm = new ForInvestorForm();
            _changeFactoryInfoForm = new ChangeFactoryInfoForm();
            _numberChangerForm = new FactoryNumberChangerForm();
            _unitsForm = new UnitFactoriesForm();
            _getLoadedForm = new GetLoadedForm();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ForInvestorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                _investorForm.RenovateListOfFactories();
                this.Hide();
                _investorForm.Show(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UnitFactoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameForUnity1.Text == String.Empty || NameForUnity2.Text == String.Empty)
                {
                    throw new ArgumentNullException($"{nameof(NameForUnity1)} or {nameof(NameForUnity2)} is empty");
                }
                
                var factory1 = factoriesDirection.GetFactory(NameForUnity1.Text);
                var factory2 = factoriesDirection.GetFactory(NameForUnity2.Text);
                factory1.Workshops.AddRange(factory2.Workshops);
                foreach(var x in factory2.FactoryHR.Employees)
                {
                    factory1.FactoryHR.AddSlave(x.Value);
                }
                foreach (var x in factory2.FactoryHR.Masters)
                {
                    factory1.FactoryHR.AddMaster(x.Value);
                }
                
                var factory3 = new Factory(factory1.Name + factory2.Name, factory1.Workshops, new FactoryHR(factory1.FactoryHR.Employees, factory1.FactoryHR.Masters,(factory1.FactoryHR.IncomePerSlave + factory2.FactoryHR.IncomePerSlave)/2, (factory1.FactoryHR.IncomePerMaster + factory2.FactoryHR.IncomePerMaster)/2));
                if (!factoriesDirection.DeleteFactory(factory1))
                {
                    throw new KeyNotFoundException();
                }

                if (!factoriesDirection.DeleteFactory(factory2))
                {
                    throw new KeyNotFoundException();
                }

                if (!factoriesDirection.AddFactory(factory3))
                {
                    throw new Exception("The factory already exists");
                }

                _unitsForm.InitializeNewFactoryInfo(factory3);
                UnitFactoriesBackground.BackColor = _defaultColor;
                this.Hide();
                _unitsForm.Show(this);
            }
            catch(ArgumentNullException ex)
            {
                UnitFactoriesBackground.BackColor = _errorColor;
                MessageBox.Show(ex.Message);
            }
            catch(KeyNotFoundException ex)
            {
                UnitFactoriesBackground.BackColor = _errorColor;
                MessageBox.Show("There is no factory you want to delete");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryInfoChangerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChangeFactoryInfoTextBox.Text == String.Empty)
                {
                    throw new ArgumentNullException($"{nameof(ChangeFactoryInfoTextBox)} is empty");
                }

                _changeFactoryInfoForm.SetValuesOfTheFactory(ChangeFactoryInfoTextBox.Text);
                FactoryInfoChangerBackground.BackColor = _defaultColor;
                this.Hide();
                _changeFactoryInfoForm.Show(this);
            }
            catch (KeyNotFoundException ex)
            {
                FactoryInfoChangerBackground.BackColor = _errorColor;
                MessageBox.Show("There is no factory you want to edit");
            }
            catch (ArgumentNullException ex)
            {
                FactoryInfoChangerBackground.BackColor = _errorColor;
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryNumberChangerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _numberChangerForm.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryInfoChangerButton_Click_1(object sender, EventArgs e)
        {

        }

        private void GoToSaving_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Hide();
                _getLoadedForm.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NameForUnity1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
