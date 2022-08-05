﻿using ExercicioEnum2.Entities;

namespace ExercicioEnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");
            
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:45"),
                "Traveling to New Zealand",
                "I am going to visit this worderful country!", 12);
            
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1.Content);
            Console.WriteLine(p2.Content);
        }
    }
}
