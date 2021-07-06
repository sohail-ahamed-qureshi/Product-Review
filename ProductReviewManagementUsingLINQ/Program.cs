using System;
using System.Collections.Generic;
using System.Data;

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
            //table
            DataTable dataTable = new DataTable();
            //columns
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));
            //rows
            dataTable.Rows.Add(1, 1, 3, "Bad", false);
            dataTable.Rows.Add(2, 2, 2, "Bad", false);
            dataTable.Rows.Add(3, 3, 1, "Bad", false);
            dataTable.Rows.Add(4, 4, 5, "Good", true);
            dataTable.Rows.Add(5, 5, 0, "Bad", false);
            dataTable.Rows.Add(6, 6, 7, "Good", true);
            dataTable.Rows.Add(7, 7, 10, "Best", true);
            dataTable.Rows.Add(8, 8, 9, "Best", true);
            dataTable.Rows.Add(9, 9, 8, "Best", true);
            dataTable.Rows.Add(10, 10, 2, "Bad", false);
            dataTable.Rows.Add(11, 11, 5, "Good", true);
            dataTable.Rows.Add(12, 12, 9, "Best", true);
            dataTable.Rows.Add(13, 13, 1, "Bad", false);
            dataTable.Rows.Add(14, 14, 8, "Best", true);
            dataTable.Rows.Add(15, 15, 3, "Bad", false);
            dataTable.Rows.Add(16, 16, 7, "Good", true);
            dataTable.Rows.Add(17, 17, 4, "Good", true);
            dataTable.Rows.Add(18, 18, 2, "Bad", false);
            dataTable.Rows.Add(19, 19, 3, "Bad", false);
            dataTable.Rows.Add(20, 19, 1, "Bad", false);
            dataTable.Rows.Add(21, 19, 10, "Best", true);
            dataTable.Rows.Add(22, 19, 7, "Good", true);
            dataTable.Rows.Add(23, 19, 8, "Best", true);
            dataTable.Rows.Add(24, 19, 4, "Good", true);
            dataTable.Rows.Add(25, 19, 2, "Bad", false);


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
            //skips top 5 records from the list
            management.SkipTopRecords(list);
            //printing the datatable
            management.PrintTable(dataTable);
            //print only rows whose like is true
            management.PrintTrueTable(dataTable);
            //average rating of each products
            management.AverageRating(dataTable);



        }
    }
}
