using Serenity.ComponentModel;

namespace GotadeOuroDefault.Produto.Forms;

[FormScript("Produto.Viscosidade")]
[BasedOnRow(typeof(ViscosidadeRow), CheckNames = true)]
public class ViscosidadeForm
{
    public string SiglaViscosidade { get; set; }
}