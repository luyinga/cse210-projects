using System;

class Video
{
    string title;
    string author;
    int lenght;

    public Video(string _title, string _author, int _lenght)
    {
        title = _title;
        author = _author;
        lenght = _lenght;

    }

    public string GetDisplayText()
    {
        string videoDisplay = "";

        {
            videoDisplay = $"{title} {author}:{lenght}";
        }

        return videoDisplay;

    }
}