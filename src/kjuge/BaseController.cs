using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class BaseController : ControllerBase
{
    private readonly YrIntegration _yrIntegration;

    public BaseController(YrIntegration yrIntegration)
    {
        _yrIntegration = yrIntegration;
    }


    [Route("")]
    public async Task<string> GetRoot()
    {
        await _yrIntegration.GetWeather();
        return "Hello world";
    }

}