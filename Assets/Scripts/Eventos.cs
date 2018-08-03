using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eventos : MonoBehaviour {

    float Otempo;
    float TempoMax = 1.0f;

    public Controlando control2;

    public Image EfeitoTriste;
	// Use this for initialization
	void Start () {
        control2 = new Controlando();
    }
	
	// Update is called once per frame
	void Update () {
        if (Controlando.Felicidade <= 0) {
            TirandoFelicidade();
        }
	}

    public void TirandoFelicidade() {        
        Otempo += Time.deltaTime;
        if (Otempo >= TempoMax) {
            Otempo = 0;
            Controlando.Notas--;
            EfeitoTriste.enabled = true;
        }

    }
}
