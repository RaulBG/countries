using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Countries.Infraestructure.Migrations
{
    public partial class InitBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapitalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latlng = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Signs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoatOfArms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoatOfArms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gini",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    The2019 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gini", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Idd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Root = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suffixes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Que = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoogleMaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenStreetMaps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "names",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Common = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Official = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_names", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostalCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regex = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demonyms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demonyms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demonyms_Designations_designationsId",
                        column: x => x.designationsId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesignationsAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationsAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignationsAttributes_Designations_DesignationsId",
                        column: x => x.DesignationsId,
                        principalTable: "Designations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NativeNameTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Official = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Common = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NativeNameTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NativeNameTranslations_names_NameId",
                        column: x => x.NameId,
                        principalTable: "names",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Pen_PenId",
                        column: x => x.PenId,
                        principalTable: "Pen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<int>(type: "int", nullable: false),
                    Tld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cca2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ccn3 = table.Column<long>(type: "bigint", nullable: false),
                    Cca3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cioc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Independent = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnMember = table.Column<bool>(type: "bit", nullable: false),
                    CurrenciesId = table.Column<int>(type: "int", nullable: false),
                    IddId = table.Column<int>(type: "int", nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltSpellings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    Latlng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Landlocked = table.Column<bool>(type: "bit", nullable: false),
                    Borders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<long>(type: "bigint", nullable: false),
                    DemonymsId = table.Column<int>(type: "int", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapsId = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    GiniId = table.Column<int>(type: "int", nullable: false),
                    Fifa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Timezones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagsId = table.Column<int>(type: "int", nullable: false),
                    CoatOfArmsId = table.Column<int>(type: "int", nullable: false),
                    StartOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapitalInfoId = table.Column<int>(type: "int", nullable: false),
                    PostalCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contries_CapitalInfo_CapitalInfoId",
                        column: x => x.CapitalInfoId,
                        principalTable: "CapitalInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_CoatOfArms_CoatOfArmsId",
                        column: x => x.CoatOfArmsId,
                        principalTable: "CoatOfArms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Currencies_CurrenciesId",
                        column: x => x.CurrenciesId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Demonyms_DemonymsId",
                        column: x => x.DemonymsId,
                        principalTable: "Demonyms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Flags_FlagsId",
                        column: x => x.FlagsId,
                        principalTable: "Flags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Gini_GiniId",
                        column: x => x.GiniId,
                        principalTable: "Gini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Idd_IddId",
                        column: x => x.IddId,
                        principalTable: "Idd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_Maps_MapsId",
                        column: x => x.MapsId,
                        principalTable: "Maps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_names_NameId",
                        column: x => x.NameId,
                        principalTable: "names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contries_PostalCode_PostalCodeId",
                        column: x => x.PostalCodeId,
                        principalTable: "PostalCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Official = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Common = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translation_contries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "contries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_contries_CapitalInfoId",
                table: "contries",
                column: "CapitalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_CarId",
                table: "contries",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_CoatOfArmsId",
                table: "contries",
                column: "CoatOfArmsId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_CurrenciesId",
                table: "contries",
                column: "CurrenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_DemonymsId",
                table: "contries",
                column: "DemonymsId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_FlagsId",
                table: "contries",
                column: "FlagsId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_GiniId",
                table: "contries",
                column: "GiniId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_IddId",
                table: "contries",
                column: "IddId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_LanguagesId",
                table: "contries",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_MapsId",
                table: "contries",
                column: "MapsId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_NameId",
                table: "contries",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_contries_PostalCodeId",
                table: "contries",
                column: "PostalCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_PenId",
                table: "Currencies",
                column: "PenId");

            migrationBuilder.CreateIndex(
                name: "IX_Demonyms_designationsId",
                table: "Demonyms",
                column: "designationsId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignationsAttributes_DesignationsId",
                table: "DesignationsAttributes",
                column: "DesignationsId");

            migrationBuilder.CreateIndex(
                name: "IX_NativeNameTranslations_NameId",
                table: "NativeNameTranslations",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_CountryId",
                table: "Translation",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignationsAttributes");

            migrationBuilder.DropTable(
                name: "NativeNameTranslations");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "contries");

            migrationBuilder.DropTable(
                name: "CapitalInfo");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "CoatOfArms");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Demonyms");

            migrationBuilder.DropTable(
                name: "Flags");

            migrationBuilder.DropTable(
                name: "Gini");

            migrationBuilder.DropTable(
                name: "Idd");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "names");

            migrationBuilder.DropTable(
                name: "PostalCode");

            migrationBuilder.DropTable(
                name: "Pen");

            migrationBuilder.DropTable(
                name: "Designations");
        }
    }
}
