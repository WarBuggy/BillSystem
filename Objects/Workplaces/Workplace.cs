using BillSystem.Objects.Works;
using System;
using System.Collections.Generic;

namespace BillSystem.Objects.Workplaces
{
    public class Workplace : IWorkplace
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public List<Work> Works { get; }

        public Workplace()
        {
        }

        public Workplace(string name, List<Work> works)
        {
            Id = Guid.NewGuid();
            Name = name;
            Works = works;
        }
    }
}
