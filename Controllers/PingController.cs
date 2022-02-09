using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace PingServer.Controllers;

[Route("[controller]")]
public class PingController : Controller
{
    public async Task<IActionResult> M()
    {
        using RestClient client = new RestClient();
        RestRequest request = new RestRequest("https://1.1.1.1", Method.Get);

        RestResponse response = await client.ExecuteAsync(request);

        return response.IsSuccessful
            ? Ok()
            : BadRequest();
    }
}