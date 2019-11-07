using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateMe : MonoBehaviour
{
    
    public int ammount;
    [SerializeField]
    private List<BasicCardScript> activeCards = new List<BasicCardScript>();
    public List<CardScriptableObject> myHand = new List<CardScriptableObject>();



    // Start is called before the first frame update
    void Start()
    {
        SpawnCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCards()
    {
        
        foreach (CardScriptableObject Card in myHand)
        {
            BasicCardScript tempCard = Instantiate(Card.myTemplate, transform);
            tempCard.CardBack.sprite = Card.CardBase;
            tempCard.myButtons[0].GetComponentInChildren<Text>().text = Card.ability1.AbilityText;
            tempCard.myButtons[1].GetComponentInChildren<Text>().text = Card.ability2.AbilityText;
            activeCards.Add(tempCard);

        } 
    }
    
}
