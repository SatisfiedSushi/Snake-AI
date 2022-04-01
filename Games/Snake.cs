using System;
using System.Threading; //Thread.Sleep
using System.Text; //For unicode characters
using System.Collections.Generic;  

public class Initialize {

  private int loadingDelay = 2;  //in seconds
  private bool isRunning = false;
  private int[,] border;
  
  int width = 40;
  int height = 33;

  string unicodeBackground = "□";
  string unicodeBorder = "■";
  string unicodeSnake = "▣";
  string unicodeApple = "◉";
  
  public Initialize() {
    Console.Clear();
    Console.WriteLine("Loading Snake");
    Thread.Sleep(loadingDelay * 1000);
    Console.WriteLine("Loaded Snake");
    Thread.Sleep(3000);
    Console.Clear();  
    RenderFrame();
    //Console.WriteLine("□");
    
  }

  private void RenderFrame() {
    string savedOutput = "";
   
    int i;
    int j;
    int k;

    for (i = 0; i < width; i++) {
      savedOutput = savedOutput + unicodeBorder + " ";
    }

    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine(savedOutput);

    savedOutput = "";

    

    for (i = 0; i < (height - 2); i++) {
      
      savedOutput = savedOutput + unicodeBorder;
      
      for (j = 0; j < (width - 2); j++) {
        
        savedOutput = savedOutput + " " + unicodeBackground;
        
      }
      
      savedOutput = savedOutput + " " + unicodeBorder;
      Console.WriteLine(savedOutput);
      savedOutput = "";
      
    }

    for (i = 0; i < width; i++) {
      savedOutput = savedOutput + unicodeBorder + " ";
    }

    Console.WriteLine(savedOutput);
    savedOutput = "";
    
  }

  

  private void SetBorder() {
    int i;
    string savedOutput = "";
    for (i = 0; i < width; i++) {
      
    }
  }
}