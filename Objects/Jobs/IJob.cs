using BillSystem.Objects.Works;
using System;

namespace BillSystem.Objects.Jobs
{
    public interface IJob
    {
        Guid Id { get; }
        uint Time { get; set; }
        IWork Work { get; }
        bool Completed { get; set; }
    }
}
