using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ping
{
    public partial class entry : Form
    {
        public entry()
        {
            InitializeComponent();
        }
        public static string name;
        private void cofirm_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "")
            {
                name = name_txt.Text;
                string file_path = Application.StartupPath + "\\scores.accdb";
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_path;
                using (OleDbConnection cnn = new OleDbConnection(connectionString))
                {
                    string sql = "insert into leaderboard ([name_id], [score]) values(@first,@second)";
                    cnn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@first", entry.name);
                        cmd.Parameters.AddWithValue("@second", Ping.points);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                Form Lead = new leaderboard();
                Lead.Show();
                this.Close();
            }
        }

        private void entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.Close();
            }
        }
    }
}
