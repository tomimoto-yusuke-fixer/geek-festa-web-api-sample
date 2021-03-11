using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GeekFestaSample.UseCases;

namespace GeekFestaSample.Domains
{
    public class GetWildInteractor : IGetWildUseCase
    {
        public GetWildInteractor()
        {
        }

        public string Get()
        {
            Task.Delay(5000).ContinueWith((task) => Num());
            return "Wild";
        }

        private void Num()
        {
            long num = 0;
            var random = new Random();
            while (num < 10000000000)
            {
                num += random.Next(100, 1000);
            }
        }
    }
}