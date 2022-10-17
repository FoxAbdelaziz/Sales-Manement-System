using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace Sales_Manement_System.BL
{
    internal class ClassMethods
    {
       public MemoryStream MS = new MemoryStream();
       public byte[] by;

        // convert to byte
        public byte[] convert_byte()
        {
            return MS.ToArray();
        }
        
        // convert byte to image
        public MemoryStream convert_image()
        {
            MS = new MemoryStream(by);
            return MS;
        }
    }
}
