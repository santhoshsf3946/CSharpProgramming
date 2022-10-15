using System;

namespace Question3
{
    public interface IFamilyInfo
    {
        string FatherName { get; set; }
        
        string MotherName { get; set; }
        
        string PermanantAddress { get; set; }
    }
}