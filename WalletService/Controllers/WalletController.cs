// [ApiController]
// [Route("api/[controller]")]
public class WalletController : ControllerBase {
  [HttpPost("debit")] public IActionResult Debit() { }
  [HttpPost("credit")] public IActionResult Credit() { }
  [HttpPost("rollback")] public IActionResult Rollback() { }
}