using System;
using System.Collections.Generic;

namespace API.Models;

public partial class InformacionTrimestralEntregada
{
    public int Id { get; set; }

    public int EntesId { get; set; }

    public int EjerciciosId { get; set; }

    public int PeriodosId { get; set; }

    public string? ComentariosApartadoI { get; set; }

    public string? ComentariosApartadoIi { get; set; }

    public string? Entrego { get; set; }

    public string? PuestoEntrego { get; set; }

    public string? UserRecibio { get; set; }

    public DateTime FechaEntrega { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool EnTiempo { get; set; }

    public virtual Ejercicio Ejercicios { get; set; } = null!;

    public virtual Ente Entes { get; set; } = null!;

    public virtual ICollection<InformacionFinanciera> InformacionFinancieras { get; set; } = new List<InformacionFinanciera>();

    public virtual Periodo Periodos { get; set; } = null!;
}
