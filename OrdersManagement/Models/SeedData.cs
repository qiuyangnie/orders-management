using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrdersManagement.Data;
using System;
using System.Linq;

namespace OrdersManagement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrdersManagementContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OrdersManagementContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }
                else
                {
                    context.Product.AddRange(
                    new Product
                    {
                        Name = "Thomann SP-320",
                        Price = 399.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2020-2-12"),
                        ExpiredDate = DateTime.Parse("2020-2-12")
                    },

                    new Product
                    {
                        Name = "Thomann DP-26",
                        Price = 299.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2019-5-24"),
                        ExpiredDate = DateTime.Parse("2019-5-24")
                    },

                    new Product
                    {
                        Name = "Casio CDP-S100",
                        Price = 329.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2020-7-15"),
                        ExpiredDate = DateTime.Parse("2020-7-15")
                    },

                    new Product
                    {
                        Name = "Hemingway DP-501 MKII RW",
                        Price = 599.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2020-9-12"),
                        ExpiredDate = DateTime.Parse("2020-9-12")
                    },

                    new Product
                    {
                        Name = "Roland GO:PIANO",
                        Price = 399.00M,
                        Description = "61 Keys",
                        CreationDate = DateTime.Parse("2020-8-13"),
                        ExpiredDate = DateTime.Parse("2020-8-13")
                    },

                    new Product
                    {
                        Name = "DP-10X",
                        Price = 499.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2020-10-11"),
                        ExpiredDate = DateTime.Parse("2020-10-11")
                    },

                    new Product
                    {
                        Name = "ES110",
                        Price = 611.00M,
                        Description = "88 Keys",
                        CreationDate = DateTime.Parse("2020-8-13"),
                        ExpiredDate = DateTime.Parse("2020-8-13")
                    });
                    context.SaveChanges();
                }

                if (context.Customer.Any())
                {
                    return;
                }
                else
                {
                    context.Customer.AddRange(
                        new Customer
                        {
                            Fname = "Brian",
                            LName = "Murphy",
                            Address = "Cork",
                            phone = "123"
                        },

                        new Customer
                        {
                            Fname = "Ronan",
                            LName = "Murphy",
                            Address = "Cork",
                            phone = "123"
                        },

                        new Customer
                        {
                            Fname = "James",
                            LName = "Murphy",
                            Address = "Cork",
                            phone = "123"
                        },

                        new Customer
                        {
                            Fname = "David",
                            LName = "Murphy",
                            Address = "Dublin",
                            phone = "123"
                        },

                        new Customer
                        {
                            Fname = "Ian",
                            LName = "Murphy",
                            Address = "Dublin",
                            phone = "123"
                        }
                    );
                    context.SaveChanges();
                }

                if (context.Order.Any())
                {
                    return;
                }
                else
                {
                    context.Order.AddRange(
                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-12"),
                            EstimateDate = DateTime.Parse("2020-10-15"),
                            CustomerId = 1,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-10"),
                            EstimateDate = DateTime.Parse("2020-10-16"),
                            CustomerId = 1,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-9"),
                            EstimateDate = DateTime.Parse("2020-10-12"),
                            CustomerId = 2,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-7"),
                            EstimateDate = DateTime.Parse("2020-10-10"),
                            CustomerId = 2,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-2"),
                            EstimateDate = DateTime.Parse("2020-10-8"),
                            CustomerId = 3,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-1"),
                            EstimateDate = DateTime.Parse("2020-10-7"),
                            CustomerId = 3,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-10"),
                            EstimateDate = DateTime.Parse("2020-10-12"),
                            CustomerId = 3,
                        },

                        new Order
                        {
                            CreationDate = DateTime.Parse("2020-10-9"),
                            EstimateDate = DateTime.Parse("2020-10-12"),
                            CustomerId = 4,
                        }
                    );
                    context.SaveChanges();
                }

                if (context.OrderDetail.Any())
                {
                    return;
                }
                else
                {
                    context.OrderDetail.AddRange(
                        new OrderDetail
                        {
                            OrderId = 1,
                            ProductId = 3,
                            quantity = 5
                        },

                        new OrderDetail
                        {
                            OrderId = 2,
                            ProductId = 4,
                            quantity = 10
                        },

                        new OrderDetail
                        {
                            OrderId = 3,
                            ProductId = 2,
                            quantity = 5
                        },

                        new OrderDetail
                        {
                            OrderId = 4,
                            ProductId = 4,
                            quantity = 10
                        },

                        new OrderDetail
                        {
                            OrderId = 5,
                            ProductId = 3,
                            quantity = 5
                        },

                        new OrderDetail
                        {
                            OrderId = 6,
                            ProductId = 4,
                            quantity = 10
                        },

                        new OrderDetail
                        {
                            OrderId = 7,
                            ProductId = 5,
                            quantity = 1
                        },

                        new OrderDetail
                        {
                            OrderId = 8,
                            ProductId = 4,
                            quantity = 10
                        }
                    );
                    context.SaveChanges();
                }

                if (context.Status.Any())
                {
                    return;
                }
                else
                {
                    context.Status.AddRange(
                        new Status
                        {
                            OrderId = 1,
                            Name = "Processing"
                        },

                        new Status
                        {
                            OrderId = 2,
                            Name = "Delivering"
                        },

                        new Status
                        {
                            OrderId = 3,
                            Name = "Processing"
                        },

                        new Status
                        {
                            OrderId = 4,
                            Name = "Delivering"
                        },

                        new Status
                        {
                            OrderId = 5,
                            Name = "Processing"
                        },

                        new Status
                        {
                            OrderId = 6,
                            Name = "Delivering"
                        },

                        new Status
                        {
                            OrderId = 7,
                            Name = "Processing"
                        },

                        new Status
                        {
                            OrderId = 8,
                            Name = "Delivering"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
