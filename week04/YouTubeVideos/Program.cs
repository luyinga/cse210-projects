using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Jesus movies: The life of Jesus", "Edward N McNulty", 590);

        Comment video1Comment1 = new Comment("Arinze", "Who is watching today, May the good Lord bless, protect and keep you all. May peace and tranquility be restored to our troubled world. Amen.");
        Comment video1Comment2 = new Comment("dicaprio", "I'm a Christian, and I pray every day at the edge of the river.Thank you Jesus for this grace. I'm not alone right now. Jesus is with me.");
        Comment video1Comment3 = new Comment("Jeanne", "The doctor told my wife that i wouldn't make it to morning, they gave me very little chance to live but Jesus healed me.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Moses Movie: Pharaoh Ramses II", "Lionel Chetwynd", 967);

        Comment video2Comment1 = new Comment("Lopez", "May almighty God bless whoever liking my comments so that I come back again and watch this glorious movie Amen.");
        Comment video2Comment2 = new Comment("Alfonso", "I cried my eyes out anytime i watch this oh Moses you are one of the most amazing man who served the lord with all ur heart.");
        Comment video2Comment3 = new Comment("Galois", "I prayed after couple of months to God Almighty while watching this movie. This movie been so blessing to me.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Noah's ARK Movie: The Mighty Epic of Noah", "Darren Aronofsky", 760);

        Comment video3Comment1 = new Comment("Bibiche", "Moses had to overcome a lot to do what GOD instructed him to do.");
        Comment video3Comment2 = new Comment("Guelor", "I have never seen this version. I saw the one with Charleston Heston.");
        Comment video3Comment3 = new Comment("Guyguy", "After watching this, may God increase my faith and stop doubting of his blessings.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}