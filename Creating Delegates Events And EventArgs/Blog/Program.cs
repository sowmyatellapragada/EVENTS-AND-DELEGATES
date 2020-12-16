using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    class Program
    {



        static void Main(string[] args)
        {
            Blog myBlog = new Blog() { BlogName = "A Happy Life" };
            myBlog.BlogSubscribtionService = new BlogSubscriptionSerivce();

            Reader reader1 = new Reader("Reader1");
            reader1.SubscribeForBlog(myBlog);

            Reader reader2 = new Reader("Reader2");
            reader2.SubscribeForBlog(myBlog);

            Writer writer = new Writer(myBlog);
            writer.ArticleCompleted();

            Console.Read();
        }

    }
}
