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

namespace TF2_Script_Manager.Windows
{
    using Classes;

    /// <summary>
    /// Interaction logic for KeyBindDialog.xaml
    /// </summary>
    public partial class KeyBindDialog {
        Dictionary< string, string > DefaultCommands = new Dictionary< string, string > { {"Unbound", string.Empty} };
        Button key { get; }

        public KeyBindDialog(Button keyButton) {
            key = keyButton;
            InitializeComponent();
            KeyLabel.Content = key.Content;
            DefaultCommandCB.ItemsSource = DefaultCommands.Keys;

            // Load default commands

            if ( !Core.ActiveConfig.Keybinds.BoundKeys.Contains(key.Tag) ) { return; }
            CustomRB.IsChecked = true;
            CustomCommandTB.Text = Core.ActiveConfig.Keybinds[ key.Tag.ToString() ].Command;
        }

        public void Unbind_Click(object sender, RoutedEventArgs e) {
            DefaultCommandCB.SelectedIndex = 0;
            Core.ActiveConfig.Keybinds.Unbind(key.Tag.ToString());
            Core.ActiveConfig.Save();
        }

        public void Save_Click(object sender, RoutedEventArgs e) {
            var newBind = new Bind(key.Tag.ToString(), DefaultRB.IsChecked != null && (bool)DefaultRB.IsChecked ? DefaultCommandCB.SelectedValue.ToString() : CustomCommandTB.Text);
            Core.ActiveConfig.Keybinds.Bind(key.Tag.ToString(), newBind);
            Core.ActiveConfig.Save();
            Close();
        }

        public void Cancel_Click(object sender, RoutedEventArgs e) => Close();
    }
}
