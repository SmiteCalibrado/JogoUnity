using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantina :Itens {


    public Cantina()
    {
        Preco = 25;
        ItemNot = 50;

    }

    public override void Atualizar()
    {
        Preco = Preco * 2;
        ItemNot = ItemNot * 2;
    }

    public override void Executar()
    {
        Controlando.QualiCantina++;
        Atualizar();
    }                                                                                         
}
