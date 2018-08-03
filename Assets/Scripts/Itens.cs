using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Itens {

    protected int preco;
    protected int nota;

    public int Preco
    {
        get
        {
            return preco;
        }
        set
        {
            preco = value;
        }
    }

    public int ItemNot
    {
        get
        {
            return nota;
        }
        set
        {
            preco = nota;
        }
    }

    public abstract void Executar();


   
}
