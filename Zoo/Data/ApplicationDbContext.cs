using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zoo.Models;


namespace Zoo.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Arraza> Arrazak { get; set; }

        public DbSet<Lekua> Lekuak { get; set; }

        public DbSet<Bezero> Bezeroak { get; set; }
        public DbSet<Animalia> Animaliak { get; set; }
        public DbSet<Langile> Langileak { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lekua>().HasData(
                new Lekua { ID = 1, Izena = "Australia", Deskribapena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Lekua { ID = 2, Izena = "Artikoa", Deskribapena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Lekua { ID = 3, Izena = "Sabana", Deskribapena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Lekua { ID = 4, Izena = "Asia", Deskribapena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Lekua { ID = 5, Izena = "Baso Tropikala", Deskribapena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." }
                );
            modelBuilder.Entity<Arraza>().HasData(
                new Arraza
                {
                    ID = 1,
                    Izena = "Txinpantze",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\chimpanzee1.jpg",
                    ID_lekua = 5
                },
                new Arraza
                {
                    ID = 2,
                    Izena = "Gorila",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\gorilla1.jpg",
                    ID_lekua = 5
                },
                new Arraza
                {
                    ID = 3,
                    Izena = "Panda Gorria",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\red-panda1.jpg",
                    ID_lekua = 4
                },
                new Arraza
                {
                    ID = 4,
                    Izena = "Kanguru",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\kangaroo1.jpg",
                    ID_lekua = 1
                },
                new Arraza
                {
                    ID = 5,
                    Izena = "Nagi",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\sloth1.jpg",
                    ID_lekua = 5
                },
                new Arraza
                {
                    ID = 6,
                    Izena = "Azeri artikoa",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\artic-fox1.jpg",
                    ID_lekua = 2
                },
                 new Arraza
                 {
                     ID = 7,
                     Izena = "Elefante",
                     Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                     ImageUrl = "\\images\\arraza\\elephant1.jpg",
                     ID_lekua = 3
                 },
                new Arraza
                {
                    ID = 8,
                    Izena = "Flamenko",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\flamingo1.jpg",
                    ID_lekua = 4
                },
                new Arraza
                {
                    ID = 9,
                    Izena = "Hartz zuri",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\polar-bear1.jpg",
                    ID_lekua = 2
                },
                new Arraza
                {
                    ID = 10,
                    Izena = "Pinguino",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\penguin1.jpg",
                    ID_lekua = 2
                },
                new Arraza
                {
                    ID = 11,
                    Izena = "Surikata",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\meerkat1.jpg",
                    ID_lekua = 3
                },
                new Arraza
                {
                    ID = 12,
                    Izena = "Giboi",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\gibbon1.jpg",
                    ID_lekua = 5
                },
                new Arraza
                {
                    ID = 13,
                    Izena = "Jirafa",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\giraffe1.jpg",
                    ID_lekua = 3
                },
                new Arraza
                {
                    ID = 14,
                    Izena = "Koala",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\koala1.jpg",
                    ID_lekua = 1
                },
                new Arraza
                {
                    ID = 15,
                    Izena = "Tximino",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\monkey1.jpg",
                    ID_lekua = 5
                },
                new Arraza
                {
                    ID = 16,
                    Izena = "Zebra",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\zebra1.jpg",
                    ID_lekua = 3
                },
                new Arraza
                {
                    ID = 17,
                    Izena = "Lehoi",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\lion1.jpg",
                    ID_lekua = 3
                },
                new Arraza
                {
                    ID = 18,
                    Izena = "Tigre",
                    Deskribapena = "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.",
                    ImageUrl = "\\images\\arraza\\tiger1.jpg",
                    ID_lekua = 3
                }
                );
            modelBuilder.Entity<Animalia>().HasData(
                 new Animalia
                 {
                     ID = 1,
                     Izena = "Charlie the Charming Chimpanzee",
                     Sarrera_data = new DateOnly(2022, 05, 15),
                     urte_betetzea = new DateOnly(2019, 03, 10),
                     ID_arraza =

                            1

                    ,
                     ImageUrl = "\\images\\animalia\\charlie.jpg",

                 },


            new Animalia
            {
                ID = 2,
                Izena = "Goliath the Gentle Giant Gorilla",
                Sarrera_data = new DateOnly(2021, 10, 20),
                urte_betetzea = new DateOnly(2018, 07, 05),
                ID_arraza =

                            2

                    ,
                ImageUrl = "\\images\\animalia\\goliath.jpg",

            },


            new Animalia
            {
                ID = 3,
                Izena = "Ruby the Radiant Red Panda",
                Sarrera_data = new DateOnly(2023, 01, 08),
                urte_betetzea = new DateOnly(2020, 02, 15),
                ID_arraza =

                            3

                    ,
                ImageUrl = "\\images\\animalia\\ruby.jpg",

            },


            new Animalia
            {
                ID = 4,
                Izena = "Kenny the Kicking Kangaroo",
                Sarrera_data = new DateOnly(2020, 12, 03),
                urte_betetzea = new DateOnly(2017, 09, 22),
                ID_arraza =

                            4

                    ,
                ImageUrl = "\\images\\animalia\\kenny.jpg",

            },


            new Animalia
            {
                ID = 5,
                Izena = "Sammy the Sleepy Sloth",
                Sarrera_data = new DateOnly(2023, 04, 25),
                urte_betetzea = new DateOnly(2020, 10, 30),
                ID_arraza =

                            5

                    ,
                ImageUrl = "\\images\\animalia\\sammy.jpg",

            },


            new Animalia
            {
                ID = 6,
                Izena = "Aurora the Agile Arctic Fox",
                Sarrera_data = new DateOnly(2022, 08, 12),
                urte_betetzea = new DateOnly(2019, 06, 18),
                ID_arraza =

                            6

                    ,
                ImageUrl = "\\images\\animalia\\aurora.jpg",

            },


            new Animalia
            {
                ID = 7,
                Izena = "Eleanor the Elegant Elephant",
                Sarrera_data = new DateOnly(2021, 11, 30),
                urte_betetzea = new DateOnly(2019, 04, 20),
                ID_arraza =

                            7

                    ,
                ImageUrl = "\\images\\animalia\\eleanor.jpg",

            },


            new Animalia
            {
                ID = 8,
                Izena = "Felicia the Flamboyant Flamingo",
                Sarrera_data = new DateOnly(2022, 09, 15),
                urte_betetzea = new DateOnly(2020, 01, 05),
                ID_arraza =

                            8

                    ,
                ImageUrl = "\\images\\animalia\\felicia.jpg",

            },


            new Animalia
            {
                ID = 9,
                Izena = "Percy the Playful Polar Bear",
                Sarrera_data = new DateOnly(2020, 07, 22),
                urte_betetzea = new DateOnly(2018, 10, 12),
                ID_arraza =

                            9

                    ,
                ImageUrl = "\\images\\animalia\\percy.jpg",

            },


            new Animalia
            {
                ID = 10,
                Izena = "Penny the Perky Penguin",
                Sarrera_data = new DateOnly(2023, 02, 28),
                urte_betetzea = new DateOnly(2020, 08, 20),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\penny.jpg",

            },


            new Animalia
            {
                ID = 11,
                Izena = "Milo the Mischievous Meerkat",
                Sarrera_data = new DateOnly(2021, 12, 10),
                urte_betetzea = new DateOnly(2019, 05, 03),
                ID_arraza =

                            11

                    ,
                ImageUrl = "\\images\\animalia\\milo.jpg",

            },


            new Animalia
            {
                ID = 12,
                Izena = "Gracie the Graceful Gibbon",
                Sarrera_data = new DateOnly(2022, 06, 05),
                urte_betetzea = new DateOnly(2019, 01, 18),
                ID_arraza =

                            12

                    ,
                ImageUrl = "\\images\\animalia\\gracie.jpg",

            },


            new Animalia
            {
                ID = 13,
                Izena = "Eric the Enthusiastic Elephant",
                Sarrera_data = new DateOnly(2023, 04, 12),
                urte_betetzea = new DateOnly(2020, 01, 30),
                ID_arraza =

                            7

                    ,
                ImageUrl = "\\images\\animalia\\eric.jpg",

            },


            new Animalia
            {
                ID = 14,
                Izena = "Fiona the Fancy Flamingo",
                Sarrera_data = new DateOnly(2023, 07, 19),
                urte_betetzea = new DateOnly(2021, 02, 10),
                ID_arraza =

                            8

                    ,
                ImageUrl = "\\images\\animalia\\fiona.jpg",

            },


            new Animalia
            {
                ID = 15,
                Izena = "Gerald the Gentle Giraffe",
                Sarrera_data = new DateOnly(2023, 08, 20),
                urte_betetzea = new DateOnly(2020, 12, 05),
                ID_arraza =

                            13

                    ,
                ImageUrl = "\\images\\animalia\\gerald.jpg",

            },


            new Animalia
            {
                ID = 16,
                Izena = "Katie the Cuddly Koala",
                Sarrera_data = new DateOnly(2024, 01, 15),
                urte_betetzea = new DateOnly(2021, 05, 25),
                ID_arraza =

                            14

                    ,
                ImageUrl = "\\images\\animalia\\katie.jpg",

            },


            new Animalia
            {
                ID = 17,
                Izena = "Manny the Merry Monkey",
                Sarrera_data = new DateOnly(2024, 03, 01),
                urte_betetzea = new DateOnly(2021, 09, 12),
                ID_arraza =

                            15

                    ,
                ImageUrl = "\\images\\animalia\\manny.jpg",

            },


            new Animalia
            {
                ID = 18,
                Izena = "Zara the Zesty Zebra",
                Sarrera_data = new DateOnly(2024, 02, 10),
                urte_betetzea = new DateOnly(2021, 06, 25),
                ID_arraza =

                            16

                    ,
                ImageUrl = "\\images\\animalia\\zara.jpg",

            },


            new Animalia
            {
                ID = 19,
                Izena = "Leo the Majestic Lion",
                Sarrera_data = new DateOnly(2024, 03, 10),
                urte_betetzea = new DateOnly(2021, 08, 25),
                ID_arraza =

                            17

                    ,
                ImageUrl = "\\images\\animalia\\leo.jpg",

            },


            new Animalia
            {
                ID = 20,
                Izena = "Luna the Fierce Lioness",
                Sarrera_data = new DateOnly(2024, 03, 15),
                urte_betetzea = new DateOnly(2021, 09, 02),
                ID_arraza =

                            17

                    ,
                ImageUrl = "\\images\\animalia\\luna.jpg",

            },


            new Animalia
            {
                ID = 21,
                Izena = "Max the Mighty Lion",
                Sarrera_data = new DateOnly(2024, 03, 20),
                urte_betetzea = new DateOnly(2021, 09, 10),
                ID_arraza =

                            17

                    ,
                ImageUrl = "\\images\\animalia\\max.jpg",

            },


            new Animalia
            {
                ID = 22,
                Izena = "Lola the Lovely Lioness",
                Sarrera_data = new DateOnly(2024, 03, 25),
                urte_betetzea = new DateOnly(2021, 09, 18),
                ID_arraza =

                            17

                    ,
                ImageUrl = "\\images\\animalia\\lola.jpg",

            },


            new Animalia
            {
                ID = 23,
                Izena = "Simba the Courageous Lion",
                Sarrera_data = new DateOnly(2024, 03, 28),
                urte_betetzea = new DateOnly(2021, 09, 22),
                ID_arraza =

                            17

                    ,
                ImageUrl = "\\images\\animalia\\simba.jpg",

            },


            new Animalia
            {
                ID = 24,
                Izena = "Carlos the Cheerful Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 01),
                urte_betetzea = new DateOnly(2021, 10, 05),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\carlos.jpg",

            },


            new Animalia
            {
                ID = 25,
                Izena = "Chloe the Charming Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 05),
                urte_betetzea = new DateOnly(2021, 10, 10),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\chloe.jpg",

            },


            new Animalia
            {
                ID = 26,
                Izena = "Chip the Clever Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 10),
                urte_betetzea = new DateOnly(2021, 10, 15),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\chip.jpg",

            },


            new Animalia
            {
                ID = 27,
                Izena = "Charlotte the Curious Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 15),
                urte_betetzea = new DateOnly(2021, 10, 20),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\charlotte.jpg",

            },


            new Animalia
            {
                ID = 28,
                Izena = "Cooper the Confident Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 20),
                urte_betetzea = new DateOnly(2021, 10, 25),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\cooper.jpg",

            },


            new Animalia
            {
                ID = 29,
                Izena = "Cindy the Cute Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 25),
                urte_betetzea = new DateOnly(2021, 10, 30),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\cindy.jpg",

            },


            new Animalia
            {
                ID = 30,
                Izena = "Connor the Cuddly Chimpanzee",
                Sarrera_data = new DateOnly(2024, 04, 30),
                urte_betetzea = new DateOnly(2021, 11, 05),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\connor.jpg",

            },


            new Animalia
            {
                ID = 31,
                Izena = "Cleo the Creative Chimpanzee",
                Sarrera_data = new DateOnly(2024, 05, 05),
                urte_betetzea = new DateOnly(2021, 11, 10),
                ID_arraza =

                            1

                    ,
                ImageUrl = "\\images\\animalia\\cleo.jpg",

            },


            new Animalia
            {
                ID = 32,
                Izena = "Paul the Playful Penguin",
                Sarrera_data = new DateOnly(2024, 04, 01),
                urte_betetzea = new DateOnly(2021, 10, 05),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\paul.jpg",

            },


            new Animalia
            {
                ID = 33,
                Izena = "Poppy the Perky Penguin",
                Sarrera_data = new DateOnly(2024, 04, 05),
                urte_betetzea = new DateOnly(2021, 10, 10),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\poppy.jpg",

            },


            new Animalia
            {
                ID = 34,
                Izena = "Arturo the Pensive Penguin",
                Sarrera_data = new DateOnly(2024, 04, 10),
                urte_betetzea = new DateOnly(2021, 10, 15),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\arturo.jpg",

            },


            new Animalia
            {
                ID = 35,
                Izena = "Pen the Polite Penguin",
                Sarrera_data = new DateOnly(2024, 04, 15),
                urte_betetzea = new DateOnly(2021, 10, 20),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\pen.jpg",

            },


            new Animalia
            {
                ID = 36,
                Izena = "Pablo the Playful Penguin",
                Sarrera_data = new DateOnly(2024, 04, 20),
                urte_betetzea = new DateOnly(2021, 10, 25),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\pablo.jpg",

            },


            new Animalia
            {
                ID = 37,
                Izena = "Polly the Prancing Penguin",
                Sarrera_data = new DateOnly(2024, 04, 25),
                urte_betetzea = new DateOnly(2021, 10, 30),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\polly.jpg",

            },


            new Animalia
            {
                ID = 38,
                Izena = "Peter the Peaceful Penguin",
                Sarrera_data = new DateOnly(2024, 04, 30),
                urte_betetzea = new DateOnly(2021, 11, 05),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\peter.jpg",

            },


            new Animalia
            {
                ID = 39,
                Izena = "Penelope the Patient Penguin",
                Sarrera_data = new DateOnly(2024, 05, 05),
                urte_betetzea = new DateOnly(2021, 11, 10),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\penelope.jpg",

            },


            new Animalia
            {
                ID = 40,
                Izena = "Patrick the Playful Penguin",
                Sarrera_data = new DateOnly(2024, 05, 10),
                urte_betetzea = new DateOnly(2021, 11, 15),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\patrick.jpg",

            },


            new Animalia
            {
                ID = 41,
                Izena = "Pippa the Prankster Penguin",
                Sarrera_data = new DateOnly(2024, 05, 15),
                urte_betetzea = new DateOnly(2021, 11, 20),
                ID_arraza =

                            10

                    ,
                ImageUrl = "\\images\\animalia\\pippa.jpg",

            },


            new Animalia
            {
                ID = 42,
                Izena = "Sarita the Zany Zebra",
                Sarrera_data = new DateOnly(2024, 04, 05),
                urte_betetzea = new DateOnly(2021, 10, 10),
                ID_arraza =

                            16

                    ,
                ImageUrl = "\\images\\animalia\\sarita.jpg",

            },


            new Animalia
            {
                ID = 43,
                Izena = "Ziggy the Zippy Zebra",
                Sarrera_data = new DateOnly(2024, 04, 10),
                urte_betetzea = new DateOnly(2021, 10, 15),
                ID_arraza =

                            16

                    ,
                ImageUrl = "\\images\\animalia\\ziggy.jpg",

            },


            new Animalia
            {
                ID = 44,
                Izena = "Gus the Gentle Giant Gorilla",
                Sarrera_data = new DateOnly(2024, 04, 01),
                urte_betetzea = new DateOnly(2021, 10, 05),
                ID_arraza =

                            2

                    ,
                ImageUrl = "\\images\\animalia\\gus.jpg",

            },


            new Animalia
            {
                ID = 45,
                Izena = "Greta the Gracious Gorilla",
                Sarrera_data = new DateOnly(2024, 04, 05),
                urte_betetzea = new DateOnly(2021, 10, 10),
                ID_arraza =

                            2

                    ,
                ImageUrl = "\\images\\animalia\\greta.jpg",

            },


            new Animalia
            {
                ID = 46,
                Izena = "Greg the Gentle Gorilla",
                Sarrera_data = new DateOnly(2024, 04, 10),
                urte_betetzea = new DateOnly(2021, 10, 15),
                ID_arraza =

                            2

                    ,
                ImageUrl = "\\images\\animalia\\greg.jpg",

            },


            new Animalia
            {
                ID = 47,
                Izena = "Gigi the Gorgeous Gorilla",
                Sarrera_data = new DateOnly(2024, 04, 15),
                urte_betetzea = new DateOnly(2021, 10, 20),
                ID_arraza =

                            2

                    ,
                ImageUrl = "\\images\\animalia\\gigi.jpg",

            },


            new Animalia
            {
                ID = 48,
                Izena = "Rusty the Radiant Red Panda",
                Sarrera_data = new DateOnly(2024, 04, 01),
                urte_betetzea = new DateOnly(2021, 10, 05),
                ID_arraza =

                            3

                    ,
                ImageUrl = "\\images\\animalia\\rusty.jpg",

            },


            new Animalia
            {
                ID = 49,
                Izena = "Tony the Terrific Tiger",
                Sarrera_data = new DateOnly(2024, 04, 01),
                urte_betetzea = new DateOnly(2021, 10, 05),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tony.jpg",

            },


            new Animalia
            {
                ID = 50,
                Izena = "Tara the Tremendous Tiger",
                Sarrera_data = new DateOnly(2024, 04, 05),
                urte_betetzea = new DateOnly(2021, 10, 10),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tara.jpg",

            },


            new Animalia
            {
                ID = 51,
                Izena = "Tim the Tenacious Tiger",
                Sarrera_data = new DateOnly(2024, 04, 10),
                urte_betetzea = new DateOnly(2021, 10, 15),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tim.jpg",

            },


            new Animalia
            {
                ID = 52,
                Izena = "Tess the Fearless Tiger",
                Sarrera_data = new DateOnly(2024, 04, 15),
                urte_betetzea = new DateOnly(2021, 10, 20),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tess.jpg",

            },


            new Animalia
            {
                ID = 53,
                Izena = "Tyler the Triumphant Tiger",
                Sarrera_data = new DateOnly(2024, 04, 20),
                urte_betetzea = new DateOnly(2021, 10, 25),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tyler.jpg",

            },


            new Animalia
            {
                ID = 54,
                Izena = "Tina the Tenacious Tiger",
                Sarrera_data = new DateOnly(2024, 04, 25),
                urte_betetzea = new DateOnly(2021, 10, 30),
                ID_arraza =

                            18

                    ,
                ImageUrl = "\\images\\animalia\\tina.jpg",

            }
                );
        }
    }
}
