using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JundongTech.Models.Service;
using JundongTech.Models.Stuff;
using JundongTech.Models.Product;
using JundongTech.Models.Partner;

namespace JundongTech.Models.Home
{
    public class HomeViewModel
    {
        public List<Service.Service> services { get; set; }
        public List<Stuff.Stuff> stuffs { get; set; }
        public List<Product.Product> products { get; set; }
        public List<Partner.Partner> partners { get; set; }
        public HomeViewModel()
        {

            ServiceContext serviceContext = new ServiceContext();
            services = (from item in serviceContext.serviceLists
                           select item).ToList();

            StuffContext stuffContext = new StuffContext();
            stuffs = (from item in stuffContext.stuffLists
                    select item).ToList();

            ProductContext productContext = new ProductContext();
            products = (from item in productContext.productList
                            select item).ToList();

            PartnerContext partnerContext = new PartnerContext();
            partners = (from item in partnerContext.partnerList
                        select item).ToList();
        }
    }
}