﻿using CinemaProjectASP.Data;
using CinemaProjectASP.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaProject.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //sala
                if (!context.Salas.Any())
                {
                    context.Salas.AddRange(new List<Sala>()
                    {
                    new Sala()
                    {
                        Nazwa = "Sala 1",
                        Opis = "Opis Opis"
                    },
                    new Sala()
                    {
                        Nazwa = "Sala 2",
                        Opis = "Opis Opis"
                    },
                    new Sala()
                    {
                        Nazwa = "Sala 3",
                        Opis = "Opis Opis"
                    },
                    new Sala()
                    {
                        Nazwa = "Sala 4",
                        Opis = "Opis Opis"
                    },
                    new Sala()
                    {
                        Nazwa = "Sala 5",
                        Opis = "Opis Opis"
                    },
                    });
                    context.SaveChanges();
                }

                //aktorzy
                if (!context.Aktors.Any())
                {
                    context.Aktors.AddRange(new List<Aktor>()
                    {
                    new Aktor()
                    {
                        ImieNazwisko = "Aktor 1",
                        RokUrodzenia = 2001,
                        Biografia = "Aktor Aktor",
                    },
                    new Aktor()
                    {
                        ImieNazwisko = "Aktor 2",
                        RokUrodzenia = 2001,
                        Biografia = "Aktor Aktor",
                    },
                    new Aktor()
                    {
                        ImieNazwisko = "Aktor 3",
                        RokUrodzenia = 2001,
                        Biografia = "Aktor Aktor",
                    },
                    new Aktor()
                    {
                        ImieNazwisko = "Aktor 4",
                        RokUrodzenia = 2001,
                        Biografia = "Aktor Aktor",
                    },
                    new Aktor()
                    {
                        ImieNazwisko = "Aktor 5",
                        RokUrodzenia = 2001,
                        Biografia = "Aktor Aktor",
                    },
                    });
                    context.SaveChanges();
                }

                //rezyserowie
                if (!context.Rezysers.Any())
                {
                    context.Rezysers.AddRange(new List<Rezyser>()
                    {
                    new Rezyser()
                    {
                        ImieNazwisko = "Rezyser 1",
                        RokUrodzenia = 2001,
                        Biografia = "Rezyser Rezyser",
                    },
                    new Rezyser()
                    {
                        ImieNazwisko = "Rezyser 2",
                        RokUrodzenia = 2001,
                        Biografia = "Rezyser Rezyser",
                    },
                    new Rezyser()
                    {
                        ImieNazwisko = "Rezyser 3",
                        RokUrodzenia = 2001,
                        Biografia = "Rezyser Rezyser",
                    },
                    new Rezyser()
                    {
                        ImieNazwisko = "Rezyser 4",
                        RokUrodzenia = 2001,
                        Biografia = "Rezyser Rezyser",
                    },
                    new Rezyser()
                    {
                        ImieNazwisko = "Rezyser 5",
                        RokUrodzenia = 2001,
                        Biografia = "Rezyser Rezyser",
                    },
                    });
                    context.SaveChanges();
                }

                //filmy
                if (!context.Films.Any())
                {
                    context.Films.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 3,
                            RezyserId = 3,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 1,
                            RezyserId = 1,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 4,
                            RezyserId = 4,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 1,
                            RezyserId = 2,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 1,
                            RezyserId = 3,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                        new Film()
                        {
                            Nazwa = "Life",
                            Opis = "This is the Life movie description",
                            Cena = 39.50,
                            OdKiedy  = DateTime.Now.AddDays(-10),
                            DoKiedy = DateTime.Now.AddDays(10),
                            SalaId = 1,
                            RezyserId = 5,
                            FilmKategoria = FilmKategoria.Akcja
                        },
                    });
                    context.SaveChanges();
                }

                //aktorzy & filmy
                if (!context.Aktors_Films.Any())
                {
                    context.Aktors_Films.AddRange(new List<Aktor_Film>()
                   {
                        new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 1
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 1
                        },

                        new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 2
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 2
                        },

                        new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 3
                        },
                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 3
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 3
                        },


                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 4
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 4
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 4
                        },


                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 5
                        },


                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 6
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 6
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 6
                        },
                        });
                    context.SaveChanges();
                }
            }
        }
    }
}