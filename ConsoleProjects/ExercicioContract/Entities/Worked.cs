using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioContract.Entities.Enums;

namespace ExercicioContract.Entities
{
    internal class Worked
    {
        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament? NameDepartament { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Worked() { }

        public Worked(string? name, WorkerLevel level, double baseSalary, Departament nameDepartament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            NameDepartament = nameDepartament;
        }

        public void AddContract(HoursContract Contract)
        {
            Contracts.Add(Contract);
        }

        public void RemoveContract(HoursContract Contract)
        {
            Contracts.Remove(Contract);
        }

        public double Income(int year, int month)
        {
            double Value = BaseSalary;
            foreach (HoursContract Contract in Contracts)
            {
                if (year == Contract.Date.Year && month == Contract.Date.Month) { Value += Contract.TotalValue(); }
            }
            return Value;
        }
    }
}
