// [ApiController]
// [Route("api/[controller]")]
public class AuthController : ControllerBase {
  [HttpPost("login")] public IActionResult Login() { /* mock JWT */ }
}