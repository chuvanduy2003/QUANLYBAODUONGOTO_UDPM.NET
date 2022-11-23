using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class DucAnh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ho = table.Column<string>(maxLength: 50, nullable: false),
                    TenDem = table.Column<string>(maxLength: 50, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    SDT = table.Column<string>(maxLength: 11, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 50, nullable: false),
                    ThanhPho = table.Column<string>(maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 200, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdCV = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ho = table.Column<string>(maxLength: 50, nullable: false),
                    TenDem = table.Column<string>(maxLength: 50, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    SDT = table.Column<string>(maxLength: 11, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 50, nullable: false),
                    TenDangNhap = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    ThanhPho = table.Column<string>(maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdKH = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(nullable: true),
                    BienSo = table.Column<string>(maxLength: 10, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdLDV = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 200, nullable: false),
                    Gia = table.Column<float>(nullable: false),
                    ThoiGianHT = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.Id);
                    table.CheckConstraint("Price", "Gia >= 0");
                    table.CheckConstraint("Time", "ThoiGianHT >= GETDATE()");
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_IdLDV",
                        column: x => x.IdLDV,
                        principalTable: "LoaiDichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdXe = table.Column<Guid>(nullable: false),
                    IdNVTaoPhieu = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    ThoiGianNhan = table.Column<DateTime>(nullable: false),
                    ThoiGianTao = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    ThoiGianHT = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<float>(nullable: false),
                    IdNVSua = table.Column<Guid>(nullable: false),
                    TenNguoiNhan = table.Column<string>(maxLength: 200, nullable: false),
                    SDT = table.Column<string>(maxLength: 11, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDichVu", x => x.Id);
                    table.CheckConstraint("TimeHT", "ThoiGianHT >= GETDATE()");
                    table.CheckConstraint("TimeNhan", "ThoiGianNhan >= GETDATE()");
                    table.CheckConstraint("PriceSum", "TongTien >= 0");
                    table.ForeignKey(
                        name: "FK_PhieuDichVu_NhanVien_IdNVTaoPhieu",
                        column: x => x.IdNVTaoPhieu,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuDichVu_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdPhieu = table.Column<Guid>(nullable: false),
                    IdDichVu = table.Column<Guid>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<float>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuChiTiet", x => x.Id);
                    table.CheckConstraint("Stocks", "SoLuong >= 0");
                    table.CheckConstraint("Prices", "DonGia >= 0");
                    table.ForeignKey(
                        name: "FK_PhieuChiTiet_DichVu_IdDichVu",
                        column: x => x.IdDichVu,
                        principalTable: "DichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuChiTiet_PhieuDichVu_IdPhieu",
                        column: x => x.IdPhieu,
                        principalTable: "PhieuDichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_IdLDV",
                table: "DichVu",
                column: "IdLDV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChiTiet_IdDichVu",
                table: "PhieuChiTiet",
                column: "IdDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChiTiet_IdPhieu",
                table: "PhieuChiTiet",
                column: "IdPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_IdNVTaoPhieu",
                table: "PhieuDichVu",
                column: "IdNVTaoPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_IdXe",
                table: "PhieuDichVu",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_IdKH",
                table: "Xe",
                column: "IdKH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuChiTiet");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "PhieuDichVu");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Xe");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
