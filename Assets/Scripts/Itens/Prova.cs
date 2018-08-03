using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : Itens {

     public void Itens()
    {
        Preco = 25;
        ItemNot = 50;
    }

    public override void Executar()
    {
        Controlando.QualiAula++;
        Controlando.Felicidade--;
    }
}
