using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DefectTrackerApp.DAL.Repository
{
    public class DefectTrackerRepository : IDefectTrackerRepository
    {
        private DefectTrackerDbContext _context;
        public DefectTrackerRepository(DefectTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Defect> GetDefects()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Defect GetDefectByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Defect InsertDefect(Defect Defect)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteDefect(int DefectID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateDefect(Defect Defect)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
