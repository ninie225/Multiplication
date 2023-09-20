using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form1 : Form
    {
        int resultat, numQuestion = 1;
        int note = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void operation()
        {
            // Créer une instance de la classe Random
            Random random = new Random();

            // Générer un nombre aléatoire entre 1 et 9 (inclus)     
            n1.Text= (random.Next(1, 10)).ToString();
            n2.Text = (random.Next(1, 10)).ToString();
        }
        public void actualisation()
        {
            //actualisation du numéro de question ainsi que de la note
            grpQuest.Text = "Question n°" + numQuestion + "/20";
            txtNote.Text = note.ToString();

            //case de saisie du resultat vidée et reprend sa couleur de base
            result.Text = "";
            result.BackColor = Color.White;

            //le label n'affiche plus le résultat de l'opération précédente
            lblOperation.Text= "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            note = 0;
            numQuestion = 1;
            actualisation();
            operation();
            btnSuivant.Enabled = false;
            result.Enabled = true;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            //actualisation du numéro de question et affichage de la nouvelle opération à résoudre
            numQuestion++;
            actualisation();
            operation();
            result.Enabled = true;
            btnSuivant.Enabled = false;

        }

        private void btnRefaire_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            resultat = int.Parse(n1.Text) * int.Parse(n2.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Résultat saisie correct
                if (result.Text.Equals(resultat.ToString()))
                {
                    result.BackColor = Color.Green;
                    note++;
                }
                else //résultat saisie incorrect
                {
                    result.BackColor = Color.Orange;
                }

                //Dans tous les cas, affichage de l'opération et de son résultat
                lblOperation.Text = n1.Text + " x " + n2.Text + " = " + resultat;

                //La case résultat devient indisponible pour ne pas modifier le résultat avant de passer à la question suivante
                result.Enabled = false;

                //btnSuivant disponible si pas à la question 20
                if (numQuestion==20)
                {
                    btnSuivant.Enabled = false;
                }
                else
                {
                    btnSuivant.Enabled = true;
                }    
            }
        }
    }
}
