using System.Collections.Generic;
using ToDoList.Web.Models;

namespace ToDoList.Web.Pages
{
    public partial class Index
    {
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();

        public ToDo NewToDo { get; set; } = new ToDo("");

        public void OnAddNewClick()
        {
            ToDos.Add(NewToDo);
            NewToDo = new ToDo("");
        }

        public void OnDeleteClick(ToDo item)
        {
            ToDos.Remove(item);
        }

        public void OnEditClick(ToDo item)
        {
            item.AllowEdit = !item.AllowEdit;
        }
    }
}