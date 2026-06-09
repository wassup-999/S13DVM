using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BaseEntity))]
public class BuffManager : MonoBehaviour
{
    private List<Buff> activeBuffs = new();
    private BaseEntity baseEntity;
    private void Awake()
    {
        baseEntity = GetComponent<BaseEntity>();
    }
    public void AddBuf(Buff buff)
   {
        buff.Apply(GetComponent<BaseEntity>());
        activeBuffs.Add(buff);
        StartCoroutine(RemoveBuff(buff));
   }

    public IEnumerator RemoveBuff(Buff buff)
    {
        yield return new WaitForSeconds(buff.Duration);

        buff.Remove(baseEntity);
        activeBuffs.Remove(buff);
    }
}
