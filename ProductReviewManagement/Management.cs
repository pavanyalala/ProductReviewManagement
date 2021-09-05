using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public DataTable dataTable = new DataTable();
        /// <summary>
        /// UC-2
        /// </summary>
        /// <param name="review"></param>
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID +
                    "  " + "UserID : " + list.UserID +
                    "  " + "Rating : " + list.Rating +
                    "  " + "Review : " + list.Review +
                    "  " + "Islike : " + list.IsLike

                    );
            }
        }
        /// <summary>
        /// UC-3
        /// </summary>
        /// <param name="review"></param>
        public void SelectRecords(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               where (productReviews.ProductID == 1 && productReviews.Rating > 3) || (productReviews.ProductID == 4 && productReviews.Rating > 3) || (productReviews.ProductID == 9 && productReviews.Rating > 3)
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID +
                    "  " + "UserID : " + list.UserID +
                    "  " + "Rating : " + list.Rating +
                    "  " + "Review : " + list.Review +
                    "  " + "Islike : " + list.IsLike
                    );
            }

        }
        /// <summary>
        /// UC-5
        /// </summary>
        /// <param name="review"></param>
        public void RetriveCountOfRecords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "-----" + list.Count);
            }
        }
        /// <summary>
        /// UC-5
        /// </summary>
        public void RetriveProductIDandReview(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               select new { productReviews.ProductID, productReviews.Review };
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "Review:-" + list.Review);
            }
        }
        public void SkipRecords(List<ProductReview> review)
        {
            var recordedData = (from productreviews in review
                                select productreviews).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id: " + list.ProductID + "  " + "User Id: " + list.UserID + "  " + "Product Rating: " + list.Rating + "  " +  "Is Like: " + list.IsLike);
            }
        }
    }
}
    

