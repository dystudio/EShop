﻿using Volo.Abp.Reflection;

namespace EasyAbp.EShop.Products.Authorization
{
    public class ProductsPermissions
    {
        public const string GroupName = "EasyAbp.EShop.Products";

        public class ProductTypes
        {
            public const string Default = GroupName + ".ProductType";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
        
        public class Categories
        {
            public const string Default = GroupName + ".Category";
            public const string CrossStore = Default + ".CrossStore";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

        public class Products
        {
            public const string Default = GroupName + ".Product";
            public const string CrossStore = Default + ".CrossStore";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
        
        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductsPermissions));
        }
    }
}