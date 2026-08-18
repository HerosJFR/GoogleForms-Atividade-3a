namespace HerosWinForms;
public partial class Form1 : Form{
    private TextBox campoNome;
    private TextBox campoSexo;
    private TextBox campoDataNasc;
    private TextBox campoCPF;
    private TextBox campoRg;
    private TextBox campoEstadoCivil;
    private TextBox campoEmail;
    private TextBox campoTelefoneCelular;
    private TextBox campoTelefoneFixo;
    private TextBox campoCEP;
    private TextBox campoEndereco;
    private TextBox campoNumeroCasa;
    private TextBox campoComplemento;
    private TextBox campoBairro;
    private TextBox campoCidade;
    private TextBox campoEstado;
    private TextBox campoCurso;
    private TextBox campoMatricula;
    private TextBox campoAno;
    private TextBox campoModalidade;
    private TextBox campoTurno;
    private TextBox campoEscolaridade;
    private TextBox campoNomeResponsavel;
    private TextBox campoCPFResponsavel;
    private TextBox campoObs;

    public Form1(){
        InitializeComponent();
        MessageBox.Show("Bem-vindos ao meu sistema");
        this.Text = "Iae paezão";

        campoNome = new TextBox();//cria o campo de texto
        campoNome.Location = new Point(50,50);//defini onde o campo fica na tela
        campoNome.Width = 490;
        Controls.Add(campoNome);

        campoSexo = new TextBox();//cria o campo de texto
        campoSexo.Location = new Point(650,50);//defini onde o campo fica na tela
        campoSexo.Width = 150;
        Controls.Add(campoSexo);

        campoDataNasc = new TextBox();//cria o campo de texto
        campoDataNasc.Location = new Point(50,115);//defini onde o campo fica na tela
        campoDataNasc.Width = 200;
        Controls.Add(campoDataNasc);

        campoCPF = new TextBox();//cria o campo de texto
        campoCPF.Location = new Point(260,115);//defini onde o campo fica na tela
        campoCPF.Width = 200;
        Controls.Add(campoCPF);

        campoRg = new TextBox();//cria o campo de texto
        campoRg.Location = new Point(470,115);//defini onde o campo fica na tela
        campoRg.Width = 172;
        Controls.Add(campoRg);

        campoEstadoCivil = new TextBox();//cria o campo de texto
        campoEstadoCivil.Location = new Point(650,115);//defini onde o campo fica na tela
        campoEstadoCivil.Width = 200;
        Controls.Add(campoEstadoCivil);

        campoEmail = new TextBox();//cria o campo de texto
        campoEmail.Location = new Point(50,175);//defini onde o campo fica na tela
        campoEmail.Width = 265;
        Controls.Add(campoEmail);

        campoTelefoneCelular = new TextBox();//cria o campo de texto
        campoTelefoneCelular.Location = new Point(325,175);//defini onde o campo fica na tela
        campoTelefoneCelular.Width = 315;
        Controls.Add(campoTelefoneCelular);

        campoTelefoneFixo = new TextBox();//cria o campo de texto
        campoTelefoneFixo.Location = new Point(650,175);//defini onde o campo fica na tela
        campoTelefoneFixo.Width = 275;
        Controls.Add(campoTelefoneFixo);

        campoCEP = new TextBox();//cria o campo de texto
        campoCEP.Location = new Point(50,310);//defini onde o campo fica na tela
        campoCEP.Width = 150;
        Controls.Add(campoCEP);

        campoEndereco = new TextBox();//cria o campo de texto
        campoEndereco.Location = new Point(260,310);//defini onde o campo fica na tela
        campoEndereco.Width = 150;
        Controls.Add(campoEndereco);

        campoNumeroCasa = new TextBox();//cria o campo de texto
        campoNumeroCasa.Location = new Point(470,310);//defini onde o campo fica na tela
        campoNumeroCasa.Width = 150;
        Controls.Add(campoNumeroCasa);

        campoComplemento = new TextBox();//cria o campo de texto
        campoComplemento.Location = new Point(650,310);//defini onde o campo fica na tela
        campoComplemento.Width = 150;
        Controls.Add(campoComplemento);

        campoBairro = new TextBox();//cria o campo de texto
        campoBairro.Location = new Point(50,375);//defini onde o campo fica na tela
        campoBairro.Width = 150;
        Controls.Add(campoBairro);

        campoCidade = new TextBox();//cria o campo de texto
        campoCidade.Location = new Point(325,375);//defini onde o campo fica na tela
        campoCidade.Width = 150;
        Controls.Add(campoCidade);

        campoEstado = new TextBox();//cria o campo de texto
        campoEstado.Location = new Point(650,375);//defini onde o campo fica na tela
        campoEstado.Width = 150;
        Controls.Add(campoEstado);

        campoCurso = new TextBox();//cria o campo de texto
        campoCurso.Location = new Point(50,440);//defini onde o campo fica na tela
        campoCurso.Width = 210;
        Controls.Add(campoCurso);

        campoMatricula = new TextBox();//cria o campo de texto
        campoMatricula.Location = new Point(325,440);//defini onde o campo fica na tela
        campoMatricula.Width = 210;
        Controls.Add(campoMatricula);

        campoAno = new TextBox();//cria o campo de texto
        campoAno.Location = new Point(650,440);//defini onde o campo fica na tela
        campoAno.Width = 210;
        Controls.Add(campoAno);

        campoModalidade = new TextBox();//cria o campo de texto
        campoModalidade.Location = new Point(50,505);//defini onde o campo fica na tela
        campoModalidade.Width = 210;
        Controls.Add(campoModalidade);

        campoTurno = new TextBox();//cria o campo de texto
        campoTurno.Location = new Point(325,505);//defini onde o campo fica na tela
        campoTurno.Width = 210;
        Controls.Add(campoTurno);

        campoEscolaridade = new TextBox();//cria o campo de texto
        campoEscolaridade.Location = new Point(650,505);//defini onde o campo fica na tela
        campoEscolaridade.Width = 210;
        Controls.Add(campoEscolaridade);

        campoNomeResponsavel = new TextBox();//cria o campo de texto
        campoNomeResponsavel.Location = new Point(50,570);//defini onde o campo fica na tela
        campoNomeResponsavel.Width = 210;
        Controls.Add(campoNomeResponsavel);

        campoCPFResponsavel = new TextBox();//cria o campo de texto
        campoCPFResponsavel.Location = new Point(325,570);//defini onde o campo fica na tela
        campoCPFResponsavel.Width = 210;
        Controls.Add(campoCPFResponsavel);

        campoObs = new TextBox();//cria o campo de texto
        campoObs.Location = new Point(50,635);//defini onde o campo fica na tela
        campoObs.Width = 650;
        Controls.Add(campoObs);

    }
    protected override void OnPaint(PaintEventArgs e)
    {
      TextRenderer.DrawText(e.Graphics, "1. Nome Completo", Font, new Point(50, 20), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "2. (Sexo)", Font, new Point(650, 20), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "3. (Data de Nascimento)", Font, new Point(50, 85), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "4. (CPF)", Font, new Point(260, 85), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "5. (RG)", Font, new Point(470, 85), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "6. (Estado Civil)", Font, new Point(650, 85), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "7. (Email)", Font, new Point(50, 150), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "8. (Telefone Calular)", Font, new Point(325, 150), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "9. (Telefone Fixo)", Font, new Point(650, 150), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "10. (CEP)", Font, new Point(50, 280), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "11. (Endereço)", Font, new Point(260, 280), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "12. (Número)", Font, new Point(470, 280), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "13. (Complemento)", Font, new Point(650, 280), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "14. (Bairro)", Font, new Point(50, 345), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "15. (Cidade)", Font, new Point(325, 345), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "16. (Estado)", Font, new Point(650, 345), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "17. (Curso)", Font, new Point(50, 410), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "18. (Matricula)", Font, new Point(325, 410), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "19. (Ano/Semestre)", Font, new Point(650, 410), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "20. (Modalidade)", Font, new Point(50, 475), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "21. (Turno)", Font, new Point(325, 475), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "22. (Escolaridade)", Font, new Point(650, 475), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "23. (Nome do responsável)", Font, new Point(50, 540), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "24. (CPF do responsável)", Font, new Point(325, 540), Color.Blue);
      TextRenderer.DrawText(e.Graphics, "25. (Observações)", Font, new Point(50, 605), Color.Blue);
    }
}