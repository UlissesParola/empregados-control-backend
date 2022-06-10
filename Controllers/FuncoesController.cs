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
public class FuncoesController : ControllerBase
{
    private readonly AppDBContext _context;

    public FuncoesController(AppDBContext context)
    {
        _context = context;
    }

    // GET: api/Funcoes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Funcao>>> GetFuncoes()
    {
      if (_context.Funcoes == null)
      {
          return NotFound();
      }
        return await _context.Funcoes.ToListAsync();
    }

    // GET: api/Funcoes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Funcao>> GetFuncao(int id)
    {
      if (_context.Funcoes == null)
      {
          return NotFound();
      }
        var funcao = await _context.Funcoes.FindAsync(id);

        if (funcao == null)
        {
            return NotFound();
        }

        return funcao;
    }
}
