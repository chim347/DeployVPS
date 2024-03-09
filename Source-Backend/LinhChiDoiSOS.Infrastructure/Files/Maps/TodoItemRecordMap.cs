using CsvHelper.Configuration;
using LinhChiDoiSOS.Application.TodoLists.Queries.ExportTodos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Infrastructure.Files.Maps
{
    public class TodoItemRecordMap : ClassMap<TodoItemRecord>
    {
        public TodoItemRecordMap()
        {
            AutoMap(CultureInfo.InvariantCulture);

            Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
        }
    }
}
