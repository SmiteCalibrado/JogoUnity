using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour {

    public Itens Item01;
    public Itens Item02;
    public Itens Item03;
    public Itens Item04;
    public Itens Item05;
    public Itens Item06;


    public Text txtNota01;
    public Text txtNota02;
    public Text txtNota03;
    public Text txtNota04;
    public Text txtNota05;
    public Text txtNota06;
    public Text txtDin01;
    public Text txtDin02;
    public Text txtDin03;
    public Text txtDin04;
    public Text txtDin05;
    public Text txtDin06;
    public Text txtAlu06;   

    // Use this for initialization
    void Start () {
        Item01 = new Itens();
        Item01.Preco = 50;
        Item01.Nota = 100;

        Item02 = new Itens();
        Item02.Preco = 55;
        Item02.Nota = 50;

        Item03 = new Itens();
        Item03.Preco = 25;
        Item03.Nota = 50;

        Item04 = new Itens();
        Item04.Preco = 70;
        Item04.Nota = 45;

        Item05 = new Itens();
        Item05.Preco = 95;
        Item05.Nota = 150;

        Item06 = new Itens();
        Item06.Preco = 10000;
        Item06.Nota = 2000;
        Item06.Alunos = 375;
    }
	
	// Update is called once per frame
	void Update () {
        txtNota01.text = Item01.Nota.ToString();
        txtDin01.text = Item01.Preco.ToString();
        txtNota02.text = Item02.Nota.ToString();
        txtDin02.text = Item02.Preco.ToString();
        txtNota03.text = Item03.Nota.ToString();
        txtDin03.text = Item03.Preco.ToString();
        txtNota04.text = Item04.Nota.ToString();
        txtDin04.text = Item04.Preco.ToString();
        txtNota05.text = Item05.Nota.ToString();
        txtDin05.text = Item05.Preco.ToString();
        txtNota06.text = Item06.Nota.ToString();
        txtDin06.text = Item06.Preco.ToString();
        txtAlu06.text = Item06.Alunos.ToString();
    }
    public void Professores() {
        if (Controlando.Notas >= Item01.Nota) {
            Controlando.Dinheiro = Controlando.Dinheiro - Item01.Preco;
            //FAZER UMA FUNÇÃO AUTOMATICA            
            AplicarProva();
            Item01.Preco = Item01.Preco * 2;
            Item01.Nota = Item01.Nota * 2;
        }      
       
    }
    public void MelhorandoQuadra() {
        if (Controlando.Notas >= Item02.Nota) {
            Controlando.Dinheiro = Controlando.Dinheiro - Item02.Preco;
            Controlando.QualiQuadra++;
            Item02.Preco = Item02.Preco * 2;
            Item02.Nota = Item02.Nota * 2;
        }
    }
    public void MelhorandoAula() {
        if(Controlando.Notas >= Item03.Nota)
        {
            Controlando.Dinheiro = Controlando.Dinheiro - Item03.Preco;
            Controlando.QualiAula++;
            Item03.Preco = Item03.Preco * 2;
            Item03.Nota = Item03.Nota * 2;
        }
    }
    public void MelhoreaComida() {
        if (Controlando.Notas >= Item04.Nota) {
            Controlando.Dinheiro = Controlando.Dinheiro - Item04.Preco;
            Controlando.QualiCantina++;
            Item04.Preco = Item04.Preco * 2;
            Item04.Nota = Item04.Nota * 2;
        }
    }
    public void AumentarEscola() {
        if (Controlando.Notas >= Item05.Nota) {
            Controlando.Dinheiro = Controlando.Dinheiro - Item05.Preco;
            Controlando.Alunos = Controlando.Alunos + 5;
            Item05.Preco = Item05.Preco * 2;
            Item05.Nota = Item05.Nota * 2;
        }
    }
    public void RevolucaoEscolar() {
        if(Controlando.Notas > Item06.Nota||Controlando.Alunos >= Item06.Alunos){
            Controlando.Dinheiro = Controlando.Dinheiro - Item06.Preco;
            //Fazer funcao para Felicidade nao cair
            //Fazer Funcao para Notas Cair Por Alguns Segundos
            Item06.Preco = Item06.Preco * 2;
            Item06.Nota = Item06.Preco * 2;
            Item06.Alunos = Item06.Alunos * 2;
        }
    }
    void TrabProfessor()
    {
        Controlando.Notas = Controlando.Notas + 1 * Controlando.QuantiProf;
    }

    void AplicarProva()
    {
        InvokeRepeating("TrabProfessor", Controlando.TempProf, Controlando.TempProf);  //Fazer um bost de trabalho

    }

}
