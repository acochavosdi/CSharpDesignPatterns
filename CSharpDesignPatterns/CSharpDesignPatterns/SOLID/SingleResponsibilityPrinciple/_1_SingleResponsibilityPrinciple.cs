using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CSharpDesignPatterns.SOLID.SingleResponsibilityPrinciple
{
    class _1_SingleResponsibilityPrinciple
    {
        private readonly CourseConfig _courseConfig;

        public _1_SingleResponsibilityPrinciple(CourseConfig courseConfig)
        {
            _courseConfig = courseConfig;
        }
        public void Start()
        {
            if (_courseConfig._1_SingleResponsibilityPrinciple)
            {
                var journal = new Journal();
                journal.AddEntry("I've created a Journal!");
                journal.AddEntry("Today i've been wondering ... what if??");
                journal.AddEntry("Entry 3");
                journal.AddEntry("Entry 4");
                journal.AddEntry("Entry 5");
                Console.Write(journal.ToString());

                journal.RemoveEntry(3);
                Console.Write(journal.ToString());

                var journalPersistence = new JorunalPersistence();
                var fileName = @"c:\temp\journal.txt";
                journalPersistence.SaveToFile(journal,fileName,true);

            }
        }

        public class Journal
        {
            List<string> entries = new List<string>();

            private static int count = 0;

            public int AddEntry(string text)
            {
                entries.Add($"{++count}: {text}");
                return count; // memento pattern
            }

            public void RemoveEntry(int index)
            {
                entries.RemoveAt(index);
            }

            public override string ToString()
            {
                var informationText = "Printing Journal!";
                var journalEntries = String.Join(Environment.NewLine, entries);
                return (informationText + Environment.NewLine + journalEntries + Environment.NewLine);
            }
        }

        public class JorunalPersistence
        {
             public void SaveToFile(Journal j, string fileName, bool overwrite = false)
            {
                if(overwrite || !File.Exists(fileName))
                {
                    File.WriteAllText(fileName,j.ToString());
                    //Process.Start(fileName);
                }
            }
        }
    }
}
