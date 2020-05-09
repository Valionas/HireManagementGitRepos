using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HireManagement.Data;
using HireManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace HireManagement.Models
{
    public class WorkerService
    {
        private  HireContext _context;

        public WorkerService()
        {
        }

        public WorkerService(HireContext context)
        {
            _context = context;
        }


        public IQueryable<Worker> WorkerSearch(string text)
        {
            var workers = from w in _context.Workers
                          select w;


            if (!String.IsNullOrEmpty(text))
            {
                workers = workers.Where(c => c.FirstName.Contains(text));
            }
            return workers;

        }

       
    }
}
