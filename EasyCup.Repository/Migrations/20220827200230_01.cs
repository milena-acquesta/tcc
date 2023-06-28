using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCup.Repository.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballSchools",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSchools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballSchoolUnitID = table.Column<int>(type: "int", nullable: false),
                    StartRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartChampionship = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelledChampionship = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndChampionship = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartPublicity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstPlaceID = table.Column<int>(type: "int", nullable: true),
                    SecondPlaceID = table.Column<int>(type: "int", nullable: true),
                    ThirdPlaceID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Championships_Teams_FirstPlaceID",
                        column: x => x.FirstPlaceID,
                        principalTable: "Teams",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Championships_Teams_SecondPlaceID",
                        column: x => x.SecondPlaceID,
                        principalTable: "Teams",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Championships_Teams_ThirdPlaceID",
                        column: x => x.ThirdPlaceID,
                        principalTable: "Teams",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ChampionshipsTeamsPlayers",
                columns: table => new
                {
                    ChampionshipID = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionshipsTeamsPlayers", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_ChampionshipsTeamsPlayers_Championships_ChampionshipID",
                        column: x => x.ChampionshipID,
                        principalTable: "Championships",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChampionshipsTeamsPlayers_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChampionshipsTeamsPlayers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamAID = table.Column<int>(type: "int", nullable: false),
                    TeamBID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChampionshipID = table.Column<int>(type: "int", nullable: false),
                    TeamAResult = table.Column<int>(type: "int", nullable: false),
                    TeamBResult = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Matches_Championships_ChampionshipID",
                        column: x => x.ChampionshipID,
                        principalTable: "Championships",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamAID",
                        column: x => x.TeamAID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamBID",
                        column: x => x.TeamBID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CupManagers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballSchoolUnitID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupManagers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FootballSchoolUnits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballSchoolID = table.Column<int>(type: "int", nullable: false),
                    CupManagerID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSchoolUnits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FootballSchoolUnits_CupManagers_CupManagerID",
                        column: x => x.CupManagerID,
                        principalTable: "CupManagers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FootballSchoolUnits_FootballSchools_FootballSchoolID",
                        column: x => x.FootballSchoolID,
                        principalTable: "FootballSchools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FutsalCourts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballSchoolUnitID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutsalCourts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FutsalCourts_FootballSchoolUnits_FootballSchoolUnitID",
                        column: x => x.FootballSchoolUnitID,
                        principalTable: "FootballSchoolUnits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Championships_FirstPlaceID",
                table: "Championships",
                column: "FirstPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_FootballSchoolUnitID",
                table: "Championships",
                column: "FootballSchoolUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_SecondPlaceID",
                table: "Championships",
                column: "SecondPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_ThirdPlaceID",
                table: "Championships",
                column: "ThirdPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionshipsTeamsPlayers_ChampionshipID",
                table: "ChampionshipsTeamsPlayers",
                column: "ChampionshipID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionshipsTeamsPlayers_TeamID",
                table: "ChampionshipsTeamsPlayers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_CupManagers_FootballSchoolUnitID",
                table: "CupManagers",
                column: "FootballSchoolUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSchoolUnits_CupManagerID",
                table: "FootballSchoolUnits",
                column: "CupManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSchoolUnits_FootballSchoolID",
                table: "FootballSchoolUnits",
                column: "FootballSchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_FutsalCourts_FootballSchoolUnitID",
                table: "FutsalCourts",
                column: "FootballSchoolUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ChampionshipID",
                table: "Matches",
                column: "ChampionshipID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamAID",
                table: "Matches",
                column: "TeamAID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamBID",
                table: "Matches",
                column: "TeamBID");

            migrationBuilder.AddForeignKey(
                name: "FK_Championships_FootballSchoolUnits_FootballSchoolUnitID",
                table: "Championships",
                column: "FootballSchoolUnitID",
                principalTable: "FootballSchoolUnits",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CupManagers_FootballSchoolUnits_FootballSchoolUnitID",
                table: "CupManagers",
                column: "FootballSchoolUnitID",
                principalTable: "FootballSchoolUnits",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CupManagers_FootballSchoolUnits_FootballSchoolUnitID",
                table: "CupManagers");

            migrationBuilder.DropTable(
                name: "ChampionshipsTeamsPlayers");

            migrationBuilder.DropTable(
                name: "FutsalCourts");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "FootballSchoolUnits");

            migrationBuilder.DropTable(
                name: "CupManagers");

            migrationBuilder.DropTable(
                name: "FootballSchools");
        }
    }
}
