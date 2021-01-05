using DataAccess.DataModels;
using System;
using System.Linq;

namespace DataAccess
{
    public static class DatabaseInitialiser
    {
        public static void Initialise(Context context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.DiscountTypes.Any()) { return; }

            /*--------------- ADD DISCOUNT TYPES ---------------*/
            var discountTypes = new DiscountType[]
            {
                new DiscountType { Description = "£10 off your purchase", IsPercentage = false, DiscountValue = 10, Threshold = null },
                new DiscountType { Description = "10% off your purchase", IsPercentage = true, DiscountValue = 10, Threshold = null },
                new DiscountType { Description = "£10 off orders above £50", IsPercentage= false, DiscountValue = 10, Threshold = 50 },
                new DiscountType { Description = "20% off your purchase", IsPercentage = true, DiscountValue = 20, Threshold = null }
            };

            foreach (DiscountType dt in discountTypes)
            {
                context.DiscountTypes.Add(dt);
            }
            context.Commit();

            /*--------------- ADD DISCOUNT TYPES ---------------*/
            var vouchers = new Voucher[]
            {
                new Voucher { ID = "£10OFFPLEASE", DiscountTypeID = 1, DiscountAvailableUntil = null, OneTimeUse = false, InUse = false, Used = false },
                new Voucher { ID = "ABCDEFG", DiscountTypeID = 1, DiscountAvailableUntil = null, OneTimeUse = true, InUse = false, Used = false },
                new Voucher { ID = "10%OFF", DiscountTypeID = 2, DiscountAvailableUntil = null, OneTimeUse = false, InUse = false, Used = false },
                new Voucher { ID = "£10OFF", DiscountTypeID = 1, DiscountAvailableUntil = new DateTime(2015, 5, 30), OneTimeUse = false, InUse = false, Used = false }
            };

            foreach(Voucher v in vouchers)
            {
                context.Vouchers.Add(v);
            }
            context.Commit();

            /*--------------- ADD SIZES ---------------*/
            var sizes = new Size[]
            {
                new Size { SizeNumber = 4 },
                new Size { SizeNumber = 4.5 },
                new Size { SizeNumber = 5 },
                new Size { SizeNumber = 6 }
            };

            foreach(Size s in sizes)
            {
                context.Sizes.Add(s);
            }
            context.Commit();

            /*--------------- ADD PRODUCTS ---------------*/
            var products = new Product[]
            {
                new Product
                {
                    ShoeName = "Leather Boots",
                    Price = 34.99,
                    PhotoFilepath = "leather-boots-01.jpg",
                    Description = "With their versatile black colourway and practical block heels, " +
                                  "the Castarika ankle boots from Christian Louboutin will have you striding " +
                                  "into the new season with confidence. Made from leather, they have the " +
                                  "label's signature lipstick-red soles – a recognizable finish for those in the know."
                },
                new Product
                {
                    ShoeName = "Colourful Sneakers",
                    Price = 74.99,
                    PhotoFilepath = "colourful-sneakers-01.jpg",
                    Description = "Sneaker lovers will recognize Nike's iconic Air Max 95 design, refreshed with color blocked stripes, " +
                                  "including leopard and floral prints. The tonal Air® sole, along with an embroidered swoosh, lend this look " +
                                  "distinguished style – perfect for pairing with dressy outfits for an urban finish."
                },
                new Product
                {
                    ShoeName = "Floral Heels",
                    Price = 55.00,
                    PhotoFilepath = "floral-heels-01.jpg",
                    Description = "These vibrant Keira sandals from Dolce & Gabbana reflect the house's jungle theme for SS20. Printed with brightly-colored" +
                                  " birds of paradise and lush foliage, they're made with silk twill straps that reference '50s-era pin-up styles. They're " +
                                  "perched atop 105mm heels wrapped in wicker."
                }
            };

            foreach(Product p in products)
            {
                context.Products.Add(p);
            }
            context.Commit();

            var productAvailabilites = new ProductAvailability[]
            {
                new ProductAvailability 
                {
                    ProductID = 1,
                    SizeID = 1,
                    NumberAvailable = 25
                },
                new ProductAvailability
                {
                    ProductID = 1,
                    SizeID = 2,
                    NumberAvailable = 10
                },
                new ProductAvailability
                {
                    ProductID = 1,
                    SizeID = 3,
                    NumberAvailable = 0
                },
                new ProductAvailability
                {
                    ProductID = 1,
                    SizeID = 4,
                    NumberAvailable = 50
                },
                new ProductAvailability
                {
                    ProductID = 2,
                    SizeID = 1,
                    NumberAvailable = 35
                },
                new ProductAvailability
                {
                    ProductID = 2,
                    SizeID = 2,
                    NumberAvailable = 0
                },
                new ProductAvailability
                {
                    ProductID = 2,
                    SizeID = 3,
                    NumberAvailable = 125
                },
                new ProductAvailability
                {
                    ProductID = 2,
                    SizeID = 4,
                    NumberAvailable = 0
                },
                new ProductAvailability
                {
                    ProductID = 3,
                    SizeID = 1,
                    NumberAvailable = 15
                },
                new ProductAvailability
                {
                    ProductID = 3,
                    SizeID = 2,
                    NumberAvailable = 15
                },
                new ProductAvailability
                {
                    ProductID = 3,
                    SizeID = 3,
                    NumberAvailable = 15
                },
                new ProductAvailability
                {
                    ProductID = 3,
                    SizeID = 4,
                    NumberAvailable = 15
                }
            };

            foreach (ProductAvailability pa in productAvailabilites)
            {
                context.ProductAvailabilities.Add(pa);
            }
            context.Commit();

            /*--------------- ADD SHOPPING CART ITEMS ---------------*/

            var item = new ShoppingCartItem
            {
                ProductID = 1,
                SizeID = 3,
                Quantity = 1
            };

            context.ShoppingCartItems.Add(item);
            context.Commit();
        }
    }
}
