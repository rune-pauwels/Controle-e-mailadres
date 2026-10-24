using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Controle_e_mailadres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Functie 1======

*1. Invoer: Welke invoer mag je verwachten voor jouw controlefunctie? Geef zowel een naam/beschrijving als een datatype.
        een email adres
*
*2. Bewerking: Hoe ga je bepalen of de invoer correct is qua vorm? Welke ingebouwde methodes heb je daarvoor nodig en hoe ga je deze gebruiken om de voorwaarden te controleren?
        via een regex
*       ^[^@]+@[^@.]{3,}\.[^@.]{2,}$

*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
        een true of false 
*

*4. Naamgeving: Welke naam ga je deze functie geven?
        CorrectEmailAdres
*
*5. Testdata: Voorzie zeker 2 goed gekozen testvoorbeelden!
        ruben@gmail.com - true
        a@123.nl - true
        @abc.nl - false
        a@abc.n - false
        user@abc - false
        user.abc.nl - false 
*

*===================================*/


        private void ControleerButton_Click(object sender, EventArgs e)
        {
            string emailAddress = Convert.ToString(EmailAdresTextBox.Text);
            bool IsCorrecteEmail = CorrectEmailAdres(emailAddress);
            if (IsCorrecteEmail)
            {
                MessageBox.Show("Dit is een correcte E-mail.", "E-mail controle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dit is geen correcte E-mail.", "E-mail controle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CorrectEmailAdres(string emailAddress)
        {
            string EmailPatroon = @"^[^@]+@[^@.]{3,}\.[^@.]{2,}$";
            return Regex.IsMatch(emailAddress, EmailPatroon);
        }
    }
}
