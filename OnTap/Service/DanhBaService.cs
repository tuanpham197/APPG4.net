using OnTap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.Service
{
    class DanhBaService
    {
        public static AppG4Context db = new AppG4Context();
        public static List<DanhBa> GetListContactByIDStudent(String idStudent)
        {
            return new AppG4Context().danhBas.Where(e => e.idStudent == idStudent).ToList();
        }

        public static void deleteContact(String id)
        {

            var itemToRemove = db.danhBas.SingleOrDefault(x => x.ID.Equals(id));
            if (itemToRemove != null)
            {
                db.danhBas.Remove(itemToRemove);
                db.SaveChanges();
            }
        }
        public static List<DanhBa> SearchContact(String key,String idStudent)
        {
            if(key == "")
                return db.danhBas.Where(e => e.idStudent.Equals(idStudent)).ToList();
            return db.danhBas.Where(e => (e.idStudent.Equals(idStudent)) && (e.Name.ToLower().Contains(key.ToLower()) || e.Email.ToLower().Contains(key.ToLower()))).ToList();
        }
        public static void addContact(DanhBa danhBa)
        {
            db.danhBas.Add(danhBa);
            db.SaveChanges();
        }
        public static void EditContact(DanhBa danhBa,String id)
        {
            DanhBa dBa = db.danhBas.Where(e => e.ID.Equals(id)).FirstOrDefault();
            dBa.Name = danhBa.Name;
            dBa.PhoneNumber = danhBa.PhoneNumber;
            dBa.Email = danhBa.Email;
            db.SaveChanges();
        }
        public static List<DanhBa> FilterContactByCharFirst(String ch,String idStudent)
        {
            return db.danhBas.Where(e => e.idStudent.Equals(idStudent) && e.Name.ToUpper().StartsWith(ch)).ToList();
        }
    }
}
