using BillSystem.Objects.Works;
using System;
using System.Collections.Generic;

namespace BillSystem.Objects.Workplaces
{
    public interface IWorkplace
    {
        Guid Id { get; }
        string Name { get; }
        List<Work> Works { get; }
    }
}
