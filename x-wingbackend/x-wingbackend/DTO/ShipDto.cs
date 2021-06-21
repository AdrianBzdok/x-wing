using x_wingbackend.Interfaces;

namespace x_wingbackend.DTO
{
    public class ShipDto
    {
        public string Name { get; set; }
        public int TypeNum {get; set;}
       // public Manuver[] Manuvers { get; set; }
        public ITrait[] Traits { get; set; }
        public int MaxHull { get; set; }
        public int MaxShield { get; set; }
        public int Hull { get; set; }
        public int Shield { get; set; }
        public int Points { get; set; }
        public ShipDto(string Name,int TypeNum,/* Manuver[] Manuvers,*/ ITrait[] Traits,int MaxHull, int MaxShield,int Points)
        {
            this.Name = Name;
            this.TypeNum = TypeNum;
           // this.Manuvers = Manuvers;
            this.MaxHull = MaxHull;
            this.MaxShield = MaxShield;
            this.Hull = MaxHull;
            this.Shield = MaxShield;
            this.Points = Points;
        }
    }
}