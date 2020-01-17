using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MAKES (Name) VALUES ('Make1') ");
            migrationBuilder.Sql("INSERT INTO MAKES (Name) VALUES ('Make2') ");
            migrationBuilder.Sql("INSERT INTO MAKES (Name) VALUES ('Make3') ");

            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make1-ModelA', (SELECT Id FROM MAKES WHERE Name = 'Make1') ) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make1-ModelB', (SELECT Id FROM MAKES WHERE Name = 'Make1')) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make1-ModelC', (SELECT Id FROM MAKES WHERE Name = 'Make1')) ");

            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make2-ModelA', (SELECT Id FROM MAKES WHERE Name = 'Make2')) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make2-ModelB', (SELECT Id FROM MAKES WHERE Name = 'Make2')) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make2-ModelC', (SELECT Id FROM MAKES WHERE Name = 'Make2')) ");

            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make3-ModelA', (SELECT Id FROM MAKES WHERE Name = 'Make3')) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make3-ModelB', (SELECT Id FROM MAKES WHERE Name = 'Make3')) ");
            migrationBuilder.Sql("INSERT INTO MODELS (Name, MakeId) VALUES ('Make3-ModelC', (SELECT Id FROM MAKES WHERE Name = 'Make3')) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MAKES WHERE Name IN ('Make1','Make2','Make3') ");
            migrationBuilder.Sql("DELETE FROM MODELS");
        }
    }
}
