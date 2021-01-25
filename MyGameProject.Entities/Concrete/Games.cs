using MyGameProject.Core.MyGameProject.Entities;

namespace MyGameProject.Entities.Concrete
{
    public class Games: IGameList
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}