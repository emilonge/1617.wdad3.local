using System;
using Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Categories
            var c1 = new Category();
            c1.Id = 1;
            c1.Name = "Nieuws";
            c1.Description = "Nieuws uit Tweakers";

            // Tags
            var t1 = new Tag();
            t1.Id = 1;
            t1.Name = "games";

            var t2 = new Tag();
            t2.Id = 2;
            t2.Name = "technology";

            // Blog
            var blog = new Blog();
            blog.Id = 1;
            blog.Title = "Tweakers Blog";
            blog.Description = "Blog van Tweakers.net om nieuws met jullie te delen.";

            // Posts
            var p1 = new Post();
            p1.Id = 1;
            p1.Title = "Video toont interface Nintendo Switch - Koper zegt console te vroeg te hebben gehad";
            p1.Synopsis = "Een gebruiker van het Neogaf-forum claimt de Nintendo Switch te vroeg te hebben binnengekregen. Hij heeft een video online gezet die de interface laat zien van de console die pas over enkele weken in de winkel te vinden zal zijn.";
            p1.Story = $@"
            <p>Neogaf-gebruiker Hiphoptherobot meldde dat hij de Switch in handen had gekregen na een pre-order in een topic over pre-orders. Hij wil niet zeggen waar hij hem heeft gekocht om de webwinkel die hem kreeg te beschermen. Het is lastig te verifiëren hoe hij het apparaat in handen heeft gekregen, maar zijn bescherming van de webwinkel kan erop wijzen dat hij iemand is of kent binnen een retailer die alvast exemplaren in het magazijn heeft liggen om op tijd te kunnen uitleveren. Het gebeurt vaker dat consumenten per ongeluk nog niet uitgebrachte consoles in handen krijgen. Zo stuurde Microsoft een nietsvermoedende consument een prototype van de Xbox One ver voor de release.</p>
            ";

            var p2 = new Post();
            p2.Id = 2;
            p2.Title = "Video toont interface Nintendo Switch - Koper zegt console te vroeg te hebben gehad";
            p2.Synopsis = "Een gebruiker van het Neogaf-forum claimt de Nintendo Switch te vroeg te hebben binnengekregen. Hij heeft een video online gezet die de interface laat zien van de console die pas over enkele weken in de winkel te vinden zal zijn.";
            p2.Story = $@"
            <p>Neogaf-gebruiker Hiphoptherobot meldde dat hij de Switch in handen had gekregen na een pre-order in een topic over pre-orders. Hij wil niet zeggen waar hij hem heeft gekocht om de webwinkel die hem kreeg te beschermen. Het is lastig te verifiëren hoe hij het apparaat in handen heeft gekregen, maar zijn bescherming van de webwinkel kan erop wijzen dat hij iemand is of kent binnen een retailer die alvast exemplaren in het magazijn heeft liggen om op tijd te kunnen uitleveren. Het gebeurt vaker dat consumenten per ongeluk nog niet uitgebrachte consoles in handen krijgen. Zo stuurde Microsoft een nietsvermoedende consument een prototype van de Xbox One ver voor de release.</p>
            ";

            // Add posts to blog    
            blog.Posts.Add(p1);
            blog.Posts.Add(p2);

            Console.WriteLine($@"
#####################################################################################
{ blog.Title }
-------------------------------------------------------------------------------------
{ blog.Description }
#####################################################################################
            ");
        }
    }
}
