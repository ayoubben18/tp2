using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("CIN123", "John", "Doe", "0600000001");
            Client client2 = new Client("CIN456", "Jane", "Smith", "0600000002");

            Compte compte1 = new Compte(client1, 500);
            Compte compte2 = new Compte(client2, 1000);

            compte1.AfficherResume();
            compte2.AfficherResume();

            compte1.Crediter(200);  
            compte2.Debiter(300);   

            compte1.Crediter(100, compte2);  

            compte1.AfficherResume();
            compte2.AfficherResume();

            Compte.AfficherNombreComptes();
        }
    }
}
