﻿using EnsajShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnsajShop.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
