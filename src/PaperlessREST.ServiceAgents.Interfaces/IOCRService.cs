namespace PaperlessREST.ServiceAgents.Interfaces
{
    public interface IOCRService
    {
        public string PerformORC(Stream document);
    }
}
