using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Team10BookStore.Controllers
{
    public class CategoryController : ApiController
    {
        // GET api/Category
        public IEnumerable<Category> GetCategory()
        {
            return new BizLogic().ListCategory();
        }

        // GET api/Category/id
        public IEnumerable<Book> GetBookByCategory(String id)
        {
            return new BizLogic().ListBookByCategory((Convert.ToInt32(id)));
        }
    }
}
