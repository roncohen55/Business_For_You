using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Business_For_You
{
    class funcServer
    {
        private List<string> arr = new List<string>();

        public funcServer() { }



        public List<string> dataFromServer( string pac)
        {
           
            Int32 port = 13000;
            int c = 0;
            IPAddress addressServer = IPAddress.Parse("127.0.0.1");
            TcpClient client = new TcpClient(addressServer.ToString(), port);
            Encoding hebrewEncoding = Encoding.GetEncoding("Windows-1255");

            byte[] data = hebrewEncoding.GetBytes(pac);// convert string to byte
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length); //send data to server
            string st = "", s = "";
            string messagefromserver = "";
            int k = 0;
            
            byte[] datafromserver = new byte[4064];
            int bytes = stream.Read(datafromserver, 0, datafromserver.Length);
            messagefromserver = hebrewEncoding.GetString(datafromserver, 0, bytes);
            

            stream.Close();
            client.Close();

        
              arr =  dataListFromServer(messagefromserver);


          return arr;
        }

        public string dataStringFromServer(string pac)
        {

            Int32 port = 13000;
            int c = 0;
            IPAddress addressServer = IPAddress.Parse("127.0.0.1");
            TcpClient client = new TcpClient(addressServer.ToString(), port);
            Encoding hebrewEncoding = Encoding.GetEncoding("Windows-1255");
            byte[] data = hebrewEncoding.GetBytes(pac);// convert string to byte
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length); //send data to server
            string st = "", s = "";
            string messagefromserver = "";
            int k = 0;
           
            byte[] datafromserver = new byte[256];
            int bytes = stream.Read(datafromserver, 0, datafromserver.Length);
            messagefromserver = hebrewEncoding.GetString(datafromserver, 0, bytes);


            stream.Close();
            client.Close();

        

            return messagefromserver;
        }

        public List<string> dataListFromServer(string messagefromserver)
        {
            List<string> tmp = new List<string>();

            string[] aq = messagefromserver.Split('*');

            for (int z = 0; z < aq.Length - 1; z++)
            {

                tmp.Add(aq[z]);

            }

            return tmp;

          
        }
    }
}
