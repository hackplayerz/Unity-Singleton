using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T> {
    static public T Instance { get; private set; }

    private void Awake () {
        if (Instance == null) {
            Instance = (T) this;
            OnAwake ();
        } else {
            Destroy (gameObject);
        }
    }
    private void Start () {
        if (Instance == (T) this) {
            OnStart ();
        }
    }
    
    /// <summary>
    /// Dont Use Awake()
    /// </summary>
    virtual protected void OnAwake () {
        
    }
    /// <summary>
    /// Dont Use Start()
    /// </summary>
    virtual protected void OnStart () {

    }
}
