namespace HW_Events_NadavArania
{
    public class LevelEventArgs
    {
        public int CurrentLevel { get; set; }

        public LevelEventArgs(int currentLevel)
        {
            CurrentLevel = currentLevel;
        }
    }
}