using HW_Events_NadavArania;

SpaceQuestGameManager sqgm = new SpaceQuestGameManager(100, 200, 150, 10, 1);
GameViewer gv = new GameViewer();

sqgm.GoodSpaceShipHPChanged += gv.GoodSpaceShipHpChangedEventHandler;
sqgm.GoodSpaceShipLocationChanged += gv.GoodSpaceShipLocationChangedEventHandler;
sqgm.GoodSpaceShipDestroyed += gv.GoodSpaceShipDestroyedEventHandler;
sqgm.BadShipsExploded += gv.BadShipsExplodedEventHandler;
sqgm.LevelUpReached += gv.LevelUpReachedEventHandler;

Timer timer = new Timer(TimerEventHandler, null, 0, 1000);

while (true)
{

}

void TimerEventHandler(object? state)
{
    Random rnd = new Random();
    sqgm.MoveSpaceShip(rnd.Next(0, 250), rnd.Next(0, 250));
    sqgm.EnemyShipsDestroyed(rnd.Next(0, 5));
    sqgm.GoodSpaceShipGotDamaged(rnd.Next(0, 30));
    sqgm.GoodSpaceShipGotExtraHp(rnd.Next(0, 10));
}

