using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleEmpregadosApi.Data;
using ControleEmpregadosApi.Models;

namespace ControleEmpregadosApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EscolaridadesController : ControllerBase
{
    private readonly AppDBContext _context;

    public EscolaridadesController(AppDBContext context)
    {
        _context = context;
    }

    // GET: api/Escolaridades
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Escolaridade>>> GetEscolaridades()
    {
      if (_context.Escolaridades == null)
      {
          return NotFound();
      }
        return await _context.Escolaridades.ToListAsync();
    }

    // GET: api/Escolaridades/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Escolaridade>> GetEscolaridade(int id)
    {
      if (_context.Escolaridades == null)
      {
          return NotFound();
      }
        var escolaridade = await _context.Escolaridades.FindAsync(id);

        if (escolaridade == null)
        {
            return NotFound();
        }

        return escolaridade;
    }
}
