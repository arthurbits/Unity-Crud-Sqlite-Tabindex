using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TabIndex : MonoBehaviour
{    
    public TMP_InputField inpNome;
    public TMP_InputField inpCPF;
    public TMP_InputField inpDataNascimento;
    public TMP_InputField inpRG;
    public TMP_InputField inpTitulo;
    public TMP_InputField inpRua;
    public TMP_InputField inpNumero;
    public TMP_InputField inpBairro;
    public TMP_InputField inpCidade;
    public TMP_InputField inpCEP;
    public TMP_InputField inpComplemento;
    public TMP_InputField inpPontoReferencia;
    public TMP_InputField inpTelefone;
    public TMP_InputField inpTelefoneContatoEmergencia;
    public TMP_InputField inpNomeContatoEmergencia;
    public TMP_InputField inpNomeTrabalho;
    public TMP_InputField inpOutroBeneficio;
    public TMP_InputField inpOutraProtecaoJuridica;
    public TMP_InputField inpComoConheceuDesabrocha;
    

    public int InputSelected;

    private void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame) 
        {
            InputSelected++;
            if (InputSelected > 18) InputSelected = 0;
            SelectInputField();
        }
        void SelectInputField() 
        {
            switch (InputSelected)
            {
                case 0: inpNome.Select(); break;
                case 1: inpDataNascimento.Select(); break;
                case 2: inpCPF.Select(); break;
                case 3: inpRG.Select(); break;
                case 4: inpTitulo.Select(); break;            
                case 5: inpTelefone.Select(); break;
                case 6: inpNomeContatoEmergencia.Select(); break;
                case 7: inpTelefoneContatoEmergencia.Select(); break;
                case 8: inpRua.Select(); break;
                case 9: inpNumero.Select(); break;
                case 10: inpBairro.Select(); break;
                case 11: inpCidade.Select(); break;           
                case 12: inpCEP.Select(); break;
                case 13: inpComplemento.Select(); break;
                case 14: inpPontoReferencia.Select(); break;            
                case 15: inpNomeTrabalho.Select(); break;               
                case 16: inpOutroBeneficio.Select(); break;
                case 17: inpOutraProtecaoJuridica.Select(); break;
                case 18: inpComoConheceuDesabrocha.Select(); break;

            }
        }
    }
    public void inpNomeSelected() => InputSelected = 0;
    public void inpDataNascimentoSelected() => InputSelected = 1;
    public void inpCPFSelected() => InputSelected = 2;
    public void inpRGSelected() => InputSelected = 3;
    public void inpTituloSelected() => InputSelected = 4;
    public void inpTelefoneSelected() => InputSelected = 5;
    public void inpNomeContatoEmergenciaSelected() => InputSelected = 6;
    public void inpTelefoneContatoEmergenciaSelected() => InputSelected = 7;
    public void inpRuaSelected() => InputSelected = 8;
    public void inpNumeroSelected() => InputSelected = 9;
    public void inpBairroSelected() => InputSelected = 10;
    public void inpCidadeSelected() => InputSelected = 11;
    public void inpCEPSelected() => InputSelected = 12;
    public void inpComplementoSelected() => InputSelected = 13;
    public void inpPontoReferenciaSelected() => InputSelected = 14;
    public void inpNomeTrabalhoSelected() => InputSelected = 15;
    public void inpOutroBeneficioSelected() => InputSelected = 16;
    public void inpOutraProtecaoJuridicaSelected() => InputSelected = 17;
    public void inpComoConheceuDesabrochaSelected() => InputSelected = 18;
}
