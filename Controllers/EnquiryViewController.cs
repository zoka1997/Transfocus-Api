using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransfocusBack.DBData;
using TransfocusBack.Models.DTO;

namespace TransfocusBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiryViewController : ControllerBase
    {
        private transfocusqa20229261212Context _context;
        public EnquiryViewController(transfocusqa20229261212Context context)
        {
            _context = context;
        }

        [HttpPost]
        public  JsonResponse Get()
        {
            try
            {
                var enqView = _context.EnquiryViews.Take(100).ToList();

                return new JsonResponse
                {
                    success = true,
                    data = enqView,
                    totalCount = enqView.Count()
                };
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }


        }

    }
}
