using Serenity.ComponentModel;

namespace GotadeOuroDefault.Produto.Forms;

[FormScript("Produto.Marca")]
[BasedOnRow(typeof(MarcaRow), CheckNames = true)]
public class MarcaForm
{
    public string Nome { get; set; }
    public bool MarcaNacional { get; set; }
}