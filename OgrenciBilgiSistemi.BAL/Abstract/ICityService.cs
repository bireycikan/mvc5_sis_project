using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface ICityService
    {
        List<City> GetCities();
        City GetCityById(byte id);
    }
}
