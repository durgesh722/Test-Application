using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QBS_CORE_WEBAPI.Migrations
{
    public partial class QBSserviceII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Plan_Ms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vc_plan_code = table.Column<string>(maxLength: 50, nullable: true),
                    vc_plan_desc = table.Column<string>(maxLength: 500, nullable: true),
                    nu_plan_min_amt = table.Column<decimal>(nullable: false),
                    nu_plan_max_amt = table.Column<decimal>(nullable: false),
                    b_active = table.Column<bool>(nullable: false),
                    dt_created_on = table.Column<DateTime>(nullable: false),
                    dt_modified_on = table.Column<DateTime>(nullable: true),
                    dt_created_by = table.Column<long>(nullable: false),
                    dt_midified_by = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Plan_Ms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Service_Ms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vc_service_code = table.Column<string>(maxLength: 50, nullable: true),
                    vc_service_desc = table.Column<string>(maxLength: 500, nullable: true),
                    nu_service_min_amt = table.Column<decimal>(nullable: false),
                    nu_service_max_amt = table.Column<decimal>(nullable: false),
                    b_active = table.Column<bool>(nullable: false),
                    dt_created_on = table.Column<DateTime>(nullable: false),
                    dt_modified_on = table.Column<DateTime>(nullable: true),
                    dt_created_by = table.Column<long>(nullable: false),
                    dt_midified_by = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Service_Ms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Plan_Ms");

            migrationBuilder.DropTable(
                name: "tbl_Service_Ms");
        }
    }
}
