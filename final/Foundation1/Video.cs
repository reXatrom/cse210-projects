using System;
using System.Collections.Generic;

public class Video
{
    private string Author;
    private string Title;
    private int Length;
    List<Comment> CommentList;
    
    public Video(string author, string title, int length, List<Comment> list)
    {
        this.Author = author;
        this.Title = title;
        this.Length = length;
        this.CommentList = list;
    }

    public string GetAuthor()
    {
        return this.Author;
    }

    public string GetTitle()
    {
        return this.Title;
    }

    public int GetLength()
    {
        return this.Length;
    }

    public void Display()
    {
        Console.WriteLine($"Video Title: {this.Title}\nAuthor: {this.Author} - Length: {this.Length} seconds"+
        $"\nComments:{this.CommentList.Count}");
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments ---");

        for(int i = 0; i < this.CommentList.Count; i++){
            Console.WriteLine(this.CommentList[i].GetComment());
        }
    }

    public int CommentsCount()
    {
        return this.CommentList.Count;
    }
}