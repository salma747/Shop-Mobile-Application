using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Services
{
    public class BannerService : IBanner
    {
        public List<Banner> GetBanners()
        {
            return API.Banners;
        }
    }
}
