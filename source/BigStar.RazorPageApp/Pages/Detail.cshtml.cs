using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigStarWebApp.Models;

namespace BigStarWebApp {
	public class DetailModel : PageModel {
		public void OnGet(int id) {

			//CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.FirstOrDefault(x => x.StopNumber == stopNumber);
			CurrentCard = new CardSource().CollectibleCards.FirstOrDefault(x => x.Id == id);
		}

		public CollectableCard CurrentCard { get; set; }
	}
}
