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
    public class CreateProductController
    {
        readonly ICreateProductInputPort _inputport;
        readonly ICreateProductOutputPort _outputPort;
        public CreateProductController(ICreateProductInputPort createProductInputport, ICreateProductOutputPort createProductOutputPort)
        {
            _inputport = createProductInputport;
            _outputPort = createProductOutputPort;
        }

        [HttpPost]
        public async Task<ProductDTO> CreateProducts(CreateProductDTO productDTO)
        {
            await _inputport.Handle(productDTO);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
