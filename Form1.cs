namespace HerosWinForms;

public partial class Form1 : Form
{

    private TextBox campoNome;
    private TextBox campoCPF;
    private TextBox campoDataNasc;
    private TextBox campoGenero;
    private TextBox campoEstadoCivil;
    private TextBox campoEmail;
    private TextBox campoTelefoneCelular;
    private TextBox campoTelefoneFixo;
    private TextBox campoCEP;
    private TextBox campoEndereco;
    private TextBox campoNumeroCasa;
    private TextBox campoBairro;
    private TextBox campoCidade;
    private TextBox campoEstado;
    private TextBox campoObs;



    public Form1()
    
    
    {

        InitializeComponent();
        MessageBox.Show("Bem-vindos ao meu sistema");
        this.Text = "iae paezao";
        
        campoNome = new TextBox();//cria o campo de texto
        campoNome.Location = new Point(50,50);//defini onde o campo fica na tela
        campoNome.Width = 450;
        Controls.Add(campoNome);

        campoCPF = new TextBox();//cria o campo de texto
        campoCPF.Location = new Point(510,50);//defini onde o campo fica na tela
        campoCPF.Width = 150;
        Controls.Add(campoCPF);

        campoDataNasc = new TextBox();//cria o campo de texto
        campoDataNasc.Location = new Point(50,115);//defini onde o campo fica na tela
        campoDataNasc.Width = 150;
        Controls.Add(campoDataNasc);

        campoGenero = new TextBox();//cria o campo de texto
        campoGenero.Location = new Point(290,115);//defini onde o campo fica na tela
        campoGenero.Width = 150;
        Controls.Add(campoGenero);

        campoEstadoCivil = new TextBox();//cria o campo de texto
        campoEstadoCivil.Location = new Point(510,115);//defini onde o campo fica na tela
        campoEstadoCivil.Width = 150;
        Controls.Add(campoEstadoCivil);

        campoEmail = new TextBox();//cria o campo de texto
        campoEmail.Location = new Point(50,180);//defini onde o campo fica na tela
        campoEmail.Width = 610;
        Controls.Add(campoEmail);

        campoTelefoneCelular = new TextBox();//cria o campo de texto
        campoTelefoneCelular.Location = new Point(50,245);//defini onde o campo fica na tela
        campoTelefoneCelular.Width = 295;
        Controls.Add(campoTelefoneCelular);

        campoTelefoneFixo = new TextBox();//cria o campo de texto
        campoTelefoneFixo.Location = new Point(365,245);//defini onde o campo fica na tela
        campoTelefoneFixo.Width = 295;
        Controls.Add(campoTelefoneFixo);

        campoCEP = new TextBox();//cria o campo de texto
        campoCEP.Location = new Point(50,310);//defini onde o campo fica na tela
        campoCEP.Width = 150;
        Controls.Add(campoCEP);

        campoEndereco = new TextBox();//cria o campo de texto
        campoEndereco.Location = new Point(290,310);//defini onde o campo fica na tela
        campoEndereco.Width = 150;
        Controls.Add(campoEndereco);

        campoNumeroCasa = new TextBox();//cria o campo de texto
        campoNumeroCasa.Location = new Point(510,310);//defini onde o campo fica na tela
        campoNumeroCasa.Width = 150;
        Controls.Add(campoNumeroCasa);

        campoBairro = new TextBox();//cria o campo de texto
        campoBairro.Location = new Point(50,375);//defini onde o campo fica na tela
        campoBairro.Width = 150;
        Controls.Add(campoBairro);

        campoCidade = new TextBox();//cria o campo de texto
        campoCidade.Location = new Point(290,375);//defini onde o campo fica na tela
        campoCidade.Width = 150;
        Controls.Add(campoCidade);

        campoEstado = new TextBox();//cria o campo de texto
        campoEstado.Location = new Point(510,375);//defini onde o campo fica na tela
        campoEstado.Width = 150;
        Controls.Add(campoEstado);

        campoObs = new TextBox();//cria o campo de texto
        campoObs.Location = new Point(50,440);//defini onde o campo fica na tela
        campoObs.Width = 610;
        Controls.Add(campoObs);


    





    }
    protected override void OnPaint(PaintEventArgs e){
      // Linha 1: Y = 30 (mais acima)
    TextRenderer.DrawText(e.Graphics, "1. Nome Completo", Font, new Point(50, 20), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "2. (CPF)", Font, new Point(510, 20), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "3. (Data de Nascimento)", Font, new Point(50, 85), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "4. (Gênero)", Font, new Point(290, 85), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "5. (Estado Civil)", Font, new Point(510, 85), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "6. (Email)", Font, new Point(50, 150), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "7. (Telefone Calular)", Font, new Point(50, 215), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "8. (Telefone Fixo)", Font, new Point(365, 215), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "9. (CEP)", Font, new Point(50, 280), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "10. (Endereço)", Font, new Point(290, 280), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "11. (Número)", Font, new Point(510, 280), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "12. (Bairro)", Font, new Point(50, 345), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "13. (Cidade)", Font, new Point(290, 345), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "14. (Estado)", Font, new Point(510, 345), Color.Blue);
    TextRenderer.DrawText(e.Graphics, "15. (Observações)", Font, new Point(50, 410), Color.Blue);



    }
}

