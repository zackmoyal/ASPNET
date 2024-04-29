﻿using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductRepository repo;

		public ProductController(IProductRepository repo)
		{
			this.repo = repo;
		}

		// GET: /<controller>/
		public IActionResult Index()
		{
			var products = repo.GetAllProducts();
			return View(products);
		}
	}
}
