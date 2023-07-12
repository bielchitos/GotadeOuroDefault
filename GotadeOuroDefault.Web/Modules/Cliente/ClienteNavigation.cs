using Serenity.Navigation;
using MyPages = GotadeOuroDefault.Cliente.Pages;

[assembly: NavigationLink(int.MaxValue, "Cliente/Cliente", typeof(MyPages.ClientePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Cliente/Veiculo", typeof(MyPages.VeiculoPage), icon: null)]