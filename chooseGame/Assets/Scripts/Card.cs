using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    
    [SerializeField] TMP_Text main_Text;
    //[SerializeField] TMP_Text leftAnswer_Text;
    //[SerializeField] TMP_Text rightAnswer_Text;
    [SerializeField] Image sprite_personagem;
    
    //Vai Iniciar com alguma carta aleatória
    void Start()
    {
        
        //Encontra o cardcontroller para gerar uma nova carta sempre que o jogador deslizar para os lados
       
    }
    public void ShowCards(string maintext, Sprite sprite)
    {
        main_Text.SetText(maintext);
        sprite_personagem.sprite = sprite;
    }
    

    
    //Mostra Informações da Carta
 
}
