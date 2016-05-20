#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 2:09 AM
// Last Revised: 03/10/2016 5:20 PM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Services {
    #region Using

    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Classes;
    using Enums;

    #endregion

    public static class ConfigReader {
        #region Public Methods

        public static async Task< ClassConfig > ReadClassConfig(string filePath, ControlConfig merc) {
            var Config = new ClassConfig(merc);

            if (!File.Exists(filePath))
            {
                if (Config.ControlConfig == ControlConfig.AutoExec || Config.ControlConfig == ControlConfig.Spy) { Config.SetDefaultKeybinds(); }
                return Config;
            }

            using ( var sr = new StreamReader(filePath) )
            {
                while ( !sr.EndOfStream )
                {
                    var line = await sr.ReadLineAsync();

                    var reg = new Regex("^bind ", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) )
                    {
                        var newBind = Bind.TryParse(line);
                        Config.Keybinds.Bind(newBind.Key, newBind);
                        continue;
                    }

                    reg = new Regex("^alias ", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) )
                    {
                        Config.Aliases.Add(Alias.TryParse(line));
                        continue;
                    }

                    reg = new Regex("^exec ", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) )
                    {
                        Config.Execs.Add(Exec.TryParse(line));
                        continue;
                    }

                    reg = new Regex("^toggle ", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) )
                    {
                        Config.Toggles.Add(Toggle.TryParse(line));
                        continue;
                    }

                    reg = new Regex("^bindtoggle ", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) )
                    {
                        Config.BindToggles.Add(BindToggle.TryParse(line));
                    }
                }
            }

            return Config;
        }

        #endregion Public Methods
    }
}