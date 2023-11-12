using System.Xml;

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int firstStart = start / 1000;
int firstEnd = end / 1000;

int secondStart = start / 100%10;
int secondEnd = end / 100%10;

int thirdStart = start / 10 % 10;
int thirdEnd = end / 10 % 10;

int fourthStart= start / 10;
int fourthEnd = end / 10;

for (int first = firstStart; first <= firstEnd; first++)
{
    if (first % 2 == 0)
    
     continue;
    
    for (int second = secondStart; second <= secondEnd; second++)
    {
        if (second % 2 == 0)
        
            continue;
        for (int third = thirdStart; third <= thirdEnd; third++)
        
         if (third % 2 == 0) 
                continue;
        for (int fourth = fourthStart; fourth <= fourthEnd; fourth++)
        { 
          if (fourth  % 2 == 0) 
                continue;
            Console.Write($"{first}{second}{third}{fourth} ");

        }
        
        
    }
    
}
