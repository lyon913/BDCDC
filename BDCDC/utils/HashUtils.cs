using System;
using System.Security.Cryptography;
using System.Text;

namespace BDCDC.utils
{
    class HashUtils
    {
        public static String md5Hash(String source,String salt,int hashIterations)
        {
            MD5 md5 = MD5.Create();
            byte[] saltSource = getSaltSource(salt, source);
            byte[] result = md5.ComputeHash(saltSource);
            hashIterations = hashIterations - 1;
            for(int i=0;i< hashIterations; i++)
            {
                result = md5.ComputeHash(result);
            }

            return BitConverter.ToString(result).Replace("-","");

        }

        public static bool match(String hash1,String hash2)
        {
            return hash1.ToLower().Equals(hash2.ToLower());
        }

        private static byte[] getSaltSource(String salt,String source)
        {
            if(salt == null)
            {
                return getBytes(source);
            }
            MD5 md5 = MD5.Create();
            byte[] saltByte = getBytes(salt);
            //byte[] saltHash = md5.ComputeHash(saltByte);
            byte[] sourceByte = getBytes(source);

            byte[] saltSource = new byte[saltByte.Length + sourceByte.Length];

            saltByte.CopyTo(saltSource, 0);
            sourceByte.CopyTo(saltSource, saltByte.Length);

            return saltSource;
        }

        public static byte[] getBytes(String str)
        {
            if(str == null)
            {
                return null;
            }
            return Encoding.UTF8.GetBytes(str);
        }
    }
}
