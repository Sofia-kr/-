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
    public partial class Roslyny : Form
    {
        public Roslyny()
        {
            InitializeComponent();
        }

        private void Roslyny_Load(object sender, EventArgs e)
        {
            this.Height = 500;  
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlipz24_2_kss.рослинии");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "Nazva roslyny";

            DGWFormat();

            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            dtBorder = h.myfunDt("select min(`Vik roslyny`), max(`Vik roslyny`) from рослинии;");
            dtDistinct = h.myfunDt("select distinct `ID roslyny` from рослинии;");

            // записуємо межі у відповідні елементи керування
            txtVikFrom.Text = dtBorder.Rows[0][0].ToString();
            txtVikTo.Text = dtBorder.Rows[0][1].ToString();
 

            // визначаємо перелік можливих значень текстового поля
            cmbGeografia.Items.Add("");
            for (int i = 0; i < dtDistinct.Rows.Count; i++)
            {
                cmbGeografia.Items.Add(dtDistinct.Rows[i][0].ToString());
            }
            cmbGeografia.DropDownStyle = ComboBoxStyle.DropDownList; //заборона редагування comboBox
            

        }
        void DGWFormat()
        {
            dataGridView1.Columns[0].HeaderText = "ID roslyny";
            dataGridView1.Columns[1].HeaderText = "Vik roslyny";
            dataGridView1.Columns[2].HeaderText = "Vyd roslyny";
            dataGridView1.Columns[3].HeaderText = "Nazva roslyny";
            dataGridView1.Columns[4].HeaderText = "Geografia roslyny";
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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1);
            gfx.DrawLine(p, 0, 5, 5, 5);
            gfx.DrawLine(p,35,5,e.ClipRectangle.Width-2,5);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width -2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2,0, e.ClipRectangle.Height - 2);


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 500;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 370;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "Nazva roslyny > 0";
            if (txtNameRosl.Text != "")
            {
                strFilter += " AND `Nazva roslyny` LIKE '%" + txtNameRosl.Text + "%'";

            }
            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }
    }
}
