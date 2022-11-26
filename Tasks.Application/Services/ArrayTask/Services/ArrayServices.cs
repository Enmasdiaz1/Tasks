using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Application.Services.ArrayTask.Interface;
using Tasks.Application.Services.ArrayTask.Models;
using Tasks.Domain.Interface;

namespace Tasks.Application.Services.ArrayTask.Services
{
    public class ArrayServices:IArrayTask_Sevices
    {
        private readonly IMapper _autoMapper;
        private readonly IArrayTask_Repository task_Repository;

        public ArrayServices(IMapper autoMapper, IArrayTask_Repository task_Repository)
        {
            _autoMapper = autoMapper;
            this.task_Repository = task_Repository;
        }

        public ArrayModel ReverseIt(string parametros)
        {
           var result= task_Repository.ReverseIt(parametros);
           return _autoMapper.Map<ArrayModel>(result);
        }
    }
}
