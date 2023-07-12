using Serenity.Navigation;
using MyPages = GotadeOuroDefault.Produto.Pages;

[assembly: NavigationLink(int.MaxValue, "Produto/Marca", typeof(MyPages.MarcaPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Produto/Produto", typeof(MyPages.ProdutoPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Produto/Tipode Produto", typeof(MyPages.TipodeProdutoPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Produto/Viscosidade", typeof(MyPages.ViscosidadePage), icon: null)]