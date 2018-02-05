using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation.Items
{
    public static class DropDownLists
    {
	    public static List<SelectListItem> Titles = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "1", Text = "Mr"},
		    new SelectListItem{Value = "2", Text = "Ms"},
		    new SelectListItem{Value = "3", Text = "Mrs"},
		    new SelectListItem{Value = "4", Text = "Miss"},
		    new SelectListItem{Value = "5", Text = "Dr (Male)"},
		    new SelectListItem{Value = "6", Text = "Dr (Female)"}

	    };

	    public static List<SelectListItem> MaritalStatus = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "0", Text = ""},
			new SelectListItem{Value = "1", Text = "Married"},
		    new SelectListItem{Value = "2", Text = "Common law partner"},
		    new SelectListItem{Value = "3", Text = "Single"},
		    new SelectListItem{Value = "4", Text = "Divorced"},
		    new SelectListItem{Value = "5", Text = "Widowed"},
		    new SelectListItem{Value = "6", Text = "Civil partnered"}
		};
    }
}
