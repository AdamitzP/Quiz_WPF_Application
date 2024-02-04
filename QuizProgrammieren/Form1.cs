using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizProgrammieren
{
    public partial class Quiz : Form
    {

        // Test
        // Fragen: Variablen


        int richtigeAntwort;
        int frageNummer = 1;
        int score;
        int prozent;
        int anzahlFragen;
        

        public Quiz()
        {
            InitializeComponent();

            FrageStellen(frageNummer);

            anzahlFragen = 4;
        }

        private void lblfrage_Click(object sender, EventArgs e)
        {

        }

        private void AntwortenPrüfen(object sender, EventArgs e)
        {
            var senderObject  = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == richtigeAntwort)
            {
                score++;
            }

            if(frageNummer == anzahlFragen)
            {
                //Prozentsatz

                prozent = (int)Math.Round((double)(score * 100) / anzahlFragen);

                MessageBox.Show(
                    "Du hast das Ende des Quiz erreicht." + Environment.NewLine + 
                    Environment.NewLine + "Du hast " + score + "/4 Fragen richtig beantwortet." + Environment.NewLine + 
                    Environment.NewLine + "Damit hast du " + prozent + "% der Fragen richtig beantwortet." + Environment.NewLine +
                    Environment.NewLine + "Drücke OK um das Quiz erneut zu starten!"
                    );

                score = 0;
                frageNummer = 0;
                FrageStellen(frageNummer);
            }


            frageNummer++;
            FrageStellen(frageNummer);

        }
        private void FrageStellen(int FrageNummer)
        {

            switch(FrageNummer)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.images;

                    lblfrage.Text = "1. Frage = A";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    richtigeAntwort = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.images;

                    lblfrage.Text = "2. Frage = B";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    richtigeAntwort = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.images;

                    lblfrage.Text = "3. Frage = C";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    richtigeAntwort = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images;

                    lblfrage.Text = "4. Frage = D";

                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Text = "C";
                    button4.Text = "D";

                    richtigeAntwort = 4;

                    break;
            }



        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
