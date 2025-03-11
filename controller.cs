using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api")]
public class controller
{

    public async Task<ActionResult<string>> GetGreeting()
    {
        return "greetings";
    }
}

// C#:ss top level käsitteet ovat

// Using
// enum: enumerator
// class
