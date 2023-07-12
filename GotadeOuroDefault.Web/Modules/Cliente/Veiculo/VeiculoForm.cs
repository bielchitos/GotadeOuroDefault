using Serenity.ComponentModel;

namespace GotadeOuroDefault.Cliente.Forms;

[FormScript("Cliente.Veiculo")]
[BasedOnRow(typeof(VeiculoRow), CheckNames = true)]
public class VeiculoForm
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
}