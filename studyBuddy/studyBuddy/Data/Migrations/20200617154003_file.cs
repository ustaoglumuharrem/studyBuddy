using Microsoft.EntityFrameworkCore.Migrations;

namespace studyBuddy.Data.Migrations
{
    public partial class file : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PdfLinks");

            migrationBuilder.AddColumn<string>(
                name: "ResimYolu",
                table: "Pdfs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimYolu",
                table: "Pdfs");

            migrationBuilder.CreateTable(
                name: "PdfLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PdfLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PdfLinks_Pdfs_PdfId",
                        column: x => x.PdfId,
                        principalTable: "Pdfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PdfLinks_PdfId",
                table: "PdfLinks",
                column: "PdfId");
        }
    }
}
