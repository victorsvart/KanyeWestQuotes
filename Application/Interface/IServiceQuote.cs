using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IServiceQuote
    {
        public Task<String> RunAsync();
        public Task<Quotes> GetQuote(string path);
    }
}
