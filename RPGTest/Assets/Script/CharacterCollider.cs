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
            ScrewNumUI.text = "Springs = " + ScrewInventory;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("NPC"))
        {
            if ((GearInventory >= 3) && (SpringInvenory >= 4)){
                GearInventory -= 3;
                SpringInvenory -= 4;
                DolosInventory += 20;
                GearNumUI.text = "Gears = " + GearInventory;
                SpringNumUI.text = "Springs = " + SpringInvenory;
                DolosNumUI.text = "$ Dolos = $ " + DolosInventory;
            }
        }
    }
}
