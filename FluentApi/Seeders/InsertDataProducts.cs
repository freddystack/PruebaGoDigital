using FluentApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApi.Seeders
{
    public static class InsertDataProducts
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Nombre = "Martillo",
                    Precio = 23.32,
                    Descripcion = "Esta es la descripcion del martillo",
                    Imagen = "https://images-na.ssl-images-amazon.com/images/I/71tTWyypTKL._AC_SY355_.jpg",
                    Categpria = "Manuales"
                },
                 new Product
                 {
                     Id = 2,
                     Nombre = "Taladro",
                     Precio = 98.32,
                     Descripcion = "Esta es la descripcion del Taladro",
                     Imagen = "https://cajonherramientas.com/wp-content/uploads/2019/09/taladro-inalambrico-articulo.jpg",
                     Categpria = "Electricas"

                 },
                  new Product
                  {
                      Id = 3,
                      Nombre = "Motosierra",
                      Precio = 50.03,
                      Descripcion = "Esta es la descripcion de la Motosierra",
                      Imagen = "https://nogalpark.com/archivos/recortes/motosierra-stihl-ms780-nogalpark-1502817726.jpg",
                      Categpria = "Electricas"
                  },
                   new Product
                   {
                       Id = 4,
                       Nombre = "Juego de Desarmadores",
                       Precio = 9.42,
                       Descripcion = "Esta es la descripcion del juego de desarmadores",
                       Imagen = "https://images-na.ssl-images-amazon.com/images/I/610-syUEk2L._AC_SY355_.jpg",
                       Categpria = "Manuales"
                   },
                     new Product
                     {
                         Id = 5,
                         Nombre = "Puerta de Madera Pino",
                         Precio = 132.42,
                         Descripcion = "Esta es la descripcion de la puerta de madera pino",
                         Imagen = "https://c0.klipartz.com/pngpicture/813/444/gratis-png-ventana-jeld-wen-puerta-muebles-madera-puertas-madera.png",
                         Categpria = "Puertas"
                     },
                      new Product
                      {
                          Id = 6,
                          Nombre = "Puerta de Hierro",
                          Precio = 10.42,
                          Descripcion = "Esta es la descripcion de la puerta de Hierro",
                          Imagen = "https://images-na.ssl-images-amazon.com/images/I/71DqYPPOJEL._AC_SY355_.jpg",
                          Categpria = "Puertas"
                      },
                       new Product
                       {
                           Id = 7,
                           Nombre = "Puerta de Madera cedro",
                           Precio = 100.42,
                           Descripcion = "Esta es la descripcion de la puerta de madera cedro",
                           Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZjLG5l8K9zw_UCf7xaSQs1JRgMlrR-XL6Jw&usqp=CAU",
                           Categpria = "Puertas"
                       },
                        new Product
                        {
                            Id = 8,
                            Nombre = "Amoladora marca bosch",
                            Precio = 80.42,
                            Descripcion = "Esta es la descripcion de la amoladora bosch",
                            Imagen = "https://s3.amazonaws.com/mercado-ideas/wp-content/uploads/sites/2/2018/09/24214558/amoladora-el%C3%A9ctrica.png",
                            Categpria = "Electricas"
                        },
                          new Product
                          {
                              Id = 9,
                              Nombre = "Cortadora marca dewalt",
                              Precio = 122.42,
                              Descripcion = "Esta es la descripcion de la cortadora dewalt",
                              Imagen = "https://cms.grupoferrepat.net/assets/img/productos/D28730-B3.jpg",
                              Categpria = "Electricas"
                          },
                           new Product
                           {
                               Id = 10,
                               Nombre = "Mazo de acero",
                               Precio = 12.42,
                               Descripcion = "Esta es la descripcion del mazo de acero",
                               Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKKXtR0CvezGN0hVvYFxbLuXhIRV-MmJPFsA&usqp=CAU",
                               Categpria = "Manuales"
                           },
                            new Product
                            {
                                Id = 11,
                                Nombre = "Mazo de madera",
                                Precio = 5.42,
                                Descripcion = "Esta es la descripcion del mazo de madera",
                                Imagen = "https://thumbs.dreamstime.com/b/peque%C3%B1o-mazo-de-madera-26098974.jpg",
                                Categpria = "Manuales"
                            },
                             new Product
                             {
                                 Id = 12,
                                 Nombre = "Tijera de acero inoxidable",
                                 Precio = 6.42,
                                 Descripcion = "Esta es la descripcion de la tijera de acero inoxidable",
                                 Imagen = "https://images-na.ssl-images-amazon.com/images/I/318J5mHXGTL._AC_.jpg",
                                 Categpria = "Manuales"
                             }

             );

        }
    }
}
