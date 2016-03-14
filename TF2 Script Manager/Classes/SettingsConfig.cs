#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/21/2016 9:48 PM
// Last Revised: 03/08/2016 7:37 AM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Classes {
    #region Using

    using Abstracts;

    #endregion

    public class SettingsConfig : Config {
        #region Public Fields + Properties

        public new string Name { get; } = "settings.cfg";

        #endregion Public Fields + Properties

        #region Public Methods

        public override void Save() { }

        #endregion Public Methods
    }
}