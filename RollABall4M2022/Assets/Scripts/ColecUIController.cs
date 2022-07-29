using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecUIController : MonoBehaviour
{
    // referencia para o objeto de texto da interface
    [SerializeField]
    private TMP_Text colecText;

    private void OnEnable()
    {
        // Se inscreve no canal de coins
        PlayerObserverManager.OnCubeChanged += UpdateColecText;
    }

    private void OnDisable()
    {
        // Retira a inscrição no canal de coins
        PlayerObserverManager.OnCubeChanged -= UpdateColecText;
    }

    // funcao usada para tratar a notificacao do canal
    // de coins
    private void UpdateColecText(int newCubeValue)
    {
        // atualiza o valor das moedas na interface
        colecText.text = newCoinsValue.ToString();
    }
}
