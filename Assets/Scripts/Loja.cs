using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour {

    Prova ItemProva = new Prova();
    Quadra ItemQuadra = new Quadra();
    Cantina ItemCant = new Cantina();
    Professores ItemProf = new Professores();
   
    [Header("Item Prova")]
    public Text Precoprov;
    public Text Notaprov;
    public Animator Provaanima;

    [Header("Item Quadra")]
    public Text Precoquadra;
    public Text Notaquadra;
    public Animator QuadraAnima;

    [Header("Item Cantina")]
    public Text PrecoCant;
    public Text NotaCant;
    public Animator CantiAnima;

    [Header("Item Professores")]
    public Text PrecoProf;
    public Text NotaProf;
    public Animator ProfAnima;

    // Use this for initialization
    void Start () {
        		
	}
	
	// Update is called once per frame
	void Update () {
        AtualizarText();
        AtualizarAnimacao();
	}

    public void AtualizarText() {
        //Sistema de texto 
       Precoprov.text = ItemProva.Preco.ToString();
       Notaprov.text = ItemProva.ItemNot.ToString();

       Precoquadra.text = ItemQuadra.Preco.ToString();
       Notaquadra.text = ItemQuadra.ItemNot.ToString();

       PrecoCant.text = ItemCant.Preco.ToString();
       NotaCant.text = ItemCant.ItemNot.ToString();

        PrecoProf.text = ItemProf.Preco.ToString();
        NotaProf.text = ItemProf.ItemNot.ToString();

    }
    public void btnProva()
    {
        if (Controlando.Dinheiro >= ItemProva.Preco && Controlando.Notas >= ItemProva.ItemNot)
        {
            ItemProva.Executar();
            Controlando.Dinheiro = Controlando.Dinheiro - ItemProva.Preco;
        }
    }

    public void btnQuadra()
    {

        if (Controlando.Dinheiro >= ItemProva.Preco && Controlando.Notas >= ItemProva.ItemNot)
        {
            ItemQuadra.Executar();
            Controlando.Dinheiro = Controlando.Dinheiro - ItemQuadra.Preco;
        }

    }

    public void btnCantina()
    {

        if (Controlando.Dinheiro >= ItemProva.Preco && Controlando.Notas >= ItemProva.ItemNot)
        {
            ItemCant.Executar();
            Controlando.Dinheiro = Controlando.Dinheiro - ItemCant.Preco;
        }

    }
    public void ContratarProfs()
    {
        if (Controlando.Dinheiro >= ItemProf.Preco && Controlando.Notas >= ItemProf.ItemNot)
        {
            ItemCant.Executar();
            Debug.Log("parte dois funcionou");
            InvokeRepeating("Profs", 1, 10);
            Controlando.Dinheiro = Controlando.Dinheiro - ItemProf.Preco;
        }
    }

    public void AtualizarAnimacao()
    {
        if (Controlando.Dinheiro >= ItemProva.Preco && Controlando.Notas >= ItemProva.ItemNot)
        {
            Provaanima.SetBool("Trancado", false);

        }
        else {
            Provaanima.SetBool("Trancado",true);
        }

        if (Controlando.Dinheiro >= ItemQuadra.Preco && Controlando.Notas >= ItemQuadra.ItemNot)
        {
            QuadraAnima.SetBool("Trancado", false);

        }
        else
        {
            QuadraAnima.SetBool("Trancado", true);
        }

        if (Controlando.Dinheiro >= ItemQuadra.Preco && Controlando.Notas >= ItemQuadra.ItemNot)
        {
           CantiAnima.SetBool("Trancado", false);

        }
        else
        {
            CantiAnima.SetBool("Trancado", true);
        }
        if (Controlando.Dinheiro >= ItemProf.Preco && Controlando.Notas >= ItemProf.ItemNot)
        {
           ProfAnima.SetBool("Trancado", false);

        }
        else
        {
            ProfAnima.SetBool("Trancado", true);
        }
    }

    public void Profs()
    {
        foreach (int prof in Controlando.QuantiProfs )
        {
            Controlando.Notas++;            // duvida 2
        }

    }

}
