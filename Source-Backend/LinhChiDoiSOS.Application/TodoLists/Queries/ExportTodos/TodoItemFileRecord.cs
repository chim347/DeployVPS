using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string? Title { get; init; }

        public bool Done { get; init; }
    }
}
