using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadra :Itens {

    public Quadra()
    {
        Preco = 35;
        nota = 100;

    }

    public override void Executar()
    {
        Controlando.QualiQuadra++;
        Atualizar();

    }
    public override void Atualizar()
    {
        Preco = Preco * 2;
        ItemNot = ItemNot * 2;
    }
}
