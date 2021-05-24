using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStarWebApp.Pages
{
	public class BuyAliensModel : PageModel
	{
		public BuyAliensModel()
		{
			this.AlienCards = new Models.CardSource().AlienCards;
		}
	
		public void OnGet()
		{

		}
		public List<Models.CollectableCard> AlienCards { get; set; }
	}
}
