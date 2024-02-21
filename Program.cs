namespace Week_05_lab_18_Theatre_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TikTokManager.Show();
            TikTokManager.Show("#Dance");
            TikTokManager.Show(25);
            TikTokManager.Show(Audience.Group);
        }
    }


    public enum Audience
    {
        World,
        Group,
        Special
    }

    public class TikTok
    {
        private static int _ID = 1;

        public string Originator { get; }
        public int Length { get; }
        public string HashTag { get; }
        public Audience Audience { get; }
        public string Id { get; }

        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
            Id = $"TikTok{_ID}";
            _ID++;
        }

        private TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Originator: {Originator}, Length: {Length}, HashTag: {HashTag}, Audience: {Audience}";
        }

        public static TikTok Parse(string line)
        {
            string[] tokens = line.Split('\t');
            return new TikTok(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3], Enum.Parse<Audience>(tokens[4]));
        }
    }


    public static class TikTokManager
    {
        private static List<TikTok> TIKTOKS;

        static TikTokManager()
        {
            TIKTOKS = [];
            Initialize();
        }

        public static void Initialize()
        {
            TIKTOKS.Add(new TikTok("John", 30, "#Dance", Audience.World));
            TIKTOKS.Add(new TikTok("Alice", 20, "#Comedy", Audience.Group));
            TIKTOKS.Add(new TikTok("Bob", 15, "#LipSync", Audience.Special));



        }

        public static void Show()
        {
            foreach (var tiktok in TIKTOKS)
            {
                Console.WriteLine(tiktok);
            }
        }

        public static void Show(string hashtag)
        {
            foreach (var tiktok in TIKTOKS)
            {
                if (tiktok.HashTag.Equals(hashtag, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(tiktok);
                }
            }
        }

        public static void Show(int length)
        {
            foreach (var tiktok in TIKTOKS)
            {
                if (tiktok.Length > length)
                {
                    Console.WriteLine(tiktok);
                }
            }
        }

        public static void Show(Audience audience)
        {
            foreach (var tiktok in TIKTOKS)
            {
                if (tiktok.Audience == audience)
                {
                    Console.WriteLine(tiktok);
                }
            }
        }
    }
}
