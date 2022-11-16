﻿using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public class HistoriqueTravelRepository : Repository<HistoriqueTravel>, IHistoriqueTravelRepository
    {
        private readonly JungleDbContext _db;

        public HistoriqueTravelRepository(JungleDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(HistoriqueTravel historiqueTravel)
        {
            _db.Update(historiqueTravel);
        }
    }
}
