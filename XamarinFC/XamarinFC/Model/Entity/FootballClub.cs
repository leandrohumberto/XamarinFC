namespace XamarinFC.Model.Entity
{
    public class FootballClub
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Anthem { get; set; }

        public override string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}
