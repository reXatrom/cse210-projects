using System;
using System.Collections.Generic;

public class Comment
{
    private string Name;
    private string Text;

    public Comment(string name, string text)
    {
        this.Name = name;
        this.Text = text;
    }

    public string GetComment(){
        return $"{this.Name}:\n    {this.Text}";
    }
}