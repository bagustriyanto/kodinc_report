using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Repositories.Interfaces
{
    public interface ICacheRepository
    {
        void Add(string key, string value, int? expireInMinutes);
        string Get(string key);
        void Remove(string key);
    }
}