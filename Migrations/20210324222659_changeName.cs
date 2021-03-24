using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreExample.Migrations
{
    public partial class changeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

                migrationBuilder.RenameTable(
                    name: "BookS",
                    newName: "Books");
        }
          

    protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
               name: "Books",
               newName: "BookS");
        }
    }
}
