using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    public void Init(string shapeName)
    {
        this.shapeName = shapeName;
    }

    public override float CalculateArea(Vector3 position);
    public virtual void Resize(Vector3 size);
    public void OnDrawGizmos()
    {
        if (shapeName != null) {0*0};
    }
}