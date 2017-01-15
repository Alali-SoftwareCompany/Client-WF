using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;
using System.IO;

namespace ClientWF
{
    public class Login
    {
        public static bool Enter(string user, string password)
        {
            bool logged = false;
            string passwordMD5 = GetMd5Hash(MD5.Create(), password);

            WebRequest request = WebRequest.Create("http://localhost:54132/Login");
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(user + ";" + password);
            request.ContentType = "application/x-www-form-urlencoded"; //Totálně netušim, k čemu to tu je!!!! :D
            request.ContentLength = byteArray.Length;
            /*
             //Odstuď tohle narvat do toho ASP
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
            */



            return logged;
            //localhost:port/Get/ID/
            //HELL Help: https://msdn.microsoft.com/cs-cz/library/debx8sh9(v=vs.110).aspx
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /* //Slouží pro ověření MD5 k GetMd5Hash ´HESLA píčo´
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
    }
}
