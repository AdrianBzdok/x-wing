namespace x_wingbackend.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Table[] Tables { get; set; }
        public Squad[] Squads { get; set; }
        public Player(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}