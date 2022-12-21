using Lb2_CSharp.FileOperations;
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

namespace Lb2_CSharp
{
    public partial class GetLoadedForm : Form
    {
        public GetLoadedForm()
        {
            InitializeComponent();
        }

        private void FactoryInfoChangerBackground_Enter(object sender, EventArgs e)
        {

        }

        private void ChangeFactoryInfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Serializer_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperator.SerializeCurrentFactoryState(FactoriesDirection.GetInstance().Factories);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deserializer_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperator.DeserializeSavedFactories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
