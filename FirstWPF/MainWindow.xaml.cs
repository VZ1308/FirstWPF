using System;
using System.Windows;
using System.Windows.Controls;

namespace FirstWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Überprüfen, ob die Felder leer sind
            if (string.IsNullOrWhiteSpace(txtBox_Name.Text) || string.IsNullOrWhiteSpace(txtbox_age.Text))
            {
                MessageBox.Show("Die Felder dürfen nicht leer sein!");
            }
            else
            {
                // Versuchen, das Alter in eine Zahl zu konvertieren
                if (int.TryParse(txtbox_age.Text, out int age))
                {
                    // Ausgabe erstellen
                    string output = "Herzlich Willkommen " + txtBox_Name.Text + "! Dein Alter ist " + age + " Jahre!";
                    txtblock_output.Text = output;
                }
                else
                {
                    // Fehlermeldung, wenn das Alter keine Zahl ist
                    MessageBox.Show("Das Alter muss eine Zahl sein.");
                }
            }
        }

        
    }
}
