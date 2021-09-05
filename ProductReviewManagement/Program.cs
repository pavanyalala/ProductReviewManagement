using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management");

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=4,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=6,UserID=2,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID=7,UserID=3,Rating=2,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=8,UserID=4,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=9,UserID=5,Rating=5,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=10,UserID=5,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=11,UserID=4,Rating=3,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=12,UserID=3,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=13,UserID=2,Rating=3,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=14,UserID=2,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID=15,UserID=4,Rating=2,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=16,UserID=5,Rating=3,Review="Nice",IsLike=true},
                new ProductReview(){ProductID=17,UserID=7,Rating=3,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=18,UserID=7,Rating=3,Review="Nice",IsLike=true},
                new ProductReview(){ProductID=19,UserID=8,Rating=4,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=20,UserID=10,Rating=4,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=21,UserID=11,Rating=4,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=22,UserID=11,Rating=4,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=23,UserID=11,Rating=5,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=24,UserID=12,Rating=5,Review="Average",IsLike=true},
                new ProductReview(){ProductID=25,UserID=10,Rating=5,Review="Bad",IsLike=false},
            };
            Management management = new Management();
            //management.TopRecords(list);
            //management.SelectRecords(list);
            //management.RetriveCountOfRecords(list);
            //management.RetriveProductIDandReview(list);
            //management.SkipRecords(list);
            management.RetriveProductIDandReview(list);
        }
    }
}
