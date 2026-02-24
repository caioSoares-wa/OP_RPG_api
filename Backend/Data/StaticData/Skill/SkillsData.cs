using ShinRoll.Models.Enums;
using ShinRoll.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinRoll.Data.StaticData.Skill
{
    [NotMapped]
    public class SkillsData
    {

        public int Id { get;  set; }
        public int Athletics { get;  set; }
        public int Acrobatics { get;  set; }
        public int Stealth { get;  set; }
        public int SleightOfHand { get;  set; }
        public int History { get;  set; }
        public int Investigation { get;  set; }
        public int Survival { get;  set; }
        public int Nature { get;  set; }
        public int Profession { get;  set; }
        public int Performance { get;  set; }
        public int Deception { get;  set; }
        public int Intimidation { get;  set; }
        public int Persuasion { get;  set; }
        public int Provoke { get;  set; }
        public int Haki { get;  set; }
        public int Insight { get;  set; }
        public int Perception { get;  set; }
        public int Supernatural { get;  set; }
        public int Luck { get;  set; }

        [NotMapped]
        public Dictionary<SkillEnum, bool> HasProficiency { get; set; } = new Dictionary<SkillEnum, bool>();
        public SkillsData()
        {
            HasProficiency.Add(SkillEnum.Athletics, false);
            HasProficiency.Add(SkillEnum.Acrobatics, false);
            HasProficiency.Add(SkillEnum.Stealth, false);
            HasProficiency.Add(SkillEnum.SleightOfHand, false);
            HasProficiency.Add(SkillEnum.History, false);
            HasProficiency.Add(SkillEnum.Investigation, false);
            HasProficiency.Add(SkillEnum.Survival, false);
            HasProficiency.Add(SkillEnum.Nature, false);
            HasProficiency.Add(SkillEnum.Profession, false);
            HasProficiency.Add(SkillEnum.Performance, false);
            HasProficiency.Add(SkillEnum.Deception, false);
            HasProficiency.Add(SkillEnum.Intimidation, false);
            HasProficiency.Add(SkillEnum.Persuasion, false);
            HasProficiency.Add(SkillEnum.Provoke, false);
            HasProficiency.Add(SkillEnum.Haki, false);
            HasProficiency.Add(SkillEnum.Insight, false);
            HasProficiency.Add(SkillEnum.Perception, false);
            HasProficiency.Add(SkillEnum.Supernatural, false);
            HasProficiency.Add(SkillEnum.Luck, false);





        }
        





    }

    
}
