#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 03/10/2016 1:02 PM
// Last Revised: 03/10/2016 2:17 PM
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
    public sealed class Exec : Keyword {
        #region Public Constructors

        public Exec(string name) : base(name) { }

        public Exec(string name, string command) : base(name, command) { }

        #endregion Public Constructors

        #region Public Methods

        public static Exec TryParse(string bindLine) {
            var splits = new Regex(@"\s").Split(bindLine, 3);
            Debug.WriteLine(splits);
            return splits.GetUpperBound(0) != 2 ? null : new Exec(splits[ 1 ], splits[ 2 ]);
        }

        #endregion Public Methods
    }
}