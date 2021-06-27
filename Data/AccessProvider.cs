using VetClinic.Models;  
using System.Collections.Generic;  
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace VetClinic.Data  
{  
    public class AccessProvider: IAccessProvider  
    {  
        private readonly DataContext _context;  
  
        public AccessProvider (DataContext context)  
        {  
            _context = context;  
        }  

        public void CreateUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int UserId)
        {
            var userDel = _context.users.FirstOrDefault(t => t.UserId == UserId);
            _context.users.Remove(userDel);
            _context.SaveChanges();
        }

        public User GetUser(int UserId)
        {
            return _context.users.FirstOrDefault(u => u.UserId == UserId);
        }

        public List<User> GetUsers()
        {
            return _context.users.ToList();
        }

        public void CreatePet(Pet pet)
        {
            _context.pets.Add(pet);
            _context.SaveChanges();
        }

        public void UpdatePet(Pet pet)
        {
            _context.pets.Update(pet);
            _context.SaveChanges();
        }

        public void DeletePet(int PetId)
        {
            var petDel = _context.pets.FirstOrDefault(t => t.PetId == PetId);
            _context.pets.Remove(petDel);
            _context.SaveChanges();
        }

        public Pet GetPet(int PetId)
        {
            return _context.pets.FirstOrDefault(u => u.PetId == PetId);
        }

        public List<Pet> GetPets()
        {
            return _context.pets.ToList();
        }

        public void CreateVisit(Visit visit)
        {
            _context.visits.Add(visit);
            _context.SaveChanges();
        }

        public void UpdateVisit(Visit visit)
        {
            _context.visits.Update(visit);
            _context.SaveChanges();
        }

        public void DeleteVisit(int VisitId)
        {
            var visitDel = _context.visits.FirstOrDefault(t => t.VisitId == VisitId);
            _context.visits.Remove(visitDel);
            _context.SaveChanges();
        }

        public Visit GetVisit(int VisitId)
        {
            return _context.visits.FirstOrDefault(u => u.VisitId == VisitId);
        }

        public List<Visit> GetVisits()
        {
            return _context.visits.ToList();
        }
    }  
}  