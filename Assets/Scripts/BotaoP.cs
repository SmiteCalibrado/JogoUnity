using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotaoP : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Animator PeixeAnima;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PeixeAnima.SetBool("Peixes", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PeixeAnima.SetBool("Peixes", false);

    }
}
