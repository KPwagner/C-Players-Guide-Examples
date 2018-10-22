using System;
namespace MakingClasses
{
    class EmptyClass
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public EmptyClass(string title)
        {
            this.title = title;
        }

        public EmptyClass(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public EmptyClass(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
