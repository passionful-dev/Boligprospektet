using Microsoft.EntityFrameworkCore.Migrations;

namespace Boligprospektet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolig_activitets",
                columns: table => new
                {
                    Bolig_activitet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Bolig_Id = table.Column<int>(nullable: false),
                    Bolig_Navn = table.Column<string>(nullable: true),
                    Bolig_activitet_Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolig_activitets", x => x.Bolig_activitet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolig_type_activitets",
                columns: table => new
                {
                    Bolig_type_activitet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Bolig_type_Id = table.Column<int>(nullable: false),
                    Bolig_type_Navn = table.Column<string>(nullable: true),
                    Bolig_type_activitet_Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolig_type_activitets", x => x.Bolig_type_activitet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolig_types",
                columns: table => new
                {
                    Bolig_type_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Bolig_type_Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolig_types", x => x.Bolig_type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Boligs",
                columns: table => new
                {
                    Bolig_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Type_Id = table.Column<int>(nullable: false),
                    Adresse_Vej = table.Column<string>(nullable: true),
                    Adresse_Postnr = table.Column<string>(nullable: true),
                    Adresse_Code = table.Column<int>(nullable: false),
                    Adresse_By = table.Column<string>(nullable: true),
                    Leje_kr = table.Column<int>(nullable: false),
                    Deposit_kr = table.Column<int>(nullable: false),
                    Areal_msquare = table.Column<int>(nullable: false),
                    Antal_Værelser = table.Column<int>(nullable: false),
                    Bolig_Beskrivelser = table.Column<string>(nullable: true),
                    Bolig_Navn = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true),
                    Ledig_Fra = table.Column<string>(nullable: true),
                    Annonse_Til = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boligs", x => x.Bolig_Id);
                });

            migrationBuilder.CreateTable(
                name: "Facilitets",
                columns: table => new
                {
                    Facilitet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bolig_Id = table.Column<int>(nullable: false),
                    Faciliteter = table.Column<string>(nullable: true),
                    Facilitet_Beskrivelser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilitets", x => x.Facilitet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Indhold_activitets",
                columns: table => new
                {
                    Indhold_activitet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Indhold_Id = table.Column<int>(nullable: false),
                    Indhold_Navn = table.Column<string>(nullable: true),
                    Indhold_activitet_Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indhold_activitets", x => x.Indhold_activitet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Indholds",
                columns: table => new
                {
                    Indhold_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Indhold_Navn = table.Column<string>(nullable: true),
                    Indhold_Beskrivelser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indholds", x => x.Indhold_Id);
                });

            migrationBuilder.CreateTable(
                name: "User_activitets",
                columns: table => new
                {
                    User_activitet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Fuldnavn = table.Column<string>(nullable: true),
                    User_activitet_Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_activitets", x => x.User_activitet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<string>(nullable: true),
                    Fuldnavn = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Mobile = table.Column<int>(nullable: false),
                    User_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolig_activitets");

            migrationBuilder.DropTable(
                name: "Bolig_type_activitets");

            migrationBuilder.DropTable(
                name: "Bolig_types");

            migrationBuilder.DropTable(
                name: "Boligs");

            migrationBuilder.DropTable(
                name: "Facilitets");

            migrationBuilder.DropTable(
                name: "Indhold_activitets");

            migrationBuilder.DropTable(
                name: "Indholds");

            migrationBuilder.DropTable(
                name: "User_activitets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
