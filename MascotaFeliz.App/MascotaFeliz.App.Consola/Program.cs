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
        //private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
       // private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello amigos vamos a empezar a definir las tablas");
            AddDueno();
              //AddVeterinario();
           // AddMascota();
           //AddHistoria();  
           //AddVisitaPyP();
           //BuscarMascota(1);
           //BuscarMascota();
           // BuscarDueno(1);
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                
                Nombres = "Maria Paula",
                Apellidos = "Engativa",
                Direccion = "Sogamoso",
                Telefono = "1234567891",
                Correo = "paula@gmail.com"
            };
            _repoDueno.AddDueno(dueno);

        }
         private static void AddVeterinario()
        {
            var veterinario= new Veterinario
            {
        
            Nombres = "Nestor",
            Apellidos = "Ortiz",
            Direccion = "Carrera 25",
            Telefono = "456222",
            TarjetaProfesional = "8888888"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        /*
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Fulgencio",
                Color = "Gris",
                Especie = "Perro",
                Raza = "criollo"
            };
            _repoMascota.AddMascota(mascota);
}*/
/*
        private static void AddHistoria()
        {
            var Historia = new Historia
            {
                FechaInicial = new DateTime(1970, 1, 1)
            };
            _repoHistoria.AddHistoria(historia);
        }

       

*/
        
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + "" + dueno.Apellidos + "" + dueno.Direccion + "" + dueno.Telefono);
        }
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario (idVeterinario);
        Console.WriteLine(veterinario.Nombres + "" + veterinario.Apellidos);

        }
    }
}

        
    
