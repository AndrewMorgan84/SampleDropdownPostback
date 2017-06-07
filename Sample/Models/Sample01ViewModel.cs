using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Models
{
    public class Sample01ViewModel
    {
        public string SelectedCountry { get; set; }
        public List<Country> countries
        {
            get
            {
                return new List<Country>()
                {
                    new Country() {Id = "IN", Name = "India"},
                    new Country() {Id = "FN", Name = "France"},
                    new Country() {Id = "EN", Name = "England"},
                    new Country() {Id = "IT", Name = "Italy"},
                    new Country() {Id = "GR", Name = "Germany"},
                    new Country() {Id = "ES", Name = "Spain"},
                    new Country() {Id = "US", Name = "United States Of America"}
                };
                
            }
        }

        public IEnumerable<SelectListItem> GetCountriesListItems()
        {
            return countries.Select(c => new SelectListItem()
            {
                Text = c.Id + " - " + c.Name,
                Value= c.Id,
                Selected = (c.Id == SelectedCountry)
            });
        }
    }
}