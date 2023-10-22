namespace BillSystem.Objects.Works
{
    public class Work : IWork
    {
        public string Name { get; }
        public uint Time { get; }

        public Work()
        {
        }

        public Work(string name, uint time)
        {
            Name = name;
            Time = time;
        }
    }
}
