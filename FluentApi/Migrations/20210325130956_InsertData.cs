using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApi.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Categpria", "Descripcion", "Imagen", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Manuales", "Esta es la descripcion del martillo", "https://images-na.ssl-images-amazon.com/images/I/71tTWyypTKL._AC_SY355_.jpg", "Martillo", 23.32 },
                    { 2, "Electricas", "Esta es la descripcion del Taladro", "https://cajonherramientas.com/wp-content/uploads/2019/09/taladro-inalambrico-articulo.jpg", "Taladro", 98.32 },
                    { 3, "Electricas", "Esta es la descripcion de la Motosierra", "https://nogalpark.com/archivos/recortes/motosierra-stihl-ms780-nogalpark-1502817726.jpg", "Motosierra", 50.03 },
                    { 4, "Manuales", "Esta es la descripcion del juego de desarmadores", "https://images-na.ssl-images-amazon.com/images/I/610-syUEk2L._AC_SY355_.jpg", "Juego de Desarmadores", 9.42 },
                    { 5, "Puertas", "Esta es la descripcion de la puerta de madera pino", "https://c0.klipartz.com/pngpicture/813/444/gratis-png-ventana-jeld-wen-puerta-muebles-madera-puertas-madera.png", "Puerta de Madera Pino", 132.42 },
                    { 6, "Puertas", "Esta es la descripcion de la puerta de Hierro", "https://images-na.ssl-images-amazon.com/images/I/71DqYPPOJEL._AC_SY355_.jpg", "Puerta de Hierro", 10.42 },
                    { 7, "Puertas", "Esta es la descripcion de la puerta de madera cedro", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZjLG5l8K9zw_UCf7xaSQs1JRgMlrR-XL6Jw&usqp=CAU", "Puerta de Madera cedro", 100.42 },
                    { 8, "Electricas", "Esta es la descripcion de la amoladora bosch", "https://s3.amazonaws.com/mercado-ideas/wp-content/uploads/sites/2/2018/09/24214558/amoladora-el%C3%A9ctrica.png", "Amoladora marca bosch", 80.42 },
                    { 9, "Electricas", "Esta es la descripcion de la cortadora dewalt", "https://cms.grupoferrepat.net/assets/img/productos/D28730-B3.jpg", "Cortadora marca dewalt", 122.42 },
                    { 10, "Manuales", "Esta es la descripcion del mazo de acero", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKKXtR0CvezGN0hVvYFxbLuXhIRV-MmJPFsA&usqp=CAU", "Mazo de acero", 12.42 },
                    { 11, "Manuales", "Esta es la descripcion del mazo de madera", "https://thumbs.dreamstime.com/b/peque%C3%B1o-mazo-de-madera-26098974.jpg", "Mazo de madera", 5.42 },
                    { 12, "Manuales", "Esta es la descripcion de la tijera de acero inoxidable", "https://images-na.ssl-images-amazon.com/images/I/318J5mHXGTL._AC_.jpg", "Tijera de acero inoxidable", 6.42 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
