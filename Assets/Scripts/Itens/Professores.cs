using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Professores : Itens {


    public Professores()
    {
        Preco = 5;
        ItemNot = 4; 
    }

    public override void Atualizar()
    {
        Preco = Preco * 2;
        ItemNot = ItemNot * 2;
    }

    public override void Executar()
    {
        Controlando.QuantiProfs.Add(1); // duvida 1
        Atualizar();
    }
}
