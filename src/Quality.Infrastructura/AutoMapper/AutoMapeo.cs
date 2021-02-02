using AutoMapper;
using Quality.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Infrastructura.AutoMapper
{
    public class AutoMapeo : IAutoMapeo
    {
        private readonly IMapper mapper;

        public AutoMapeo(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return mapper.Map<TSource, TDestination>(source);
        }
    }
}
