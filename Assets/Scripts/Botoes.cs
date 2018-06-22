using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Botoes : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public Animator ProvaAnima;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        ProvaAnima.SetBool("Notas", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ProvaAnima.SetBool("Notas", false);

    }
}
