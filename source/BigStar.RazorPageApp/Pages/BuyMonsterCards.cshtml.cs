using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStarWebApp.Pages
{
	public class BuyMonstersModel : PageModel
	{
		public BuyMonstersModel()
		{
			this.MonsterCards = new Models.CardSource().MonsterCards;
		}
	
		public void OnGet()
		{

		}
		public List<Models.CollectableCard> MonsterCards { get; set; }
	}
}
