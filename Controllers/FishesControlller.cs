namespace Fishes.Controllers;

[ApiController]
[Route("api/fishes")]
public class FishesController : ControllerBase
{
    private readonly FishesService _fishesService;
    public FishesController(FishesService fishesService)
    {
        _fishesService = fishesService;
    }

    [HttpGet]
    public ActionResult<List<Fish>> Get()
    {
        try
        {
            List<Fish> fishes = _fishesService.Get();
            return Ok(fishes);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{fishId}")]
    public ActionResult<Fish> GetOne(int fishId)
    {
        try
        {
            Fish fish = _fishesService.GetOne(fishId);
            return Ok(fish);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Fish> Create([FromBody] Fish fishData)
    {
        try
        {
            Fish fish = _fishesService.Create(fishData);
            return Ok(fish);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{fishId}")]
    public ActionResult<string> Remove(int fishId)
    {
        try
        {
            string message = _fishesService.Remove(fishId);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}