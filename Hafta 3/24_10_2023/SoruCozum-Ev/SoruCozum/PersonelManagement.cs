using SoruCozum.Interfaces;
using SoruCozum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum
{
    internal class PersonelManagement : IManagement<Personel>
    {
        List<Personel> _personeller = new List<Personel>();
        public void Add(Personel entity)
        {
            _personeller.Add(entity);
        }

        public List<Personel> GetAll()
        {
            return _personeller;
        }

        public Personel GetById(int id)
        {
            foreach(Personel personel in _personeller)
            {
                if(personel.PersonelID == id) 
                    return personel;
            }

            return null;
        }

        public void Remove(Personel entity)
        {
            _personeller.Remove(entity);
        }

        public void Update(Personel entity)
        {
            Remove(GetById(entity.PersonelID));
            Add(entity);
        }

        public IEnumerable<Personel> TamZamanliPersoneller()
        {
            foreach (Personel personel in _personeller)
            {
                if (personel is TamZamanliPersonel)
                    yield return personel;
            }
        }

        public IEnumerable<Personel> YariZamanliPersoneller()
        {
            foreach (Personel personel in _personeller)
            {
                if (personel is YariZamanliPersonel)
                    yield return personel;
            }
        }
    }
}
