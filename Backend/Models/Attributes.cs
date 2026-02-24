using System.Text.Json.Serialization;

namespace ShinRoll.Models
{
    public class Attributes
    {
        [JsonIgnore]
        public long Id { get;  set; }
        public int Strength { get;  set; } = 10;
        [JsonIgnore]
        public int ModStrenght { get;  set; } 
        public int Dexterity { get;  set; } = 10;
        [JsonIgnore]
        public int ModDexterity { get;  set; }
        public int Constitution { get;  set; } = 10;
        [JsonIgnore]
        public int ModConstituition { get;  set; }
        public int Wisdom { get;  set; } = 10;
        [JsonIgnore]
        public int ModWisdom { get;  set; }
        public int Presence { get;  set; } = 10;
        [JsonIgnore]
        public int ModPresence { get;  set; }
        public int Will { get;  set; } = 10;
        [JsonIgnore]
        public int ModWill { get;  set; } 

  

        public Attributes()
        {
        }

    }
}
