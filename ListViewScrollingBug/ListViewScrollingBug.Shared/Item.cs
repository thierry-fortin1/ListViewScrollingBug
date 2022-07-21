using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewScrollingBug
{
    public record Item
    {
        internal Item(string content)
        {
            Id = Guid.NewGuid().ToString();
            Content = content;
        }

        public string Id { get; set; }  
        public string Content { get; set; }
    }
}
