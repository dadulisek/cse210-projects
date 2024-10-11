using System;

class Program
{
    static void Main(string[] args)
    {
        Comment c11 = new Comment("So cool!!!", "danny011");
        Comment c12 = new Comment("Noice, very well done", "Narr#tor");
        Comment c13 = new Comment("Why did you say that", "N0t so N00b");
        Comment c14 = new Comment("Awsome keep it up $$$$$", "Pasek1999");
        Comment c21 = new Comment("First!!!!", "The suber");
        Comment c22 = new Comment("You can't be frst, i is author firsgt", "Timmo 2010");
        Comment c23 = new Comment("No dramma in the commentos por favore", "PetroFINO");
        Comment c31 = new Comment("Finally someone said it", "The best");
        Comment c32 = new Comment("I don't think it was good that it said it", "Tr0000l000");
        Comment c33 = new Comment("Report it please", "Vigilant");
        Comment c41 = new Comment("Awsome so sweet dude!!!", "Positivist");
        Comment c42 = new Comment("It is a normal commuity", "knock knock");
        Comment c43 = new Comment("I learned something", "JePed2008");
        Comment c44 = new Comment("Yes", "Who Who?");

        Video v1 = new Video("How to C#", "Random Dude", 347, c11, c12, c13, c14);
        Video v2 = new Video("How to Python", "Not so Random Person", 421, c21, c22, c23);
        Video v3 = new Video("How to not C#", "Just another guy", 319, c31, c32, c33);
        Video v4 = new Video("How to not Python", "The eliminator ;)", 112, c41, c42, c43, c44);

        List<Video> videos = new List<Video>{v1,v2, v3, v4};

        Console.Clear();
        Console.WriteLine("This is start!!!!");

        foreach (Video vid in videos)
        {
            string text1;
            int numComment;

            text1 = vid.GetVideo();
            numComment = vid.NumOfComments();

            Console.WriteLine(text1);
            Console.WriteLine($"The number of comments is: {numComment}");
            vid.GetComment();
        }

        Console.WriteLine("This is end!!!!");
    }
}