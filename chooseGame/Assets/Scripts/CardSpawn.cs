using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardSpawn : MonoBehaviour
{
    public Button botao1;
    public CardData asdasd;
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
    public void OnSpawnPrefab()
    {
            GameObject newCard = Instantiate(prefabcard, new Vector2(prefabcard.transform.position.x, prefabcard.transform.position.y), Quaternion.identity) as GameObject ;
        
        newCard.transform.SetParent(GameObject.Find("Canvas Cartas").transform,false);
    }
    
}
