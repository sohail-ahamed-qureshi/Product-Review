using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagementUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management Using LINQ");
            //list of product reviews 
            List<ProductReview> list = new List<ProductReview>
            {
                new ProductReview(){ProductID = 1, UserID = 1, Rating =3, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 2, UserID = 2, Rating =2, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 3, UserID = 3, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 4, UserID = 4, Rating =5, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 5, UserID = 5, Rating =0, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 6, UserID = 6, Rating =7, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 7, UserID = 6, Rating =10, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 8, UserID = 6, Rating =9, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 9, UserID = 6, Rating =8, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 10, UserID = 6, Rating =2, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 11, UserID = 6, Rating =5, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 12, UserID = 6, Rating =9, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 13, UserID = 6, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 14, UserID = 6, Rating =8, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 15, UserID = 6, Rating =3, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 16, UserID = 6, Rating =7, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 17, UserID = 6, Rating =4, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 18, UserID = 6, Rating =2, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 19, UserID = 6, Rating =3, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 20, UserID = 6, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 21, UserID = 6, Rating =10, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 22, UserID = 6, Rating =7, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 23, UserID = 6, Rating =8, Review ="Best", isLike = true },
                new ProductReview(){ProductID = 24, UserID = 6, Rating =4, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 25, UserID = 6, Rating =2, Review ="Bad", isLike = false },
            };
            
            Management management = new Management();
            //gets top 3 products review from the list
            management.GetTopThree(list);
            //gets products with id 1,4,9 whose rating is above 3
            management.RatingAboveThree(list);
            //Count by Review
            Console.WriteLine();
            management.CountByReview(list);
            //select only particular fields from the list
            Console.WriteLine();
            management.GetParticularFields(list);
        }
    }
}
