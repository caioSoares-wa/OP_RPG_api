using ShinRoll.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;



namespace ShinRoll.Data.StaticData.CharacterSpecs.Species
{
    [NotMapped]
    public class SpeciesStats
    {
        public int Id { get; set; }
        public SpeciesEnum Species { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? SubSpecieName { get; set;  }
        public int BaseLifePoints { get; set; }
        public double Moviment { get; set; }
        public double Swimming { get; set; }
        public SubSpecieEnum? SubSpecies { get; set; }
        public string? VariantDescription { get; set; }
        public string Beneficts { get; set; } = string.Empty;
        public string Harms { get; set; } = string.Empty;


        public SpeciesStats()
        {

        }

        public SpeciesStats(SpeciesEnum specie, SubSpecieEnum? subSpecies)
        {

            Species = specie;
            SubSpecies = subSpecies;
            

            

            switch (Species)
            {
                case SpeciesEnum.Dwarf:
                    this.Name ="Anões";
                    this.BaseLifePoints = 8;
                    this.Moviment = 9;
                    this.Swimming = 4.5;
                    Beneficts = @"Corpo Pequeno: Enquanto o anão e seus mestiços permanecerem na categoria de
tamanho Miúdo, eles se beneficiam das seguintes características:
    Estômago Pequeno: Itens consumíveis e alimentos feitos para criaturas de
tamanho Médio ou maior podem ser usados em metade da quantidade usual
para garantir os mesmos bônus.
    Piscar: Você pode desaparecer da visão de todos e reaparecer em um local
desocupado à sua escolha, a até 9 metros de distância de sua posição inicial.
Essa característica pode ser usada até 3 vezes e você recupera todos os
seus usos ao término de um descanso longo.
    Andar das Fadas: Desde que não estejam sob a condição “Impedido”, anões
recebem vantagem em Testes de Destreza (Furtividade) quando não estiverem em um encontro de batalha.
Dentro de um encontro, podem tentar se esconder mesmo a plena vista, usando uma ação bônus, desde
que haja um local que proporcione cobertura total.
    Hóspede Feérico: Enquanto o anão e seus mestiços mantiverem a categoria de tamanho Miúdo, podem ocupar o
mesmo espaço de criaturas de categoria de tamanho maiores. Se movimentando apenas através do corpo da criatura
e sendo movidos junto com ela.
Enquanto estiver compartilhando o espaço da criatura, não será possível ser alvejado por jogadas de ataque ou
Salvaguardas (comum ou de Técnicas). Entretanto, não poderá usar ações poderosas e sofrerão metade de todo o
dano direcionado à criatura que estiverem compartilhando o espaço. O dano sofrido pelo anão ignora as
características que alterem o dano sofrido pelo hospedeiro, como invulnerabilidades, resistências e etc.
    ARMAS REDUZIDAS
Os anões possuem grande conhecimento de manufatura, são capazes de fazer em tamanho reduzido, para seu próprio
uso, qualquer arma (Cortantes, Especiais, Marciais e Munições) que já tenham visto seu funcionamento. Para isso,
serão gastos 1/5 dos recursos normais da arma.
No entanto, armas de fogo ou que realizem uma jogada de ataque a distância têm seu dano total reduzido
pela metade, por conta do seu tamanho reduzido.
As armas recebidas pelo “Estilo de Combate” já vêm adaptadas ao tamanho da sua espécie.
";
                    Harms = @"Ingenuidade Anormal: Anões são muito ingênuos e recebem -10 em Testes de Atributo de Vontade (Intuição).";
                    break;

                case SpeciesEnum.Celestial:
                    this.Name = "Celestiais";
                    this.BaseLifePoints = 10;
                    this.Moviment = 12;
                    this.Swimming = 3;
                    this.Beneficts = @"Herança Cultural: Um celestial conhece e se torna proficiente com todos os tipos de dials e suas funcionalidades.
No início do jogo, à escolha do jogador, o personagem recebe 3 dials cotidianos de tipos diferentes e mais 1 dial
bélico, presentes no Guia do Narrador.
Além disso, escolhe 2 Perícias para adicionar sua proficiência, à sua escolha, com exceção de “Sobrenatural” e
“Sorte”. No lugar de uma dessas perícias, você pode escolher receber a Singularidade “Haki da Observação Inato” e
receber 15 Pontos de Ambição, que só poderão ser investidos no Haki da Observação, logo após despertar o uso do
Haki.";
                    this.Harms = @"Dificuldade da Espécie
Anjos Caídos: Por estarem, a gerações, acostumados com atmosferas menos densas, altitudes mais baixas podem
distorcer o senso de equilíbrio dos celestiais. Dessa maneira, você recebe -2 em Testes de Atributo de Destreza
(Acrobacia), desde que não esteja a mais de 5.000 metros do nível do mar.";
                    this.VariantDescription = ChooseVariant();
                    break;

                case SpeciesEnum.Giant :
                    this.Name = "Gigantes";
                    this.BaseLifePoints = 20;
                    this.Moviment = 9;
                    this.Swimming = 3;
                    this.Beneficts = @"Força Colossal: O gigante se torna proficiente e dobra o bônus de proficiência em qualquer Salvaguarda ou Teste
de Atributo de Força. Além disso, características e técnicas que se limitam a afetar apenas criaturas Grandes ou
menores podem afetar também criaturas e alvos 
Corpo Assustador: Os gigantes naturalmente impõem suas presenças àqueles ao seu redor. Recebem +2 em Testes
de Atributo de Presença (Intimidação).";
                    this.Harms = @"Necessidades Gigantescas: O corpo colossal dos gigantes gera a necessidade de recursos igualmente grandes. O
gigante precisa de uma quantidade de alimento e líquido 5 vezes maior que a de um humano (o suficiente para
mantê-lo alimentado, mas não para saciar sua fome de verdade) e ocupa o espaço de 20 tripulantes em um navio.";

                    break;

                case SpeciesEnum.Human:
                    this.Name = "Humanos";
                    this.BaseLifePoints = 10;
                    this.Moviment = 9;
                    this.Swimming = 4.5;
                    this.Beneficts = @"Adaptação: O humano escolhe 3 Perícias para adicionar sua proficiência, à sua escolha, com exceção de “Haki”,
“Sobrenatural” e “Sorte”.";
                    this.Harms = @"Aspectos Humanos: A humanidade é imensa e plural, sendo capazes de inúmeros feitos, mas também incontáveis
defeitos. Você deve escolher uma das seguintes falhas de caráter para o seu personagem:
Ganância: Desde que você esteja na frente de um tesouro ou algum tesouro esteja relacionado a algum Teste
de Atributo ou Salvaguarda você recebe -2 no Teste.
Gula: É necessário o dobro de comida e água para você não sofrer as consequências de falta de alimentação.
Inveja: Quando uma ou mais criaturas são bem-sucedidas em um Teste de Atributo ou Salvaguarda que você
falhou, durante a mesma rodada, você recebe -2 no seu próximo Teste de Atributo, até o final do dia.
Ira: Você falha automaticamente em qualquer Salvaguarda contra Provocação.
Luxúria: Criaturas do sexo que o seu personagem sinta atração recebem +2 em Testes Resistidos contra você.
Preguiça: Você leva o dobro do tempo para terminar um descanso curto e recebe o dobro de Níveis de Exaustão,por não realizar um descanso longo.
Orgulho: Você recebe -1 em Testes de Atributo de Presença.

Regra Opcional: Alternativamente, você pode escolher receber apenas uma perícia do Benefício da Espécie
“Adaptação” e não receber a Dificuldade da Espécie “Aspectos Humanos”.
";
                    this.VariantDescription = ChooseVariant();

                    break;

                case SpeciesEnum.Lunarian:
                    this.Name = "Lunarian";
                    this.BaseLifePoints = 16;
                    this.Moviment = 9;
                    this.Swimming = 3;
                    this.Beneficts = @"Heat: Uma vez por rodada, usando uma ação bônus, o lunariano pode
adicionar 1d10 de dano de Fogo em uma jogada de ataque (comum ou de
Técnica). Essa característica pode ser usada uma quantidade de vezes
igual ao seu nível de personagem e você recupera todos os seus usos
ao término de um descanso longo.
Alternativamente, você pode usar essa característica de forma
conjunta com a sua jogada de ataque ou técnica, sem necessidade de
uma ação bônus. Essa forma alternativa pode ser usada até 5 vezes,
respeitado o uso limitado pelo seu nível de personagem e você recupera
todos os seus usos ao término de um descanso longo.
Por exemplo, se você tiver 10 usos disponíveis e optar por usar a forma
alternativa 5 vezes, ainda terá 5 usos restantes para o uso padrão com ação bônus.
Só é possível usar o Heat uma vez por rodada, independentemente de ter sido
utilizado na forma padrão ou na alternativa. Essa limitação também se aplica a
características semelhantes, como o Benefício da Espécie “Electro” dos Minks ou a
Manifestação de Poder Especial “Potencializador Ofensivo” da Akuma no Mi.

Manipulação do Fogo: Enquanto o fogo nas suas costas se mantém, você pode
exercer os seguintes benefícios com as chamas:
Recebe resistência a dano de fogo;
Seu corpo ilumina até 6 metros com luz direta e mais 3 metros com penumbra;
Você pode usar sua ação para manipular uma esfera de fogo, movendo-a para
qualquer lugar a até 6 metros de você, que emite a mesma luz que você. Essa
esfera se apaga ao encostar em criaturas, causando 1d4 de dano de Fogo ou ao
encostar em objetos, causando combustão em objetos inflamáveis.";
                    this.Harms = @"Cabeça à Prêmio: O Governo Mundial busca capturar ou exterminar qualquer membro da Espécie lunariana,
estando dispostos a recompensar com fortunas qualquer pessoa que possa lhes conceder mesmo pistas do paradeiro
de um. Portanto, se você mostrar sua aparência em público, o Narrador deve jogar 1d12, em um valor 6 ou menor,
em algum momento do dia seguinte, irá surgir um grupo do Governo Mundial ou Marinha para te capturar.";

                    break;
                    //não coloquei mestiços
                case SpeciesEnum.Minks:
                    this.Name = "Minks";
                    this.BaseLifePoints = 12;
                    this.Moviment = 9;
                    this.Swimming = 4.5;
                    this.Beneficts = @"Electro: Uma vez por rodada, usando uma ação bônus, o mink pode adicionar 1d10 de dano Elétrico em uma jogada
de ataque (comum ou de Técnica). Essa característica pode ser usada uma quantidade de vezes igual ao seu
nível de personagem e você recupera todos os seus usos ao término de um descanso longo.
Alternativamente, você pode usar essa característica de forma conjunta com a sua jogada de ataque ou técnica,
sem necessidade de uma ação bônus. Essa forma alternativa pode ser usada até 5 vezes, respeitado o uso limitado
pelo seu nível de personagem e você recupera todos os seus usos ao término de um descanso longo.
Por exemplo, se você tiver 10 usos disponíveis e optar por usar a forma alternativa 5 vezes, ainda terá 5 usos
restantes para o uso padrão com ação bônus.
Só é possível usar o Electro uma vez por rodada, independentemente de ter sido utilizado na forma padrão ou
na alternativa. Essa limitação também se aplica a características semelhantes, como o Benefício da Espécie “Heat”
dos Lunarianos ou a Manifestação de Poder Especial “Potencializador Ofensivo” da Akuma no Mi.";
                    this.Harms = @"Instintos Animalescos: Para todo mink existe algum objeto que o faz perder o controle de alguma forma. Por
exemplo, um mink coelho, ao ver uma cenoura, se sente impelido a deixar de fazer o que estava fazendo e ir morder
a cenoura. Nesses casos, o mink deve fazer uma Salvaguarda de Vontade CD 15 para não sucumbir aos seus instintos
e ficar 1d4 turnos “distraído” (condição “Atordoado”), ou até que receba dano";
                    this.VariantDescription = ChooseVariant();


                    break;
                case SpeciesEnum.PeopleOfTheSea:
                    this.Name = "Povo do Mar";
                    this.BaseLifePoints = 14;
                    this.Moviment = 9;
                    this.Swimming = 15;
                    this.Beneficts = @"Força Superior: O povo do mar se torna proficiente e adiciona mais a metade do bônus de proficiência
(arredondado para baixo) em Salvaguardas e Testes de Atributo de Força.";
                    this.Harms = @"Criatura do Mar: O povo do mar possui brânquias e pulmões, possibilitando uma respiração em ambientes com
água ou ar. As brânquias se fecham em contato com o ar, fazendo com que sufoquem, caso esteja submerso.
Porém, precisam de duas vezes mais água que humanos em um dia normal e quatro vezes mais em um dia
quente, para não receber/aumentar 1 Nível de Exaustão ao final de cada dia.";
                    this.VariantDescription = ChooseVariant();

                    break;




            }
        }

    public string? ChooseVariant()
        {
            List<SpeciesEnum> speciesVariant = new List<SpeciesEnum>();

            speciesVariant.Add(SpeciesEnum.Celestial);
            speciesVariant.Add(SpeciesEnum.Human);
            speciesVariant.Add(SpeciesEnum.Minks);
            speciesVariant.Add(SpeciesEnum.PeopleOfTheSea);


         

            if (speciesVariant.Contains(this.Species))
            {
                switch (SubSpecies) 
                {
                    case SubSpecieEnum.Birkans :
                        this.SubSpecies = SubSpecieEnum.Birkans;
                        this.SubSpecieName = "Birkans";
                        this.VariantDescription = @"São os habitantes de Birka, uma ilha no céu ao sudeste de Skypiea. Suas asas têm maior diferença entre as outras tribos,
suas penas apontam para baixo, enquanto as asas dos Shandians e Skypeans apontam para os lados. Alguns possuem
uma aparência peculiar, que lembra um bode. Muitos são adeptos de cerimónias e usam vestimentas religiosas.
Benefício da Espécie (Sacerdote Celestial): O celestial recebe +5 em Testes de Atributo de Presença (Atuação).";
                        return VariantDescription;
                        

                    case SubSpecieEnum.Shadians :
                        this.SubSpecies = SubSpecieEnum.Shadians;
                        this.SubSpecieName = "Shandians";
                        this.VariantDescription = @"Os Shandians encontraram seu lar no Mar Azul, na ilha de Jaya, mas um fenômeno marinho levou toda a tribo, junto
com metade da ilha, para os mares do céu. Após isso, os Skypeans tomaram suas terras, e uma guerra se iniciou desde
então. Os Shandians usam vestimentas tribais e se ornamentam com pinturas e tatuagens por todo o corpo. Eles têm
grande apreço pelo treinamento físico e pelo espírito de guerreiro.
Benefício da Espécie (Guerreiro Celestial): O celestial recebe +5 em Testes de Atributo de Força (Atletismo).";
                        return VariantDescription;

                    case SubSpecieEnum.Skypeans:
                        this.SubSpecies = SubSpecieEnum.Skypeans;
                        this.SubSpecieName = "Skypeans";
                        this.VariantDescription = @"Os Skypeans são o povo mais pacato que vive nas ilhas do céu, possuindo diversas leis. Usam dials para tarefas diárias,
como cozinhar e andar de barco. Para se cumprimentarem, dizem “Heso” (umbigo), e seus penteados tradicionalmente
são moldados para parecerem duas antenas com bolinhas nas pontas. Eles também tendem a ter a cor de pele mais clara
do que a dos Shandians.
Benefício da Espécie (Diplomata Celestial): O celestial recebe +5 em Testes de Atributo de Presença
(Persuasão).";
                        return VariantDescription;

                    case SubSpecieEnum.CommonHumans:
                        this.SubSpecieName = "Humanos Comuns";
                        this.VariantDescription = @"Os humanos são a Espécie mais presente em todo o mundo e bastante diversificados, seja em cultura, modo de agir e
até mesmo aparência. Por serem tão imprevisíveis, eles se mostram a Espécie mais perigosa de todas, e apesar de não
terem atributos físicos tão avantajados, sua capacidade de adaptação é algo acima do comum.
Benefício da Espécie (Aptidão Natural): Você escolhe uma perícia na qual possa usar o seu bônus de proficiência
e dobra o seu bônus de proficiência.";
                        return this.VariantDescription;
                    case SubSpecieEnum.BigHumans:
                        this.SubSpecieName = "Humanozarrões";
                        this.VariantDescription = @"São humanos comuns que possuem corpos que atingem proporções absurdas. Existem casos de humanozarrões com
mais de 8 metros, o que pode chegar a assustar até os pais, se tiverem uma estatura comum.
Benefício da Espécie (Colosso): Seu tamanho aumenta para Grande e você recebe +2 em Salvaguardas de Força.";
                        return this.VariantDescription;
                    case SubSpecieEnum.LongArmsTribe:
                        this.SubSpecieName = "Tribo Braços Longos";
                        this.VariantDescription = @"Uma tribo com duas articulações nos membros superiores, ou seja, dois ombros em cada braço, fazendo os braços serem
mais longos, tendo maior alcance e melhor mobilidade com os braços.
Os membros dessa tribo, que seguem sua cultura, geralmente estão vestidos de Changpao (veste tradicional
chinesa) e sempre possuem algo escrito em kanji em suas roupas, o kanji muda de membro para membro. Por causa de
uma guerra de mais de mil anos com a Tribo Pernas Longas, existe uma grande inimizade entre esses dois povos.
Benefício da Espécie (Braços Especiais): Recebe alcance de 3 metros em jogadas de ataque corpo a corpo,
quando utilizando os braços e recebem +2 Em Testes de Atributo de Destreza (Prestidigitação).";
                        return this.VariantDescription;
                    case SubSpecieEnum.KujasTribe:
                        this.SubSpecieName ="Tribo Kujas";
                        this.VariantDescription = @"Uma tribo composta exclusivamente por mulheres guerreiras, nascidas em Amazon Lily, que possuem uma cultura
isolacionista e pouco conhecimento sobre o mundo exterior. Algumas de suas características mais marcantes incluem
sempre terem nomes de flores, darem à luz apenas a mulheres e odiarem qualquer tipo de homem, que são proibidos de
entrar em seu território.
Cobra Companheira: Toda kuja recebe em seu nascimento uma cobra para acompanhá-la por toda sua vida. Você
escolhe o nome da cobra e ela entende tudo que você falar, podendo realizar pequenas tarefas, como trazer uma
toalha para o seu banho, por exemplo. Ela não recebe dano de nenhuma jogada de ataque ou Salvaguarda que não
tenha ela explicitamente como alvo do atacante.
Ela é totalmente obediente a você e renunciaria até a própria vida se ordenada. Quando em combate, a cobra
age no mesmo turno que você. Essa cobra tem as características presentes na ficha abaixo “Cobra Bélica”.



Classe de Resistência: 15                  Bônus de Proficiência: +2
Pontos de Vida: 39 (7d8+7)                 Tamanho: 1,5 metro (Pequeno)
Deslocamento: 9 metros
    
FOR         DES         CON         SAB         PRE         VON
11 (0)      20 (+5)     13 (+1)     10 (0)      10 (0)      10 (0)

Características:
Classificação: Tipo B, Comum.
Invulnerabilidade à Condição: Envenenado.
Perícia: Furtividade +7.
Salvaguarda: Destreza +7.

Aspectos:
Agarrador: A cobra bélica tem vantagem nas jogadas de ataque contra qualquer criatura
agarrada por ela.

Ações:
Picada: Ataque Corpo a corpo: +7 para atingir, alcance 1,5 metro, um alvo.
Acerto: 10 (2d4+5) de dano de Veneno
Efeito: O alvo deve ser bem-sucedido em uma Salvaguarda de Constituição CD 16 ou
receberá a condição “Envenenado” por 1 minuto. Até a duração do veneno acabar, o alvo
receberá 1d4 no final de cada um de seus turnos. O alvo pode repetir a Salvaguarda no final
de cada um dos turnos dele, terminando o envenenamento sobre si com um sucesso e não
sofrendo mais os seus efeitos, durante as próximas 24 horas, após o sucesso.

USANDO SUA COBRA
As cobras das kujas podem ser usadas de maneiras únicas, uma vez durante o turno da kuja e sem necessidade de usar
ações, as kujas podem dar as seguintes ordens às suas cobras:
Arco de Cobra: As kujas comandam suas cobras para assumir o formato de um arco e podem usar flechas para
realizar uma jogada de ataque à distância com arma, recebendo os seguintes benefícios:
Pode ser adicionado o bônus de proficiência em suas jogadas de ataque;
O modificador da jogada de ataque e de dano pode ser alterado para o seu atributo primário;
As jogadas de ataque e de dano recebem +2.
Restringir: As kujas podem comandar suas cobras para se prenderem nos membros de uma criatura Grande ou
menor e se tornarem algemas tão duras quanto o aço, a criatura fica com a condição “Incapacitado” ou com a
condição “Agarrado” e pode tentar encerrar as condições com uma Salvaguarda de Força CD 16, no início de
cada um dos seus turnos. Para isso, a cobra deve acertar uma jogada de ataque corpo a corpo e substituir o dano
por essa característica e, até que encerre o agarramento, fica com a condição “Impedido”.
";
                        return this.VariantDescription;
                    case SubSpecieEnum.LongLegsTribe:
                        this.SubSpecieName="Tribo Pernas Longas";
                        this.VariantDescription = @"Essa tribo possui as pernas muito mais alongadas que os humanos comuns e com uma musculatura forte.
Tradicionalmente, os membros dessa tribo deixam suas pernas totalmente expostas e possuem uma tatuagem
em uma de suas coxas. Por causa de conflitos antigos, a Tribo Pernas Longas está em guerra com a Tribo Braços Longos.
Benefício da Espécie (Pernas Especiais): Alcance de 3 metros em jogadas de ataque corpo a corpo, quando
utilizando as pernas e seu deslocamento normal se torna 12 metros.";
                        return this.VariantDescription;
                    case SubSpecieEnum.SnakeNeckTribe:
                        this.SubSpecieName = "Tribo Pescoço de Cobra";
                        this.VariantDescription = @"Os membros da Tribo Pescoço de Cobra têm pescoços mais longos que os de um ser humano comum, o tamanho varia
desde um pouco mais alongados a até 1 metro de comprimento, o que os torna muito mais altos que a maioria dos
humanos comuns. Normalmente possuem os corpos muito finos o que os tornam mais parecidos com as cobras.
Benefício da Espécie (Pescoço Esticado): Alcance de 3 metros em jogadas de ataque corpo a corpo, quando
utilizando a cabeça e +2 em Testes de Atributo de Vontade (Percepção) que dependam da visão.";
                        return this.VariantDescription;

                    case SubSpecieEnum.ThreeEyeTribe:
                        this.SubSpecieName = "Tribo Dos 3 Olhos";
                        this.VariantDescription = @"Como o nome sugere, os membros da Tribo dos Três Olhos possuem um 3º olho em suas testas, além dos dois olhos
comuns dos humanos. É dito que são capazes de alcançar o “verdadeiro despertar” com seu terceiro olho, que
supostamente vem com a capacidade de ouvir a “Voz de Todas as Coisas”.
Benefício da Espécie (Abrir os Olhos): O uso do terceiro olho possui uma conexão mística com o destino. Como
resultado, você recebe proficiência em Testes de Atributo de Vontade – Escolha entre Haki, Sobrenatural ou Sorte";
                        return this.VariantDescription;

                    case SubSpecieEnum.Agile:
                        this.SubSpecieName = "Ágeis";
                        this.VariantDescription = @"São minks esguios e rápidos, em geral, possuem uma estatura abaixo da média o que faz com que
sejam mais difíceis de notar. Seu pouco peso, faz com que se movam muito mais em menos
tempo.
Benefício da Espécie (Corpo Leve): Seu deslocamento normal se torna 12
metros e seu deslocamento de escalada se torna 9 metros (caso receba outro
deslocamento, prevalece o maior).";
                        return this.VariantDescription;

                    case SubSpecieEnum.Garchu:
                        this.SubSpecieName = "Meãos";
                        this.VariantDescription = @"São minks que possuem um corpo médio e proporcional, muito semelhante ao
dos humanos comuns, só sendo distinguido pela quantidade de pelo, garras ou
chifres. Um mink meão tem um corpo que lhe permite escolher entre ser
rápido ou forte.
Benefício da Espécie (Estamina Animal): Seu deslocamento normal
se torna 18 metros (caso receba outro deslocamento, prevalece o maior).";
                        return this.VariantDescription;
                    case SubSpecieEnum.Robust:
                        this.SubSpecieName = "Robustos";
                        this.VariantDescription = @"São minks altos e largos, possuem, naturalmente, muita força ou resistência. Seu
tamanho pode chegar a assustar os próprios minks, o peso desses minks faz com que sejam
imponentes apenas por pisar no chão.
Benefício da Espécie (Pisada Firme): Seu deslocamento normal se torna 12 metros e
não pode ser reduzido por terreno difícil (caso receba outro deslocamento, prevalece o
maior).";   
                        return this.VariantDescription;

                    case SubSpecieEnum.Fishman:

                        this.SubSpecieName = "Homem-Peixe";
                        this.VariantDescription = @"Os homens-peixe possuem uma união da estrutura de corpos humanoides comuns com as características dos animais
marinhos, como barbatanas tentáculos e etc.
Benefício da Espécie (Corpo Marinho): De acordo com a criatura do mar que o personagem tenha como
ancestral, o homem-peixe pode escolher 1 Traço Comum das Akuma no Mi Zoan (ignorando o requisito de forma
original, híbrida ou animal), presentes no Capítulo 6, ou criadas pelo jogador, mas devem ser aprovadas pelo
Narrador.";
                        return this.VariantDescription;
                    case SubSpecieEnum.Siren:

                        this.SubSpecieName = "Sireno";
                        this.VariantDescription = @"Os sirenos, sempre possuem as características dos animais marinhos mais acentuadas da cintura para baixo,
normalmente não se diferenciando muito de um humano comum em sua parte superior.
Benefício da Espécie (Natação Superior): Os sirenos recebem 18 metros de nado e podem usar a ação
“Disparada” como ação bônus, enquanto estiverem nadando.";
                        return this.VariantDescription;
                }
            }
            else
            {
                this.SubSpecieName = string.Empty;
                return null;
            }
            
            return VariantDescription;
        }
    }
}
