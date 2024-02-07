using System;

  //Seventeen Days: Text Edition
  //Rylei Mindrum
  //Text-Based survival RPG taking place in an abandoned hospital. The player must find their way out without dying or going insane. They face a series of obsticals and only have a set amount of time to escape.  

class MainClass 
{

    //method here

  public static void Main (string[] args) 
  {

      int health = 17;
        bool isAlive = health > 0;
      string characterName = "Jay";
      double money = 17.00;
      int endurance = 17; 

    Print("You wake up in a dark room, your eyes haven't adjusted leaving you almost blind. You lie on the floor waiting for your vision to adjust but it never does.");
    Print("");
    Print("You start to feel around the room, you move until your hand hits something. A flashlight!");
    Print("");
    Print("You try and flip the flashlight on but nothing happens.");
    Print(" ");
    Print("How will you navigate this darkness?");
    Print("How will you escape?");
    Print("What else is in the darkness with you?");
    Print("Do you have the courage to find out?");
    Print(" ");
    Print("Your health " + health);
    Print("Your name " + characterName);
    Print("Your money " + money);
    Print("Your endurance: " + endurance);
    Print("You're alive? " + isAlive);

    Print(" ");
    Print("What type of defense do you prefer? (ie. shield, none, armour, ect.)");
    string defense = Console.ReadLine();
    Print("Suddenly (a(n)) " + defense + " appears next to you!");
    Print(" ");
   
    //Character Attributes
      //1. Name
      //2. Health Points
      //3. Alive or Dead
      //4. Money
      //5. Endurance Tracker
   
    //methods - comparmentalize and re-use code inside a code
    StartScene1();
    StartScene2();

        Print("You aim the flashlight and look around. On your left you see an open door leading to a staircase. On your right you see shelves and boxes with old hospital equipment. Which direction should you travel?");

    string response = Input("Explore to the (r)ight? or the (l)eft?", "R", "L");

    if (response.Equals("l"))
    {
      Print(" ");
      Print("You walk towards the staricase. One you get there you see a trail of blood leading up the stairs. You reach out and touch it and it is still warm. Fresh Blood. You make your way up the stairs trying to avoid the blood.");
      Print("How much endurance will you use to avoid the blood (1-17)? ");

      string enduranceRaw = Console.ReadLine();
      int enduranceSpent = Convert.ToInt32(enduranceRaw);
      endurance -= enduranceSpent;
      Print("You have " + endurance + " endurance remaining.");

    }
    else
    {
      Print(" ");
      Print("You walk towards the shelves. Once you get there you look into the boxes and see that they are sparkling clean. You touch a stethascope and can feel the most texture of santizer.");
    }
    static bool battle(string enemy, int enemyHealth)
    {
      Print("You go to battle against " + enemy + " (" + enemyHealth + ")");

      Random random = new Random();
      bool victory = Convert.ToBoolean(random.Next(2));
      Print("Victory" + victory);

      return victory;
    }

    
    
  }

    //method here

  public static void Print(string text)
  {
    //used inplace of a specific start of a line of code. Console.WriteLine -> Print 
    //ex line 48
    Console.WriteLine(text);
  }

  public static void StartScene1()
  {
   //where the code is built however it is not used until it is put into the Main...
     Print("Scene 1");

     Print("To the right is darkness with a smooth floor; to the left is darkness with a rough floor.");
     string response = Input("Explore to the (r)ight? or the (l)eft?", "R", "L");
    /*string response = Input("Go to the (c)ave, or the (l)ake?", "C", "L");
       */ 
    if (response.Equals("r")) 
    {
      Print(" ");
      Print("You go to the right... and an anvil falls on your head"); 
      Print("You get knocked out and wake up to feel batteries next to you. You place them into your flashlight.");
      Print(" ");
      
      /*
      health *= 0;
      Print("Your health: " + health);
      */
    }     
    else 
    {
      Print("You go to the left and find batteries!");
       
      string octo = Input("Should you put the batteries in the flashlight (f) or throw them into the darkness (t) ?", "F", "T");
      if (octo.Equals("f")) 
      {
        Print("Your flashlight turns on!");
        Print(" ");
      }
      else 
      {
        Print("Congrats, you accomplished nothing and are still in darkness.");
        Print(" ");
        Print("You reach next to you and grasp the batteries again because you suck at throwing and place them into your flashlight.");
        Print(" ");
      }
    }
  }
    
       /*
       else if (response.Equals("1")) {
         Print("you go to the right... and an anvil falls on your head.);
      */

  public static void StartScene2()
  {
    Print("Scene 2");
  }
  
  //used to validate text that the player puts in

  public static string Input(string text, string option1, string option2) 
  {
    bool valid;
    string response;

    do  
    {
      Print("\r\n" + text + " (" + option1 + ", " + option2 +"): ");
      response = Console.ReadLine (). ToLower();
      valid = response.Equals(option1.ToLower()) || response.Equals(option2.ToLower());

      if (!valid)
        Print("That is not a valid response.");
    } while(!valid);
    
    return response;
  }
}
