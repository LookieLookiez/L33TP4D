using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeetReactions : MonoBehaviour {
    public GameObject[] Screws;
    private int screwCount = 0;
    public GameObject panel;
    private bool screwsOut;
    private bool panelOff;

    private float timer = 1f;
    private bool countDown = false;
	// Update is called once per frame
	void Update () {
        if(countDown)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                PrintToScreen.Instance.readOut = null;
                timer = 1f;
                countDown = false;
            }
        }

        //Story//
        //Screw
        if (PrintToScreen.Instance.readOut == "5CR3W")
        { 
            if(screwCount == 3)
            {
                PrintToScreen.Instance.readOut = "N0W What";
                screwsOut = true;
            }
            else
            {
                PrintToScreen.Instance.readOut = "PLZ N0";
            }
            Screws[screwCount].transform.position = new Vector3(1000, 1000, 1000);
            screwCount++;
            countDown = true;
        }
        //Open
        if (PrintToScreen.Instance.readOut == "0P3N" && screwsOut)
        {

            PrintToScreen.Instance.readOut = "FUC U";
            panel.transform.position = new Vector3(1000, 1000, 1000);
            panelOff = true;
            countDown = true;
        }
        //Wire
        if (PrintToScreen.Instance.readOut == "W1R3")
        {
            if(panelOff)
            {
                PrintToScreen.Instance.readOut = "3 of them";
            }
            countDown = true;
        }
        //CutWire
        if (PrintToScreen.Instance.readOut == "CU7W1R3" && panelOff)
        {
            if (panelOff)
            {
                PrintToScreen.Instance.readOut = "Which one";
            }
            countDown = true;
        }
        //RedWire
        if (PrintToScreen.Instance.readOut == "R3DW1R3" && panelOff)
        {
            PrintToScreen.Instance.readOut = "R U Sure";

            countDown = true;
        }
        //GreenWire
        if (PrintToScreen.Instance.readOut == "9R33NW1R3" && panelOff)
        {
            PrintToScreen.Instance.readOut = "R U Sure";

            countDown = true;
        }
        //BlueWire
        if (PrintToScreen.Instance.readOut == "81U3W1R3" && panelOff)
        {
            PrintToScreen.Instance.readOut = "R U Sure";

            countDown = true;
        }




        //Love
        if (PrintToScreen.Instance.readOut == "10U3")
        {
            PrintToScreen.Instance.readOut = "U 2 Babe";
            countDown = true;
        }
        //Hate
        if (PrintToScreen.Instance.readOut == "H473")
        {
            PrintToScreen.Instance.readOut = "PLZ LUV";
            countDown = true;
        }
        //Loser
        if (PrintToScreen.Instance.readOut == "1053R")
        {
            PrintToScreen.Instance.readOut = "o.0";
            countDown = true;
        }
        //Leet
        if (PrintToScreen.Instance.readOut == "1337")
        {
            PrintToScreen.Instance.readOut = "Yes!";
            countDown = true;
        }
        //Who
        if (PrintToScreen.Instance.readOut == "WH0")
        {
            PrintToScreen.Instance.readOut = "Me";
            countDown = true;
        }
        //Why
        if (PrintToScreen.Instance.readOut == "WHY")
        {
            PrintToScreen.Instance.readOut = "Why Not";
            countDown = true;
        }
        //SAD
        if (PrintToScreen.Instance.readOut == "54D")
        {
            PrintToScreen.Instance.readOut = "Who";
            countDown = true;
        }
        //ISAD
        if (PrintToScreen.Instance.readOut == "154D")
        {
            PrintToScreen.Instance.readOut = "LOL";
            countDown = true;
        }
        //USAD
        if (PrintToScreen.Instance.readOut == "U54D")
        {
            PrintToScreen.Instance.readOut = "Nope :)";
            countDown = true;
        }
        //IHateYou
        if (PrintToScreen.Instance.readOut == "1H473Y0U")
        {
            PrintToScreen.Instance.readOut = "PLZ LUV";
            countDown = true;
        }
        //Dave
        if (PrintToScreen.Instance.readOut == "D4V3")
        {
            PrintToScreen.Instance.readOut = "I Am Here?";
            countDown = true;
        }
        //Shipwreck
        if (PrintToScreen.Instance.readOut == "5H1PWR3K")
        {
            PrintToScreen.Instance.readOut = "R U PR0UD";
            countDown = true;
        }
        //Acid
        if (PrintToScreen.Instance.readOut == "4C1D")
        {
            PrintToScreen.Instance.readOut = "Trippy!";
            countDown = true;
        }
        //Agnostic
        if (PrintToScreen.Instance.readOut == "49N0571C")
        {
            PrintToScreen.Instance.readOut = "N0W U NO";
            countDown = true;
        }
        //Shrek
        if (PrintToScreen.Instance.readOut == "5HR3K")
        {
            PrintToScreen.Instance.readOut = "Is Life";
            countDown = true;
        }
        //Cuck
        if (PrintToScreen.Instance.readOut == "CUCK")
        {
            PrintToScreen.Instance.readOut = "R U? Sry";
            countDown = true;
        }
        //Pepe
        if (PrintToScreen.Instance.readOut == "P3P3")
        {
            PrintToScreen.Instance.readOut = "Frog you!";
            countDown = true;
        }
        //420Blaze
        if (PrintToScreen.Instance.readOut == "42081453")
        {
            PrintToScreen.Instance.readOut = "Drg R Bad";
            countDown = true;
        }
        //Base
        if (PrintToScreen.Instance.readOut == "8453")
        {
            PrintToScreen.Instance.readOut = "AYBABTU";
            countDown = true;
        }


        //Anime
        //Anime
        if (PrintToScreen.Instance.readOut == "4N1W5")
        {
            PrintToScreen.Instance.readOut = "Fuck Yeah!";
            countDown = true;
        }
        //Sister
        if (PrintToScreen.Instance.readOut == "51573R")
        {
            PrintToScreen.Instance.readOut = "KissXsis";
            countDown = true;
        }
        //Naruto
        if (PrintToScreen.Instance.readOut == "N4RU70")
        {
            PrintToScreen.Instance.readOut = "Rasengan";
            countDown = true;
        }
        //Natsu
        if (PrintToScreen.Instance.readOut == "N475U")
        {
            PrintToScreen.Instance.readOut = "Salamander";
            countDown = true;
        }



        //Childish//
        //Anus
        if (PrintToScreen.Instance.readOut == "4NU5")
        {
            PrintToScreen.Instance.readOut = "Child";
            countDown = true;
        }
        //Anal
        if (PrintToScreen.Instance.readOut == "4N41")
        {
            PrintToScreen.Instance.readOut = "Child";
            countDown = true;
        }
        //Shit
        if (PrintToScreen.Instance.readOut == "5H17")
        {
            PrintToScreen.Instance.readOut = "Child";
            countDown = true;
        }
        //Cunt
        if (PrintToScreen.Instance.readOut == "CUN7")
        {
            PrintToScreen.Instance.readOut = "U 2 Babe";
            countDown = true;
        }
        //Boobs
        if (PrintToScreen.Instance.readOut == "80085")
        {
            PrintToScreen.Instance.readOut = "U R SMORT";
            countDown = true;
        }
        //Tits
        if (PrintToScreen.Instance.readOut == "7175")
        {
            PrintToScreen.Instance.readOut = "Really";
            countDown = true;
        }
        //Dick
        if (PrintToScreen.Instance.readOut == "D1CK")
        {
            PrintToScreen.Instance.readOut = "Really";
            countDown = true;
        }



        //KickedOff
        //Kek
        if (PrintToScreen.Instance.readOut == "K3K")
        {
            PrintToScreen.Instance.readOut = "GTFO!";
            countDown = true;
            if(!countDown)
            {
                Application.Quit();
            }
        }
        //Swastika
        if (PrintToScreen.Instance.readOut == "5W4571K4")
        {
            PrintToScreen.Instance.readOut = "GTFO!";
            countDown = true;
            if (!countDown)
            {
                Application.Quit();
            }
        }
        //Hitler
        if (PrintToScreen.Instance.readOut == "H1713R")
        {
            PrintToScreen.Instance.readOut = "GTFO!";
            countDown = true;
            if (!countDown)
            {
                Application.Quit();
            }
        }



    }

}
