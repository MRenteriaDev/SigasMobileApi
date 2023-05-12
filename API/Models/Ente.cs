using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Ente
{
    public int Id { get; set; }

    public int EntesTipoEnte { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NumeroEnte { get; set; }

    public string? Domicilio { get; set; }

    public string? Telefono { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool Activo { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public byte[]? Logo { get; set; }

    public string? ClaveEnte { get; set; }

    public string? NombreCorto { get; set; }

    public int? ParamunicipalDe { get; set; }

    public string? Pronombre { get; set; }

    public string? Ciudad { get; set; }

    public int? ClaveInegi { get; set; }

    public int? ClaveIne { get; set; }

    public int? Grupo { get; set; }

    public bool MayorA25mil { get; set; }

    public virtual ICollection<ArchivoPermanente> ArchivoPermanentes { get; set; } = new List<ArchivoPermanente>();

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Balanza> Balanzas { get; set; } = new List<Balanza>();

    public virtual ICollection<CalificacionDesempeno> CalificacionDesempenos { get; set; } = new List<CalificacionDesempeno>();

    public virtual ICollection<CalificacionesGlobale> CalificacionesGlobales { get; set; } = new List<CalificacionesGlobale>();

    public virtual ICollection<Calificacion> Calificacions { get; set; } = new List<Calificacion>();

    public virtual ICollection<ConfiguracionInformeResultado> ConfiguracionInformeResultados { get; set; } = new List<ConfiguracionInformeResultado>();

    public virtual ICollection<CopiasOficio> CopiasOficios { get; set; } = new List<CopiasOficio>();

    public virtual ICollection<CriteriosAcreditado> CriteriosAcreditados { get; set; } = new List<CriteriosAcreditado>();

    public virtual ICollection<CriteriosRevisado> CriteriosRevisados { get; set; } = new List<CriteriosRevisado>();

    public virtual ICollection<CumplimientoEtca> CumplimientoEtcas { get; set; } = new List<CumplimientoEtca>();

    public virtual ICollection<DatosIndicadore> DatosIndicadores { get; set; } = new List<DatosIndicadore>();

    public virtual ICollection<Denuncia> Denuncia { get; set; } = new List<Denuncia>();

    public virtual ICollection<Dependencia> Dependencia { get; set; } = new List<Dependencia>();

    public virtual ICollection<DeudaFormato> DeudaFormatos { get; set; } = new List<DeudaFormato>();

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual ICollection<EnteCalificacion> EnteCalificacions { get; set; } = new List<EnteCalificacion>();

    public virtual TipoEnte EntesTipoEnteNavigation { get; set; } = null!;

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<InformacionFinanciera> InformacionFinancieras { get; set; } = new List<InformacionFinanciera>();

    public virtual ICollection<InformacionTrimestralEntregada> InformacionTrimestralEntregada { get; set; } = new List<InformacionTrimestralEntregada>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<Ente> InverseParamunicipalDeNavigation { get; set; } = new List<Ente>();

    public virtual ICollection<Meta> Meta { get; set; } = new List<Meta>();

    public virtual ICollection<NotaEnMedio> NotaEnMedios { get; set; } = new List<NotaEnMedio>();

    public virtual ICollection<ObraPublica> ObraPublicas { get; set; } = new List<ObraPublica>();

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual ICollection<Papele> Papeles { get; set; } = new List<Papele>();

    public virtual Ente? ParamunicipalDeNavigation { get; set; }

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<PronunciamientoObservacione> PronunciamientoObservaciones { get; set; } = new List<PronunciamientoObservacione>();

    public virtual ICollection<ProveedorMonto> ProveedorMontos { get; set; } = new List<ProveedorMonto>();

    public virtual ICollection<RecepcionDocumentacion> RecepcionDocumentacions { get; set; } = new List<RecepcionDocumentacion>();

    public virtual ICollection<ResultadosEncuesta> ResultadosEncuesta { get; set; } = new List<ResultadosEncuesta>();

    public virtual ICollection<Sancion> Sancions { get; set; } = new List<Sancion>();

    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<UsuarioEnte> UsuarioEntes { get; set; } = new List<UsuarioEnte>();

    public virtual ICollection<Visita> Visita { get; set; } = new List<Visita>();
}
