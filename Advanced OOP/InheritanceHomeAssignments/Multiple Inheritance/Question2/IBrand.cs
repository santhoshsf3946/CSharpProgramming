using System;

namespace Question2
{
    public interface IBrand
    {
        string BrandName { get; set; }
        
        string ModelName { get; set; }
        
        void ShowDetails();
    }
}