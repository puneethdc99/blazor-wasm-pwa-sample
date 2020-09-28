using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrendModelService.Server.Models;
using TrendModelService.Shared;
namespace Server.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class TrendController : ControllerBase {
        private TrendContext _trendContext;
        public TrendController (TrendContext trendContext) {
            _trendContext = trendContext;
        }

        // GET api/trend
        [HttpGet ("")]
        public ActionResult<List<Trend>> Getstrings () {
            return _trendContext.Trends.ToList ();
        }

        // GET api/trend/5
        [HttpGet ("{id}")]
        public ActionResult<Trend> GetstringById (int id) {
            return _trendContext.Trends.FirstOrDefault (trend => trend.Id == id);
        }

        // POST api/trend
        [HttpPost ("")]
        public ActionResult<Trend> Poststring (Trend trend) {
            _trendContext.Trends.Add (trend);
            _trendContext.SaveChanges ();
            return trend;
        }

        // PUT api/trend/5
        [HttpPut ("{id}")]
        public ActionResult<Trend> Putstring (int id, Trend trend) {
            Trend newtrend = _trendContext.Trends.FirstOrDefault (trend => trend.Id == id);
            newtrend.AspectName = trend.AspectName;
            newtrend.TrendTrace = trend.TrendTrace;
            newtrend.TrendTreatment = trend.TrendTreatment;
            _trendContext.SaveChanges ();
            return newtrend;

        }

        // DELETE api/trend/5
        [HttpDelete ("{id}")]
        public void DeletestringById (int id) {
            Trend oldtrend = _trendContext.Trends.FirstOrDefault (trend => trend.Id == id);
            _trendContext.Trends.Remove (oldtrend);
            _trendContext.SaveChanges ();
        }
    }
}