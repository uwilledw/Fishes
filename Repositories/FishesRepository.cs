namespace Fishes.Repositories;

public class FishesRepository
{
    private readonly FakeDB _db;

    public FishesRepository(FakeDB db)
    {
        _db = db;
    }

    internal Fish Create(Fish fishData)
    {
        int fishId = _db.Fishes[_db.Fishes.Count - 1].Id + 1;
        Fish newFish = new Fish(fishData.Name, fishData.Color, fishData.Age, fishData.Fins, fishId);
        _db.Fishes.Add(newFish);
        return newFish;
    }

    internal List<Fish> Get()
    {
        return _db.Fishes;
    }

    internal Fish GetOne(int fishId)
    {
        Fish fish = _db.Fishes.Find(f => f.Id == fishId);
        return fish;
    }

    internal void Remove(int fishId)
    {
        Fish fish = this.GetOne(fishId);
        _db.Fishes.Remove(fish);

    }
}