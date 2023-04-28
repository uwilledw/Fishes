
using System.ComponentModel.DataAnnotations;

namespace Fishes.Models;


public class Fish
{
    public Fish(string name, string color, int age, int fins, int id)
    {
        Name = name;
        Color = color;
        Age = age;
        Fins = fins;
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public int Fins { get; set; }

}