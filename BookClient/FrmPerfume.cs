using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookClient
{
    public partial class FrmPerfume : Form
    {
        SqlDataReader dr;
        public FrmPerfume()
        {
            InitializeComponent();
        }

        private void FrmPerfume_Load(object sender, EventArgs e)
        {
            List<Perfume> per = new PerfumeBUS().GetAll();
            dgv_perfume.DataSource = per;
        }

        private void dgv_perfume_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_perfume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_perfume_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_perfume.SelectedRows.Count > 0)
            {
                int Id = int.Parse(dgv_perfume.SelectedRows[0].Cells["Id"].Value.ToString());
                Perfume p = new PerfumeBUS().GetDetails(Id);
                if (p != null)
                {
                    txtid.Text = p.Id.ToString();
                    txtname.Text = p.Name;
                    txtbrand.Text = p.Brand;
                    txtorigin.Text = p.Origin.ToString();
                    txtprice.Text = p.Price.ToString();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Perfume newPerfume = new Perfume()
            {
                Id = 0,
                Name = txtname.Text.Trim(),
                Brand = txtbrand.Text.Trim(),
                Origin = txtorigin.Text.Trim(),
                Price = Double.Parse(txtprice.Text.Trim()),
            };
            bool result = new PerfumeBUS().AddNew(newPerfume);
            if (result)
            {
                List<Perfume> per = new PerfumeBUS().GetAll();
                dgv_perfume.DataSource = per;
            }
            else
            {
                MessageBox.Show("Thêm không thành công :<<< !!!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Perfume newPerfume = new Perfume()
            {
                Id = int.Parse(txtid.Text.Trim().ToString()),
                Name = txtname.Text.Trim(),
                Brand = txtbrand.Text.Trim(),
                Origin = txtorigin.Text.Trim(),
                Price = Double.Parse(txtprice.Text.Trim())
            };
            bool result = new PerfumeBUS().Update(newPerfume);
            if (result)
            {
                List<Perfume> per = new PerfumeBUS().GetAll();
                dgv_perfume.DataSource = per;
            }
            else
            {
                MessageBox.Show("Update không thành công :<<< !!!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int Id = int.Parse(txtid.Text.Trim());
                bool result = new PerfumeBUS().Delete(Id);
                if (result)
                {
                    List<Perfume> per = new PerfumeBUS().GetAll();
                    dgv_perfume.DataSource = per;
                }
                else
                {
                    MessageBox.Show("KHÔNG THỂ XÓA<<<<< !!!");
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();
            List<Perfume> per = new PerfumeBUS().Search(keyword);
            dgv_perfume.DataSource = per;
        }

        public void LoadPerfume()
        {
            int i = 0;
            string strPerfume = ConfigurationManager.ConnectionStrings["strPerfume"].ConnectionString;
            SqlConnection con = new SqlConnection(strPerfume);
            SqlCommand cm = new SqlCommand();
            string queryString = "SELECT * FROM Perfume WHERE CONCAT(Id, Name, Brand, Origin) LIKE '%" + txt_search.Text + "%'";
            cm = new SqlCommand(queryString, con);
            con.Open();
            dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_perfume.DataSource = dt;
        }
        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("Searching ... ");
                LoadPerfume();
            }
        }

        private void FrmPerfume_Load_1(object sender, EventArgs e)
        {
            List<Perfume> per = new PerfumeBUS().GetAll();
            dgv_perfume.DataSource = per;
        }

        private void FrmPerfume_Load_2(object sender, EventArgs e)
        {
            List<Perfume> per = new PerfumeBUS().GetAll();
            dgv_perfume.DataSource = per;
        }
    }
}