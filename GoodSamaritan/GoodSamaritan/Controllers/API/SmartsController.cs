﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GoodSamaritan.Models.Client;
using GoodSamaritan.Models.Smart;

namespace GoodSamaritan.Controllers.API
{
    public class SmartsController : ApiController
    {
        private ClientContext db = new ClientContext();

        // GET: api/Smarts
        public IQueryable<Smart> GetSmarts()
        {
            return db.Smarts;
        }

        // GET: api/Smarts/5
        [ResponseType(typeof(Smart))]
        public IHttpActionResult GetSmart(int id)
        {
            Smart smart = db.Smarts.Find(id);
            if (smart == null)
            {
                return NotFound();
            }

            return Ok(smart);
        }

        // PUT: api/Smarts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSmart(int id, Smart smart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smart.SmartId)
            {
                return BadRequest();
            }

            db.Entry(smart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Smarts
        [ResponseType(typeof(Smart))]
        public IHttpActionResult PostSmart(Smart smart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Smarts.Add(smart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = smart.SmartId }, smart);
        }

        // DELETE: api/Smarts/5
        [ResponseType(typeof(Smart))]
        public IHttpActionResult DeleteSmart(int id)
        {
            Smart smart = db.Smarts.Find(id);
            if (smart == null)
            {
                return NotFound();
            }

            db.Smarts.Remove(smart);
            db.SaveChanges();

            return Ok(smart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SmartExists(int id)
        {
            return db.Smarts.Count(e => e.SmartId == id) > 0;
        }
    }
}