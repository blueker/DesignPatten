using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartten
{
   public class Singleton
    {
       static readonly Singleton instant = new Singleton();
       public static Singleton Instanse
       {
           get { return instant; }
       }
       private Singleton() { }


       public void publicFunction()
       { 
        
       }
    }
}
