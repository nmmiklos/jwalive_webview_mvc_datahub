namespace jwParsed_WebView.Models
{
    public class Creature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Class { get; set; }
        public int? Health { get; set; }
        public int? Damage { get; set; }
        public int? Speed { get; set; }
        public int? Armor { get; set; }
        public int? Crit { get; set; }
        public string Version { get; set; }
    }
}