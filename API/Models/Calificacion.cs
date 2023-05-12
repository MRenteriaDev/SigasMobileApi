using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Calificacion
{
    public int Id { get; set; }

    public long ImporteObservado { get; set; }

    public long Devengado { get; set; }

    public int NoObservaciones { get; set; }

    public int NoObservacionesAnteriores { get; set; }

    public int EnteId { get; set; }

    public int EjercicioId { get; set; }

    public double CalificacionFinal { get; set; }

    public double Desempeno { get; set; }

    public double Financiera { get; set; }

    public double Obras { get; set; }

    public double FinancieraDanoP { get; set; }

    public double ServiciosPublicos { get; set; }

    public double ControlInterno { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public long ImporteObservadoDano { get; set; }

    public long ImporteObservadoObraDano { get; set; }

    public long DevengadoObra { get; set; }

    public long ImporteObservadoDeterminado { get; set; }

    public long ImporteObservadoAclarado { get; set; }

    public long ImporteObservadoObraDeterminado { get; set; }

    public long ImporteObservadoObraAclarado { get; set; }

    public long ImporteObservadoObra { get; set; }

    public double FinancieraIndiceCumplimiento { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual ICollection<ImportesAuditoria> ImportesAuditoriaCalificacionId1Navigations { get; set; } = new List<ImportesAuditoria>();

    public virtual ICollection<ImportesAuditoria> ImportesAuditoriaCalificacions { get; set; } = new List<ImportesAuditoria>();
}
