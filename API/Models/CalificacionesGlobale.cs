using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CalificacionesGlobale
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public double Financiera { get; set; }

    public double ObrasPublicas { get; set; }

    public double Desempeno { get; set; }

    public double InformesTrimesYcuenPublic { get; set; }

    public double Presupuestal { get; set; }

    public double DeudaPublica { get; set; }

    public double Legal { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double PonderacionFinanciera { get; set; }

    public double PonderacionObra { get; set; }

    public double PonderacionDesempeno { get; set; }

    public double PonderacionCuentaPublica { get; set; }

    public double PonderacionPresupuestal { get; set; }

    public double PonderacionDeuda { get; set; }

    public double PonderacionLegal { get; set; }

    public double Calificacion { get; set; }

    public double SistemaContable { get; set; }

    public double PonderacionSistemaContable { get; set; }

    public virtual ICollection<CalificacionClase> CalificacionClases { get; set; } = new List<CalificacionClase>();

    public virtual Ente Ente { get; set; } = null!;
}
