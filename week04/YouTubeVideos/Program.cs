using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Video video1 = new Video("C# Full Course for free", "Bro Code", 14400);
        Video video2 = new Video("BINI | 'Salamin, Salamin' Official Music Video", "BINI Official", 268);
        Video video3 = new Video("Drawing the Power of Jesus Christ into Our Lives", "General Conference of The Church of Jesus Christ", 890);

        video1.AddComment(new Comment("@E.J.Corretjer", "You explain this better than my professor in community college and the text book that I am using."));
        video1.AddComment(new Comment("@damegeveloper8648", "I always wonder how Bro Code learned a language without the Bro Code tutorial"));
        video1.AddComment(new Comment("@motorinmysoup9912", "Thank you for this bountiful knowledge!"));
        video1.AddComment(new Comment("@YungRagz", "This guy is truly an inspiration! Hes giving time out of his day to help people out. We appreciate bro!"));

        video2.AddComment(new Comment("@lyricsandblues5890", "ABS CBN is really listening, we just have to support the girls more. Budget, quality, music, outfits, talent,  and all other production ON POINT."));
        video2.AddComment(new Comment("@imeldarose6068", "Next stop Salamin Salamin naman ang ipa-100 million natin blooms ❤🌸"));
        video2.AddComment(new Comment("@reelzreal", "I know BINI will make it. Silent supporter here. World Domination here we go!"));
        video2.AddComment(new Comment("@AnereyBalin", "Watching bago matulog bukas watch nanaman"));

        video3.AddComment(new Comment("@Carlos-up9fy", "I want to change my life hearing you preach might help me I don't want to be a sinner no more"));
        video3.AddComment(new Comment("@maddyboombaddybaddy6532", "LDS are good ppl."));
        video3.AddComment(new Comment("@marygoldorigenes2076", "Thank you God for this message ❤ I thank they oh God for the prophet."));
        video3.AddComment(new Comment("@annmarietate3383", "Look unto Jesus Christ in every thought . Doubt not fear not 🙏🙏🙏"));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
