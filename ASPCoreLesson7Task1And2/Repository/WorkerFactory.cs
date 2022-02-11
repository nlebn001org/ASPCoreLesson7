using ASPCoreLesson7Task1And2.Models;
using System.Collections.Generic;

namespace ASPCoreLesson7Task1And2.Repository
{
    public static class WorkerFactory
    {
        public static List<Worker> CreateWorker(int count)
        {
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < count; i++)
                workers.Add(new Worker() { WorkerID = i, Name = $"WorkerName{i}", Surname = $"WorkerSurname{i}" });
            return workers;

        }
    }
}
