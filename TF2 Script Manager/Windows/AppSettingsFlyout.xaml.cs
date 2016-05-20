using System;
using System.Windows.Input;
using TF2_Script_Manager.Services;

namespace TF2_Script_Manager.Windows
{
    /// <summary>
    /// Interaction logic for AppSettings.xaml
    /// </summary>
    public partial class AppSettingsFlyout
    {
        public AppSettingsFlyout()
        {
            InitializeComponent();
            TFPath.Text = Core.Settings.TF2Directory ?? string.Empty;
        }



        public void OpenFileDialog(object sender, MouseButtonEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if ( dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK ) { return; }
            Core.Settings.TF2Directory = dialog.SelectedPath;
            AppSettings.Save(Core.Settings);
            TFPath.Text = Core.Settings.TF2Directory ?? string.Empty;
        }
    }
}
