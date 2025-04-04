using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОБЗД
{
    public partial class Doslidnyk : Form
    {
        public Doslidnyk()
        {
            InitializeComponent();
        }

        private void Doslidnyk_Load(object sender, EventArgs e)
        {
            this.Height = 500;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlipz24_2_kss.дослідник");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "Last name"; 

            DGWFormat();
        }
        void DGWFormat()
        {
            dataGridView1.Columns[0].HeaderText = "ID doslidnyka";
            dataGridView1.Columns[1].HeaderText = "Name doslidnyka";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "place of work";
            
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                ChancelFind();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                }
            }
        }



        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            ChancelFind();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                ChancelFind();
            }
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                    if (cellValue != null && cellValue.ToString().Contains(txtFind.Text))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }

        private void txtFind_Leave_1(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            ChancelFind();
        }
        private void ChancelFind()
        {
            label1.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }
    }
}
