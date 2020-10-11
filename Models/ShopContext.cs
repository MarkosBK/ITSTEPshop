using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext(string name) : base(name) { }
        public ShopContext() { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ImageForGood> imagesForGoods { get; set; }
    }

    public class MyInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Category category1 = new Category() { CategoryName = "Category1Category1Category1Category1Category1Category1Category1" };
            Category category2 = new Category() { CategoryName = "Category2Category2Category2Category2" };
            Category category3 = new Category() { CategoryName = "Category3" };
            Category category4 = new Category() { CategoryName = "Category4Category4Category4" };
            Category category5 = new Category() { CategoryName = "Category5" };
            context.Categories.AddRange(new[] { category1, category2, category3, category4, category5 });
            context.SaveChanges();

            Good good1 = new Good() { Title = "Good1Good1 Good1 Good1 Good1 Good1 Good1Good1", Price = 2000, CategoryId = 1 };
            Good good2 = new Good() { Title = "Good2Good2 Good2Good2 Good2Good2Good2 Good2Good2 Good2 Good2Good2Good2 Good2Good2", Price = 3000, CategoryId = 1 };
            Good good3 = new Good() { Title = "Good3Good3 Good3Good3Good3 Good3Good3Good3", Price = 4000, CategoryId = 1 };
            Good good4 = new Good() { Title = "Good4Good4 Good4 Good4Good4", Price = 2000, CategoryId = 2 };
            Good good5 = new Good() { Title = "Good5Good5 Good5Good5", Price = 1000, CategoryId = 2 };
            Good good6 = new Good() { Title = "Good6Good6", Price = 6000, CategoryId = 3 };
            Good good7 = new Good() { Title = "Good7", Price = 7000, CategoryId = 3 };
            Good good8 = new Good() { Title = "Good8Good8Good8", Price = 8000, CategoryId = 3 };
            Good good9 = new Good() { Title = "Good9Good9Good9", Price = 17000, CategoryId = 4 };
            Good good10 = new Good() { Title = "Good10 Good10Good10 Good10Good10", Price = 7000, CategoryId = 4 };
            Good good11 = new Good() { Title = "Good11Good11", Price = 5000, CategoryId = 5 };
            Good good12 = new Good() { Title = "Good12", Price = 11000, CategoryId = 5 };
            context.Goods.AddRange(new[] { good1, good2, good3, good4, good5, good6, good7, good8, good9, good10, good11, good12 });
            context.SaveChanges();

            Comment comment1 = new Comment() { CommentText = "CommentText1", UserName = "UserName1", GoodId = 1 };
            Comment comment2 = new Comment() { CommentText = "CommentText2", UserName = "UserName2", GoodId = 1 };
            Comment comment3 = new Comment() { CommentText = "CommentText3", UserName = "UserName3", GoodId = 1 };
            Comment comment4 = new Comment() { CommentText = "CommentText4", UserName = "UserName4", GoodId = 1 };
            Comment comment5 = new Comment() { CommentText = "CommentText5", UserName = "UserName2", GoodId = 2 };
            Comment comment6 = new Comment() { CommentText = "CommentText6", UserName = "UserName3", GoodId = 3 };
            Comment comment7 = new Comment() { CommentText = "CommentText7", UserName = "UserName1", GoodId = 4 };
            Comment comment8 = new Comment() { CommentText = "CommentText8", UserName = "UserName6", GoodId = 5 };
            Comment comment9 = new Comment() { CommentText = "CommentText9", UserName = "UserName7", GoodId = 6 };
            Comment comment10 = new Comment() { CommentText = "CommentText10", UserName = "UserName10", GoodId = 7 };
            context.Comments.AddRange(new[] { comment1, comment2, comment3, comment4, comment5, comment6, comment7, comment8, comment9, comment10 });
            context.SaveChanges();

            ImageForGood img1 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 1 };
            ImageForGood img2 = new ImageForGood() { Title = "image1", Path = "/Files/Images/logo.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img3 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img4 = new ImageForGood() { Title = "image1", Path = "/Files/Images/logo.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img5 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img6 = new ImageForGood() { Title = "image1", Path = "/Files/Images/logo.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img7 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 3 };
            ImageForGood img8 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 4 };
            ImageForGood img9 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 5 };
            ImageForGood img10 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 6 };
            ImageForGood img11 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 7 };
            ImageForGood img12 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 8 };
            ImageForGood img13 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 9 };
            ImageForGood img14 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 10 };
            ImageForGood img15 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 11 };
            ImageForGood img16 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 12 };
            ImageForGood img17 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img18 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 1 };
            ImageForGood img19 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = true, GoodId = 2 };
            ImageForGood img20 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 2 };
            ImageForGood img21 = new ImageForGood() { Title = "image1", Path = "/Files/Images/good.jpg", IsLogo = false, GoodId = 2 };
            context.imagesForGoods.AddRange(new[] { img1, img2, img3, img4, img5, img6, img7, img8, img9, img10, img11, img12, img13, img14, img15, img16, img17, img18, img19, img20, img21 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}