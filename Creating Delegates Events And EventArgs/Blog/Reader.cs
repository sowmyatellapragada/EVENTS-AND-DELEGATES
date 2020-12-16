using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{



    public class Reader
    {
        public string ReaderName { get; set; }

        public Reader(string readerName)
        {
            ReaderName = readerName;
        }

        public void SubscribeForBlog(Blog blog)
        {
            blog.BlogSubscribtionService.BlogSubscribeEvent += BlogSubscribtionService_BlogSubscribeEvent;
        }

        private void BlogSubscribtionService_BlogSubscribeEvent(string articleName, string blogName)
        {
            Console.WriteLine("{0} is read by {1} in the blog {2}", articleName, ReaderName, blogName);
        }
    }
}
