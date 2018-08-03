using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoPlay : MonoBehaviour {
    

    public void IniciarJogo() {
        SceneManager.LoadScene("CenaJogo", LoadSceneMode.Additive);
    }

    
}
