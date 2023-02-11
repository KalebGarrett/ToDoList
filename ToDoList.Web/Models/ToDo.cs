using System;

namespace ToDoList.Web.Models
{
    public class ToDo
    {
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool AllowEdit { get; set; }
        
        public ToDo(string text)
        {
            Text = text;
        }
    }
}