using Caf.DynamicWebApi;
using Caf.DynamicWebApi.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace CafApi.DynamicServices
{
    [DynamicWebApi]
    public class TestAppService:IDynamicWebApiService
    {
        public IActionResult Get(int id)
        {
            return new  JsonResult("Test");
        }
        
    }
}