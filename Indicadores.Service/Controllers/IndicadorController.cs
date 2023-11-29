﻿using Indicadores.BL.Class;
using Indicadores.DA.Class;
using Indicadores.DA.Interface;
using Indicadores.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Indicadores.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadorController : ControllerBase
    {

        private IndicadorBL indicadorBL;

        public IndicadorController(IIndicadorDA indicadorDA)
        {
            this.indicadorBL = new IndicadorBL(indicadorDA);
        }


        [HttpPost]
        [Route("ListarIndicadores")]
        public async Task<IActionResult> ListarIndicadores()
        {
            try
            {
                var respuesta = await indicadorBL.listarIndicadores();

                return StatusCode(200, respuesta);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        [Route("InsertarIndicador")]
        public async Task<IActionResult> InsertarIndicador([FromBody] IndicadorInput indicadorInput)
        {
            try
            {
                var respuesta = await indicadorBL.InsertarIndicador(indicadorInput);

                return StatusCode(200, respuesta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("EliminarIndicador")]
        public async Task<IActionResult> EliminarIndicador([FromBody] int idIndicador)
        {
            try
            {
                var respuesta = await indicadorBL.EliminarIndicador(idIndicador);

                return StatusCode(200, respuesta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}