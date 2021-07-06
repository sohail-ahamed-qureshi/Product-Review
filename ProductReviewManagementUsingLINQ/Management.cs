using System;
using System.Collections.Generic;
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
    }
}
