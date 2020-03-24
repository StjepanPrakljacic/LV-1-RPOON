using System;
using System.Collections.Generic;
using System.Text;

namespace LV_1_RPPOON
{
    class Note
    {
        private string mText;
        private string mAuthor;
        private int mPriority;

        public string GetText() { return mText; }
        public void SetText(string text) { mText = text; }
        public string GetAuthor() { return mAuthor; }
        private void SetAuthor(string author) { mAuthor = author; }
        public int GetPriority() { return mPriority; }
        public void SetPriority(int priority) { mPriority = priority; }



        public Note() { mAuthor = "Unknown"; mText = "Unknown"; mPriority = 0; }
        public Note(string author, string text, int priority) { mAuthor = author; mText = text; mPriority = priority; }
        public Note(string author, string text) { mAuthor = author; mText = text; }

        public int Priority
        {
            get { return mPriority; }
            set { mPriority = value; }
        }

        public string Text
        {
            get { return mText; }
            set { mText = value; }
        }

        public String Author
        {
            get { return mAuthor; }
        }


        public override string ToString()
        {
            return "Author is:" + mAuthor + " " + ",Text :" + mText + " " + ",Priority :" + mPriority + " ";
        }


    }
}

