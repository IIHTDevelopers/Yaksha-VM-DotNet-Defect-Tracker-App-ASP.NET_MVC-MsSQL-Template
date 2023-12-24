using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefectTrackerApp.DAL.Repository
{
    public class DefectTrackerService : IDefectTrackerInterface
    {
        private IDefectTrackerRepository _repo;
        public DefectTrackerService(IDefectTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteDefect(int DefectId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Defect GetDefectByID(int DefectId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Defect> IDefectTrackerInterface.GetDefects()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Defect IDefectTrackerInterface.InsertDefect(Defect Defect)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IDefectTrackerInterface.UpdateDefect(Defect Defect)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}