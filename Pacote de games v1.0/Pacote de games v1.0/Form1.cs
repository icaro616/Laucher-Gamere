using AventStack.ExtentReports.Gherkin.Model;
using Pacote_de_games_v1._0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace Pacote_de_games_v1._0
{
    public partial class Form1 : Form
    {
        private readonly SecureString administrador;

        public Form1()
        {

            InitializeComponent();
            Jogos_v1.Items.Add("Assassin's Creed I");
            Jogos_v1.Items.Add("Assassin's Creed II");
            Jogos_v1.Items.Add("Battlefield 4");
            Jogos_v1.Items.Add("Call of Duty - Black Ops");
            Jogos_v1.Items.Add("Call of Duty Modern Warfare 3");
            Jogos_v1.Items.Add("Devil May Cry 5");
            Jogos_v1.Items.Add("Exo One");
            Jogos_v1.Items.Add("Grand Theft Auto V");
            Jogos_v1.Items.Add("Need for Speed Most Wanted Limited Edition");
            Jogos_v1.Items.Add("Onimusha Warlords");
            

            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var jogo1 = Resources.img1;
            var jogo2 = Resources.img2;
            var jogo3 = Resources.img3;
            var jogo4 = Resources.img4;
            var jogo5 = Resources.img5;
            var jogo6 = Resources.img6;
            var jogo7 = Resources.img7;
            var jogo8 = Resources.img8;
            var jogo9 = Resources.img9;
            var jogo10 = Resources.img10;
            var jogo11 = Resources.img11;

           
            switch (Jogos_v1.Text)
            {
                case "Assassin's Creed I":
                    pictureBox1.Image = Properties.Resources.img1;
                    break;
                case "Assassin's Creed II":
                    pictureBox1.Image = Properties.Resources.img2;
                    break;
                case "Battlefield 4":
                    pictureBox1.Image = Properties.Resources.img3;
                    break;
                case "Call of Duty - Black Ops":
                    pictureBox1.Image = Properties.Resources.img4;
                    break;
                case "Call of Duty Modern Warfare 3":
                    pictureBox1.Image = Properties.Resources.img5;
                    break;
                case "Devil May Cry 5":
                    pictureBox1.Image = Properties.Resources.img6;
                    break;
                case "Exo One":
                    pictureBox1.Image = Properties.Resources.img7;
                    break;
                case "Grand Theft Auto V":
                    pictureBox1.Image = Properties.Resources.img8;
                    break;
                case "Need for Speed Most Wanted Limited Edition":
                    pictureBox1.Image = Properties.Resources.img9;
                    break;
                case "Onimusha Warlords":
                    pictureBox1.Image = Properties.Resources.img10;
                    break;
               
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

    

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var jogo1 = Resources.img1;
            var jogo2 = Resources.img2;
            var jogo3 = Resources.img3;
            var jogo4 = Resources.img4;
            var jogo5 = Resources.img5;
            var jogo6 = Resources.img6;
            var jogo7 = Resources.img7;
            var jogo8 = Resources.img8;
            var jogo9 = Resources.img9;
            var jogo10 = Resources.img10;
            var jogo11 = Resources.img11;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (Jogos_v1.Text)
            {
                case "Assassin's Creed I":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Ubisoft/Assassin's Creed/AssassinsCreed_Game.exe");
                    Application.Exit();
                    break;
                case "Assassin's Creed II":
                    System.Diagnostics.Process.Start("C:/Games/Assassins Creed II/AssassinsCreedIIGame.exe");
                    Application.Exit();
                    break;
                case "Battlefield 4":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Battlefield 4/bf4_x86.exe");
                    Application.Exit();
                    break;
                case "Call of Duty - Black Ops":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Activision/Call of Duty - Black Ops/game1.lnk");
                    Application.Exit();
                    break;
                case "Call of Duty Modern Warfare 3":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Black_Box/Call of Duty Modern Warfare 3/gam2.lnk");
                    Application.Exit();
                    break;
                case "Devil May Cry 5":
                    System.Diagnostics.Process.Start("C:/Games/Devil May Cry 5/game3.lnk");
                    Application.Exit();
                    break;
                case "Exo One":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Exo One/game4.lnk");
                    Application.Exit();
                    break;
                case "Grand Theft Auto V":
                    System.Diagnostics.Process.Start("C:/Games/Grand Theft Auto V/game5.lnk");
                    Application.Exit();
                    break;
                case "Need for Speed Most Wanted Limited Edition":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Need for Speed Most Wanted Limited Edition/game7.lnk");
                    Application.Exit();
                    break;
                case "Onimusha Warlords":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Onimusha Warlords/game8.lnk");
                    Application.Exit();
                    break;
              
            }

        }
    }
}
