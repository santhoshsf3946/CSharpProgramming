using System;

namespace Question2
{
    public interface IBankInfo
    {
        string BankName { get; set; }
        
        string IFSC { get; set; }
        
        string Branch { get; set; }
    }
}