
using ImTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Persistencia;

namespace WindowsFormsApp1
{
    public class RsaEncryption
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }
        public string GetPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();

        }
        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        internal static class Program
        {
            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]


            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());



                using (DatabaseEntities db = new DatabaseEntities())
                {
                    users oUser = new users();
                    oUser.nombre = "marta";
                    oUser.password = Segu.GetSHA256("marta");
                    db.users.Add(oUser);
                    db.SaveChanges();
                }
            }
            
        }
    }
}
