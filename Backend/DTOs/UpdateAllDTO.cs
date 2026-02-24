using ShinRoll.Data.StaticData.CharacterSpecs.FightingStyles;
using ShinRoll.Data.StaticData.CharacterSpecs.Origin;
using ShinRoll.Data.StaticData.CharacterSpecs.Profession;
using ShinRoll.Data.StaticData.CharacterSpecs.Species;
using ShinRoll.Models;

namespace ShinRoll.DTOs
{
    public class UpdateAllDTO
    {
            public string Name { get; set; }
            public int Level { get; set; } 
            public Attributes Attributes { get; set; }
            public FightingStyleStats FightingStyle { get; set; }

            public ProfessionStats Profession {  get; set; }
            public OriginStats Origin { get; set; }         
            public SpeciesStats Species { get; set; } 



    }
}
