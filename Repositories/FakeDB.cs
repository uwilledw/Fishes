namespace Fishes.Repositories;


public class FakeDB
{
    public List<Fish> Fishes;

    public FakeDB()
    {
        Fishes = new List<Fish>();
        Fishes.Add(new Fish("Goldie", "Gold", 5, 4, 1));
        Fishes.Add(new Fish("Nemo", "Orange", 1, 3, 2));
        Fishes.Add(new Fish("Dory", "Blue", 4, 4, 3));
        Fishes.Add(new Fish("Dave", "white", 2, 6, 4));
    }

}