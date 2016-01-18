using AutoMapper;

namespace Servicios
{
    class AutoMapper
    {
        public static void Configurar()
        {
            // MODELO --> PERSISTENCIA
           /* Mapper.CreateMap<Modelo.Imagen, Persistencia.Imagen>();
            Mapper.CreateMap<Modelo.RangoHorario, Persistencia.RangoHorario>();
            Mapper.CreateMap<Modelo.RangoFecha, Persistencia.RangoFecha>()
                    .ForMember(dest => dest.RangosHorario, opt => opt.MapFrom(src => src.ListaRangosHorario));
            Mapper.CreateMap<Modelo.Campaña, Persistencia.Campaña>()
                    .ForMember(dest => dest.Imagenes, opt => opt.MapFrom(src => src.ListaImagenes))
                    .ForMember(dest => dest.RangosFecha, opt => opt.MapFrom(src => src.ListaRangosFecha));
            Mapper.CreateMap<Modelo.InformacionAdicional, Persistencia.InformacionAdicional>();
            Mapper.CreateMap<>();

            // PERSISTENCIA --> MODELO
            Mapper.CreateMap<Persistencia.Imagen, Modelo.Imagen>();
            Mapper.CreateMap<Persistencia.RangoHorario, Modelo.RangoHorario>();
            Mapper.CreateMap<Persistencia.RangoFecha, Modelo.RangoFecha>()
                    .ForMember(dest => dest.ListaRangosHorario, opt => opt.MapFrom(src => src.RangosHorario));
            Mapper.CreateMap<Persistencia.Campaña, Modelo.Campaña>()
                    .ForMember(dest => dest.ListaImagenes, opt => opt.MapFrom(src => src.Imagenes))
                    .ForMember(dest => dest.ListaRangosFecha, opt => opt.MapFrom(src => src.RangosFecha));
            Mapper.CreateMap<Modelo.InformacionAdicional, Persistencia.InformacionAdicional>();*/
        }
    }
}
