using ShinRoll.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinRoll.Data.StaticData.CharacterSpecs.Origin
   
{
    [NotMapped]
    public class OriginStats
    {
        
        public int Id { get; set; }

        public OriginEnum Origin { get; set; }

        public string OriginName { get; set; } = string.Empty;
        public string SpecialAbilityName { get; set; } = string.Empty;
        public string SpecialAbilityDescription { get; set; } = string.Empty;
        public List<AttributeEnum> RecommendedAttribute { get; set; } = new();
        public List<SkillEnum> SkillsProficiency { get; set; } = new();
        public int SkillToChoose { get; set; } = 0;

        public OriginStats() { }

        public static readonly List<OriginStats> OriginStatsList =
            new List<OriginStats>
            {
               new OriginStats{
                    SkillToChoose= 2 ,
                    Origin = OriginEnum.PandemicSurvivor,
                    OriginName = "Sobrevivente da Pandemia",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Nature,
                        SkillEnum.Survival,
                        SkillEnum.Intimidation,
                        SkillEnum.Stealth
                    },
                    SpecialAbilityName = "Imunidade Ressurgente",
                    SpecialAbilityDescription = "Por ter sobrevivido a um ambiente de pura pestilência, seu corpo adquiriu uma resistência única.Uma vez por dia, você pode realizar um teste de Vontade (sorte) para tentar se livrar de qualquerdoença ou efeito prejudicial em seu corpo. A CD do teste será determinada pelo Narrador, levandoem consideração a gravidade da condição. Você pode usar essa característica apenas uma vez,recuperando seus usos após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Experiment,
                    OriginName = "Experimento",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Acrobatics,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Perception
                    },
                    SpecialAbilityName = "Cobaia Natural",
                    SpecialAbilityDescription = "Por você ter nascido ou se desenvolvido em um laboratório, você tem uma predisposição natural para aguentar experimentos. Desde que você seja bem-sucedido em um teste de Atributo Vontade (Sorte),com a CD definida pelo Narrador, você pode suportar qualquer tipo de químico, veneno, arma biológica ou tortura.Essa característica só pode ser usada novamente depois de um descanso longo."},

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.SonOfTheDevil,
                    OriginName = "Filho do Demônio",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Nature,
                        SkillEnum.Perception,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Adaptação Sobrenatural",
                    SpecialAbilityDescription = "Ao se deparar com uma situação complexa ou difícil, você enxerga uma forma de resolvê-la usando sua fruta. Desde que você seja bem sucedido em um teste de atributo de vontade (Sorte), com a CD definida pelo Narrador, você pode criar uma técnica auxiliar temporária, que existe especificamente para resolver a situação que você se encontra. Essa característica só pode ser usada novamente após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.ExAgentCipherPol,
                    OriginName = "Ex-Agente Cipher Pol",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Deception,
                        SkillEnum.Investigation,
                        SkillEnum.Perception,
                        SkillEnum.Persuasion
                    },
                    SpecialAbilityName = "Conhecimento Subliminar",
                    SpecialAbilityDescription = "O jogador pode fazer um teste de vontade (Sorte), com ND definido pelo Narrador, para no sucesso saber de antemão uma informação privilegiada sobre uma pessoa, um lugar, uma organização ou um evento. Essa característica pode ser usada um número de vezes igual a sua proficiência."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Thief,
                    OriginName = "Ladrão",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Acrobatics,
                        SkillEnum.Stealth,
                        SkillEnum.SleightOfHand,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Batedor de Carteira",
                    SpecialAbilityDescription = "Quando estiver um ambiente com um grande número de pessoas circulando, você pode jogar um teste de Vontade (Sorte) com ND definido pelo Narrador. No sucesso, você consegue roubar 2d10 x 5.000 belly. Essa característica pode ser usada novamente após um descanso curto. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.BornInWar,
                    OriginName = "Nascido na Guerra",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Strength},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Besta da Guerra",
                    SpecialAbilityDescription = "Você aprendeu a continuar lutando não importa a adversidade que enfrenta, podendo superar qualquer debilitação quando necessário. Uma vez por dia, após encerrar um combate, você pode fazer um teste de vontade (sorte) com ND definido pelo Narrador, caso passe você recupera PV's iguais a metade do total de dano que recebeu neste combate. Esta característica pode ser usada novamente após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Mobster,
                    OriginName = "Mafioso",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Intimidation,
                        SkillEnum.Persuasion,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Molhar as Mãos",
                    SpecialAbilityDescription = "Por ter passado muito tempo mediando conflitos e cobrando favores, você tem facilidade em subornar os outros. Quando estiver impedido de ir a algum lugar ou em uma situação que possa escalar para uma batalha, você pode jogar um teste de Vontade (Sorte), com ND definido pelo mestre, para no sucesso conseguir contornar a situação pagando um valor de 3d10 x 5.000 belly. Essa característica pode ser usada uma quantidade de vezes igual a sua proficiência, sendo os dados dobrados a cada uso até um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Gladiator,
                    OriginName = "Gladiador",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Acrobatics,
                        SkillEnum.Athletics,
                        SkillEnum.Provoke,
                        SkillEnum.Intimidation
                    },
                    SpecialAbilityName = "Nemesis",
                    SpecialAbilityDescription = "Sua experiência nas arenas forjou em você uma fúria indomável, antes de iniciar combate com uma criatura que você tenha alguma interação negativa no passado, você pode realizar um teste de Força (Atletismo), caso passe, sua iniciativa no combate que envolva tal criatura será dobrada. Essa característica pode ser usada uma quantidade de vezes igual a sua proficiência e recupera seus usos após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.FamilyMan,
                    OriginName = "Pai de Família",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Investigation,
                        SkillEnum.Insight,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Apoio Paterno",
                    SpecialAbilityDescription = "Seu instinto paternal vai além da proteção física; ele se manifesta como um farol de apoio nos momentos cruciais. Uma vez por dia, você pode fazer um teste de sabedoria (sorte), caso passe você escolha um aliado e conceda a ele um bônus de em seu próximo teste. Você pode usar essa característica uma vez por dia, recuperando seus usos apenas após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Worker,
                    OriginName = "Trabalhador",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Athletics,
                        SkillEnum.Insight,
                        SkillEnum.Nature,
                        SkillEnum.Profession
                    },
                    SpecialAbilityName = "Jornada Extendida",
                    SpecialAbilityDescription = "Pode levar o tempo que for, mas você eventualmente termina o seu serviço. Desde que você tenha 8 horas disponíveis, você pode escolher ter acerto automático em todos os testes de sabedoria (perícia especial) por 24 horas. Durante esse tempo, você não pode fazer um descanso longo, e recebe no final dele 2 níveis de exaustão. Essa característica só pode ser usada novamente depois de um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Oppressed,
                    OriginName = "Oprimido",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Persuasion,
                        SkillEnum.Stealth,
                        SkillEnum.Perception,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Nunca me Curvarei",
                    SpecialAbilityDescription = "A sua vida de oprimido forjou uma resistência inquebrável. Uma vez por dia, você pode fazer um teste de Vontade (Sorte), com o ND definido pelo Narrador, caso passe, você recebe vantagem em todos testes de resistência por 1 minuto. Essa característica só pode ser usada novamente depois de um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.DevoteeOfDavyJones,
                    OriginName = "Devoto de Davy Jones",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Luck,
                        SkillEnum.Persuasion,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Rei dos Jogos",
                    SpecialAbilityDescription = "Sempre que estiver em uma situação de conflito envolvendo piratas, você pode fazer um teste de vontade (sorte) cujo ND é definido pelo Narrador. No sucesso, o conflito pode ser resolvido com um teste de perícia da escolha do jogador Essa característica só pode ser usada novamente depois de um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Guardian,
                    OriginName = "Guardião",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Perception,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Protetor",
                    SpecialAbilityDescription = "A sua dedicação à proteção da família transcende os limites do cotidiano e se estende até o calor do combate. Uma vez por dia, quando um aliado dentro de uma esfera de até 12 metros sofre dano, você pode realizar um teste de Destreza (Acrobacia), com o ND definido pelo Narrador, um sucesso permite que você salte à frente do aliado como uma reação, empurrando-o 3 metros para trás e assumindo o dano em seu lugar."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Glutton,
                    OriginName = "Glutão",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Intimidation,
                        SkillEnum.Provoke,
                        SkillEnum.Persuasion
                    },
                    SpecialAbilityName = "Paladar Refinado",
                    SpecialAbilityDescription = "Seu paladar vai além do ordinário; ele é verdadeiramente sem igual. Uma vez por dia, ao saborear uma refeição, você pode realizar um teste de Vontade (Sorte), com o ND definido pelo Narrador. Em caso de sucesso, essa característica dobra os efeitos positivos da refeição."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.MadScientist,
                    OriginName = "Cientista Maluco",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Investigation,
                        SkillEnum.Nature,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Genialidade Inusitada",
                    SpecialAbilityDescription = "Sua mente é um caldeirão fervente de criatividade descontrolada e intelecto distorcido, uma vez por dia, ao se deparar com um desafio intelectual, seja na forma de quebra-cabeças, enigmas ou problemas científicos, você pode realizar um teste de Vontade (sorte), com o ND determinado pelo Narrador. Em caso de sucesso, sua genialidade louca surge, proporcionando uma solução única e inesperada para o problema em questão"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Tormented,
                    OriginName = "Atormentado",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Acrobatics,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Acostumado com a Dor",
                    SpecialAbilityDescription = "Sua ligação com a dor e sofrimento permite que você aguente mais que os outros, enquanto fora de combate, caso a sua concentração fosse ser quebrada, você pode fazer um teste de vontade (sorte), caso passe, você mantém sua concentração."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Admirer,
                    OriginName = "Admirador",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Perception,
                        SkillEnum.Performance,
                        SkillEnum.Luck
                    },
                    SpecialAbilityName = "Senpai",
                    SpecialAbilityDescription = "A imagem do seu admirado é tão marcante que, uma vez por dia ao realizar ações fora do combate que ecoam suas características, você pode realizar um teste de Presença (atuação), com o ND definido pelo narrador. Em caso de sucesso, sua representação é tão convincente que cria uma aura inspiradora ao seu redor, concedendo vantagem no seu próximo de Presença, e concedendo a aliados vantagens em testes de Vontade por 1 minuto. Essa característica pode ser usada uma vez, recuperando seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.HeredeInDisenchantment,
                    OriginName = "Herede em Desencanto",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Strength},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Investigation,
                        SkillEnum.Nature,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Berço de Sangue",
                    SpecialAbilityDescription = "O treinamento severo e o isolamento imposto pelo exílio resultaram em uma infância péssima, mas repleta de conhecimento, uma vez por dia, você pode realizar um teste de Vontade (sorte). Se bem-sucedido, você se recorda de uma situação similar que teve como estudo em sua época de cativeiro, permitindo que você receba uma perícia a sua escolha por 1 minuto. Essa característica não poderá ser usada novamente até o término de um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.BornToKill,
                    OriginName = "Nascido para Matar",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Athletics,
                        SkillEnum.Acrobatics,
                        SkillEnum.Stealth,
                        SkillEnum.Perception
                    },
                    SpecialAbilityName = "Um com as Sombras",
                    SpecialAbilityDescription = "Sua habilidade de se dissolver nas sombras é muito útil, uma vez por dia, ao realizar um teste de Destreza (Furtividade) com ND definido pelo Narrador, caso passe você pode receber o efeito invisível por 1 minuto, desaparecendo nas sombras ao seu redor. Esta característica não pode ser usada dentro de combate, e não poderá ser utilizada novamente até completar um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Martyr,
                    OriginName = "Mártir",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Constitution},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Nature,
                        SkillEnum.Luck,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Ato Real de Carinho e Amor",
                    SpecialAbilityDescription = "Sua empatia é sem igual e aberta para todos, uma vez por dia, enquanto fora de combate você pode realizar um teste de Vontade (sorte), caso você passe, pode envolver um alvo qualquer próximo em um abraço que não apenas oferece conforto emocional e acalma os nervos de qualquer um, mas também remove as condições: Alucinado, Amedrontado e Enfurecido. Esta característica só pode ser usada novamente após concluir um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.CapitalSpecialist,
                    OriginName = "Especialista em Capital",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Deception,
                        SkillEnum.Intimidation,
                        SkillEnum.Persuasion,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Amigos nos Lugares mais Altos",
                    SpecialAbilityDescription = "Sua habilidade em lidar com autoridades é incomparável, tanto que uma vez por dia, ao realizar um teste de Vontade (Sorte), com a ND determinada pelo Narrador, você pode empregar táticas subversivas para convencer um membro da marinha ou governo a ignorar, temporariamente, todos os crimes em uma região específica. Este ato de suborno proporciona uma janela de impunidade por 10 minutos, essa característica recupera seu uso após um descanso longo.. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.CommunityHero,
                    OriginName = "Herói da Comunidade",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Deception,
                        SkillEnum.Intimidation,
                        SkillEnum.Persuasion,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Sindicato",
                    SpecialAbilityDescription = "Sua presença em meio aos trabalhadores atua como uma centelha que pode acender as chamas da revolta, uma vez por dia, você pode realizar um teste de Vontade (Sorte), com a ND definida pelo Narrador, caso passe você pode incitar uma revolta espontânea entre os trabalhadores na área. Durante os próximos 10 minutos, o caos resultante demanda a atenção total das forças da marinha e do governo, concedendo a você um período de relativa liberdade para agir sem interferência. Esta característica recupera seu uso após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Circus,
                    OriginName = "Circense",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Deception,
                        SkillEnum.Perception,
                        SkillEnum.Performance,
                        SkillEnum.Luck
                    },
                    SpecialAbilityName = "O Show deve Continuar",
                    SpecialAbilityDescription = "Sua habilidade em encantar o público se estende à generosidade deles, você pode iniciar um show enquanto em um local público uma vez por dia, ao realizar um teste de Vontade (Sorte), caso seja bem-sucedido, seus fãs entusiasmados contribuem generosamente. Você recebe uma quantia em dinheiro equivalente a 1.000 berries multiplicado pelo resultado de 1d10, recuperando suas forças para um novo show após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.DiscipleOfBushido,
                    OriginName = "Discípulo de Bushido",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Perception,
                        SkillEnum.Athletics,
                        SkillEnum.Acrobatics
                    },
                    SpecialAbilityName = "O Caminho da Espada",
                    SpecialAbilityDescription = "Sua dedicação ao Bushido não se limita apenas à guerra, mas se estende à paz interior. Uma vez por dia, você pode realizar um teste de Vontade (Sorte) para encontrar equilíbrio em meio ao caos. Caso seja bem-sucedido, todos aliados próximos de você recebem vantagem no proximo teste de resistência por 1 minuto. Essa característica só pode ser usada novamente após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.ApprenticeOfLegend,
                    OriginName = "Aprendiz da Lenda",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Athletics,
                        SkillEnum.Luck,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Pirralho do Passado ",
                    SpecialAbilityDescription = "Seu passado como parte de uma tripulação lendária abre portas entre os renomados piratas do passado. Uma vez por dia, ao encontrar um pirata renomado, você pode realizar um teste de Vontade (Sorte). Se o teste for bem-sucedido, o pirata se lembrará de você, conferindo-lhe vantagem em todas as interações sociais com este mesmo pirata por 3 minutos. Essa característica pode ser utilizada novamente após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Opportunist,
                    OriginName = "Oportunista",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Luck,
                        SkillEnum.Deception,
                        SkillEnum.Stealth,
                        SkillEnum.Perception
                    },
                    SpecialAbilityName = "Olhos Atentos",
                    SpecialAbilityDescription = "Seu olhar atento e instinto aguçado para oportunidades permite que você, uma vez por dia, faça um teste de Vontade (sorte) com ND definido pelo Narrador. Caso seja bem-sucedido, você identifica uma oportunidade única no ambiente ao seu redor, seja para obter informações valiosas, ganhar vantagem em negociações, ou até mesmo em casos raros, encontrar uma akuma no mi (sujeito ao Narrador). Essa característica só pode ser usada 1 vez e recupera seu uso após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Usurped,
                    OriginName = "Usurpado",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Persuasion,
                        SkillEnum.Stealth,
                        SkillEnum.Perception,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Conexões Recuperadas",
                    SpecialAbilityDescription = "Sua busca por recuperar seu lugar no poder levou a reconectar-se com antigos aliados. Uma vez por dia, ao realizar um teste de Vontade (sorte), você pode restabelecer laços e alianças estratégicas com pessoas em alto nivel de poder que foram perdidos durante sua queda. Está caracteristica pode ser usada novamente apenas após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Explorer,
                    OriginName = "Explorador",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Nature,
                        SkillEnum.Investigation,
                        SkillEnum.Perception,
                        SkillEnum.Persuasion
                    },
                    SpecialAbilityName = "Mestre dos Mares",
                    SpecialAbilityDescription = "Seu conhecimento instintivo dos mares é excepcional. Uma vez por dia, enquanto em alto mar você pode realizar um teste de Vontade (Sorte), caso passe você consegue discernir a melhor rota em meio à névoa ou tempestade, evitando perigos e economizando tempo igual a um navegador. Essa caracteristica pode ser usada uma vez e recupera seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.ExperientHealer,
                    OriginName = "Curandeiro Experiente",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Nature,
                        SkillEnum.Insight,
                        SkillEnum.Perception,
                        SkillEnum.Luck
                    },
                    SpecialAbilityName = "Experiência na Medicina",
                    SpecialAbilityDescription = "Sua capacidade de diagnosticar é quase infalível. Uma vez por dia, ao realizar um teste de Vontade (sorte),caso passe você pode diagnosticar e identificar corretamente condições médicas complexas, proporcionando um guia preciso para o tratamento eficaz. Essa característica pode ser usada um número de vezes igual a sua proficiência e recupera todos os seus usos após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Witch,
                    OriginName = "Bruxa",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Nature,
                        SkillEnum.Deception,
                        SkillEnum.Intimidation,
                        SkillEnum.Luck
                    },
                    SpecialAbilityName = "Não Irrite uma Bruxa",
                    SpecialAbilityDescription = "Seu poder mágico inclui a capacidade de lançar maldições sobre qualquer pessoa que você não gosta. Uma vez por dia, ao realizar um teste de Carisma Vontade (sorte) cujo ND é definido pelo narrador, caso passe você lança uma maldição sob o alvo, fazendo com que ele tenha nada além de puro azar por 3 minutos, causando puro caos na vida dele. Essa característica não pode ser usada em combate e recupera seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Psychologist,
                    OriginName = "Psicólogo",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Nature,
                        SkillEnum.Investigation,
                        SkillEnum.Survival,
                        SkillEnum.Luck
                    },
                    SpecialAbilityName = "Terapia em Grupo",
                    SpecialAbilityDescription = "Sua habilidade de facilitar sessões de aconselhamento em grupo é notável. Uma vez por dia, ao realizar um teste de Vontade (sorte), caso passe você pode conduzir uma sessão terapêutica em grupo, encerrando qualquer condição ou doença mental Essa característica não pode ser usada em combate e recupera seu uso após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin =OriginEnum.Farce,
                    OriginName = "Farsa",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Deception,
                        SkillEnum.Insight,
                        SkillEnum.Luck,
                        SkillEnum.Persuasion
                    },
                    SpecialAbilityName = "Identidade Falsa",
                    SpecialAbilityDescription = "Sua habilidade de se disfarçar é excepcional, tanto que uma vez por dia, ao realizar um teste de Vontade (sorte), caso passe você pode assumir uma identidade completamente diferente, por 10 minutos você não pode ser reconhecido, e pode se misturar com outras facções. Essa característica não pode ser usada em combate e recupera seu uso após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.FreeSpirit,
                    OriginName = "Espírito Livre",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Nature,
                        SkillEnum.Perception,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Me Deixe Virar seu Amigo",
                    SpecialAbilityDescription = "Sua disposição para fazer novas amizades é contagiante, você tem tanta facilidade nisso que uma vez por dia, ao realizar um teste de Vontade (sorte) com ND defnido pelo Narrador, caso passe você pode estabelecer uma conexão rápida e profunda com um novo conhecido. Essa característica não pode ser usada em combate e recupera seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.ToxicFamily,
                    OriginName = "Família Tóxica",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Dexterity},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Aprendizado Infortúnio",
                    SpecialAbilityDescription = "Durante sua juventude você acabou tendo de aprender a ler as emoções dos outros para evitar a fúria de seus familiares, tanto que uma vez por dia, ao realizar um teste de Vontade (sorte) com ND definido pelo narrador, caso tenha sucesso você tem conhecimento pleno dos sentimentos de todos a sua volta que você possa ver o rosto. Essa característica pode ser usada um número de vezes igual a sua proficiência e recupera seus usos após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.AspiringHero,
                    OriginName = "Aspirante a Herói",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Persuasion,
                        SkillEnum.Athletics,
                        SkillEnum.History
                    },
                    SpecialAbilityName = "O Destino Sorriu Para Mim",
                    SpecialAbilityDescription = "O destino sorri gentilmente para você, seja por favoritismo ou por paixão por sua determinação. Ao falhar em uma rolagem de Teste de Atributo ou Salvaguarda, você pode realizar a rolagem novamente, adicionando a sua Proficiência a rolagem, (caso já tenha proficiência, ela é dobrada) sendo que você é obrigado a usar a nova rolagem independente de qualquer coisa. Não é possível rolar novamente uma jogada que foi um erro crítico, recupera o uso após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.GodComplex,
                    OriginName = "Complexo De Deus",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Perception,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "De Joelhos Perante o Seu Novo Deus",
                    SpecialAbilityDescription = "Uma vez por dia você pode realizar um teste de Presença (Intimidação), cujo CD é definido pelo narrador, enquanto estiver em uma vila ou pequena cidade. Caso obtenha sucesso, a aura de superioridade que irradia convence os moradores a prestarem-lhe adoração como se fosse uma divindade. Essa momentânea reverência tem benefícios práticos, como informações privilegiadas, presentes ou até mesmo a disposição dos habitantes para seguir suas ordens com fervor religioso. Essa característica pode ser usada uma vez e recupera seu uso após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.MemoryVoid,
                    OriginName = "Vazio Mnemônico",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Investigation,
                        SkillEnum.Insight,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Eu me Lembro Desse Lugar",
                    SpecialAbilityDescription = "Ao entrar em uma nova ilha ou cidade, você pode realizar um teste de Vontade (Sorte). Caso seja bem-sucedido, fragmentos de memórias há muito perdidas emergem, proporcionando-lhe uma familiaridade sutil com o local. Essas lembranças efêmeras concedem a você a capacidade de discernir a localização de marcos importantes e conhecer figuras proeminentes. Essa característica pode ser usada uma vez por dia e recupera seu uso após um descanso longo. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Homeless,
                    OriginName = "Sem Lar",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Persuasion,
                        SkillEnum.Stealth,
                        SkillEnum.Perception,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Rede De Contatos",
                    SpecialAbilityDescription = "Ao realizar um teste de Vontade (Sorte) enquanto estiver dentro de uma cidade, caso seja bem-sucedido, os outros moradores de rua, invisíveis aos olhos da maioria, reconhecem sua presença e oferecem ajuda de maneiras sutis. Eles compartilham informações valiosas sobre caminhos ocultos, pontos de acesso discretos e até mesmo a localização de figuras importantes. Essa característica pode ser usada uma vez por dia e recupera seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.SearchingForRedemption,
                    OriginName = "Em Busca da Redenção",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Nature,
                        SkillEnum.Perception,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Eu Conheço Esse Sentimento",
                    SpecialAbilityDescription = "Sua busca por redenção moldou sua capacidade de ajudar outros a superarem seus proprios erros. Quando um aliado falha em um teste fora de combate, você pode realizar um teste de Vontade (Sorte). Se for bem-sucedido, você compartilha uma experiência significativa de seu passado, para inspirar e encorajar seu aliado. Ao fazer isso, o aliado tem a oportunidade de tentar novamente o teste com vantagem. Caso já tivesse vantagem, ele recebe um bônus adicional de +2 na jogada. Essa característica pode ser usada uma vez por dia e recupera seu uso após um descanso longo."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.HeraldOfTheNewEra,
                    OriginName = "Arauto da Nova Geração",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Luck,
                        SkillEnum.History,
                        SkillEnum.Nature
                    },
                    SpecialAbilityName = "Passar Adiante",
                    SpecialAbilityDescription = "A vida que você levou o incentivou a sempre compartilhar suas experiências com a nova geração, tanto que uma vez por semana, você pode tentar auxiliar um aliado que está fazendo um treinamento ao fazer um teste de Vontade (sorte) com ND definido pelo Narrador, caso passe a sua orientação será de muito adianto para o aliado que terá os dias necessários reduzidos em 1d8. Essa característica pode ser usada uma vez e recupera seu uso após um descanso longo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.LadyNight,
                    OriginName = "Dama da Noite",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Persuasion,
                        SkillEnum.Deception,
                        SkillEnum.SleightOfHand,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Sussurros da Noite",
                    SpecialAbilityDescription = "Você conhece a arte de ouvir e influenciar, uma habilidade refinada durante suas noites entre sussurros e confidências. Uma vez por descanso longo, você pode invocar a astúcia do seu passado para extrair informações, espalhar rumores ou seduzir informações. Faça um teste de Presença (Persuasão ou Enganação) com ND definida pelo Narrador. Seu passado lhe concede uma compreensão íntima dos desejos e medos humanos, permitindo-lhe manipular as pessoas."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Survivor,
                    OriginName = "Survivor",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Insight,
                        SkillEnum.Stealth,
                        SkillEnum.Perception
                    },
                    SpecialAbilityName = "Instintos de Sobrevivência",
                    SpecialAbilityDescription = "A vida ensinou você a perceber o perigo antes que ele se manifeste e a encontrar um caminho mesmo nas situações mais desesperadoras. Uma vez por descanso longo, você pode fazer um teste de Vontade (Sobrevivência ou Percepção) com ND definida pelo Narrador. Sua experiência em escapar da morte lhe dá uma vantagem única, permitindo-lhe antecipar um perigo na área atual."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.InnateTrust,
                    OriginName = "Confiança Nata",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Persuasion,
                        SkillEnum.Deception,
                        SkillEnum.Intimidation,
                        SkillEnum.Performance
                    },
                    SpecialAbilityName = "Conhecido no Mundo Todo",
                    SpecialAbilityDescription = "Você tem uma habilidade única para unir as pessoas e garantir o apoio necessário quando mais precisa. Uma vez por descanso longo, você pode invocar sua rede de contatos para obter informações, recursos ou assistência. Faça um teste de Presença (Persuasão) com ND definida pelo Narrador. Sua vasta rede de amigos e conhecidos está sempre disposta a ajudar, oferecendo suporte em formas que vão desde abrigo temporário e informações valiosas até reforços em um conflito. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.KidOfTheSea,
                    OriginName = "Criança do Mar",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Survival,
                        SkillEnum.Profession,
                        SkillEnum.History,
                        SkillEnum.Stealth
                    },
                    SpecialAbilityName = "Já Viu de Tudo",
                    SpecialAbilityDescription = "Você desenvolveu uma habilidade extraordinária para viajar por longas distâncias e adaptar-se rapidamente a novos ambientes. Uma vez por descanso longo, você pode realizar um teste de Sabedoria (Sobrevivência ou História) com ND definida pelo Narrador. Sua vida de viagens incessantes lhe conferiu um conhecimento profundo e uma resiliência rara, permitindo-lhe superar obstáculos que outros não podem, desde escalar montanhas e atravessar desertos até tempestades."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Errant,
                    OriginName = "Errante",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Insight,
                        SkillEnum.Persuasion,
                        SkillEnum.Supernatural
                    },
                    SpecialAbilityName = "Caminho da Redescoberta",
                    SpecialAbilityDescription = "A sua jornada de perda também é uma jornada de descoberta. Uma vez por descanso longo, você pode invocar sua busca interior para ganhar insights sobre um problema, pessoa ou lugar. Realize um teste de Vontade (Intuição ou Sobrenatural) com ND definida pelo Narrador. Sua experiência em questionar e reavaliar tudo o que conhecia confere a você uma perspectiva única e a habilidade de perceber o que outros podem não terem notado revelando algum detalhe que deixaram passar. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.RenegadeLeader,
                    OriginName = "Lider Renegado",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Intimidation,
                        SkillEnum.Persuasion,
                        SkillEnum.History,
                        SkillEnum.Athletics
                    },
                    SpecialAbilityName = "Comando Inspirador",
                    SpecialAbilityDescription = "Sua transformação de rebelde solitário para líder respeitado concedeu-lhe uma autoridade natural e uma habilidade para inspirar e comandar. Uma vez por descanso longo, você pode realizar um teste de Presença (Persuasão ou Intimidação) com CD definida pelo Narrador. Caso passe você incentiva seus aliados, dando a todos vantagem em testes sociais por 1 minuto."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.UnstoppableDreamer,
                    OriginName = "Sonhador Imparável",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Strength, AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Survival,
                        SkillEnum.Haki
                    },
                    SpecialAbilityName = "Determinação Inabalável",
                    SpecialAbilityDescription = "Seu foco em seu objetivo é inigualável, e você desenvolveu uma capacidade extraordinária de perseverar além dos seus limites. Uma vez por descanso longo, você pode fazer um teste de Força ou Vontade com ND definida pelo Narrador, caso passe você pode reduzir a duração necessária de seu próximo descanso longo em 2 horas"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Protegee,
                    OriginName = "protégée",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Persuasion,
                        SkillEnum.Insight,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Lições Pra Vida Toda",
                    SpecialAbilityDescription = "A influência duradoura e as lições do seu protetor, proporcionam um momento de inspiração e poder quando você mais precisa. Uma vez por descanso longo, você pode fazer um teste de Vontade cujo ND é definido pelo Narrador, para se concentrar nas lições de seu mentor para superar um desafio. Isso lhe concede vantagem no seu próximo teste de qualquer perícia ou atributo"
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.LastingRivalry,
                    OriginName = "Rivalidade Duradoura",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Will},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Profession,
                        SkillEnum.Insight,
                        SkillEnum.Athletics,
                        SkillEnum.Acrobatics
                    },
                    SpecialAbilityName = "Confronto Destinado",
                    SpecialAbilityDescription = "O seu rival ocupa um lugar especial em seus objetivos e ambições. Uma vez por descanso longo, quando você encontra seu rival, você pode realizar um teste de Vontade para canalizar toda a intensidade de sua rivalidade em foco e determinação. Se for bem-sucedido, você recebe +1 em todos os testes contra ele (incluindo perícias) enquanto fora de combate, esse efeito dura por 1 hora. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Infiltrated,
                    OriginName = "Infiltrado",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Stealth,
                        SkillEnum.Deception,
                        SkillEnum.SleightOfHand,
                        SkillEnum.Insight
                    },
                    SpecialAbilityName = "Expertise",
                    SpecialAbilityDescription = "Seu tempo como infiltrado lhe deu uma compreensão única de como as organizações operam e como as pessoas pensam. Uma vez por descanso longo, você pode fazer um teste de Presença (Enganação), caso tenha sucesso você pode se infiltrar dentro de uma base da marinha ou pirata próxima da sua localização, desde que eles não tenham conhecimento da sua presença no local."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.ConsciousAndroid,
                    OriginName = "Android Consciente",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Wisdom},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Investigation,
                        SkillEnum.Nature,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Analise da Situação",
                    SpecialAbilityDescription = "Sua natureza de androide permite uma introspecção e autoanálise superiores. Uma vez por descanso longo, você pode realizar um teste de Vontade (Sorte) para ativar um modo de autoanálise, permitindo-lhe adaptar suas funções internas para um desafio específico. Se for bem-sucedido, você ganha vantagem em um tipo específico de teste de perícia ou salvamento de sua escolha por 1 hora. "
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.Problematic,
                    OriginName = "Problemático",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Perception,
                        SkillEnum.Athletics,
                        SkillEnum.Intimidation,
                        SkillEnum.Provoke
                    },
                    SpecialAbilityName = "Eu vou te esbulachar",
                    SpecialAbilityDescription = "Seu histórico como problemático lhe proporcionou uma habilidade única para provocar e incitar combates. Uma vez por descanso longo, você pode realizar um teste de Presença (Provocação) para desestabilizar um oponente, ganhando vantagem em seu primeiro ataque contra ele, além disso durante esse combate, esse alvo pode apenas atacar você por 1 minuto."
                },

                new OriginStats{
                    SkillToChoose=2,
                    Origin = OriginEnum.SonOfHeavenAndHell,
                    OriginName = "Filho do Céu e do Inferno",
                    RecommendedAttribute = new List<AttributeEnum>{AttributeEnum.Presence},
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Insight,
                        SkillEnum.Haki,
                        SkillEnum.Perception,
                        SkillEnum.Survival
                    },
                    SpecialAbilityName = "Sagacidade Social ",
                    SpecialAbilityDescription = "Sua vida entre os extremos conferiu-lhe uma habilidade única para se adaptar e prosperar. Uma vez por descanso longo enquanto em uma interação social, você pode fazer um Teste de Vontade (sorte) cuja CD é definida pelo Narrador, caso passe você pode convencer uma pessoa de uma ideia sua, seja um plano alternativo ou receber uma recompensa extra pelos seus esforços. "
                }

            };






    }
}
