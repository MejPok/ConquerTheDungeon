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
using System.Windows.Shapes;
using ConquerTheDungeon.Class;

namespace ConquerTheDungeon.Windows
{
    /// <summary>
    /// Interakční logika pro PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        MainWindow mainWindow;
        Player player;
        public PlayerWindow(MainWindow mainwin)
        {
            InitializeComponent();
            mainWindow = mainwin;
            player = mainwin.player;
            this.DataContext = player;

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Close_PlayerWindow();
        }
    }
}
