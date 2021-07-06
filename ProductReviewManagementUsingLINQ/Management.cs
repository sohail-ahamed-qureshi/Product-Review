using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace ProductReviewManagementUsingLINQ
{
    class Management
    {
        /// <summary>
        /// Get top 3 records from the list whose rating is highest
        /// </summary>
        /// <param name="productReviews"> product reviews passed from the list</param>
        public void GetTopThree(List<ProductReview> productReviews)
        {
            var query = (from products in productReviews
                         orderby products.Rating descending
                         select products).Take(3);

            Print(query);
        }
        /// <summary>
        /// gets products with id 1,4,9 whose rating is above 3
        /// </summary>
        /// <param name="productReviews"></param>
        public void RatingAboveThree(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        where (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9) && products.Rating >= 3
                        select products;
            Print(query);
        }
        /// <summary>
        /// groups the products by reviews
        /// </summary>
        /// <param name="productReviews"></param>
        public void CountByReview(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        group products by products.Review;

            foreach (var item in query)
            {
                Console.WriteLine($"Review : {item.Key}");
                foreach (ProductReview items in item)
                {
                    Console.WriteLine($"Product ID: {items.ProductID}, User ID: {items.UserID}, Rating: {items.Rating}, Review: {items.Review}, Like: {items.isLike}");

                }
            }
        }
        /// <summary>
        /// select only particular fields from the list
        /// </summary>
        /// <param name="productReviews"></param>
        public void GetParticularFields(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        select (products.ProductID, products.Review);

            foreach (var item in query)
            {
                Console.WriteLine($"Product ID: {item.ProductID} Review: {item.Review}");
            }
        }
        /// <summary>
        /// Skips top 5 records from the list
        /// </summary>
        /// <param name="productReviews"></param>
        public void SkipTopRecords(List<ProductReview> productReviews)
        {
            var query = (from products in productReviews
                         orderby products.Rating descending
                         select products).Skip(5);

            Print(query);
        }

        /// <summary>
        /// prints the product review
        /// </summary>
        /// <param name="productReviews"> list obtained after processing LINQ operations</param>
        private void Print(IEnumerable<ProductReview> productReviews)
        {
            foreach (var item in productReviews)
            {
                Console.WriteLine($"Product ID: {item.ProductID}, User ID: {item.UserID}, Rating: {item.Rating}, Review: {item.Review}, Like: {item.isLike}");
            }
        }
        /// <summary>
        /// method to read the datatable and print its rows
        /// </summary>
        /// <param name="dataTable"></param>
        public void PrintTable(DataTable dataTable)
        {
            var Products = from products in dataTable.AsEnumerable() select (products.Field<int>("ProductID"),products.Field<int>("UserID"), products.Field<int>("Rating"),
                           products.Field<string>("Review"), products.Field<bool>("isLike"));
            PrintDataTable(Products);
        }
        /// <summary>
        /// printing datatable after linq operations
        /// </summary>
        /// <param name="products"></param>
        private void PrintDataTable(EnumerableRowCollection<(int, int, int, string, bool)> products)
        {
            Console.WriteLine("ProductID  UserID  Rating  Review  Like");
            foreach (var item in products)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3 + " " + item.Item4 + " " + item.Item5);
            }
        }
        /// <summary>
        /// custom method to print rows whose isLike is true
        /// </summary>
        /// <param name="dataTable"></param>
        public void PrintTrueTable(DataTable dataTable)
        {
            var products = from product in dataTable.AsEnumerable() where (product.Field<bool>("isLike") == true)
                           select(product.Field<int>("ProductID"), product.Field<int>("UserID"), product.Field<int>("Rating"),
                           product.Field<string>("Review"), product.Field<bool>("isLike"));
            PrintDataTable(products);
        }
        /// <summary>
        /// print only whose review is Best
        /// </summary>
        /// <param name="dataTable"></param>
        public void ReviewIsBest(DataTable dataTable)
        {
            var products = from product in dataTable.AsEnumerable()
                           where (product.Field<string>("Review").Contains("Best"))
                           select (product.Field<int>("ProductID"), product.Field<int>("UserID"), product.Field<int>("Rating"),
                           product.Field<string>("Review"), product.Field<bool>("isLike"));
            PrintDataTable(products);
        }
        /// <summary>
        /// print only products whose userid is 19
        /// </summary>
        /// <param name="dataTable"></param>
        public void UserID(DataTable dataTable)
        {
            var products = from product in dataTable.AsEnumerable()
                           where (product.Field<int>("UserID") == 19)
                           select (product.Field<int>("ProductID"), product.Field<int>("UserID"), product.Field<int>("Rating"),
                           product.Field<string>("Review"), product.Field<bool>("isLike"));
            PrintDataTable(products);
        }
        /// <summary>
        /// Find average ratinf of eact product 
        /// </summary>
        /// <param name="dataTable"></param>
        public void AverageRating(DataTable dataTable)
        {
            var average = (from product in dataTable.AsEnumerable()
                            select (product.Field<int>("Rating"))).Average();
            Console.WriteLine(average.ToString());
        }
    }
}
