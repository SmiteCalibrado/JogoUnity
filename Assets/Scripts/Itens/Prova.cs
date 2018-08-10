using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : Itens {

    public Prova()
    {
        Preco = 25;
        ItemNot = 50;
    }


    public override void Executar()
    {
        Controlando.QualiAula++;
        Controlando.Feliz = Controlando.Feliz+ 0.01f;
        Atualizar();
        
    }

    public override void Atualizar()
    {
        Preco = Preco * 2;
        ItemNot = ItemNot * 2;
    }
}
