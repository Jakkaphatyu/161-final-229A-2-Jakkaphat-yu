using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
    public virtual void Cast(Spell spell);
    public void Cast(Spell spell)
    {
     string = spell.ToString();
    }
}