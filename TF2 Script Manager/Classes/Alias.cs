#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 12:41 AM
// Last Revised: 02/19/2016 12:49 AM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Classes {
    #region Using
    using PropertyChanged;
    #endregion

    [ ImplementPropertyChanged, ToString ]
    public class Alias {
        #region Public Fields + Properties
        public string Name { get; set; }
        public string Command { get; set; }

        #endregion Public Fields + Properties

        #region Public Constructors
        public Alias(string name) { Name = name; }

        public Alias(string name, string command) : this(name) { Command = command; }

        #endregion Public Constructors
    }
}