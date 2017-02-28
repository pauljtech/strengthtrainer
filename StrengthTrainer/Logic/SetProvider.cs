using AutoMapper;
using StrengthTrainer.Data;
using StrengthTrainer.Data.Entities;
using StrengthTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StrengthTrainer.Logic
{
    public class SetProvider
    {
        public async Task<SetModel> GetSet(int id)
        {
            var setModel = new SetModel();
            Set set = null;

            using (var db = new StrengthTrainerContext())
            {
                set = await db.Sets.FindAsync(id);    
            }

            if (set != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<Set, SetModel>());
                setModel = Mapper.Map<SetModel>(set);
            }

            return setModel;
        }
    }
}