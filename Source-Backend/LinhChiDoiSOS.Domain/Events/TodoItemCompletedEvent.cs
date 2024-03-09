using LinhChiDoiSOS.Domain.Common;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Events
{
    public class TodoItemCompletedEvent : BaseEvent
    {
        public TodoItemCompletedEvent(TodoItem item) {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
