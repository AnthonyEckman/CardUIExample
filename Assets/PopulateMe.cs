using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateMe : MonoBehaviour
{
    
    //list of cards that have been spawned
    [SerializeField]
    private List<BasicCardScript> activeCards = new List<BasicCardScript>();
    //list of cards that need to be spawned.
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
            //spawns the blank prefab card
            BasicCardScript tempCard = Instantiate(Card.myTemplate, transform);
            //changes the image of the prefab to a card image
            tempCard.CardBack.sprite = Card.CardBase;
            //changes the text component of the buttons
            tempCard.myButtons[0].GetComponentInChildren<Text>().text = Card.ability1.AbilityText;
            tempCard.myButtons[1].GetComponentInChildren<Text>().text = Card.ability2.AbilityText;
            activeCards.Add(tempCard);

        } 
    }
    
}
