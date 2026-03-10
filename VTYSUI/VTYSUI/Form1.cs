using Microsoft.SqlServer.Server;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=f1database; user ID=postgres; password=1234"); 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "select * from \"TEAM_MEMBER\"";
            NpgsqlDataAdapter dat = new NpgsqlDataAdapter(txt, baglan);
            DataSet dset = new DataSet();
            dat.Fill(dset);
            dataGridView1.DataSource = dset.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tx = "select * from \"CAR\"";
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(tx, baglan);
            DataSet dst = new DataSet();
            dt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string tx = "select * from \"CITY\"";
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(tx, baglan);
            DataSet dst = new DataSet();
            dt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string tx = "select * from \"CITY\"";
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(tx, baglan);
            DataSet dst = new DataSet();
            dt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tx = "select * from \"SPONSOR\"";
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(tx, baglan);
            DataSet dst = new DataSet();
            dt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tx = "select * from \"DRIVER\"";
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(tx, baglan);
            DataSet dst = new DataSet();
            dt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "DELETE FROM \"SPONSOR\" WHERE \"SponsorID\" = @p1";
                NpgsqlCommand command = new NpgsqlCommand(sql, baglan);
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Sponsor ID
                command.ExecuteNonQuery();
                MessageBox.Show("Sponsor başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "INSERT INTO \"SPONSOR\" (\"SponsorID\", \"TeamID\", \"SponsorName\", \"SponsorType\", \"SponsorDescription\") VALUES (@p1, @p2, @p3, @p4, @p5)";
                NpgsqlCommand command = new NpgsqlCommand(sql, baglan);
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Sponsor ID
                command.Parameters.AddWithValue("@p2", string.IsNullOrEmpty(textBox2.Text) ? (object)DBNull.Value : Convert.ToInt32(textBox2.Text)); // Team ID
                command.Parameters.AddWithValue("@p3", textBox3.Text); // Sponsor Name
                command.Parameters.AddWithValue("@p4", textBox4.Text); // Sponsor Type
                command.Parameters.AddWithValue("@p5", textBox5.Text); // Sponsor Description
                command.ExecuteNonQuery();
                MessageBox.Show("Sponsor başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "UPDATE \"SPONSOR\" SET \"TeamID\" = @p2, \"SponsorName\" = @p3, \"SponsorType\" = @p4, \"SponsorDescription\" = @p5 WHERE \"SponsorID\" = @p1";
                NpgsqlCommand command = new NpgsqlCommand(sql, baglan);
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Sponsor ID
                command.Parameters.AddWithValue("@p2", string.IsNullOrEmpty(textBox2.Text) ? (object)DBNull.Value : Convert.ToInt32(textBox2.Text)); // Team ID
                command.Parameters.AddWithValue("@p3", textBox3.Text); // Sponsor Name
                command.Parameters.AddWithValue("@p4", textBox4.Text); // Sponsor Type
                command.Parameters.AddWithValue("@p5", textBox5.Text); // Sponsor Description
                command.ExecuteNonQuery();
                MessageBox.Show("Sponsor başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }
        }
    }
}
