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
