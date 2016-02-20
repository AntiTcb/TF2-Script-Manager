#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/20/2016 12:34 AM
// Last Revised: 02/20/2016 12:34 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Services {
    using System;
    using System.IO;
    using ProtoBuf;

    [ProtoContract(ImplicitFields = ImplicitFields.AllFields)]
    public class AppSettings {
        public static readonly string AppDataPath = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + @"\TF2ScriptManager";

        public static readonly string BackupDataPath = AppDataPath + @"\Backsups";

        public string TF2Directory = "";

        public static void Save(AppSettings settings) {
            Environment.CurrentDirectory = AppDataPath;
            using ( var file = File.Create("settings.ini") )
            {
                Serializer.Serialize(file, settings);
            }
        }

        public static void Load() {
            Environment.CurrentDirectory = AppDataPath;
            using ( var file = File.OpenRead("settings.ini") ) { Serializer.Deserialize< AppSettings >(file); }
        }

        public static void SaveBackup(AppSettings settings) {
            Environment.CurrentDirectory = BackupDataPath;
            using (var file = File.Create("settings.ini")) { Serializer.Serialize(file, settings);}
        }

        public static void LoadBackup() {
            Environment.CurrentDirectory = BackupDataPath;
            using ( var file = File.Create("settings.ini") ) { Serializer.Deserialize< AppSettings >(file); }
        }


    }
}