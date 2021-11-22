using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApplication2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange
                (
                     new Product
                     {
                         Name = "Iphone 12",
                         Description = "128 GB 6.7inc",
                         Category = "Iphone",
                         Price = 11000,
                         MainCategory = "Telefon",
                         ImgPath = "../Anasayfa/images/telefon/iphone_12.png"
                     },

                     new Product
                     {
                         Name = "Iphone 11",
                         Description = "128 GB 6.1inc",
                         Category = "Iphone",
                         Price = 10000,
                         MainCategory = "Telefon",
                         ImgPath = "../Anasayfa/images/telefon/iphone_11.jpg"
                     },

                      new Product
                      {
                          Name = "Iphone X",
                          Description = "128 GB 5.8inc",
                          Category = "Iphone",
                          Price = 9000,
                          MainCategory = "Telefon",
                          ImgPath = "../Anasayfa/images/telefon/iphone_x.jpg"
                      },

                      // ===============================================================

                      new Product
                      {
                          Name = "Samsung Galaxy Note 10",
                          Description = "64GB 6.3inc",
                          Category = "Samsung",
                          Price = 8000,
                          MainCategory = "Telefon",
                          ImgPath = "../Anasayfa/images/telefon/samsung_note_10.jpg"
                      },

                      new Product
                      {
                          Name = "Samsung Galaxy Z Fold 2",
                          Description = "128GB 6.2inc",
                          Category = "Samsung",
                          Price = 7500,
                          MainCategory = "Telefon",
                          ImgPath = "../Anasayfa/images/telefon/samsung_fol_2.jpg"
                      },

                      new Product
                      {
                          Name = "Samsung Galaxy S20",
                          Description = "64GB 6.5inc",
                          Category = "Samsung",
                          Price = 6000,
                          MainCategory = "Telefon",
                          ImgPath = "../Anasayfa/images/telefon/samsung_s20_fe.jpg"
                      },

                       // ==================================================================

                       new Product
                       {
                           Name = "Oppo A91",
                           Description = "256GB 5.8inc",
                           Category = "Oppo",
                           Price = 7600,
                           MainCategory = "Telefon",
                           ImgPath = "../Anasayfa/images/telefon/oppo_a91.jpg"
                       },

                       new Product
                       {
                           Name = "Oppo C2",
                           Description = "128GB 5.4inc",
                           Category = "Oppo",
                           Price = 7600,
                           MainCategory = "Telefon",
                           ImgPath = "../Anasayfa/images/telefon/oppo_c2.jpg"
                       },

                       new Product
                       {
                            Name = "Oppo Reno 4",
                            Description = "256GB 6.5inc",
                            Category = "Oppo",
                            Price = 9800,
                            MainCategory = "Telefon",
                            ImgPath = "../Anasayfa/images/telefon/oppo_reno_4.jpg"
                       },

                        // ==================================================================

                        new Product
                        {
                            Name = "Huawei P40 Lite",
                            Description = "128GB 5.9inc",
                            Category = "Huawei",
                            Price = 8400,
                            MainCategory = "Telefon",
                            ImgPath = "../Anasayfa/images/telefon/huawei_p40_lite.jpg"
                        },

                        new Product
                        {
                            Name = "Huawei P20 Lite",
                            Description = "128GB 6inc",
                            Category = "Huawei",
                            Price = 7200,
                            MainCategory = "Telefon",
                            ImgPath = "../Anasayfa/images/telefon/huawei_p20_lite.jpg"
                        },

                         new Product
                         {
                             Name = "Huawei Y5",
                             Description = "128GB 6inc",
                             Category = "Huawei",
                             Price = 6800,
                             MainCategory = "Telefon",
                             ImgPath = "../Anasayfa/images/telefon/huawei_y5.jpg"
                         },

                         //==================================
                         //==================================

                         new Product
                         {
                             Name = "Samsung Smart TV C6",
                             Description = "Full HD 4K",
                             Category = "Samsung",
                             Price = 15000,
                             MainCategory = "Televizyon",
                             ImgPath = "../Anasayfa/images/televizyon/samsung_televiz_1.jpg"
                         },

                          new Product
                          {
                              Name = "Samsung Smart TV C7",
                              Description = "Full HD 4K",
                              Category = "Samsung",
                              Price = 14500,
                              MainCategory = "Televizyon",
                              ImgPath = "../Anasayfa/images/televizyon/samsung_televiz_2.jpg"
                          },

                          new Product
                          {
                              Name = "Samsung Smart TV C8",
                              Description = "Full HD 4K",
                              Category = "Samsung",
                              Price = 13000,
                              MainCategory = "Televizyon",
                              ImgPath = "../Anasayfa/images/televizyon/samsung-ue-43tu8500-gorseli-107846_large.jpg"
                          },

                          //=================================================

                          new Product
                          {
                              Name = "LG Smart TV A1",
                              Description = "Full HD 4K",
                              Category = "LG",
                              Price = 12000,
                              MainCategory = "Televizyon",
                              ImgPath = "../Anasayfa/images/televizyon/lg_1.jpg"
                          },

                          new Product
                          {
                              Name = "LG Smart TV A2",
                              Description = "Full HD 4K",
                              Category = "LG",
                              Price = 11000,
                              MainCategory = "Televizyon",
                              ImgPath = "../Anasayfa/images/televizyon/lg_2.jpg"
                          },

                           // ================================

                           new Product
                           {
                               Name = "Vestel Smart TV B1",
                               Description = "Full HD 4K",
                               Category = "Vestel",
                               Price = 10000,
                               MainCategory = "Televizyon",
                               ImgPath = "../Anasayfa/images/televizyon/vestel_1.jpg"
                           },

                            new Product
                            {
                                Name = "Vestel Smart TV B2",
                                Description = "Full HD 4K",
                                Category = "Vestel",
                                Price = 10000,
                                MainCategory = "Televizyon",
                                ImgPath = "../Anasayfa/images/televizyon/vestel_2.jpg"
                            },

                            new Product
                            {
                                Name = "Vestel Smart TV B3",
                                Description = "Full HD 4K",
                                Category = "Vestel",
                                Price = 16000,
                                MainCategory = "Televizyon",
                                ImgPath = "../Anasayfa/images/televizyon/vestel_3.jpg"
                            },

                            new Product
                            {
                                Name = "Vestel Smart TV B4",
                                Description = "Full HD 4K",
                                Category = "Vestel",
                                Price = 14500,
                                MainCategory = "Televizyon",
                                ImgPath = "../Anasayfa/images/televizyon/vestel-40fd5050-40-inc-102-ekran-uydu-alicili-full-hd-led-televizyon-17905.jpg"
                            },

                           //===========================

                           new Product
                           {
                               Name = "Asus Laptop 1",
                               Description = "8GB RAM Intel i5",
                               Category = "Asus",
                               Price = 9800,
                               MainCategory = "Bilgisayar",
                               ImgPath = "../Anasayfa/images/laptop/asus_1.jpg"
                           },

                            new Product
                            {
                                Name = "Asus Laptop 2",
                                Description = "16GB RAM Intel i5",
                                Category = "Asus",
                                Price = 10000,
                                MainCategory = "Bilgisayar",
                                ImgPath = "../Anasayfa/images/laptop/asus_2.jpg"
                            },

                             new Product
                             {
                                 Name = "Asus Laptop 3",
                                 Description = "16GB RAM Intel i7",
                                 Category = "Asus",
                                 Price = 12000,
                                 MainCategory = "Bilgisayar",
                                 ImgPath = "../Anasayfa/images/laptop/asus_3.jpg"
                             },

                              new Product
                              {
                                  Name = "Asus Laptop 4",
                                  Description = "32GB RAM Intel i9",
                                  Category = "Asus",
                                  Price = 20000,
                                  MainCategory = "Bilgisayar",
                                  ImgPath = "../Anasayfa/images/laptop/asus_4.jpg"
                              },

                               // ==================================

                               new Product
                               {
                                   Name = "Dell Laptop 1",
                                   Description = "8GB RAM Intel i3",
                                   Category = "Dell",
                                   Price = 5000,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/dell_1.jpg"
                               },

                               new Product
                               {
                                   Name = "Dell Laptop 2",
                                   Description = "8GB RAM Intel i5",
                                   Category = "Dell",
                                   Price = 6500,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/dell_2.jpg"
                               },

                               new Product
                               {
                                   Name = "Dell Laptop 3",
                                   Description = "16GB RAM Intel i5",
                                   Category = "Dell",
                                   Price = 7500,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/dell_3.jpg"
                               },

                               new Product
                               {
                                   Name = "Dell Laptop 4",
                                   Description = "32GB RAM Intel i7",
                                   Category = "Dell",
                                   Price = 15000,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/dell_4.jpg"
                               },

                               //================================================

                               new Product
                               {
                                   Name = "Monster Laptop 1",
                                   Description = "16GB RAM Intel i9",
                                   Category = "Monster",
                                   Price = 19000,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/monster_1.jpg"
                               },

                               new Product
                               {
                                   Name = "Monster Laptop 2",
                                   Description = "8GB RAM Intel i5",
                                   Category = "Monster",
                                   Price = 8700,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/monster_2.jpg"
                               },

                               new Product
                               {
                                   Name = "Monster Laptop 3",
                                   Description = "8GB RAM Intel i3",
                                   Category = "Monster",
                                   Price = 7800,
                                   MainCategory = "Bilgisayar",
                                   ImgPath = "../Anasayfa/images/laptop/monster_3.jpg"
                               },

                               // ===================
                               // ===================

                               new Product
                               {
                                   Name = "Asus Anakart",
                                   Description = "DDR4",
                                   Category = "Asus",
                                   Price = 1200,
                                   MainCategory = "Sarf Malzemeler",
                                   ImgPath = "../Anasayfa/images/sarf/asus_1.jpg"
                               },

                               new Product
                               {
                                   Name = "Gigabyte Anakart",
                                   Description = "DDR3",
                                   Category = "Gigabyte",
                                   Price = 800,
                                   MainCategory = "Sarf Malzemeler",
                                   ImgPath = "../Anasayfa/images/sarf/gigabyte_1.png"
                               },

                               new Product
                               {
                                   Name = "MSI Anakart",
                                   Description = "DDR4",
                                   Category = "MSI",
                                   Price = 1500,
                                   MainCategory = "Sarf Malzemeler",
                                   ImgPath = "../Anasayfa/images/sarf/msi_1.jpg"
                               }

                );
                context.SaveChanges();
            }
        }
    }
}
