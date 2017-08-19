using System;
using System.Linq;

public class Clinic
{
    private int numberOfRooms;
    private Pet[] rooms;
    private int centerRoom;
    public Clinic(string name, int numberOfRooms)
    {
        this.Name = name;
        this.NumberOfRooms = numberOfRooms;
        this.centerRoom = numberOfRooms / 2;
        this.rooms = new Pet[numberOfRooms];
    }

    public string Name { get; set; }

    public int NumberOfRooms
    {
        get => this.numberOfRooms;
        set
        {
            if (value % 2 == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            this.numberOfRooms = value;
        }
    }

    public bool AddPet(Pet pet)
    {
        
        for (int i = 0; i <= centerRoom; i++)
        {
            if (rooms[centerRoom - i] == null)
            {
                rooms[centerRoom - i] = pet;
                return true;
            }
            if (rooms[centerRoom + i] == null)
            {
                rooms[centerRoom + i] = pet;
                return true;
            }
        }
        return false;
    }

    public bool Release()
    {
        for (int i = this.centerRoom; i < this.rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                rooms[i] = null;
                return true;
            }
        }
        for (int i = 0; i < this.centerRoom; i++)
        {
            if (rooms[i] != null)
            {
                rooms[i] = null;
                return true;
            }
        }
        return false;
    }

    public bool HasEmptyRooms() => this.rooms.Any(r => r == null);

    public void Print(int roomNumber)
    {
        roomNumber--;
        if (roomNumber < 0 || roomNumber > this.rooms.Length)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        if (rooms[roomNumber] == null)
        {
            Console.WriteLine("Room empty");
        }
        else
        {
            Console.WriteLine(rooms[roomNumber]);
        }
    }

    public void Print()
    {
        foreach (var room in this.rooms)
        {
            if (room == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                Console.WriteLine(room);
            }
            
        }
    }
}

