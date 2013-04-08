using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oaWebNotes
{
    public partial class Note
    {
        private static List<Category> _categories;
        public static List<Category> Categories
        {
            get { return _categories ?? (_categories = DataHelper.EmWebNotes.Categories.ToList()); }
        }

        /// <summary>
        /// Field containing the name of the category from Categories table.
        /// </summary>
        public string CategoryName
        {
            get
            {
                Category _category = Categories.SingleOrDefault(c => c.FID == this.FCATEGORY_ID);
                return (_category == null) ? string.Empty : _category.FNAME;
            }
        }

        /// <summary>
        /// Field containing the first 100 chars of the content. Shown in grid.
        /// </summary>
        public string ContentShort
        {
            get
            {
                return (this.FCONTENT.Length > 100) ? (this.FCONTENT.Substring(0, 100) + "...") : this.FCONTENT;
            }
        }
    }
}
