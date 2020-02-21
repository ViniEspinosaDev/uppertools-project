using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using CadastroEmpresasLibrary.Classes;
using Microsoft.Data.OData;

namespace CadastroEmpresasLibrary.Classes
{
    public class PessoaJuridicaController : ApiController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/PessoaJuridicas
        public async Task<IHttpActionResult> GetPessoaJuridicas([FromUri]string sort, [FromUri]string order)
        {
            // validate the query.
            try
            {
                //queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }
            List<PessoaJuridica> re = new PessoaJuridica().GetAll();
            if (order == "asc")
            {
                switch (sort)
                {
                    case "PessoaJuridicaId":
                        re = re.OrderBy(o => o.PessoaJuridicaId).ToList();
                        break;
                    case "Nome":
                        re = re.OrderBy(o => o.Nome).ToList();
                        break;
                    case "Abertura":
                        re = re.OrderBy(o => o.Abertura).ToList();
                        break;
                    default:
                        break;
                }
            }
            else if (order == "desc")
            {
                switch (sort)
                {
                    case "PessoaJuridicaId":
                        re = re.OrderByDescending(o => o.PessoaJuridicaId).ToList();
                        break;
                    case "Nome":
                        re = re.OrderByDescending(o => o.Nome).ToList();
                        break;
                    case "Abertura":
                        re = re.OrderByDescending(o => o.Abertura).ToList();
                        break;
                    default:
                        break;
                }
            }
            return Ok(re);
        }

        // GET: odata/PessoaJuridicas(5)
        public async Task<IHttpActionResult> GetPessoaJuridica([FromODataUri] int key, ODataQueryOptions<PessoaJuridica> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<PessoaJuridica>(PessoaJuridica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/PessoaJuridicas(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<PessoaJuridica> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(PessoaJuridica);

            // TODO: Save the patched entity.

            // return Updated(PessoaJuridica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/PessoaJuridicas
        public async Task<IHttpActionResult> Post(PessoaJuridica PessoaJuridica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(PessoaJuridica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/PessoaJuridicas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<PessoaJuridica> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(PessoaJuridica);

            // TODO: Save the patched entity.

            // return Updated(PessoaJuridica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/PessoaJuridicas(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}