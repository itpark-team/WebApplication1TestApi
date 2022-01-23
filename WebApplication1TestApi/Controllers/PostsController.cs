using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1TestApi.Models;

namespace WebApplication1TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public List<PostData> Get()
        {
            return PostDatasRepository.postDatas;
        }

        [HttpPost]
        public void Post([FromBody]PostData postData)
        {
            PostDatasRepository.postDatas.Add(postData);
        }
    }
}
