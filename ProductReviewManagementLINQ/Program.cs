using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC:1- Creating data table
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Review="good",Rating=17,IsLike=true},
                new ProductReview(){ProductId=2,UserId=6,Review="good",Rating=11,IsLike=true},
                new ProductReview(){ProductId=1,UserId=2,Review="bad",Rating=7,IsLike=false},
                new ProductReview(){ProductId=9,UserId=1,Review="good",Rating=19,IsLike=true},
                new ProductReview(){ProductId=1,UserId=2,Review="good",Rating=18,IsLike=true},
                new ProductReview(){ProductId=8,UserId=3,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=5,UserId=5,Review="good",Rating=9,IsLike=false},
                new ProductReview(){ProductId=9,UserId=3,Review="good",Rating=7,IsLike=false},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=19,IsLike=true},
                new ProductReview(){ProductId=3,UserId=6,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=5,UserId=7,Review="good",Rating=15,IsLike=true},
                new ProductReview(){ProductId=1,UserId=1,Review="good",Rating=18,IsLike=true},
                new ProductReview(){ProductId=2,UserId=9,Review="good",Rating=16,IsLike=true},
                new ProductReview(){ProductId=9,UserId=3,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=8,UserId=4,Review="good",Rating=13,IsLike=true},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=3,IsLike=false},
                new ProductReview(){ProductId=2,UserId=8,Review="good",Rating=17,IsLike=true},
                new ProductReview(){ProductId=5,UserId=4,Review="bad",Rating=9,IsLike=false},
                new ProductReview(){ProductId=6,UserId=3,Review="good",Rating=14,IsLike=true},
                new ProductReview(){ProductId=1,UserId=7,Review="bad",Rating=2,IsLike=false},
                new ProductReview(){ProductId=4,UserId=9,Review="bad",Rating=1,IsLike=false},
                new ProductReview(){ProductId=8,UserId=8,Review="bad",Rating=3,IsLike=false},
                new ProductReview(){ProductId=9,UserId=3,Review="good",Rating=20,IsLike=true},
                new ProductReview(){ProductId=7,UserId=1,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=6,UserId=5,Review="good",Rating=17,IsLike=true},
            };
            //IterateLoopList(list);
            RetrieveTop3Records(list);
            Console.ReadLine();
        }

        // UC:1- Adding 25 values in the list
        public static void IterateLoopList(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Product ID: " + product.ProductId + "\t User ID: " + product.UserId + "\t Review: " + product.Review + "\t Rating: " + product.Rating);
            }
        }

        // UC2-Retriving Top 3 Records from the List
        public static void RetrieveTop3Records(List<ProductReview> list)
        {
            var result = (from product in list orderby product.Rating descending select product).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("After Sorting");
            IterateLoopList(result);
            var top3Records = result.Take(3).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("Top 3 Records");
            IterateLoopList(top3Records);
        }
    }
}
