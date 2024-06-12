using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BookShop.Data.Manager
{
    public class AdminManager : BaseManager<Admin>
    {
        public Admin AdminBul(string email, string sifre)
        {
            return Listele(x => x.MailAdresi == email && x.Sifre == sifre).FirstOrDefault();
        }

        public void Ekle(Admin entity)
        {
            entity.Sifre = Sifrele(entity.Sifre);
            base.Ekle(entity);
        }

        public void Guncelle(Admin entity)
        {
            entity.Sifre = Sifrele(entity.Sifre);
            base.Guncelle(entity);
        }

        public string Sifrele(string sifre)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifre);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
                sb.Append(ba.ToString("x2").ToLower());

            return sb.ToString();
        }
    }
}
