﻿using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UsuarioCrudFactory : CrudFactory
    {

      public UsuarioCrudFactory()
        {
            _dao = SqlDao.GetInstance();
        }


        public override void Create(BaseDTO baseDTO)
        {
            throw new NotImplementedException();

        }

        public override void Delete(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {

            throw new NotImplementedException();


        }

        public override T RetrieveById<T>(int id)
        {
            throw new NotImplementedException();

        }

    

        public T RetrieveByEmail<T>(int id)
        {
            throw new NotImplementedException();
        }


        public override void Update(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }

    }
}