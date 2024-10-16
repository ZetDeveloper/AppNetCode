using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationNet.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedures : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Eliminar el procedimiento si existe
            migrationBuilder.Sql(@"
        IF OBJECT_ID('sp_UpdateProduct', 'P') IS NOT NULL
            DROP PROCEDURE sp_UpdateProduct;
    ");

            // Crear el procedimiento almacenado
            migrationBuilder.Sql(@"
        CREATE PROCEDURE sp_UpdateProduct
            @Id INT,
            @Name NVARCHAR(100),
            @Price DECIMAL(18,2)
        AS
        BEGIN
            SET NOCOUNT ON;
            UPDATE Products
            SET Name = @Name,
                Price = @Price
            WHERE Id = @Id;
        END
    ");

            // Repetir el proceso para sp_DeleteProduct
            migrationBuilder.Sql(@"
        IF OBJECT_ID('sp_DeleteProduct', 'P') IS NOT NULL
            DROP PROCEDURE sp_DeleteProduct;
    ");

            migrationBuilder.Sql(@"
        CREATE PROCEDURE sp_DeleteProduct
            @Id INT
        AS
        BEGIN
            SET NOCOUNT ON;
            DELETE FROM Products
            WHERE Id = @Id;
        END
    ");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        IF OBJECT_ID('sp_UpdateProduct', 'P') IS NOT NULL
            DROP PROCEDURE sp_UpdateProduct;
    ");

            migrationBuilder.Sql(@"
        IF OBJECT_ID('sp_DeleteProduct', 'P') IS NOT NULL
            DROP PROCEDURE sp_DeleteProduct;
    ");
        }
    }
}
