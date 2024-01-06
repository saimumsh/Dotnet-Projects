using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blogie.data.Migrations
{
    /// <inheritdoc />
    public partial class addDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogDatas",
                columns: new[] { "Id", "Details", "Name", "Summary", "Thumnail", "Title" },
                values: new object[,]
                {
                    { 1, "Details1", "Shahadat", "Summary1", "~/image/avenue-815297_640.jpg", "Title1" },
                    { 2, "Details2", "Emran", "Summary2", "~/image/download(1).jpg", "Title2" },
                    { 3, "Details3", "Mahfuz", "Summary3", "~/image/download.jpg", "Title3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogDatas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogDatas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogDatas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
