using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Periodo
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int PeriodoPadre { get; set; }

    public int? Inicio { get; set; }

    public int? Fin { get; set; }

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Balanza> Balanzas { get; set; } = new List<Balanza>();

    public virtual ICollection<CumplimientoEtca> CumplimientoEtcas { get; set; } = new List<CumplimientoEtca>();

    public virtual ICollection<DeudaFormato> DeudaFormatos { get; set; } = new List<DeudaFormato>();

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<InformacionFinanciera> InformacionFinancieras { get; set; } = new List<InformacionFinanciera>();

    public virtual ICollection<InformacionTrimestralEntregada> InformacionTrimestralEntregada { get; set; } = new List<InformacionTrimestralEntregada>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<Meta> Meta { get; set; } = new List<Meta>();

    public virtual ICollection<ObraPublica> ObraPublicas { get; set; } = new List<ObraPublica>();

    public virtual ICollection<ProveedorMonto> ProveedorMontos { get; set; } = new List<ProveedorMonto>();

    public virtual ICollection<RecepcionDocumentacion> RecepcionDocumentacions { get; set; } = new List<RecepcionDocumentacion>();

    public virtual ICollection<Revisione> Revisiones { get; set; } = new List<Revisione>();
}
