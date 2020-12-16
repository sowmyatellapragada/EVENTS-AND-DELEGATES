using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    public class Writer
    {
        private Blog blogProp;
        public Writer(Blog blog)
        {
            this.blogProp = blog;
        }

        public void ArticleCompleted()
        {
            if (blogProp == null)
                blogProp = new Blog();

            blogProp.BlogSubscribtionService.ArticleCompleted("Events in .NET", blogProp.BlogName);
        }

    }
}
