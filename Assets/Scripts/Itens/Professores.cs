using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Professores : Itens {


    public Professores()
    {

    }

    public override void Atualizar()
    {
        Preco = Preco * 2;
        ItemNot = ItemNot * 2;
    }

    public override void Executar()
    {
        Controlando.QuantiProf++;
        Atualizar();
    }
}
