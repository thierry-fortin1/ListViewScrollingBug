using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewScrollingBug
{
    public record Item
    {
        internal Item(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}
