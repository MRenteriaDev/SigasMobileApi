using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Planeacion
{
    public int Id { get; set; }

    public int? AuditoriaId { get; set; }

    public int TipoAuditoriaId { get; set; }

    public int EnteId { get; set; }

    public int EjercicioId { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public string? Notas { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int ModoEjecucionId { get; set; }

    public string? Objetivo { get; set; }

    public string? Color { get; set; }

    public int? FondoFederalId { get; set; }

    public int? ProgramaPresupuestarioId { get; set; }

    public bool TiempoReal { get; set; }

    public int? ProgramaAnualId { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual FondosFederale? FondoFederal { get; set; }

    public virtual ModoEjecucion ModoEjecucion { get; set; } = null!;

    public virtual ICollection<PlaneacionTipoAuditoria> PlaneacionTipoAuditoria { get; set; } = new List<PlaneacionTipoAuditoria>();

    public virtual ProgramaAnual? ProgramaAnual { get; set; }

    public virtual ProgramaPresupuestario? ProgramaPresupuestario { get; set; }

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;
}
