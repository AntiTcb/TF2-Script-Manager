#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 2:09 AM
// Last Revised: 02/19/2016 2:09 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Services {
    using Classes;
    using System.IO;
    using System.Text;
    public static class ConfigWriter {
        public static void WriteClassConfigFile(ClassConfig config)
        {
            var bindsOutput = new StringBuilder();
            var aliasesOutput = new StringBuilder();
            var execsOutput = new StringBuilder(); 
            
        }

        public static void WriteOtherConfigFile(OtherConfig config) {
            
        }
    }
}