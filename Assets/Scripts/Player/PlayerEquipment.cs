using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    //refer�ncia global do c�digo do personagem
    public static PlayerEquipment Instance { get; set; }

    //niveis de equipamento
    public int sword_lvl, armor_lvl, shield_lvl;
    //po��es que o jogador tem agora
    public int potions, max_potions;

    private void Awake()
    {
        //setta a refer�ncia global desse script
        if (Instance == null) Instance = this;
        //garante que s� tem um dele na cena
        else Destroy(gameObject);
    }
}
