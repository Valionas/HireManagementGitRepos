using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
    public class WorkerHolderRepository:IWorkerRepository
    {
        private List<Worker> _workerlist;
        public WorkerHolderRepository()
        {
            _workerlist = new List<Worker>()
            {
                new Worker() { ID = 1, FirstName = "Valkata", LastName = "Kolev", Age = 20, City = "Tarnovgrad", Email = "sdms@abv.bg", JoinedDate = DateTime.UtcNow},
                new Worker() { ID = 2, FirstName = "Valkata DIV", LastName = "Kolevich", Age = 22, City = "Tarnovgrad", Email = "sdss@abv.bg", JoinedDate = DateTime.UtcNow }
            };
        }

        public Worker Add(Worker worker)
        {
            worker.ID = _workerlist.Max(e => e.ID) + 1;
            _workerlist.Add(worker);
            return worker;
        }

        public ICollection<Worker> GetAllWorkers()
        {
            return _workerlist;
        }

        public Worker GetWorker(int Id)
        {
            return _workerlist.FirstOrDefault(e => e.ID == Id);
        }
    }
}
