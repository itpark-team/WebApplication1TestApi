using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1TestApi.Models
{
    public class PostDatasRepository
    {
        public static List<PostData> postDatas = new List<PostData>()
           {
               new PostData(){Id = 1, UserId = 1, Body = "sdsdds", Title = "fbgdh"},
               new PostData(){Id = 2, UserId = 3, Body = "ghj", Title = "xc"},
               new PostData(){Id = 3, UserId = 45, Body = "xcv", Title = "sdf"}
           };
    }
}
