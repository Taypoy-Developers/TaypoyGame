using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class MainMenu_playtest
    {
        
        [UnityTest]
        public IEnumerator StartGame()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            var GameObject = new GameObject();
            //MainMenu main= new MainMenu();
            //main.PlayGame();
            MainMenu main= new MainMenu();
            main.PlayGame();
            yield return new WaitForSeconds(2.0f);
            //String actual = SceneManager.GetActiveScene().name 
            string expected = "Nivel1";
            string actual = SceneManager.GetActiveScene().name;
            
            Debug.Log(SceneManager.GetActiveScene().name);
            Assert.AreEqual( expected, actual);
        }
        [UnityTest]
        public IEnumerator QuitGame()
        {
            var GameObject = new GameObject();
            MainMenu main = new MainMenu();
            main.QuitGame();
            yield return new WaitForSeconds(2.0f);
            Assert.True(main == null);
            Debug.Log("Game over");
        }
    }
}
