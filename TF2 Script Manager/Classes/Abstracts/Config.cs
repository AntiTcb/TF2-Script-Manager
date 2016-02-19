#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 1:10 AM
// Last Revised: 02/19/2016 1:10 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Classes.Abstracts {
    using System.Collections.Generic;
    using PropertyChanged;
    using Services;

    [ImplementPropertyChanged]
    public abstract class Config {

        public string Name { get; set; }
        public string FileName => "";
        public List<string> Execs { get; set; }
        public List<Alias> Aliases { get; set; }
        public List<Bind> Binds { get; set; }
        public KeybindingCollection Keybinds { get; set; }

        public void SetDefaultKeybinds() {
            foreach ( var item in Keybinds ) { Keybinds[ item.Key ] = null; }

            Keybinds.Bind("-", DefaultBinds.ChangeDisguiseTeam);
            Keybinds.Bind(",", DefaultBinds.ChangeClass);
            Keybinds.Bind(".", DefaultBinds.ChangeTeam);
            Keybinds.Bind("`", DefaultBinds.ToggleConsole);
            Keybinds.Bind("a", DefaultBinds.MoveLeft);
            Keybinds.Bind("b", DefaultBinds.LastDisguise);
            Keybinds.Bind("c", DefaultBinds.VoiceMenu3);
            Keybinds.Bind("d", DefaultBinds.MoveRight);
            Keybinds.Bind("e", DefaultBinds.CallMedic);
            Keybinds.Bind("f", DefaultBinds.InspectWeapon);
            Keybinds.Bind("g", DefaultBinds.TauntMenu);
            Keybinds.Bind("h", DefaultBinds.UseItem);
            Keybinds.Bind("i", DefaultBinds.ShowMapInfo);
            Keybinds.Bind("j", DefaultBinds.AcceptRequest);
            Keybinds.Bind("k", DefaultBinds.DeclineRequest);
            Keybinds.Bind("l", DefaultBinds.DropIntel);
            Keybinds.Bind("m", DefaultBinds.OpenCharacterInfo);
            Keybinds.Bind("n", DefaultBinds.OpenBackpack);
            Keybinds.Bind("q", DefaultBinds.LastWeapon);
            Keybinds.Bind("r", DefaultBinds.Reload);
            Keybinds.Bind("s", DefaultBinds.MoveBackward);
            Keybinds.Bind("t", DefaultBinds.Spray);
            Keybinds.Bind("u", DefaultBinds.TeamChat);
            Keybinds.Bind("v", DefaultBinds.Voice);
            Keybinds.Bind("w", DefaultBinds.MoveForward);
            Keybinds.Bind("x", DefaultBinds.VoiceMenu2);
            Keybinds.Bind("y", DefaultBinds.AllChat);
            Keybinds.Bind("z", DefaultBinds.VoiceMenu1);

            Keybinds.Bind("1", DefaultBinds.PrimaryWeapon);
            Keybinds.Bind("2", DefaultBinds.SecondaryWeapon);
            Keybinds.Bind("3", DefaultBinds.MeleeWeapon);
            Keybinds.Bind("4", DefaultBinds.CreateBuildingOrDisguise);
            Keybinds.Bind("5", DefaultBinds.DestroyBuilding);
            Keybinds.Bind("6", DefaultBinds.GrapplingHook);
            Keybinds.Bind("7", DefaultBinds.WeaponCategory7);
            Keybinds.Bind("8", DefaultBinds.WeaponCategory8);
            Keybinds.Bind("9", DefaultBinds.WeaponCategory9);
            Keybinds.Bind("0", DefaultBinds.WeaponCategory10);

            Keybinds.Bind("F2", DefaultBinds.ShowContracts);
            Keybinds.Bind("F4", DefaultBinds.MVMToggle);
            Keybinds.Bind("F5", DefaultBinds.Screenshot);
            Keybinds.Bind("F6", DefaultBinds.SaveReplay);
            Keybinds.Bind("F7", DefaultBinds.ReportAbuse);
            Keybinds.Bind("F10", DefaultBinds.Quit);
            Keybinds.Bind("F12", DefaultBinds.ToggleReplayTips);

            Keybinds.Bind("MWHEELUP", DefaultBinds.MouseUp);
            Keybinds.Bind("MWHEELDOWN", DefaultBinds.MouseDown);
            Keybinds.Bind("MOUSE1", DefaultBinds.Mouse1);
            Keybinds.Bind("MOUSE2", DefaultBinds.Mouse2);
            Keybinds.Bind("MOUSE3", DefaultBinds.Mouse3);

            Keybinds.Bind("'", DefaultBinds.SwimUp);
            Keybinds.Bind("/", DefaultBinds.SwimDown);
            Keybinds.Bind("ALT", DefaultBinds.Strafe);
            Keybinds.Bind("CTRL", DefaultBinds.Duck);
            Keybinds.Bind("END", DefaultBinds.CenterView);
            Keybinds.Bind("ESCAPE", DefaultBinds.Escape);
            Keybinds.Bind("PAUSE", DefaultBinds.Pause);
            Keybinds.Bind("PDDN", DefaultBinds.LookDown);
            Keybinds.Bind("PGUP", DefaultBinds.LookUp);
            Keybinds.Bind("SPACE", DefaultBinds.Jump);
            Keybinds.Bind("TAB", DefaultBinds.ScoreBoard);
        }
    }
}