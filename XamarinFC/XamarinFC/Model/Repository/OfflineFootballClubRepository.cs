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
                    Anthem = "GAAAAAAAAAAAAAAAAAAAAAAAAYYYYYYYYYYY",
                },

                new FootballClub
                {
                    Name = "Santos",
                    Anthem = "pran7os",
                },

                new FootballClub
                {
                    Name = "Palmeiras",
                    Anthem = "Não tem mundial",
                },

                new FootballClub
                {
                    Name = "Fluminense",
                    Anthem = "FluminenC",
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
