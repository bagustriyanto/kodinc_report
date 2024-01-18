using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using ReportService.Repositories.Interfaces;

namespace ReportService.Repositories
{
    public class CacheRepository : ICacheRepository
    {
        private readonly IMemoryCache memoryCache;
        public CacheRepository(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;

        }
        public void Add(string key, string value, int? expireInMinutes)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions();
            if (expireInMinutes.HasValue)
            {
                cacheEntryOptions.AbsoluteExpiration = DateTime.Now.AddMinutes(expireInMinutes.Value);
            }
            else
            {
                cacheEntryOptions.AbsoluteExpiration = DateTime.MaxValue;
                cacheEntryOptions.Priority = CacheItemPriority.NeverRemove;
            }

            memoryCache.Set(key, value, cacheEntryOptions);
        }

        public string Get(string key)
        {
            string result = string.Empty;

            memoryCache.TryGetValue(key, out result);

            return result;
        }

        public void Remove(string key)
        {
            memoryCache.Remove(key);
        }
    }
}