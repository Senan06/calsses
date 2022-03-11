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
        public double costPrice;
        public double saledPrice;

        public Product(string name, double costPrice, double saledPrice)
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
        public double discountPrecent;
        public Book(string name, double costPrice, double saledPrice, string authorName, int pageCount, double discountPrecent) : base( name, costPrice, saledPrice)
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
        public double GetDiscountedPrice()
        {
            return saledPrice - ((saledPrice / 100) * discountPrecent);
        }

    }
}
