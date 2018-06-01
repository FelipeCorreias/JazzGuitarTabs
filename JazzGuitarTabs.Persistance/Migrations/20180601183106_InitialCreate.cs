using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JazzGuitarTabs.Persistance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(maxLength: 255, nullable: true),
                    Artist = table.Column<string>(maxLength: 255, nullable: true),
                    Style = table.Column<string>(maxLength: 255, nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    File = table.Column<byte[]>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabs");
        }
    }
}
