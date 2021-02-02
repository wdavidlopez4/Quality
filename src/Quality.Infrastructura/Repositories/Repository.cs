using Quality.Domain.Entities;
using Quality.Domain.Ports;
using Quality.Infrastructura.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Infrastructura.Repositories
{
    public class Repository : IRepository
    {
        private readonly QualityContext beerContext;

        public Repository(QualityContext beerContext)
        {
            this.beerContext = beerContext;
        }

        public async Task<bool> Existe<T>(string id) where T : EntityBase
        {
            try
            {
                //hace falta convertirlo en metodo sincronico. solamente devuelve un resultado sincronico
                //pero el metodo no es sincronico
                return await Task.FromResult(beerContext.Set<T>().AsQueryable().Any(x => x.Id == id));
            }
            catch (Exception e)
            {
                throw new Exception($"no se pudo verificar si existe la entidad: {e.Message}");
            }
        }

        public async Task<bool> Existe<T>(Expression<Func<T, bool>> expression) where T : EntityBase
        {
            try
            {
                //hace falta convertirlo en metodo sincronico. solamente devuelve un resultado sincronico
                //pero el metodo no es sincronico
                return await Task.FromResult(beerContext.Set<T>().AsQueryable().Any(expression));
            }
            catch (Exception e)
            {

                throw new Exception($"no se pudo verificar si existe la entidad: {e.Message}");
            }
        }

        public async Task<T> Guardar<T>(T obj) where T : EntityBase
        {
            try
            {
                //añadimos el objeto
                var entity = await beerContext.Set<T>().AddAsync(obj);

                //ejecutamos el guardado
                if (await beerContext.SaveChangesAsync() < 0)
                    throw new Exception("no se guardo la entidad");

                //retornamos la entidad guardada
                return entity.Entity;
            }
            catch (Exception e)
            {
                throw new Exception($"no se pudo guardar la entidad: {e.Message}");
            }
        }

        public async Task<T> Obtener<T>(string id) where T : EntityBase
        {
            try
            {
                return await beerContext.Set<T>().FindAsync(id);
            }
            catch (Exception e)
            {

                throw new Exception($"no se pudo obtener la entidad {e.Message}");
            }
        }

        public async Task<T> Obtener<T>(Expression<Func<T, bool>> expression) where T : EntityBase
        {
            try
            {
                return await beerContext.Set<T>().FindAsync(expression);
            }
            catch (Exception e)
            {

                throw new Exception($"no se pudo obtener la entidad {e.Message}");
            }
        }



    }
}
