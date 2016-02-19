﻿#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 4:13 AM
// Last Revised: 02/19/2016 4:27 AM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Classes {
    public class Bind {
        #region Public Fields + Properties

        public string Command { get; set; }
        public string Key { get; set; }

        #endregion Public Fields + Properties

        #region Public Constructors

        public Bind(string key) { Key = key; }

        public Bind(string key, string command) : this(key) { Command = command; }

        #endregion Public Constructors

        #region Public Methods

        public override string ToString() => $"bind \"{Key}\" \"{Command}\"";

        #endregion Public Methods
    }
}