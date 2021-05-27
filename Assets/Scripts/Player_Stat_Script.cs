using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stat_Script : MonoBehaviour
{
    private const int BASESTATS = 5;
    private const int BASEATRIBUTES = 50;
    private const int BASEXP = 0;
    private const int BASELEVEL = 1;
    public int endurance { get; set; }
    //
    public int strength { get; set; }
    //
    public int dexterity { get; set; }
    //
    public int intelligence { get; set; }
    //
    public int magicEndurance { get; set; }
    //
    public int experiencePoints { get; set; }
    //
    public int health { get; set; }
    //
    public int manaPoints { get; set; }
    //
    public int level { get; set; }
    // Start is called before the first frame update
    void Awake()
    {
        createCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createCharacter()
    {
        endurance = BASESTATS;
        strength = BASESTATS;
        dexterity = BASESTATS;
        intelligence = BASESTATS;
        magicEndurance = BASESTATS;
        experiencePoints = BASEXP;
        health = BASEATRIBUTES;
        manaPoints = BASEATRIBUTES;
        level = BASELEVEL;
    }
}

