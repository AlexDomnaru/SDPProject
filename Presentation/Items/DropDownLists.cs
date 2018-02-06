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
		    new SelectListItem{Value = "", Text = ""},
			new SelectListItem{Value = "Married", Text = "Married"},
		    new SelectListItem{Value = "Common law partner", Text = "Common law partner"},
		    new SelectListItem{Value = "Single", Text = "Single"},
		    new SelectListItem{Value = "Divorced", Text = "Divorced"},
		    new SelectListItem{Value = "Widowed", Text = "Widowed"},
		    new SelectListItem{Value = "Civil partnered", Text = "Civil partnered"}
		};

	    public static List<SelectListItem> OccupationTypes = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "", Text = ""},
		    new SelectListItem{Value = "Employed", Text = "Employed"},
		    new SelectListItem{Value = "Self employed", Text = "Self employed"},
		    new SelectListItem{Value = "Unemployed", Text = "Unemployed"},
		    new SelectListItem{Value = "In Education", Text = "In Education"},
		    new SelectListItem{Value = "House Person", Text = "House Person"},
		    new SelectListItem{Value = "Retired", Text = "Retired"}
	    };

	    public static List<SelectListItem> LicenceType = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "", Text = ""},
		    new SelectListItem{Value = "Full UK", Text = "Full UK"},
		    new SelectListItem{Value = "Provisional UK", Text = "Provisional UK"},
		    new SelectListItem{Value = "Moped", Text = "Moped"},
		    new SelectListItem{Value = "EU", Text = "EU"},
		    new SelectListItem{Value = "International", Text = "International"},
	    };

	    public static List<SelectListItem> EducationOccupations = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "", Text = ""},
		    new SelectListItem{Value = "Mature Student - Living At Home", Text = "Mature Student - Living At Home"},
		    new SelectListItem{Value = "Mature Student - Living Away", Text = "Mature Student - Living Away"},
		    new SelectListItem{Value = "Medical Student - Living At Home", Text = "Medical Student - Living At Home"},
		    new SelectListItem{Value = "Medical Student - Living Away", Text = "Medical Student - Living Away"},
		    new SelectListItem{Value = "Student", Text = "Student"},
		    new SelectListItem{Value = "Student - Living At Home", Text = "Student - Living At Home"},
		    new SelectListItem{Value = "Student - Living Away", Text = "Student - Living Away"},
		    new SelectListItem{Value = "Student Nurse - Living At Home", Text = "Student Nurse - Living At Home"},
		    new SelectListItem{Value = "Student Nurse - Living Away", Text = "Student Nurse - Living Away"},
		    new SelectListItem{Value = "Student Teacher - Living At Home", Text = "Student Teacher - Living At Home"},
		    new SelectListItem{Value = "Student Teacher - Living Away", Text = "Student Teacher - Living Away"}
		};

	    public static List<SelectListItem> RidersInsured = new List<SelectListItem>
	    {
		    new SelectListItem{Value = "0", Text = "Insured only"},
		    new SelectListItem{Value = "1", Text = "Insured and named rider"}
	    };
	}
}
