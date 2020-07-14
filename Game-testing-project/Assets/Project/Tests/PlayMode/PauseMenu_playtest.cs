using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using System.Windows;

namespace Tests
{
    public class PauseMenu_playtest
    {
        [UnityTest]
        public IEnumerator PauseGame()
        {
            var gameObject = new GameObject();
            
            
            Scene s = SceneManager.GetSceneByName("Scene1");
            var canvas = GameObject.Find("Canvas_lvl1");
            //SceneManager.SetActiveScene(s);
            
            var pauseMenu = new PauseMenu();
            pauseMenu.pauseMenuUI = GameObject.Find("PauseMenu_lvl1");
            
            //pauseMenu.Pause();
            Debug.Log("funciona");
            //pauseMenu.Resume();
            


            
            
            yield return new WaitForSeconds(5);
            AfterEveryTest();

        }
        [TearDown]
        public void AfterEveryTest()
        {
            foreach (var gameObject in GameObject.FindGameObjectsWithTag("PauseMenu"))
                Object.Destroy(gameObject)
            ;


        }
        [UnityTest]
        public IEnumerator ContinueGame()
        {
            
            PauseMenu pauseMenu = new PauseMenu();
            Debug.Log(PauseMenu.GameIsPaused);
            //pauseMenu.Pause();
            //pauseMenu.Resume();
            yield return new WaitForSeconds(2.0f);
            //Assert.True( Time.timeScale == 1f );
            //Assert.True( !PauseMenu.GameIsPaused );
            //Assert.True(pauseMenu.pauseMenuUI.activeSelf == false);
            //Debug.Log("test");
            AfterEveryTest(); 
        }
        [UnityTest]
        public IEnumerator LoadMainMenu()
        {
            var GameObject = new GameObject();
            PauseMenu pauseMenu = new PauseMenu();
            pauseMenu.LoadMenu();
            yield return null;
            string expected = "Menu1";
            string actual = SceneManager.GetActiveScene().name;
            Assert.AreEqual( expected, actual);
            
            AfterEveryTest();
        }
        [UnityTest]
        public IEnumerator QuitGame()
        {
            var GameObject = new GameObject();
            PauseMenu pauseMenu = new PauseMenu();
            pauseMenu.QuitGame();
            yield return new WaitForSeconds(2.0f);
            Assert.True(pauseMenu==null);
            AfterEveryTest();
        }
        
    }
}
