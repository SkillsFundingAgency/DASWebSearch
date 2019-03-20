using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using component_lib;
using component_lib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shared_lib;
using shared_lib.Models;

namespace component_lib
{
    public class SearchBoxViewComponent : ViewComponent
    {
        private readonly IGenerateSearchResults _generator;

        public SearchBoxViewComponent(IGenerateSearchResults generator)
        {
            _generator = generator;
        }

        public IViewComponentResult Invoke(string searchRouteName, QueryModel q)
        {
            var model = new SearchBoxModel
            {
                Keywords = q.Keywords,
                SearchRouteName = searchRouteName
            };

            return View(model);
        }

        private static IEnumerable<LevelAggregationViewModel> BuildAggregationModels(IEnumerable<SearchResultItem> hits)
        {
            return hits.GroupBy(x => x.Level)
                .Select(g => new LevelAggregationViewModel{ Value = g.Key.ToString(), Count = g.Count() })
                .OrderBy(x => x.Value);
        }

        private List<SearchResultItem> ApplyFilter(List<SearchResultItem> hits, List<int> selectedLevels)
        {
            if (selectedLevels == null || selectedLevels.Count == 0)
            return hits;

            return hits.Where(x => !selectedLevels.Contains(x.Level)).ToList();
        }
    }
}