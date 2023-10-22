using BillSystem.Objects.Works;
using System;

namespace BillSystem.Objects.Jobs
{
    public class Job : IJob
    {
        public Guid Id { get; }
        public IWork Work { get; }
        public uint Time { get; set; }
        public bool Completed { get; set; }

        public Job()
        {
        }

        public Job(Work work)
        {
            Id = Guid.NewGuid();
            Work = work;
            Time = 0;
            Completed = false;
        }
    }
}
