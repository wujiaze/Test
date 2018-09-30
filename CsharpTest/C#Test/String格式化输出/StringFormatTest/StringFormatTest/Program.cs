using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatTest
{
    class Program:IEnumerable<string>
    {
        public IEnumerator<string> bw()
        {
            yield return "b";
            yield return "x";
            yield return "z";
        }
        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return bw();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        //public IEnumerator<string> GetEnumerator()
        //{
        //    return bw();
        //}

        public enum CBCharacteristicProperties
        {
            CBCharacteristicPropertyBroadcast = 0x01,
            CBCharacteristicPropertyRead = 0x02,
            CBCharacteristicPropertyWriteWithoutResponse = 0x04,
            CBCharacteristicPropertyWrite = 0x08,
            CBCharacteristicPropertyNotify = 0x10,
            CBCharacteristicPropertyIndicate = 0x20,
            CBCharacteristicPropertyAuthenticatedSignedWrites = 0x40,
            CBCharacteristicPropertyExtendedProperties = 0x80,
            CBCharacteristicPropertyNotifyEncryptionRequired = 0x100,
            CBCharacteristicPropertyIndicateEncryptionRequired = 0x200,
        }
        public enum CBAttributePermissions
        {
            CBAttributePermissionsReadable = 0x01,
            CBAttributePermissionsWriteable = 0x02,
            CBAttributePermissionsReadEncryptionRequired = 0x04,
            CBAttributePermissionsWriteEncryptionRequired = 0x08,
        }
        static void Main(string[] args)
        {
            byte b = 200;
            string str = string.Format("{0:X2}", b); // 转换成16进制输出
            Console.WriteLine(str);
            CBCharacteristicProperties xx = CBCharacteristicProperties.CBCharacteristicPropertyRead |
                                            CBCharacteristicProperties.CBCharacteristicPropertyWrite |
                                            CBCharacteristicProperties.CBCharacteristicPropertyNotify;
            Console.WriteLine(CBCharacteristicProperties.CBCharacteristicPropertyRead);
            Console.WriteLine(CBCharacteristicProperties.CBCharacteristicPropertyWrite);
            Console.WriteLine(CBCharacteristicProperties.CBCharacteristicPropertyNotify);
            Console.WriteLine(xx);

            Program p1 =new Program();
            foreach (var VARIABLE in p1)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();
        }

       
    }
}
