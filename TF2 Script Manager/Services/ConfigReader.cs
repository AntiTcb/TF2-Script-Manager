#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 2:09 AM
// Last Revised: 02/19/2016 3:30 AM
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

        public static async Task< ClassConfig > ReadClassConfig(string filePath, Mercenary merc) {
            var Config = new ClassConfig(merc);
            using ( var sr = new StreamReader(filePath) )
            {
                while ( !sr.EndOfStream )
                {
                    var line = await sr.ReadLineAsync();

                    var reg = new Regex("\bbind \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\balias \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\bexec \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\btoggle \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\bbindtoggle \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\becho \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { continue; }

                    reg = new Regex("\bwait \b", RegexOptions.IgnoreCase);
                    if ( reg.IsMatch(line) ) { }
                }
            }

            return Config;
        }

        public static async Task< OtherConfig > ReadOtherConfig(string filePath) {
            var Config = new OtherConfig();
            using ( var sr = new StreamReader(filePath) ) {
                while ( !sr.EndOfStream ) { var line = await sr.ReadLineAsync(); }
            }

            return Config;
        }

        #endregion Public Methods
    }
}