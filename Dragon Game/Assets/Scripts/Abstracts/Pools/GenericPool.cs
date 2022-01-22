using DragonGame.Combats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

//Havuz sistemi  butun pooler burdan miras alýr
namespace DragonGame.Abstracts.Polls
{
   public abstract class GenericPool<T>: MonoBehaviour where T : Component
    {
        [SerializeField] T[] prefabs;/* Prefab Dizisi*/
        [SerializeField] int countLoop = 5;

        Queue<T> _poolPrefabs = new Queue<T>();/*Prefablarý sýraya koyar*/
        private void Awake()
        {
            SingletonObject();
           
        }
        private void OnEnable()
        {
            GameManager.Instance.OnSceneChanged += ResetAllObjects;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnSceneChanged -= ResetAllObjects;
        }
        private void Start()
        {
            GrowPoolPrefab();
        }

        protected abstract void SingletonObject();/*Sanal Singelton Obje*/

        public T Get()/*Havuzda eleman yoksa havuza eleman ekler ve return eder*/
        {
            if (_poolPrefabs.Count == 0)
            {
                GrowPoolPrefab();
            }
            return _poolPrefabs.Dequeue();
        }
        public abstract void ResetAllObjects();
        

        private void GrowPoolPrefab()/*Havuza eleman ekler*/
        {
            for(int i = 0; i < countLoop; i++)
            {
                T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;/*Tranformu belirler*/
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }
        }
         public void Set(T poolObject)/*Objeleri gizli hale getirir ve havuza ekler*/
        
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }
    }
}

