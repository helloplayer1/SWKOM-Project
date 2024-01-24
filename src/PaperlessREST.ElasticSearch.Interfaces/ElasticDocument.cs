namespace PaperlessREST.ElasticSearch.Interfaces
{
    public class ElasticDocument
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}