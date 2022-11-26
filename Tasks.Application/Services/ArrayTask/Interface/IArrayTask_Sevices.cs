using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Application.Services.ArrayTask.Models;

namespace Tasks.Application.Services.ArrayTask.Interface
{
    public interface IArrayTask_Sevices
    {
        ArrayModel ReverseIt(string parametros);
    }
}
