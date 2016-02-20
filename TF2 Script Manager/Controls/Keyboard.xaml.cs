﻿using System;
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

    /// <summary>
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class Keyboard : UserControl
    {
        public Keyboard()
        {
            InitializeComponent();
            AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(button_Click));
            var buttons = new List< Button >();
            foreach ( var ctrl in MainGrid.Children )
            {
                if (ctrl is Button) { buttons.Add((Button)ctrl);
                    continue;
                }

                if ( ctrl is Grid ) { buttons.AddRange(((Grid) ctrl ).Children.OfType< Button >());
                    continue;
                }

                var panel = ctrl as StackPanel;
                if (panel != null) { buttons.AddRange(panel.Children.OfType<Button>());}

            }
            foreach ( var btn in buttons ) { btn.ToolTip = btn.Tag; }
        }

        public static void button_Click(object sender, RoutedEventArgs e) => MessageBox.Show(( (Button)e.OriginalSource ).ToolTip?.ToString());
    }
}