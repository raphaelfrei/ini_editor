using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniEditor {

    public class Section {

        public string Name { get; set; }
        public string Description { get; set; }

        public List<KeyAndValue> KeyAndValue { get; set; }

        public Section() { 
        
            Name = string.Empty;
            Description = string.Empty;
            KeyAndValue = new List<KeyAndValue>();

        }

        public Section(string name, string description) {
            Name = name;
            Description = description;
            KeyAndValue = new List<KeyAndValue>();
        }

        public void AddKeyAndValue(KeyAndValue keyAndValue) {
            KeyAndValue.Add(keyAndValue);
        }

        public void RemoveKeyAndValue(KeyAndValue keyAndValue) {
            KeyAndValue.Remove(KeyAndValue.FirstOrDefault(keyAndValue));
        }

    }

}
