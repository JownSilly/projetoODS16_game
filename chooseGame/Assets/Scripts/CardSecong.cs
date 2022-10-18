using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSecong : MonoBehaviour
{
    private CardLogic _cardlogic;
    private GameObject _firstCard;

    // Start is called before the first frame update
    void Start()
    {
        _cardlogic = FindObjectOfType<CardLogic>();
        _firstCard = _cardlogic.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
