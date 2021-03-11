using System;
using System.Threading.Tasks;
using GeekFestaSample.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace GeekFestaSample.Controllers
{
    [ApiController]
    [Route("api/sample")]
    public class GetWildController
    {
        private readonly IGetWildUseCase _getWildUseCase;

        public GetWildController(IGetWildUseCase getWildUseCase)
        {
            _getWildUseCase = getWildUseCase;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var res = _getWildUseCase.Get();
            Task.Delay(5000).ContinueWith((task) => { Environment.Exit(-1); });
            return res;
        }
    }
}