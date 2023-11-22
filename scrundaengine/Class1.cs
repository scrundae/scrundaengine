using System.Diagnostics;

namespace scrundaengine
{
    public class Engine
    {
        //Health variables
        public float globalHealth = 100;
        public float minGlobalHealth = 0;
        public float maxGlobalHealth = 100;
        public bool useGlobalHealth;
        public string globalUserScrape;
        public string globalUserRecord;
        public void Cast(string text)
        {
            Console.WriteLine(text);
        }

        public void Wipe()
        {
            Console.Clear();
        }

        public void Scrape()
        {
            globalUserScrape = Console.ReadLine();
        }

        public void Record()
        {
            globalUserRecord = Console.ReadKey().KeyChar.ToString();
        }

        public void PlotPoint(float x, float y, string pointDefiner)
        {
            string formattedPoint = new string(' ', (int)x) + pointDefiner; // Add spaces before 'o' based on the value of x

            for (int i = 0; i < (int)y; i++)
            {
                Console.WriteLine(); // Add new lines before 'o' based on the value of y
            }

            Console.WriteLine(formattedPoint);
        }
    }
}