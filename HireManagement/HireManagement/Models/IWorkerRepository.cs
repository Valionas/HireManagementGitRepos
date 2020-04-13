using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
    public interface IWorkerRepository
    {
        Worker GetWorker(int Id);
        ICollection<Worker> GetAllWorkers();
        Worker Add(Worker worker);
    }
}
