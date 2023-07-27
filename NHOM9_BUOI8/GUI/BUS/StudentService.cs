using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        //TẠO SINGLETON

        private static StudentService instance;

        public static StudentService Instance
        {
            get { if (instance == null) instance = new StudentService(); return instance; }
            private set { instance = value; }
        }

        public List<STUDENT> GetAll()
        {
            StudentContextDB context = new StudentContextDB(); 
            return context.STUDENTs.ToList();
        }

        public List<STUDENT> GetAllHasNoMajor()
        {
            StudentContextDB context = new StudentContextDB();
            return context.STUDENTs.Where(p=>p.MAJORID == null).ToList();
        }

        public List<STUDENT> GetAllHasNoMajor(int FalID)
        {
            StudentContextDB context = new StudentContextDB();
            return context.STUDENTs.Where(p => p.MAJORID == null && p.FacultyId == FalID).ToList();
        }

        public STUDENT FindById(string studentId)
        {
            StudentContextDB context = new StudentContextDB();
            return context.STUDENTs.FirstOrDefault(p=>p.STUDENTID == studentId);
        }

        public void InsertUpdate(STUDENT s)
        {
            StudentContextDB context = new StudentContextDB();
            context.STUDENTs.AddOrUpdate(s);
            context.SaveChanges();
        }


    }
}
