using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RecepcionDocumentacion
{
    public int Id { get; set; }

    public int FuncionarioId { get; set; }

    public int? PeriodosId { get; set; }

    public int EjerciciosId { get; set; }

    public int EntesId { get; set; }

    public string? Comentarios { get; set; }

    public DateTime FechaRecepcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int AuditorId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual Ejercicio Ejercicios { get; set; } = null!;

    public virtual Ente Entes { get; set; } = null!;

    public virtual Funcionario Funcionario { get; set; } = null!;

    public virtual ICollection<OficiosRecepcionDocumentacion> OficiosRecepcionDocumentacions { get; set; } = new List<OficiosRecepcionDocumentacion>();

    public virtual Periodo? Periodos { get; set; }
}
