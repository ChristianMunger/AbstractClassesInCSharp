using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesInCSharp
{
    // using abstract we allow the classes that inherit to still be instantiated and access methods inside this base class
    // but now this class cannot be instantiated like DataAccess da = new DataAccess();
    public abstract class DataAccess
    {
        // this is a base class
        // instead of having this same method in both sqlitedataaccess and sqldataaccess we can store it here
        // then inherit this class in other classes where this method would be used
        // virtual keyword gives the option to override but don't have to... abstract forces to override and implement method
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        // abstract classes are kinda like a blend between interfaces and base classes
        // you just have the option to override abstract methods and implement own logic in classes that inherit class
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }

    // using abstract classes too much can end up messy when trying to connect things with inheritance
    // so stick to "is a" relationship
    // if there isn't this relationship just use helper methods or play around w/ access modifiers like internal/public/private/protected to limit access
}
