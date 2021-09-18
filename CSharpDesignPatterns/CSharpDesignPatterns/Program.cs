using CSharpDesignPatterns.SOLID;
using System;
using static CSharpDesignPatterns.SOLID._1_SingleResponsibilityPrinciple;

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

        }
    }
}
