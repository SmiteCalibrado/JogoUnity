using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Controlando : MonoBehaviour {

    //int e float
    [Header("Os Bagulho Importante")]
    public static int Notas = 0;
    public static int Alunos = 40;
    public static int Dinheiro = 0;

    [Header("O Que ninguem liga")]
    public static float Feliz = 0.05f;
    public static int QualiAula = 1;
    public static int QualiCantina = 1;
    [Header("O Que ninguem liga Parte 2")]
    public static List<int> QuantiProfs;    
    public static float QualiQuadra = 1;
    public static float TempProf = 10.0f;
    public static float Felicidade = 1;

    [Header("Textos")]
    public Text txtNotas;
    public Text txtDinheiro;
    public Text txtAlunos;

    [Header("Imagens")]
    public Image ImagemFeliz;
    public Image EfeitoTriste;
    public Image EfeitoCafe;

    [Header("Menus")]
    public GameObject MenuCantina;
    public GameObject MenuAula;
    public GameObject MenuEdF;
    public GameObject Hud;
    public GameObject Loja;
    public GameObject Loja2;
    public GameObject MenuEventos;
   
    // Use this for initialization
    void Start() {     
        MenuCantina.SetActive(false);      
        MenuAula.SetActive(true);
        Hud.SetActive(true);
        Loja.SetActive(false);
        Loja2.SetActive(false);
        EfeitoCafe.enabled = false;
        EfeitoTriste.enabled = false;
        MenuEventos.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        SetandoTexto();        
        SetandoZero();
        ImagemFeliz.fillAmount = Felicidade;
    }


    public void ContandoNotas() {
        Notas = Notas + 1 * QualiAula;
        Felicidade = Felicidade - Feliz;
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

    public void AtivandoCantina() {
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
  

    void SetandoZero()
    {
        if (Felicidade < 0f)
        {
            Felicidade = 0;
        }
        if (Notas <= 0)
        {
            Notas = 0;
        }
        if (Alunos <= 0)
        {
            Alunos = 0;
        }
        if (Dinheiro <= 0)
        {
            Dinheiro = 0;
        }
    }
   
}
