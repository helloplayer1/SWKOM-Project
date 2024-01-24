﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace PaperlessREST.ElasticSearch.Interfaces
{
    public interface IElasticSearcher
    {
        IEnumerable<ElasticDocument> SearchDocument(string searchString);
    }
}
