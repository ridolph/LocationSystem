﻿using LocationServices.Locations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TEntity = Location.TModel.Location.AreaAndDev.Tag;
using Location.TModel.Location.AreaAndDev;

namespace WebApiService.Controllers
{
    [RoutePrefix("api/tags")]
    public class TagController : ApiController, ITagService
    {
        ITagService service;

        public TagController()
        {
            service = new TagService();
        }

        public bool AddList(List<TEntity> entities)
        {
            return service.AddList(entities);
        }
        public bool DeleteAll()
        {
            return service.DeleteAll();
        }

        [Route("{id}")]
        public TEntity Delete(string id)
        {
            return service.Delete(id);
        }

        [Route("")]//area/?id=1
        [Route("{id}")]
        public TEntity GetEntity(string id)
        {
            return service.GetEntity(id);
        }

        [Route("")]
        [Route("list")]
        public IList<TEntity> GetList()
        {
            return service.GetList();
        }

        [Route("")]//search/?name=主
        [Route("search/{name}")]//search/1,直接中文不行
        public IList<TEntity> GetListByName(string name)
        {
            return service.GetListByName(name);
        }

        [Route]
        public TEntity Post(TEntity item)
        {
            return service.Post(item);
        }

        [Route]
        public TEntity Put(TEntity item)
        {
            return service.Put(item);
        }
    }
}