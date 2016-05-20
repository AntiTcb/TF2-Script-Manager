#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/21/2016 11:21 AM
// Last Revised: 05/12/2016 5:05 PM
// Last Revised by: Alex Gravely

#endregion

namespace TF2_Script_Manager.Windows {
    #region Using

    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;

    #endregion

    /// <summary>
    ///     Interaction logic for KeyBindDialog.xaml
    /// </summary>
    public partial class KeyBindDialog {
        #region Private Fields + Properties

        public Button Key { get; }
        Dictionary< string, string > DefaultCommands;

        #endregion Private Fields + Properties

        #region Public Constructors

        public KeyBindDialog(Button keyButton) {
            Key = keyButton;
            InitializeComponent();
            KeyLabel.Content = Key.Content;

            // Load default commands
            GenerateDefaultCommands();
            DefaultCommandCB.ItemsSource = DefaultCommands.Keys;
            if ( !Core.ActiveConfig.Keybinds.BoundKeys.Contains(Key.Tag) ) { return; }
            CustomRB.IsChecked = true;
            CustomCommandTB.Text = Core.ActiveConfig.Keybinds[ Key.Tag.ToString() ].Command;
        }

        #endregion Public Constructors

        #region Public Methods

        public void Cancel_Click(object sender, RoutedEventArgs e) => Close();

        public void Save_Click(object sender, RoutedEventArgs e)
        {
            ChangeKeybind();
            Core.ActiveConfig.Save();
            Close();
        }

        void ChangeKeybind()
        {
            if ((bool)DefaultRB.IsChecked)
            {
                if (DefaultCommandCB.SelectedIndex == 0) { Core.ActiveConfig.Keybinds.Unbind(Key.Tag.ToString()); }
                Core.ActiveConfig.Keybinds[Key.Tag.ToString()].Command =
                    DefaultCommands[(string)DefaultCommandCB.SelectedItem];
            }
            else
            {
                Core.ActiveConfig.Keybinds[Key.Tag.ToString()].Command = CustomCommandTB.Text;
                Key.ToolTip = CustomCommandTB.Text;
            }
        }

        public void Unbind_Click(object sender, RoutedEventArgs e) {
            DefaultCommandCB.SelectedIndex = 0;
            Core.ActiveConfig.Keybinds.Unbind(Key.Tag.ToString());
            Core.ActiveConfig.Save();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Generates the default commands for TF2.
        /// </summary>
        void GenerateDefaultCommands() {
            var defaultCommands = new Dictionary< string, string > {
                                                                       { "Unbound", string.Empty }, {
                                                                                                        "Accept Request",
                                                                                                        "cl_trigger_first_notification"
                                                                                                    }, {
                                                                                                           "Decline Request",
                                                                                                           "cl_decline_first_notification"
                                                                                                       },
                                                                       { "Chat (All)", "say" },
                                                                       { "Chat (Team)", "say_team" },
                                                                       { "Call Medic", "voicemenu 0 0" },
                                                                       { "Center View", "centerview" },
                                                                       { "Change Class", "changeclass" },
                                                                       { "Change Team", "changeteam" },
                                                                       { "Change Disguise Team Color", "disguiseteam" },
                                                                       { "Drop Intelligence", "dropitem" },
                                                                       { "Duck", "+duck" },
                                                                       { "Escape", "escape" },
                                                                       { "Inspect Weapon", "+inspect" },
                                                                       { "Jump", "+jump" },
                                                                       { "Last Disguise", "lastdisguise" },
                                                                       { "Look Up", "+lookup" },
                                                                       { "Last Weapon", "lastinv" },
                                                                       { "Look Down", "+lookdown" }, {
                                                                                                         "Mann vs. Machine Ready", "player_ready_toggle"
                                                                                                     },
                                                                       { "Move Forward", "+forward" },
                                                                       { "Move Backward", "+back" },
                                                                       { "Move Left", "+left" },
                                                                       { "Move Right", "+right" },
                                                                       { "Next Weapon", "invnext" },
                                                                       { "Open Backpack", "+forward" },
                                                                       { "Open Character Info", "+forward" },
                                                                       { "Pause", "pause" },
                                                                       { "Primary Attack", "+attack" },
                                                                       { "Secondary Attack", "+attack2" },
                                                                       { "Special Attack", "attack+3" },
                                                                       { "Quit", "quit prompt" },
                                                                       { "Reload", "+reload" },
                                                                       { "Report Abuse", "abuse_report_queue" },
                                                                       { "Save Replay", "save_replay" },
                                                                       { "Show Contracts", "show_quest_log" },
                                                                       { "Show Scoreboard", "+showscores" },
                                                                       { "Show Map Info", "showmapinfo" },
                                                                       { "Spray Logo", "impulse 201" },
                                                                       { "Strafe", "+strafe" },
                                                                       { "Swim Up", "+moveup" },
                                                                       { "Swim Down", "+movedown" },
                                                                       { "Switch to Primary Weapon", "slot1" },
                                                                       { "Switch to Secondary Weapon", "slot2" },
                                                                       { "Switch to Melee Weapon", "slot3" }, {
                                                                                                                  "Switch to Construction PDA / Disguise Kit",
                                                                                                                  "slot4"
                                                                                                              },
                                                                       { "Switch to Destruction PDA", "slot5" },
                                                                       { "Switch to Grappling Hook", "slot6" },
                                                                       { "Switch to Weapon Slot 7", "slot7" },
                                                                       { "Switch to Weapon Slot 8", "slot8" },
                                                                       { "Switch to Weapon Slot 9", "slot9" },
                                                                       { "Switch to Weapon Slot 10", "slot10" },
                                                                       { "Take Screenshot", "screenshot" },
                                                                       { "Taunt Menu", "+taunt" },
                                                                       { "Toggle Console", "toggleconsole" }, {
                                                                                                                  "Toggle Replay Tips", "replay_togglereplaytips"
                                                                                                              },
                                                                       { "Use Item", "+use_action_slot_item" },
                                                                       { "Voice Communicate", "+voicerecord" },
                                                                       { "Voice Menu 1", "voice_menu_1" },
                                                                       { "Voice Menu 2", "voice_menu_2" },
                                                                       { "Voice Menu 3", "voice_menu_3" }
                                                                   };

            DefaultCommands = defaultCommands;
        }

        #endregion Private Methods
    }
}