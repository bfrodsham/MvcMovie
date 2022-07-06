using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

// I was getting a "login failed" error when I tried using this code from my work laptop,
// so I had to do this new migration and update the database. It worked.
// Interestingly, the Up and Down functions are blank, probably meaning that nothing changed
// from the last migration.

namespace MvcMovie.Migrations
{
    public partial class WorkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
