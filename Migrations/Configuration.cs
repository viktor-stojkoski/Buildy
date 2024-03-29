using Buildy.Models;

namespace Buildy.Migrations
{
    using Buildy.Models.PC_Components.PC_Helper_Models;
    using Buildy.Models.PC_Components;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Buildy.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Buildy.Models.ApplicationDbContext context)
        {
            context.Manufacturers.AddOrUpdate(x => x.Id,
              new Manufacturer() { Id = 1, Name = "Nvdia" },
              new Manufacturer() { Id = 2, Name = "AMD" },
              new Manufacturer() { Id = 3, Name = "Intel" },
              new Manufacturer() { Id = 4, Name = "MSI" },
              new Manufacturer() { Id = 5, Name = "EVGA" },
              new Manufacturer() { Id = 6, Name = "Cooler Master" },
              new Manufacturer() { Id = 7, Name = "Deep Cool" },
              new Manufacturer() { Id = 8, Name = "NZXT" },
              new Manufacturer() { Id = 9, Name = "Samsung" },
              new Manufacturer() { Id = 10, Name = "Kingston" },
              new Manufacturer() { Id = 11, Name = "Gigabyte" },
              new Manufacturer() { Id = 12, Name = "G Skill" },
              new Manufacturer() { Id = 13, Name = "Toshiba" },
              new Manufacturer() { Id = 14, Name = "Western Digital" },
              new Manufacturer() { Id = 15, Name = "Fractial Design" },
              new Manufacturer() { Id = 16, Name = "Sharkoon" },
              new Manufacturer() { Id = 17, Name = "A-Data" },
              new Manufacturer() { Id = 18, Name = "Asus" },
              new Manufacturer() { Id = 19, Name = "Corsair" },
              new Manufacturer() { Id = 20, Name = "Noctua" }
               );

            context.MotherboardTypes.AddOrUpdate(x => x.Id,
                new MotherboardType() { Id = 1 , Name = "Atx"},
                new MotherboardType() { Id = 2, Name = "micro-Atx" },
                new MotherboardType() { Id = 3, Name = "mini-Atx" }
               );

            context.PsuEficenciess.AddOrUpdate(x => x.Id,
                new PSUEficency() { Id = 1, Name = "80 Plus Bronze" },
                new PSUEficency() { Id = 2, Name = "80 Plus Silver" },
                new PSUEficency() { Id = 3, Name = "80 Plus Gold" },
                new PSUEficency() { Id = 4, Name = "80 Plus Platinum" },
                new PSUEficency() { Id = 5, Name = "80 Plus Titanium" },
                new PSUEficency() { Id = 6, Name = "80 Plus " }
               );

            context.RamMemoryTypes.AddOrUpdate(x => x.Id,
                new RAMMemoryType() { Id = 1, Name = "DDR 3" },
                new RAMMemoryType() { Id = 2, Name = "DDR 4" },
                new RAMMemoryType() { Id = 3, Name = "GDDR 4" },
                new RAMMemoryType() { Id = 4, Name = "GDDR 5" },
                new RAMMemoryType() { Id = 5, Name = "GDDR 6" }
               );

            context.Sockets.AddOrUpdate(x => x.Id,
                new Socket() { Id = 1, Name = "LGA" },
                new Socket() { Id = 2, Name = "PGA" }
               );

            context.StorageTypes.AddOrUpdate(x => x.Id,
                new StorageType() { Id = 1, Name = "HDD"},
                new StorageType() { Id = 2, Name = "SSD" },
                new StorageType() { Id = 3, Name = "M.2" }
               );

            context.Chipsets.AddOrUpdate(x => x.Id,
                new Chipset() { Id = 1, Name = "AM4" },
                new Chipset() { Id = 2, Name = "AM3" },
                new Chipset() { Id = 3, Name = "LGA 1156" },
                new Chipset() { Id = 4, Name = "LGA 1155" },
                new Chipset() { Id = 5, Name = "LGA 1150" },
                new Chipset() { Id = 6, Name = "LGA 1366" },
                new Chipset() { Id = 7, Name = "LGA 1151" }
               );

            context.CoolingTypes.AddOrUpdate(x => x.Id,
                new CoolingType() {Id = 1, Name = "Liquid" },
                new CoolingType() { Id = 2, Name = "Air" }
                );

            context.Cpus.AddOrUpdate(x => x.Id,
                new CPU() { Id = 1 , Name = "Ryzen 5 3600" , Cores = 6 , Threads = 12 , Frequency =  3, Cache = 32 , CoolingSolution = true , ManufacturerId = 2 , ChipsetId = 1  , Price = 193 , ImageURL= "https://cdn.pcpartpicker.com/static/forever/images/product/c7baf2c9c9cc15ae23adb24c2f4316fc.1600.jpg" },
                new CPU() { Id = 2, Name = "Ryzen 7 3700X", Cores = 8, Threads = 16, Frequency = 4, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 350 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/23cd3adfd50037c1b44d6d53edb15248.1600.jpg" },
                new CPU() { Id = 3, Name = "Ryzen 9 3900X", Cores = 12, Threads = 24, Frequency = 4, Cache = 64, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 500  , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/14adcd1fc88ebf386b746037c966b6af.1600.jpg" },
                new CPU() { Id = 4, Name = "Core i7-9700K", Cores = 8, Threads = 16, Frequency = 4.9f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 340 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 5, Name = "Core i9-9900K", Cores = 8, Threads = 16, Frequency = 5, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 500 , ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41EDFtP5hpL.jpg" },
                new CPU() { Id = 6, Name = "Ryzen 5 2600", Cores = 6, Threads = 12, Frequency = 3.4f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/55aea2dd64e2e3a3e3b1d678048d8d76.1600.jpg" },
                new CPU() { Id = 7, Name = "Core i5-9400F", Cores = 6, Threads = 12, Frequency = 2.9f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 140, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3b2d769c28b9890779f87a7568887dfc.1600.jpg" },
                new CPU() { Id = 8, Name = "Ryzen 5 2600X", Cores = 6, Threads = 12, Frequency = 3.6f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 150, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/55aea2dd64e2e3a3e3b1d678048d8d76.1600.jpg" },
                new CPU() { Id = 9, Name = "Ryzen 7 2700X", Cores = 8, Threads = 16, Frequency = 4.3f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 200, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/4e84967ef18c9b42e543b58c836d73ef.1600.jpg" },
                new CPU() { Id = 10, Name = "Ryzen 3 2200G", Cores = 4, Threads = 8, Frequency = 3.5f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 80, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ad2e56d88c77de3053dcc5dada363f58.1600.jpg" },
                new CPU() { Id = 11, Name = "Ryzen 5 3600X", Cores = 6, Threads = 12, Frequency = 3.8f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 240, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/c7baf2c9c9cc15ae23adb24c2f4316fc.1600.jpg" },
                new CPU() { Id = 12, Name = "i7-8700K", Cores = 6, Threads = 12, Frequency = 3.7f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 350, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 13, Name = "Ryzen 7 2700", Cores = 8, Threads = 16, Frequency = 4.1f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 180, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/4e84967ef18c9b42e543b58c836d73ef.1600.jpg" },
                new CPU() { Id = 14, Name = "Ryzen 5 3400G 3.7", Cores = 4, Threads = 8, Frequency = 3.7f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 140, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/43e2914b40ccb9ab7ce39eb656db3b44.1600.jpg" },
                new CPU() { Id = 15, Name = "Core i5-9600K", Cores = 6, Threads = 12, Frequency = 3.7f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 230, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/33f96aec821c5c10f4b1fd636a7d1881.1600.jpg" },
                new CPU() { Id = 16, Name = "Core i3-9100F", Cores = 4, Threads = 8, Frequency = 4.2f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 170, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/0d74fb44f832ad674549787311aafa0f.1600.jpg" },
                new CPU() { Id = 17, Name = "Core i7-6700K", Cores = 4, Threads = 8, Frequency = 4.0f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 170, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/614a9c530cce56d1fafbc5ba97920ab1.1600.jpg" },
                new CPU() { Id = 18, Name = "Core i5-8400", Cores = 6, Threads = 12, Frequency = 2.8f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 140, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/515kqMHI1IL.jpg" },
                new CPU() { Id = 19, Name = "i7-7700K", Cores = 4, Threads = 8, Frequency = 4.2f, Cache = 16, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 330, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 20, Name = "Ryzen 7 1700X", Cores = 8, Threads = 16, Frequency = 3.4f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 165, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/4e84967ef18c9b42e543b58c836d73ef.1600.jpg" },
                new CPU() { Id = 21, Name = "Core i7-9700", Cores = 8, Threads = 16, Frequency = 3, Cache = 14, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 330, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 22, Name = "Core i5-9400", Cores = 6, Threads = 12, Frequency = 2.9f, Cache = 16, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 170, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/64bf363daabaca441f6b8f07b54005cc.1600.jpg" },
                new CPU() { Id = 23, Name = "Core i5-8600K", Cores = 6, Threads = 12, Frequency = 3.9f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 260, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/64bf363daabaca441f6b8f07b54005cc.1600.jpg" },
                new CPU() { Id = 24, Name = "Core i3-8100F", Cores = 4, Threads = 8, Frequency = 3.6f, Cache = 32, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 120, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/0d74fb44f832ad674549787311aafa0f.1600.jpg" },
                new CPU() { Id = 25, Name = "Core i5-6600K", Cores = 4, Threads = 8, Frequency = 3.5f, Cache = 16, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 220, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/64bf363daabaca441f6b8f07b54005cc.1600.jpg" },
                new CPU() { Id = 26, Name = "Threadripper 2950X", Cores = 16, Threads = 32, Frequency = 3.5f, Cache = 64, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 165, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/09734bbf8632da3f135375bbb4ea6f94.1600.jpg" },
                new CPU() { Id = 27, Name = "Core i7-7700", Cores = 4, Threads = 8, Frequency = 3.6f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 300, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 28, Name = "Core i5-9600KF", Cores = 6, Threads = 12, Frequency = 3.7f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 220, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/658de8a85dd1c0af16b8f020ed5bb2da.1600.jpg" },
                new CPU() { Id = 29, Name = "Core i5-7400", Cores = 4, Threads = 8, Frequency = 3f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 180, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/658de8a85dd1c0af16b8f020ed5bb2da.1600.jpg" },
                new CPU() { Id = 30, Name = "Ryzen 7 1700", Cores = 8, Threads = 16, Frequency = 3f, Cache = 32, CoolingSolution = true, ManufacturerId = 2, ChipsetId = 1, Price = 224, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/4e84967ef18c9b42e543b58c836d73ef.1600.jpg" },
                new CPU() { Id = 31, Name = "Core i7-7700", Cores = 4, Threads = 8, Frequency = 3.4f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 205, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3760e89d1820da393f084e2c18a62e3b.1600.jpg" },
                new CPU() { Id = 32, Name = "Core i7-8086K", Cores = 6, Threads = 12, Frequency = 4f, Cache = 12, CoolingSolution = true, ManufacturerId = 3, ChipsetId = 7, Price = 350, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/452fefc7712153b364268a36d1674efb.1600.jpg" }
                );

            context.Motherboards.AddOrUpdate(x => x.Id,
                new Motherboard() { Id = 1 , Name = "B450 TOMAHAWK" , ChipsetId = 1 , DimmSlots = 4 , MotherboardTypeId = 1 , ManufacturerId = 4 , MemorySupport = 64 , SocketId = 1 , Price = 115 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/76a05556b1231db294600c672f605747.1600.jpg" },
                new Motherboard() { Id = 2, Name = "ROG STRIX B450-F GAMING", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 64, SocketId = 1, Price = 120, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ae3eca9a74b37b6a2dafadcc948c208d.1600.jpg" },
                new Motherboard() { Id = 3, Name = "B450M DS3H", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 2, ManufacturerId = 11, MemorySupport = 64, SocketId = 1, Price = 73, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/75eae1d6254dc2bd453a2cf64b601ede.1600.jpg" },
                new Motherboard() { Id = 4, Name = "ROG STRIX Z390-E", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 64, SocketId = 1, Price = 115, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/51mDZNleLaL.jpg" },
                new Motherboard() { Id = 5, Name = "Z390-A PRO", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 64, SocketId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/fcc113830e84371c4f0f83c5ed5f4ae4.1600.jpg" },
                new Motherboard() { Id = 6, Name = "B450 Gaming Pro", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 64, SocketId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a6ae20785466eef236198522ad3a4fa5.1600.jpg" },
                new Motherboard() { Id = 7, Name = "B450M MORTAR TITANIUM", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 2, ManufacturerId = 4, MemorySupport = 64, SocketId = 1, Price = 70, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/00d01d92abc6b855882834ca3a480d98.1600.jpg" },
                new Motherboard() { Id = 8, Name = "GA-AB350-GAMING 3", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 128, SocketId = 1, Price = 700, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/51IFLBU8jpL.jpg" },
                new Motherboard() { Id = 9, Name = "X570 AORUS XTREME", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 11, MemorySupport = 64, SocketId = 1, Price = 137, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/7d5e0519ee3f05ab4720ae4d15ea14c1.1600.jpg" },
                new Motherboard() { Id = 10, Name = "ROG STRIX X470-I GAMING", ChipsetId = 1, DimmSlots = 2, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 32, SocketId = 1, Price = 105, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/2d6aec01983abcfd48c2d450cc27ce1b.1600.jpg" },
                new Motherboard() { Id = 11, Name = "PRIME B450-PLUS", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 64, SocketId = 1, Price = 200, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a6ae20785466eef236198522ad3a4fa5.1600.jpg" },
                new Motherboard() { Id = 12, Name = "MEG X570 ACE", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 128, SocketId = 1, Price = 80, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ef675852c52dc65806e9e2edf192436c.1600.jpg" },
                new Motherboard() { Id = 13, Name = "ROG STRIX B360-I GAMING", ChipsetId = 7, DimmSlots = 2, MotherboardTypeId = 3, ManufacturerId = 18, MemorySupport = 32, SocketId = 1, Price = 110, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51k0l-O2gqL.jpg" },
                new Motherboard() { Id = 14, Name = "MPG Z390 GAMING EDGE AC", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 3, ManufacturerId = 4, MemorySupport = 128, SocketId = 1, Price = 180, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/51DZf-KOjZL.jpg" },
                new Motherboard() { Id = 15, Name = "PG Z390 GAMING PRO CARBON", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 128, SocketId = 1, Price = 185, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/91d7402ac6c9d16afc48f31c5165cf3d.1600.jpg" },
                new Motherboard() { Id = 16, Name = "Z390 AORUS ULTRA ATX", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 64, SocketId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a6ae20785466eef236198522ad3a4fa5.1600.jpg" },    
                new Motherboard() { Id = 17, Name = "ROG MAXIMUS XI FORMULA", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 128, SocketId = 1, Price = 425, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51a%2BH%2BWRXPL.jpg" },
                new Motherboard() { Id = 18, Name = "MPG Z390 GAMING PRO CARBON AC", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 128, SocketId = 1, Price = 200, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/cd20ba2d9fea29fc03b304c320510e7d.1600.jpg" },
                new Motherboard() { Id = 19, Name = "B360 HD3", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 11, MemorySupport = 64, SocketId = 1, Price = 95, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/11ea676aa40218876173f6fa1020ba00.1600.jpg" },
                new Motherboard() { Id = 20, Name = "PRIME Z270-P", ChipsetId = 7, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 64, SocketId = 1, Price = 145, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91mMGp3pTPL._SX466_.jpg" },
                new Motherboard() { Id = 21, Name = "B450I GAMING PLUS AC", ChipsetId = 1, DimmSlots = 2, MotherboardTypeId = 3, ManufacturerId = 4, MemorySupport = 32, SocketId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/813923da0e8510b2adaec8e131b8c7fd.1600.jpg" },
                new Motherboard() { Id = 22, Name = "PRIME X570-PRO", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 128, SocketId = 1, Price = 240, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/b06a90d7ec5a485121a21751cdc3d9b9.1600.jpg" },
                new Motherboard() { Id = 23, Name = "ROG Strix X570-E Gaming", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 128, SocketId = 1, Price = 320, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8edda8b2608b4fe4e5c3777f9e6df4fd.1600.jpg" },
                new Motherboard() { Id = 24, Name = "TUF GAMING X570-PLUS", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 18, MemorySupport = 64, SocketId = 1, Price = 190, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/c96321a1e039a1f7fd1bc917c5ae72b7.1600.jpg" },
                new Motherboard() { Id = 25, Name = "MPG Z390 GAMING PLUS", ChipsetId = 1, DimmSlots = 4, MotherboardTypeId = 1, ManufacturerId = 4, MemorySupport = 64, SocketId = 1, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a6ae20785466eef236198522ad3a4fa5.1600.jpg" }
                );

            context.Cases.AddOrUpdate(x => x.Id,
                new Case() { Id = 1 , Name = "H510 Elite" , Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4 , ManufacturerId = 8 , ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2428/large_b2feaa953e1c78d9.jpg" , Price  = 170 , MotherboardTypeId = 1} ,
                new Case() { Id = 2, Name = "H710i", Dimensions = "W: 230mm H: 516mm D: 494mm", FanSupport = 5, ManufacturerId = 8, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2462/large_caaa8ad6b19de81c.jpg", Price = 200, MotherboardTypeId = 1 } ,
                new Case() { Id = 3, Name = "H500", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, ImageURL = "https://www.scan.co.uk/images/products/2948278-a.jpg", Price = 75, MotherboardTypeId = 1 } ,
                new Case() { Id = 4, Name = "H210i", Dimensions = "	W: 210mm H: 349mm D: 372mm", FanSupport = 4, ManufacturerId = 8, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2262/large_2fbdddad9178e815.jpg", Price = 120, MotherboardTypeId = 2 } ,
                new Case() { Id = 5, Name = "H510", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, Price = 80, MotherboardTypeId = 1, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2385/large_119c49cc79b97b94.jpg" },
                new Case() { Id = 6, Name = "Obsidian 500D RGB SE", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 6, ManufacturerId = 19, Price = 280, MotherboardTypeId = 1, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41tzS2mBxyL.jpg" },
                new Case() { Id = 7, Name = "200R", Dimensions = "W: 497mm H: 210 mm D: 429 mm", FanSupport = 4, ManufacturerId = 19, Price = 70, MotherboardTypeId = 1, ImageURL = "http://ecx.images-amazon.com/images/I/41qTCywCUvL.jpg" },
                new Case() { Id = 8, Name = "MasterBox Pro 5 RGB", Dimensions = "W: 500mm H: 223mm D: 475mm", FanSupport = 5, ManufacturerId = 6, Price = 95, MotherboardTypeId = 1, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41Foz%2B%2BKvmL.jpg" },
                new Case() { Id = 9, Name = "Master MasterCase H500", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 6, Price = 120, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8058a5658a08dbd68ed2f88ab8e70df7.1600.jpg" },
                new Case() { Id = 10, Name = "SPEC-DELTA RGB", Dimensions = "W: 440mm H: 210mm D: 450mm", FanSupport = 6, ManufacturerId = 19, Price = 90, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/b35ad4944a6207c0e307154137834af6.1600.jpg" },
                new Case() { Id = 11, Name = "Master MasterBox Lite 5", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 6, Price = 55, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/17fa8a2537f9c8b4daed00429246ba26.1600.jpg" },
                new Case() { Id = 12, Name = "Crystal Series 680X RGB", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 6, ManufacturerId = 19, Price = 250, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/6c64c4140c5b621d9e2177d0498cd43a.1600.jpg" },
                new Case() { Id = 13, Name = "MasterCase H500M", Dimensions = "W: 248mm H: 544mm D: 546mm", FanSupport = 4, ManufacturerId = 6, Price = 200, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/3b22338d08cddc21f3cd6150ec431a31.1600.jpg" },
                new Case() { Id = 14, Name = "1000D", Dimensions = "W: 248mm H: 544mm D: 546mm", FanSupport = 6, ManufacturerId = 19, Price = 500, MotherboardTypeId = 1, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a7a0359ad235cd8cb78730230deb4666.1600.jpg" },
                new Case() { Id = 15, Name = "Master MasterBox Q300P", Dimensions = "W: 230mm H: 455mm D: 458mm", FanSupport = 4, ManufacturerId = 6, Price = 92, MotherboardTypeId = 2, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d5515cc352c490650ff658bd3608857f.1600.jpg" },
                new Case() { Id = 16, Name = "H400i", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, Price = 150, MotherboardTypeId = 2, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/6eefe518c7238492e201cad2e26ac36a.1600.jpg" },
                new Case() { Id = 17, Name = "H400", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, Price = 115, MotherboardTypeId = 2, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/6eefe518c7238492e201cad2e26ac36a.1600.jpg" },
                new Case() { Id = 18, Name = "SILENCIO S400", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 6, Price = 90, MotherboardTypeId = 2, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/7c65bcaf0b488afa25432eac27991ce0.1600.jpg" },
                new Case() { Id = 19, Name = "Manta", Dimensions = "W: 210mm H: 335mm D: 328mm", FanSupport = 2, ManufacturerId = 8, Price = 75, MotherboardTypeId = 3, ImageURL = "http://ecx.images-amazon.com/images/I/41s6YuZbkKL.jpg" },
                new Case() { Id = 20, Name = "Elite 130", Dimensions = "W: 210mm H: 235mm D: 228mm", FanSupport = 4, ManufacturerId = 6, Price = 100, MotherboardTypeId = 3, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/f23d251fb57394eedf211f122d84e934.1600.jpg" }
                );

            context.Gpus.AddOrUpdate(x => x.Id,
                new GPU() { Id = 1, Name = "RTX 2080 Black", ManufacturerId = 5, RAMSize = 8, Price = 675, Frequency = 1515, Timing = "1", MemoryClock = 14000, RAMTypeId = 5 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8f9aabc24178caf70135e2e6dc2f5445.1600.jpg" } ,
                new GPU() { Id = 2, Name = "RTX 2080 Ti Black", ManufacturerId = 5, RAMSize = 11, Price = 1070, Frequency = 1350, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8f9aabc24178caf70135e2e6dc2f5445.1600.jpg" },
                new GPU() { Id = 3, Name = "RTX 2080 Ti ULTRA GAMING", ManufacturerId = 5, RAMSize = 11, Price = 1400, Frequency = 1755, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/03524d3eecccc31527c359f9de79d9c7.1600.jpg" },
                new GPU() { Id = 4, Name = "RTX 2080 Ti ROG Strix Gaming OC", ManufacturerId = 18, RAMSize = 11, Price = 1280, Frequency = 1350, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/0174f5005fe9f34decdf2d379bfe7221.1600.jpg" },
                new GPU() { Id = 5, Name = "RTX 2080 ROG Strix Gaming", ManufacturerId = 18, RAMSize = 8, Price = 770, Frequency = 1515, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d15b18b5b4b518256c4b8003672424c7.1600.jpg" },
                new GPU() { Id = 6, Name = "RTX 2060 6 GB STRIX GAMING OC", ManufacturerId = 18, RAMSize = 6, Price = 400, Frequency = 1365, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41HBsLEE01L.jpg" },
                new GPU() { Id = 8, Name = "GeForce RTX 2060 VENTUS OC", ManufacturerId = 6, RAMSize = 6, Price = 350, Frequency = 1300, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/e623089ba2b3010c09c7015f9538a311.1600.jpg" },
                new GPU() { Id = 9, Name = "GeForce RTX 2070 8 GB STRIX GAMING OC", ManufacturerId = 18, RAMSize = 8, Price = 420, Frequency = 1410, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51%2B5qM9Ia3L.jpg" },
                new GPU() { Id = 10, Name = "GeForce RTX 2070 SUPER 8 GB GAMING X TRIO", ManufacturerId = 6, RAMSize = 8, Price = 580, Frequency = 1450, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ca23ff3065e60b6a75ef9443e25b2a31.1600.jpg" },
                new GPU() { Id = 11, Name = "GeForce RTX 2070 SUPER 8 GB XC GAMING", ManufacturerId = 5, RAMSize = 8, Price = 540, Frequency = 1600, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41lKk8cJ-JL.jpg" },
                new GPU() { Id = 12, Name = "GeForce GTX 1080 Ti 11 GB GAMING X", ManufacturerId = 6, RAMSize = 11, Price = 650, Frequency = 1400, Timing = "1", MemoryClock = 14000, RAMTypeId = 4, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/188bc2e653c9415cd65739ccbb223943.1600.jpg" },
                new GPU() { Id = 13, Name = "GeForce GTX 1080 Ti 11 GB STRIX GAMING", ManufacturerId = 18, RAMSize = 11, Price = 700, Frequency = 1450, Timing = "1", MemoryClock = 14000, RAMTypeId = 4, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81a2aBCgDML._SX466_.jpg" },
                new GPU() { Id = 14, Name = "GeForce GTX 1070 Ti 8 GB SC GAMING ACX 3.0 Black Edition", ManufacturerId = 5, RAMSize = 8, Price = 550, Frequency = 1400, Timing = "1", MemoryClock = 14000, RAMTypeId = 4, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51PLpT-02fL.jpg" },
                new GPU() { Id = 15, Name = "GeForce GTX 1070 8 GB G1", ManufacturerId = 11, RAMSize = 8, Price = 500, Frequency = 1380, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "http://ecx.images-amazon.com/images/I/41lXcLke4GL.jpg" },
                new GPU() { Id = 16, Name = "Radeon RX 580 8 GB ARMOR OC", ManufacturerId = 6, RAMSize = 8, Price = 200, Frequency = 1300, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d53db7190559b6287a4ff549f3bf5904.1600.jpg" },
                new GPU() { Id = 17, Name = "Radeon RX 580 8 GB ROG STRIX", ManufacturerId = 18, RAMSize = 8, Price = 350, Frequency = 1400, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91q5KBUBiaL._SX425_.jpg" },
                new GPU() { Id = 18, Name = "Radeon RX 580 8 GB Gaming 8G", ManufacturerId = 11, RAMSize = 8, Price = 350, Frequency = 1380, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/410U1dG4GtL.jpg" },
                new GPU() { Id = 19, Name = "Radeon RX 5700 XT 8 GB GAMING OC", ManufacturerId = 11, RAMSize = 8, Price = 420, Frequency = 1400, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/1b6084a197c46a295eb03b6ed062eda2.1600.jpg" },
                new GPU() { Id = 20, Name = "Radeon RX 5700 8 GB MECH OC", ManufacturerId = 6, RAMSize = 8, Price = 360, Frequency = 1380, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/f35fedb0450427dec520c5efb19d9c46.1600.jpg" },
                new GPU() { Id = 21, Name = "GeForce GTX 1050 Ti 4 GB", ManufacturerId = 6, RAMSize = 4, Price = 150, Frequency = 1350, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/05cdbb665a59f5f73dcaf1a414c8ad04.1600.jpg" },
                new GPU() { Id = 22, Name = "GeForce GTX 1050 Ti 4 GB GAMING X 4G", ManufacturerId = 6, RAMSize = 4, Price = 170, Frequency = 1380, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/2fab0ac0a13fef6a74ca8171b62e28dc.1600.jpg" },
                new GPU() { Id = 23, Name = "GeForce GTX 1050 2 GB", ManufacturerId = 6, RAMSize = 2, Price = 100, Frequency = 1300, Timing = "1", MemoryClock = 8000, RAMTypeId = 4, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d622ea150f25f44d91631a29c59f42a8.1600.jpg" }
                );

            context.Psus.AddOrUpdate(x => x.Id,
                new PSU() { Id = 1 , Name = "CXM" , Capacity = 550 , Modular = false , EfficiencyId = 1 , ManufacturerId = 18 ,Price = 70 ,ImageURL = "http://ecx.images-amazon.com/images/I/51RxdsALapL.jpg" },
                new PSU() { Id = 2, Name = "SuperNOVA G3", Capacity = 750, Modular = true, EfficiencyId = 3, ManufacturerId = 5, Price = 127, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/2a2172d1f17661103de901f43d831187.1600.jpg" },
                new PSU() { Id = 3, Name = "RMx (2018)", Capacity = 650, Modular = true, EfficiencyId = 3, ManufacturerId = 18, Price = 85, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51icxwzI9VL.jpg" },
                new PSU() { Id = 4, Name = "MASTERWATT MAKER MIJ", Capacity = 1200, Modular = true, EfficiencyId = 5, ManufacturerId = 6, Price = 200, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/244afeb4bd3917774842c887571a9803.1600.jpg" },
                new PSU() { Id = 6, Name = "Master V", Capacity = 1000, Modular = true, EfficiencyId = 4, ManufacturerId = 6, Price = 180, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/c28253b1b63474d96ab2f28ff5cdcdce.1600.jpg" },
                new PSU() { Id = 7, Name = "MasterWatt", Capacity = 750, Modular = true, EfficiencyId = 1, ManufacturerId = 6, Price = 90, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d6645bc4330f5a00dabba3d69728af42.1600.jpg" },
                new PSU() { Id = 8, Name = "RMx (2018) 750 W", Capacity = 750, Modular = true, EfficiencyId = 3, ManufacturerId = 19, Price = 120, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/513mVXq9TiL.jpg" },
                new PSU() { Id = 9, Name = "RMx (2018) 850 W", Capacity = 850, Modular = true, EfficiencyId = 3, ManufacturerId = 19, Price = 125, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51lUqysCuDL.jpg" },
                new PSU() { Id = 10, Name = "BQ", Capacity = 600, Modular = true, EfficiencyId = 1, ManufacturerId = 5, Price = 50, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/512voawCsuL.jpg" },
                new PSU() { Id = 11, Name = "CXM (2015) 450 W", Capacity = 450, Modular = false, EfficiencyId = 1, ManufacturerId = 19, Price = 45, ImageURL = "http://ecx.images-amazon.com/images/I/51ZqerxDFcL.jpg" },
                new PSU() { Id = 12, Name = "1600 W 80+ Titanium Certified", Capacity = 1600, Modular = true, EfficiencyId = 5, ManufacturerId = 19, Price = 450, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/1d57cf53a1289e4dfff1aed9b1cc272a.1600.jpg" },
                new PSU() { Id = 13, Name = "500 W 80+", Capacity = 500, Modular = false, EfficiencyId = 6, ManufacturerId = 5, Price = 40, ImageURL = "http://ecx.images-amazon.com/images/I/51PiQrWaNjL.jpg" },
                new PSU() { Id = 14, Name = "SuperNOVA G1+ 650 W", Capacity = 650, Modular = true, EfficiencyId = 3, ManufacturerId = 5, Price = 100, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/cef75cc13e5787d7c29760e9087905f4.1600.jpg" },
                new PSU() { Id = 15, Name = "RM (2019) 750 W", Capacity = 750, Modular = true, EfficiencyId = 3, ManufacturerId = 19, Price = 120, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/02951377c9eed1e21fc3d8ba6092717e.1600.jpg" },
                new PSU() { Id = 16, Name = "SF 600 W", Capacity = 600, Modular = true, EfficiencyId = 4, ManufacturerId = 19, Price = 120, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41qUzlhfWKL.jpg" },
                new PSU() { Id = 17, Name = "1200 W 80+", Capacity = 1200, Modular = true, EfficiencyId = 4, ManufacturerId = 18, Price = 300, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/5b4d3a0c8ba785ed560565371fb5b0a6.1600.jpg" },
                new PSU() { Id = 18, Name = "BQ", Capacity = 750, Modular = true, EfficiencyId = 1, ManufacturerId = 6, Price = 60, ImageURL = "http://ecx.images-amazon.com/images/I/51J5s4nQnWL.jpg" },
                new PSU() { Id = 19, Name = "CXM 750 W ", Capacity = 750, Modular = true, EfficiencyId = 1, ManufacturerId = 19, Price = 90, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/23a8f923c23d6de30026d889136bf175.1600.jpg" },
                new PSU() { Id = 20, Name = "VS", Capacity = 450, Modular = false, EfficiencyId = 6, ManufacturerId = 19, Price = 35, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51pKHarWxGL.jpg" },
                new PSU() { Id = 21, Name = "RMx White (2018)", Capacity = 750, Modular = true, EfficiencyId = 3, ManufacturerId = 19, Price = 130, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/78afeb3cab692533f7fad2eba2975750.1600.jpg" }
                );

            context.Rams.AddOrUpdate(x => x.Id,
                new RAM() { Id = 1 , Name = "Vengeance LPX" , MemoryTypeId = 2 , ManufacturerId = 19 , Frequency = 2400 , Size = 8 , Timing = "none" , Price = 38 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ef1c9d46308283f227a0ba51e4179ff1.1600.jpg" },
                new RAM() { Id = 2, Name = "Vengeance LPX", MemoryTypeId = 2, ManufacturerId = 19, Frequency = 3000, Size = 16, Timing = "16-20-20-38", Price = 73, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/897d32aa11f4462641daa6c62d1322f5.1600.jpg" },
                new RAM() { Id = 3, Name = "Ripjaws V Series ", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 2400, Size = 16, Timing = "none", Price = 66, ImageURL = "http://ecx.images-amazon.com/images/I/41XcDGwMsBL.jpg" },
                new RAM() { Id = 4, Name = "Ripjaws V", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 3600, Size = 16, Timing = "19-20-20-40", Price = 78, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/72816e43251cd35c4b3f598eb8fc16e0.1600.jpg" },
                new RAM() { Id = 5, Name = "HyperX Predator", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 2666, Size = 8, Timing = "none", Price = 43, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/f25ee4f0e1776a3d15c2286d35feeb8c.1600.jpg" },
                new RAM() { Id = 6, Name = "HyperX Fury", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 2666, Size = 8, Timing = "none", Price = 40, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/14c2a7f4a3a06e1d0e81f25fb7c2a42a.1600.jpg" },
                new RAM() { Id = 7, Name = "HyperX Fury", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 3200, Size = 8, Timing = "none", Price = 55, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/14c2a7f4a3a06e1d0e81f25fb7c2a42a.1600.jpg" },
                new RAM() { Id = 8, Name = "Vengeance", MemoryTypeId = 2, ManufacturerId = 19, Frequency = 1866, Size = 8, Timing = "none", Price = 35, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/6a3b0f143de7182ae0c995ac4b357d19.med.1600.jpg" },
                new RAM() { Id = 9, Name = "HyperX Fury", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 3200, Size = 16, Timing = "none", Price = 96, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d39bd7cede4c3af6acc60c517645ab7c.1600.jpg" },
                new RAM() { Id = 10, Name = "HyperX Fury", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 2400, Size = 8, Timing = "none", Price = 40, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/14c2a7f4a3a06e1d0e81f25fb7c2a42a.1600.jpg" },
                new RAM() { Id = 11, Name = "Vengeance LPX", MemoryTypeId = 2, ManufacturerId = 19, Frequency = 3000, Size = 32, Timing = "none", Price = 170, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/7c04b120a9d93500b574655bd99b93aa.1600.jpg" },
                new RAM() { Id = 12, Name = "Ripjaws V", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 3600, Size = 8, Timing = "none", Price = 48, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/c0fe82c5c039e038cd14a5833293d591.1600.jpg" },
                new RAM() { Id = 13, Name = "32 GB", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 2133, Size = 32, Timing = "none", Price = 700, ImageURL = "http://ecx.images-amazon.com/images/I/41mMZ13YGfL.jpg" },
                new RAM() { Id = 14, Name = "Vengeance LPX 8 GB", MemoryTypeId = 2, ManufacturerId = 19, Frequency = 2666, Size = 8, Timing = "none", Price = 40, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/9b6014a1b219eb2ba07ec3d12c0c639f.1600.jpg" },
                new RAM() { Id = 15, Name = "Ripjaws V", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 3600, Size = 16, Timing = "none", Price = 80, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/72816e43251cd35c4b3f598eb8fc16e0.1600.jpg" },
                new RAM() { Id = 16, Name = "HyperX Fury Black", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 2133, Size = 8, Timing = "none", Price = 80, ImageURL = "http://ecx.images-amazon.com/images/I/41Vkj6Q5vtL.jpg" },
                new RAM() { Id = 17, Name = "HyperX Fury Blue", MemoryTypeId = 2, ManufacturerId = 10, Frequency = 1600, Size = 8, Timing = "none", Price = 30, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/420350537fa9e0e49b1e491fe9c4810d.1600.jpg" },
                new RAM() { Id = 18, Name = "Ripjaws V Series 8 GB", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 2400, Size = 8, Timing = "none", Price = 33, ImageURL = "http://ecx.images-amazon.com/images/I/41UyfTQGqiL.jpg" },
                new RAM() { Id = 19, Name = "Aegis", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 2666, Size = 16, Timing = "none", Price = 47, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/0c6edb82799a2627d1ea10e7cba3abfb.1600.jpg" },
                new RAM() { Id = 20, Name = "Aegis", MemoryTypeId = 2, ManufacturerId = 12, Frequency = 2666, Size = 8, Timing = "none", Price = 38, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/cecd6ed1bee7da70050efd4881c95968.1600.jpg" }
                );

            context.Storages.AddOrUpdate(x => x.Id,
                new Storage() { Id = 1 , Name = "660p Series" , ManufacturerId = 3 , Capacity = 2048 , ReadingSpeed = 800 , WritingSpeed = 700 , TypeId = 3 , Price = 185 , ImageURL = "https://images-fe.ssl-images-amazon.com/images/I/41-UBTlEZwL.jpg" },
                new Storage() { Id = 2, Name = "Caviar Blue", ManufacturerId = 14, Capacity = 1000, ReadingSpeed = 150, WritingSpeed = 120, TypeId = 1, Price = 43, ImageURL = "http://ecx.images-amazon.com/images/I/51fbLQLVJFL.jpg" },
                new Storage() { Id = 3, Name = "860 Evo", ManufacturerId = 9, Capacity = 500, ReadingSpeed = 500, WritingSpeed = 420, TypeId = 2, Price = 75, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41JX1N9gi1L.jpg" },
                new Storage() { Id = 4, Name = "970 Evo", ManufacturerId = 9, Capacity = 500, ReadingSpeed = 900, WritingSpeed = 750, TypeId = 3, Price = 90, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 5, Name = "A400", ManufacturerId = 10, Capacity = 240, ReadingSpeed = 400, WritingSpeed = 300, TypeId = 2, Price = 32, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/97e2bd828644767c8a80b71f8cb14743.1600.jpg" },
                new Storage() { Id = 6, Name = "970 Evo", ManufacturerId = 9, Capacity = 1024, ReadingSpeed = 900, WritingSpeed = 750, TypeId = 3, Price = 170, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 7, Name = "A400", ManufacturerId = 9, Capacity = 250, ReadingSpeed = 500, WritingSpeed = 400, TypeId = 2, Price = 31, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41UKoJx2tZL.jpg" },
                new Storage() { Id = 8, Name = "Blue", ManufacturerId = 14, Capacity = 500, ReadingSpeed = 300, WritingSpeed = 250, TypeId = 3, Price = 65, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/5d75e5e4274a02ca8924d7c4d2a575b2.1600.jpg" },
                new Storage() { Id = 9, Name = "660p Series", ManufacturerId = 3, Capacity = 2048, ReadingSpeed = 500, WritingSpeed = 350, TypeId = 3, Price =190, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/72ac6b04347d22c2592029d4a49bc5ed.1600.jpg" },
                new Storage() { Id = 10, Name = "660p Series", ManufacturerId = 3, Capacity = 512, ReadingSpeed = 500, WritingSpeed = 350, TypeId = 3, Price = 62, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/72ac6b04347d22c2592029d4a49bc5ed.1600.jpg" },
                new Storage() { Id = 11, Name = "970 Evo Plus", ManufacturerId = 9, Capacity = 500, ReadingSpeed = 550, WritingSpeed = 450, TypeId = 3, Price = 110, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 12, Name = "970 Evo Plus", ManufacturerId = 9, Capacity = 250, ReadingSpeed = 550, WritingSpeed = 450, TypeId = 3, Price = 62, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 13, Name = "A400", ManufacturerId = 9, Capacity = 480, ReadingSpeed = 500, WritingSpeed = 400, TypeId = 2, Price = 52, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41UKoJx2tZL.jpg" },
                new Storage() { Id = 14, Name = "970 Evo Plus", ManufacturerId = 9, Capacity = 1024, ReadingSpeed = 550, WritingSpeed = 450, TypeId = 3, Price = 215, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 15, Name = "970 Evo Plus", ManufacturerId = 9, Capacity = 2048, ReadingSpeed = 550, WritingSpeed = 450, TypeId = 3, Price = 450, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" },
                new Storage() { Id = 16, Name = "860 Evo", ManufacturerId = 9, Capacity = 250, ReadingSpeed = 500, WritingSpeed = 420, TypeId = 2, Price = 54, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41JX1N9gi1L.jpg" },
                new Storage() { Id = 17, Name = "860 Evo", ManufacturerId = 9, Capacity = 4000, ReadingSpeed = 500, WritingSpeed = 420, TypeId = 2, Price = 900, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41JX1N9gi1L.jpg" },
                new Storage() { Id = 18, Name = "860 Evo", ManufacturerId = 9, Capacity = 2048, ReadingSpeed = 500, WritingSpeed = 420, TypeId = 2, Price = 280, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41JX1N9gi1L.jpg" },
                new Storage() { Id = 19, Name = "Blue", ManufacturerId = 14, Capacity = 1024, ReadingSpeed = 300, WritingSpeed = 250, TypeId = 3, Price = 110, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/5d75e5e4274a02ca8924d7c4d2a575b2.1600.jpg" },
                new Storage() { Id = 20, Name = "970 Evo Plus", ManufacturerId = 9, Capacity = 2048, ReadingSpeed = 550, WritingSpeed = 450, TypeId = 3, Price = 400, ImageURL = "https://images-eu.ssl-images-amazon.com/images/I/41x8zIrgC3L.jpg" }
                );

            context.Coolings.AddOrUpdate(x => x.Id,
                new Cooling() { Id = 1 , Name = "AER RGB" , ManufacturerId = 8 , TypeId = 2 , RGB = true , Size = 120 , Speed = 1500 , Price= 28 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/b19d6a6fea838158bcca998fcae5e6b0.1600.jpg" },
                new Cooling() { Id = 2, Name = "LL120 RGB LED", ManufacturerId = 19, TypeId = 2, RGB = true, Size = 120, Speed = 1500, Price = 30, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/4e2045757086fab56d2420d84fcf9619.1600.jpg" },
                new Cooling() { Id = 3, Name = "LL140 RGB", ManufacturerId = 19, TypeId = 2, RGB = true, Size = 140, Speed = 1300, Price = 40, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/af0e3ae9695b1702e6e1b5d4f6200db6.1600.jpg" },
                new Cooling() { Id = 4, Name = "SickleFlow", ManufacturerId = 6, TypeId = 2, RGB = false, Size = 120, Speed = 2000, Price = 10, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/4187AIcuisL._SX466_.jpg" },
                new Cooling() { Id = 5, Name = "ML120 PRO RGB", ManufacturerId = 19, TypeId = 2, RGB = true, Size = 120, Speed = 1600, Price = 30, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/637d55a951c6564584edaa513645859e.1600.jpg" },
                new Cooling() { Id = 6, Name = "ML120 PRO", ManufacturerId = 19, TypeId = 2, RGB = false, Size = 120, Speed = 1600, Price = 24, ImageURL = "http://ecx.images-amazon.com/images/I/51cneTiL46L.jpg" },
                new Cooling() { Id = 7, Name = "iCUE SP120", ManufacturerId = 19, TypeId = 2, RGB = true, Size = 120, Speed = 1400, Price = 25, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/a26d9e55f89e849dbb15cbcb5e327e72.1600.jpg" },
                new Cooling() { Id = 8, Name = "NF-A14 PWM", ManufacturerId = 20, TypeId = 2, RGB = false, Size = 140, Speed = 1500, Price = 20, ImageURL = "http://ecx.images-amazon.com/images/I/51uz3Oi-I8L.jpg" },
                new Cooling() { Id = 9, Name = "NF-F12 PWM", ManufacturerId = 20, TypeId = 2, RGB = false, Size = 120, Speed = 1500, Price = 20, ImageURL = "http://ecx.images-amazon.com/images/I/51u748R1j1L.jpg" },
                new Cooling() { Id = 10, Name = "NF-P12 redux", ManufacturerId = 20, TypeId = 2, RGB = false, Size = 140, Speed = 1700, Price = 13, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/513cdf4%2B-SL.jpg" },
                new Cooling() { Id = 11, Name = "ML140 PRO", ManufacturerId = 19, TypeId = 2, RGB = false, Size = 140, Speed = 2000, Price = 25, ImageURL = "http://ecx.images-amazon.com/images/I/514BYMyIhbL.jpg" },
                new Cooling() { Id = 12, Name = "ML120 PRO LED", ManufacturerId = 19, TypeId = 2, RGB = false, Size = 120, Speed = 1700, Price = 28, ImageURL = "http://ecx.images-amazon.com/images/I/51Iktd3q0jL.jpg" },
                new Cooling() { Id = 13, Name = "ML120 PRO LED", ManufacturerId = 6, TypeId = 2, RGB = true, Size = 140, Speed = 1500, Price = 27, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/ae67a9e317a6e28209c2f276f2609bd4.1600.jpg" },
                new Cooling() { Id = 14, Name = "SP120 RGB", ManufacturerId = 19, TypeId = 2, RGB = true, Size = 120, Speed = 1400, Price = 17, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/204befc450a5aa5cc5d2f9b980481d9f.1600.jpg" },
                new Cooling() { Id = 15, Name = "NF-R8 redux", ManufacturerId = 20, TypeId = 2, RGB = false, Size = 80, Speed = 1800, Price = 9, ImageURL = "http://ecx.images-amazon.com/images/I/51IUhpueJWL.jpg" }
                );

            context.Computers.AddOrUpdate(x => x.Id,
                new Computer() { Id = 1, CaseId = 3, CoolingId = 5, CpuId = 9, GpuId = 5, MotherboardId = 9, PsuId = 2, RamId = 4, StorageId = 3, CoolingAmmount = 4, RamAmmount = 16, StorageAmmount = 5 , Name = "ViksaPC"},
                new Computer() { Id = 2, CaseId = 5, CoolingId = 3, CpuId = 6, GpuId = 4, MotherboardId = 1, PsuId = 3, RamId = 5, StorageId = 4, CoolingAmmount = 5, RamAmmount = 16, StorageAmmount = 8 , Name = "ChingoPC" },
                new Computer() { Id = 3, CaseId = 1, CoolingId = 1, CpuId = 1, GpuId = 1, MotherboardId = 1, PsuId = 1, RamId = 1, StorageId = 1, CoolingAmmount = 1, RamAmmount = 32, StorageAmmount = 9 , Name = "MAzhepc" },
                new Computer() { Id = 4, CaseId = 2, CoolingId = 2, CpuId = 2, GpuId = 2, MotherboardId = 2, PsuId = 2, RamId = 2, StorageId = 2, CoolingAmmount = 2, RamAmmount = 64, StorageAmmount = 5 , Name = "AStorPc" });
        }
    }
}
