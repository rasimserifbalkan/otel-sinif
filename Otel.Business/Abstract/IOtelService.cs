using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Abstract
{
    internal interface IOtelService
    {
        void Add(OtelModel otelModel);
        List<OtelModel> List();
        OtelModel Get(string name);
        OtelModel Get(int Id);
    }
}
