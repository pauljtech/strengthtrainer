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
            Set set = null;

            using (var db = new StrengthTrainerContext())
            {
                set = await db.Sets.FindAsync(id);    
            }

            SetModel setModel = null;
            // map data to model
            if (set != null)
            {
                setModel = new SetModel();
                Mapper.Initialize(cfg => cfg.CreateMap<Set, SetModel>());
                setModel = Mapper.Map<SetModel>(set);
                setModel.WeightType = set.WeightType.ToString();
            }

            return setModel;
        }

        public async Task<bool> StoreSet(Set set)
        {
            int result = 0;

            using (var db = new StrengthTrainerContext())
            {
                db.Sets.Add(set);
                result = await db.SaveChangesAsync();
            }

            // The task result contains the number of objects written to the underlying database.
            return result > 0;
        }
    }
}