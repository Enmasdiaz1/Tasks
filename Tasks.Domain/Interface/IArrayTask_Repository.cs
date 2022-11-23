using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Domain.Models;

namespace Tasks.Domain.Interface
{
    public interface IArrayTask_Repository
    {
        ArrayModel_Domain ReverseIt(string parametros);
    }
}
