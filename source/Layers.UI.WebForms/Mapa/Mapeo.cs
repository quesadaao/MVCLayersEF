using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ent = Layers.DO.Objects;
using mod = Layers.UI.WebForms.Models;

namespace Layers.UI.WebForms.Mapa
{
    public class Mapeo
    {
        public static void CrearMapas() {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ent.Categories, mod.CategoriesModel>();
                cfg.CreateMap<ent.Products, mod.ProductsModel>();
                cfg.CreateMap<ent.Suppliers, mod.SuppliersModel>();

                cfg.CreateMap<mod.CategoriesModel, ent.Categories>();
                cfg.CreateMap<mod.ProductsModel, ent.Products>();
                cfg.CreateMap<mod.SuppliersModel, ent.Suppliers>();

            });
        }


    }
}