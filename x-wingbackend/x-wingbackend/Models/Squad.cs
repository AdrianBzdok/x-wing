namespace x_wingbackend.Models
{
    public class Squad
    {
        public int ID { get; set; }
        public Player Player { get; set; }
        public string Name { get; set; }
        public int Points {get; set;}
        public string Type { get; set; }
        public Ship[] Ships { get; set; }
    }
}