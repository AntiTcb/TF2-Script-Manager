using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace TF2_Script_Manager.Windows
{
    using System.ComponentModel;
    using PropertyChanged;
    using Services;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [ImplementPropertyChanged]
    public partial class MainWindow : MetroWindow {
        public static string ActiveAppTab { get; set; } = "";
        public static string ActiveConfigTab { get; set; } = "";
        public string WinTitle { get; } = $"TF2 Script Manager - {ActiveAppTab} - {ActiveConfigTab}";

        public MainWindow()
        {
            InitializeComponent();
            ConfigTabs.SelectedIndex = 0;
        }

        public void DonateButton_OnClick(object sender, RoutedEventArgs e) {

        }

        void MainWindow_OnClosing(object sender, CancelEventArgs e) {
            Core.SaveAllConfigs();
            AppSettings.SaveBackup(Core.Settings);
            Application.Current.Shutdown();
        }

        void ConfigTabs_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            ActiveConfigTab = ( (TabItem) ConfigTabs.SelectedItem).Header.ToString();
            if (Core.IsInititalized) { Core.ActiveConfig.Save();}
            switch ( ConfigTabs.SelectedIndex )
            {
                // All Classes (AutoExec)
                case 0:
                    Core.ActiveConfig = Core.DefaultConfig;
                    break;

                // Scout    
                case 1:
                    Core.ActiveConfig = Core.ScoutConfig;
                    break;
                // Soldier
                case 2:
                    Core.ActiveConfig = Core.SoldierConfig;
                    break;
                // Pyro
                case 3:
                    Core.ActiveConfig = Core.PyroConfig;
                    break;

                // Demo
                case 4:
                    Core.ActiveConfig = Core.DemomanConfig;
                    break;

                // Heavy
                case 5:
                    Core.ActiveConfig = Core.HeavyConfig;
                    break;

                // Engi
                case 6:
                    Core.ActiveConfig = Core.EngineerConfig;
                    break;

                // Medic
                case 7:
                    Core.ActiveConfig = Core.MedicConfig;
                    break;

                // Sniper
                case 8:
                    Core.ActiveConfig = Core.SniperConfig;
                    break;

                // Spy 
                case 9:
                    Core.ActiveConfig = Core.SpyConfig;
                    break;
            }
            KeybindsKeyboard.SetButtonBinds();
        }

        void AppTabs_OnSelectionChanged(object sender, SelectionChangedEventArgs e) { }
    }
}
