using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Observacione
{
    public int Id { get; set; }

    public int Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int EntesObservaciones { get; set; }

    public string? Tipo { get; set; }

    public string? Normatividad { get; set; }

    public string? Solventacion { get; set; }

    public string? Origen { get; set; }

    public DateTime FechaNotificacion { get; set; }

    public DateTime FechaTermino { get; set; }

    public string? Clasificacion { get; set; }

    public string? NotaGeneral { get; set; }

    public string? Tabla { get; set; }

    public bool IsVisibleNotaGeneral { get; set; }

    public string? Importancia { get; set; }

    public int? IdEjercicio { get; set; }

    public int? DespachoId { get; set; }

    public int TipoObservacionId { get; set; }

    public int? HallazgoId { get; set; }

    public int? ObservacionPadre { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public string? TablaHtml { get; set; }

    public long? Importe { get; set; }

    public DateTime? FechaNotificacionHallazgo { get; set; }

    public DateTime? FechaTerminoHallazgo { get; set; }

    public DateTime? FechaConversion { get; set; }

    public int StatusId { get; set; }

    public bool PosibleDañoPatrimonial { get; set; }

    public string? OrdenadoPor { get; set; }

    public bool Deleted { get; set; }

    public int? IdAnterior { get; set; }

    public int? ProrrogaId { get; set; }

    public string? DescripcionAlternativa { get; set; }

    public int? Vencimiento { get; set; }

    public int? ExpedienteId { get; set; }

    public int? ExpedienteId1 { get; set; }

    public int NumeroInforme { get; set; }

    public bool EnInformeCiudadano { get; set; }

    public virtual ICollection<CriteriosAcreditado> CriteriosAcreditados { get; set; } = new List<CriteriosAcreditado>();

    public virtual ICollection<Denuncia> Denuncia { get; set; } = new List<Denuncia>();

    public virtual DespachosExterno? Despacho { get; set; }

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual Ente EntesObservacionesNavigation { get; set; } = null!;

    public virtual Expediente? Expediente { get; set; }

    public virtual Expediente? ExpedienteId1Navigation { get; set; }

    public virtual ICollection<ExpedienteObservacion> ExpedienteObservacions { get; set; } = new List<ExpedienteObservacion>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual Hallazgo? Hallazgo { get; set; }

    public virtual Ejercicio? IdEjercicioNavigation { get; set; }

    public virtual ICollection<ImporteObservacione> ImporteObservaciones { get; set; } = new List<ImporteObservacione>();

    public virtual ICollection<Observacione> InverseObservacionPadreNavigation { get; set; } = new List<Observacione>();

    public virtual Observacione? ObservacionPadreNavigation { get; set; }

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<Plazo> Plazos { get; set; } = new List<Plazo>();

    public virtual Prorroga? Prorroga { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual ICollection<StatusObservacion> StatusObservacions { get; set; } = new List<StatusObservacion>();

    public virtual TipoObservacion TipoObservacion { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;
}
