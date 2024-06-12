﻿using MehmetHusnaKisla.Domain.Entities;
using MehmetHusnaKisla.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Infrastructure.Concrete
{
    public class EssayRepository : BaseRepository<Essay>, IEssayRepository
    {
        public EssayRepository(Context context) : base(context) { }
    }
}
