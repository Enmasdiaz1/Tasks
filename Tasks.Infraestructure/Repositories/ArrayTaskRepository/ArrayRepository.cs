using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Domain.Interface;
using Tasks.Domain.Models;

namespace Tasks.Infraestructure.Repositories.ArrayTaskRepository
{
    public class ArrayRepository : IArrayTask_Repository
    {
        public ArrayRepository()
        {
        }
        public ArrayModel_Domain ReverseIt(string parametros)
        {
            ArrayModel_Domain model = new ArrayModel_Domain();
            if (parametros != "")
            {
                int lenght = parametros.Length;
                char[] arr = new char[lenght];
                int cont = 0;

                for (int i = lenght - 1; i >= 0; i--)
                {
                    arr[cont++] = parametros[i];
                }
                model.Caracteres = arr;
            }
                return model;
        }
    }
}
