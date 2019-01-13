using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Team10BookStore.Controllers
{
    public class BookController : ApiController
    {
        //GET api/Book/id
        public Book GetBook(String id)
        {
            return new BizLogic().GetBook(Convert.ToInt32(id));
        }

        // POST update book
        [HttpPost]
        [Route("api/Book/update")]
        public int update([FromBody] Book book)
        {
            return new BizLogic().UpdateBook(book);
        }
    }
}
