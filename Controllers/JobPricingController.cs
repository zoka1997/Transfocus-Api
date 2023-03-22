using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransfocusBack.DBData;
using TransfocusBack.Models.DTO;
using TransfocusAPI.HelperClasses;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
                throw ex;
                //return new JsonResponse
                //{
                //    data = null,
                //    errorMessage = ex.Message,
                //    success = false,
                //    totalCount = 0
                //};
            }

        }
        [HttpGet]
        public JsonResponse GetJobLegsByJobID(Guid ID)
        {
            try
            {
                //var items = _context.JobLegs.Where(x => x.JobId == ID && x.Active == true)
                //                            .Include(x => x.Sender.Select(a => new Location { Name = a.ame, Address = a.Address, PostCode = a.PostCode, }))
                //                            .OrderBy(x => x.LegNumber)
                //                            .Select(x => x)
                //                            .ToList();
                IEnumerable<JobLeg> items = _context.JobLegs
                                            .Where(x => x.JobId == ID && x.Active == true)
                                            .OrderBy(x => x.LegNumber)
                                            .Select(x => new JobLeg
                                            {
                                                // select only the properties you need from JobLeg
                                                Id = x.Id,
                                                JobId = x.JobId,
                                                LegNumber = x.LegNumber,
                                                JobNumber = x.JobNumber,
                                                ConsignmentNumber = x.ConsignmentNumber,
                                                ManifestId = x.ManifestId,
                                                Timestamp = x.Timestamp,
                                                LegTotalKilometers = x.LegTotalKilometers,
                                                TripStatusId= x.TripStatusId,
                                                Podstatus = x.Podstatus,

                                                Manifest = x.Manifest != null ? new Manifest
                                                {
                                                    ManifestNumber = x.Manifest.ManifestNumber,
                                                    ManifestStatusId = x.Manifest.ManifestStatusId,
                                                } : null,

                                                Job = x.Job != null ? new Job
                                                {
                                                    TrackingCode = x.Job.TrackingCode,
                                                } : null,

                                                Sender = new Location
                                                {
                                                    Id = x.Sender.Id,
                                                    Name = x.Sender.Name,
                                                    Address = x.Sender.Address,
                                                    PostCode = x.Sender.PostCode,
                                                    State = x.Sender.State,
                                                    City = x.Sender.City,
                                                },

                                                Recepient = new Location
                                                {
                                                    Id = x.Recepient.Id,
                                                    Name = x.Recepient.Name,
                                                    Address = x.Recepient.Address,
                                                    PostCode = x.Recepient.PostCode,
                                                    State = x.Recepient.State,
                                                    City = x.Recepient.City,
                                                },

                                                Driver = x.Driver != null ? new User
                                                {
                                                    FirstName = x.Driver.FirstName,
                                                    LastName = x.Driver.LastName,
                                                } : null,

                                                Customer = new Customer
                                                {
                                                    Name = x.Customer.Name,
                                                    Id = x.Customer.Id,
                                                },

                                                TripStatus = new TripStatus
                                                {
                                                    Id = x.TripStatus.Id,
                                                    Name= x.TripStatus.Name,
                                                }

                                            })
                                            .ToList();


                return new JsonResponse { data = items, success = true, errorMessage = null, totalCount = items.Count() };
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

    }
}
