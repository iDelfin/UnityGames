using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCollider : MonoBehaviour
{
    public int GearInventory = 0;
    public int SpringInvenory = 0;
    public int ScrewInventory = 0;
    public int DolosInventory = 0;
    public Text GearNumUI;
    public Text SpringNumUI;
    public Text ScrewNumUI;
    public Text DolosNumUI;

    public GameObject NpcFsd;
    public GameObject NpcLg;
    public GameObject NpcWea;
    public GameObject NpcThr;


    void Start()
    {
        GearNumUI.text = "Gears = " + GearInventory;
        SpringNumUI.text = "Springs = " + SpringInvenory;
        ScrewNumUI.text = "Screws = " + ScrewInventory;
        DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gear"))
        {
            GearInventory++;
            GearNumUI.text = "Gears = " + GearInventory;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Springs"))
        {
            SpringInvenory++;
            SpringNumUI.text = "Springs = " + SpringInvenory;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Screws")){
            ScrewInventory++;
            ScrewNumUI.text = "Screws = " + ScrewInventory;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("NPCFSD"))
        {
            if ((GearInventory >= 5) && (ScrewInventory >= 3)){
                GearInventory -= 5;
                ScrewInventory -= 3;
                DolosInventory += 50;
                GearNumUI.text = "Gears = " + GearInventory;
                ScrewNumUI.text = "Screws = " + ScrewInventory;
                DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
                NpcFsd.SetActive(false);
            }
        }
        else if (other.gameObject.CompareTag("NPCLG"))
        {
            if ((GearInventory >= 3) && (ScrewInventory >= 2) && (SpringInvenory >= 2)){
                GearInventory -= 3;
                ScrewInventory -= 2;
                SpringInvenory -= 2;
                DolosInventory += 30;
                GearNumUI.text = "Gears = " + GearInventory;
                ScrewNumUI.text = "Screws = " + ScrewInventory;
                SpringNumUI.text = "Springs = " + SpringInvenory;
                DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
                NpcLg.SetActive(false);

            }
        }
        else if (other.gameObject.CompareTag("NPCWeapons")){
            if ((GearInventory >= 2) && (SpringInvenory >= 4)){
                GearInventory -= 2;
                SpringInvenory -= 4;
                DolosInventory += 35;
                GearNumUI.text = "Gears = " + GearInventory;
                SpringNumUI.text = "Springs = " + SpringInvenory;
                DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
                NpcWea.SetActive(false);
            }
        }
        else if (other.gameObject.CompareTag("NPCTHR")){
            if ((GearInventory >= 4) && (ScrewInventory >= 4)){
                GearInventory -= 4;
                ScrewInventory -= 4;
                DolosInventory += 35;
                GearNumUI.text = "Gears = " + GearInventory;
                ScrewNumUI.text = "Screws = " + ScrewInventory;
                DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
                NpcThr.SetActive(false);
            }
        }
    }
}
