﻿using EcommerseApplication.Models;

namespace EcommerseApplication.Repository
{
    public class RequestRepository : IRequest
    {
        private readonly Context context;

        public RequestRepository(Context _con)
        {
            context = _con;
        }

        public List<Requests> GetAllRequests()
        {
            List<Requests> All=context.Requests.ToList();
            return All;
        }

        public void RequestTobePartner(Requests request)
        {
         context.Requests.Add(request);
         context.SaveChanges();
        }
        public Requests GetPartnerById(int id)
        {
            return context.Requests.FirstOrDefault(i => i.RequestId == id);
            
        }


    }
}

