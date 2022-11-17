using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public CardPlayer player;
    public GameManager gameManager;
    public float chooseInterval;
    private float timer = 0;

    int lastSelected =0;

    Card[] cards;

    private void Start()
    {
        cards = GetComponentsInChildren<Card>();
    }
    void Update()
    {
        if(gameManager.State != GameManager.GameState.ChooseAttack)
        
        if (timer < chooseInterval)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        ChooseAttack();
               
    }

    public void ChooseAttack()
    {
        var random = Random.Range(0, cards.Length);
        var selection = (lastSelected + random) % cards.Length;

        player.SetChosenCard(cards[selection]);
        lastSelected = selection;
    }
}
