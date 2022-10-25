using System;
using CastleAggregate.Weapons;
using UnityEngine;
using static BuildingsStats; 
using static BonusesStats;

public class AttackBonuses : MonoBehaviour
{
    private CardManager _cardManager;
    private ArrowsSpawner _arrowsSpawner;

    public void Init(CardManager cardManager)
    {
        _cardManager = cardManager;
    }
    
    public void IncreaseArrowDamage()
    {
        AnyBuilding.Castle.arrowDamage += 0.5f;
        DeletingCards();
    }
    
    public void IncreaseCastleAttackSpeed()
    {
        AnyBuilding.Castle.attackCooldown -= 0.15f;
        DeletingCards();
    }

    private void AddArrowWave()
    {
        flagCreateArrowWave = true;
        DeletingCards();
    }
    

    private void DeletingCards()
    {
        _cardManager.DeleteCardFromList("attack");
        _cardManager.DestroyCards();
    }
}
