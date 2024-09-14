
using System.Xml.Serialization;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    Random random = new Random();


    
    private void RollButton_Clicked(object sender, EventArgs e) {
       
        double qtdDados = Convert.ToDouble(DiceEntry.Text);
        int soma = 0;
        string resultados = "";
        int numeroSorteado = 0;
        int numeroSelecionado = 0;

        for (int i = 0; i < qtdDados; i++)
        {
            
             numeroSelecionado = Convert.ToInt32(SidesPicker.SelectedItem);
            numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
            soma  = soma +  numeroSorteado;
            
        }
       ResultLabel.Text = numeroSorteado.ToString();
        ResultLabel.Text = "Você tirou: " +  soma.ToString();    
        

    }

    
    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

