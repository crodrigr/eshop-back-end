using Microsoft.EntityFrameworkCore.Migrations;

namespace catalog.api.Migrations
{
    public partial class cargadatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, "Apple MacBook Pro is a macOS laptop with a 13.30-inch display that has a resolution of 2560x1600 pixels", "MacBook", 2000.0, 10, 2300.0 },
                    { 2, "Active noise cancellation for immersive sound. Transparency mode for hearing and connecting with the world around you", "Apple - AirPods Pro - White", 150.0, 10, 190.0 },
                    { 3, "Bring a theater experience to your home with this Sony BRAVIA 77-inch OLED 4K HDR TV.", "Smart Android TV Sony - 77 TV Class A9G OLED 4K UHD ", 3500.0, 10, 3900.0 },
                    { 4, "The iPhone 12 features a 6.1-inch (15.3-cm) display with Super Retina XDR OLED technology at a resolution of 2532×1170 pixels and a pixel density of about 460 ppi", "iPhone 12", 900.0, 10, 1200.0 }
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
        }
    }
}
