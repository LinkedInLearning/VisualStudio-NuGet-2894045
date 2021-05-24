using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace BigStar.ColorLib
{
	public class ColorManager
	{

		private Random _ran = new Random();
		private List<WebColor> _allColors;
		public ColorManager()
		{

			_allColors = ColorSource.GetColors();
		}
		public List<WebColor> AllColors  { get { return _allColors; } }
		
		private WebColor GetRandomizedColor()
		{

			return _allColors.ElementAt(_ran.Next(_allColors.Count));
		}

		public WebColor GetRandomColor()
		{

			return GetRandomizedColor();
		}
		public List<WebColor> GetMatchingColorFamily(WebColor candidate)
		{
			var family = _allColors.Where(x => x.ColorFamily == candidate.ColorFamily);
			return family.ToList();
		}
		public WebColor GetSubstituteColor(WebColor candidate)
		{
			var q = from color in GetMatchingColorFamily(candidate)
							where color.ColorName != candidate.ColorName
							select color;
		return q.ElementAt(_ran.Next(q.Count())); ;
		}
	}

}
