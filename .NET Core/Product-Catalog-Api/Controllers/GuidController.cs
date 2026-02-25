using Microsoft.AspNetCore.Mvc;
using Product_Catalog_Api.Repository.Repository;

namespace Product_Catalog_Api.Controllers
{
    [ApiController]
    [Route("api/lifetime")]
    public class GuidController : ControllerBase
    {
        private readonly ITransientService _transient1;
        private readonly ITransientService _transient2;
        private readonly IScopedService _scoped1;
        private readonly IScopedService _scoped2;
        private readonly ISingletonService _singleton1;

        public GuidController(
            ITransientService t1, ITransientService t2,
            IScopedService s1, IScopedService s2,
            ISingletonService sn1)
        {
            _transient1 = t1; _transient2 = t2;
            _scoped1 = s1; _scoped2 = s2;
            _singleton1 = sn1;
        }

        [HttpGet]
        public IActionResult Get() => Ok(new
        {
            Transient = new { id1 = _transient1.Id, id2 = _transient2.Id }, // Different IDs
            Scoped = new { id1 = _scoped1.Id, id2 = _scoped2.Id },          // Same IDs
            Singleton = new { id = _singleton1.Id }                        // Same ID forever
        });
    }

}
