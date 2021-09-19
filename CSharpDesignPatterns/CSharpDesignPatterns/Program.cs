using CSharpDesignPatterns.SOLID.OpenClosedPrinciple;
using CSharpDesignPatterns.SOLID.SingleResponsibilityPrinciple;
using System;


namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PATTERN WORLD!");

            var courseConfig = new CourseConfig();

            // SOLID
            var singleResponsibilityPrinciple = new _1_SingleResponsibilityPrinciple(courseConfig);
            singleResponsibilityPrinciple.Start();

            var openClosedPrinciple = new _2_OpenClosedPrincipleV1(courseConfig);
            openClosedPrinciple.Start();

        }
    }
}
