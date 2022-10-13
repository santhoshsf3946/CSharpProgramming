using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Outside;
namespace Inside
{
    public class First : Third
    {
        public int publicNumber = 10;
        private int privateNumber = 20;
        
        internal int internalNumber = 30;
        internal int protectedNumber = 40;

        public int PrivateOutput { get { return privateNumber; } }

        public int ProtectedInternalOutput { get{ return protectedInternalNumber; } }
    }
}
