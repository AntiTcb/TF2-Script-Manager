#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 12:40 AM
// Last Revised: 02/21/2016 9:43 AM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager {
    #region Using

    using System;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Windows;
    using Classes;
    using Classes.Abstracts;
    using Enums;
    using Services;

    #endregion

    public static class Core {
        #region Public Structs + Classes

        public static class Windows { }

        #endregion Public Structs + Classes

        #region Public Fields + Properties

        public static Config ActiveConfig { get; set; }

        public static ClassConfig DefaultConfig { get; set; }
        public static ClassConfig DemomanConfig { get; set; }
        public static ClassConfig EngineerConfig { get; set; }
        public static ClassConfig HeavyConfig { get; set; }
        public static MainWindow MainWindow { get; set; }

        public static ClassConfig MedicConfig { get; set; }
        public static ClassConfig PyroConfig { get; set; }
        public static ClassConfig ScoutConfig { get; set; }
        public static AppSettings Settings { get; set; } = new AppSettings();
        public static ClassConfig SniperConfig { get; set; }
        public static ClassConfig SoldierConfig { get; set; }
        public static ClassConfig SpyConfig { get; set; }

        public static bool IsInititalized { get; set; }

        #endregion Public Fields + Properties

        #region Public Methods

        public static void Initialize() {
            // Check Settings File for TF2 Directory
            if ( File.Exists(AppSettings.AppDataPath + @"\settings.ini") )
            {
                Settings = AppSettings.Load();
                if ( string.IsNullOrEmpty(Settings.TF2Directory) )
                {
                    var dialog = new FolderBrowserDialog
                                 {
                                     RootFolder =
                                         Environment.Is64BitOperatingSystem
                                             ? Environment.SpecialFolder.ProgramFilesX86
                                             : Environment.SpecialFolder.ProgramFiles
                                 };
                    if ( dialog.ShowDialog() == DialogResult.OK )
                    {
                        Settings.TF2Directory = dialog.SelectedPath;
                        AppSettings.Save(Settings);
                    }
                }
                if ( !Directory.Exists(Settings.TF2Directory + @"\cfg") )
                {
                    var dialog = new FolderBrowserDialog
                                 {
                                     RootFolder =
                                         Environment.Is64BitOperatingSystem
                                             ? Environment.SpecialFolder.ProgramFilesX86
                                             : Environment.SpecialFolder.ProgramFiles
                                 };
                    if ( dialog.ShowDialog() == DialogResult.OK )
                    {
                        Settings.TF2Directory = dialog.SelectedPath;
                        AppSettings.Save(Settings);
                    }
                }
            }
            else
            {
                var dialog = new FolderBrowserDialog
                             {
                                 RootFolder =
                                     Environment.Is64BitOperatingSystem
                                         ? Environment.SpecialFolder.ProgramFilesX86
                                         : Environment.SpecialFolder.ProgramFiles
                             };
                if ( dialog.ShowDialog() == DialogResult.OK )
                {
                    Settings.TF2Directory = dialog.SelectedPath;
                    AppSettings.Save(Settings);
                }
            }

            Task.Run(() => LoadConfigs());
            MainWindow = new MainWindow();
            MainWindow.Show();
            IsInititalized = true;
        }

        public static async void LoadConfigs() {
            DefaultConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\config.cfg", ControlConfig.Config);
            ScoutConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\scout.cfg", ControlConfig.Scout);
            SoldierConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\soldier.cfg", ControlConfig.Soldier);
            PyroConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\pyro.cfg", ControlConfig.Pyro);
            DemomanConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\demoman.cfg", ControlConfig.Demoman);
            HeavyConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\heavyweapons.cfg", ControlConfig.Heavyweapons);
            EngineerConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\engineer.cfg", ControlConfig.Engineer);
            MedicConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\medic.cfg", ControlConfig.Medic);
            SniperConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\sniper.cfg", ControlConfig.Sniper);
            SpyConfig =
                await ConfigReader.ReadClassConfig($@"{Settings.TF2Directory}\cfg\spy.cfg", ControlConfig.Spy);
        }

        public static async void SaveAllConfigs() {
            await ConfigWriter.WriteClassConfigFile(ScoutConfig ?? new ClassConfig(ControlConfig.Scout));
            await ConfigWriter.WriteClassConfigFile(SoldierConfig ?? new ClassConfig(ControlConfig.Soldier));
            await ConfigWriter.WriteClassConfigFile(PyroConfig ?? new ClassConfig(ControlConfig.Pyro));
            await ConfigWriter.WriteClassConfigFile(DemomanConfig ?? new ClassConfig(ControlConfig.Demoman));
            await ConfigWriter.WriteClassConfigFile(HeavyConfig ?? new ClassConfig(ControlConfig.Heavyweapons));
            await ConfigWriter.WriteClassConfigFile(EngineerConfig ?? new ClassConfig(ControlConfig.Engineer));
            await ConfigWriter.WriteClassConfigFile(MedicConfig ?? new ClassConfig(ControlConfig.Medic));
            await ConfigWriter.WriteClassConfigFile(SniperConfig ?? new ClassConfig(ControlConfig.Sniper));
            await ConfigWriter.WriteClassConfigFile(SpyConfig ?? new ClassConfig(ControlConfig.Spy));
        }

        #endregion Public Methods
    }
}