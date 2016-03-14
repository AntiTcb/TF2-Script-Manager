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

namespace TF2_Script_Manager.Controls
{
    using System.Windows.Controls.Primitives;
    using Windows;
    using MahApps.Metro.Controls;
    using MahApps.Metro.Controls.Dialogs;

    /// <summary>
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class Keyboard : UserControl
    {
        List<Button> Buttons = new List< Button >();
        public Keyboard()
        {
            InitializeComponent();
            AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(button_Click));
            foreach ( var ctrl in MainGrid.Children )
            {
                if (ctrl is Button) { Buttons.Add((Button)ctrl);
                    continue;
                }

                if ( ctrl is Grid ) { Buttons.AddRange(((Grid) ctrl ).Children.OfType< Button >());
                    continue;
                }

                var panel = ctrl as StackPanel;
                if (panel != null) { Buttons.AddRange(panel.Children.OfType<Button>());}

            }
        }

        public void SetButtonBinds() {
            foreach ( var btn in Buttons )
            {
                var isDefaultBind = Core.DefaultConfig.Keybinds.BoundKeys.Contains(btn.Tag);
                var isSpecificBind = Core.ActiveConfig.Keybinds.BoundKeys.Contains(btn.Tag);

                if ( !isDefaultBind &&
                     !isSpecificBind )
                {
                    btn.ToolTip = null;
                    btn.Background = Brushes.White;
                    continue;
                }
                if (isSpecificBind)
                {
                    btn.ToolTip = Core.ActiveConfig.Keybinds[btn.Tag.ToString()].Command;
                    btn.Background = Brushes.Green;
                    continue;
                }
                btn.ToolTip = Core.DefaultConfig.Keybinds[ btn.Tag.ToString() ].Command;
                btn.Background = Brushes.Gold;
            }
        }

        public static void button_Click(object sender, RoutedEventArgs e) {
            var bindDialog = new KeyBindDialog((Button)e.OriginalSource);
            bindDialog.ShowDialog();
        }
    }
}
