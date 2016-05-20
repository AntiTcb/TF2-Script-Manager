#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 12:41 AM
// Last Revised: 03/10/2016 2:16 PM
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
    public sealed class Alias : Keyword {
        #region Public Constructors

        public Alias(string name) : base(name) { }

        public Alias(string name, string command) : base(name, command) { }

        #endregion Public Constructors

        #region Public Methods

        public static Alias TryParse(string bindLine) {
            var splits = new Regex(@"\s").Split(bindLine, 3);
            Debug.WriteLine(splits);
            return splits.GetUpperBound(0) != 2 ? null : new Alias(splits[ 1 ], splits[ 2 ]);
        }
        #endregion Public Methods

        public override string ToString() => $"alias \"{Name}\" \"{Command}\"";
    }
}