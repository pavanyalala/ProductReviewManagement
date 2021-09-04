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
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + 
                    "  " + "UserID : " + list.UserID +
                    "  " + "Rating : " + list.Rating +
                    "  " + "Review : " + list.Review +
                    "  " + "Islike : " + list.IsLike 

                    );
            }
        }
    }
}
