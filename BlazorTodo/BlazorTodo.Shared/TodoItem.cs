using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTodo.Shared
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public bool IsInEdit { get; set; }
    }
}
