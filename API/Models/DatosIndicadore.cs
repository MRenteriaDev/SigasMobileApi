using System;
using System.Collections.Generic;

namespace API.Models;

public partial class DatosIndicadore
{
    public int Id { get; set; }

    public int? ObservacionesRecurrentes { get; set; }

    public int? ObservacionesRecurrentesSolventadas { get; set; }

    public int? MetasFiscalizadas { get; set; }

    public int? MetasAcreditadas { get; set; }

    public int? EjerciciosId { get; set; }

    public int EntesId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double? PredialRecaudado { get; set; }

    public double? PredialFacturado { get; set; }

    public double? RezagoPredial { get; set; }

    public double? Fortamunpresupuestado { get; set; }

    public double? Fismunpresupuestado { get; set; }

    public double? TotalFism { get; set; }

    public double? TotalFortamun { get; set; }

    public double? MontoIafism { get; set; }

    public double? MontoIafortamun { get; set; }

    public virtual Ejercicio? Ejercicios { get; set; }

    public virtual Ente Entes { get; set; } = null!;
}
