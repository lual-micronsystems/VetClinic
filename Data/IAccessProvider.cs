using VetClinic.Models;  
using System.Collections.Generic;
using System;

namespace VetClinic.Data
{  
    public interface IAccessProvider  
    {  
        void CreateUser(User user);  
        void UpdateUser(User user);  
        void DeleteUser(int UserId);  
        User GetUser(int UserId);  
        List<User> GetUsers();  

        void CreatePet(Pet pet);
        void UpdatePet(Pet pet);
        void DeletePet(int PetId);
        Pet GetPet(int PetId);
        List<Pet> GetPets();

        void CreateVisit(Visit visit);
        void UpdateVisit(Visit visit);
        void DeleteVisit(int VisitId);
        Visit GetVisit(int VisitId);
        List<Visit> GetVisits();
    }  
}  