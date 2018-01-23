namespace _07.Advertisement_Message
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var messages = File.ReadAllLines("../../input.txt");
            var random = new Random();

            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] = $"{Title(random.Next())} {GetStatement(random.Next())} {GetAuthor(random.Next())} – {GetCity(random.Next())}.";
            }

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllLines("../../output.txt", messages);
        }

        private static string GetCity(int index)
        {
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            return cities[index % cities.Length];
        }

        private static string GetAuthor(int index)
        {
            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva",
                "Ani",
                "Antoaneta",
                "Silviq",
                "Tatqna",
                "Emanuela",
                "Andrea",
                "Gergana",
                "Petq",
                "Gery",
                "Jana",
                "Yana"
            };

            return authors[index % authors.Length];
        }

        private static string GetStatement(int index)
        {
            string[] statements =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            return statements[index % statements.Length];
        }

        private static string Title(int index)
        {
            string[] titles =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            return titles[index % titles.Length];
        }
    }
}