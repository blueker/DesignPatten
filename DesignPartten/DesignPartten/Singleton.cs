using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartten
{
    /// <summary>
    /// 单例模式 确保整个应用程序进程中只有一个访问实力
    /// 缺点 会一直存在 不能 gc释放掉
    /// 
    /// </summary>
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
