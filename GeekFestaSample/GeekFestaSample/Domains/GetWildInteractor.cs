using GeekFestaSample.UseCases;

namespace GeekFestaSample.Domains
{
    public class GetWildInteractor : IGetWildUseCase
    {
        public GetWildInteractor(){}
    
        public string Get() 
        {
            return "Wild";
        }
    }
}