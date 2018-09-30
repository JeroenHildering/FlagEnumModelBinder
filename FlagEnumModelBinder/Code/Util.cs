using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FlagEnumModelBinder.Code
{
    public static class Util
    {
        /// <summary>
        /// Convert an enumeration to a Mvc.SelectList for use in dropdowns. Note that the enumeration values must all be added to a resource file.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="enumObj">The enum obj.</param>
        /// <param name="sortAlphabetically">If set to <c>true</c> [the list is sorted alphabetically].</param>
        /// <returns></returns>
        public static SelectList ToSelectList<TEnum>( this TEnum enumObj, bool sortAlphabetically = true )
        {
            IList<SelectListItem> values =
                        ( from TEnum e in Enum.GetValues( typeof( TEnum ) )
                          select new SelectListItem
                          {
                              Text = e.ToString(),
                              Value = e.ToString()
                          } ).ToList();

            if ( sortAlphabetically )
                values = values.OrderBy( v => v.Text ).ToList();

            return new SelectList( values, "Value", "Text", enumObj );
        }
    }
}