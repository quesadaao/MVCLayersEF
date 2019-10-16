using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ent = Layers.DO;
using dato = Layers.DAL.Entidades;

namespace Layers.Maps
{
    public class Maps
    {
        public static void createMaps()
        {
            //Mapper.CreateMap<ent.Objects.Categories, dato.Categories>();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ent.Objects.Categories, dato.Categories>();
                cfg.CreateMap<ent.Objects.Products, dato.Products>();
                cfg.CreateMap<ent.Objects.Suppliers, dato.Suppliers>();

                cfg.CreateMap<dato.Categories, ent.Objects.Categories>();
                cfg.CreateMap<dato.Products, ent.Objects.Products>();
                cfg.CreateMap<dato.Suppliers, ent.Objects.Suppliers>();

            });

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<ent.Objects.Categories, dato.Category>();
            //});

            //IMapper mapper = config.CreateMapper();
            //var source = new ent.Objects.Categories();
            //var dest = mapper.Map<ent.Objects.Categories, dato.Category>() > (source);
        }
    }
}
