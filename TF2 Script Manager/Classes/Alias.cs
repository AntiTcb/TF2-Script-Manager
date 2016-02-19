// Description:
//
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
//
// Created: 02/19/2016 12:41 AM
// Last Revised: 02/19/2016 12:49 AM
// Last Revised by: Alex Gravely - Alex

namespace TF2_Script_Manager.Classes
{
    using PropertyChanged;
    using System.Text.RegularExpressions;

    [ImplementPropertyChanged]
    public class Alias
    {
        #region Public Fields + Properties

        public string Command { get; set; }
        public string Name { get; set; }

        #endregion Public Fields + Properties

        #region Public Constructors

        public Alias(string name)
        {
            Name = name;
        }

        public Alias(string name, string command) : this(name)
        {
            Command = command;
        }

        #endregion Public Constructors

        #region Public Methods

        public static Alias TryParse(string bindLine)
        {
            var splitRegex = new Regex(@"\s");
            var splits = splitRegex.Split(bindLine, 3);
            //Console.WriteLine(splits);
            if (splits.GetUpperBound(0) == 2)
            {
                var outBind = new Alias(splits[1], splits[2]);
                return outBind;
            }
            return null;
        }

        #endregion Public Methods

        public override string ToString() => $"alias \"{Name}\" \"{Command}\"";
    }
}