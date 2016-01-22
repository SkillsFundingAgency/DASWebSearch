using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole.Helpers
{
    public static class ListExtensions
    {
        public static async Task ForEachAsync<T>(this List<T> list, Func<T, Task> action)
        {
            foreach (var item in list)
            {
                await action(item);
            }
        }
    }
}