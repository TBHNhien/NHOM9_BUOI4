using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FacultyService
    {
        private static FacultyService instance;

        public static FacultyService Instance
        {
            get { if (instance == null) instance = new FacultyService(); return instance; }
            private set { instance = value; }
        }

        public List<FACULTY> GetAll()
        {
            StudentContextDB context = new StudentContextDB();
            return context.FACULTies.ToList();
        }

    }
}
