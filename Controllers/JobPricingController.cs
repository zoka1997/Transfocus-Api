using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransfocusBack.DBData;
using TransfocusBack.Models.DTO;
using TransfocusAPI.HelperClasses;

namespace TransfocusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPricingController : ControllerBase
    {
        private readonly transfocusqa20229261212Context _context;

        public JobPricingController(transfocusqa20229261212Context context)
        {
            this._context = context;
        }

        [HttpPost]
        public JsonResponse GetJobPricing(Guid ID)
        {

            try
            {
                var data = _context.JobPricings.Where(x => x.JobId == ID)
                    .OrderBy(x => x.OrderNumber)
                    .Select(x => new JobPricingList
                    {
                        PricingID = x.Id,
                        PricingItem = x.PricingItem != null ? x.PricingItem.Description : null,
                        Description = x.PricingItem.Description + " (" + x.PricingItem.Code + ")",
                        Amount = x.Amount,
                        ApplyFuelLevy = x.ApplyFuelLevy,
                        ChargeUnit = x.PricingItem.ChargeUnitId,
                        Quantity = x.Quantity,
                        UnitRate = x.UnitRate
                    });

                return new JsonResponse
                {
                    data = data,
                    success = true,
                    errorMessage = null,
                    totalCount = data.Count()
                };
            }
            catch (Exception ex)
            {
                return new JsonResponse
                {
                    data = new { },
                    errorMessage = ex.Message,
                    success = false,
                    totalCount = 0
                };
            }

        }


    }
}
