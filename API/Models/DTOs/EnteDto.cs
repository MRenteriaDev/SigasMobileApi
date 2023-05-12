using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.DTOs
{
    public class EnteDto
    {
        public int Id { get; set; }
        public int Entes_TipoEnte { get; set; }
        public string TipoEnteName { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string NumeroEnte { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreCortoCompleto { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool Activo { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }
        public string Logo { get; set; }
        public string Pronombre { get; set; }
        public string ClaveEnte { get; set; }
        public int ParamunicipalDe { get; set; }
        public string ArticuloContractoA { get; set; }
        public int ArchivosCount { get; set; }
        public bool MayorA25mil { get; set; }
        public int ClaveINEGI { get; set; }
        public int ClaveINE { get; set; }
        public int Grupo { get; set; }
        public string Ambito { get; set; }
    }
}