using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject card;
    public CardLogic logicCard;
    SpriteRenderer spriteRender;
    float fMovingSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = card.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&& logicCard.isMouseOver)
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            card.transform.position = position;
        }
        if (card.transform.position.x > 2)
        {
            spriteRender.color = Color.green;
            if (!Input.GetMouseButton(0)){
                logicCard.InduceRight();
                
            }
        }
        else if(card.transform.position.x<-2){
            spriteRender.color = Color.red;
            if (!Input.GetMouseButton(0))
            {
                logicCard.InduceLeft ();
                
            }

        }
        else
        {
            spriteRender.color = Color.white;
        }
    }
}
