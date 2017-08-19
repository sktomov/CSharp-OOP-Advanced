using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInpreter
{
    private List<Pet> pets;
    private List<Clinic> clinics;

    public CommandInpreter()
    {
        this.clinics = new List<Clinic>();
        this.pets = new List<Pet>();
    }

    public void CreatePet(string name, int age, string kind)
    {
        var pet = new Pet(name, age, kind);
        this.pets.Add(pet);
    }

    public void CreateClinic(string name, int numberOfRooms)
    {
        var clinic = new Clinic(name, numberOfRooms);
        this.clinics.Add(clinic);
    }

    public bool AddPetToClinic(string petName, string clinicName)
    {
        var clinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
        var pet = this.pets.FirstOrDefault(p => p.Name == petName);
        if (clinic == null || pet == null)
        {
            throw  new ArgumentException("Invalid Operation!");
        }
        return clinic.AddPet(pet);
    }

    public bool ReleaseClinic(string clinicName)
    {
        var clinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
        if (clinic == null)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        return clinic.Release();
    }

    public void PrintRoomOfClinic(string clinicName, int roomNumber)
    {
        var clinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
        if (clinic == null)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        clinic.Print(roomNumber);
    }
    public void PrintClinic(string clinicName)
    {
        var clinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
        if (clinic == null)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        clinic.Print();
    }

    public bool EmptyRooms(string clinicName)
    {
        var clinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
        if (clinic == null)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        return clinic.HasEmptyRooms();
    }
}

