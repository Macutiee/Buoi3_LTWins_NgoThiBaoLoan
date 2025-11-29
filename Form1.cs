using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Buoi3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStudents.SelectedItems[0];

                txtLN.Text = item.SubItems[0].Text;
                txtFN.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        private void AddRow(string ln, string fn, string phone)
        {
            string[] row = { ln, fn, phone };
            lvStudents.Items.Add(new ListViewItem(row));
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string ln = txtLN.Text.Trim();
            string fn = txtFN.Text.Trim();
            string phone = txtPhone.Text.Trim();
            if (ln == "" && fn == "" && phone == "")
            {
                MessageBox.Show("Điền thông tin đi bà!");
                return;
            }
            AddRow(ln, fn, phone);
            txtLN.Clear();
            txtFN.Clear();
            txtPhone.Clear();
        }
    }
}
