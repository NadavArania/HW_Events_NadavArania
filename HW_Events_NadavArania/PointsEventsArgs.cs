namespace HW_Events_NadavArania
{
    public class PointsEventsArgs : EventArgs
    {
        public int Hp { get; set; }

        public PointsEventsArgs(int hp)
        {
            Hp = hp;
        }
    }
}