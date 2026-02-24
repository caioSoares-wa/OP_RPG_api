using ShinRoll.Models;
using ShinRoll.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinRoll.Data.StaticData.CharacterSpecs.SavingBonus
{
    [NotMapped]
    public class SavingBonusStats : Attributes 
    {

        
        public Dictionary<AttributeEnum, bool> HasProficiency { get; set; } = new();

        public SavingBonusStats()
        {
           
            HasProficiency.Add(AttributeEnum.Strength, false);
            HasProficiency.Add(AttributeEnum.Dexterity, false);
            HasProficiency.Add(AttributeEnum.Constitution, false);
            HasProficiency.Add(AttributeEnum.Wisdom, false);
            HasProficiency.Add(AttributeEnum.Presence, false);
            HasProficiency.Add(AttributeEnum.Will, false);

        }


        

        
    }
}
