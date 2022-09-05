using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    string heroname = "super mario";
    int heroAge = 20;
    float heroHeight = 170.5f;
    string heroPower = "Jump";

    string vilianName = "Vilian";
    float vIlianHeight = 180.3f;
    int vilianAge = 100;
    string vilianSuperpower = "fly";
    int agediff;


    void Start()
    {
        if (heroAge > vilianAge)
        {
            agediff = heroAge - vilianAge;
        }else
        {
            agediff =  vilianAge- heroAge;
        }

        print(" Hero's name is +heroname+");
        print(" Hero's height is +heroHeight+");
        print(" Hero's age is +heroAge+");
        print(" Hero's power is +heroPower+");

        print(" Vilian's name is +vilianName+");
        print(" Vilian's height is +vIlianHeight+");
        print(" Vilian's age is +vilianAge+");
        print(" Vilian's power is +vilianSuperpower+");

        heroHeight = heroHeight + 5;
        vilianSuperpower = "None ";

        print(" Updated values");

        print(" Hero's name is +heroname+");
        print(" Hero's height is +heroHeight+");
        print(" Hero's age is +heroAge+");
        print(" Hero's power is +heroPower+");

        print(" Vilian's name is +vilianName+");
        print(" Vilian's height is +vIlianHeight+");
        print(" Vilian's age is +vilianAge+");
        print(" Vilian's power is +vilianSuperpower+");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
