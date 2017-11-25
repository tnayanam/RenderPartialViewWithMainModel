using System;


// Logic
/*
 * 1. A birthdate of a person does not change so it should be set just once
 * 2. the age is calculated based on birthdate so it should not have a setter
 
     
     */




namespace ConsoleApplication1
{
    public enum Postal
    {
        FedEx = 0,
        USPS = 1,
        UPS = 2
    }

    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _voteCount;

        public Post(string title, string desc)
        {
            _description = desc;
            _title = title;
            _created = DateTime.Now;
        }

        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            if (_voteCount <= 0)
                throw new Exception();

            _voteCount--;
        }

        public int VoteCount()
        {
            return _voteCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post("FirstPost", "This is a first Post");
            p1.UpVote();
            p1.UpVote();
            p1.UpVote();
            p1.DownVote();
            Console.WriteLine(p1.VoteCount());

        }
    }
}
