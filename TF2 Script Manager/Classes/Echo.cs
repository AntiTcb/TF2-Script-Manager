#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 03/10/2016 2:31 PM
// Last Revised: 03/10/2016 2:32 PM
// Last Revised by: Alex Gravely - Alex

#endregion

namespace TF2_Script_Manager.Classes {
    #region Using

    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using Abstracts;
    using PropertyChanged;

    #endregion

    [ ImplementPropertyChanged ]
    public class Echo : Keyword {
        #region Public Constructors

        public Echo(string name) : base(name) { }

        public Echo(string name, string command) : base(name, command) { }

        #endregion Public Constructors

        #region Public Methods

        public static Echo TryParse(string bindLine) {
            var splits = new Regex(@"\s").Split(bindLine, 3);
            Debug.WriteLine(splits);
            return splits.GetUpperBound(0) != 2 ? null : new Echo(splits[ 1 ], splits[ 2 ]);
        }

        #endregion Public Methods
    }
}