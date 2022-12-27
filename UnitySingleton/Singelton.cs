namespace UnitySingleton
{
    using UnityEngine;


#nullable enable
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static readonly Lazy<T> _instance =
            new Lazy<T>(() =>
            {
                T instance = FindObjectOfType(typeof(T)) as T;

                if (instance == null)
                {
                    GameObject obj = new GameObject("GameManager");
                    instance = obj.AddComponent(typeof(T)) as T;
                }

                return instance;
            });

        public static T Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}