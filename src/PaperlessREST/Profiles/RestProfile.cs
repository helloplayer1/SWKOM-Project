using AutoMapper;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.Entities;

public class RestProfile : Profile
{
    public RestProfile()
    {
        //CreateMap<DocumentsIdBody,Document>().ReverseMap();
        CreateMap<DocumentDto, Document>().ReverseMap();
        CreateMap<DocumentDao, Document>().ReverseMap();

    }
}