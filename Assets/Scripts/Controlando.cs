using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Controlando : MonoBehaviour {

    //int e float
    int Notas;
    int Alunos;
    int Dinheiro;
    int QualiAula = 1;
    int QualiCantina = 1;
    int QualiQuadra = 1;
    float Felicidade = 1;

    //textos
    public Text txtNotas;
    public Text txtDinheiro;
    public Text txtAlunos;
    

    //botoes
    public Button Aulas;
    public Button Comida;
    public Button Quadra;
 

    //Image
    public Image ImagemFeliz;


    public GameObject MenuCantina;
    public GameObject MenuAula;
    public GameObject MenuEdF;
    public GameObject ProvaA;
    public SpriteRenderer PeixeAnimacao;
  


    // Use this for initialization
    void Start() {
        MenuCantina.SetActive(false);
        MenuAula.SetActive(true);
        ProvaA.SetActive(true);
        PeixeAnimacao.enabled = false;
    }

    // Update is called once per frame
    void Update() {        
        SetandoTexto();
        ImagemFeliz.fillAmount = Felicidade;
            }

    public void ContandoNotas() {
        Notas++;
        Notas = Notas* QualiAula;
        Felicidade = Felicidade - 0.05f;     
    }
    public void ContandoDin()
    {
        Dinheiro++;    
        Dinheiro = Dinheiro * QualiCantina;       
    }
    public void ContandoFelicidade()
    {
        Felicidade = Felicidade + 0.02f;
        Felicidade = Felicidade * QualiQuadra;
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
        ProvaA.SetActive(false);
        PeixeAnimacao.enabled = true;
    }
    public void AtivandoAula()
    {
        MenuCantina.SetActive(false);
        MenuEdF.SetActive(false);
        MenuAula.SetActive(true);
        ProvaA.SetActive(true);
        PeixeAnimacao.enabled = false;

    }
    public void AtivandoQuadra()
    {
        MenuCantina.SetActive(false);
        MenuEdF.SetActive(true);
        MenuAula.SetActive(false);
        ProvaA.SetActive(false);
        PeixeAnimacao.enabled = false;
    }

}
