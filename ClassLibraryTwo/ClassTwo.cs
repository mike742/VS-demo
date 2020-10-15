using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryOne;

namespace ClassLibraryTwo
{
    class ClassTwo : ClassOne
    {
        public void Print()
        {
            ClassOne c1 = new ClassOne();
            Console.WriteLine( base._id  );

            DDD();
        }
    }
}
