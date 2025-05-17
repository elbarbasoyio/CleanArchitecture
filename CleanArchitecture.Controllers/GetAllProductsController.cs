using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputport;
        readonly IGetAllProductsOutputPort _outputPort;
        public GetAllProductsController(IGetAllProductsInputPort getAllProductsInputport, IGetAllProductsOutputPort getAllProductsOutputPort)
        {
            _inputport = getAllProductsInputport;
            _outputPort = getAllProductsOutputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _inputport.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
        }
    }
}
