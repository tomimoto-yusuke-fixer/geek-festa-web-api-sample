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
            return res;
        }
    }
}