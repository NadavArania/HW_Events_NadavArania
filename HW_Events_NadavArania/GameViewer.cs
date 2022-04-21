using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events_NadavArania
{
    internal class GameViewer
    {
        public void GoodSpaceShipHpChangedEventHandler(object sender, PointsEventsArgs pe)
        {
            Console.WriteLine($"Hp left : {pe.Hp}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs le)
        {
            Console.WriteLine($"New location X : {le.X}, new location Y : {le.Y}");
        }

        public void GoodSpaceShipDestroyedEventHandler(object sender, LocationEventArgs le)
        {
            Console.WriteLine($"Game Over!");
        }

        public void BadShipsExplodedEventHandler(object sender, BadShipsExplodedEventArgs bsee)
        {
            Console.WriteLine($"Bad ship remaining : {bsee.NumOfBadShipsExploded}");
        }

        public void LevelUpReachedEventHandler(object sender, LevelEventArgs le)
        {
            Console.WriteLine($"You've been promoted to level : {le.CurrentLevel}");
        }
    }
}
