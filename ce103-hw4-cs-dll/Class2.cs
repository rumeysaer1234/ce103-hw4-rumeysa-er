using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class Class2
    {
        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp(int fiIndex);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_strrev_cpp(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_strlen_cpp(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_stract_cpp(string fiDest, string fiSrc);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_strcmp_cpp(string fiLhs, string fiRhs);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_strcpy_cpp(string foDestination, string fiSource);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_hex2bin_cpp(string fiHex, string fiHexlen);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_bin2hex_cpp(string fiBin, string fiBinlen);











    }
}
