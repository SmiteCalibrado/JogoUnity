using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Controlando : MonoBehaviour {

    //int e float
    public static int Notas = 500;
    public static int Alunos = 10;
    public static int Dinheiro = 500;
    public static int QualiAula = 1;
    public static int QualiCantina = 1;
    public static int QuantiProf = 1;
    public static float QualiQuadra = 1;
    public static float TempProf = 10.0f;
    float Felicidade = 1;

    //textos
    public Text txtNotas;
    public Text txtDinheiro;
    public Text txtAlunos;

    //botoes
    public Button Aulas;
    public Button Comida;
    public Button Quadra;
 

    //Imagens
    public Image ImagemFeliz;


    public GameObject MenuCantina;
    public GameObject MenuAula;
    public GameObject MenuEdF;
    public GameObject Hud;
    public GameObject Loja;
    public GameObject Loja2;     



    // Use this for initialization
    void Start() {
        MenuCantina.SetActive(false);
        MenuAula.SetActive(true);        
        Hud.SetActive(true);
        Loja.SetActive(false);
        Loja2.SetActive(false);       

    }

    // Update is called once per frame
    void Update() {        
        SetandoTexto();
        ImagemFeliz.fillAmount = Felicidade;
            }

    public void ContandoNotas() {
        Notas = Notas + 1 * QualiAula;
        Felicidade = Felicidade - 0.05f;     
    }
    public void ContandoDin()
    {
        Dinheiro++;    
        Dinheiro = Dinheiro * QualiCantina;       
    }
    public void ContandoFelicidade()
    {
        Felicidade = Felicidade + 0.02f * QualiQuadra;        
    }

    void SetandoTexto() {
        txtNotas.text = Notas.ToString();
        txtDinheiro.text = Dinheiro.ToString();
        txtAlunos.text = Alunos.ToString();
    }

    public void  AtivandoCantina(){
        MenuCantina.SetActive(true);
        MenuAula.SetActive(false);
        MenuEdF.SetActive(false);      
        Hud.SetActive(true);
        Loja2.SetActive(false);
    }
    public void AtivandoAula()
    {
        MenuCantina.SetActive(false);
        MenuEdF.SetActive(false);
        MenuAula.SetActive(true);        
        Hud.SetActive(true); 
        Loja2.SetActive(false);
        Loja.SetActive(false);
    }
    public void AtivandoQuadra()
    {
        MenuCantina.SetActive(false);
        MenuEdF.SetActive(true);
        MenuAula.SetActive(false);       
        Hud.SetActive(true); 
        Loja2.SetActive(false);
    }
    public void AtivandoLoja()
    {
        MenuCantina.SetActive(false);
        MenuEdF.SetActive(false);
        MenuAula.SetActive(false);       
        Hud.SetActive(false);
        Loja.SetActive(true);
        Loja2.SetActive(false);
    }
    public void AtivandoPag2()
    {
        Loja2.SetActive(true);
        Loja.SetActive(false);
    }
     /*void TrabProfessor()
    {
        Notas = Notas + 1 * QuantiProf;
    }
    protected void AplicarProva()
    {
        InvokeRepeating("TrabProfessor", 1.0f, 1.0f);
    }
    */
}
