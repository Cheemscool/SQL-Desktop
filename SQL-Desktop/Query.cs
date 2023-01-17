using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Desktop
{
    internal class Query
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Query(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
