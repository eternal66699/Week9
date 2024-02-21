using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    private static EventsManager instance;
    public static EventsManager Instance { get { return instance; } }
    public delegate void PortalEvent();
    public static event PortalEvent OnKnifePortal = delegate { };
    public static event PortalEvent OnAxePortal = delegate { };
    public static event PortalEvent OnplusOnePortal = delegate { };
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void KnifePortal()
    {
        OnKnifePortal?.Invoke();
    }
    public void AxePortal()
    {
        OnAxePortal?.Invoke();
    }
    public void PlusOnePortal()
    {
        OnplusOnePortal?.Invoke();
    }
}
