#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 1:18 AM
// Last Revised: 02/19/2016 1:18 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Classes {
    using Abstracts;
    using Enums;

    public class ClassConfig : Config {
        public Mercenary Mercenary { get; }

        public new string Name => $"{Mercenary}.cfg".ToLower();

        public ClassConfig(Mercenary mercenary) { Mercenary = mercenary; }
    }
}