
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinRoll.Data.StaticData.CharacterSpecs.Technique
{
    [NotMapped]
    public class TechniqueStats
    {
        public int Id {  get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Degree { get; set; } = 0;
        public int PowerPointCost { get; set; } = 0;
        public string Damage { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Range { get; set; } = string.Empty;
        public bool CanCombineAttack { get; set; } = false;
        public string ActionRequirement { get; set; } = string.Empty;
        


        public TechniqueStats() { }
    }
}
