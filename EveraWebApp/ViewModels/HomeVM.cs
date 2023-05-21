﻿using EveraWebApp.Models;

namespace EveraWebApp.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Popular> Populars { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }
        public List<Image> Images { get; set; }
    }
}
