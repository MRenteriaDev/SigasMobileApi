using API.Data;
using API.Models;
using API.Models.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EntesApiController : BaseApiController
    {
        private readonly ObservacionesWebDbContext _observacionesWebDbContext;
        private readonly IMapper _imapper;
        public EntesApiController(ObservacionesWebDbContext observacionesWebDbContext, IMapper imapper)
        {
            _observacionesWebDbContext = observacionesWebDbContext;
            _imapper = imapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ente>>> GetEntesAsync()
        {
            var entes = await _observacionesWebDbContext.Entes.ToListAsync();

            var entesToReturn = _imapper.Map<IEnumerable<EnteDto>>(entes);

            return Ok(entes);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Ente>> GetEnteAsync(int id)
        {
            var ente = await _observacionesWebDbContext.Entes.FindAsync(id);

            var enteToReturn = _imapper.Map<EnteDto>(ente);

            return Ok(ente);
        }
    }
}