using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFC.Model.Entity
{
    public class FootballClub
    {
        public string Name { get; set; }
        public string Anthem { get; set; }

        public override string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}
