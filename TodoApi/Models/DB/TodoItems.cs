using System;
using System.Collections.Generic;

namespace TodoApi.Models.DB
{
    public partial class TodoItems
    {
        public long Id { get; set; }
        public bool IsComplete { get; set; }
        public string Name { get; set; }
    }
}
