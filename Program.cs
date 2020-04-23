using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyWeight
{


    class buildingpasport
    {
        public int levels { get; set; }
        public int appartment { get; set; }
        public string buildingType { get; set; }
        public override int GetHashCode()
        {
            string str = buildingType + "|" + levels + "|" + appartment;
            return str.GetHashCode();
        }
    }

    class factorypasport
    {
        HashSet<buildingpasport> _pasport = new HashSet<buildingpasport>();
        public buildingpasport Getpasport(int levels, int appartment, string buildingType)
        {
            buildingpasport bp = new buildingpasport() { };
            if (_pasport.Contains(bp))
            {
                return _pasport.First(p => p.GetHashCode("bp"));
            }
            else
            {
                _pasport.Add(bp);
                return bp;

            }


        }

    }

    class Building
    {
        buildingpasport pasport;
        public int Id { get; set; }
        public void PrintPasport()
        {
            Console.WriteLine(Id);
            Console.WriteLine(pasport.levels);
            Console.WriteLine(pasport.appartment);
            Console.WriteLine(pasport.buildingType);
        }
        public Building(factorypasport pf, int id, int levels, int appartmet, string buildingType)
        {
            Id = id;
            pasport = pf.Getpasport(levels, appartmet, buildingType);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            factorypasport pf = new factorypasport();
            Building b1 = new Building(pf, 1, 10, 100, "Consern");
            buildingpasport p = new buildingpasport();
         
        }
    }
}
