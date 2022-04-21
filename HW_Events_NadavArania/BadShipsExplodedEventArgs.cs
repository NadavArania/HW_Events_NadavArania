namespace HW_Events_NadavArania
{
    public class BadShipsExplodedEventArgs
    {
        public int NumOfBadShipsExploded { get; set; }

        public BadShipsExplodedEventArgs(int numOfBadShipsExploded)
        {
            NumOfBadShipsExploded = numOfBadShipsExploded;
        }
    }
}