﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Shop
    {
        public static void Add(Shop_ shop_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertShop '{shop_.ShopName}'," +
                                                        $"'{shop_.Description}'," +
                                                        $"'{shop_.Address}'," +
                                                        $"'{shop_.PhoneNumber}'," +
                                                        $"'{shop_.Image}'," +
                                                        $"{shop_.ShopOwner}");
        }
        public static void Update(Shop_ shop_)
        {

        }
        public static void Delete(Shop_ shop_)
        {

        }
    }
}
