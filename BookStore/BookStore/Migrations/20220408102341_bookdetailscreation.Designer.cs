// <auto-generated />
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookDbcontext))]
    [Migration("20220408102341_bookdetailscreation")]
    partial class bookdetailscreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.Models.BookDetail", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<int>("BookDesc")
                        .HasColumnType("int");

                    b.Property<int>("BookName")
                        .HasColumnType("int");

                    b.Property<int>("BookType")
                        .HasColumnType("int");

                    b.HasKey("BookID");

                    b.ToTable("bookDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
