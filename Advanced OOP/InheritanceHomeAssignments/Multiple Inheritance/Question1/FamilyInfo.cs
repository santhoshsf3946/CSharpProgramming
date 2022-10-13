using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public interface FamilyInfo : IShowData
    {
        string FatherName { get; set; }

        string MotherName { get; set; }

        string HouseAddress { get; set; }

        int NumberOfSiblings { get; set; }
    }
}