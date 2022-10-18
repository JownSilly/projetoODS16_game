using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Button botao1;
    public CardData[] cardList;
    private Card cardsave;
    [SerializeField] private GameObject prefabcard;
    // Start is called before the first frame update
    void Start()
    {
        botao1.onClick = new Button.ButtonClickedEvent();
        botao1.onClick.AddListener(() => OnSpawnPrefab());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //retorna uma nova carta aleatória
    public CardData NewCard()
    {

        int randomNumber = Random.Range(0, cardList.Length);
        
        return cardList[randomNumber];
        
    }
    public void OnSpawnPrefab()
    {
        
        GameObject newCard = Instantiate(prefabcard, new Vector2(prefabcard.transform.position.x, prefabcard.transform.position.y), Quaternion.identity) as GameObject;

        newCard.transform.SetParent(GameObject.Find("Canvas Cartas").transform, false);
        
    }
}
