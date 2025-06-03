using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Mr", "John", 30);
        Comment comment = new Comment(video, "Peace forecast upon them, are significant figures in Christianity," +
        "And Christianity, revered for their unwavering faith and obedience to GoD. Their story is" +
        "central to key events in religion, particularly the sacrifice");


        Console.WriteLine(video.GetDisplayText());
        Console.WriteLine();
        //Console.WriteLine("Press enter to continue");

        //Console.Clear();
    }
}