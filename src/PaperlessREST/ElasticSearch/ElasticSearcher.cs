using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Elastic.Clients.Elasticsearch;
using Microsoft.Extensions.Logging;
using PaperlessREST.ElasticSearch.Interfaces;
using Elasticsearch.Net;
using Nest;

namespace PaperlessREST.ElasticSearch
{
    public class ElasticSearcher : IElasticSearcher
    {
        private readonly ILogger<ElasticSearcher> _logger;

        public ElasticSearcher(ILogger<ElasticSearcher> logger)
        {
            _logger = logger;
        }

        IEnumerable<ElasticDocument> IElasticSearcher.SearchDocument(string searchTerm)
        {
            var elasticClient = new ElasticsearchClient(new Uri("http://localhost:9200/"));

            var searchResponse = elasticClient.Search<ElasticDocument>(s => s
                .Index("documents")
                .Query(q => q.QueryString(qs => qs.DefaultField(p => p.Content).Query($"*{searchTerm}*"))));

            return searchResponse.Documents;
        }

    }
}
