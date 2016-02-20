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
using MahApps.Metro.Controls;

namespace TF2_Script_Manager.Windows
{
    using System.ComponentModel;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow {
        public TabItem ActiveAppTab;
        public TabItem ActiveConfigTab;

        public MainWindow()
        {
            InitializeComponent();
            ConfigTabs.SelectedIndex = 0;
        }

        public void DonateButton_OnClick(object sender, RoutedEventArgs e) {
            
        }

        void MainWindow_OnClosing(object sender, CancelEventArgs e) => Application.Current.Shutdown();

        void ConfigTabs_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            switch ( ConfigTabs.SelectedIndex )
            {
                // All Classes (AutoExec)
                case 0:
                    break;
                
                // Scout    
                case 1:
                    break;
                
                // Soldier
                case 2:
                    break;
                
                // Pyro
                case 3:
                    break;
                
                // Demo
                case 4:
                    break;

                // Heavy
                case 5:
                    break;

                // Engi
                case 6:
                    break;

                // Medic
                case 7:
                    break;

                // Sniper
                case 8:
                    break;

                // Spy 
                case 9:
                    break;

                // Graphics
                case 10:
                    break;

                // Settings
                case 11:
                    break;
            }
        }

        void AppTabs_OnSelectionChanged(object sender, SelectionChangedEventArgs e) { }
    }
}
