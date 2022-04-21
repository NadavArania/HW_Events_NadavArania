namespace HW_Events_NadavArania
{
    public class LocationEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LocationEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}