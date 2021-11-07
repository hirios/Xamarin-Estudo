using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;



namespace frameAction
{    
    public partial class MainPage : ContentPage
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "hunterxhunter.txt");

        public MainPage()
        {
            
            InitializeComponent();
        }

        async void NextPage()
        {
            await Navigation.PushAsync(new Page1());
        }

        public void GRAVAR(object sender, EventArgs e)
        {
            string STR = ENTRADA.Text;       
            File.WriteAllText(fileName, STR);
            NextPage();

        }

        public void LEITURA(object sender, EventArgs e)
        {
            bool Exist = File.Exists(fileName);

            if (Exist)
            {
                SAIDA.Text = File.ReadAllText(fileName);
            }
        }

    }
}
