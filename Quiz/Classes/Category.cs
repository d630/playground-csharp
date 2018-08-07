using System.Collections.Generic;

namespace Quiz.Classes
{

    /*
     * This class is for specifiying all categories.
     *
     * TODO: This class should have beend named "CountryCategory". Also, the dictionaries'
     * values doesn't matter in this App right now.
    */

    public class Category
    {
        private IDictionary<string, string> categories;

        public Category()
        {
            this.categories = new SortedDictionary<string, string>
            {
                { "capital", "capital"},
                { "country", "country"},
                { "flag", "flag" }
            };
        }

        public IDictionary<string, string> Categories
        {
            get { return categories; }
        }
    }
}
