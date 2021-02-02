using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Ports
{
    public interface IAutoMapeo
    {
        public TDestination Map<TSource, TDestination>(TSource source);
    }
}
