using ShinRoll.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace ShinRoll.Data.StaticData.CharacterSpecs.Profession
{
    [NotMapped]
    public class ProfessionStats
    {
        public int Id { get; set; }
        public ProfessionEnum Profession { get; set; } = ProfessionEnum.None;
        public int SkillToChoose { get; set; }
        public List<SkillEnum> SkillsProficiency { get; set; } = new();

        public string SpecialSkillName { get; set; } = string.Empty;
        public string SpecialSkill { get; set; } = string.Empty;
        public List<string> Details { get; set; } = new List<string>();



        public ProfessionStats() { }


        public static readonly List<ProfessionStats> ProfessionList =
            new List<ProfessionStats>{
                new ProfessionStats{

                    Profession = Models.Enums.ProfessionEnum.Trainer,
                    SkillToChoose = 2,
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.Acrobatics,
                        SkillEnum.Performance,
                        SkillEnum.Insight,
                        SkillEnum.Perception,
                        SkillEnum.Persuasion,
                        SkillEnum.Survival
                    },
                    SpecialSkillName = "Lidar com Animais.",
                    SpecialSkill =
                        @"A profissão Adestrador garante que Testes de Atributo relacionados à interação com animais, sejam feitos por meio
da Perícia Especial do Ofício (Lidar com Animais). Desta forma, recebendo os benefícios exclusivos proporcionados
por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Lidar com Animais),
ao invés das perícias normais, são:
Ao tentar intimidar ou resistir ao amedrontamento uma fera;
Ao tentar prestar primeiros socorros em um animal;
Ao tentar identificar o motivo do comportamento estranho em um ou mais animais.",
                    Details = new List<string>
                            {
                                @"Adestrar Animais: 
Ao tentar adestrar um animal selvagem, o Narrador pode pedir um Teste de Atributo com a Perícia Especial do Ofício
(Lidar com Animais) CD 10 + o Nível de Desafio do alvo. O animal adestrado vai ajudá-lo por 24 horas, você poderá
montá-lo e usar suas habilidades para o que desejar. Caso o animal receba dano, seja ordenado a infligir dano a si, ou for
ordenado a atacar seus companheiros ele se liberta do controle, foge ou se torna hostil. Não é possível adestrar mais de
um animal por vez.
Alternativamente, você pode usar esse mesmo teste para tentar se comunicar, afugentar ou acalmar o animal.
Após acalmado, o animal voltará a ser hostil caso ele ou criaturas companheiras dele sejam atacados ou ameaçados de
alguma forma.",

    @"Vínculo Animal
Você pode escolher um único animal para ser seu companheiro mais fiel, ele se tornará seu Animal Vinculado e estará
sempre ao seu lado, sendo treinado diariamente.
Conforme você melhora como adestrador, seu companheiro animal também se torna mais habilidoso,
chegando ao ponto de ser incomparável com qualquer outro animal da mesma espécie, recebendo as seguintes
características:
Você pode montar seu animal vinculado sem receber penalidades, contanto que ele tenha a mesma categoria de tamanho
que você ou maior. Independentemente de você ter proficiência em veículos e montarias.
Salvaguardas de Destreza para manter-se montado, no seu animal, são feitos com vantagem, mesmo sem sela.
Caso o animal vinculado morra ou seja trocado, ao escolher um novo, as características do animal serão as de um Amador
(Novato) na tabela Evolução do Animal Vinculado, a cada 2 dias ele aumentará uma subdivisão ou uma graduação
(quando estiver na subdivisão veterano), até chegar ao nível atual da profissão. Qualquer treinamento que tenha sido
ensinado ao animal anterior não passa para o novo.
O animal adestrado recebe Pontos de Poder iguais ao seu nível de Estilo de Combate, até o máximo de 20 pontos.
Ao término de um descanso longo, o animal adestrado recupera todos os seus Pontos de Vida e Pontos de Poder.
Enquanto você possuir seu animal vinculado, todos os seus gastos de alimentação e hospedagem são dobrados.
Você escolhe um dos animais presentes na tabela Animal Vinculado. Caso queira escolher outro tipo de animal, ele
deve ser aprovado pelo Narrador.
Na graduação Amador e em cada uma das subsequentes, você pode aumentar um valor de atributo do seu
animal vinculado, à sua escolha, em 2 ou aumentar dois valores de atributo, à sua escolha, em 1. Não é possível elevar
um valor de atributo do animal acima de 20 com essa característica.

As Salvaguardas e Testes de Atributo usam os valores de atributo presentes na tabela Animal Vinculado. Você pode
escolher 2 atributos para adicionar o bônus de proficiência do adestrador em suas Salvaguardas e 2 perícias entre
Acrobacia, Atletismo, Furtividade, Intimidação, Investigação, Percepção e Sobrevivência para adicionar o bônus de
proficiência do adestrador.
O animal recebe CR, tamanho, deslocamento e Pontos de Vida de acordo com a coluna PV Inicial da tabela
Animal Vinculado. Com boa nutrição e intenso treinamento, o animal vinculado se torna mais forte e saudável,
superando os limites da própria espécie, aumentando uma categoria de tamanho sempre que você aumenta uma
graduação de adestrador, até a categoria de tamanho Enorme.
Conforme evolui o animal recebe bônus no valor de Pontos de Vida, Classe de Resistência e dano, de acordo com as
colunas Pontos de Vida, Classe de Resistência e Dano Adicional da tabela Evolução do Animal Vinculado.
Esses valores não se acumulam a cada nível, eles são substituídos pelos valores da tabela. Por exemplo, uma
coruja possui 26 PV com um adestrador Amador, quando passa para Profissional, a coruja fica com 56 PV.",

    @"Antes da graduação Profissional, vocês ainda não possuem sincronia, sendo assim, você deve usar sua ação para
direcionar o animal vinculado a fazer uma ação.
Nas jogadas de ataque, é adicionado o modificador do maior atributo entre Força e Destreza + a proficiência
do adestrador. O valor de Constituição não influência os Pontos de Vida do animal.
Durante o combate, o animal vinculado possui iniciativa igual ao do seu adestrador, pode se deslocar, mas
sua ação deve ser feita no turno do adestrador (apenas as ações atacar, disparada, esconder e procurar), dependente
do adestrador usar sua própria ação para isso.
O animal vinculado pode usar ação bônus, reação e ação poderosa, desde que tenha alguma característica ou
técnica que exija o uso dessas atividades.
Seus ataques podem ter o tipo de dano Perfurantes, Cortantes ou Contundente e dão 1d6 + o maior
modificador entre Força e Destreza do animal.",

    @"Evolução
Graduação Especialista: O animal pode fazer uma ação em seu próprio
turno, sem necessidade do adestrador usar sua própria ação para isso.
Graduação Mestre: Agora o seu animal vinculado pode atacar duas
vezes, ao invés de uma, quando usar a ação Atacar durante o seu
turno.",

    @"Você consegue ensinar ao seu animal vinculado qualquer treinamento que você já possuir, presente no Capítulo 5, com
exceção dos Treinamentos de Espécie. Para isso, deve estar à disposição do animal todas as ferramentas necessárias
para o treino, ele precisa ter os atributos exigidos nos requisitos de cada treinamento e deve ter condições físicas para
exercer o treinamento ou será impossível que o animal o aprenda, por exemplo, uma águia não conseguiria atirar com
um arco e flecha. São adicionados 10 dias extras aos dias já exigidos para cada treinamento e o requisito de Pontos de
Treinamento é ignorado.
O seu animal vinculado só pode aprender até 3 treinamentos. Para cada dia exigido pelo treinamento, são
necessárias 6 horas do adestrador, durante esse tempo, o adestrador deve estar dedicando total atenção ao seu animal
vinculado. O animal deve estar pelo menos dentro doEstilo de Vida Modesto, podendo se alimentar devidamente bem
e ter um local para descansar tranquilamente.

EVOLUÇÃO
Graduação Mestre: Você passa a poder ensinar ao seu animal vinculado treinamentos que você não aprendeu. Sempre que você quiser que o animal inicie um treinamento que você não possui,
além do animal ter que possuir todas as exigências normais da característica Treinamento Animal, você deve passar em um Teste de Atributo com a Perícia Especial do Ofício (Lidar com Animais) CD 18, caso falhe, o animal não pode iniciar o treinamento e você
deve esperar 1 semana para tentar ensinar qualquer treinamento que você ainda possuir novamente.
Neste teste você não pode conseguir um sucesso automático com nenhuma característica que você possa vir a ter.",

    @"Um adestrador tem que ter conhecimento sobre todo o mundo animal e seus habitats, sobre métodos de ensino para
animais, medicina veterinária, alimentação e outros conhecimentos.
Um adestrador precisa sempre estar com seus conhecimentos afiados para cuidar dos animais feridos
durante os descansos e continuar evoluindo os treinamentos para seus animais.
De acordo com a graduação, ferramentas de adestradores vem com diferentes tipos de livros de veterinária,
nutrição animal e de treinamento animal, chicote, apito, 1 kit médico e 3 kits de primeiros socorros."                            }



                },


                new ProfessionStats{

                    Profession = Models.Enums.ProfessionEnum.Archaeologist,
                    SkillToChoose = 2,
                    SkillsProficiency = new List<SkillEnum>{
                        SkillEnum.History,
                        SkillEnum.Insight,
                        SkillEnum.Investigation,
                        SkillEnum.Perception,
                        SkillEnum.Persuasion,
                        SkillEnum.Survival
                    },
                    SpecialSkillName = "História Perdida",
                    SpecialSkill = @"A profissão Arqueólogo garante que Testes de Atributo relacionados à exploração e descobrimento, sejam feitos por
meio da Perícia Especial do Ofício (História Perdida). Desta forma, recebendo os benefícios exclusivos
proporcionados por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (História Perdida), ao
invés das perícias normais, são:
Ao tentar decifrar ou transcrever corretamente uma língua antiga;
Ao tentar lembrar de informações sobre o local e cultura de uma civilização;
Ao tentar identificar ou restaurar um artefato encontrado.",

                            Details = new List<string>
{
    @"Recebe os seguintes itens: Ferramentas de Arqueólogo (amador), 1 mochila pequena, 1 lanterna, 1 corda e 1 tenda.",

    @"PONEGLYPHS
As escrituras dos Poneglyphs são complexas e o acesso as informações para decifrar seus segredos já está perdido.
Ainda assim, com estudo e recolhendo informações, é possível tentar entender seus significados.
Poneglyphs Históricos: Poneglyphs Históricos falam da história ou trazem dicas do local, histórias do século

perdido ou detêm recados para as próximas gerações. Para serem decifrados totalmente, é necessário ser bem-
sucedido em um Teste de Atributo com a Perícia Especial do Ofício (História Perdida) CD 20.

Poneglyphs Instrutivos: Poneglyphs Instrutivos geralmente indicam onde podem ser encontrados outros

Poneglyphs, armas antigas e objetos inestimáveis. Para serem decifrados totalmente, é necessário ser bem-
sucedido em um Teste de Atributo com a Perícia Especial do Ofício (História Perdida) CD 25.

Poneglyphs Caminho: Existem 4 Poneglyphs Caminho, que indicam como chegar até Laugh Tale. Para serem
decifrados totalmente, é necessário ser bem-sucedido em um Teste de Atributo com a Perícia Especial do Ofício
(História Perdida) CD 30.
FALHAR EM UMA TRADUÇÃO
Caso falhe em decifrar as escrituras de um Poneglyph ou texto antigo, você ainda pode continuar tentando. Após
estudar por 3 dias, você pode repetir o teste, reduzindo em 5 o CD, cada vez que você repetir a tentativa de tradução.",

    @"EXPLORADOR ATENTO
Quando você passa por experiências relacionadas à exploração de locais e ruínas, você pode conseguir buscar pistas para
desarmar ou passar ileso por armadilhas, achar um outro caminho ou achar um jeito melhor de resolver cada situação.
Sempre que você fizer Testes de Atributo ou Salvaguardas para esses cenários, você recebe vantagem.",

    @"IDENTIFICAR AKUMA NO MI
Ao encontrar uma Akuma no Mi, você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (História
Perdida) para saber qual tipo de poder ela concede. O Narrador ainda pode decidir que a Akuma no Mi é irreconhecível
ou não catalogada.
A CD do teste é 15 para frutos historicamente relevantes, CD 20 para frutos obscuras e CD 25 para frutos
desconhecidas. Além disso, não é possível receber um sucesso automático nessa característica.",

    @"ENCONTRAR TESOURO
Adentrando calabouços, ruinas e cidades antigas, você pode usar seu conhecimento em estruturas antigas e costumes
culturais de povos ancestrais para descobrir acessos obstruídos, mecanismos e passagens secretas, podendo descobrir
os mais variados tipos de tesouros.
No início de uma exploração, o Narrador pode pedir que você faça um Teste de Atributo com a Perícia Especial
do Ofício (História Perdida), caso seja bem-sucedido, você encontra pistas para achar um tesouro escondido.
Encontrando a câmara secreta, jogue um d8 para saber quais dos tesouros na tabela Tesouros Perdidos foi
achado. Caso o resultado do dado seja um artefato (Dial, Arma Meito, Equipamento Engenhado ou Akuma no Mi), jogue
um d10 para escolher uma opção entre as suas subdivisões, que podem estar danificados ou em perfeito estado.
Caso o resultado seja Joias e Ouro, você recebe riquezas em um valor igual ao seu nível de personagem x 25
milhões de bellys.",

    @"EVOLUÇÃO 
Graduação Profissional: Ao encontrar tesouros, caso o resultado seja Dial, você pode rolar novamente o d10 e
receber o conjunto de dial 2 vezes ao invés de uma, de acordo com os resultados.
Graduação Especialista: Ao encontrar tesouros, e após jogar um d8 para saber qual tesouro foi encontrado dos
disponíveis na tabela Tesouros Perdidos, você pode ignorar o resultado e jogar mais uma vez o d8, escolhendo o
segundo resultado. Essa característica só funciona uma vez em cada tesouro.
Graduação Mestre: Ao encontrar tesouros, caso o resultado seja um artefato, quando for jogar o dado para saber
qual subdivisão do artefato foi encontrada, você pode jogar o dado duas vezes e escolher qualquer um dos dois
resultados.",

    @"FERRAMENTAS DE ARQUEÓLOGO
Um arqueólogo precisa estudar muito para se tornar um bom profissional. Precisa ler diversos livros e adquirir
conhecimento do mundo inteiro e sua história e cultura.
Para um arqueólogo é essencial estar sempre lendo inúmeros livros e aumentando seu conhecimento. Além
disso deve ter o conhecimento de culturas antigas, seus costumes e atividades, para identificar artefatos e objetos
antigos.
De acordo com a graduação, ferramentas de arqueólogos vem com diferentes tipos de livros de história,
geografia e culturas antigas, 1 chicote, 1 porta mapas, 1 caderno e caneta e 1 kit de escalada."

                        }
                },



                new ProfessionStats{
    Profession = Models.Enums.ProfessionEnum.BountyHunter,
    SkillToChoose = 2,
    SkillsProficiency = new List<SkillEnum>{
        SkillEnum.Stealth,
        SkillEnum.Intimidation,
        SkillEnum.Investigation,
        SkillEnum.Perception,
        SkillEnum.Persuasion,
        SkillEnum.Survival
    },
    SpecialSkillName = "Caça",
    SpecialSkill = @"A profissão Caçador de Recompensas garante que Testes de Atributo relacionados à procura e perseguição, sejam
feitos por meio da Perícia Especial do Ofício (Caça). Desta forma, recebendo os benefícios exclusivos proporcionados
por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Caça), ao invés das
perícias normais, são:
Ao tentar achar pistas ou pegadas em uma floresta;
Ao tentar negociar com um agente do governo ou membro da Marinha;
Ao tentar lembra de informações relacionadas a crimes ou segurança pública.",
            Details = new List<string>
            {
                @"CONTRATO CLANDESTINOS
Caçadores de recompensas sempre buscam conseguir contatos em todos os lugares, se relacionando com todo tipo de
gente para facilitar seus negócios. Suas relações se expandem te tal maneira que possuem até acordos com membros
corruptos da Marinha e do Governo Mundial, fazendo com que mesmo se o caçador seja um pirata ou criminoso de
qualquer tipo, ele consiga, por debaixo dos panos, negociar as recompensas daqueles que conseguiu caçar, pagando uma
propina com parte dos seus ganhos.
Dependendo se você possui contatos no local, você consegue fechar acordos que pagam 70% do valor original
da recompensa para criminosos vivos.
O Narrador pode pedir ao caçador um Teste de Atributo com a Perícia Especial do Ofício (Caça) para ver se ele
já tem ou conhece alguém para negociar, ou para conseguir conhecer e negociar com um novo contato confiável.
RECOMPENSAS
O sistema de recompensas é um meio que o Governo Mundial tem de agilizar o processo de captura de criminosos,
fazendo com que suas identidades sejam divulgadas e oferecendo um prêmio em dinheiro pela sua captura. Desta
forma, aumenta a quantidade de pessoas em busca desses procurados, muitos tomam isso como profissão e se tornam
caçadores de recompensas.
Os cartazes de procurados geralmente dizem que o criminoso deve estar Vivo ou Morto, indicando que seu
direito a vida foi revogado, da mesma forma, outros direitos também não se aplicam, por exemplo, não é crime roubar
de piratas.
Quanto mais perigoso o Governo Mundial considerar um criminoso, maior será a recompensa dada pela sua
cabeça, porém, pode existir uma redução de até 40% do valor que seria pago, quando eles são entregues
mortos, pois o Governo Mundial e a Marinha preferem fazer execuções públicas e usá-las de exemplo.

EVOLUÇÃO
Graduação Profissional: Você consegue negociar com seus contatos da Marinha ou do Governo Mundial para
aumentar o valor recebido pela captura de criminosos e consolidar acordos que pagam 75% do valor total da
recompensa, desde que estejam vivos até o momento que for entregue.
Graduação Especialista: Os acordos agora pagam 80% do valor total da recompensa, desde que estejam vivos até
o momento que for entregue.
Graduação Mestre: Os acordos agora pagam 90% do valor total da recompensa, desde que estejam vivos até o
momento que for entregue.",

                @"INFORMAÇÕES CONFIÁVEIS

Para um caçador de recompensas reunir informações é metade do trabalho. Ao definir sua
próxima caçada, é necessário que ele conheça bem seu alvo. O que vai definir o quão
difícil é obter as informações é o tipo de alvo, existindo aqueles que são mais cuidadosos
com sua privacidade e aqueles que fazem questão de se exibir.
São muitas as informações que você precisa conseguir para estar pronto para
iniciar sua caçada. Essas informações abrangem não só o alvo como suas conexões locais
e de lugares distantes. Também é importante saber o nível de ameaça que o alvo
representa, mensurando tanto sua força individual quanto a de seus subordinados
ou companheiros. Algumas outras informações necessárias do alvo são seus hábitos,
rotinas, locais que habita, fraquezas, inimigos, manias, capacidades de combate.
Na maioria dos casos, os alvos se encaixam nas categorias apresentadas
abaixo, entretanto, há alguns que vão se encaixar em mais de um tipo de
categoria, nestes casos, o Narrador decide qual é a mais relevante. Os tipos são:
Pessoa Comum: São pessoas que vivem uma vida normal e, na maioria dos casos, não faz
ideia de que podem estar sendo alvos de caçadores, o que facilita bastante o seu
rastreamento e o acúmulo de informações para o trabalho.
Figura Pública: Podem ser governantes, políticos, celebridades ou qualquer
pessoa que se destaque na sociedade, embora o rastreamento desta pessoa seja algo absurdamente fácil de conseguir,
o acesso às informações, quando não restrito, é poluído e cheio de meias verdades e informações falsas.
Criminoso Procurado: Criminosos são os mais comuns a serem alvos de caçadores, alguns são famosos e
experientes, sabem como apagar seus rastros ou silenciar possíveis delatores; outros são mais reclusos ou novatos,
não chamando grande atenção e mais difíceis de localizar, como consequência.
Identidade Oculta: Geralmente, são pessoas que possuem uma grande influência no submundo, mas preferem se
manter anônimas para manter algum tipo de status em alguma sociedade ou proteger títulos. Essas pessoas tendem
a ter organizações próprias para fazer suas vontades, realizar seus planos e usar pseudônimos. São tipos difíceis de
conseguir qualquer tipo de informação ou paradeiro.
Entidade: São o tipo mais difícil de conseguir qualquer coisa, uma vez que a sua própria existência não é
comprovada. São conhecidas assim porque um grupo de indivíduos começa a atrelar acontecimentos a uma pessoa
ou criatura. Essa vinculação, correntemente tem indícios de serem verdadeiros, mas nunca fatos e provas.
O caçador pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Caça) para reunir informações suficientes
para Marcar um Alvo, obtidas através de todo tipo de fonte disponível. Você pode fazer o Primeiro Teste quando
tiver a primeira ciência do alvo em potencial, para saber se já tem conhecimentos prévios. Esse primeiro contato pode
ocorrer quando o caçador vê o alvo em um cartaz de procurado ou ao receber um pedido direto.
Você também pode fazer Novos Testes quando entrar em uma cidade ou local que tenha uma ligação com o
alvo, quando conversar com uma pessoa que possua informações sobre o alvo, quando tiver acesso a uma nova
informação ou outras situações que o Narrador julgar possíveis. A CD para cada teste está na tabela Pesquisa e
Investigação.
Dependendo do intervalo de tempo desde o primeiro teste, você pode repetir o teste sem ter novas informações com a
mesma CD do Primero Teste, a quantidade de tempo é pré-determinada de acordo com a coluna Repetir Teste da
tabela Pesquisa e Investigação. Quando o tempo é indeterminado, o Narrador decide quando o teste pode ser refeito.
Custo: Sempre que você usar essa característica, você deve gastar uma quantidade de dinheiro definido pelo
Narrador, geralmente entre 5.000 a 25.000 bellys. Esse dinheiro pode ser para suborno ou presentes para agradar
a fonte das suas informações.

EVOLUÇÃO
Graduação Especialista: Conforme foi adquirindo experiência, você se condicionou a se manter atento a todo
tipo de informação sobre as pessoas e personalidades que estiverem sob o seu olhar. Quando fizer o primeiro teste
para tentar marcar um alvo e falhar, você pode repetir esse teste com a mesma CD.
Graduação Mestre: Quando você for fazer o primeiro teste para marcar uma criatura, você pode usar o CD dos
novos testes.",

                @"ALVO MARCADO 
Quando você passa em um Teste de Atributo com a Perícia Especial do Ofício (Caça) para conseguir informações sobre um alvo, você pode escolher
marcar este alvo e receber alguns bônus durante sua caçada.
Você só pode escolher uma única criatura por vez, caso desista de marcar a criatura, terá até 3 dias para marcá-la novamente sem precisar repetir o teste.
Você recebe os seguintes benefícios ao marcar um alvo:
Marca do Caçador: Você tem vantagem em Testes de Atributo de Vontade (Percepção) ou Sabedoria (Sobrevivência) para rastrear seu alvo marcado,
assim como em Testes de Atributo de Sabedoria para lembrar informações sobre ele. 
Você também recebe vantagem em Testes de Atributo de Destreza (Furtividade), para se esconder do seu alvo marcado.
Passos Longos: Durante uma perseguição ao seu alvo marcado, terreno difícil
proveniente do solo e da natureza não afeta o seu deslocamento.
Dificultar Detecção: O alvo marcado por você
tem desvantagem em tentar fazer testes de Sabedoria ou Vontade para te localizar.

EVOLUÇÃO
Graduação Especialista: Suas habilidades em caçar acompanham o seu renome, você consegue marcar até 2 alvos
ao mesmo tempo e nunca esquece um alvo já marcado, fazendo com que possa, a qualquer momento, sem precisar
de um gatilho, fazer um novo teste para marcar o alvo em sua memória.
Graduação Mestre: Suas habilidades também chegaram ao ápice, você consegue manter até 3 alvos marcados ao
mesmo tempo.",

                @"FERRAMENTAS DE CAÇADOR DE RECOMPENSAS
Para que caçadores de recompensa desempenhem bem suas atividades é necessário que eles possuam conhecimentos
diversificados e ferramentas que os auxiliem e ajudem onde eles tiverem défices.
Para que isso seja possível, caçadores de recompensas devem estar sempre lendo livros de assuntos diversos
e cada vez mais detalhados e didáticos, sobre investigação, sociologia, geologia e história. Além de precisarem de
ferramentas específicas.
De acordo com a graduação, ferramentas de caçador de recompensas vem com diferentes tipos de livros de
comportamento, história e outros temas diversos, 3 kits de primeiros socorros, 2 cordas, 2 pares de algemas e 1 tipo
de bússola à sua escolha (bússola ou log pose).",
    }
},



                new ProfessionStats{
    Profession = Models.Enums.ProfessionEnum.Carpenter,
    SkillToChoose = 2,
    SkillsProficiency = new List<SkillEnum>{
        SkillEnum.Acrobatics,
        SkillEnum.Athletics,
        SkillEnum.History,
        SkillEnum.Investigation,
        SkillEnum.Persuasion,
        SkillEnum.SleightOfHand
    },
    SpecialSkillName = "Carpintaria",
    SpecialSkill = @"A profissão Carpinteiro garante que Testes de Atributo relacionados à construção em geral, sejam feitos por meio da
Perícia Especial do Ofício (Carpintaria). Desta forma, recebendo os benefícios exclusivos proporcionados por cada
graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Carpintaria), ao invés
das perícias normais, são:
Ao tentar realizar trabalhos manuais de marcenaria para criar objetos, fortificar portas, escadas e etc.;
Ao tentar replicar perfeitamente uma peça com madeira;
Ao tentar entender mecanismos simples ou complexos de engenharia.",
            Details = new List<string>
            {
                @"RECEBE OS SEGUINTES ITENS: Ferramenta de Carpinteiro (amador), 1 mochila pequena.",

                @"CONSERTO EM MADEIRA
Conforme o navio vai sendo danificado, é necessário que o carpinteiro repare esses danos. Este trabalho é mais
cuidadoso e detalhista, pois a ideia é ser uma manutenção de qualidade para longo prazo, por isso, é gasto mais tempo
e deve ser usado o tipo de madeira mais indicado para navegações.
O tempo de conserto vai variar dependendo do quão danificado a embarcação está. Junto com isso, também
são acrescentados custos adicionais de outros materiais que serão necessários para o conserto. As definições do conserto
estão presentes na tabela Navio Danificado.

Dependendo do tipo de madeira que você vai querer utilizar, o custo varia para cada Ponto de Vida recuperado, conforme
demonstrado abaixo:
Cedro: Para cada 1 Ponto de Vida recuperado do navio, é gasto um valor de ฿ 40.000 em peças de madeira.
Carvalho: Para cada 1 Ponto de Vida recuperado do navio, é gasto um valor de ฿ 100.000 em peças de madeira.
Cerejeira: Para cada 1 Ponto de Vida recuperado do navio, é gasto um valor de ฿ 190.000 em peças de madeira.
Adam: Para cada 1 Ponto de Vida recuperado do navio, é gasto um valor de ฿ 500.000 em peças de madeira.",

                @"ARQUITETAR NAVIO
O carpinteiro tem os conhecimentos e vigor necessário para criar embarcações de qualquer tamanho, junto com
cômodos, velas, mastros e etc. Todos os detalhes das embarcações, como valor, peças, propriedades, estão todos no
Capítulo 14, mais a frente neste Livro.

EVOLUÇÃO
Graduação Especialista: Seus conhecimentos e habilidades permitem que construa com muito mais eficácia,
evitando gastos desnecessários de matéria prima, diminuindo em 10% todos os gastos necessários para a
construção e reparos de uma embarcação e seus componentes.
Graduação Mestre: As embarcações criadas por um mestre recebem +12 nós (24 km/h) de bônus de velocidade
e adicionar a madeira um bônus na CR de +3. Em casos de embarcações já construídas, o carpinteiro pode fazer um
Teste de Atributo com a Perícia Especial do Ofício (Carpintaria) CD 18 para garantir os mesmos bônus. Em caso de
falha, o teste pode ser repetido após 1 semana.",

                @"CONFECÇÃO RÁPIDA
Desde que haja madeira, um carpinteiro pode criar qualquer coisa. Com uma ação
ou 6 segundos, o carpinteiro pode construir 1,5 m2 de um tipo de estrutura.
A estrutura terá uma Classe de Resistência 10 e para cada 1,5 m2 que
possuir, ela terá 10 Pontos de Vida.
Chão: Uma construção para possibilitar ou aumentar o espaço de
livre movimentação de criaturas.
Escada: Uma construção com vários degraus para acessar locais
mais altos de forma rápida.
Parede: Construção para proteção contra ataques e contra o clima.
Criaturas que usem essas paredes como proteção podem se beneficiar das regras
de cobertura (Capítulo 12).
Ponte: A construção perfeita para ligar locais altos e separados, da forma mais
direta possível. Possibilita que qualquer criatura possa se deslocar de forma segura,
normalmente ou em disparada, sem a necessidade de Salvaguardas para não cair.
Custo: Sempre que você usar essa característica, você gasta ฿ 22.000 de tábua de madeira como matéria prima
(ou uma quantidade de madeira que o Narrador considere suficiente, por exemplo, destroços de navios ou pedaços
de árvores) para cada 1,5 m2 e 3d6 kit de construção.",

                @"REPARO EMERGENCIAL
Um carpinteiro eficiente é capaz de fazer reparos no navio após uma batalha e até durante, mesmo em pleno mar e com
poucos recursos. Usando os equipamentos que estiverem ao alcance, partes do próprio navio ou qualquer tipo de
material possível, como destroços do navio inimigo.
Você deve fazer um Teste de Atributo com a Perícia Especial do Ofício (Carpintaria) CD 15, para saber se vai
ser possível o reparo com os recursos disponíveis. Em caso de falha, o teste pode ser repetido após 5 minutos.
O tempo de reparo dura 2 minutos e recupera 5d10+10 Pontos de Vida, inicialmente. Esse reparo é temporário,
desta forma, após 2d6 dias, todos os PV recuperados com essa característica são perdidos, caso o navio não seja
devidamente consertado.
Custo: Sempre que você usar essa característica, você gasta 1d6 kit de construção.

EVOLUÇÃO
Graduação Profissional: Ao usar essa característica, passam a ser recuperados 10d10+20 Pontos de Vida.
Graduação Especialista: Ao usar essa característica, passam a ser recuperados 16d10+30 Pontos de Vida.
Graduação Mestre: Ao usar essa característica, passam a ser recuperados 30d10+50 Pontos de Vida.",

                @"CORPO DE CONSTRUTOR
Graças à natureza do trabalho bruto que um carpinteiro exerce, seu corpo adaptou-se a alturas elevadas, suportar uma
carga maior de peso e passar várias horas exercendo um trabalho árduo. Isso lhe garante alguns benefícios como:
Bônus de +2 em Testes de Atributo e Resistência para manter o equilíbrio em qualquer situação;
Dobra o valor base da sua capacidade de carga;
O carpinteiro pode tentar ser bem-sucedido em uma Salvaguarda de Constituição CD 10, para não receber 1 Nível
de Exaustão. Caso já tenha qualquer Nível de Exaustão antes de fazer o teste, a CD aumenta em +2 para cada nível.
Essa característica não poderá ser usada novamente até o término de um descanso longo;
Recebe vantagem em Testes de Atributo de Força (Atletismo).
",
                @"FERRAMENTAS DE CARPINTEIRO
Carpinteiros são extremamente dependentes de suas ferramentas, uma vez que, são elas que possibilitam a
transformação da madeira em outras formas.
Para que o carpinteiro consiga desempenhar bem sua profissão são necessários livros cada vez mais
detalhados e ferramentas mais resistentes, afiadas, precisas ou maiores.
De acordo com a graduação, ferramentas de carpinteiros vem com diferentes tipos de livros de marcenaria
e engenharia, 10 plantas de construção, 1 serrote, 1 martelo, 1 kit de construção.",
    }
},

                new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Combatant,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.Acrobatics,
      SkillEnum.Athletics,
      SkillEnum.Stealth,
      SkillEnum.Intimidation,
      SkillEnum.Provoke,
      SkillEnum.Survival
  },
  SpecialSkillName = "Noção de Batalha.",
  SpecialSkill = @"A profissão Combatente garante que Testes de Atributo relacionados à batalha e estratégia, sejam feitos por meio da
Perícia Especial do Ofício (Noção de Batalha). Desta forma, recebendo os benefícios exclusivos proporcionados por
cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Noção de Batalha), ao
invés das perícias normais, são:
Ao tentar se manter frio para perceber um detalhe que passou desapercebido na batalha;
Ao tentar adivinhar onde estariam posicionados os inimigos e sua quantidade;
Ao tentar prever os planos e estratégia de um grupo inimigo.",
          Details = new List<string>{
              @"RECEBE OS SEGUINTES ITENS: Ferramenta de Combatente (amador), 1 mochila pequena.",

              @"COMANDO RÁPIDO
Durante um combate, desde que você possa ver onde seu aliado está, você pode instruir ele nas batalhas, usando uma
linguagem corporal ou com sua voz. Essas instruções são os Comandos e podem ajudar um companheiro seu a desviar
de golpes, atacar pontos fracos do inimigo, aproveitar melhor seu movimento, entre outras coisas.
Fazer um comando eficaz é a combinação de analisar a situação, tomar decisões e instruir um aliado seu
corretamente, para isso, você deve usar 1 reação quando um dos seguintes acontecimentos ocorrer em uma batalha:
Ajuda: Quando um aliado seu for realizar uma jogada de ataque, a próxima jogada de ataque dele recebe vantagem.
Alerta: Quando um aliado seu for alvo de uma jogada de ataque, ele recebe +3 na CR para escapar deste ataque.
Dica: Quando um aliado seu for realizar uma jogada de ataque, ele recebe 1d10 de dano extra, caso acerte.
Motivação: Quando um aliado gastar PP, ele recupera até 2 pontos. Este comando só pode ser usado 1 vez por
encontro em cada aliado.
Orientação: Quando um aliado usa seu deslocamento, ele recebe 3 metros adicionais e seu deslocamento não pode
ser reduzido por terreno difícil.
Para saber se os comandos foram bem-sucedidos, em cada comando o Narrador pode pedir que você faça um Teste de
Atributo com a Perícia Especial do Ofício (Noção de Batalha) CD 12.

EVOLUÇÃO
Graduação Profissional: Quando você usar essa característica, você poderá fazer mais 1 Comando em outra
criatura, que ainda não tenha sido afetada por um Comando, como parte da mesma reação.
Graduação Especialista: Quando você usar essa característica, você poderá fazer mais 2 Comandos em outras
criaturas, que ainda não tenham sido afetadas por um Comando, como parte da mesma reação.
Graduação Mestre: Quando você usar essa característica, você poderá fazer mais 3 Comandos em outras criaturas,
que ainda não tenham sido afetadas por um Comando, como parte da mesma reação.
",

              @"PROTETOR
Durante um encontro ou exploração, criaturas que não participam de combates (geralmente personagens controlados
pelo Narrador) e estão a até 6 metros de você recebem sua proteção, ficando imunes a dano, contanto que você não
esteja com a condição Incapacitado.
Além disso, sempre que uma dessas criaturas falhar em um Teste de Atributo ou Salvaguarda, você pode usar
sua reação para garantir a ela um sucesso, arcando você mesmo com as consequências da falha (o Narrador decide o
dano ou os efeitos que você sofrerá).",

              @"ANÁLISE DE COMBATE
Ao ver uma criatura qualquer, você pode usar seus conhecimentos e experiências de batalha para tentar avaliar o
tamanho da ameaça que ela pode proporcionar a você e seus companheiros.
O Narrador pode pedir que você faça um Teste de Atributo com a Perícia Especial do Ofício (Noção de Batalha)
CD 16 + o modificador de Presença da criatura. Caso o teste seja bem-sucedido, o Narrador vai revelar 1 informações da
tabela Características do Alvo, à sua escolha. Cada vez que você subir uma graduação nesta profissão, a partir do
Especialista, você pode pedir ao Narrador uma informação adicional, quando for bem-sucedido no teste.
Em caso de falha, o combatente deve jogar 1d4 duas vezes e cada resultado corresponderá a uma característica
que o Narrador vai revelar para você. Se os resultados forem iguais, jogue novamente até sair um resultado diferente.
Você não poderá tentar analisar uma criatura que você já tenha falhado em analisar, até que você suba uma
subdivisão ou graduação ou até que se passe 1 mês desde a última vez que você tentou analisar a criatura.

EVOLUÇÃO
Graduação Profissional: Fazer um teste para analisar uma criatura passa a ter uma CD 14 + o modificador de
Presença da criatura.
Graduação Especialista: Fazer um teste para analisar uma criatura passa a ter uma CD 12 + o modificador de
Presença da criatura.",

              @"CONHECIMENTO DE COMBATE
O combatente está sempre alerta contra ameaças e pensando na melhor forma de vencer. Para isso, ele busca ajudar
seus aliados, potencializando as chances de vitória.
Antes de estipular a ordem de iniciativa de um encontro, você pode fazer um Teste de Atributo com a Perícia
Especial do Ofício (Noção de Batalha) CD 15. Se passar no teste, você e todas as criaturas aliadas recebem os seguintes
bônus até o encontro se encerrar:
Melhor Posicionamento: Você e qualquer criatura aliada recebe +5 em suas jogadas de iniciativa;
Alerta Precavido: Você e qualquer criatura aliada, que esteja a até 9 metros de você não poderá ser surpreendida,
durante todo o encontro;
Encorajar: Você e qualquer criatura aliada, que esteja a até 9 metros de você recebe 10 Pontos de Vida temporários,
que somem após o encontro;
Inspirar Determinação: Você e qualquer criatura aliada recebe 6 Pontos de Poder adicionais, com as mesmas
regras dos Pontos de Vida temporários, que somem após o encontro;
Auxílio Imediato: Você e qualquer criatura aliada, que esteja a até 9 metros de você recebe vantagem em qualquer
teste contra armadilhas;
Experiência Compartilhada: Quando o combatente for forçado a fazer uma Salvaguarda para diminuir o dano
sofrido e outras criaturas aliadas forem fazer o mesmo teste, se você passar, todas as criaturas aliadas recebem
vantagem no teste.
Plano de Ação: Você pode escolher uma criatura aliada para distrair ou ser o foco dos inimigos. Durante o encontro,
o dano causado contra criaturas aliadas diferentes da que você escolheu sempre recebem 5 pontos de redução.
Essa característica não poderá ser usada novamente até o término de um descanso longo.

EVOLUÇÃO
Graduação Profissional: Quando a tentativa de usar essa característica falhar, ela não será considerada como um
dos seus usos. Além disso, a característica Encorajar passa a adicionar 30 PV temporários.
Graduação Especialista: Essa característica passa a poder ser usada até 3 vezes e você recupera todos os seus usos
ao término de um descanso longo. Além disso, a característica Encorajar passa a adicionar 50 PV temporários.",

              @"FERRAMENTAS DE COMBATENTE
Combatentes estão sempre estudando, observando e anotando seus pensamentos para que consigam evoluir suas
habilidades.
Para que combatentes consigam evoluir seus conhecimentos é necessário que participem de diversos tipos
de batalha e leiam livros específicos sobre o combate e sua história.
De acordo com a graduação, ferramentas de combatente vêm com diferentes tipos de livros de estratégias e
anatomia, cadernos de anotações, 3 kits de primeiros socorros e 1 kit de escalada.",
  }
},

                new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Chef,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.Performance,
      SkillEnum.Insight,
      SkillEnum.Persuasion,
      SkillEnum.SleightOfHand,
      SkillEnum.Provoke,
      SkillEnum.Survival
  },
  SpecialSkillName = "Gastronomia.",
  SpecialSkill = @"A profissão Cozinheiro garante que Testes de Atributo relacionados à produção de alimentos e saúde alimentar, sejam
feitos por meio da Perícia Especial do Ofício (Gastronomia). Desta forma, recebendo os benefícios exclusivos
proporcionados por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Gastronomia), ao invés
das perícias normais, são:
Ao tentar achar alimentos em locais escassos, como cogumelos subterrâneos dentro de uma caverna;
Ao tentar verificar se um alimento está estrago ou envenenado;
Ao tentar decifrar ingredientes só ao sentir o aroma de uma preparação.",
          Details = new List<string>{
              @"RECEBE OS SEGUINTES ITENS: Ferramenta de Cozinheiro (amador), 1 mochila pequena.",

              @"REFEIÇÃO DO CHEF
Você cria pratos, chamados de Refeição do Chef, que buscam trazer uma nutrição que ultrapassa a culinária normal
e garante benefícios magníficos.
Ao iniciar o dia, você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Gastronomia) CD 15,
para preparar as refeições do chef. Em caso de falha, os personagens que comeram seus pratos devem escolher apenas
1 característica para se beneficiar, entre Alimento Medicinal, Alimento Energético, Descanso Pleno e Nutrição
Superior. Em caso de sucesso, eles podem se beneficiar de 2 características, à escolha de cada criatura.
Desde que os personagens se alimentem de pelo menos uma refeição do chef, eles podem escolher receber os
benefícios dos seus pratos, sem precisar usar nenhuma ação, até o término do próximo descanso longo.",

              @"ALIMENTO MEDICINAL
Um preparo com os alimentos cuidadoso, usando as formas certas de cocção, escolhendo os melhores alimentos e
temperos, o cozinheiro consegue explorar e potencializar sua carga nutritiva e medicinal.
Desde que o personagem tenha se alimentado de uma Refeição do Chef no dia, ao realizar um descanso longo,
ele recupera 1 Nível de Exaustão adicional, além do que normalmente recuperaria.
Caso o personagem esteja sofrendo com uma doença, enquanto ele estiver se alimentando com os pratos do
cozinheiro, o tempo que ele pode ficar sem tratamento antes do óbito é dobrado (esse benefício se mantém mesmo se
essa característica não for escolhida pelo jogador no dia).",

              @"ALIMENTO ENERGÉTICO
Um preparo com os alimentos cuidadoso, usando as formas certas de cocção, escolhendo os melhores alimentos e
temperos, o cozinheiro consegue explorar e potencializar sua carga nutritiva e energética.
Desde que o personagem tenha se alimentado de uma Refeição do Chef no dia, quando realizar um descanso
curto ou longo, ele recupera 5 Pontos de Poder.",

              @"DESCANSO PLENO
Um preparo com os alimentos cuidadoso, feito para trazer não apenas saciedade, mas também para que o organismo de
quem as come esteja em perfeito funcionamento.
Desde que o personagem tenha se alimentado de uma Refeição do Chef no dia, no final de um descanso curto,
ao gastar um ou mais Dados de Vida, ele recupera Dados de Vida adicionais de acordo com o valor de bônus de
proficiência do personagem.
Ao passar de nível, enquanto o personagem estiver se alimentando com os pratos do cozinheiro, caso o
resultado do dado de vida para aumentar os Pontos de Vida máximos seja entre 1 e 3, ele deve jogar o dado novamente
(esse benefício se mantém mesmo se essa característica não for escolhida pelo jogador no dia).",

              @"NUTRIÇÃO SUPERIOR
Um preparo com os alimentos cuidadoso, usando as formas certas de cocção, escolhendo os melhores alimentos e
temperos, o cozinheiro consegue explorar e potencializar sua carga nutritiva.
Desde que o personagem tenha se alimentado de uma Refeição do Chef no dia, uma vez por dia, ele pode usar
uma ação e recuperar Pontos de Vida em um valor igual ao dobro do nível de personagem dele.
Caso o personagem seja reduzido a 0 Pontos de Vida e não morra, enquanto ele estiver se alimentando com os
pratos do cozinheiro, uma vez por descanso longo, ao invés de cair inconsciente ele recupera 1 Ponto de Vida (esse
benefício se mantém mesmo se essa característica não for escolhida pelo jogador no dia).
Custo: Sempre que você usar essa característica para fazer uma Refeição do Chef, você gasta 1d6 kit de temperos
e ฿ 3.000 em alimentos para cada prato.",

              @"EVOLUÇÃO
Graduação Profissional: No caso de sucesso no teste de preparo das refeições do chef, cada criatura pode escolher
até 3 características.
Graduação Especialista: No caso de falha no teste de preparo das refeições do chef, cada criatura ainda pode
escolher até 2 características.
Graduação Mestre: No caso de sucesso no teste de preparo das refeições do chef, cada criatura recebe todas as
características.",

              @"PREPARO PERFEITO
Um preparo com os alimentos cuidadoso, usando as formas certas de cocção,
escolhendo os melhores alimentos e temperos, o cozinheiro consegue explorar
e potencializar todas as propriedades dos alimentos.
Você prepara refeições usando todo o seu conhecimento sobre a
culinária e alimentos, com o objetivo de conseguir um sabor divino aos seus
degustadores, que supra qualquer necessidade.
Desde que os personagens se alimentem de pelo menos uma refeição
do chef, eles podem escolher um dos seguintes benefícios, no início do turno
deles e sem precisar usar suas ações, até o término do próximo descanso longo.
Você aumenta em +1 à sua Classe de Resistência, por 1 minuto (não cumulativo);
Você encerra sobre si uma das seguintes condições: Atordoado, Envenenado,
Estremecido, Letárgico, Sangramento ou Sonolento;
Você pode escolher jogar novamente uma jogada de ataque em que você falhou;
Você pode recuperar 1 Nível de Exaustão;
Você recebe +3 metros de deslocamento normal, por 1 minuto;
Você recebe 1d12 de dano extra, após saber que a jogada de ataque acertou;
Você recupera 1d6 Pontos de Poder;
Você recebe vantagem em Salvaguardas de Constituição, por até 1 minuto;
Você recupera 5 vezes o valor do seu modificador de Constituição em Pontos de Vida.

EVOLUÇÃO
Graduação Profissional: Cada criatura, que tenha se alimentado de pelo menos uma refeição do chef, pode
escolher até 2 vezes essas características.
Graduação Especialista: Cada criatura, que tenha se alimentado de pelo menos uma refeição do chef, pode
escolher até 3 vezes essas características.
Graduação Mestre: Cada criatura, que tenha se alimentado de pelo menos uma refeição do chef, pode escolher
até 4 vezes essas características.",

              @"FERRAMENTAS DE COZINHEIRO
Cozinheiros estão sempre com suas ferramentas de trabalho, com elas, eles conseguem realizar preparações e
adicionar textura, sabor e aromas magníficos aos seus pratos.
Para que cozinheiros consigam aumentar suas habilidades é necessário ler livros cada vez mais detalhados e
boas facas e temperos, entre outros materiais.
De acordo com a graduação, ferramentas de cozinheiro vem com diferentes tipos de livros gastronômicos,
receitas e nutrição, 1 kit de cozinha, 3 kits de temperos, e 1 roupa de gala."
  }
},

new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Engineer,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.History,
      SkillEnum.Insight,
      SkillEnum.Investigation,
      SkillEnum.Perception,
      SkillEnum.SleightOfHand,
      SkillEnum.Survival
  },
  SpecialSkillName = "Engenharia",
  SpecialSkill = @"A profissão Engenheiro garante que Testes de Atributo relacionados à mecânica e engenharia, sejam feitos por meio
da Perícia Especial do Ofício (Engenharia). Desta forma, recebendo os benefícios exclusivos proporcionados por cada
graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Engenharia), ao invés
das perícias normais, são:
Ao tentar fazer melhorias mecânicas em navios;
Ao tentar interagir com sistemas complexos de segurança ou ter acesso a informações em computadores;
Ao tentar entender estruturas complexas de engenharia.",
          Details = new List<string>{
              @"APRIMORAR EQUIPAMENTO
É possível para o engenheiro, ao fazer um Teste de Atributo com a Perícia Especial do Ofício (Engenharia) ampliar o
alcance de armas à distância aumentando suas duas distâncias em 6 metros, melhorar a qualidade e manuseio de armas
corpo a corpo aprimorando seu bônus de acerto em +1, ambos com a Classe de Dificuldade 14.
Para melhorar o fio de armas com lâminas para ignorar invulnerabilidades e resistências e revestir armas e
munições (20 por vez) com Kairoseki você deve passar em um Teste de Atributo com a Perícia Especial do Ofício
(Engenharia) CD 17.
Na tentativa de melhorar um equipamento, se o resultado no d20 for 1, ele quebra automaticamente sem forma
de reparo.
Custo: Sempre que você usar essa característica, você gasta 1d6 kit de construção e mais ฿ 20.000.

EVOLUÇÃO
Graduação Especialista: Ao melhorar o alcance de uma arma o aumento das distâncias de uma arma à distância
se torna 9 metros e o bônus de acerto de armas corpo a corpo aumenta para +2.
Graduação Mestre: Ao melhorar o alcance de uma arma o aumento das distâncias de uma arma à distância se
torna 12 metros e o bônus de acerto de armas corpo a corpo aumenta para +3.",

              @"CRIAR ARMA DE GRANDE PORTE
Os engenheiros também são capazes de construir armas para navios e fortalezas, essas armas são especialmente criadas
para destruir construções como embarcações, muralhas e castelos.
Por terem esta finalidade, precisam ser robustas e com grande poder de fogo. Não são muito complexas, mas
demandam bastante tempo de construção, pelo seu tamanho e para serem resistentes em batalhas.
As especificações para construção destas armas estão no Capítulo 14.",

              @"CRIAR ENGENHOCA
É possível inventar equipamentos com propriedades peculiares e muito úteis. Cada equipamento engenhado possui
dials diferentes em sua estrutura misturados com engenharia para produzir resultados diversos. Para criar esses
equipamentos é necessário passar em um Teste de Atributo com a Perícia Especial do Ofício (Engenharia). Caso o
engenheiro falhe no Teste, ele deve comprar mais materiais no valor de 10% do custo total. Os dials necessários, custo
de produção, tempo necessário trabalhando em sua construção e Classe de Dificuldade estão especificados na tabela
Criar Equipamento Engenhado.",

              @"DISPARADOR DE POP GREEN
O engenheiro pode criar um disparador de sementes pop green, fazendo um Teste de Atributo com a Perícia Especial do
Ofício (Engenharia) CD 15 e gastando ฿ 90.000.
A arma terá todas as mesmas propriedades de um mosquete e será capaz de disparar as sementes, porém, não
será capaz de disparar nenhum outro tipo de munição.",

              @"CONSTRUIR ROBÔ
Em um determinado momento da profissão você consegue reunir elevados conhecimentos de mecânica e computação
e com essas duas áreas, explorar a construção de máquinas muito mais sofisticadas e complexas.
A criação de um robô demanda muito tempo, dinheiro e recursos, por isso, apenas o conhecimento não é o
suficiente para tal criação. O custo da construção de um corpo robótico, sua manutenção mensal (que inclui o uso de
possíveis armamentos e munições) e o custo de fontes de energia estão presente na tabela Construção Robótica.
A inteligência de um robô é limitada a cumprir ordens simples, por esse motivo, o engenheiro é capaz de
comandar um robô por vez.

Robôs não se recuperam ao descansar, para retornar seus Pontos de Vida é necessário que ele seja consertado. Quando
danificado, o seu conserto pode variar de acordo com o dano recebido. Quando um robô é reduzido a 0 Pontos de Vida,
ocorre perda total do seu funcionamento, o engenheiro pode fazer um Teste de Atributo com a Perícia Especial do Ofício
(Engenharia) CD 14 para tentar recuperar as partes vitais do corpo robótico, se passar no Teste, o robô recupera 1 Ponto
de Vida e você pode pagar o custo de dano grave para consertá-lo totalmente. O custo, de acordo com cada dano recebido
pelo robô, está especificado na tabela Reparar um Robô

Inicialmente o engenheiro só é capaz de controlar um único robô ativado por vez, independente de quantos você tenha
construído. A partir do momento da criação, o robô só seguirá as ordens do seu criador. Todo comando durante um
combate requer uma ação bônus, conforme você passa a controlar mais de um simultaneamente você pode comandar
os robôs com a mesma ação bônus.
Durante um encontro a iniciativa de um robô é a mesma do seu criador.

ORDENS
Um robô possui algumas ações pré-programadas, caso ele seja atacado, o robô analisa o grau de ameaça e ataca de
volta, a não ser que seja ordenado a permanecer passivo e não revidar no momento ou previamente. Caso ele veja seu
criador sendo atacado ele também assume ações para proteger seu mestre automaticamente.
O robô precisa de ordens para realizar as determinadas ações:
Atacar: Esta ordem faz com que um ou mais inimigos sejam alvos dos ataques do robô, ele não para o ataque até
que todos os alvos estejam incapacitados ou que seja ordenado a parar.
Defender: Esta ordem é exclusiva para quando você deseja ser protegido pelo robô.
Movimentação: Um conjunto de ordens que definem para onde o robô deve ir, se manter ou quem deve seguir.
Parar: Uma ordem absoluta que faz o robô cessar qualquer ordem anterior ou ação que ele esteja fazendo.
Proteger: Esta ordem define um local, passagem ou pessoa a quem o robô deva defender, usando a força ou não.
O engenheiro é capaz de criar 3 tipos de robôs:
Beta: O robô Beta é feito de forma ainda rudimentar e seu corpo ainda possui muitos pontos expostos e fraquezas,
além de ser usado um metal pouco resistente em sua construção.
Alpha: O robô Alpha é feito de forma a tentar equilibrar a qualidade com o custo de produção, visando um resultado
satisfatório para muitas tarefas.
Ômega: O robô Ômega é resultado de um grande conhecimento da robótica, fundindo os mais altos conhecimentos
de engenharia mecânica e programação, ele é capaz de competir até mesmo com os robôs da Marinha.

EVOLUÇÃO
Graduação Especialista: Você consegue controlar até 2 robôs simultaneamente.
Graduação Mestre: Você consegue controlar até 3 robôs simultaneamente.",

              @"FERRAMENTAS DE ENGENHEIRO
Engenheiros necessitam estar supridos de bons equipamentos para que seus trabalhos superem as criações comuns
e muitas vezes é impossível realizar certas criações sem as ferramentas certas.
Um engenheiro tem que estar sempre buscando conhecimento para que suas habilidades evoluam e ele se
torne capaz de criar e entender mecanismos mais complexos, além disso, deve possuir ferramentas que possam ser
capazes de possibilitar que sua imaginação ganhe forma.
De acordo com a graduação, ferramentas de engenheiro vem com diferentes tipos de livros de engenharia
mecânica, física e computação, 1 martelo, 1 kit de chaves e 1 mini computador."
  }
},

new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Doctor,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.History,
      SkillEnum.Insight,
      SkillEnum.Investigation,
      SkillEnum.Perception,
      SkillEnum.SleightOfHand,
      SkillEnum.Survival
  },
  SpecialSkillName = "Medicina",
  SpecialSkill = @"A profissão Médico garante que Testes de Atributo relacionados à tratamentos de doenças e ferimentos, sejam feitos
por meio da Perícia Especial do Ofício (Medicina). Desta forma, recebendo os benefícios exclusivos proporcionados
por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Medicina), ao invés das
perícias normais, são:
Ao tentar realizar uma cirurgia, cuidar de ferimentos graves, implantar próteses e etc.;
Ao tentar diagnosticar uma doença ou saber os melhores remédios para prescrever;",
          Details = new List<string>{
              @"RECEBE OS SEGUINTES ITENS: 1 Ferramenta de Médico (amador), 1 mochila pequena.",

              @"CONTROLE DE DOENÇAS
Um dos trabalhos do médico é sempre pesquisar e guardar amostras de doenças em que
ele já teve algum contato. Para que sua tripulação não tenha dificuldades com doenças
conhecidas e para melhor lidar com as novas.
Quando alguma criatura estiver sofrendo os efeitos de alguma doença ou
veneno, você pode fazer um Teste de Atributo com a Perícia Especial do Ofício
(Medicina) CD 16 para analisar a composição do agente infeccioso. Em caso de um
sucesso, após 3d6 dias, você consegue guardar as informações obtidas e manipular
o agente para os seguintes usos, sempre que necessário:
Criar Cura: Ao ser bem-sucedido em um Teste de Atributo com a Perícia Especial
do Ofício (Medicina) CD 18, e após 2 horas de trabalho, você pode criar 5 doses de
um antídoto, cura ou vacina para combater o agente. Quando utilizado em criaturas,
remove qualquer efeito ou condição, durante as batalhas, e elas são totalmente
curadas do agente infeccioso em 1d4 horas (nos casos em que a doença pode ser
curada);
Criar Cura em Massa: Ao ser bem-sucedido em um Teste de Atributo com a Perícia
Especial do Ofício (Medicina) CD 22, e após 5 horas de trabalho, você pode criar uma
única dose que ao entrar em contato com o ar espalha uma fumaça com os mesmos
efeitos de um antídoto, cura ou vacina em uma esfera de 9 metros de raio. Remove
qualquer efeito ou condição das criaturas afetadas, durante as batalhas, e elas são
totalmente curadas do agente infeccioso em 1d12 horas (nos casos em que a doença
pode ser curada).

Custo: Sempre que você usar essa característica e seus usos, você gasta 1d6 kit médico.
",

              @"TRATAR FERIMENTOS
O médico é o especialista encarregado de zelar pela saúde dos necessitados e enfermos, tratando suas feridas e doenças
por meio da administração de cuidados manuais e medicamentos.
O tratamento tem a duração de 1 minuto, e a cada vez que é concluído, são recuperados 2d10+10 Pontos de
Vida. Durante o processo de tratamento, o médico usa concentração; caso a concentração seja perdida, o tempo
investido no tratamento é anulado, e o médico precisa reiniciar o procedimento.
Apesar de aplicar os melhores cuidados para curar e tratar a ferida de uma criatura, o corpo humano apresenta
limitações. Não é viável restaurar completamente danos mais severos sem o descanso adequado. Portanto, o número
máximo de Pontos de Vida que um médico pode recuperar em um único personagem, sem o repouso necessário, é igual
a 10 vezes o nível do personagem.

Custo: Sempre que você usar essa característica, você gasta 2 kits médicos.

EVOLUÇÃO
Graduação Profissional: Ao realizar o tratamento para recuperar os Pontos de Vida de uma criatura, você passa
a curar 3d10+30.
Graduação Especialista: Ao realizar o tratamento para recuperar os Pontos de Vida de uma criatura, você passa
a curar 4d10+40.
Graduação Mestre: Ao realizar o tratamento para recuperar os Pontos de Vida de uma criatura, você passa a curar
6d10+60. Além disso, você consegue fazer executar um tratamento usando apenas sua ação, essa característica não
poderá ser usada novamente até o término de um descanso longo.",

              @"TRATAR DOENÇAS
Apenas médicos são capazes de diagnosticar doenças e tratá-las. Após usar 1 minuto para analisar o paciente o médico
pode tratar o paciente com medicamentos, usando uma ação. A criatura medicada fica sem os sintomas da doença e não
sofre os efeitos da condição pelas próximas 24 horas, após isso, deve ser tratada adequadamente.
Algumas doenças têm seu tratamento especificado no Capítulo 10. Para tratar essas doenças, o Narrador pode
pedir um Teste de Atributo com a Perícia Especial do Ofício (Medicina) CD 18 menos o modificador de Constituição do
paciente. A CD aumenta em 1 para cada dia que passe sem que a doença esteja sendo tratada.
Outras doenças não especificadas, geralmente, têm a duração do seu tratamento igual a 1d4+1 dias e custam ฿
30.000 para serem tratadas. Para tratar essas doenças, o Narrador pode pedir um Teste de Atributo com a Perícia
Especial do Ofício (Medicina) CD 16 menos o modificador de Constituição do paciente. A CD aumenta em 1 para cada
dia que passe sem que a doença esteja sendo tratada.

Custo: Sempre que você usar essa característica, você gasta 1d6 kit médico.",

              @"INSPEÇÃO MÉDICA
O médico está sempre acompanhando e cuidando da saúde de seus companheiros, fazendo com que todos os tripulantes
do navio estejam em ótima forma e prontos para os perigos.
Desde que uma criatura que passe mais de 1 semana com o médico, não esteja com nenhum Nível de Exaustão
e com mais da metade dos Pontos de Vida, ela recebe os seguintes benefícios:
Vantagem em qualquer Salvaguarda contra a condição Bêbado, Envenenado, Letárgico, Queimadura e
Sangramento;
Vantagem em qualquer Salvaguarda contra doenças.

Custo: Ao início de cada semana, devem ser gastos ฿ 25.000 para cada criatura que você quiser que seja afetada por
essa característica.",

              @"TRATAR DANOS BRUTAIS
Você pode fazer cirurgias que curam o paciente e trazem de volta a sua saúde. Ao realizar a cirurgia você precisa estar
em um local apropriado e esterilizado com todas as ferramentas necessárias à mão.
O Narrador pode pedir um Teste de Atributo com a Perícia Especial do Ofício (Medicina) CD 15 menos o
modificador de Constituição do paciente. A CD aumenta em 1 (máximo de 5) para cada dia que passe sem que a ferida
esteja sendo tratada.
Dos vários tipos de Danos Brutais, o Narrador pode decidir que a ferida foi ainda mais grave e ocorreu uma das
lesões presentes na tabela Ferida Brutal, com CD própria, custo adicional, tempo de cirurgia e um efeito específico,
que pode ser tratado com remédio e tratamentos manuais, usando uma ação para passar em um Teste de Atributo com
a Perícia Especial do Ofício (Medicina) CD 14 menos o modificador de Constituição da criatura, para amenizar por 1
hora os efeitos.
A Classe de Dificuldade de algumas lesões muda de acordo com sua gravidade, porém, ainda pode ser reduzida
pelo modificador de Constituição do paciente, normalmente.

Custo: Sempre que você usar essa característica, você gasta 2 kits médicos e 1d4 ampola de anestesia.",

              @"PARAMEDICINA
Com o conhecimento de tratar vítimas de ferimentos graves, você pode garantir que as vidas das criaturas sejam
protegidas. Usando uma ação bônus você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Medicina)
CD 17 para tratar uma criatura que esteja inconsciente com 0 Pontos de Vida.
Em caso de uma falha, você encerra as condições Letárgico, Queimado, Sangramento e Sonolento, caso
a criatura tratada esteja sendo afetada por alguma delas, e concede 50 Pontos de Vida Temporários que duram por até
1 hora e protegem a criatura contra outros eventuais danos, mas não acordam a criatura. Em caso de um sucesso, você
encerra as mesmas condições e recupera metade dos Pontos de Vida da criatura, arredondado para baixo, por 1 minuto.
Após esse tempo, a criatura volta a cair inconsciente a 0 Pontos de Vida, independentemente de ter recuperado outros
Pontos de Vida, e deve completar um descanso curto ou longo para acordar.
Essa característica só pode garantir os efeitos de sucesso no teste uma única vez em cada criatura, após isso, só
pode afetar a mesma criatura para atribuir os efeitos do teste falho.
Após um descanso longo, a criatura pode receber novamente os efeitos de um teste bem-sucedido.

Custo: Sempre que você usar essa característica, você gasta 1 kit de primeiros socorros.",

              @"FERRAMENTAS DE MÉDICO
Médicos precisam estar sempre lendo e aprendendo novos tratamentos enquanto se preparam criando novos
remédios e antídotos, além disso, precisam de ferramentas adequadas para tratamentos e cirurgias.
Para que médicos consigam aumentar suas habilidades é necessário ler livros cada vez mais detalhados e
boas ferramentas de higiene e tratamento de enfermos.
De acordo com a graduação, ferramentas de médico vem com diferentes tipos de livros de anatomia,
medicina e bioquímica, 1 kit médicos e 3 kits de primeiros socorros."
  }
},


                new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Musician,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.Acrobatics,
      SkillEnum.Performance,
      SkillEnum.Deception,
      SkillEnum.Stealth,
      SkillEnum.Intimidation,
      SkillEnum.Insight,
      SkillEnum.Perception,
      SkillEnum.Persuasion,
      SkillEnum.SleightOfHand,
      SkillEnum.Provoke
  },
  SpecialSkillName = "Canção",
  SpecialSkill =
                @"A profissão Músico garante que Testes de Atributo relacionados às relações interpessoais e apresentações musicais,
sejam feitos por meio da Perícia Especial do Ofício (Canção). Desta forma, recebendo os benefícios exclusivos
proporcionados por cada graduação, ao invés de usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Canção), ao invés das
perícias normais, são:
 Ao tentar impressionar multidões;
 Ao tentar cativar interesses românticos;
 Ao tentar trazer felicidade e motivação aos seus companheiros.",
          Details = new List<string>{
              "RECEBE OS SEGUINTES ITENS: 1 Ferramenta de Músico (amador), 1 mochila pequena.",

              @"ALMA DE ARTISTA
Seu corpo e alma são devotados à arte da música, desta forma, você treinou arduamente com instrumentos e nos
conhecimentos musicais. Isso lhe garante alguns benefícios como:
Você é imune à condição Letárgico e Sonolento;
Você é proficiente com qualquer tipo de instrumento musical e possui uma linda voz;
Você recebe vantagem em Testes de Atributo de Vontade (Percepção), relacionado à audição;
Quando uma criatura passar em uma Salvaguarda para resistir ao efeito de uma canção sua, você pode fazer um Teste de
Atributo com a Perícia Especial do Ofício (Canção) CD 16 para fazer com que a criatura repita o teste. Essa característica
pode ser usada até 3 vezes e você recupera todos os seus usos ao término de um descanso longo.",

              @"REPERTÓRIO ENCANTADOR
Como músico, além de suas músicas normais, você tem um conjunto especial que conseguem influenciar as emoções
das pessoas em um nível inacreditável. Você usa uma ação no início de cada um dos seus turnos para manter uma música
e seus efeitos. Além disso, você só consegue manter um tipo de música ao mesmo tempo. Uma música que não
especifique uma duração é instantânea.
Todas os efeitos dessas músicas têm um alcance de até 15 metros ao seu redor e afetam uma criatura específica
ou todas as criaturas dentro desse alcance que você possa ver, que possam te ouvir e não passem em uma Salvaguarda
de Presença com CD igual à 8 + seu bônus de proficiência + seu modificador de Presença. Você pode usar essas músicas
uma quantidade de vezes igual ao seu bônus de proficiência e você recupera todos os seus usos ao término de um
descanso longo.
Música da Paz: Com sua música, você tenta suprimir emoções fortes de cada criatura à sua escolha dentro do
alcance. Se uma criatura falhar na Salvaguarda, escolha um dentre os dois efeitos a seguir.
Você pode acalmar qualquer motivo que esteja fazendo a criatura ficar hostil, por até 1 minuto. Depois disso,
o motivo volta, a menos que sua duração tenha terminado nesse meio tempo.
Alternativamente, você pode fazer com que um alvo fique indiferente às criaturas que você escolher. Essa
indiferença acaba se o alvo for atacado, ferido ou se testemunhar algum de seus amigos sendo ferido. Quando o
efeito terminar, a criatura se tornará hostil novamente, a menos que o Narrador diga o contrário.
Música da Sedução: Você tenta enfeitiçar um humanoide que você possa ver dentro do alcance. O alvo recebe
vantagem no teste se você ou seus companheiros estiverem lutando com ele. Se ele falhar, ele receberá a condição
Enfeitiçado por 1 hora ou até que você ou seus companheiros façam qualquer coisa nociva contra ele. A criatura
enfeitiçada o trata de forma amigável. Quando o efeito acabar, a criatura saberá que foi enfeitiçada por você.

131
Música do Herói: Uma criatura voluntária que você escolher é imbuída com bravura. Durante até 1 minuto, a
criatura é imune à condição Amedrontado e ganha Pontos de Vida temporários igual ao seu nível de personagem,
no início de cada turno dela. Quando o efeito acabar, o alvo perde qualquer Ponto de Vida temporário restante dessa
música.
Música da Confusão: Essa música ataca e embaralha as mentes das criaturas, gerando delírios e provocando ações
descontroladas. Cada criatura à sua escolha, dentro do alcance, deve ser bem-sucedida em uma Salvaguarda, quando
você usar essa música.
Um alvo afetado não pode realizar reações e deve rolar um d10 no início de cada um dos seus turnos para
determinar seu comportamento nesse turno, de acordo com a tabela Confusão.

Ao final de cada um dos seus turnos, um alvo afetado pode realizar uma Salvaguarda de Sabedoria. Se for bem-
sucedido, esse efeito acaba nesse alvo.

Música de Ninar: Uma música para encantar os inimigos e fazer com que caiam em um sono profundo. Jogue
12d12; o total é a quantidade de Pontos de Vida de criaturas afetados pela música. As criaturas hostis conscientes
dentro da área da música, e que possam te ouvir, são afetadas em ordem ascendente dos Pontos de Vida atuais delas.
Começando com as criaturas com menos Pontos de Vida atuais, cada criatura afetada por essa música cai
inconsciente até sofrer dano ou alguém usar sua ação para sacudi-la ou esbofeteá-la até acordar. Subtraia os Pontos
de Vida de cada criatura do total antes de seguir para a próxima criatura com menos Pontos de Vida atuais. Os
Pontos de Vida atuais da criatura devem ser iguais ou menores que o valor restante para que a criatura possa ser
afetada.
Música da Distração: Você performa uma música chamativa, fazendo as criaturas, à sua escolha realizarem uma
Salvaguarda de Presença. Qualquer criatura que não puder ser enfeitiçada, passa automaticamente nesse teste e, se
você ou seus companheiros estiverem lutando com a criatura, ela terá vantagem na Salvaguarda.
Se falhar na Salvaguarda, a criatura terá desvantagem em Testes de Atributo de Vontade (Percepção) feitos
para notar qualquer criatura além de você, até a música acabar ou até o alvo não poder mais ouvir você. O efeito
acaba se você estiver Incapacitado ou incapaz de falar.
Música da Dança Irresistível: Durante 1 minuto, criaturas à sua escolha que você puder ver, devem realizar uma
Salvaguarda de Vontade. Um alvo passa automaticamente nesse teste se ele não puder ser enfeitiçado. Se falhar no
teste, até a música acabar, você pode usar uma ação bônus em cada um dos seus turnos, para designar uma direção
horizontal a você. Cada criatura afetada deve se mover, da melhor forma possível, para essa direção no próximo
turno dela. Ela pode realizar sua ação antes de se mover. Depois de se mover dessa forma, ela pode realizar outra
Salvaguarda para tentar acabar com o efeito.
Um alvo não é obrigado a se mover em direção de um perigo obviamente mortal, como uma fogueira ou abismo,
mas ele vai provocar ataques de oportunidade por se mover na direção designada.
Música do Desrespeito: Você faz uma música voltada a insultar uma criatura que você possa ver, o alvo dos
ataques deve ser bem-sucedido em uma Salvaguarda de Presença para não receber a condição Enfurecido.",

              @"ESPETÁCULO
Ao performar uma música, com uma ação no início de cada um dos seus turnos, ela atrai ou repele as criaturas de sua
escolha. Você escolhe criaturas dentro do alcance de 18 metros de você e as envolve com uma aura que pode atrair ou
repelir essas criaturas por até 1 hora, pedindo Salvaguardas de Presença com CD igual à característica Repertório
Encantador. Escolha Antipatia ou Simpatia como efeito da aura.
Antipatia: A música faz com as criaturas designadas por você se sintam fortemente impelidas em deixar a área e
evitar sua música. Caso a criatura esteja procurando por você ou seus aliados e se aproximar por mais de 18 metros,
a criatura deve ser bem-sucedida em um teste ou decidirá não procurar pelo local de onde a música está vindo.
Simpatia: A música faz com que as criaturas escolhidas se sintam fortemente impelidas a se aproximar de sua
música. Quando uma dessas criaturas puder te ver ou ficar a 18 metros de você, a criatura deve ser bem-sucedida
em um teste ou usará seu deslocamento em cada um dos seus turnos para entrar na área ou se mover até o alcance
da música. Quando a criatura tiver feito isso, ela não poderá se afastar da sua música voluntariamente. Se a criatura
afetada for ferida de alguma forma, a criatura afetada pode realizar um novo teste para terminar o efeito, como
descrito abaixo.

TERMINANDO O EFEITO:
Se uma criatura afetada terminar seu turno enquanto não estiver a até 18 metros de você ou não for capaz de vê-lo, a
criatura faz um teste. Em um sucesso, a criatura não estará mais afetada e sentirá algo estranho quanto à música. Uma
criatura que obtenha sucesso na Salvaguarda contra esse efeito ficará imune a ele por 1 minuto, depois desse tempo, ela
pode ser afetada novamente.
",

              @"SHOWMAN
Quando você realiza uma performance, você recebe 1 Pontos de Audiência para cada criatura que esteja vendo o seu
espetáculo. Você pode receber até 100 pontos em uma semana e duram até o início da próxima semana. Esses pontos
podem ser usados das seguintes formas:
Canção Energizante: Com uma ação, 20 Pontos de Audiência podem ser trocados por uma música que faz uma
criatura, escolhida por você, que esteja a até 9 metros e possa ouvi-lo, recuperar 2 Pontos de Poder.
Canção da Perseverança: 40 Pontos de Audiência podem ser trocados para jogar novamente um Teste de Atributo
ou Salvaguarda que você tenha falhado.
Canção do Retorno: Com uma ação, 50 Pontos de Audiência podem ser trocados por uma música que faz uma
criatura, escolhida por você, que esteja a até 9 metros e possa ouvi-lo, que esteja derrubada a 0 Pontos de Vida,
levante com 1 Ponto de Vida.
Auxílio Musical: Com uma ação bônus, 20 Pontos de Audiência podem ser trocados para assegurar que uma
criatura, escolhida por você, que esteja a até 9 metros e possa ouvi-lo, realize uma Salvaguarda, um Teste de Atributo
ou uma jogada de ataque com um bônus de +3 na rolagem. A criatura beneficiada por essa ação tem até 1 minuto
para utilizar esse benefício e só pode usufruir de um bônus de cada vez.
EVOLUÇÃO
Graduação Profissional: Você pode usar a Canção da Perseverança consumindo apenas 20 Pontos de Audiência.
Graduação Especialista: Você pode usar a Canção do Retorno consumindo apenas 25 Pontos de Audiência.
Graduação Mestre: Você começa todo dia com 20 Pontos de Audiência.
",

              @"FERRAMENTAS DE MÚSICO
Músicos estão sempre praticando com seus instrumentos e cantorias, aprendendo novas músicas, instrumentos e
atingindo novos escalas de afinação.
Para que músicos consigam aumentar suas habilidades é necessário ler livros cada vez mais detalhados, bons
instrumentos e peças de reposição.
De acordo com a graduação, ferramentas de músico vem com diferentes tipos de livros de canto, ensinado a
tocar instrumentos e partituras, 1 instrumento musical à sua escolha e itens de manutenção."
  }
},

new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Navigator,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.Deception,
      SkillEnum.Insight,
      SkillEnum.Investigation,
      SkillEnum.Perception,
      SkillEnum.Persuasion,
      SkillEnum.Survival
  },
  SpecialSkillName = "Navegação.",
  SpecialSkill = @"A profissão Navegador garante que Testes de Atributo relacionados às culturas locais, conhecimento gerais,
fenômenos meteorológicos, astronomia e comportamento marítimo, sejam feitos por meio da Perícia Especial do
Ofício (Navegação). Desta forma, recebendo os benefícios exclusivos proporcionados por cada graduação, ao invés de
usar as perícias normais.
Alguns exemplos de Testes de Atributos que podem usar a Perícia Especial do Ofício (Navegação), ao invés
das perícias normais, são:
Ao tentar lembrar de informações públicas, acontecimentos mundiais recentes ou conhecer a cultura de locais;
Ao tentar saber se uma mercadoria vale o que está sendo pedido;
Ao tentar perceber informações falsas.",
          Details = new List<string>{
              "RECEBE OS SEGUINTES ITENS: 1 Ferramenta de Navegador (amador), 1 mochila pequena.",

              @"SEMPRE INFORMADO
É trabalho do navegador guiar seus companheiros, não apenas pelos mares, mas por toda a sua jornada. Desta maneira,
um navegador está sempre lendo jornais e gravando informações que achar úteis, adquirindo cada vez mais todos os
tipos de conhecimentos e usando em prol do grupo.
Um navegador é capaz de identificar figuras importantes, passando em um Teste de Atributo com a Perícia
Especial do Ofício (Navegação) CD 16, sabendo os feitos e habilidades que sejam de conhecimento público.
Ao usar seus conhecimentos sobre o mercado, costumes e recursos de uma região, o navegador consegue
desconto de 20% em qualquer compra que ele intermedeie, barganhando com qualquer tipo de vendedor.

EVOLUÇÃO: Graduação Profissional: Você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Navegação) para
tentar aumentar o desconto de uma compra para 30%.
Graduação Especialista: Você diminui para 12 a CD do teste para tentar identificar uma figura importante. Além
disso, aumenta para 40% o desconto que você consegue em compras.
Graduação Mestre: Você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Navegação) para tentar
aumentar o desconto de uma compra para 50%.",

              @"PREVISÃO MARÍTIMA
Um navegador sempre está de olho nas mínimas mudanças de tempo, como uma
brisa mais gelada ou a migração incomum de pássaros. Por essa razão, antes
de partir em uma viagem, o navegador pode fazer um Teste de Atributo
com a Perícia Especial do Ofício (Navegação), com a Classe de
Dificuldade de acordo com o mar, caso obtenha sucesso, a viagem é
atrasada em 1d4 dias e todos os Testes de Navegação, durante a
viagem, recebem vantagem.
Blues: CD 12
Grand Line (Paradise): CD 16
Grand Line (Novo Mundo): CD 18
Outros Tipos de Mares: CD 14",

              @"NAVEGAÇÃO
Testes de Navegação ocorrem sempre que um navio for fazer viagens em alto mar. O Narrador pode pedir que o
navegador faça um Teste de Atributo com a Perícia Especial do Ofício (Navegação) para saber se ouve sucesso em evitar
uma aproximação de perigos climáticos ou de inimigos. A dificuldade e frequências desses testes são determinados pelo
tipo de mar que o navio está navegando e sua tabela está presente no Guia do Narrador.
Uma tripulação que não possua um membro minimamente capacitado, como um navegador, caçador de
recompensas ou timoneiro, recebe falha automaticamente em todos os Testes de Navegação, acarretando em
uma chance de sobrevivência quase nula, para os tripulantes em suas viagens.

EVOLUÇÃO:
Graduação Profissional: Quando você não passar em Teste de Navegação, você pode jogar duas vezes o d10, ao
invés de uma, e escolher qualquer um dos resultados.
Graduação Especialista: Quando você não passar em Teste de Navegação, e o resultado for: Animal Alado,
Ataque Pirata, Frota da Marinha ou Rei dos Mares, você pode fazer um Teste de Atributo com a Perícia Especial
do Ofício (Navegação), com a CD do mar navegado, para tentar despistar a ameaça.
Caso você não passe em um Teste de Navegação, e o resultado for: Maremoto, Redemoinho ou Tufão, você
pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Navegação), contra a CD do mar navegado, para
reduzir na metade o dano recebido.
Graduação Mestre: Quando você não passar em Teste de Navegação você pode, uma vez na mesma viagem, trocar
uma falha por um sucesso.",

              @"CRIAR MAPA
Ao fazer viagens, você pode desenhar mapas astronômicos e marítimos que auxiliarão nas próximas navegações, caso
você passe pelos locais cartografados novamente.
Você pode fazer um Teste de Atributo com a Perícia Especial do Ofício (Navegação) com a Classe de Dificuldade
de acordo com o mar, para criar um mapa cartográfico.
Em viagens que você possua um mapa da região, a duração da viagem é diminuída pela metade e não é
necessário fazer Testes de Navegação, recebendo sucessos automáticos.
Blues: CD 10
Grand Line (Paradise): CD 14
Grand Line (Novo Mundo): CD 16
Outros Tipos de Mares: CD 12",

              @"MENTE AFIADA
Como navegador, você sempre está usando seus conhecimentos para ajudar sua tripulação a chegar em seus destinos e
auxiliá-los quando chegam no local. Desta forma, você recebe as seguintes características:
Você sempre sabe qual caminho é o Norte;
Você sempre sabe o número de horas restantes antes do próximo nascer ou pôr do sol;
Ao realizar um Teste de Atributo de Sabedoria, você trata um resultado no d20 de 9 ou menor como um 10;
Pode rolar novamente uma Salvaguarda de Sabedoria que tenha falhado e escolher qualquer um dos resultados. Essa
característica pode ser usada até 3 vezes e você recupera todos os seus usos ao término de um descanso longo;
Você pode se lembrar com precisão de qualquer coisa que tenha visto ou ouvido em um período de 30 dias.",

              @"FERRAMENTAS DE NAVEGADOR
Navegadores precisam estar sempre lendo jornais e pesquisando sobre os climas das ilhas e proximidades, entender
a corrente marinha de cada mar e seus fenômenos climáticos.
Para que navegadores consigam aumentar suas habilidades é necessário ler livros cada vez mais detalhados
e boas ferramentas de desenho, sextantes e bússolas específicas.
De acordo com a graduação, ferramentas de navegador vem com diferentes tipos de livros de astronomia,
geografia e navegação, 1 tipo de bússola à sua escolha (bússola, log pose, log pose de 3 agulhas), 1 compasso, 1
balestilha e 1 astrolábio.
"
  }
},

new ProfessionStats{
  Profession = Models.Enums.ProfessionEnum.Helmsman,
  SkillToChoose = 2,
  SkillsProficiency = new List<SkillEnum>{
      SkillEnum.Deception,
      SkillEnum.Insight,
      SkillEnum.Investigation,
      SkillEnum.Perception,
      SkillEnum.Persuasion,
      SkillEnum.Survival
  },
  SpecialSkillName = "Navegação.",
  SpecialSkill = @"A profissão Timoneiro utiliza a Perícia Especial do Ofício (Navegação) para manobras e controle de embarcações, focando na operação física e técnica do timão.",
          Details = new List<string>{
              "SUBPROFISSÃO: O Timoneiro é uma variação do Navegador. É possível trocar Conhecimentos de Trabalho de Navegador por de Timoneiro.",

              @"COMBATE MARÍTIMO
Permite operar o timão em combate. Pode realizar 5 manobras por dia:
Cavalgar Correntes: Desde que não seja uma corrente de nível 0, em qualquer outro nível de corrente, você
consegue mover o navio como se estivesse em uma corrente de nível 2, ao seu favor.l 2 a favor.
Investida: Você consegue atingir um navio ou outra estrutura, que estejam a até 1,5 metro do seu navio, com uma
colisão do seu próprio navio. Ao fazer isso, você deve fazer um Teste de Atributo com a Perícia Especial do Ofício
(Navegação), caso o resultado seja igual ao superior à CR do navio ou estrutura inimiga, a colisão é um sucesso
(regras de colisão no Capítulo 14) e o seu navio sofre apenas 3d10 de dano.
Impulso: Durante 1 minuto, você faz com que o navio se mova como se estivesse em uma corrente de nível 3 ao
seu favor, com controle total sob o movimento do navio;
Surf Naval: Durante 1 minuto, você faz com que o navio se mova de forma aleatória, fazendo com que todos os
ataques contra ele recebam desvantagem.",

              @"MANOBRAR DESASTRES NATURAIS
Caso você não passe em um Teste de Navegação, e o resultado for: Maremoto, Redemoinho ou Tufão, você pode
fazer um Teste de Atributo com a Perícia Especial do Ofício (Navegação), contra a CD do mar navegado, para reduzir na
metade o dano recebido.
Quando você for um navegador mestre, caso você falhe nesse Teste de Atributo com a Perícia Especial do Ofício
(Navegação), você reduz o dano recebido pela metade e não recebe dano nenhum em um sucesso.
",
              @"BRAÇO DE TIMONEIRO
Testes de Atributo de Força resistidos recebem +2 de bônus;
Você se torna proficiente em Testes de Atributo de Força (Atletismo);
Dobra o valor base da sua capacidade de carga;
Recebe vantagem em Testes de Atributo de Força (Atletismo).
"
  }
}


            };

    }
}
