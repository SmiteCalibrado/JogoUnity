using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loja : MonoBehaviour {

    Prova ItemProva = new Prova();

    // Use this for initialization
    void Start () {

        		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AtualizarText() {
        //Sistema de texto 
    }
    public void btnProva()
    {
        if (Controlando.Dinheiro >= ItemProva.Preco && Controlando.Notas >= ItemProva.ItemNot)
        {
            ItemProva.Executar();
        }
    }
}
