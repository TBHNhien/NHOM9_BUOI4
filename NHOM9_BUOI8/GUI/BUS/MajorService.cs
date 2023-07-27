using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MajorService
    {
        private static MajorService instance;

        public static MajorService Instance
        {
            get { if (instance == null) instance = new MajorService(); return instance; }
            private set { instance = value; }
        }

        public List<MAJOR> GetAllByFaculty(int facultyID)
        {
            StudentContextDB context = new StudentContextDB();
            return context.MAJORs.Where(p => p.FALCULTYID == facultyID).ToList();
        }


    }
}
