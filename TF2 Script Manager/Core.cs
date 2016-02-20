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
    using System;
    using System.IO;
    using Windows;
    using Classes;
    using Enums;
    using Services;
    public static class Core {
        public static MainWindow MainWindow { get; set; }

        public static ClassConfig ScoutConfig { get; set; }
        public static ClassConfig SoldierConfig { get; set; }
        public static ClassConfig PyroConfig { get; set; }
        public static ClassConfig DemomanConfig { get; set; }
        public static ClassConfig HeavyConfig { get; set; }
        public static ClassConfig EngineerConfig { get; set; }
        public static ClassConfig MedicConfig { get; set; }
        public static ClassConfig SniperConfig { get; set; }
        public static ClassConfig SpyConfig { get; set; }
        public static OtherConfig GraphicsConfig { get; set; }
        public static OtherConfig AutoExecConfig { get; set; }
        public static OtherConfig SettingsConfig { get; set; }

        public static KeybindingCollection ActiveBinds { get; set; }

        public static AppSettings Settings { get; set; }


        public static void Initialize() {
            // Check Settings File for TF2 Directory
            if ( File.Exists(AppSettings.AppDataPath + @"\settings.ini") )
            {
                if ( string.IsNullOrEmpty(Settings.TF2Directory) )
                {
                    // Prompt for TF2 Directory
                }
                if ( !Directory.Exists(Settings.TF2Directory + @"\cfg") )
                {
                    // Prompt for TF2 Directory
                }
            }
            MainWindow = new MainWindow();
           //LoadConfigs();
            MainWindow.Show();
        }

        public static async void LoadConfigs() {
            ScoutConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/scout.cfg", Mercenary.Scout);
            SoldierConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/soldier.cfg", Mercenary.Soldier);
            PyroConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/pyro.cfg", Mercenary.Pyro);
            DemomanConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/demoman.cfg", Mercenary.Demoman);
            HeavyConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/heavyweapons.cfg", Mercenary.Heavyweapons);
            EngineerConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/engineer.cfg", Mercenary.Engineer);
            MedicConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/medic.cfg", Mercenary.Medic);
            SniperConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/sniper.cfg", Mercenary.Sniper);
            SpyConfig = await ConfigReader.ReadClassConfig($"{Settings.TF2Directory}/cfg/spy.cfg", Mercenary.Spy);
            GraphicsConfig = await ConfigReader.ReadGraphicsConfig($"{Settings.TF2Directory}/cfg/gfx.cfg");
            SettingsConfig = await ConfigReader.ReadSettingsConfig($"{Settings.TF2Directory}/cfg/settings.cfg");
            AutoExecConfig = await ConfigReader.ReadAutoExecConfig($"{Settings.TF2Directory}/cfg/autoexec.cfg");
        }


        public static void SaveAllConfigs()
        {
            ConfigWriter.WriteClassConfigFile(ScoutConfig ?? new ClassConfig(Mercenary.Scout));
            ConfigWriter.WriteClassConfigFile(SoldierConfig ?? new ClassConfig(Mercenary.Soldier));
            ConfigWriter.WriteClassConfigFile(PyroConfig ?? new ClassConfig(Mercenary.Pyro));
            ConfigWriter.WriteClassConfigFile(DemomanConfig ?? new ClassConfig(Mercenary.Demoman));
            ConfigWriter.WriteClassConfigFile(HeavyConfig ?? new ClassConfig(Mercenary.Heavyweapons));
            ConfigWriter.WriteClassConfigFile(EngineerConfig ?? new ClassConfig(Mercenary.Engineer));
            ConfigWriter.WriteClassConfigFile(MedicConfig ?? new ClassConfig(Mercenary.Medic));
            ConfigWriter.WriteClassConfigFile(SniperConfig ?? new ClassConfig(Mercenary.Sniper));
            ConfigWriter.WriteClassConfigFile(SpyConfig ?? new ClassConfig(Mercenary.Spy));
            ConfigWriter.WriteOtherConfigFile(GraphicsConfig ?? new OtherConfig(GameSetting.Graphics));
            ConfigWriter.WriteOtherConfigFile(SettingsConfig ?? new OtherConfig(GameSetting.Settings));
            ConfigWriter.WriteOtherConfigFile(AutoExecConfig ?? new OtherConfig(GameSetting.AutoExec));
        }

        public static class Windows {
            

        }
    }
}