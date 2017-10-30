using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class monitor_list : Form
    {
        public monitor_list(string Si_Name)
        {
            InitializeComponent();
            ImageList dummyImage = new ImageList();
            dummyImage.ImageSize = new System.Drawing.Size(1, 30);
            MessageBox.Show(Si_Name);
            //listView1.SmallImageList = dummyImage;
            //Read();
        }

        /*private void Read()
        {
            string strConn = "Server=localhost;Port=3300;Database=bhs;Uid=root;Pwd=1234;";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sql = "SELECT Station_num,Station_name FROM station WHERE Station_favorite = " + a;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                listView1.View = View.Details;
                listView1.BeginUpdate();
                while (rdr.Read())
                {
                    ListViewItem lvi = new ListViewItem(rdr["Station_num"].ToString());
                    lvi.SubItems.Add(rdr["Station_name"].ToString());
                    listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
                conn.Close();
            }
        }*/


        private void monitor_list_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
