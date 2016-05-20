#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 03/10/2016 2:19 PM
// Last Revised: 05/12/2016 6:00 PM
// Last Revised by: Alex Gravely

#endregion

namespace TF2_Script_Manager.Classes {
    #region Using

    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using Abstracts;

    #endregion

    public class BindToggle : Keyword {

        public int ToggleValue { get; set; }

        #region Public Constructors

        public BindToggle(string name) : base(name) { }

        public BindToggle(string name, string command) : base(name, command) { }

        #endregion Public Constructors

        #region Public Methods

        public static BindToggle TryParse(string bindLine) {
            var splits = new Regex(@"\s").Split(bindLine, 3);
            Debug.WriteLine(splits);
            return splits.GetUpperBound(0) != 2 ? null : new BindToggle(splits[ 1 ], splits[ 2 ]);
        }

        #endregion Public Methods
    }
}