using MyGameProject.Core.MyGameProject.Entities;

namespace MyGameProject.Entities.Concrete
{
    public class Player : IPlayer
    {
        public int PlayerId { get; set; }
        public string NumberId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string DateofBirth { get; set; }
        public double Balance { get; set; }
    }
}