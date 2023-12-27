using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            var userName = textBox1.Text;
            //var password = Password.Text;
            MessageBox.Show("Welcome "+userName);
        }

        private void employeeMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vRecruitDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vRecruitDataSet.EmployeeMaster' table. You can move, or remove it, as needed.
            this.employeeMasterTableAdapter.Fill(this.vRecruitDataSet.EmployeeMaster);

        }

        private void employeeMasterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
