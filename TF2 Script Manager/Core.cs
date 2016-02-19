#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 12:40 AM
// Last Revised: 02/19/2016 12:40 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager {
    using Classes;
    using Enums;
    using Services;
    public class Core {
        public static ClassConfig ScoutConfig;
        public static ClassConfig SoldierConfig;
        public static ClassConfig PyroConfig;
        public static ClassConfig DemomanConfig;
        public static ClassConfig HeavyConfig;
        public static ClassConfig EngineerConfig;
        public static ClassConfig MedicConfig;
        public static ClassConfig SniperConfig;
        public static ClassConfig SpyConfig;
        public static string TF2Directory;


        public void SaveAllConfigs()
        {
            ConfigWriter.WriteClassConfigFile(ScoutConfig ?? new ClassConfig(Mercenary.Scout));
            ConfigWriter.WriteClassConfigFile(SoldierConfig);
            ConfigWriter.WriteClassConfigFile(PyroConfig);
            ConfigWriter.WriteClassConfigFile(DemomanConfig);
            ConfigWriter.WriteClassConfigFile(HeavyConfig);
            ConfigWriter.WriteClassConfigFile(EngineerConfig);
            ConfigWriter.WriteClassConfigFile(MedicConfig);
            ConfigWriter.WriteClassConfigFile(SniperConfig);
            ConfigWriter.WriteClassConfigFile(SpyConfig);
        }
    }
}