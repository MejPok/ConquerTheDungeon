using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConquerTheDungeon.Class;
using ConquerTheDungeon.Windows;

namespace ConquerTheDungeon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Player player;
        public Dungeon dungeon;

        private PlayerWindow playerWindow;
        bool open;

        public MainWindow()
        {
            InitializeComponent();
            player = new Player();
            dungeon = new Dungeon();
            this.DataContext = dungeon;
        }

        private void Open_PlayerWindow(object sender, RoutedEventArgs e)
        {
            if (!open) { 
                playerWindow = new PlayerWindow(this);
                playerWindow.Show();
                open = true;
            }
           
        }
        public void Close_PlayerWindow() { open = false; }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (open)
            {
                playerWindow.Close();
            }
            
        }

        
    }
}