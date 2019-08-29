using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist xxxx = Artists.FirstOrDefault(
                x => x.Hometown == "Mount Vernon");
            System.Console.WriteLine(xxxx.ArtistName);



            //Who is the youngest artist in our collection of artists?
            Artist youngest = Artists.FirstOrDefault(
                city => city.Age == Artists.Min(c => c.Age)
            );
            System.Console.WriteLine(youngest.ArtistName + " " + youngest.Age);



            //Display all artists with 'William' somewhere in their real name
            var William = Artists.Where(
                name => name.RealName.Contains("William"));
                foreach(var will in William)
                {
                    System.Console.WriteLine(will.ArtistName);
                }
          


            //Display the 3 oldest artist from Atlanta

            var Atlanta = Artists.Where(
                name => name.Hometown.Contains("Atlanta"));
            var old = Atlanta.OrderByDescending( 
                Age => Age.Age).Take(3);

                foreach(var ATL in old)
                {
                    System.Console.WriteLine(ATL.ArtistName + " " + ATL.Age+ " " + ATL.Hometown);
                }




            //(Optional) Display the Group Name of all groups that have members that are not from New York City




            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);





        }
    }
}
