using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaserrr
{
    public partial class Form2 : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\databaserrr\databaserrr\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
                     con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into employe values(' " + tbname.Text + "','" + tbsalary.Text + "')";
            con.Close();
            MessageBox.Show("Saved");
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE employe SET name='" + tbname.Text + "WHERE id='" + tbid.Text + "'";
            con.Close();
            MessageBox.Show("Update!");
        }

        private void btfetch_Click(object sender, EventArgs e)
        {
            string cmd = "Select * from employe";
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();
            dp.Fill(dt);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
        }

        private void database1DataSet3BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btselectimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbimage.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = tbimage.Text;
            

            
            
        }

        private void tbimage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsaveimage_Click(object sender, EventArgs e)
        {
            con.Open();
            byte[] Imagebytes = File.ReadAllBytes(tbimage.Text);
            SqlCommand s = new SqlCommand("insert into imgtable (id,pic) values('5',@pic)", con);
            
            
            SqlParameter prm = new SqlParameter("@pic",SqlDbType.VarBinary,Imagebytes.Length,ParameterDirection.Input,false,0,0,null,DataRowVersion.Current,Imagebytes);
            s.Parameters.Add(prm);
            s.ExecuteNonQuery();
            con.Close();
        }

        private void btdisplay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from imgtable where Id=" + tbid.Text , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            byte[] mydata = new byte[0];
            mydata = (byte[])dt.Rows[0][1];
            MemoryStream ms = new MemoryStream(mydata);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
