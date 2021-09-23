using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente (Paciente paciente);
        IEnumerable<Paciente> GetAllPacientes();
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Paciente UpdatePaciente(Paciente paciente);
    }
}
