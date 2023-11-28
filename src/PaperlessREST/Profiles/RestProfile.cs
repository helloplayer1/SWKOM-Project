using AutoMapper;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.Entities;

public class RestProfile : Profile
{
    public RestProfile()
    {
<<<<<<< HEAD
        CreateMap<DocumentsIdBody,Document>().ReverseMap();
=======
        //CreateMap<DocumentsIdBody,Document>().ReverseMap();
>>>>>>> dev
        CreateMap<DocumentDto,Document>().ReverseMap();

    }
}