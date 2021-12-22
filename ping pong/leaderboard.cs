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

namespace ping_pong
{
    public partial class leaderboard : Form
    {
        public leaderboard()
        {
            InitializeComponent();
        }

        private void leaderboard_Load(object sender, EventArgs e)
        {
            string file_path = Application.StartupPath + "\\scores.accdb";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_path;
            //gets data
            var file_read = new List<string>();//loads userpass
            string strSQL = "SELECT * FROM leaderboard ORDER BY [score] DESC";
            // Create a connection  
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            file_read.Add(reader["name_id"].ToString() + "," + reader["score"].ToString());
                            //creates a user profile to be analysed by system
                        }
                        connection.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
            string datastring = string.Empty;
            int loop = 1;
            foreach (string element in file_read)
            {
                string score = element.Split(',')[1];
                string id = element.Split(',')[0];
                datastring += loop.ToString() + ") " + id + ": " + score + "\n";
                loop += 1;
            }
            peeps_lbl.Text = datastring;
        }

        private void leaderboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.Close();
            }
        }
    }
}
