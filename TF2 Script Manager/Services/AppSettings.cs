#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/20/2016 12:34 AM
// Last Revised: 03/10/2016 2:08 PM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Services {
    #region Using

    using System;
    using System.Diagnostics;
    using System.IO;
    using ProtoBuf;
    using System.Windows.Forms;
    #endregion

    [ ProtoContract(ImplicitFields = ImplicitFields.AllFields) ]
    public class AppSettings {
        #region Public Fields + Properties

        public static readonly string AppDataPath = Environment.GetFolderPath
                                                        (Environment.SpecialFolder.ApplicationData) +
                                                    @"\TF2ScriptManager";

        public static readonly string BackupDataPath = AppDataPath + @"\Backups";

        public string TF2Directory = "";

        #endregion Public Fields + Properties

        #region Public Constructors

        public AppSettings() {
            if ( !Directory.Exists(AppDataPath) ) { Directory.CreateDirectory(AppDataPath); }
            if ( !Directory.Exists(BackupDataPath) ) { Directory.CreateDirectory(BackupDataPath); }
        }

        #endregion Public Constructors

        #region Public Methods
        
        public static AppSettings Load() {
            Environment.CurrentDirectory = AppDataPath;
            using ( var file = File.OpenRead("settings.ini") )
            {
                try {
                    return Serializer.Deserialize< AppSettings >(file);
                }
                catch {
                    return LoadBackup();
                }
            }
        }

        public static AppSettings LoadBackup() {
            Environment.CurrentDirectory = BackupDataPath;
            using ( var file = File.Create("settings.ini") )
            {
                try {
                    return Serializer.Deserialize< AppSettings >(file);
                }
                catch
                {
                    Debug.WriteLine("Failed loading backup");
                    return null;
                }
            }
        }

        public static void Save(AppSettings settings) {
            Environment.CurrentDirectory = AppDataPath;
            using ( var file = File.Create("settings.ini") ) { Serializer.Serialize(file, settings); }
        }

        public static void SaveBackup(AppSettings settings) {
            Environment.CurrentDirectory = BackupDataPath;
            using ( var file = File.Create("settings.ini") ) { Serializer.Serialize(file, settings); }
        }

        #endregion Public Methods
    }
}