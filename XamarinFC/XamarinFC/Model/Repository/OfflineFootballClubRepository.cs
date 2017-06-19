using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFC.Model.Entity;
using XamarinFC.Model.Repository;

//[assembly: Dependency(typeof(OfflineFootballClubRepository))]
namespace XamarinFC.Model.Repository
{
    class OfflineFootballClubRepository : IFootballClubRepository
    {
        public async Task<IEnumerable<FootballClub>> GetClubsData()
        {
            return await Task.FromResult(GenerateClubsData());
        }

        private List<FootballClub> GenerateClubsData()
        {
            return new List<FootballClub>
            {
                new FootballClub
                {
                    Name = "Corinthians", 
                    FullName = "Sport Club Corinthians Paulista", 
                    Anthem = 
                        "Salve o Corinthians\n" +
                        "O campeão dos campeões\n" +
                        "Eternamente dentro dos nossos corações\n" +
                        "Salve o Corinthians de tradições e glórias mil\n" +
                        "Tu és orgulho\n" +
                        "Dos desportistas do Brasil\n" +
                        "\n" +
                        "Teu passado é uma bandeira\n" +
                        "Teu presente é uma lição\n" +
                        "Figuras entre os primeiros\n" +
                        "Do nosso esporte bretão\n" +
                        "\n" +
                        "Corinthians grande\n" +
                        "Sempre altaneiro\n" +
                        "És do Brasil\n" +
                        "O clube mais brasileiro\n" +
                        "\n" +
                        "Salve o Corinthians\n" +
                        "O campeão dos campeões\n" +
                        "Eternamente dentro dos nossos corações\n" +
                        "Salve o Corinthians de tradições e glórias mil\n" +
                        "Tu és orgulho\n" +
                        "Dos desportistas do Brasil\n",
                },

                new FootballClub
                {
                    Name = "Flamengo",
                    FullName = "Clube de Regatas Flamengo", 
                    Anthem =
                        "Uma vez Flamengo, sempre Flamengo\n" +
                        "Flamengo sempre eu hei de ser\n" +
                        "É meu maior prazer vê-lo brilhar\n" +
                        "Seja na terra, seja no mar\n" +
                        "Vencer, vencer, vencer!\n" +
                        "Uma vez Flamengo, Flamengo até morrer!\n" +
                        "\n" +
                        "Na regata, ele me mata\n" +
                        "Me maltrata, me arrebata\n" +
                        "Que emoção no coração!\n" +
                        "Consagrado no gramado\n" +
                        "Sempre amado, o mais cotado\n" +
                        "Nos Fla-Flus é o Ai, Jesus!\n" +
                        "\n" +
                        "Eu teria um desgosto profundo\n" +
                        "Se faltasse o Flamengo no mundo\n" +
                        "Ele vibra, ele é fibra\n" +
                        "Muita libra já pesou\n" +
                        "Flamengo até morrer eu sou!\n",
                },

                new FootballClub
                {
                    Name = "São Paulo",
                    FullName = "São Paulo Futebol Clube", 
                    Anthem =
                        "Salve o tricolor paulista\n" +
                        "Amado clube brasileiro\n" +
                        "Tu és forte, tu és grande\n" +
                        "Dentre os grandes és o primeiro\n" +
                        "Tu és forte, tu és grande\n" +
                        "Dentre os grandes és o primeiro\n" +
                        "\n" +
                        "Ó tricolor\n" +
                        "Clube bem amado\n" +
                        "As tuas glórias\n" +
                        "Vêm do passado\n" +
                        "(x2)\n" +
                        "\n" +
                        "São teus guias brasileiros\n" +
                        "Que te amam ternamente\n" +
                        "De São Paulo tens o nome\n" +
                        "Que ostentas dignamente\n" +
                        "\n" +
                        "Coro: Oh tricolor...\n" +
                        "\n" +
                        "São Paulo clube querido\n" +
                        "Tu tens o nosso amor\n" +
                        "Teu nome e tuas glórias\n" +
                        "Têm honra e resplendor\n" +
                        "\n" +
                        "Coro: Oh tricolor...\n" +
                        "\n" +
                        "Tuas cores gloriosas\n" +
                        "Despertam amor febril\n" +
                        "Pela terra Bandeirante:\n" +
                        "Honra e Glória do Brasil\n" +
                        "\n" +
                        "Coro: Oh tricolor...\n",
                },

                new FootballClub
                {
                    Name = "Santos",
                    FullName = "Santos Futebol Clube", 
                    Anthem =
                        "Sou alvinegro da Vila Belmiro\n" +
                        "O Santos vive no meu coração\n" +
                        "É o motivo de todo o meu riso\n" +
                        "De minhas lágrimas de emoção\n" +
                        "\n" +
                        "Sua bandeira no mastro é a história\n" +
                        "De um passado e um presente só de glórias\n" +
                        "Nascer, viver, e no Santos morrer\n" +
                        "É um orgulho que nem todos podem ter\n" +
                        "\n" +
                        "No Santos pratica-se o esporte\n" +
                        "Com dignidade e com fervor\n" +
                        "Seja qual for a sua sorte\n" +
                        "De vencido ou de vencedor\n" +
                        "\n" +
                        "Com técnica e disciplina\n" +
                        "Dando o sangue com amor\n" +
                        "Pela bandeira que ensina\n" +
                        "Lutar com fé e com ardor\n",
                },

                new FootballClub
                {
                    Name = "Palmeiras", 
                    FullName = "Sociedade Esportiva Palmeiras", 
                    Anthem =
                        "Quando surge o alviverde imponente\n" +
                        "No gramado em que a luta o aguarda\n" +
                        "Sabe bem o que vem pela frente\n" +
                        "Que a dureza do prélio não tarda\n" +
                        "\n" +
                        "E o Palmeiras no ardor da partida\n" +
                        "Transformando a lealdade em padrão\n" +
                        "Sabe sempre levar de vencida\n" +
                        "E mostrar que de fato é campeão\n" +
                        "\n" +
                        "Defesa que ninguém passa\n" +
                        "Linha atacante de raça\n" +
                        "Torcida que canta e vibra\n" +
                        "\n" +
                        "Por nosso alviverde inteiro\n" +
                        "Que sabe ser brasileiro\n" +
                        "Ostentando a sua fibra\n",
                },

                new FootballClub
                {
                    Name = "Fluminense",
                    FullName = "Fluminense Football Club", 
                    Anthem =
                        "Sou tricolor de coração\n" +
                        "Sou do clube tantas vezes campeão\n" +
                        "Fascina pela sua disciplina\n" +
                        "O Fluminense me domina\n" +
                        "Eu tenho amor ao tricolor\n" +
                        "\n" +
                        "Salve o querido pavilhão\n" +
                        "Das três cores que traduzem tradição\n" +
                        "A paz, a esperança e o vigor\n" +
                        "Unido e forte pelo esporte\n" +
                        "Eu sou é tricolor\n" +
                        "\n" +
                        "Vence o Fluminense\n" +
                        "Com o verde da esperança pois\n" +
                        "Quem espera sempre alcança\n" +
                        "Clube que orgulha o Brasil\n" +
                        "Retumbante de glórias\n" +
                        "E vitórias mil\n" +
                        "\n" +
                        "Sou tricolor de coração\n" +
                        "Sou do clube tantas vezes campeão\n" +
                        "Fascina pela sua disciplina\n" +
                        "O Fluminense me domina\n" +
                        "Eu tenho amor ao tricolor\n" +
                        "\n" +
                        "Salve o querido pavilhão\n" +
                        "Das três cores que traduzem tradição\n" +
                        "A paz, a esperança e o vigor\n" +
                        "Unido e forte pelo esporte\n" +
                        "Eu sou é tricolor\n" +
                        "\n" +
                        "Vence o Fluminense\n" +
                        "Com sangue de encarnado\n" +
                        "Com amor e com vigor\n" +
                        "Faz a torcida querida\n" +
                        "Vibrar com a emoção\n" +
                        "Do tricampeão\n" +
                        "\n" +
                        "Vence o Fluminense\n" +
                        "Usando a fidalguia\n" +
                        "Branco é paz e harmonia\n" +
                        "Brilha no sol da manhã\n" +
                        "Ou na luz do refletor\n" +
                        "Salve o Tricolor\n",
                },

                new FootballClub
                {
                    Name = "Botafogo",
                    FullName = "Botafogo de Futebol e Regatas", 
                    Anthem =
                        "Botafogo, Botafogo\n" +
                        "Campeão desde 1910\n" +
                        "Foste herói em cada jogo, Botafogo\n" +
                        "Por isso é que tu és\n" +
                        "\n" +
                        "E hás de ser\n" +
                        "Nosso imenso prazer\n" +
                        "Tradições,\n" +
                        "Aos milhões tens também.\n" +
                        "\n" +
                        "Tu és O Glorioso\n" +
                        "Não podes perder\n" +
                        "Perder pra ninguém\n" +
                        "\n" +
                        "Noutros esportes\n" +
                        "Tua fibra está presente\n" +
                        "Honrando as cores,\n" +
                        "do Brasil e de nossa gente\n" +
                        "\n" +
                        "Na estrada do louros\n" +
                        "Num faixo de luz\n" +
                        "Tua estrela solitária\n" +
                        "Te conduz,\n",
                },

                new FootballClub
                {
                    Name = "Vasco",
                    FullName = "Club de Regatas Vasco da Gama", 
                    Anthem =
                        "Vamos todos cantar de coração\n" +
                        "A Cruz de Malta é o meu pendão\n" +
                        "Tu tens o nome de um heróico português\n" +
                        "Vasco da Gama, a tua fama assim se fez\n" +
                        "\n" +
                        "Tua imensa torcida é bem feliz\n" +
                        "Norte e sul, norte e sul deste Brasil\n" +
                        "Tua estrela, na terra a brilhar\n" +
                        "Ilumina o mar\n" +
                        "\n" +
                        "No atletismo és um braço\n" +
                        "No remo és imortal\n" +
                        "No futebol és o traço\n" +
                        "De união Brasil-Portugal",
                },

                new FootballClub
                {
                    Name = "Cruzeiro",
                    FullName = "Cruzeiro Esporte Clube", 
                    Anthem =
                        "Existe um grande clube na cidade,\n" +
                        "que mora dentro do meu coração\n" +
                        "Eu vivo cheio de vaidade\n" +
                        "pois na realidade é um grande campeão\n" +
                        "Nos gramados de Minas Gerais\n" +
                        "temos páginas heróicas e imortais\n" +
                        "Cruzeiro Cruzeiro querido\n" +
                        "tão combatido jamais vencido.\n" +
                        "\n" +
                        "Existe um grande clube na cidade,\n" +
                        "que mora dentro do meu coração\n" +
                        "Eu vivo cheio de vaidade\n" +
                        "pois na realidade é um grande campeão\n" +
                        "Nos gramados de Minas Gerais\n" +
                        "temos páginas heróicas e imortais\n" +
                        "Cruzeiro Cruzeiro querido\n" +
                        "tão combatido jamais vencido.\n",
                },

                new FootballClub
                {
                    Name = "Atlético-MG",
                    FullName = "Clube Atlético Mineiro",
                    Anthem =
                        "Nós somos do Clube Atlético Mineiro.\n" +
                        "Jogamos com muita raça e amor...\n" +
                        "Vibramos com alegria nas vitórias\n" +
                        "Clube Atlético Mineiro,\n" +
                        "Galo forte vingador.\n" +
                        "\n" +
                        "Vencer, vencer, vencer...\n" +
                        "Este é o nosso ideal.\n" +
                        "Honramos o nome de Minas\n" +
                        "No cenário esportivo mundial!\n" +
                        "Lutar, lutar, lutar...\n" +
                        "Pelos gramados do mundo para vencer.\n" +
                        "Clube Atlético Mineiro,\n" +
                        "Uma vez até morrer.\n" +
                        "\n" +
                        "Nós somos campeões do gelo\n" +
                        "O nosso time é imortal.\n" +
                        "Nós somos campeões dos campeões,\n" +
                        "Somos o orgulho do esporte nacional.\n" +
                        "Lutar, lutar, lutar...\n" +
                        "Com toda a nossa raça pra vencer.\n" +
                        "Clube Atlético Mineiro,\n" +
                        "Uma vez até morrer.\n" +
                        "\n" +
                        "Clube Atlético Mineiro,\n" +
                        "Uma vez até morrer.\n",
                },

                new FootballClub
                {
                    Name = "Atlético-PR",
                    FullName = "Clube Atlético Paranaense", 
                    Anthem =
                        "Atlético! Atlético!\n" +
                        "Conhecemos teu valor\n" +
                        "A camisa rubro-negra\n" +
                        "Só se veste por amor\n" +
                        "\n" +
                        "Vamos marchar sempre cantando\n" +
                        "O hino do Furacão\n" +
                        "E no peito ostentando\n" +
                        "A faixa de campeão\n" +
                        "\n" +
                        "Atlético! Atlético!\n" +
                        "Conhecemos teu valor\n" +
                        "A camisa rubro - negra\n" +
                        "Só se veste por amor\n" +
                        "\n" +
                        "O coração atleticano\n" +
                        "Estará sempre voltado\n" +
                        "Para os feitos do presente\n" +
                        "E as glórias do passado\n" +
                        "\n" +
                        "Atlético! Atlético!\n" +
                        "Conhecemos teu valor\n" +
                        "A camisa rubro - negra\n" +
                        "Só se veste por amor\n" +
                        "\n" +
                        "A tradição vigor sem jaça\n" +
                        "Nos legou o sangue forte\n" +
                        "Rubro - negro é quem tem raça\n" +
                        "E não teme a própria morte\n" +
                        "\n" +
                        "Atlético! Atlético\n" +
                        "Conhecemos teu valor\n" +
                        "A camisa rubro-negra\n" +
                        "Só se veste por amor\n",
                },

                new FootballClub
                {
                    Name = "Avaí",
                    FullName = "Avaí Futebol Clube", 
                    Anthem =
                        "Na ilha formosa,\n" +
                        "cheia de graça.\n" +
                        "O time da raça.\n" +
                        "É povo é gente,\n" +
                        "é bola pra frente,\n" +
                        "É só coração\n" +
                        "o meu Avaí\n" +
                        "\n" +
                        "Avaí meu Avaí.\n" +
                        "Da ilha és o Leão\n" +
                        "Avaí meu Avaí.\n" +
                        "Tu já nasceste campeão\n" +
                        "\n" +
                        "Não dá para esquecer\n" +
                        "o seu belo passado\n" +
                        "Mas a hora é presente\n" +
                        "e o time vem quente\n" +
                        "De encontro marcado\n" +
                        "com seus dias de glória\n" +
                        "Pois a ordem é vitória\n" +
                        "Vencer, vencer.\n",
                },

                new FootballClub
                {
                    Name = "Bahia",
                    FullName = "Esporte Clube Bahia", 
                    Anthem =
                        "Somos a Turma Tricolor,\n" +
                        "Somos a voz do campeão,\n" +
                        "Somos do povo o clamor,\n" +
                        "Ninguém nos vence em vibração!\n" +
                        "\n" +
                        "Vamos, avante, esquadrão!\n" +
                        "Vamos, serás o vencedor!\n" +
                        "Vamos, conquistar mais um tento!\n" +
                        "Bahia, Bahia, Bahia!\n" +
                        "Ouve esta voz que é seu alento!\n" +
                        "Bahia, Bahia, Bahia!\n" +
                        "\n" +
                        "Mais um!Mais um, Bahia!\n" +
                        "Mais um, mais um título de glória!\n" +
                        "Mais um!Mais um, Bahia!\n" +
                        "É assim que se resume a sua história!\n",
                },

                new FootballClub
                {
                    Name = "Vitória",
                    FullName = "Esporte Clube Vitória", 
                    Anthem =
                        "Vitória, Vitória\n" +
                        "Mostra o teu valor\n" +
                        "No campo da luta\n" +
                        "Tu é os melhor\n" +
                        "No teu pavilhão\n" +
                        "Tens feitos de Glória\n" +
                        "Vitória, Vitória\n" +
                        "Tu tens grande história\n" +
                        "\n" +
                        "Somos torcedores\n" +
                        "de grande valor\n" +
                        "somos rubro-negro\n" +
                        "não temos temor\n" +
                        "estamos contigo em qualquer lugar\n" +
                        "Pois temos conquistas\n" +
                        "na terra e no mar\n" +
                        "\n" +
                        "Vitória, Vitória\n" +
                        "Mostra o teu valor\n" +
                        "No campo da luta\n" +
                        "Tu é os melhor\n" +
                        "No teu pavilhão\n" +
                        "Tens feitos de Glória\n" +
                        "Vitória, Vitória\n" +
                        "Tu tens grande história\n" +
                        "\n" +
                        "Procura mostrar\n" +
                        "Todo teu poder\n" +
                        "Somos invenciveis\n" +
                        "Não vamos temer\n" +
                        "O teu pavilhão\n" +
                        "Nós vamos erguer\n" +
                        "Seremos Vitória até morrer\n" +
                        "\n" +
                        "Vitória, Vitória\n" +
                        "Mostra o teu valor\n" +
                        "No campo da luta\n" +
                        "Tu é os melhor\n" +
                        "No teu pavilhão\n" +
                        "Tens feitos de Glória\n" +
                        "Vitória, Vitória\n" +
                        "Tu tens grande história\n",
                },

                new FootballClub
                {
                    Name = "Ponte Preta", 
                    FullName = "Associação Atlética Ponte Preta", 
                    Anthem =
                        "Estandarte desfraldado\n" +
                        "preto e branco é sua cor\n" +
                        "Ponte Preta vai pro campo\n" +
                        "prá mostrar o seu valor\n" +
                        "\n" +
                        "Ponte Preta inflamante\n" +
                        "Ponte Preta emoção\n" +
                        "Ponte Preta gigante\n" +
                        "raça de campeão\n" +
                        "\n" +
                        "Seu estádio é o Majestoso\n" +
                        "seu nome uma glória\n" +
                        "Ponte Preta sempre sempre\n" +
                        "na derrota ou na vitória\n" +
                        "\n" +
                        "És a nossa Ponte Preta\n" +
                        "O orgulho de nossa terra\n" +
                        "Ponte Preta de paz\n" +
                        "Ponte Preta de guerra\n" +
                        "\n" +
                        "Ponte Preta de paz\n" +
                        "Ponte Preta de guerra\n",
                },

                new FootballClub
                {
                    Name = "Coritiba", 
                    FullName = "Coritiba Foot Ball Club", 
                    Anthem =
                        "Lá no alto de tantas glórias\n" +
                        "Brilhou, Brilhou um novo sol\n" +
                        "Clareando com seus raios verde e branco\n" +
                        "Encantando o país do futebol\n" +
                        "\n" +
                        "Palco de artistas, jogadores, de um passado sem igual\n" +
                        "Da arte dos teus grandes valores\n" +
                        "O seu nome pelo mundo vai brilhar\n" +
                        "Coritiba, Coritiba campeão do Paraná\n" +
                        "\n" +
                        "Tua camisa alviverde\n" +
                        "Com orgulho para sempre irei de amar\n" +
                        "Jogando pelos campos brasileiros\n" +
                        "Despertando na torcida emoção\n" +
                        "\n" +
                        "Coritiba Campeão do Povo\n" +
                        "Alegria do meu coração\n" +
                        "Coxa, Coxa, é garra, é força, é tradição\n" +
                        "Coxa, Coxa, explode o coração.\n",
                },

                new FootballClub
                {
                    Name = "Grêmio",
                    FullName = "Grêmio Foot-Ball Porto Alegrense", 
                    Anthem =
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "50 anos de glória\n" +
                        "Tens imortal tricolor\n" +
                        "Os feitos da tua história\n" +
                        "Canta o Rio Grande com amor\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo e que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "Nós somos bons torcedores\n" +
                        "Sem hesitarmos sequer\n" +
                        "Aplaudiremos o Grêmio\n" +
                        "Aonde o Grêmio estiver\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n" +
                        "\n" +
                        "Lara o craque imortal\n" +
                        "Soube seu nome elevar\n" +
                        "Hoje com o mesmo ideal\n" +
                        "Nós saberemos te honrar\n" +
                        "\n" +
                        "Até a pé nós iremos\n" +
                        "Para o que der e vier\n" +
                        "Mas o certo é que nós estaremos\n" +
                        "Com o Grêmio onde o Grêmio estiver\n",
                },

                new FootballClub
                {
                    Name = "Atlético-GO",
                    FullName = "Atlético Clube Goianiense", 
                    Anthem =
                        "Meu Atlético,\n" +
                        "Meu estandarte\n" +
                        "Modéstia à parte tem a força\n" +
                        "Quente de um dragão\n" +
                        "Meu Atlético tem a mania de dar\n" +
                        "Alegria pro meu coração...\n" +
                        "Meu rubro negro, eu chego e vejo,\n" +
                        "Você cumprindo o meu desejo de vencer, vencer,\n" +
                        "Vencer!\n" +
                        "Dá gosto ver nosso esquadrão,\n" +
                        "Rolando a bola pelo chão e\n" +
                        "Dando um show e mais um gol...\n" +
                        "Lê Lêlêoo\n" +
                        "Lê Lêlêoo\n" +
                        "Atlético!\n",
                },

                new FootballClub
                {
                    Name = "Sport",
                    FullName = "Sport Club do Recife", 
                    Anthem =
                        "Com o Sport Eternamente estarei\n" +
                        "Pois rubro-negras são\n" +
                        "As cores que abracei\n" +
                        "E o abraço, de tão forte,\n" +
                        "Não tem separação\n" +
                        "Pra mim, o meu Sport É religião\n" +
                        "\n" +
                        "A vida a gente vive\n" +
                        "Pra vencer Sport, Sport\n" +
                        "Uma razão para viver\n" +
                        "\n" +
                        "Treze de Maio,\n" +
                        "Mil novecentos e cinco\n" +
                        "Dia divino em que Guilherme de Aquino\n" +
                        "Reune, no Recife, ardentes seguidores\n" +
                        "Fundando esta nação de vencedores\n" +
                        "Que encanta, enobrece e dá prazer\n" +
                        "Sport, Sport\n" +
                        "Uma razão para viver\n" +
                        "\n" +
                        "Eterno símbolo de orgulho\n" +
                        "É o pavilhão\n" +
                        "De listras pretas e vermelhas,\n" +
                        "Com o Leão\n" +
                        "Erguendo, imponente, o imortal escudo\n" +
                        "Mostrando à gente que o Sport é tudo\n" +
                        "Que a vida tem de belo a oferecer\n" +
                        "Sport, Sport Uma razão para viver\n" +
                        "\n" +
                        "São gerações e corações\n" +
                        "Fazendo a história\n" +
                        "São campeões e emoções\n" +
                        "Tercendo a glória\n" +
                        "Do bravo Leão da Ilha, Sport obsessão\n" +
                        "Que faz bater mais forte o coração\n" +
                        "Torcida mais fiel não pode haver\n" +
                        "Sport, Sport Uma razão para viver\n" +
                        "Sport! Sport! Sport!\n",
                },

                new FootballClub
                {
                    Name = "Chapecoense",
                    FullName = "Associação Chapecoense de Futebol", 
                    Anthem =
                        "Ó glorioso verde que se expande\n" +
                        "Entre os estados, tu és sempre um esplendor\n" +
                        "Nas alegrias e nas horas mais difíceis\n" +
                        "Meu furacão, tu és sempre um vencedor\n" +
                        "\n" +
                        "São tantos títulos outrora conquistados\n" +
                        "Com bravura, muita raça e fervor\n" +
                        "Leva consigo o coração de uma cidade\n" +
                        "Meu furacão, tu és sempre um vencedor\n" +
                        "\n" +
                        "Sempre honrando nosso escudo com sua raça\n" +
                        "És alegria nos estádios nunca só\n" +
                        "Na imensidão e vastidão de nosso estado\n" +
                        "Chapecoense, tu és sempre Chapecó\n" +
                        "\n" +
                        "A força imensa de sua fiel torcida\n" +
                        "Que nos estádios tudo é lindo e nos fascina\n" +
                        "A nossa massa, meu verdão mexe contigo\n" +
                        "Tu és querido em toda Santa Catarina\n",
                },

                new FootballClub
                {
                    Name = "Internacional",
                    FullName = "Sport Club Internacional", 
                    Anthem =
                        "Glória do desporto nacional\n" +
                        "Oh, Internacional\n" +
                        "Que eu vivo a exaltar\n" +
                        "Levas a plagas distantes\n" +
                        "Feitos relevantes\n" +
                        "Vives a brilhar\n" +
                        "Correm os anos surge o amanhã\n" +
                        "Radioso de luz, varonil\n" +
                        "Segue a tua senda de vitórias\n" +
                        "Colorado das glórias\n" +
                        "Orgulho do Brasil\n" +
                        "\n" +
                        "É teu passado alvi-rubro\n" +
                        "Motivo de festas em nossos corações\n" +
                        "O teu presente diz tudo\n" +
                        "Trazendo à torcida alegres emoções\n" +
                        "Colorado de ases celeiro\n" +
                        "Teus astros cintilam num céu sempre azul\n" +
                        "Vibra o Brasil inteiro\n" +
                        "Com o clube do povo do Rio Grande do Sul\n",
                },
            };
        }
    }
}
