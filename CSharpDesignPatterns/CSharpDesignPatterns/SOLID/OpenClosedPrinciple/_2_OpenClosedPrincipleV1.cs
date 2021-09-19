using CSharpDesignPatterns.SOLID.OpenClosedPrinciple.V1;
using CSharpDesignPatterns.SOLID.OpenClosedPrinciple.V2;
using CSharpDesignPatterns.SOLID.OpenClosedPrinciple.V2.Specifications;
using System;
using System.Collections.Generic;
using static CSharpDesignPatterns.SOLID.OpenClosedPrinciple.Enums;


namespace CSharpDesignPatterns.SOLID.OpenClosedPrinciple
{
    public class _2_OpenClosedPrincipleV1
    {
        private readonly CourseConfig _courseConfig;

        public _2_OpenClosedPrincipleV1(CourseConfig courseConfig)
        {
            _courseConfig = courseConfig;
        }

        public void Start()
        {
            if (_courseConfig._2_OpenClosedPrincipleV1)
            {
                var products = new List<Product>();
                FillProducts(products);

                // V1 - NOT OPEN CLOSE PRINCIPLE RESPECTED
                Console.WriteLine("First Printing");
                PrintProductList(products);
                
                Console.WriteLine("Filtered By Size Without Yield");                
                PrintProductList(ProductFilter.FilterBySize(products, Size.Large));

                Console.WriteLine("Filtered By Size Using Yield");
                PrintProductList(ProductFilter.FilterBySize(products, Size.Large));

                Console.WriteLine("Filtered By Color");
                PrintProductList(ProductFilter.FilterByColor(products, Color.Blue));

                Console.WriteLine("Filtered By Size And Color");                
                PrintProductList(ProductFilter.FilterBySizeAndColor(products, Size.Large, Color.Blue));

                // V2 - OPEN CLOSE PRINCIPLE RESPECTED
                var betterFilter = new BetterFilter();
                
                Console.WriteLine("SUPER FILTER BY COLOR!");
                PrintProductList(betterFilter.Filter(products, new ColorSpecification(Color.Red)));

                Console.WriteLine("SUPER FILTER BY SIZE!");
                PrintProductList(betterFilter.Filter(products, new SizeSpecification(Size.Large)));

                Console.WriteLine("SUPER FILTER BY SIZE AND COLOR USING COMBINATOR!");
                var productsFilteredUsingCombinator = betterFilter.Filter(
                    products, 
                    new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)));
                PrintProductList(productsFilteredUsingCombinator);
            }
        } 
        
        public static void PrintProductList(IEnumerable<Product> products)
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public static List<Product> FillProducts(List<Product> products)
        {
            products.Add(new Product(name: "Product1", color: Color.Red, size: Size.Small));
            products.Add(new Product(name: "Product2", color: Color.Red, size: Size.Medium));
            products.Add(new Product(name: "Product3", color: Color.Red, size: Size.Large));
            products.Add(new Product(name: "Product4", color: Color.Blue, size: Size.Yuge));
            products.Add(new Product(name: "Product5", color: Color.Blue, size: Size.Medium));
            products.Add(new Product(name: "Product6", color: Color.Blue, size: Size.Large));
            products.Add(new Product(name: "Product7", color: Color.Blue, size: Size.Large));
            products.Add(new Product(name: "Product8", color: Color.Green, size: Size.Large));
            products.Add(new Product(name: "Product9", color: Color.Green, size: Size.Yuge));

            return products;
        }
    }   
}
