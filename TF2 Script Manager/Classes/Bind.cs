#region Header

// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 4:13 AM
// Last Revised: 05/12/2016 6:01 PM
// Last Revised by: Alex Gravely

#endregion

namespace TF2_Script_Manager.Classes {
    #region Using

    using System.Text.RegularExpressions;

    #endregion

    public class Bind {
        #region Public Fields + Properties

        /// <summary>
        ///     Gets or sets the command this bind is assigned.
        /// </summary>
        /// <value>
        ///     The command.
        /// </value>
        public string Command { get; set; }

        /// <summary>
        ///     Gets or sets the keyboard Key for this Bind.
        /// </summary>
        /// <value>
        ///     The Key.
        /// </value>
        public string Key { get; set; }

        #endregion Public Fields + Properties

        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Bind" /> class.
        /// </summary>
        /// <param name="key">The Keyboard Key.</param>
        public Bind(string key) { Key = key; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Bind" /> class.
        /// </summary>
        /// <param name="key">The Keyboard Key.</param>
        /// <param name="command">The command to run when the Key is pressed.</param>
        public Bind(string key, string command) : this(key) { Command = command; }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///     Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"bind \"{Key}\" \"{Command}\"";

        #endregion Public Methods

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="bindLine">Command line found in a .cfg file.</param>
        /// <returns>New Bind object if Parse was successful, null if not.</returns>
        public static Bind TryParse(string bindLine) {
            var splitRegex = new Regex(@"\s");
            var splits = splitRegex.Split(bindLine.Replace("\"", ""), 3);
            if ( splits.GetUpperBound(0) != 2 ) { return null; }
            var outBind = new Bind(splits[ 1 ], splits[ 2 ]);
            return outBind;
        }
    }
}