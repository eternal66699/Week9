using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalUpdateManager : MonoBehaviour
{
    public List<GameObject> Weapons = new();
    private int activeIndex;
    public GameObject Axe, Knife;

    private void OnEnable()
    {
        EventsManager.OnAxePortal += AxeEnabled;
        EventsManager.OnKnifePortal += KnifeEnabled;
        EventsManager.OnplusOnePortal += PlusOnePlayer;
    }

    private void OnDisable()
    {
        EventsManager.OnAxePortal -= AxeEnabled;
        EventsManager.OnKnifePortal -= KnifeEnabled;
        EventsManager.OnplusOnePortal -= PlusOnePlayer;
    }

    private void KnifeEnabled()
    {
        ToggleObject(0);
        //Knife.SetActive(true);
        //Axe.SetActive(false);
    }

    private void AxeEnabled()
    {
        ToggleObject(1);
        //Axe.SetActive(true);
       //Knife.SetActive(false);
    }

    private void PlusOnePlayer()
    {

    }
    void ToggleObject(int index)
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(i == index?!Weapons[i].activeSelf:false);
        }
        activeIndex = index;
    }
}
