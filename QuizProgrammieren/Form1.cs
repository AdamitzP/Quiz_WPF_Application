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
        public static Form instance;

       
        // Variablen festlegen 

        int richtigeAntwort;
        int frageNummer = 1;
        int score;
        int prozent;
        int anzahlFragen;
        

        // Anzahl der Fraegn hinzufügen

        public Quiz()
        {
            InitializeComponent();
            instance = this;

            FrageStellen(frageNummer);

            anzahlFragen = 10;
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
                //Prozentsatz einrichten

                prozent = (int)Math.Round((double)(score * 100) / anzahlFragen);

                DialogResult result = MessageBox.Show(
                "Du hast das Ende des Quiz erreicht." + Environment.NewLine + "----------------------------------------------------------------" + 
                Environment.NewLine + "Du hast " + score + "/10 Fragen richtig beantwortet." + Environment.NewLine +
                Environment.NewLine + "Damit hast du " + prozent + "% der Fragen richtig beantwortet." + Environment.NewLine +
                "----------------------------------------------------------------" + Environment.NewLine +
                Environment.NewLine + "Drücke OK um das Quiz erneut zu starten!");
                

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
                    pictureBox1.Image = Properties.Resources.Frage_1;

                    lblfrage.Text = "1. Was gibt dieser Code aus?";

                    button1.Text = "7";
                    button2.Text = "10";
                    button3.Text = "25";
                    button4.Text = "52";

                    richtigeAntwort = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Frage_2;

                    lblfrage.Text = "2. Was gibt dieser Code aus?";

                    button1.Text = "Hallo, Welt!";
                    button2.Text = "text + name";
                    button3.Text = "Hallo,";
                    button4.Text = "Welt!";

                    richtigeAntwort = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Frage_3;

                    lblfrage.Text = "3. Was gibt dieser Code aus?";

                    button1.Text = "15";
                    button2.Text = "10";
                    button3.Text = "5";
                    button4.Text = "zahl += 5;";

                    richtigeAntwort = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Frage_4;

                    lblfrage.Text = "4. Was gibt dieser Code aus?";

                    button1.Text = "true";
                    button2.Text = "false";
                    button3.Text = "istWahr";
                    button4.Text = "!istWahr";

                    richtigeAntwort = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Frage_5;

                    lblfrage.Text = "5. Was gibt dieser Code aus?";

                    button1.Text = "3";
                    button2.Text = "2";
                    button3.Text = "1";
                    button4.Text = "4";

                    richtigeAntwort = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Frage_6;

                    lblfrage.Text = "6. Was gibt dieser Code aus?";

                    button1.Text = "Die Zahl ist größer als 5.";
                    button2.Text = "Die Zahl ist nicht größer als 5.";
                    button3.Text = "true";
                    button4.Text = "false";

                    richtigeAntwort = 1;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Frage_7;

                    lblfrage.Text = "7. Was gibt dieser Code aus?";

                    button1.Text = "5 4 3 2 1";
                    button2.Text = "0 1 2 3 4";
                    button3.Text = "1 2 3 4";
                    button4.Text = "1 2 3 4 5";

                    richtigeAntwort = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Frage_8;

                    lblfrage.Text = "8. Was gibt dieser Code aus?";

                    button1.Text = "Eins";
                    button2.Text = "zahl";
                    button3.Text = "Acht";
                    button4.Text = "Keine Übereinstimmung";

                    richtigeAntwort = 3;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.Frage_9;

                    lblfrage.Text = "9. Was gibt dieser Code aus?";

                    button1.Text = "0 1 2 3";
                    button2.Text = "0 1 2";
                    button3.Text = "3 2 1 0";
                    button4.Text = "0 1 2 3 4";

                    richtigeAntwort = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.Frage_10;

                    lblfrage.Text = "10. Was gibt dieser Code aus?";

                    button1.Text = "Blau Grün Rot";
                    button2.Text = "Rot, Grün, Blau";
                    button3.Text = "Rot Grün Blau";
                    button4.Text = "farben[0] farben[1] farben[2]";

                    richtigeAntwort = 3;

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
