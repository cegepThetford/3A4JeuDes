using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JeuDes_Affaires;

namespace JeuDes_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainDes _mainDes;
        private PartieDes _partieDes;
        private List<CheckBox> _lstEtatsDe;
        private List<Image> _lstImagesDe;
        public MainWindow()
        {
            InitializeComponent();
            // creer la main et la partie (2 tours)
            // collections pour les images et les cases a cocher

            // brasser la main

            this.afficherDes();

            // aviser la partie du score de la main

            this.afficherStats();
        }

        private void afficherDes()
        {
            // new BitmapImage(new Uri("pack://application:,,,/" + 2 + ".png"));
            // a completer
        }
        private void afficherStats()
        {
            // a completer: afficher score courant, le meilleur score et le numero du tour
        }

        private void BtnLancer_Click(object sender, RoutedEventArgs e)
        {
            if (_partieDes.estTerminee())
            {
                btnLancer.Content = "Lancer les dés";
                // demarrer une nouvelle partie
                // liberer les des de la main
                // enlever les coches des cases a cocher
            }
            else
                _partieDes.incrementerTourJoue();

            // brasser la main

            this.afficherDes();

            // aviser la partie du score de la main

            this.afficherStats();

            if (_partieDes.estTerminee())
                btnLancer.Content = "Rejouer une partie?";
        }



    }
}