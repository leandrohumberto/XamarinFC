using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFC.Model.Entity;
using XamarinFC.Model.Repository;

[assembly: Dependency(typeof(OfflineFootballClubRepository))]
namespace XamarinFC.Model.Repository
{
    public class OfflineFootballClubRepository : IFootballClubRepository
    {
        public async Task<IEnumerable<FootballClub>> GetClubData()
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
                    Anthem = "Oi?",
                },

                new FootballClub
                {
                    Name = "Vasco",
                    Anthem = "VICE",
                },

                new FootballClub
                {
                    Name = "Cruzeiro",
                    Anthem = "Marias",
                },

                new FootballClub
                {
                    Name = "Atlético-MG",
                    Anthem = "Patético-MG",
                },

                new FootballClub
                {
                    Name = "Atlético-PR",
                    Anthem = "",
                },

                new FootballClub
                {
                    Name = "Avaí",
                    Anthem = "???",
                },

                new FootballClub
                {
                    Name = "Bahia",
                    Anthem = "MINHA PORRA",
                },

                new FootballClub
                {
                    Name = "Vitória",
                    Anthem = "...",
                },

                new FootballClub
                {
                    Name = "Ponte Preta",
                    Anthem = "Macaca",
                },

                new FootballClub
                {
                    Name = "Coritiba",
                    Anthem = "Coxa",
                },

                new FootballClub
                {
                    Name = "Grêmio",
                    Anthem = "Gaymio",
                },

                new FootballClub
                {
                    Name = "Atlético-GO",
                    Anthem = "Walter",
                },

                new FootballClub
                {
                    Name = "Sport",
                    Anthem = "CASA-CASA-CASA",
                },

                new FootballClub
                {
                    Name = "Chapecoense",
                    Anthem = "R.I.P.",
                },
            };
        }
    }
}
