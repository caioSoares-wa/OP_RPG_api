using System.ComponentModel.DataAnnotations.Schema;

namespace ShinRoll.Data.StaticData.CharacterSpecs.Haki
{
    [NotMapped]
    public class HakiStats
    {
        
        public int Id { get; set; }
        public int AmbitionPoint { get; set; } = 6;



        public HakiStats() { }

    }
}
