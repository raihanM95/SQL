using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataOperation
{
    public partial class Form1 : Form
    {
        DataManage dm = new DataManage();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string query = @"CREATE TABLE " + txtTName.Text + " (Id int primary key)";

            dm.Execute(query);
        }

        private void btnCreateColumn_Click(object sender, EventArgs e)
        {
            string query = @"ALTER TABLE " + txtTName.Text + " ADD " + txtCName.Text + " varchar(100)";

            dm.Execute(query);
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string query = @"DROP TABLE " + txtTName.Text + "";

            dm.Execute(query);
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            string query = @"ALTER TABLE Student
                             DROP COLUMN " + txtCName.Text + "";

            dm.Execute(query);
        }
    }
}
