#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 2:40 AM
// Last Revised: 02/19/2016 2:40 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Classes {
    using Abstracts;
    using Enums;

    public class OtherConfig : Config {
        public new string Name => $"{GameSetting}.cfg".ToLower();

        public GameSetting GameSetting { get; }

        public OtherConfig(GameSetting gameSetting) { GameSetting = gameSetting; }
    }
}