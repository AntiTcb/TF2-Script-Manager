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
    using System.Threading.Tasks;
    using Abstracts;
    using Enums;
    using Services;

    public sealed class ClassConfig : Config {
        public ControlConfig ControlConfig { get; }

        public new string Name => $"{ControlConfig}.cfg".ToLower();

        public override void Save() => Task.Run(() => ConfigWriter.WriteClassConfigFile(this));

        public ClassConfig(ControlConfig controlConfig) { ControlConfig = controlConfig; }
    }
}