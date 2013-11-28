using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarryPotter.Domain;

namespace HarryPotter.Services
{
    public interface IOrderService
    {
        void Create(Order order);
    }
}
