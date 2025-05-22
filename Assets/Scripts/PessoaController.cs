

using Mono.Data.Sqlite;
using System.Data;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;
using Button = UnityEngine.UI.Button;

public class PessoaController : MonoBehaviour    
{
    
    public GameObject telaCadastrar;
    public GameObject telaInformacao;
    public GameObject telaExcluir;
    public GameObject row;    
    public Transform content_Tabela;
    public GameObject DisplayBtnSalvarAlterar;
    public GameObject DisplayBtnSalvarCadastrar;

    private TextMeshProUGUI idCad;
    private TMP_InputField inpNome;
    private TMP_InputField inpCPF;
    private TMP_InputField inpDataNascimento;
    private TMP_InputField inpRG;
    private TMP_InputField inpTitulo;
    private TMP_InputField inpRua;
    private TMP_InputField inpNumero;
    private TMP_InputField inpBairro;
    private TMP_InputField inpCidade;
    private TMP_InputField inpCEP;
    private TMP_InputField inpComplemento;
    private TMP_InputField inpPontoReferencia;
    private TMP_InputField inpTelefone;
    private TMP_InputField inpTelefoneContatoEmergencia;
    private TMP_InputField inpNomeContatoEmergencia;
    private TMP_InputField inpNomeTrabalho;
    private TMP_InputField inpOutroBeneficio;
    private TMP_InputField inpOutraProtecaoJuridica;
    private TMP_InputField inpComoConheceuDesabrocha;

    private TMP_Dropdown dropSexo;
    private TMP_Dropdown dropEscolaridade;
    private TMP_Dropdown dropEstadoCivil;
    private TMP_Dropdown dropEstado;
    private TMP_Dropdown dropTrabalhando;
    private TMP_Dropdown dropRendaFamiliar;
    private TMP_Dropdown dropBeneficio;
    private TMP_Dropdown dropQtdFilhos;
    private TMP_Dropdown dropFilhosVacinados;
    private TMP_Dropdown dropFilhosMatriculados;
    private TMP_Dropdown dropUsoImagem;
    private TMP_Dropdown dropViolencia;
    private TMP_Dropdown dropProtecaoJuridica;

    private UnityEngine.UI.Toggle tgBolsaFamilia;
    private UnityEngine.UI.Toggle tgLoas;
    private UnityEngine.UI.Toggle tgAposentadoria;
    private UnityEngine.UI.Toggle tgViolenciaFisica;
    private UnityEngine.UI.Toggle tgViolenciaPatrimonial;
    private UnityEngine.UI.Toggle tgViolenciaSexual;
    private UnityEngine.UI.Toggle tgViolenciaPsicologica;
    private UnityEngine.UI.Toggle tgViolenciaMoral;
    private UnityEngine.UI.Toggle tgCreas;
    private UnityEngine.UI.Toggle tgCras;
    private UnityEngine.UI.Toggle tgDelegaciaMulher;
    private UnityEngine.UI.Toggle tgCravi;
    private UnityEngine.UI.Toggle tgOAB;
    private UnityEngine.UI.Toggle tgMedidaProtetiva;

    private TextMeshProUGUI txtNome;
    private TextMeshProUGUI txtSexo;
    private TextMeshProUGUI txtDataNascimento;
    private TextMeshProUGUI txtRg;
    private TextMeshProUGUI txtCpf;
    private TextMeshProUGUI txtTitulo;
    private TextMeshProUGUI txtEscolaridade;
    private TextMeshProUGUI txtEstadoCivil;
    private TextMeshProUGUI txtTelefone;
    private TextMeshProUGUI txtNomeContato;
    private TextMeshProUGUI txtTelefoneContato;
    private TextMeshProUGUI txtRua;
    private TextMeshProUGUI txtNumero;
    private TextMeshProUGUI txtBairro;
    private TextMeshProUGUI txtCidade;
    private TextMeshProUGUI txtEstado;
    private TextMeshProUGUI txtCep;
    private TextMeshProUGUI txtComplemento;
    private TextMeshProUGUI txtPontoDeReferencia;
    private TextMeshProUGUI txtTrabalhando;
    private TextMeshProUGUI txtNomeTrabalho;
    private TextMeshProUGUI txtFaixaSalarial;
    private TextMeshProUGUI txtBeneficio;
    private TextMeshProUGUI txtBolsaFamilia;
    private TextMeshProUGUI txtLoas;
    private TextMeshProUGUI txtAposentadoria;
    private TextMeshProUGUI txtFilhos;
    private TextMeshProUGUI txtFilhosVacinados;
    private TextMeshProUGUI txtFilhosMatriculados;
    private TextMeshProUGUI txtUsoImagem;
    private TextMeshProUGUI txtViolencia;
    private TextMeshProUGUI txtViolenciaFisica;
    private TextMeshProUGUI txtViolenciaPatrimonial;
    private TextMeshProUGUI txtViolenciaSexual;
    private TextMeshProUGUI txtViolenciaPsicologica;
    private TextMeshProUGUI txtViolenciaMoral;
    private TextMeshProUGUI txtProtecao;
    private TextMeshProUGUI txtCreas;
    private TextMeshProUGUI txtCras;
    private TextMeshProUGUI txtDelegacia;
    private TextMeshProUGUI txtCravi;
    private TextMeshProUGUI txtOab;
    private TextMeshProUGUI txtMedidaProtetiva;
    private TextMeshProUGUI txtOutraProtecao;
    private TextMeshProUGUI txtComoConheceu;
    private TextMeshProUGUI txtExcluirNome;
    private TextMeshProUGUI txtExcluirtxtExcluirCpf;
    private TextMeshProUGUI txtIdExcluir;
    private TMP_InputField inpBuscar;

    private string vars = "NOME, CPF, DATANASCIMENTO, SEXO, RG, TITULO, ESCOLARIDADE, ESTADOCIVIL, RUA, NUMERO, COMPLEMENTO, PONTOREFERENCIA, CIDADE, ESTADO, CEP, TELEFONE, TELEFONECONTATO, NOMECONTATO, BAIRRO, TRABALHANDO, NOMETRABALHO, RENDAFAMILIAR, BENEFICIO, OUTROBENEFICIO, BOLSAFAMILIA, LOAS, APOSENTADORIA, QTDFILHOS, FILHOSVACINADOS, FILHOSMATRICULADOS, USOIMAGEM, VIOLENCIA, VIOLENCIAFISICA, VIOLENCIAPATRIMONIAL, VIOLENCIASEXUAL, VIOLENCIAPSICOLOGICA, VIOLENCIAMORAL, PROTECAOJURIDICA, CREAS, CRAS, DELEGACIAMULHER, CRAVI, OAB, MEDIDAPROTETIVA, OUTRAMEDIDAPROTETIVA, COMOCONHECEU";
    private string parametros = "@nome, @cpf, @data_nascimento, @sexo, @rg, @titulo, @escolaridade, @estado_civil, @rua, @numero, @complemento, @ponto_referencia, @cidade, @estado, @cep, @telefone, @telefone_contato_emergencia, @nome_contato_emergencia, @bairro, @trabalhando, @nome_trabalho, @renda_familiar, @beneficio, @outro_beneficio, @bolsa_familia, @loas, @aposentadoria, @qtd_filhos, @filho_vacinado, @filho_matriculado_escola, @uso_imagem, @violencia, @violencia_fisica, @violencia_patrimonial, @violencia_sexual, @violencia_psicologica, @violencia_moral, @protecao_juridica_social, @creas, @cras, @delegacia_mulher, @cravi, @oab, @medida_protetiva, @outra_protecao_juridica_social, @como_conheceu_desabrocha";
    private string varAlterar = "NOME = @nome, SEXO = @sexo, CPF = @cpf, RG = @rg, DATANASCIMENTO = @data_nascimento, TITULO = @titulo, ESCOLARIDADE = @escolaridade, ESTADOCIVIL = @estado_civil, RUA = @rua, NUMERO = @numero, BAIRRO = @bairro, CIDADE = @cidade, ESTADO = @estado, CEP = @cep, COMPLEMENTO = @complemento, PONTOREFERENCIA = @ponto_referencia, TELEFONE = @telefone, TELEFONECONTATO = @telefone_contato_emergencia, NOMECONTATO = @nome_contato_emergencia, TRABALHANDO = @trabalhando, NOMETRABALHO = @nome_trabalho, RENDAFAMILIAR = @renda_familiar, BENEFICIO = @beneficio, OUTROBENEFICIO = @outro_beneficio, BOLSAFAMILIA = @bolsa_familia, LOAS = @loas, APOSENTADORIA = @aposentadoria, QTDFILHOS = @qtd_filhos, FILHOSVACINADOS = @filho_vacinado, FILHOSMATRICULADOS = @filho_matriculado_escola, USOIMAGEM = @uso_imagem, VIOLENCIA = @violencia, VIOLENCIAFISICA = @violencia_fisica, VIOLENCIAPATRIMONIAL = @violencia_patrimonial, VIOLENCIASEXUAL = @violencia_sexual, VIOLENCIAPSICOLOGICA = @violencia_psicologica, VIOLENCIAMORAL = @violencia_moral, PROTECAOJURIDICA = @protecao_juridica_social, CREAS = @creas, CRAS = @cras, DELEGACIAMULHER = @delegacia_mulher, CRAVI = @cravi, OAB = @oab, MEDIDAPROTETIVA = @medida_protetiva, OUTRAMEDIDAPROTETIVA = @outra_protecao_juridica_social, COMOCONHECEU = @como_conheceu_desabrocha";
    private string createString = "CREATE TABLE IF NOT EXISTS PESSOA (ID INTEGER NOT NULL,NOME TEXT,SEXO TEXT,CPF TEXT, RG TEXT, DATANASCIMENTO TEXT, TITULO TEXT, ESCOLARIDADE TEXT, ESTADOCIVIL TEXT, RUA TEXT, NUMERO TEXT, BAIRRO TEXT, CIDADE TEXT, ESTADO TEXT, CEP TEXT, COMPLEMENTO TEXT, PONTOREFERENCIA TEXT, TELEFONE TEXT, TELEFONECONTATO TEXT, NOMECONTATO TEXT, TRABALHANDO TEXT, NOMETRABALHO TEXT, RENDAFAMILIAR TEXT, BENEFICIO TEXT, OUTROBENEFICIO TEXT, BOLSAFAMILIA TEXT, LOAS TEXT, APOSENTADORIA TEXT, QTDFILHOS TEXT, FILHOSVACINADOS TEXT, FILHOSMATRICULADOS TEXT, USOIMAGEM TEXT, VIOLENCIA TEXT, VIOLENCIAFISICA TEXT, VIOLENCIAPATRIMONIAL TEXT, VIOLENCIASEXUAL TEXT, VIOLENCIAPSICOLOGICA TEXT, VIOLENCIAMORAL TEXT, PROTECAOJURIDICA TEXT, CREAS TEXT, CRAS TEXT, DELEGACIAMULHER TEXT, CRAVI TEXT, OAB TEXT, MEDIDAPROTETIVA TEXT, OUTRAMEDIDAPROTETIVA TEXT, COMOCONHECEU TEXT, PRIMARY KEY([ID] AUTOINCREMENT))";
    private string dbName;    
    
    void Start()
    {
        dbName = "URI=file:" + Application.dataPath + "/StreamingAssets/dbDesabrocha.db"; 
        Debug.Log("Caminho do banco de dados: " + dbName);
        Debug.Log("Caminho do banco de dados: " + Application.persistentDataPath);
        inpBuscar = GameObject.Find("InputFieldBuscar").GetComponent<TMP_InputField>();
        ColetarValoresInformacao();
        ColetarValores();
        ColetarValoresExcluir();
        FecharTelas();
        CreateTable();            
        Listar();                
    }


    private void CreateTable()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand()) 
            {
                cmd.CommandText = createString;
                cmd.ExecuteNonQuery();                
            }            
            con.Close();            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirCadastrar()
    {
        DisplayBtnSalvarAlterar.SetActive(false);
        DisplayBtnSalvarCadastrar.SetActive(true);
        telaCadastrar.SetActive(true);
        ColetarValores();
    }
    
    public void FecharCadastrar()
    {
        telaCadastrar.SetActive(false);
    }  

    public void FecharInformacao()
    {
        telaInformacao.SetActive(false);
    }

    public void FecharExcluir()
    {
        telaExcluir.SetActive(false);
    }

    public void Cadastrar() 
    {
        CadastrarDao();
        Limpar();
        Listar();
        FecharCadastrar();
    }

    public void Alterar() 
    {
        AlterarDao();
        Limpar();
        Listar();
        FecharCadastrar();
    }

    public void Buscar()
    {
        LimpaTabela();
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {                
                cmd.CommandText = "SELECT * FROM PESSOA WHERE NOME LIKE @nome COLLATE NOCASE OR CPF LIKE @cpf COLLATE NOCASE OR RG LIKE @rg COLLATE NOCASE";
                cmd.Parameters.AddWithValue("@nome","%" + inpBuscar.text + "%");
                cmd.Parameters.AddWithValue("@cpf", "%" + inpBuscar.text + "%");
                cmd.Parameters.AddWithValue("@rg", "%" + inpBuscar.text + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Debug.Log("Nenhum resultado encontrado.");
                        reader.Close();
                        con.Close();
                        return; // Sai do método se não houver resultados
                    }
                    int i = 0;
                    while (reader.Read())
                    {                        
                        GameObject newRow = Instantiate(row, content_Tabela);
                        newRow.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = reader["NOME"].ToString();
                        newRow.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = reader["ID"].ToString();
                        newRow.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = reader["CPF"].ToString();
                        newRow.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = reader["RG"].ToString();

                        BtnInfo btnInfo = newRow.transform.GetChild(4).GetComponent<BtnInfo>();
                        btnInfo.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarInformacao(int.Parse(btnInfo.id.text));
                        });
                        BtnExluir btnExcluir = newRow.transform.GetChild(5).GetComponent<BtnExluir>();
                        btnExcluir.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarExcluir(int.Parse(btnExcluir.id.text));
                        });
                        BtnEditar btnEditando = newRow.transform.GetChild(6).GetComponent<BtnEditar>();
                        btnEditando.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarEditar(int.Parse(btnEditando.id.text));
                        });
                        i++;
                    }
                    reader.Close();
                }
            }
            con.Close();
        }
    }

    public void Limpar()
    {
        idCad.text = "";
        inpNome.text = "";
        inpCPF.text = "";
        inpDataNascimento.text = "";
        inpRG.text = "";
        inpTitulo.text = "";
        inpRua.text = "";
        inpNumero.text = "";
        inpBairro.text = "";
        inpCidade.text = "";
        inpCEP.text = "";
        inpComplemento.text = "";
        inpPontoReferencia.text = "";
        inpTelefone.text = "";
        inpTelefoneContatoEmergencia.text = "";
        inpNomeContatoEmergencia.text = "";
        inpNomeTrabalho.text = "";
        inpOutroBeneficio.text = "";
        inpOutraProtecaoJuridica.text = "";
        inpComoConheceuDesabrocha.text = "";


        tgBolsaFamilia.isOn = false;
        tgLoas.isOn = false;
        tgAposentadoria.isOn = false;
        tgViolenciaFisica.isOn = false;
        tgViolenciaPatrimonial.isOn = false;
        tgViolenciaSexual.isOn = false;
        tgViolenciaPsicologica.isOn = false;
        tgViolenciaMoral.isOn = false;
        tgCreas.isOn = false;
        tgCras.isOn = false;
        tgDelegaciaMulher.isOn = false;
        tgCravi.isOn = false;
        tgOAB.isOn = false;
        tgMedidaProtetiva.isOn = false;

    }

    public void Excluir()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM PESSOA WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", txtIdExcluir.text);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        Listar();
        telaExcluir.SetActive(false);
    }

    public void Listar()
    {
        LimpaTabela();
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PESSOA ORDER BY NOME";
                using (var reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        GameObject newRow = Instantiate(row, content_Tabela);
                        newRow.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = reader["NOME"].ToString();
                        newRow.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = reader["ID"].ToString();
                        newRow.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = reader["CPF"].ToString();
                        newRow.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = reader["RG"].ToString();

                        BtnInfo btnInfo = newRow.transform.GetChild(4).GetComponent<BtnInfo>();
                        btnInfo.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarInformacao(int.Parse(btnInfo.id.text));
                        });
                        BtnExluir btnExcluir = newRow.transform.GetChild(5).GetComponent<BtnExluir>();
                        btnExcluir.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarExcluir(int.Parse(btnExcluir.id.text));
                        });
                        BtnEditar btnEditando = newRow.transform.GetChild(6).GetComponent<BtnEditar>();
                        btnEditando.gameObject.GetComponent<Button>().onClick.AddListener(() => {
                            AcionarEditar(int.Parse(btnEditando.id.text));
                        });
                        i++;
                    }
                    reader.Close();
                }
            }
            con.Close();
        }
    }

    private void AlterarDao()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE PESSOA SET " + varAlterar + " WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", idCad.text);          
                cmd.Parameters.AddWithValue("@nome", inpNome.text);
                cmd.Parameters.AddWithValue("@cpf", inpCPF.text);
                cmd.Parameters.AddWithValue("@data_nascimento", inpDataNascimento.text);
                cmd.Parameters.AddWithValue("@rg", inpRG.text);
                cmd.Parameters.AddWithValue("@titulo", inpTitulo.text);
                cmd.Parameters.AddWithValue("@rua", inpRua.text);
                cmd.Parameters.AddWithValue("@numero", inpNumero.text);
                cmd.Parameters.AddWithValue("@bairro", inpBairro.text);
                cmd.Parameters.AddWithValue("@cidade", inpCidade.text);
                cmd.Parameters.AddWithValue("@cep", inpCEP.text);
                cmd.Parameters.AddWithValue("@complemento", inpComplemento.text);
                cmd.Parameters.AddWithValue("@ponto_referencia", inpPontoReferencia.text);
                cmd.Parameters.AddWithValue("@telefone", inpTelefone.text);
                cmd.Parameters.AddWithValue("@telefone_contato_emergencia", inpTelefoneContatoEmergencia.text);
                cmd.Parameters.AddWithValue("@nome_contato_emergencia", inpNomeContatoEmergencia.text);
                cmd.Parameters.AddWithValue("@nome_trabalho", inpNomeTrabalho.text);
                cmd.Parameters.AddWithValue("@outro_beneficio", inpOutroBeneficio.text);
                cmd.Parameters.AddWithValue("@outra_protecao_juridica_social", inpOutraProtecaoJuridica.text);
                cmd.Parameters.AddWithValue("@como_conheceu_desabrocha", inpComoConheceuDesabrocha.text);

                cmd.Parameters.AddWithValue("@bolsa_familia", PegarBool(tgBolsaFamilia.isOn));
                cmd.Parameters.AddWithValue("@loas", PegarBool(tgLoas.isOn));
                cmd.Parameters.AddWithValue("@aposentadoria", PegarBool(tgAposentadoria.isOn));
                cmd.Parameters.AddWithValue("@violencia_fisica", PegarBool(tgViolenciaFisica.isOn));
                cmd.Parameters.AddWithValue("@violencia_patrimonial", PegarBool(tgViolenciaPatrimonial.isOn));
                cmd.Parameters.AddWithValue("@violencia_sexual", PegarBool(tgViolenciaSexual.isOn));
                cmd.Parameters.AddWithValue("@violencia_psicologica", PegarBool(tgViolenciaPsicologica.isOn));
                cmd.Parameters.AddWithValue("@violencia_moral", PegarBool(tgViolenciaMoral.isOn));
                cmd.Parameters.AddWithValue("@creas", PegarBool(tgCreas.isOn));
                cmd.Parameters.AddWithValue("@cras", PegarBool(tgCras.isOn));
                cmd.Parameters.AddWithValue("@delegacia_mulher", PegarBool(tgDelegaciaMulher.isOn));
                cmd.Parameters.AddWithValue("@cravi", PegarBool(tgCravi.isOn));
                cmd.Parameters.AddWithValue("@oab", PegarBool(tgOAB.isOn));
                cmd.Parameters.AddWithValue("@medida_protetiva", PegarBool(tgMedidaProtetiva.isOn));

                cmd.Parameters.AddWithValue("@sexo", dropSexo.options[dropSexo.value].text);
                cmd.Parameters.AddWithValue("@escolaridade", dropEscolaridade.options[dropEscolaridade.value].text);
                cmd.Parameters.AddWithValue("@estado_civil", dropEstadoCivil.options[dropEstadoCivil.value].text);
                cmd.Parameters.AddWithValue("@estado", dropEstado.options[dropEstado.value].text);
                cmd.Parameters.AddWithValue("@trabalhando", dropTrabalhando.options[dropTrabalhando.value].text);
                cmd.Parameters.AddWithValue("@renda_familiar", dropRendaFamiliar.options[dropRendaFamiliar.value].text);
                cmd.Parameters.AddWithValue("@beneficio", dropBeneficio.options[dropBeneficio.value].text);
                cmd.Parameters.AddWithValue("@qtd_filhos", dropQtdFilhos.options[dropQtdFilhos.value].text);
                cmd.Parameters.AddWithValue("@filho_vacinado", dropFilhosVacinados.options[dropFilhosVacinados.value].text);
                cmd.Parameters.AddWithValue("@filho_matriculado_escola", dropFilhosMatriculados.options[dropFilhosMatriculados.value].text);
                cmd.Parameters.AddWithValue("@uso_imagem", dropUsoImagem.options[dropUsoImagem.value].text);
                cmd.Parameters.AddWithValue("@violencia", dropViolencia.options[dropViolencia.value].text);
                cmd.Parameters.AddWithValue("@protecao_juridica_social", dropProtecaoJuridica.options[dropProtecaoJuridica.value].text);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }

    private void AcionarInformacao(int id) 
    {
        telaInformacao.SetActive(true);
        ColetarValoresInformacao();
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PESSOA WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {                    
                    txtNome.text = reader["NOME"].ToString();
                    txtSexo.text = reader["SEXO"].ToString();
                    txtDataNascimento.text = reader["DATANASCIMENTO"].ToString();
                    txtRg.text = reader["RG"].ToString();
                    txtCpf.text = reader["CPF"].ToString();
                    txtTitulo.text = reader["TITULO"].ToString();
                    txtEscolaridade.text = reader["ESCOLARIDADE"].ToString();
                    txtEstadoCivil.text = reader["ESTADOCIVIL"].ToString();
                    txtTelefone.text = reader["TELEFONE"].ToString();
                    txtNomeContato.text = reader["NOMECONTATO"].ToString();
                    txtTelefoneContato.text = reader["TELEFONECONTATO"].ToString();
                    txtRua.text = reader["RUA"].ToString();
                    txtNumero.text = reader["NUMERO"].ToString();
                    txtBairro.text = reader["BAIRRO"].ToString();
                    txtCidade.text = reader["CIDADE"].ToString();
                    txtEstado.text = reader["ESTADO"].ToString();
                    txtCep.text = reader["CEP"].ToString();
                    txtComplemento.text = reader["COMPLEMENTO"].ToString();
                    txtPontoDeReferencia.text = reader["PONTOREFERENCIA"].ToString();
                    txtTrabalhando.text = reader["TRABALHANDO"].ToString();
                    txtNomeTrabalho.text = reader["NOMETRABALHO"].ToString();
                    txtFaixaSalarial.text = reader["RENDAFAMILIAR"].ToString();
                    txtBeneficio.text = reader["BENEFICIO"].ToString();
                    txtBolsaFamilia.text = reader["BOLSAFAMILIA"].ToString();
                    txtLoas.text = reader["LOAS"].ToString();
                    txtAposentadoria.text = reader["APOSENTADORIA"].ToString();
                    txtFilhos.text = reader["QTDFILHOS"].ToString();
                    txtFilhosVacinados.text = reader["FILHOSVACINADOS"].ToString();
                    txtFilhosMatriculados.text = reader["FILHOSMATRICULADOS"].ToString();
                    txtUsoImagem.text = reader["USOIMAGEM"].ToString();
                    txtViolencia.text = reader["VIOLENCIA"].ToString();
                    txtViolenciaFisica.text = reader["VIOLENCIAFISICA"].ToString();
                    txtViolenciaPatrimonial.text = reader["VIOLENCIAPATRIMONIAL"].ToString();
                    txtViolenciaSexual.text = reader["VIOLENCIASEXUAL"].ToString();
                    txtViolenciaPsicologica.text = reader["VIOLENCIAPSICOLOGICA"].ToString();
                    txtViolenciaMoral.text = reader["VIOLENCIAMORAL"].ToString();
                    txtProtecao.text = reader["PROTECAOJURIDICA"].ToString();
                    txtCreas.text = reader["CREAS"].ToString();
                    txtCras.text = reader["CRAS"].ToString();
                    txtDelegacia.text = reader["DELEGACIAMULHER"].ToString();
                    txtCravi.text = reader["CRAVI"].ToString();
                    txtOab.text = reader["OAB"].ToString();
                    txtMedidaProtetiva.text = reader["MEDIDAPROTETIVA"].ToString();
                    txtOutraProtecao.text = reader["OUTRAMEDIDAPROTETIVA"].ToString();
                    txtComoConheceu.text = reader["COMOCONHECEU"].ToString();               
                    
                    reader.Close();
                }
            }
            con.Close();
        }        
    }

    private void AcionarExcluir(int id) 
    {                
        txtIdExcluir.text = id.ToString();
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PESSOA WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtExcluirNome.text = reader["NOME"].ToString();
                        txtExcluirtxtExcluirCpf.text = reader["CPF"].ToString();                        
                    }
                    reader.Close();
                }
            }
            con.Close();
        }
        telaExcluir.SetActive(true);
    }

    private void AcionarEditar(int id) 
    {   
        DisplayBtnSalvarAlterar.SetActive(true);
        DisplayBtnSalvarCadastrar.SetActive(false);
        BuscarPorID(id);
        telaCadastrar.SetActive(true);
    }

    private string PegarBool(bool valor) 
    {
        if (valor )
        {
            return "Sim";
        }
        else 
        {
            return "Não";
        }
    }

    private void SetDrop(TMP_Dropdown dropdown, string targetText)
    {        
        for (int i = 0; i < dropdown.options.Count; i++)
        {
            if (dropdown.options[i].text == targetText)
            {
                dropdown.value = i; // Define o índice encontrado
                dropdown.RefreshShownValue(); // Atualiza visualmente
                return;
            }
        }        
    }

    private void BuscarPorID(int id) 
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PESSOA WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                
                using (var reader = cmd.ExecuteReader())
                {                    
                    idCad.text = reader["ID"].ToString();
                    inpNome.text = reader["NOME"].ToString();
                    inpCPF.text = reader["CPF"].ToString();
                    inpDataNascimento.text = reader["DATANASCIMENTO"].ToString();
                    inpRG.text = reader["RG"].ToString();
                    inpTitulo.text = reader["TITULO"].ToString();
                    inpRua.text = reader["RUA"].ToString();
                    inpNumero.text = reader["NUMERO"].ToString();
                    inpBairro.text = reader["BAIRRO"].ToString();
                    inpCidade.text = reader["CIDADE"].ToString();
                    inpCEP.text = reader["CEP"].ToString();
                    inpComplemento.text = reader["COMPLEMENTO"].ToString();
                    inpPontoReferencia.text = reader["PONTOREFERENCIA"].ToString();
                    inpTelefone.text = reader["TELEFONE"].ToString();
                    inpTelefoneContatoEmergencia.text = reader["TELEFONECONTATO"].ToString();
                    inpNomeContatoEmergencia.text = reader["NOMECONTATO"].ToString();
                    inpNomeTrabalho.text = reader["NOMETRABALHO"].ToString();
                    inpOutroBeneficio.text = reader["OUTROBENEFICIO"].ToString();
                    inpOutraProtecaoJuridica.text = reader["OUTRAMEDIDAPROTETIVA"].ToString();
                    inpComoConheceuDesabrocha.text = reader["COMOCONHECEU"].ToString();

                    SetDrop(dropSexo, reader["SEXO"].ToString());
                    SetDrop(dropEscolaridade, reader["ESCOLARIDADE"].ToString());
                    SetDrop(dropEstadoCivil, reader["ESTADOCIVIL"].ToString());
                    SetDrop(dropEstado, reader["ESTADO"].ToString());
                    SetDrop(dropTrabalhando, reader["TRABALHANDO"].ToString());
                    SetDrop(dropRendaFamiliar, reader["RENDAFAMILIAR"].ToString());
                    SetDrop(dropBeneficio, reader["BENEFICIO"].ToString());
                    SetDrop(dropQtdFilhos, reader["QTDFILHOS"].ToString());
                    SetDrop(dropFilhosVacinados, reader["FILHOSVACINADOS"].ToString());
                    SetDrop(dropFilhosMatriculados, reader["FILHOSMATRICULADOS"].ToString());
                    SetDrop(dropUsoImagem, reader["USOIMAGEM"].ToString());
                    SetDrop(dropViolencia, reader["VIOLENCIA"].ToString());
                    SetDrop(dropProtecaoJuridica, reader["PROTECAOJURIDICA"].ToString());

                    tgBolsaFamilia.isOn = SimNaoConverter(reader["BOLSAFAMILIA"].ToString());
                    tgLoas.isOn = SimNaoConverter(reader["LOAS"].ToString());
                    tgAposentadoria.isOn = SimNaoConverter(reader["APOSENTADORIA"].ToString());
                    tgViolenciaFisica.isOn = SimNaoConverter(reader["VIOLENCIAFISICA"].ToString());
                    tgViolenciaPatrimonial.isOn = SimNaoConverter(reader["VIOLENCIAPATRIMONIAL"].ToString());
                    tgViolenciaSexual.isOn = SimNaoConverter(reader["VIOLENCIASEXUAL"].ToString());
                    tgViolenciaPsicologica.isOn = SimNaoConverter(reader["VIOLENCIAPSICOLOGICA"].ToString());
                    tgViolenciaMoral.isOn = SimNaoConverter(reader["VIOLENCIAMORAL"].ToString());
                    tgCreas.isOn = SimNaoConverter(reader["CREAS"].ToString());
                    tgCras.isOn = SimNaoConverter(reader["CRAS"].ToString());
                    tgDelegaciaMulher.isOn = SimNaoConverter(reader["DELEGACIAMULHER"].ToString());
                    tgCravi.isOn = SimNaoConverter(reader["CRAVI"].ToString());
                    tgOAB.isOn = SimNaoConverter(reader["OAB"].ToString());
                    tgMedidaProtetiva.isOn = SimNaoConverter(reader["MEDIDAPROTETIVA"].ToString());
                    
                    reader.Close();
                }
            }
            con.Close();
        }
    }

    private bool SimNaoConverter(string termo) 
    {        
        if (termo == "Sim")
        {
            return true;
        }
        else 
        {
            return false;
        }
       
    }

    private void CadastrarDao()
    {
        using (var con = new SqliteConnection(dbName))
        {
            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO PESSOA (" + vars + ") VALUES (" + parametros + ")";
                // Campos de texto/input normal
                cmd.Parameters.AddWithValue("@nome", inpNome.text);
                cmd.Parameters.AddWithValue("@cpf", inpCPF.text);
                cmd.Parameters.AddWithValue("@data_nascimento", inpDataNascimento.text);
                cmd.Parameters.AddWithValue("@rg", inpRG.text);
                cmd.Parameters.AddWithValue("@titulo", inpTitulo.text);
                cmd.Parameters.AddWithValue("@rua", inpRua.text);
                cmd.Parameters.AddWithValue("@numero", inpNumero.text);
                cmd.Parameters.AddWithValue("@bairro", inpBairro.text);
                cmd.Parameters.AddWithValue("@cidade", inpCidade.text);
                cmd.Parameters.AddWithValue("@cep", inpCEP.text);
                cmd.Parameters.AddWithValue("@complemento", inpComplemento.text);
                cmd.Parameters.AddWithValue("@ponto_referencia", inpPontoReferencia.text);
                cmd.Parameters.AddWithValue("@telefone", inpTelefone.text);
                cmd.Parameters.AddWithValue("@telefone_contato_emergencia", inpTelefoneContatoEmergencia.text);
                cmd.Parameters.AddWithValue("@nome_contato_emergencia", inpNomeContatoEmergencia.text);
                cmd.Parameters.AddWithValue("@nome_trabalho", inpNomeTrabalho.text);
                cmd.Parameters.AddWithValue("@outro_beneficio", inpOutroBeneficio.text);
                cmd.Parameters.AddWithValue("@outra_protecao_juridica_social", inpOutraProtecaoJuridica.text);
                cmd.Parameters.AddWithValue("@como_conheceu_desabrocha", inpComoConheceuDesabrocha.text);

                cmd.Parameters.AddWithValue("@bolsa_familia", PegarBool(tgBolsaFamilia.isOn));
                cmd.Parameters.AddWithValue("@loas", PegarBool(tgLoas.isOn));
                cmd.Parameters.AddWithValue("@aposentadoria", PegarBool(tgAposentadoria.isOn));
                cmd.Parameters.AddWithValue("@violencia_fisica", PegarBool(tgViolenciaFisica.isOn));
                cmd.Parameters.AddWithValue("@violencia_patrimonial", PegarBool(tgViolenciaPatrimonial.isOn));
                cmd.Parameters.AddWithValue("@violencia_sexual", PegarBool(tgViolenciaSexual.isOn));
                cmd.Parameters.AddWithValue("@violencia_psicologica", PegarBool(tgViolenciaPsicologica.isOn));
                cmd.Parameters.AddWithValue("@violencia_moral", PegarBool(tgViolenciaMoral.isOn));
                cmd.Parameters.AddWithValue("@creas", PegarBool(tgCreas.isOn));
                cmd.Parameters.AddWithValue("@cras", PegarBool(tgCras.isOn));
                cmd.Parameters.AddWithValue("@delegacia_mulher", PegarBool(tgDelegaciaMulher.isOn));
                cmd.Parameters.AddWithValue("@cravi", PegarBool(tgCravi.isOn));
                cmd.Parameters.AddWithValue("@oab", PegarBool(tgOAB.isOn));
                cmd.Parameters.AddWithValue("@medida_protetiva", PegarBool(tgMedidaProtetiva.isOn));

                cmd.Parameters.AddWithValue("@sexo", dropSexo.options[dropSexo.value].text);
                cmd.Parameters.AddWithValue("@escolaridade", dropEscolaridade.options[dropEscolaridade.value].text);
                cmd.Parameters.AddWithValue("@estado_civil", dropEstadoCivil.options[dropEstadoCivil.value].text);
                cmd.Parameters.AddWithValue("@estado", dropEstado.options[dropEstado.value].text);
                cmd.Parameters.AddWithValue("@trabalhando", dropTrabalhando.options[dropTrabalhando.value].text);
                cmd.Parameters.AddWithValue("@renda_familiar", dropRendaFamiliar.options[dropRendaFamiliar.value].text);
                cmd.Parameters.AddWithValue("@beneficio", dropBeneficio.options[dropBeneficio.value].text);
                cmd.Parameters.AddWithValue("@qtd_filhos", dropQtdFilhos.options[dropQtdFilhos.value].text);
                cmd.Parameters.AddWithValue("@filho_vacinado", dropFilhosVacinados.options[dropFilhosVacinados.value].text);
                cmd.Parameters.AddWithValue("@filho_matriculado_escola", dropFilhosMatriculados.options[dropFilhosMatriculados.value].text);
                cmd.Parameters.AddWithValue("@uso_imagem", dropUsoImagem.options[dropUsoImagem.value].text);
                cmd.Parameters.AddWithValue("@violencia", dropViolencia.options[dropViolencia.value].text);
                cmd.Parameters.AddWithValue("@protecao_juridica_social", dropProtecaoJuridica.options[dropProtecaoJuridica.value].text);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }

    private void ColetarValoresInformacao() 
    {
        txtNome = GameObject.Find("txtNome").GetComponent<TextMeshProUGUI>();
        txtSexo = GameObject.Find("txtSexo").GetComponent<TextMeshProUGUI>();
        txtDataNascimento = GameObject.Find("txtDataNascimento").GetComponent<TextMeshProUGUI>();
        txtRg = GameObject.Find("txtRg").GetComponent<TextMeshProUGUI>();
        txtCpf = GameObject.Find("txtCpf").GetComponent<TextMeshProUGUI>();
        txtTitulo = GameObject.Find("txtTitulo").GetComponent<TextMeshProUGUI>();
        txtEscolaridade = GameObject.Find("txtEscolaridade").GetComponent<TextMeshProUGUI>();
        txtEstadoCivil = GameObject.Find("txtEstadoCivil").GetComponent<TextMeshProUGUI>();
        txtTelefone = GameObject.Find("txtTelefone").GetComponent<TextMeshProUGUI>();
        txtNomeContato = GameObject.Find("txtNomeContato").GetComponent<TextMeshProUGUI>();
        txtTelefoneContato = GameObject.Find("txtTelefoneContato").GetComponent<TextMeshProUGUI>();
        txtRua = GameObject.Find("txtRua").GetComponent<TextMeshProUGUI>();
        txtNumero = GameObject.Find("txtNumero").GetComponent<TextMeshProUGUI>();
        txtBairro = GameObject.Find("txtBairro").GetComponent<TextMeshProUGUI>();
        txtCidade = GameObject.Find("txtCidade").GetComponent<TextMeshProUGUI>();
        txtEstado = GameObject.Find("txtEstado").GetComponent<TextMeshProUGUI>();
        txtCep = GameObject.Find("txtCep").GetComponent<TextMeshProUGUI>();
        txtComplemento = GameObject.Find("txtComplemento").GetComponent<TextMeshProUGUI>();
        txtPontoDeReferencia = GameObject.Find("txtPontoDeReferencia").GetComponent<TextMeshProUGUI>();
        txtTrabalhando = GameObject.Find("txtTrabalhando").GetComponent<TextMeshProUGUI>();
        txtNomeTrabalho = GameObject.Find("txtNomeTrabalho").GetComponent<TextMeshProUGUI>();
        txtFaixaSalarial = GameObject.Find("txtFaixaSalarial").GetComponent<TextMeshProUGUI>();
        txtBeneficio = GameObject.Find("txtBeneficio").GetComponent<TextMeshProUGUI>();
        txtBolsaFamilia = GameObject.Find("txtBolsaFamilia").GetComponent<TextMeshProUGUI>();
        txtLoas = GameObject.Find("txtLoas").GetComponent<TextMeshProUGUI>();
        txtAposentadoria = GameObject.Find("txtAposentadoria").GetComponent<TextMeshProUGUI>();
        txtFilhos = GameObject.Find("txtFilhos").GetComponent<TextMeshProUGUI>();
        txtFilhosVacinados = GameObject.Find("txtFilhosVacinados").GetComponent<TextMeshProUGUI>();
        txtFilhosMatriculados = GameObject.Find("txtFilhosMatriculados").GetComponent<TextMeshProUGUI>();
        txtUsoImagem = GameObject.Find("txtUsoImagem").GetComponent<TextMeshProUGUI>();
        txtViolencia = GameObject.Find("txtViolencia").GetComponent<TextMeshProUGUI>();
        txtViolenciaFisica = GameObject.Find("txtViolenciaFisica").GetComponent<TextMeshProUGUI>();
        txtViolenciaPatrimonial = GameObject.Find("txtViolenciaPatrimonial").GetComponent<TextMeshProUGUI>();
        txtViolenciaSexual = GameObject.Find("txtViolenciaSexual").GetComponent<TextMeshProUGUI>();
        txtViolenciaPsicologica = GameObject.Find("txtViolenciaPsicologica").GetComponent<TextMeshProUGUI>();
        txtViolenciaMoral = GameObject.Find("txtViolenciaMoral").GetComponent<TextMeshProUGUI>();
        txtProtecao = GameObject.Find("txtProtecao").GetComponent<TextMeshProUGUI>();
        txtCreas = GameObject.Find("txtCreas").GetComponent<TextMeshProUGUI>();
        txtCras = GameObject.Find("txtCras").GetComponent<TextMeshProUGUI>();
        txtDelegacia = GameObject.Find("txtDelegacia").GetComponent<TextMeshProUGUI>();
        txtCravi = GameObject.Find("txtCravi").GetComponent<TextMeshProUGUI>();
        txtOab = GameObject.Find("txtOab").GetComponent<TextMeshProUGUI>();
        txtMedidaProtetiva = GameObject.Find("txtMedidaProtetiva").GetComponent<TextMeshProUGUI>();
        txtOutraProtecao = GameObject.Find("txtOutraProtecao").GetComponent<TextMeshProUGUI>();
        txtComoConheceu = GameObject.Find("txtComoConheceu").GetComponent<TextMeshProUGUI>();
    }

    private void ColetarValoresExcluir() 
    {
        txtIdExcluir = GameObject.Find("txtIdExcluir").GetComponent<TextMeshProUGUI>();
        txtExcluirNome = GameObject.Find("txtExcluirNome").GetComponent<TextMeshProUGUI>();
        txtExcluirtxtExcluirCpf = GameObject.Find("txtExcluirCpf").GetComponent<TextMeshProUGUI>();
    }

    private void ColetarValores()
    {
        
        idCad = GameObject.Find("txtIdCad").GetComponent<TextMeshProUGUI>();
        inpNome = GameObject.Find("InputFieldNome").GetComponent<TMP_InputField>();
        inpCPF = GameObject.Find("InputFieldCpf").GetComponent<TMP_InputField>();
        inpDataNascimento = GameObject.Find("InputFieldDataNascimento").GetComponent<TMP_InputField>();
        inpDataNascimento.characterLimit = 10;
        inpRG = GameObject.Find("InputFieldRg").GetComponent<TMP_InputField>();
        inpTitulo = GameObject.Find("InputFieldTitulo").GetComponent<TMP_InputField>();
        inpRua = GameObject.Find("InputFieldRua").GetComponent<TMP_InputField>();
        inpNumero = GameObject.Find("InputFieldNumero").GetComponent<TMP_InputField>();
        inpBairro = GameObject.Find("InputFieldBairro").GetComponent<TMP_InputField>();
        inpCidade = GameObject.Find("InputFieldCidade").GetComponent<TMP_InputField>();
        inpCEP = GameObject.Find("InputFieldCep").GetComponent<TMP_InputField>();
        inpComplemento = GameObject.Find("InputFieldComplemento").GetComponent<TMP_InputField>();
        inpPontoReferencia = GameObject.Find("InputFieldPontoReferencia").GetComponent<TMP_InputField>();
        inpTelefone = GameObject.Find("InputFieldTelefone").GetComponent<TMP_InputField>();
        inpTelefoneContatoEmergencia = GameObject.Find("InputFieldTelefoneContato").GetComponent<TMP_InputField>();
        inpNomeContatoEmergencia = GameObject.Find("InputFieldNomeContato").GetComponent<TMP_InputField>();
        inpNomeTrabalho = GameObject.Find("InputFieldNomeTrabalho").GetComponent<TMP_InputField>();
        inpOutroBeneficio = GameObject.Find("InputFieldOutroBeneficio").GetComponent<TMP_InputField>();
        inpOutraProtecaoJuridica = GameObject.Find("InputFieldOutraProtecao").GetComponent<TMP_InputField>();
        inpComoConheceuDesabrocha = GameObject.Find("InputFieldComoConheceu").GetComponent<TMP_InputField>();

        dropSexo = GameObject.Find("dropSexo").GetComponent<TMP_Dropdown>();
        dropEscolaridade = GameObject.Find("dropEscolaridade").GetComponent<TMP_Dropdown>();
        dropEstadoCivil = GameObject.Find("dropEstadoCivil").GetComponent<TMP_Dropdown>();
        dropEstado = GameObject.Find("dropEstado").GetComponent<TMP_Dropdown>();
        dropTrabalhando = GameObject.Find("dropTrabalhando").GetComponent<TMP_Dropdown>();
        dropRendaFamiliar = GameObject.Find("dropRendaFamiliar").GetComponent<TMP_Dropdown>();
        dropBeneficio = GameObject.Find("dropBeneficio").GetComponent<TMP_Dropdown>();
        dropQtdFilhos = GameObject.Find("dropQtdFilhos").GetComponent<TMP_Dropdown>();
        dropFilhosVacinados = GameObject.Find("dropFilhosVacinados").GetComponent<TMP_Dropdown>();
        dropFilhosMatriculados = GameObject.Find("dropFilhosMatriculados").GetComponent<TMP_Dropdown>();
        dropUsoImagem = GameObject.Find("dropUsoImagem").GetComponent<TMP_Dropdown>();
        dropViolencia = GameObject.Find("dropViolencia").GetComponent<TMP_Dropdown>();
        dropProtecaoJuridica = GameObject.Find("dropProtecaoJuridica").GetComponent<TMP_Dropdown>();

        tgBolsaFamilia = GameObject.Find("tgBolsaFamilia").GetComponent<UnityEngine.UI.Toggle>();
        tgLoas = GameObject.Find("tgLoas").GetComponent<UnityEngine.UI.Toggle>();
        tgAposentadoria = GameObject.Find("tgAposentadoria").GetComponent<UnityEngine.UI.Toggle>();
        tgViolenciaFisica = GameObject.Find("tgViolenciaFisica").GetComponent<UnityEngine.UI.Toggle>();
        tgViolenciaPatrimonial = GameObject.Find("tgViolenciaPatrimonial").GetComponent<UnityEngine.UI.Toggle>();
        tgViolenciaSexual = GameObject.Find("tgViolenciaSexual").GetComponent<UnityEngine.UI.Toggle>();
        tgViolenciaPsicologica = GameObject.Find("tgViolenciaPsicologica").GetComponent<UnityEngine.UI.Toggle>();
        tgViolenciaMoral = GameObject.Find("tgViolenciaMoral").GetComponent<UnityEngine.UI.Toggle>();
        tgCreas = GameObject.Find("tgCreas").GetComponent<UnityEngine.UI.Toggle>();
        tgCras = GameObject.Find("tgCras").GetComponent<UnityEngine.UI.Toggle>();
        tgDelegaciaMulher = GameObject.Find("tgDelegaciaMulher").GetComponent<UnityEngine.UI.Toggle>();
        tgCravi = GameObject.Find("tgCravi").GetComponent<UnityEngine.UI.Toggle>();
        tgOAB = GameObject.Find("tgOab").GetComponent<UnityEngine.UI.Toggle>();
        tgMedidaProtetiva = GameObject.Find("tgMedidaProtetiva").GetComponent<UnityEngine.UI.Toggle>();
    }

    private void FecharTelas() 
    {
        telaCadastrar.SetActive(false);
        telaInformacao.SetActive(false);
        telaExcluir.SetActive(false);
    }

    private void LimpaTabela() 
    {
        foreach (Transform child in content_Tabela)
        {
            Destroy(child.gameObject); // Remove todos os filhos do content_Tabela antes de adicionar novos
        }
    }



    /*
        // Coletar valores
        Debug.Log("Nome = " + inpNome.text);           
        Debug.Log("Bolsa Familia = " + PegarBool(tgBolsaFamilia.isOn));
        Debug.Log("Sexo = " + dropSexo.options[dropSexo.value].text);

        // Definir valores
        inpNome.text = "Nome Teste";
        SetDrop(dropSexo, "Masculino");
        tgBolsaFamilia.isOn = true;

    */
}
