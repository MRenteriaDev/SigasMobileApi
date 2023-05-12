using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Ejercicio
{
    public int Id { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int Año { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int ConsecutivoAuditoria { get; set; }

    public int ConsecutivoObservaciones { get; set; }

    public int ConsecutivoExpediente { get; set; }

    public bool Actual { get; set; }

    public string? Lema { get; set; }

    public int ConsecutivoSustanciacion { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Balanza> Balanzas { get; set; } = new List<Balanza>();

    public virtual ICollection<CalificacionDesempeno> CalificacionDesempenos { get; set; } = new List<CalificacionDesempeno>();

    public virtual ICollection<Calificacion> Calificacions { get; set; } = new List<Calificacion>();

    public virtual ICollection<ConfiguracionInformeResultado> ConfiguracionInformeResultados { get; set; } = new List<ConfiguracionInformeResultado>();

    public virtual ICollection<CumplimientoEtca> CumplimientoEtcas { get; set; } = new List<CumplimientoEtca>();

    public virtual ICollection<DatosIndicadore> DatosIndicadores { get; set; } = new List<DatosIndicadore>();

    public virtual ICollection<Denuncia> Denuncia { get; set; } = new List<Denuncia>();

    public virtual ICollection<DeudaFormato> DeudaFormatos { get; set; } = new List<DeudaFormato>();

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual ICollection<EnteCalificacion> EnteCalificacions { get; set; } = new List<EnteCalificacion>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual ICollection<FondosFederalesRecibido> FondosFederalesRecibidos { get; set; } = new List<FondosFederalesRecibido>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<InformacionFinanciera> InformacionFinancieras { get; set; } = new List<InformacionFinanciera>();

    public virtual ICollection<InformacionTrimestralEntregada> InformacionTrimestralEntregada { get; set; } = new List<InformacionTrimestralEntregada>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<Meta> Meta { get; set; } = new List<Meta>();

    public virtual ICollection<ObraPublica> ObraPublicas { get; set; } = new List<ObraPublica>();

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual ICollection<Papele> Papeles { get; set; } = new List<Papele>();

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<ProveedorMonto> ProveedorMontos { get; set; } = new List<ProveedorMonto>();

    public virtual ICollection<RecepcionDocumentacion> RecepcionDocumentacions { get; set; } = new List<RecepcionDocumentacion>();

    public virtual ICollection<ResultadosEncuesta> ResultadosEncuesta { get; set; } = new List<ResultadosEncuesta>();
}
