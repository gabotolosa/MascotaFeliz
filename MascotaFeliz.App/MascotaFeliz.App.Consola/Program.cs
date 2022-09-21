using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());        
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());   
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("se corrio correctamente el proyecto!");
            AddDueno();
            //AddVeterinario();
            //AddMascota();
            //AddHistoria();
            //AddVisitaPyP();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Katherine",
                Apellidos = "Vega",
                Direccion = "calle 2a #10b 92",
                Telefono = "1234567891",
                Correo = "Kathevega@gmail.com"
                };
                _repoDueno.AddDueno(dueno);
        }
       
  
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Alexander",
                Apellidos = "Torres",
                Direccion = "Duitama",
                Telefono = "31057555335",
                TarjetaProfesional = "ac45689"
                };
                _repoVeterinario.AddVeterinario(veterinario);            
        } 

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Horus",
                Color = "cafe",
                Especie = "canino",
                Raza = "Golden",
                };
                _repoMascota.AddMascota(mascota);     
        }

         private static void AddHistoria()
        {
            var historia = new Historia
            {
                
                FechaInicial = new DateTime(2022, 09, 18)
                
            };
            _repoHistoria.AddHistoria(historia);     
        }
    
        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP
            {
                FechaVisita = new DateTime (2022,09,16),
                Temperatura = 35,
                Peso = 10,
                FrecuenciaRespiratoria = 28,
                FrecuenciaCardiaca = 98,
                EstadoAnimo = "Normal",
                IdVeterinario = 123456,
                Recomendaciones = "darle amor, comprension ternura"
            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }
    }
}