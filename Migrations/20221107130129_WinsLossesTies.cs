using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pingpong.Migrations
{
    public partial class WinsLossesTies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScoreLosses",
                table: "Player",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreTies",
                table: "Player",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreWins",
                table: "Player",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScoreLosses",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "ScoreTies",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "ScoreWins",
                table: "Player");
        }
    }
}
