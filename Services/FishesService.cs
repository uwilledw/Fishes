namespace Fishes.Services;

public class FishesService
{
    private readonly FishesRepository _repo;
    public FishesService(FishesRepository repo)
    {
        _repo = repo;
    }

    internal List<Fish> Get()
    {
        List<Fish> fishes = _repo.Get();
        return fishes;
    }

    internal Fish GetOne(int fishId)
    {
        Fish fish = _repo.GetOne(fishId);
        if (fish == null)
        {
            throw new Exception($"no fish at id {fishId}");
        }
        return fish;
    }

    internal Fish Create(Fish fishData)
    {
        Fish fish = _repo.Create(fishData);
        return fish;
    }

    internal string Remove(int fishId)
    {
        Fish fish = this.GetOne(fishId);
        _repo.Remove(fishId);
        return $"{fish.Name} was bought.";
    }
}