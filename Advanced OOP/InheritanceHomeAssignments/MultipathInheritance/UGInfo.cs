using System;

namespace MultipathInheritance
{
    public interface UGInfo
    {
        long UGMarksheetNumber { get; set; }
        
        double Sem1Mark { get; set; }

        double Sem2Mark { get; set; }

        double Sem3Mark { get; set; }

        double Sem4Mark { get; set; }
        
        double UGTotalMarks { get; set; }
        
        double UGPercentage { get; set; }
    }
}