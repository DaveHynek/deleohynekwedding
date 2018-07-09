using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace deleohynekwedding.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuestResponseInfo_Guest_ID",
                table: "GuestResponseInfo");

            migrationBuilder.AlterColumn<bool>(
                name: "Attending",
                table: "Invitation",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Attending",
                table: "GuestResponseInfo",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "GuestResponseInfo",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ResponseInfoID",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_ResponseInfoID",
                table: "Guest",
                column: "ResponseInfoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_GuestResponseInfo_ResponseInfoID",
                table: "Guest",
                column: "ResponseInfoID",
                principalTable: "GuestResponseInfo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_GuestResponseInfo_ResponseInfoID",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_ResponseInfoID",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "ResponseInfoID",
                table: "Guest");

            migrationBuilder.AlterColumn<bool>(
                name: "Attending",
                table: "Invitation",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Attending",
                table: "GuestResponseInfo",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "GuestResponseInfo",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestResponseInfo_Guest_ID",
                table: "GuestResponseInfo",
                column: "ID",
                principalTable: "Guest",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
