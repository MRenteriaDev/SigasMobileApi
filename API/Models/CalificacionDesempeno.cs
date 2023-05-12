using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CalificacionDesempeno
{
    public int Id { get; set; }

    public int EntesId { get; set; }

    public double? Eficacia { get; set; }

    public double? Eficiencia { get; set; }

    public double? Economia { get; set; }

    public double? ServiciosPublicos { get; set; }

    public double? Calificacion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? NumeroEncuestas { get; set; }

    public int? NivelConfianza { get; set; }

    public int EjercicioId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Entes { get; set; } = null!;
}
