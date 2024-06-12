namespace MVC_Uygulamasi
{
    public class DataUtility
    {
        HttpClient client = new HttpClient();

        public async Task<List<Product>> VerileriGetir(string url)
        {
            var data = await client.GetFromJsonAsync<List<Product>>(url);
            return data;
        }

        public async Task VeriEkle(string url, Product product) 
        {
            await client.PostAsJsonAsync<Product>(url, product);
        }

        public async Task<Product> VeriGetir(string url, int id)
        {
            return await client.GetFromJsonAsync<Product>(url+""+id);
        }

        public async Task VeriGuncelle(string url, Product product)
        {
            await client.PutAsJsonAsync<Product>(url+""+product.ProductID, product);
        }

        public async Task VeriSil(string url)
        {
            await client.DeleteAsync(url);
        }
    }
}
