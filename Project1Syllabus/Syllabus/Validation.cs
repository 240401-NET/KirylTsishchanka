namespace Project1Syllabus;

public class Validation 
{

    
    
    public static int userChoiceToInt()  
    {
        
        int userCh=-1;

        while(userCh==-1)
        {
        
            try{
            userCh=Convert.ToInt32(Console.ReadLine());
        } catch(Exception){
            Console.WriteLine("Entry was invalid. Please try again!");
        }


        }

        return userCh;
        
    }


    
    public static double userChoiceToDouble()  
    {
        
        double userCh=-1;

        while(userCh==-1)
        {
        
            try{
            userCh= Convert.ToDouble(Console.ReadLine());
        } catch(Exception){
            Console.WriteLine("Entry was invalid. Please try again!");
        }


        }

        return userCh;
        
    }






    public static double userChoiceCheck()
    {
        
        double userCh=-1;

        while(userCh==-1)
        {
        userCh=userChoiceToDouble();
        if(userCh<0 || userCh>100)
            {
            Console.WriteLine("Please enter the number between 0 and 100."); 
            userCh=-1;
            }
        }

        return userCh;
        
    }

}