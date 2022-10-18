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
    [SerializeField] CardData cardPadrao;

    //Vai Iniciar com alguma carta aleatória
    void Start()
    {
        //Encontra o cardcontroller para gerar uma nova carta sempre que o jogador deslizar para os lados
        var cardController =GameObject.Find("GameManager").GetComponent<CardController>();
        
        ShowCards(cardController.NewCard());
    }
    
    //Mostra Informações da Carta
    public void ShowCards(CardData card_data)
    {
        main_Text.SetText(card_data.main_text);
        sprite_personagem.sprite = card_data.sprite_personagem;
        cardPadrao = card_data;
    }
}
