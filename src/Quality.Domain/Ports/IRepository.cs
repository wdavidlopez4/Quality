using Quality.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Domain.Ports
{
    public interface IRepository
    {
        public Task<T> Guardar<T>(T obj) where T : EntityBase;

        public Task<T> Obtener<T>(string id) where T : EntityBase;

        public Task<T> Obtener<T>(Expression<Func<T, bool>> expression) where T : EntityBase;

        public Task<bool> Existe<T>(string id) where T : EntityBase;

        public Task<bool> Existe<T>(Expression<Func<T, bool>> expression) where T : EntityBase;
    }
}
