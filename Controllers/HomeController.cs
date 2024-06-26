﻿using MyStandardFramework_POC.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// comment 3

// comment 3 - additional text

// change 1 - from Dev-April

// change - from Dev-2
// change2 - from Dev-2

// change - from Dev-3
// change2 - from Dev-3

// change - from Dev-4
// change2 - from Dev-4

namespace MyStandardFramework_POC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			List<GetMostPopularJob_Result> popularJob = new List<GetMostPopularJob_Result>();

			using (var db = new MyDatabaseEntities())
			{
				var query = db.GetMostPopularJob();

				foreach (GetMostPopularJob_Result item in query)
				{
					popularJob.Add(item);
				}
			}

			return View(popularJob);
		}

		public ActionResult Users()
		{
			ViewBag.Message = "Your contact page.";

			List<Person> users = new List<Person>();

			using (var db = new MyDatabaseEntities())
			{
				var query = from b in db.People
							orderby b.first_name
							select b;

				foreach (Person item in query)
				{
					users.Add(item);
				}
			}

			return View(users);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}


	}
}