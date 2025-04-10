using DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    //Open closed Principle
    public abstract class ViewData
    {
        protected Database database = new Database();
        public abstract List<T> retrieveData<T>() where T : class;
    }
}
