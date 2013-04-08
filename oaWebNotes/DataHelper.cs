using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Telerik.OpenAccess;

namespace oaWebNotes
{
    public class DataHelper
    {
        private static emWebNotes _emWebNotes;
        private static readonly object _padLock = new object();

        public static emWebNotes EmWebNotes
        {
            get
            {
                if (_emWebNotes == null)
                {
                    lock (_padLock)
                    {
                        _emWebNotes = new emWebNotes(ConnectionString);
                    }
                }
                //return _emWebNotes ?? (_emWebNotes = new emWebNotes(ConnectionString));
                return _emWebNotes;
            }
        }

        public static string ConnectionString
        {
            get
            {
                var key = ConfigurationManager.ConnectionStrings["WebNoteConnection"];
                return key.ConnectionString;
            }
        }
    }
}
