using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardDataSO : ScriptableObject
{
    public List<CardData> cardData;
}

[Serializable]
public class CardData
{
    [field: SerializeField]
    public int Vol { get; private set; }
    [field: SerializeField]
    public string Suit { get; private set; }
    [field: SerializeField]
    public Sprite Sprite {  get; private set; }
}