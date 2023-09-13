﻿using La8b.Models;
using Lab8.Interfaces;
using Lab8.Models;
using Microsoft.AspNetCore.Mvc;

namespace La8b.Controllers
{
    /// <summary>
    /// Working with Lera
    /// </summary>
    [ApiController]
    [Route("api/lera")]
    public class LeraController : ControllerBase
    {
        private ITD _tdService;

        public LeraController(ITD tdService)
        {
            _tdService = tdService;
        }

        /// <summary>
        /// Get list of all leras
        /// </summary>
        /// <returns>
        /// List of leras
        /// </returns>
        [HttpGet]
        async public Task<IEnumerable<Lera>> GetAll()
        {
            return _tdService.GetAll();
        }

        /// <summary>
        /// Get one Lera by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        async public Task<Lera> Get(int id)
        {
            return _tdService.Get(id);
        }

        /// <summary>
        /// Create new Lera
        /// </summary>
        /// <param name="lera"></param>
        /// <returns></returns>
        [HttpPost]
        async public Task Add(NewLera lera)
        {
            _tdService.Add(lera);
        }

        /// <summary>
        /// Delete Lera by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        async public Task Delete(int id)
        {
            _tdService.Delete(id);
        }


        /// <summary>
        /// Update Lera by Id
        /// </summary>
        /// <param name="lera"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        async public Task Update(int id, NewLera lera)
        {
            _tdService.Update(id, lera);
        }
    }
}
