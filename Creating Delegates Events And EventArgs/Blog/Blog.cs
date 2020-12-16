using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blog
{
    public class Blog
    {
        public string BlogName { get; set; }

        public BlogSubscriptionSerivce BlogSubscribtionService { get; set; }
        public Blog()
        {
            BlogSubscribtionService = new BlogSubscriptionSerivce();
        }
    }
}