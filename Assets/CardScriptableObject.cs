using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="yes")]
public class CardScriptableObject : ScriptableObject
{
    public BasicCardScript myTemplate;
    public Sprite CardBase;
    public BasicAbilitySO ability1;
    public BasicAbilitySO ability2;

}
