#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 4:25 AM
// Last Revised: 02/19/2016 4:25 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Services {
    using Classes;

    public static class DefaultBinds {
        public static Bind ToggleConsole { get; } = new Bind("'", "toggleconsole");
        public static Bind MoveForward { get; } = new Bind("w", "+forward");
        public static Bind MoveBackward { get; } = new Bind("s", "+back");
        public static Bind MoveLeft { get; } = new Bind("a", "+moveleft");
        public static Bind MoveRight { get; } = new Bind("d", "+moveright");
        public static Bind Strafe { get; } = new Bind("ALT", "+strafe");
        public static Bind Jump { get; } = new Bind("SPACE", "+jump");
        public static Bind Duck { get; } = new Bind("CTRL", "+duck");
        public static Bind ScoreBoard { get; } = new Bind("TAB", "+showscores");
        public static Bind SwimUp { get; } = new Bind("'", "+moveup");
        public static Bind SwimDown { get; } = new Bind("/", "+movedown");
        public static Bind LookUp { get; } = new Bind("PGUP", "+lookup");
        public static Bind LookDown { get; } = new Bind("PGDN", "+lookdown");
        public static Bind CenterView { get; } = new Bind("END", "centerview");
        public static Bind Voice { get; } = new Bind("v", "+voicerecord");
        public static Bind AllChat { get; } = new Bind("y", "say");
        public static Bind TeamChat { get; } = new Bind("u", "say_team");
        public static Bind VoiceMenu1 { get; } = new Bind("z", "voice_menu_1");
        public static Bind VoiceMenu2 { get; } = new Bind("x", "voice_menu_2");
        public static Bind VoiceMenu3 { get; } = new Bind("c", "voice_menu_3");
        public static Bind CallMedic { get; } = new Bind("e", "voicemenu 0 0");
        public static Bind Reload { get; } = new Bind("r", "+reload");
        public static Bind Mouse1 { get; } = new Bind("MOUSE1", "+attack");
        public static Bind Mouse2 { get; } = new Bind("MOUSE2", "+attack2");
        public static Bind Mouse3 { get; } = new Bind("MOUSE3", "+attack3");
        public static Bind DropIntel { get; } = new Bind("l", "dropitem");
        public static Bind PrimaryWeapon { get; } = new Bind("1", "slot1");
        public static Bind SecondaryWeapon { get; } = new Bind("2", "slot2");
        public static Bind MeleeWeapon { get; } = new Bind("3", "slot3");
        public static Bind CreateBuildingOrDisguise { get; } = new Bind("4", "slot4");
        public static Bind DestroyBuilding { get; } = new Bind("5", "slot5");
        public static Bind GrapplingHook { get; } = new Bind("6", "slot6");
        public static Bind WeaponCategory7 { get; } = new Bind("7", "slot7");
        public static Bind WeaponCategory8 { get; } = new Bind("8", "slot8");
        public static Bind WeaponCategory9 { get; } = new Bind("9", "slot9");
        public static Bind WeaponCategory10 { get; } = new Bind("0", "slot10");
        public static Bind MouseUp { get; } = new Bind("MWHEELUP", "invprev");
        public static Bind MouseDown { get; } = new Bind("MWHEELDOWN", "invnext");
        public static Bind LastWeapon { get; } = new Bind("q", "lastinv");
        public static Bind ShowContracts { get; } = new Bind("F2", "show_quest_log");
        public static Bind MVMToggle { get; } = new Bind("F4", "player_ready_toggle");
        public static Bind Screenshot { get; } = new Bind("F5", "screenshot");
        public static Bind SaveReplay { get; } = new Bind("F6", "save_replay");
        public static Bind ReportAbuse { get; } = new Bind("F7", "abuse_report_queue");
        public static Bind Quit { get; } = new Bind("F10", "quit prompt");
        public static Bind ToggleReplayTips { get; } = new Bind("F12", "replay_togglereplaytips");
        public static Bind Spray { get; } = new Bind("t", "impulse 201");
        public static Bind AcceptRequest { get; } = new Bind("j", "cl_trigger_first_notification");
        public static Bind DeclineRequest { get; } = new Bind("k", "cl_decline_first_notification");
        public static Bind Pause { get; } = new Bind("PAUSE", "pause");
        public static Bind Escape { get; } = new Bind("ESCAPE", "escape");
        public static Bind ChangeTeam { get; } = new Bind(".", "changeteam");
        public static Bind ChangeClass { get; } = new Bind(",", "changeclass");
        public static Bind TauntMenu { get; } = new Bind("g", "+taunt");
        public static Bind UseItem { get; } = new Bind("h", "+use_action_slot_item");
        public static Bind LastDisguise { get; } = new Bind("b", "lastdisguise");
        public static Bind ShowMapInfo { get; } = new Bind("i", "showmapinfo");
        public static Bind ChangeDisguiseTeam { get; } = new Bind("-", "disguiseteam");
        public static Bind OpenCharacterInfo { get; } = new Bind("m", "open_charinfo_direct");
        public static Bind OpenBackpack { get; } = new Bind("n", "open_charinfo_backpack");
        public static Bind InspectWeapon { get; } = new Bind("f", "+inspect");
    }
}