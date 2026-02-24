using Microsoft.OpenApi;
using ShinRoll.Data.StaticData.CharacterSpecs.FightingStyles;
using ShinRoll.Data.StaticData.CharacterSpecs.Haki;
using ShinRoll.Data.StaticData.CharacterSpecs.Origin;
using ShinRoll.Data.StaticData.CharacterSpecs.Profession;
using ShinRoll.Data.StaticData.CharacterSpecs.SavingBonus;
using ShinRoll.Data.StaticData.CharacterSpecs.Species;
using ShinRoll.Data.StaticData.CharacterSpecs.Technique;
using ShinRoll.Data.StaticData.Skill;
using ShinRoll.DTOs;
using ShinRoll.Models.Enums;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace ShinRoll.Models
{
    public class Character
    {
        
        public long Id { get;  set; }
        public string Name { get;  set; } = string.Empty;

        public Attributes Attributes { get;  set; } = new();
        public SkillsData Skills { get;  set; } = new();
        public int Level { get;  set; } = 0;
        public FightingStyleStats FightingStyleCharacter { get;  set; } = new();
        public SavingBonusStats SavingBonus { get;  set; } = new();
        public OriginStats Origin { get;  set; } = new();
        public ProfessionStats Profession { get;  set; } = new();
        public SpeciesStats Species { get;  set; } = new();
        public SubSpecieEnum? SubSpecie { get;  set; } = new();
        public List<TechniqueStats> Techniques { get;  set; } = new();
        public List<SkillEnum> AllowedSkills { get;  set; } = new();
        public int PointsOfLife { get;  set; } = 0;

        public int PointsOfEnergy { get;  set; } = 0;

        public int ArmorClass { get;  set; } = 0;
        public int DifficultyClass { get;  set; } = 0;
        public int Proficiency { get;  set; } = 2;
        

        public Character()
        {

        }
        public Character(
            string name,
            int level,
            OriginEnum origin , 
            FightingStylesEnum fightingStyleEnum,
            SpeciesEnum species ,
            SubSpecieEnum? subSpecie ,
            ProfessionEnum profession,
            Attributes attributes
            )
        {
            this.Name = name;
            this.Level = level;
            this.Attributes = attributes;
            CalculateModifier();
            this.FightingStyleCharacter = FightingStyleStats.FightList.First(p => p.FightingStyle == fightingStyleEnum);
            this.Profession = ProfessionStats.ProfessionList.First(p => p.Profession == profession);
            this.Origin = OriginStats.OriginStatsList.First(p=> p.Origin == origin);

            Recalculate();

            foreach ( var p in Skills.HasProficiency)
            { 
                CalculateSkills(p.Key , p.Value);        
            }

            foreach (var p in SavingBonus.HasProficiency)
            {
                CalculateSavingBonus(p.Key, p.Value);
            }
            this.Species = new (species, subSpecie);
        }

        private void CalculateModifier()
        {
            Attributes.ModStrenght = (this.Attributes.Strength - 10) / 2;
            Attributes.ModDexterity = (this.Attributes.Dexterity - 10) / 2;
            Attributes.ModConstituition = (this.Attributes.Constitution - 10) / 2;
            Attributes.ModWisdom = (this.Attributes.Wisdom - 10) / 2;
            Attributes.ModPresence = (this.Attributes.Presence - 10) / 2;
            Attributes.ModWill = (this.Attributes.Will - 10) / 2;      
        }

        private int CalculatePointsOfEnergy()
        {
            return this.Level * 2;
        }

        public void UpdateAttributes(UpdateAttributeDTO attributes)
        {
            this.Attributes.Strength = attributes.Attributes.Strength;
            this.Attributes.Dexterity = attributes.Attributes.Dexterity;
            this.Attributes.Constitution = attributes.Attributes.Constitution;
            this.Attributes.Wisdom = attributes.Attributes.Wisdom;
            this.Attributes.Presence = attributes.Attributes.Presence;
            this.Attributes.Will = attributes.Attributes.Will;




            CalculateModifier(); 
            foreach (var p in Skills.HasProficiency)
            {
                CalculateSkills(p.Key, p.Value);
            }

            foreach (var p in SavingBonus.HasProficiency)
            {
                CalculateSavingBonus(p.Key, p.Value);
            }
            Recalculate();
            
        }

        public void UpdateCharacter(UpdateAllDTO character)
        {

            this.Name = character.Name;
            this.Level = character.Level;
            this.Attributes = character.Attributes;
            CalculateModifier();
            this.FightingStyleCharacter = character.FightingStyle;
            this.Profession = character.Profession;
            this.Origin = character.Origin;
            this.Species = character.Species;

            foreach (var p in Skills.HasProficiency)
            {
                CalculateSkills(p.Key, p.Value);
            }
            foreach (var p in SavingBonus.HasProficiency)
            {
                CalculateSavingBonus(p.Key, p.Value);
            }

            Recalculate();

        }
    
        public void Recalculate()
        {
            this.PointsOfEnergy = CalculatePointsOfEnergy();
            this.Proficiency = this.CalculateProficiencyBonus();
            this.PointsOfLife = this.CalculateLifePoints();
            this.ArmorClass = this.CalculateArmorClass();
            this.AllowedSkills = this.CalculateAllowedSkills();
            CalculateDifficultyClass();
        }

        public void CalculateDifficultyClass()
        {
            var listCdAttributes = FightingStyleCharacter.CDAttributes.ToList();

            var maxAttribute = 0 ;

            AttributeEnum attr = new();
            

            foreach (var p in listCdAttributes)
            {
               

                if (p == AttributeEnum.Strength )
                {
                    if (this.Attributes.Strength > maxAttribute )
                    {
                        maxAttribute = this.Attributes.Strength;
                        attr = AttributeEnum.Strength;
                    }
                }
                else if (p == AttributeEnum.Dexterity)
                {

                    if (this.Attributes.Dexterity > maxAttribute)
                    {
                        attr = AttributeEnum.Dexterity;
                        maxAttribute = this.Attributes.Dexterity;
                    }
                }
                else if (p == AttributeEnum.Constitution)
                {
                    if (this.Attributes.Constitution > maxAttribute)
                    {
                        attr = AttributeEnum.Constitution;
                        maxAttribute = this.Attributes.Constitution;
                    }
                }
                else if (p == AttributeEnum.Wisdom)
                {
                    if (this.Attributes.Wisdom > maxAttribute)
                    {
                        attr = AttributeEnum.Wisdom;
                        maxAttribute = this.Attributes.Wisdom;
                    }
                }
                else if (p == AttributeEnum.Presence)
                {
                    if (this.Attributes.Presence > maxAttribute)
                    {
                        attr = AttributeEnum.Presence;
                        maxAttribute = this.Attributes.Presence;
                    }
                }
                else if (p == AttributeEnum.Will)
                {
                    if (this.Attributes.Will > maxAttribute)
                    {
                        attr = AttributeEnum.Will;
                        maxAttribute = this.Attributes.Will;
                    }
                }


                
              
            }


                switch (FightingStyleCharacter.FightingStyle)
                {
                    case FightingStylesEnum.Shooter:

                    this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8 ;
                    break;

                    case FightingStylesEnum.Brute:
                    this.DifficultyClass = Attributes.ModStrenght + Proficiency + 8;
                    break;
                    
                    case FightingStylesEnum.KaratekaFishman:

                    


                        if ( attr == AttributeEnum.Strength )
                        {
                            this.DifficultyClass = DifficultyClass = Attributes.ModStrenght + Proficiency + 8;
                            break;
                        }

                        if (attr == AttributeEnum.Dexterity)
                            {
                            this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8;
                            break;
                        }
                    
                                throw new ArgumentException("Parâmetro invalido para esse estilo de luta!");          
                    case FightingStylesEnum.Cyborg:
                    this.DifficultyClass = Attributes.ModWisdom + Proficiency + 8 ;
                        break;
                    case FightingStylesEnum.Swordsman:

 
                        if (attr ==AttributeEnum.Dexterity)
                            {
                            this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8;
                            break;
                        }

                            else if (attr ==AttributeEnum.Strength)
                            {
                            this.DifficultyClass = Attributes.ModStrenght + Proficiency + 8;
                            break;
                        }

                            throw new ArgumentException("Parâmetro invalido para esse estilo de luta!");    
                    

                    case FightingStylesEnum.Guerrila:

                            if (attr ==AttributeEnum.Dexterity)
                            {
                            this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8;
                            break;

                        }
                            else if (attr ==AttributeEnum.Strength)
                            {
                            this.DifficultyClass = Attributes.ModStrenght + Proficiency + 8;
                            break;
                        }
                            else if (attr ==AttributeEnum.Wisdom)
                            {
                            this.DifficultyClass = Attributes.ModWisdom + Proficiency + 8;
                            break;

                        }

                        throw new ArgumentException("Parâmetro invalido para esse estilo de luta!");    
                    case FightingStylesEnum.Fighter:

                        this.DifficultyClass = Attributes.ModStrenght + Proficiency + 8; 
                        break;

                    case FightingStylesEnum.Ninja:

                        this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8;
                        break;

                    case FightingStylesEnum.OkamaKenpo:

                        this.DifficultyClass = Attributes.ModPresence + Proficiency + 8;
                        break;

                    case FightingStylesEnum.Rokushiki:
                        
                        if (attr ==AttributeEnum.Dexterity)
                        {
                          this.DifficultyClass = Attributes.ModDexterity + Proficiency + 8;
                          break;    
                        }
                        else if (attr ==AttributeEnum.Strength)
                        {
                         this.DifficultyClass = Attributes.ModStrenght + Proficiency + 8;
                        break;
                    }
                        throw new ArgumentException("Parâmetro invalido para esse estilo de luta!");
            }
        }

        private List<SkillEnum> CalculateAllowedSkills()
        {
            var list1= this.Profession.SkillsProficiency;
            var list2= this.Origin.SkillsProficiency;
            var list3= this.FightingStyleCharacter.SkillsProficiency;
            var listFinal = list1.Concat(list2).Concat(list3).ToList();
            return  listFinal;
        }

        public void CalculateSavingBonus(AttributeEnum attributeEnum ,bool trained = false )
        {
            SavingBonus.HasProficiency[attributeEnum]= trained;
            if (trained)
            {
                switch (attributeEnum)
                {
                    case AttributeEnum.Strength:
                        this.SavingBonus.Strength = Proficiency + SavingBonus.ModStrenght ;
                        break;
                    case AttributeEnum.Dexterity:
                        this.SavingBonus.Dexterity = Proficiency + SavingBonus.ModDexterity;
                        break;
                    case AttributeEnum.Constitution:
                        this.SavingBonus.Constitution = Proficiency + SavingBonus.ModConstituition;
                        break;
                    case AttributeEnum.Wisdom:
                        this.SavingBonus.Wisdom = Proficiency + SavingBonus.ModWisdom;
                        break;
                    case AttributeEnum.Presence:
                        this.SavingBonus.Presence = Proficiency + SavingBonus.ModPresence;
                        break;
                    case AttributeEnum.Will:
                        this.SavingBonus.Will = Proficiency + SavingBonus.ModWill;
                        break;
                }
            }
            else
            {
                switch (attributeEnum)
                {
                    case AttributeEnum.Strength:
                        this.SavingBonus.Strength = SavingBonus.ModStrenght;
                        break;
                    case AttributeEnum.Dexterity:
                        this.SavingBonus.Dexterity = SavingBonus.ModDexterity;
                        break;
                    case AttributeEnum.Constitution:
                        this.SavingBonus.Constitution = SavingBonus.ModConstituition;
                        break;
                    case AttributeEnum.Wisdom:
                        this.SavingBonus.Wisdom =  SavingBonus.ModWisdom;
                        break;
                    case AttributeEnum.Presence:
                        this.SavingBonus.Presence =  SavingBonus.ModPresence;
                        break;
                    case AttributeEnum.Will:
                        this.SavingBonus.Will =  SavingBonus.ModWill;
                        break;
                }
            }

        }


        private void CalculateSkills(SkillEnum skillEnum, bool trained)
        {

            Skills.HasProficiency[skillEnum] = trained;

            switch (skillEnum) 
            {
                case SkillEnum.Acrobatics:
                    if (trained == true)
                    {
                        this.Skills.Acrobatics = Proficiency + Attributes.ModDexterity ;
                        break;
                    }
                    else
                    {
                        this.Skills.Acrobatics = Attributes.ModDexterity;
                        break;
                    }

                    
                case SkillEnum.Athletics:
                    if (trained == true)
                    {
                        this.Skills.Athletics = Proficiency + Attributes.ModStrenght;
                        break;
                    }
                    else
                    {
                    this.Skills.Athletics =  Attributes.ModStrenght;
                        break;
                    }



                   
                case SkillEnum.Stealth:
                    if (trained == true)
                    {
                    this.Skills.Stealth = Proficiency + Attributes.ModDexterity;
                        break;
                    }
                    else
                    {
                        this.Skills.Stealth =   Attributes.ModDexterity;

                        break;
                    }
                    

                case SkillEnum.SleightOfHand:
                    if (trained == true)
                    {
                    this.Skills.SleightOfHand = Proficiency + Attributes.ModDexterity;
                        break;
                    }
                    else
                    {
                        this.Skills.SleightOfHand =   Attributes.ModDexterity;
                        break;
                    }

                    

                case SkillEnum.History:
                    if (trained == true)
                    {

                    this.Skills.History = Proficiency + Attributes.ModWisdom;
                        break;
                    }
                    else
                    {
                        this.Skills.History =   Attributes.ModWisdom;

                        break;
                    }
                    
                case SkillEnum.Investigation:
                    if (trained == true)
                    {
                    this.Skills.Investigation = Proficiency + Attributes.ModWisdom;

                        break;
                    }
                    else
                    {
                        this.Skills.Investigation =   Attributes.ModWisdom;

                        break;
                    }
                    
                case SkillEnum.Nature:
                    if (trained == true)
                    {
                    this.Skills.Nature = Proficiency + Attributes.ModWisdom;
                        break;
                    }
                    else
                    {
                        this.Skills.Nature =  Attributes.ModWisdom;

                        break;
                    }
                    
                case SkillEnum.Survival:
                    if (trained == true)
                    {
                    this.Skills.Survival = Proficiency + Attributes.ModWisdom;                    
                        break;
                    }
                    else
                    {
                        this.Skills.Survival =   Attributes.ModWisdom;

                        break;
                    }
                    
                case SkillEnum.Performance:
                    if (trained == true)
                    {
                    this.Skills.Performance = Proficiency + Attributes.ModPresence;
                        break;
                    }
                    else
                    {
                        this.Skills.Performance =   Attributes.ModPresence;

                        break;
                    }
                   
                case SkillEnum.Profession:
                    if (trained == true)
                    {
                    this.Skills.Profession = Proficiency + Attributes.ModPresence;
                        break;
                    }
                    else
                    {
                        this.Skills.Profession = Attributes.ModPresence;

                        break;
                    }
                    
                case SkillEnum.Deception:
                    if (trained == true)
                    {
                        this.Skills.Deception = Proficiency + Attributes.ModPresence;

                        break;
                    }
                    else
                    {
                        this.Skills.Deception =   Attributes.ModPresence;
                        break;
                    }
                    
                case SkillEnum.Intimidation:
                    if (trained == true)
                    {

                    this.Skills.Intimidation = Proficiency + Attributes.ModPresence;
                        break;
                    }
                    else
                    {
                        this.Skills.Intimidation =   Attributes.ModPresence;

                        break;
                    }
                    
                case SkillEnum.Persuasion:
                    if (trained == true)
                    {
                    this.Skills.Persuasion = Proficiency + Attributes.ModPresence;
                        break;
                    }
                    else
                    {
                        this.Skills.Persuasion =  Attributes.ModPresence;

                        break;
                    }
                    
                case SkillEnum.Provoke:
                    if (trained == true)
                    {
                    this.Skills.Provoke = Proficiency + Attributes.ModPresence;
                        break;
                    }
                    else
                    {
                        this.Skills.Provoke =   Attributes.ModPresence;
                        break;
                    }
                    
                case SkillEnum.Haki:
                    if (trained == true)
                    {
                    this.Skills.Haki = Proficiency + Attributes.ModWill;
                        break;
                    }
                    else
                    {
                        this.Skills.Haki =   Attributes.ModWill;

                        break;
                    }
                    
                case SkillEnum.Insight:
                    if (trained == true)
                    {

                    this.Skills.Insight = Proficiency + Attributes.ModWill;
                        break;
                    }
                    else
                    {
                        this.Skills.Insight =   Attributes.ModWill;

                        break;
                    }
                  
                case SkillEnum.Perception:
                    if (trained == true)
                    {
                    this.Skills.Perception = Proficiency + Attributes.ModWill;
                        break;
                    }
                    else
                    {
                        this.Skills.Perception =  Attributes.ModWill;

                        break;
                    }
                    
                case SkillEnum.Supernatural:
                    if (trained == true)
                    {
                    this.Skills.Supernatural = Proficiency + Attributes.ModWill;
                        break;
                    }
                    else
                    {
                        this.Skills.Supernatural =  Attributes.ModWill;

                        break;
                    }
                    
                case SkillEnum.Luck:
                    if (trained == true)
                    {

                    this.Skills.Luck = Proficiency + Attributes.ModWill;
                        break;
                    }
                    else
                    {
                        this.Skills.Luck =  Attributes.ModWill;

                        break;
                    }
                   
   

            }
        }


        private int CalculateProficiencyBonus()
        {
            
            if (this.Level >= 1 && this.Level <= 4 )
            {     
                return 2;
            }else if (this.Level > 4 && this.Level <= 8 )
            {
                return 3; 
            }else if (this.Level > 8 && this.Level <= 12)
            {
                return 4;
            }
            else if (this.Level > 12 && this.Level <= 16)
            {
                return 5;
            }
            else
            {
                return 6;
            }            
        }

        private int CalculateLifePoints()
        {
            return this.Species.BaseLifePoints + this.FightingStyleCharacter.LifeDice + Attributes.ModConstituition ;
        }

        private int CalculateArmorClass(int? bonus = null) {
            return Attributes.ModDexterity + 10;
        }


    }
}
