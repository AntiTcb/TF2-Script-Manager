#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 03/10/2016 2:05 PM
// Last Revised: 03/10/2016 2:05 PM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Classes.Abstracts {
    using PropertyChanged;

    [ImplementPropertyChanged]
    public abstract class Keyword {
        public string Name { get; set; }
        public string Command { get; set; }

        protected Keyword(string name) { Name = name; }
        protected Keyword(string name, string command) : this(name) { Command = command; }
    }
}