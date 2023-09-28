using Mediate.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features
{
    public class SampleEvent : IEvent
    {
        public string EventData { get; set; }
    }
}
