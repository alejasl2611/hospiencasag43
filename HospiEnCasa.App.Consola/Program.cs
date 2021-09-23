using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //IndexPacientes();
            //DeletePaciente();
            //IndexPacientes();
            //AddMedico();
            AsignarMedico();

        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Juan",
                Apellidos = "Suárez",
                NumeroTelefono = "123456789",
                Genero = Genero.Masculino,
                Direccion = "Av Flavio Reyes",
                Longitud = 6.07062F,
                Latitud = -86.52290F,
                Ciudad = "Manta",
                FechaNacimiento = new DateTime(1987, 08, 15)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void IndexPacientes()
        {
            foreach (var paciente in _repoPaciente.GetAllPacientes())
            {
                Console.WriteLine(paciente.Nombre + " " +paciente.Apellidos);
            }
        }
        private static void DeletePaciente()
        {
            _repoPaciente.DeletePaciente(3);
        }
        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Alejandra",
                Apellidos = "Sanmiguel",
                NumeroTelefono = "123456789",
                Genero = Genero.Femenino,
                Especialidad = "Neonatóloga",
                Codigo = "123456",
                RegistroRethus = "ABC123"
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            //Se ve en Azure(BASE DE DATOS) la posicion del paciente q es 1 y 4 medico
            var medico = _repoPaciente.AsignarMedico(1,4);
            Console.WriteLine(medico.Nombre +" "+ medico.Apellidos);
        }
    }
}
