using System;

class Comment
{
    Video video;
    List<Word> words;

    public Comment(Video _video, string _text)
    {
        video = _video;
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach (string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in words)
        {

            scriptureText += word.GetDisplayText() + "";

        }

        return ($"{video.GetDisplayText()} {scriptureText}");
    }

}