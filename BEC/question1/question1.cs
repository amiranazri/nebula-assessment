using System;

class firstQuestion {

   static void Main(String[] args) {
      for(int i = 1; i <= 100; i++) {

         if((i % 2 == 0) && (i % 4 == 0))
         Console.WriteLine("Stack Overflow!\n");
         else if(i % 2 == 0)
         Console.WriteLine("Stack\n");
         else if(i % 4 == 0)
         Console.WriteLine("Overflow\n");
         else
         Console.WriteLine("The string is not a multiple of 2 or 4. \n");
      }
   }
}