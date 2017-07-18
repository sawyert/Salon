using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonServices.Migrations
{
    public partial class InitialSalonDataForTim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            FullDataLoad.LoadData();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
