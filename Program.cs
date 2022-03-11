using System;

namespace calsses
{
   
    public static class Program
    {
        public static void Main()
        {
            Book book1 = new Book();
            Console.WriteLine(book1.name);

        }
    }
    class Product
    {
        public string name;
        public int costPrice;
        public int saledPrice;

        public Product(string name, int costPrice, int saledPrice)
        {
            this.name = name;
            this.costPrice = costPrice;
            this.saledPrice = saledPrice;
        }


    }
    class Book : Product
    {
        public string authorName;
        public int pageCount;
        public int discountPrecent;
        public Book(string name, int costPrice, int saledPrice, string authorName, int pageCount, int discountPrecent) : base(string name, int costPrice, int saledPrice)
        {
            this.pageCount = pageCount;
            this.authorName = authorName;
            this.discountPrecent = discountPrecent;
        }
        public void Getinfo()
        {
            Console.WriteLine($"Mehsul adi: {name}");
            Console.WriteLine($"Mehsul maya deyeri: {costPrice}");
            Console.WriteLine($"Mehsul satis qiymeti: {saledPrice}");
            Console.WriteLine($"Mehsul Muellifi: {authorName}");
            Console.WriteLine($"Mehsul {pageCount} sehife");
            Console.WriteLine($"Mehsul endirim faizi: {discountPrecent}");
            Console.WriteLine($"Mehsulun endirimli satis qiymeti {GetDiscountedPrice()}");
        }
        public int GetDiscountedPrice()
        {
            return saledPrice - ((saledPrice / 100) * discountPrecent);
        }

    }
}
