using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MonitorController : ControllerBase
{
    private List<Monitor> _monitores;

     public MonitorController()
    {
        _monitores = new List<Monitor>
        {
            DadosMockados.grabalos,
            DadosMockados.beatriz,
            DadosMockados.marcos,
            DadosMockados.anna,
            DadosMockados.ricardo
        };
    }

    // GET: api/Monitor
    [HttpGet]
    public async Task<IActionResult> GetAllMonitors()
    {
        return Ok(_monitores);
    }

    // GET: api/Monitor/{nome}
    [HttpGet("{nome}")]
    public IActionResult GetMonitorByName(string nome)
    {
        var monitor = _monitores.FirstOrDefault(m => m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (monitor == null)
        {
            return NotFound(new { Message = $"Monitor com nome '{nome}' não encontrado." });
        }

        return Ok(monitor);
    }

    // POST: api/Monitor
    [HttpPost]
    public IActionResult CreateMonitor([FromBody] Monitor novoMonitor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Adiciona o monitor à lista
        _monitores.Add(novoMonitor);

        return CreatedAtAction(nameof(GetMonitorByName), new { nome = novoMonitor.Nome }, novoMonitor);
    }


    // DELETE: api/Monitor/{nome}
    [HttpDelete("{nome}")]
    public IActionResult DeleteMonitor(string nome)
    {
        var monitor = _monitores.FirstOrDefault(m => m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (monitor == null)
        {
            return NotFound(new { Message = $"Monitor com nome '{nome}' não encontrado." });
        }

        // Remove o monitor
        _monitores.Remove(monitor);

        return Ok(new { Message = $"Monitor com nome '{nome}' removido com sucesso." });
    }
}
