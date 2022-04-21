using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events_NadavArania
{
    internal  class SpaceQuestGameManager
    {
        private int goodSpaceShipHp;
        private int shipXLocation;
        private int shipYLocation;
        private int numberOfBadShips;
        private int currentLevel;
        public event EventHandler<PointsEventsArgs> GoodSpaceShipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int _goodSpaceShipHp, int _shipXLocation, int _shipYLocation, int _numberOfBadShips, int _currentLevel)
        {
            goodSpaceShipHp = _goodSpaceShipHp;
            shipXLocation = _shipXLocation;
            shipYLocation = _shipYLocation;
            numberOfBadShips = _numberOfBadShips;
            currentLevel = _currentLevel;
        }

        public void MoveSpaceShip(int newX, int newY)
        {
            CheckIfGoodShipSurvived();
            shipXLocation = newX;
            shipYLocation = newY;
            OnGoodSpaceShipLocationChanged();
        }

        public void GoodSpaceShipGotDamaged(int damage)
        {
            CheckIfGoodShipSurvived();
            goodSpaceShipHp -= damage;
            OnGoodSpaceShipHpChanged();
        }

        public void GoodSpaceShipGotExtraHp(int extraHp)
        {
            CheckIfGoodShipSurvived();
            goodSpaceShipHp += extraHp;
            OnGoodSpaceShipHpChanged();
        }

        public void EnemyShipsDestroyed(int numberOfBadShipsDestroyed)
        {
            if (numberOfBadShips <= 0)
            {
                currentLevel++;
                OnLevelUpReached();
                goodSpaceShipHp = 100;
                shipXLocation = 50;
                shipYLocation = 50;
                numberOfBadShips = 10;
            }
            numberOfBadShips -= numberOfBadShipsDestroyed;
            OnBadShipsExploded();
        }

        private void OnGoodSpaceShipHpChanged()
        {
            GoodSpaceShipHPChanged?.Invoke(this, new PointsEventsArgs(goodSpaceShipHp));
        }

        private void OnGoodSpaceShipLocationChanged()
        {
            GoodSpaceShipLocationChanged?.Invoke(this, new LocationEventArgs(shipXLocation, shipYLocation));
        }

        private void OnGoodSpaceShipDestroyed()
        {
            GoodSpaceShipDestroyed?.Invoke(this, new LocationEventArgs(shipXLocation, shipYLocation));
        }

        private void OnBadShipsExploded()
        {
            BadShipsExploded?.Invoke(this, new BadShipsExplodedEventArgs(numberOfBadShips));
        }

        private void OnLevelUpReached()
        {
            LevelUpReached?.Invoke(this, new LevelEventArgs(currentLevel));
        }

        private void CheckIfGoodShipSurvived()
        {
            if (goodSpaceShipHp <= 0)
            {
                currentLevel = 1;
                OnGoodSpaceShipDestroyed();
                goodSpaceShipHp = 100;
                shipXLocation = 50;
                shipYLocation = 50;
                numberOfBadShips = 10;
            }
        }
    }
}
