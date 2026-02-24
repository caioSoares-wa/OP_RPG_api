using ShinRoll.Data.StaticData.Skill;
using ShinRoll.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Text.RegularExpressions;


namespace ShinRoll.Data.StaticData.CharacterSpecs.FightingStyles
{
    [NotMapped]
    public class FightingStyleStats
    {
        [NotMapped]
        public int Id { get; set; }
        public FightingStylesEnum FightingStyle { get; set; }
        public string Name { get; set; } = string.Empty;
        public int LifeDice { get; set; }

        public string WeaponProficiency { get; set; } = string.Empty;
        public string FavoriteWeapon { get; set; } = string.Empty;
        public int SkillToChoose { get; set; } = 0;    
        public List<AttributeEnum> PrimaryAttribute { get; set; } = new();
        public List<SavingBonusEnum> SavingBonus { get; set; } = new();
        public List<SkillsData> SkillsAllowed { get; set; } = new();
        public List<SkillEnum> SkillsProficiency { get; set; } = new();
        public List<AttributeEnum> CDAttributes { get; set; } = new();
             

        public static readonly List<FightingStyleStats> FightList =
            new List<FightingStyleStats>
            {
                    new FightingStyleStats{
                        LifeDice = 8 ,
                        Name = "Atirador",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Dexterity},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Dexterity,
                            SavingBonusEnum.Wisdom
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Athletics,
                            SkillEnum.Acrobatics,
                            SkillEnum.Stealth,
                            SkillEnum.SleightOfHand,
                            SkillEnum.History,
                            SkillEnum.Investigation,
                            SkillEnum.Survival,
                            SkillEnum.Nature,
                            SkillEnum.Profession,
                            SkillEnum.Deception,
                            SkillEnum.Intimidation,
                            SkillEnum.Persuasion,
                            SkillEnum.Provoke,
                            SkillEnum.Insight,
                            SkillEnum.Perception,
                            SkillEnum.Supernatural,
                            SkillEnum.Luck
                        },
                        SkillToChoose = 3,
                        WeaponProficiency = "Armas de Fogo, Lançador de Arpão, Bazuca, Canhão de Mão e Armas de Navio",
                        FightingStyle = FightingStylesEnum.Shooter  },

                    new FightingStyleStats{
                        LifeDice = 12 ,
                        Name = "Brutamontes",
                        WeaponProficiency = "Kanabo",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Strength,
                            SavingBonusEnum.Constitution
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Athletics,
                            SkillEnum.Intimidation,
                            SkillEnum.Provoke,
                            SkillEnum.Survival
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Brute  },


                    new FightingStyleStats{
                        LifeDice = 12 ,
                        Name = "Carateca Homem-Peixe",
                        WeaponProficiency = "Armas Marciais e Tridente",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Dexterity},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Strength,
                            SavingBonusEnum.Constitution
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Acrobatics,
                            SkillEnum.Athletics,
                            SkillEnum.Performance,
                            SkillEnum.Intimidation,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.KaratekaFishman  },

                    new FightingStyleStats{
                        LifeDice = 12 ,
                        Name = "Ciborgue",
                        WeaponProficiency = "Nenhuma",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Wisdom},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Wisdom},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Strength,
                            SavingBonusEnum.Wisdom
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Athletics,
                            SkillEnum.Investigation,
                            SkillEnum.SleightOfHand,
                            SkillEnum.Survival,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Cyborg  },

                    new FightingStyleStats{
                        LifeDice = 10 ,
                        Name = "Espadachim",
                        WeaponProficiency = "Armas Cortantes",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Dexterity},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Dexterity},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Dexterity,
                            SavingBonusEnum.Will
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Athletics,
                            SkillEnum.Intimidation,
                            SkillEnum.Insight,
                            SkillEnum.Perception,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Swordsman  },

                    new FightingStyleStats{
                        LifeDice = 10 ,
                        Name = "Guerrilheiro",
                        WeaponProficiency = "Armas Cortantes, Armas de Fogo, Armas Especiais e Armas Marciais",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Wisdom,AttributeEnum.Dexterity},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Wisdom},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Strength,
                            SavingBonusEnum.Dexterity,
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Acrobatics,
                            SkillEnum.Athletics,
                            SkillEnum.Stealth,
                            SkillEnum.History,
                            SkillEnum.Survival,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Guerrila  },

                    new FightingStyleStats{
                        LifeDice = 12 ,
                        Name = "Lutador",
                        WeaponProficiency = "Armas Marciais e Tridente",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Constitution},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Strength,
                            SavingBonusEnum.Constitution
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Athletics,
                            SkillEnum.Intimidation,
                            SkillEnum.Provoke,
                            SkillEnum.Survival,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Fighter  },

                    new FightingStyleStats{
                        LifeDice = 8 ,
                        Name = "Ninja",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Dexterity},
                        WeaponProficiency = "Katana, Kunai, Adaga, Shuriken, Foice e Arco",
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Dexterity,
                            SavingBonusEnum.Wisdom
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Acrobatics,
                            SkillEnum.Deception,
                            SkillEnum.Stealth,
                            SkillEnum.SleightOfHand,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Ninja  },

                    new FightingStyleStats{
                        LifeDice = 12 ,
                        Name = "Okama Kenpo",
                        CDAttributes= new List<AttributeEnum>{AttributeEnum.Presence},
                        WeaponProficiency = "Armas Marciais",
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Presence},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Dexterity,
                            SavingBonusEnum.Presence
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Acrobatics,
                            SkillEnum.Athletics,
                            SkillEnum.Performance,
                            SkillEnum.Deception,
                            SkillEnum.Intimidation,
                            SkillEnum.Insight,
                            SkillEnum.Provoke,
                        },
                        SkillToChoose = 3,
                        FightingStyle = FightingStylesEnum.OkamaKenpo},

                    new FightingStyleStats{
                        LifeDice = 10 ,
                        Name = "Usuário de Rokushiki",
                        WeaponProficiency = "Armas Marciais e Tridente",
                        FavoriteWeapon = "Escolha uma entre adaga, katana, bastão ou “Corporal”.",
                       CDAttributes= new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Dexterity},
                        PrimaryAttribute = new List<AttributeEnum>{AttributeEnum.Strength,AttributeEnum.Dexterity},
                        SavingBonus = new List<SavingBonusEnum >{
                            SavingBonusEnum.Dexterity,
                            SavingBonusEnum.Strength
                        },
                        SkillsProficiency = new List<SkillEnum>
                        {
                            SkillEnum.Acrobatics,
                            SkillEnum.Athletics,
                            SkillEnum.Deception,
                            SkillEnum.Stealth,
                            SkillEnum.History,
                            SkillEnum.Investigation,
                        },
                        SkillToChoose = 2,
                        FightingStyle = FightingStylesEnum.Rokushiki },



            };

          

       
        public FightingStyleStats() {
            
        }
        

      

    }
}
