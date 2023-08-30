using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniEditor {

    public class KeyAndValue {

        public string Key { get; set; }
        public string Value { get; set; }

        public KeyAndValue(string key, string value) {

            Key = key;
            Value = value;

        }

        public KeyAndValue() { 

            Key = string.Empty; 
            Value = string.Empty;

        }

    }
}
