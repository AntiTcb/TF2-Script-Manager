#region Header
// Description:
// 
// Solution: TF2 Script Manager
// Project: TF2 Script Manager
// 
// Created: 02/19/2016 1:29 AM
// Last Revised: 02/19/2016 1:29 AM
// Last Revised by: Alex Gravely - Alex
#endregion
namespace TF2_Script_Manager.Classes {
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class KeybindingCollection : IEnumerable<KeyValuePair<string, Bind>> {

        public List< string > UnboundKeys => innerDict.Where(v => v.Value == null).Select(k => k.Key).ToList();

        public List< string > BoundKeys => innerDict.Where(v => v.Value != null).Select(k => k.Key).ToList();

        readonly Dictionary< string, Bind > innerDict = new Dictionary< string, Bind >();

        #region Implementation of IEnumerable

        public IEnumerator< KeyValuePair< string, Bind > > GetEnumerator() => innerDict.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        public KeybindingCollection() { }

        public KeybindingCollection(Dictionary<string, Bind> keybinds) : this() { innerDict = keybinds; }

        public void Bind(string key, Bind bind) {
            if ( !innerDict.ContainsKey(key) ) { innerDict.Add(key, bind); }
            else
            { innerDict[ key ] = bind; }
        }

        public void Bind(KeyValuePair< string, Bind > item) => Bind(item.Key, item.Value);

        public void Unbind(string key) => innerDict[ key ] = null;

        public Bind this[string key] {
            get
            {
                return innerDict.ContainsKey(key) ? innerDict[ key ] : null;
            }
            set
            {
                if ( value == null ) { return; }
                if ( innerDict.ContainsKey(key) )
                {
                    innerDict[ key ] = value;
                }
            }
        }

        public ICollection< string > Keys => innerDict.Keys;
        public ICollection< Bind > Bindings => innerDict.Values;

        public override string ToString() => $"Count = {innerDict.Count}";
    }
}