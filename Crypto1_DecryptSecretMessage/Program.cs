using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto1_DecryptSecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class DecryptMessage
    {
        static public byte[] ConvertStringHexToByteArray(string hexString)
        {
            byte[] hexArray = new byte[hexString.Length/2];
            for (int i = 0, x = 0; i < hexString.Length; i+=2, x++)
            {
                // ISSUE: what if length is odd? Can it be odd?
                hexArray[x] = byte.Parse(hexString.Substring(i, 2));
            }

            return hexArray;
        }
    }
}
