using System;
using System.Collections.Generic;
using System.Text;
using WorkerContract.Entities.Enum;

namespace WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker(string name, WorkLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {
            
        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            return 0;
        }
    }
}
