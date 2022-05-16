using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPUDP
{
    public static class ConvertHelp
    {
        public static void EncodeCommandToASCII(this BinaryWriter binaryWriter, string stringToEncoding, Encoding encoderType)
        {
            binaryWriter.Write(encoderType.GetBytes(stringToEncoding));
            binaryWriter.Write(encoderType.GetBytes("\0"));
        }

        public static void EncodeCommandXPToASCII(this BinaryWriter binaryWriter, string stringToEncoding, Encoding encoderType)
        {
            binaryWriter.Write(encoderType.GetBytes(stringToEncoding));
        }

        public static string DecodeZeroArrayFromASCII(this BinaryReader binaryReader, Encoding encoderType)
        {
            byte[] bytes = encoderType.GetBytes("\0");
            int len = bytes.Length;
            List<byte> list = new List<byte>();
            byte[] array;
            while (!(array = binaryReader.ReadBytes(len)).SequenceEqual(bytes))
            {
                list.AddRange(array);
            }
            return encoderType.GetString(list.ToArray());
        }

        public static string DecodeArrayFromASCII(this BinaryReader binaryReader, Encoding encoderType, int count)
        {
            byte[] bytes = binaryReader.ReadBytes(count);
            return encoderType.GetString(bytes);
        }
    }
}
