using UnityEngine;

namespace Packages.Estenis.ScriptableObjectsData_
{
    
    public abstract class BaseSOData<T> : ScriptableObject
    {
        public T Data;
    }
}
