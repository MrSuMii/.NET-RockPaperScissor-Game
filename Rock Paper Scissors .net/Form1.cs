using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Rock_Paper_Scissors_.net
{

    public partial class Form1 : Form
 
    {

        string playerchoice;
        string computerchoice;
        string[] options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerscore;
        int playerscore;
        string draw;
        string uname = null;
        string winner = null;
        string word = null;


        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void CPU_PIC_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            playerchoice = (string)tempButton.Tag;

            int i = random.Next(0, options.Length);
            computerchoice = options[i];

            IblPlayerchoice.Text = uname + " Choise is: " + UpdateTextandImage(playerchoice, PLAYER_PIC);
            IblCPUchoice.Text = "Computer Choise is: " + UpdateTextandImage(computerchoice, CPU_PIC);
            CheckGame();
        }

        private string UpdateTextandImage(string text, PictureBox pic)
        {
            

            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;

            }

            return word;

        }

        private void CheckGame()
        {
            if (computerchoice == playerchoice)
            {
                draw = "Draw!";
            }
            else if (playerchoice == "R" && computerchoice == "P" || playerchoice == "S" && computerchoice == "R" || playerchoice == "P" & computerchoice == "S")
            {
                computerscore++;
                draw = null;
            }
            else
            {
                playerscore++;
                draw = null;
            }

            IblCPUresult.Text = "Computer Score: " + computerscore + Environment.NewLine + draw;
            IblPlayerresult.Text = uname + " Score: " + playerscore + Environment.NewLine + draw;
        }

        private void ViewHistory(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sumit\source\repos\AWP\Rock Paper Scissors .net\RPSdb.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM history WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username1.Text);
            SqlDataReader rd = cmd.ExecuteReader();

            listBox1.Items.Clear();
            listBox1.Items.Add("UserName | Player Choice | Opponent | Opponent Choice | Winner");

            while (rd.Read())
            {
                // Assuming the column order is: username, playerchoice, opponent, computerchoice, winner
                string row = $"{rd["username"]} | {rd["userchoosie"]} | {rd["computer"]} | {rd["compchoosie"]} | {rd["winAndLoss"]}";

                listBox1.Items.Add(row);
            }
            groupBox1.Visible = true;
            con.Close();


        }

        private void play_button(object sender, EventArgs e)
        {
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
        }

        private void pause_button(object sender, EventArgs e)
        {
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;
            if (computerscore > playerscore)
            {
                MessageBox.Show("Winner is Computer", "Winner Status", MessageBoxButtons.OK);
                winner = "Winner is Computer";
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sumit\source\repos\AWP\Rock Paper Scissors .net\RPSdb.mdf"";Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO history VALUES (@username, @playerchoice, 'Computer', @computerchoice, 'Winner is Computer')", con);
                cmd.Parameters.AddWithValue("@username", username1.Text);
                cmd.Parameters.AddWithValue("@playerchoice", playerchoice);
                cmd.Parameters.AddWithValue("@computerchoice", computerchoice);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (playerscore > computerscore)
            {
                MessageBox.Show("Winner is " + uname, "Winner Status", MessageBoxButtons.OK);
                winner = "Winner is "+uname;
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sumit\source\repos\AWP\Rock Paper Scissors .net\RPSdb.mdf"";Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                string win = "Winner is " + username1.Text;
                SqlCommand cmd = new SqlCommand("INSERT INTO history VALUES (@username, @playerchoice, 'Computer', @computerchoice, @win)", con);
                cmd.Parameters.AddWithValue("@username", username1.Text);
                cmd.Parameters.AddWithValue("@playerchoice", playerchoice);
                cmd.Parameters.AddWithValue("@computerchoice", computerchoice);
                cmd.Parameters.AddWithValue("@win", win);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Match is Darw", "Winner Status", MessageBoxButtons.OK);
                winner = "Match is Darw";
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sumit\source\repos\AWP\Rock Paper Scissors .net\RPSdb.mdf"";Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO history VALUES (@username, @playerchoice, @opponent, @computerchoice, @winner)", con);
                cmd.Parameters.AddWithValue("@username", username1.Text);
                cmd.Parameters.AddWithValue("@playerchoice", playerchoice);
                cmd.Parameters.AddWithValue("@opponent", "Computer");
                cmd.Parameters.AddWithValue("@computerchoice", computerchoice);
                cmd.Parameters.AddWithValue("@winner", "Match is Darw");
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void UName_button(object sender, EventArgs e)
        {
            uname = username1.Text;
            playername.Visible = false;
        }

        private void Quit_button(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks You For Playing", "Greating", MessageBoxButtons.OK);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}