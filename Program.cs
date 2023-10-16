using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo user = new UserInfo();
            Console.WriteLine(user.Info());
        }
    }

    public class UserInfo
    {
        public string Info()
        {
            User user = new User();
            VisitedPlaces visitedPlaces = new VisitedPlaces();

            user.name="Ramazan";
            user.lastname="Altun";
            user.age="23";
            user.money="100.000$";
            user.placeabaut="Almanya'nın Başkenti Berlin'dir.";
            visitedPlaces.Country="Almanya";
            visitedPlaces.city="Berlin";
            visitedPlaces.postcode="10115";
            visitedPlaces.SetHumans(new Dictionary<int, string>(){{1 , "Enis Baykara"},{2 , "Mert Deliyürek"},{3 , "Recep Çalışkan"},{4 , "Ebru Geçkalan"}});
            string exit = $"{user.name} {user.lastname} {visitedPlaces.Country}, {visitedPlaces.city}'de 4 kişi ile tanıştı bunlar sırasıyla;{visitedPlaces.GetHumans()}'dır.";
            return exit;
        }
    }


    public class User
    {
        public string name{ get; set; }
        public string lastname{ get; set; }
        public string age{ get; set; }
        public string money{ get; set; }
        public string placeabaut{ get; set; }
    }
    public class VisitedPlaces
    {
        public string Country { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        private Dictionary<int, string> humans = new Dictionary<int, string>();
        //public Dictionary<int, string> humans{get; set;}
        
        public void SetHumans(Dictionary<int ,string> humansname)
        {
            this.humans = humansname;
        }
        public string GetHumans()
        {
            string val = "";
            foreach (var item in this.humans)
            {
                
                val += ","+(item.Value);
                
                
            }
            return val;
        }
            
    }
}