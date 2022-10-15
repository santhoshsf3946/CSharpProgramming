using System;

namespace MultipathInheritance
{
    public interface HSCInfo : PersonalInfo
    {
        long HSCMarksheetNumber { get; set; }
        
        double Physics { get; set; }
        
        double Chemistry { get; set; }
        
        double Maths { get; set; }
        
        double HSCTotalMarks { get; set; }
        
        double HSCPercentage { get; set; }
    }
}
