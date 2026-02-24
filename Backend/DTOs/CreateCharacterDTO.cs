using ShinRoll.Models;
using ShinRoll.Models.Enums;

namespace ShinRoll.DTOs
{
    public class CreateCharacterDTO
    {
        public string Name { get; set; } 
        public int Level { get; set; } 
        public SpeciesEnum Species { get; set; }
        public SubSpecieEnum? SubSpecie { get; set; }
        public FightingStylesEnum FightingStyles { get; set; }
        public ProfessionEnum Profession { get; set; }
        public OriginEnum Origin { get; set; }
        public Attributes Attributes { get; set; } = new();

        
    }
}
