namespace Scarpe_Co.Models
{
    public class StaticDB
    {
        private static int _prodId = 1;
        private static List<Details> _prodotti = [
            new Details() { Id = 1, Name = "Flowing Plume", Description = "Scarpe Ginnastica Uomo Traspirante Running Corsa Leggero Camminata Casual Comode Basse Baskets Sportive Fitness Sneakers", BgImgUrl = "https://m.media-amazon.com/images/S/stores-image-uploads-eu-prod/8/AmazonStores/APJ6JRA9NG5V4/aaaa0b6d8c478f14cdc15c259362e30f.w3000.h600._CR0%2C0%2C3000%2C600_SX1500_.jpg", ImgUrl = "https://m.media-amazon.com/images/I/714z2wSZ+5L._AC_SY575_.jpg", ImgUrl2 = "https://m.media-amazon.com/images/I/71JvIt369AL._AC_SY575_.jpg", ImgUrl3 = "https://m.media-amazon.com/images/I/71-OFG54pnL._AC_SY575_.jpg", Price = 19.99M }
            ];

        public static List<Details> GetAll() 
        { 
            return _prodotti; 
        }

        public static Details GetById(int? Id)
        {
            for (int i = 0;  i < _prodotti.Count; i++)
            {
                Details prodotto = _prodotti[i];
                if (_prodotti[i].Id == Id)
                {
                    return prodotto;
                }
            }
            return null;
        }

        public static Details Add(int Id, string Name, string Description, string BgImgUrl, string ImgUrl, string ImgUrl2, string ImgUrl3, decimal Price)
        {
            _prodId++;
            var prodotto = new Details()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                BgImgUrl = BgImgUrl,
                ImgUrl = ImgUrl,
                ImgUrl2 = ImgUrl2,
                ImgUrl3 = ImgUrl3,
                Price = Price
            };
            _prodotti.Add(prodotto);
            return prodotto;
        }

        public static Details Edit(int Id, string Name, string Description, string BgImgUrl, string ImgUrl, string ImgUrl2, string ImgUrl3, decimal Price)
        {
            foreach (var prodotto in _prodotti)
            {
                if (prodotto.Id == Id)
                {
                    prodotto.Id = Id;
                    prodotto.Name = Name;
                    prodotto.Description = Description;
                    prodotto.BgImgUrl = BgImgUrl;
                    prodotto.ImgUrl = ImgUrl;
                    prodotto.ImgUrl2 = ImgUrl2;
                    prodotto.ImgUrl3 = ImgUrl3;
                    prodotto.Price = Price;
                    return prodotto;
                }
            }

            return null;
        }

        public static Details Delete(int Id)
        {
            foreach (var prodotto in _prodotti)
            {
                if(prodotto.Id == Id)
                {
                    _prodotti.Remove(prodotto);
                }
            }

            return null;
        }

    }
}
